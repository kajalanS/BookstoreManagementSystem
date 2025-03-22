using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Models;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
    public partial class EFDataConnector : IDataConnector
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

        public Result<bool> CheckConnection()
        {
            try
            {
                var findUser = context.Users.ToList().FirstOrDefault();
                return new Result<bool>(Data: true);
            }
            catch (Exception)
            {
                return new Result<bool>(Data:false);
            }
        }
        #endregion
    }
}
