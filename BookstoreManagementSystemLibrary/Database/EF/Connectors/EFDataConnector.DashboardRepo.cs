using BookstoreManagementSystemLibrary.Database.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
	public partial class EFDataConnector : IDashboardRepo
	{
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
					?.Where(x => x.IsDeleted == false)
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

	}
}
