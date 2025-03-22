using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary.Services;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
    public partial class EFDataConnector : IUserRepo
    {
        public Result<User> CreateUser(User user)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
                transaction.Commit();
                return new Result<User>(Data: user, Message: "User Create Successfully.");
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return new Result<User>(Message: "User not create");
            }
        }

        public Result<bool> DeleteUser(User user)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                user.IsDeleted = true;
                context.Users.Update(user);
                context.SaveChanges();
                transaction.Commit();
                return new Result<bool>(Data: true, Message: "User delete successful.");
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<bool>(Message: "Fail to Update the user");
            }
        }

        public Result<User> FindUserByUsername(string username)
        {
            try
            {
                var findUser = context.Users
                  //.AsNoTracking()
                  .Where(u => u.Username == username)
                  .Where(x => x.IsDeleted == false);
                if (!findUser.Any())
                {
                    return new Result<User>(Message: "loginUser not found");
                }
                return new Result<User>(Data: findUser.FirstOrDefault());
            }
            catch (Exception)
            {
                return new Result<User>(Message: "Fail to find the loginUser");
            }
        }

        public Result<List<User>> GetAllUsers()
        {
            try
            {
                var findUser = context.Users
                  //.AsNoTracking()
                  .Where(x => x.IsDeleted == false);
                if (!findUser.Any())
                {
                    return new Result<List<User>>(Message: "User not found");
                }
                return new Result<List<User>>(Data: [.. findUser]);
            }
            catch (Exception e)
            {
                return new Result<List<User>>(Message: "Fail to find the User");
            }
        }

        public Task<Result<User>> ResetPasswordAsync(string email, string salt)
        {
            try
            {
                var findUser = context.Users
                  //.AsNoTracking()
                  .Where(u => u.Email == email)
                  .Where(x => x.IsDeleted == false);
                var user = findUser.FirstOrDefault();

                if (user == null || user.Email == null)
                {
                    return Task.FromResult(new Result<User>(Message: "loginUser not found"));
                }
                var newPassword = 10.GenerateRandomPassword();

                Dictionary<EmailTemplatePlaceHolder, object> dataMapper = new()
        {
          {EmailTemplatePlaceHolder.Username,user.Username! },
          {EmailTemplatePlaceHolder.Password,newPassword },
        };

                Thread thread = new(() =>
                {
                    Task task = user.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
                });
                thread.Start();
                user.PasswordHash = newPassword.GetHash(salt);
                context.Users.Update(user);
                context.SaveChanges();
                return Task.FromResult(new Result<User>(Data: user, Message: "Password Reset Successfully."));
            }
            catch (Exception)
            {
                return Task.FromResult(new Result<User>(Message: "Fail to find the loginUser"));
            }
        }

        public Task<Result<User>> ResetPasswordAsync(User userData, string salt)
        {
            try
            {
                var findUser = context.Users
                  //.AsNoTracking()
                  .Where(u => u.UserId == userData.UserId)
                  .Where(x => x.IsDeleted == false);
                var user = findUser.FirstOrDefault();
                if (user == null || user.Email == null)
                {
                    return Task.FromResult(new Result<User>(Message: "loginUser not found"));
                }
                return SendResetPasswordMail(salt, user);
            }
            catch (Exception)
            {
                return Task.FromResult(new Result<User>(Message: "Fail to find the loginUser"));
            }
        }

        private Task<Result<User>> SendResetPasswordMail(string salt, User user)
        {
            var newPassword = 10.GenerateRandomPassword();
            Dictionary<EmailTemplatePlaceHolder, object> dataMapper = new()
              {
                {EmailTemplatePlaceHolder.Username,user.Username! },
                {EmailTemplatePlaceHolder.Password,newPassword },
              };
            Task task = user.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
            user.PasswordHash = newPassword.GetHash(salt);
            context.Users.Update(user);
            context.SaveChanges();
            return Task.FromResult(new Result<User>(Data: user, Message: "Password Reset successfull."));
        }

        public Result<User> TriggerLogin(string username)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var loginUser = context.Users
                  //.AsNoTracking()
                  .Where(x => x.Username == username)
                  .Where(x => x.IsDeleted == false)
                  .FirstOrDefault();
                if (loginUser == null)
                {
                    return new Result<User>(Message: "Category not found");
                }
                loginUser.LastLogin = DateTime.Now;
                context.Users.Update(loginUser);
                context.SaveChanges();
                transaction.Commit();
                return new Result<User>(Data: loginUser);
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return new Result<User>(Message: "Fail to login the loginUser");
            }
        }

        public Result<User> UpdateUserProfile(User user)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Users.Update(user);
                context.SaveChanges();
                transaction.Commit();
                return new Result<User>(Data: user, Message: "User update successful.");
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<User>(Message: "Fail to Update the User");
            }
        }
    }
}
