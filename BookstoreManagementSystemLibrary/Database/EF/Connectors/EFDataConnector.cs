using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary.Services;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using EFCategory = BookstoreManagementSystemLibrary.Models.Category;

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

        #endregion

	}
}