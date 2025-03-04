
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary.Services;

namespace BookstoreManagementSystemLibrary.Database.EF
{
    public class EFDataConnector : IDataConnector
    {
        #region Property

        protected readonly EFDBContext context;
        protected readonly EFConnectionType connectionType;
        protected readonly Dictionary<EFConnectionType, string> connectionStringList = [];

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
                return new Result<User>(data: user);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<User>(message: "user not create");
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
                return new Result<Book>(data: book);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<Book>(message: "Fail to create the book");
            }
        }

        public Result<User> FindUserByUsername(string username)
        {
            try
            {
                var findUser = context.Users.Where(u => u.Username == username);

                if (!findUser.Any())
                {
                    return new Result<User>(message: "user not found");
                }

                return new Result<User>(data: findUser.FirstOrDefault());
            }
            catch (Exception)
            {
                return new Result<User>(message: "Fail to find the user");
            }
        }

        public Result<Book> FindBook(string name)
        {
            try
            {
                var findBook = context.Books.Where(u => u.Title == name);

                if (!findBook.Any())
                {
                    return new Result<Book>(message: "book not found");
                }

                return new Result<Book>(data: findBook.FirstOrDefault());
            }
            catch (Exception)
            {
                return new Result<Book>(message: "Fail to find the book");
            }
        }

        public Result<List<Book>> GetAllBooks()
        {
            try
            {
                var findBook = context.Books;

                if (!findBook.Any())
                {
                    return new Result<List<Book>>(message: "book not found");
                }

                return new Result<List<Book>>(data: findBook.ToList());
            }
            catch (Exception e)
            {

                return new Result<List<Book>>(message: "Fail to find the book");
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
                return new Result<Category>(data: category);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return new Result<Category>(message: "Fail to create the category");
            }
        }

        public Result<Category> FindCategory(string name)
        {
            try
            {
                var findCategory = context.Categories.Where(u => u.CategoryName == name);

                if (!findCategory.Any())
                {
                    return new Result<Category>(message: "Category not found");
                }

                return new Result<Category>(data: findCategory.FirstOrDefault());
            }
            catch (Exception)
            {
                return new Result<Category>(message: "Fail to find the Category");
            }
        }

        public Result<List<Category>> GetAllCategories()
        {
            try
            {
                var findCategory = context.Categories;

                if (!findCategory.Any())
                {
                    return new Result<List<Category>>(message: "Category not found");
                }

                return new Result<List<Category>>(data: findCategory.ToList());
            }
            catch (Exception e)
            {

                return new Result<List<Category>>(message: "Fail to find the Category");
            }
        }

        public async Task<Result<User>> ResetPasswordAsync(string email, string salt)
        {
            try
            {
                var findUser = context.Users.Where(u => u.Email == email);
                var user = findUser.FirstOrDefault();

                if (user == null || user.Email == null)
                {
                    return new Result<User>(message: "user not found");
                }


                //var newPassword = PasswordGenerator.GenerateRandomPassword(10);
                var newPassword = 10.GenerateRandomPassword();

                Dictionary<EmailTemplatePlaceHolder, string> dataMapper = new Dictionary<EmailTemplatePlaceHolder, string>
                {
                    {EmailTemplatePlaceHolder.Username,user.Username! },
                    {EmailTemplatePlaceHolder.Password,newPassword },
                };

                //await Task.Run(async () =>
                //{
                //    await user.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
                //});

                Thread thread = new Thread(() =>
                {
                    Task task = user.Email.SendHtmlEmailAsync("Password Reset", EmailTemplateType.PasswordReset, dataMapper);
                });

                thread.Start();


                user.PasswordHash = newPassword.GetHash(salt);


                return new Result<User>(data: user);
            }
            catch (Exception)
            {
                return new Result<User>(message: "Fail to find the user");
            }
        }

        #endregion

    }
}
