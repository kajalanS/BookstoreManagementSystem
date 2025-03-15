using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
	public partial class EFDataConnector : IAuditLogRepo
	{

		//public Result<Order> CreateOrder(Order auditLog)
		//{
		//	using var transaction = context.Database.BeginTransaction();

		//	try
		//	{
		//		context.Orders.Add(auditLog);
		//		context.SaveChanges();

		//		transaction.Commit();
		//		return new Result<Order>(Data: auditLog);
		//	}
		//	catch (Exception)
		//	{
		//		transaction.Rollback();
		//		return new Result<Order>(Message: "Fail to create the auditLog");
		//	}
		//}

		//public Result<Order> FindOrder(int orderId)
		//{
		//	try
		//	{
		//		var findAuditLog = context.Orders
		//			.AsNoTracking()
		//			.Include(o => o.Customer)
		//			.Include(o => o.OrderDetails)
		//			.Where(u => u.OrderId == orderId)
		//			.Where(x => x.IsDeleted == false);

		//		if (!findAuditLog.Any())
		//		{
		//			return new Result<Order>(Message: "Order not found");
		//		}

		//		return new Result<Order>(Data: findAuditLog.FirstOrDefault());
		//	}
		//	catch (Exception)
		//	{
		//		return new Result<Order>(Message: "Fail to find the Order");
		//	}
		//}

		//public Result<List<Order>> GetAllOrders()
		//{
		//	try
		//	{
		//		var findAuditLog = context.Orders
		//			.AsNoTracking()
		//			.Include(o => o.Customer)
		//			.Include(o => o.OrderDetails)
		//			.Where(x => x.IsDeleted == false);

		//		if (!findAuditLog.Any())
		//		{
		//			return new Result<List<Order>>(Message: "Order not found");
		//		}

		//		return new Result<List<Order>>(Data: [.. findAuditLog]);
		//	}
		//	catch (Exception e)
		//	{
		//		return new Result<List<Order>>(Message: "Fail to find the Order");
		//	}
		//}

		//public Result<Order> EditOrder(Order auditLog)
		//{
		//	using var transaction = context.Database.BeginTransaction();

		//	try
		//	{
		//		context.Orders.Update(auditLog);
		//		context.SaveChanges();

		//		transaction.Commit();
		//		return new Result<Order>(Data: auditLog, Message: "Order update successful.");
		//	}
		//	catch (Exception)
		//	{
		//		transaction.Rollback();
		//		return new Result<Order>(Message: "Fail to Update the auditLog");
		//	}
		//}

		//public Result<bool> DeleteAuditLog(Order auditLog)
		//{
		//	using var transaction = context.Database.BeginTransaction();

		//	try
		//	{
		//		auditLog.IsDeleted = true;

		//		context.Orders.Update(auditLog);
		//		context.SaveChanges();

		//		transaction.Commit();
		//		return new Result<bool>(Data: true, Message: "Order delete successful.");
		//	}
		//	catch (Exception)
		//	{
		//		transaction.Rollback();
		//		return new Result<bool>(Message: "Fail to Update the auditLog");
		//	}

		//public Result<AuditLog> EditAuditLog(AuditLog auditLog)
		//{
		//	throw new NotImplementedException();
		//}

		public Result<List<AuditLog>> GetAllAuditLog()
		{
			try
			{
				var findAuditLog = context.AuditLogs
					//.AsNoTracking()
					.Include(o => o.User);

				if (!findAuditLog.Any())
				{
					return new Result<List<AuditLog>>(Message: "AuditLog not found");
				}

				return new Result<List<AuditLog>>(Data: [.. findAuditLog]);
			}
			catch (Exception e)
			{
				return new Result<List<AuditLog>>(Message: "Fail to find the AuditLog");
			}
		}
	}
}
