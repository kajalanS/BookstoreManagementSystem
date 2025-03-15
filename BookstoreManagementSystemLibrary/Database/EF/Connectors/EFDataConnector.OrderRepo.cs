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
	public partial class EFDataConnector : IOrderRepo
	{

		public Result<Order> CreateOrder(Order order)
		{
			using var transaction = context.Database.BeginTransaction();

			try
			{
				context.Orders.Add(order);
				context.SaveChanges();

				transaction.Commit();
				return new Result<Order>(Data: order);
			}
			catch (Exception)
			{
				transaction.Rollback();
				return new Result<Order>(Message: "Fail to create the order");
			}
		}

		public Result<Order> FindOrder(int orderId)
		{
			try
			{
				var findOrder = context.Orders
					//.AsNoTracking()
					.Include(o => o.Customer)
					.Include(o => o.OrderDetails)
					.Where(u => u.OrderId == orderId)
					.Where(x => x.IsDeleted == false);

				if (!findOrder.Any())
				{
					return new Result<Order>(Message: "Order not found");
				}

				return new Result<Order>(Data: findOrder.FirstOrDefault());
			}
			catch (Exception)
			{
				return new Result<Order>(Message: "Fail to find the Order");
			}
		}

		public Result<List<Order>> GetAllOrders()
		{
			try
			{
				var findOrder = context.Orders
					//.AsNoTracking()
					.Include(o => o.Customer)
					.Include(o => o.OrderDetails)
					.Where(x => x.IsDeleted == false);

				if (!findOrder.Any())
				{
					return new Result<List<Order>>(Message: "Order not found");
				}

				return new Result<List<Order>>(Data: [.. findOrder]);
			}
			catch (Exception e)
			{
				return new Result<List<Order>>(Message: "Fail to find the Order");
			}
		}

		public Result<Order> EditOrder(Order order)
		{
			using var transaction = context.Database.BeginTransaction();

			try
			{
				context.Orders.Update(order);
				context.SaveChanges();

				transaction.Commit();
				return new Result<Order>(Data: order, Message: "Order update successful.");
			}
			catch (Exception)
			{
				transaction.Rollback();
				return new Result<Order>(Message: "Fail to Update the order");
			}
		}

		public Result<bool> DeleteOrder(Order order)
		{
			using var transaction = context.Database.BeginTransaction();

			try
			{
				order.IsDeleted = true;

				context.Orders.Update(order);
				context.SaveChanges();

				transaction.Commit();
				return new Result<bool>(Data: true, Message: "Order delete successful.");
			}
			catch (Exception)
			{
				transaction.Rollback();
				return new Result<bool>(Message: "Fail to Update the order");
			}
		}
	}
}
