
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Models;

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

        public User? CreateUser(User user)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                context.Users.Add(user);
                context.SaveChanges();

                transaction.Commit();
                return user;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return null;
            }
        }

        public Book? CreateBook(Book book)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                context.Books.Add(book);
                context.SaveChanges();

                transaction.Commit();
                return book;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return null;
            }
        }

        #endregion

    }
}
