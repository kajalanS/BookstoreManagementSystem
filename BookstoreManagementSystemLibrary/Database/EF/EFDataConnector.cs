
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary.Services;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagementSystemLibrary.Database.EF
{
    public class EFDataConnector : IDataConnector
    {
        #region Property

        private readonly EFDBContext context;
        protected readonly EFConnectionType connectionType;
        protected readonly Dictionary<EFConnectionType, string> connectionStringList = [];

        public EFDBContext Context { get => context; }

        #endregion

        #region Core

        public EFDataConnector(EFConnectionType connectionType, Dictionary<EFConnectionType, string> connectionStringList)
        {
            if (connectionStringList is null)
            {
                throw new ArgumentNullException(nameof(connectionStringList));
            }

            context = new EFDBContext();
            context.SetConnectionType(connectionType);
            context.SetConnectionList(connectionStringList);

            this.connectionType = connectionType;
            this.connectionStringList = connectionStringList;
        }

        #endregion

        #region DataConnector

        public Result<User> CreateUser(User user)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                context.Users.Add(user);
                context.SaveChanges();

                transaction.Commit();
                return new Result<User>(Data: user);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<User>(Message: "User not create");
            }
        }

        public Result<Book> CreateBook(Book book)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                context.Books.Add(book);
                context.SaveChanges();

                transaction.Commit();
                return new Result<Book>(Data: book);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<Book>(Message: "Fail to create the book");
            }
        }

        public Result<User> FindUserByUsername(string username)
        {
            try
            {
                var findUser = context.Users
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

        public Result<List<Book>> FindBook(string name)
        {
            try
            {

                var findBook = context.Books
                    .Where(u => u.Title.Contains(name))
                    .Where(x => x.IsDeleted == false);

                if (!findBook.Any())
                {
                    return new Result<List<Book>>(Message: "book not found");
                }

                return new Result<List<Book>>(Data: [.. findBook]);
            }
            catch (Exception)
            {
                return new Result<List<Book>>(Message: "Fail to find the book");
            }
        }

        public Result<List<Book>> GetAllBooks()
        {
            try
            {
                var findBook = context.Books
                    .Where(x => x.IsDeleted == false);

                if (!findBook.Any())
                {
                    return new Result<List<Book>>(Message: "book not found");
                }

                return new Result<List<Book>>(Data: [.. findBook]);
            }
            catch (Exception e)
            {

                return new Result<List<Book>>(Message: "Fail to find the book");
            }
        }

        public Result<Category> CreateCategory(Category category)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                context.Categories.Add(category);
                context.SaveChanges();

                transaction.Commit();
                return new Result<Category>(Data: category);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<Category>(Message: "Fail to create the category");
            }
        }

        public Result<Category> FindCategory(string name)
        {
            try
            {
                var findCategory = context.Categories
                    .Where(u => u.CategoryName == name)
                    .Where(x => x.IsDeleted == false);

                if (!findCategory.Any())
                {
                    return new Result<Category>(Message: "Category not found");
                }

                return new Result<Category>(Data: findCategory.FirstOrDefault());
            }
            catch (Exception)
            {
                return new Result<Category>(Message: "Fail to find the Category");
            }
        }

        public Result<List<Category>> GetAllCategories()
        {
            try
            {
                var findCategory = context.Categories.Where(x => x.IsDeleted == false);

                if (!findCategory.Any())
                {
                    return new Result<List<Category>>(Message: "Category not found");
                }

                return new Result<List<Category>>(Data: [.. findCategory]);
            }
            catch (Exception e)
            {

                return new Result<List<Category>>(Message: "Fail to find the Category");
            }
        }

        public Task<Result<User>> ResetPasswordAsync(string email, string salt)
        {
            try
            {
                var findUser = context.Users
                    .Where(u => u.Email == email)
                    .Where(x => x.IsDeleted == false);
                var user = findUser.FirstOrDefault();

                if (user == null || user.Email == null)
                {
                    return Task.FromResult(new Result<User>(Message: "loginUser not found"));
                }


                //var newPassword = PasswordGenerator.GenerateRandomPassword(10);
                var newPassword = 10.GenerateRandomPassword();

                Dictionary<EmailTemplatePlaceHolder, string> dataMapper = new()
                {
                    {EmailTemplatePlaceHolder.Username,user.Username! },
                    {EmailTemplatePlaceHolder.Password,newPassword },
                };

                //await Task.Run(async () =>
                //{
                //    await loginUser.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
                //});

                Thread thread = new(() =>
                {
                    Task task = user.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
                });

                thread.Start();


                user.PasswordHash = newPassword.GetHash(salt);
                context.Users.Update(user);
                context.SaveChanges();


                return Task.FromResult(new Result<User>(Data: user));
            }
            catch (Exception)
            {
                return Task.FromResult(new Result<User>(Message: "Fail to find the loginUser"));
            }
        }

        public Result<User> TriggerLogin(string username)
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var loginUser = context.Users
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

        public Result<DashboardDataResult> GetDashboardData()
        {
            try
            {
                var totalBookCount = context.Books
                                    ?.Where(x => x.IsDeleted == false)
                                    ?.Count();
                var totalSuppliersCount = context.Suppliers
                    ?.Where(x => x.IsDeleted == false)
                    ?.Count();
                var totalOrderList = context.Orders
                                    ?.Where(x => x.IsDeleted == false)
                                    ?.Count();
                var totalIncome = context.OrderDetails
                                    .Where(x => x.IsDeleted == false)
                                    ?.Select(x => x.CalculatePrice())
                                    ?.ToList()
                                    ?.Sum();

                DashboardDataResult result = new()
                {
                    TotalBooks = totalBookCount ?? 0,
                    TotalSuppliers = totalSuppliersCount ?? 0,
                    TotalOrder = totalOrderList ?? 0,
                    TotalIncome = totalIncome ?? 0,
                };

                return new Result<DashboardDataResult>(Data: result);
            }
            catch (Exception e)
            {
                return new Result<DashboardDataResult>(Message: "Fail to find the book");
            }
        }

        #endregion

    }
}
