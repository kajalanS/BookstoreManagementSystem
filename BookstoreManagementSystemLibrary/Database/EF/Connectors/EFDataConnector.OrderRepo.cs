using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary.Services;
using Microsoft.EntityFrameworkCore;
using BookstoreManagementSystemLibrary.Database.Core;

namespace BookstoreManagementSystemLibrary.Database.EF.Connectors
{
    public partial class EFDataConnector : IOrderRepo
    {
        public Result<Order> CreateOrder(Order order)
        {
            using var transaction = context.Database.BeginTransaction();

            try
            {
                var user = context.Users.Find(order.UserId);

                if (user == null)
                {
                    transaction.Rollback();
                    return new Result<Order>(Message: "User not found with the given UserId.");
                }

                order.UserId = user.UserId;

                // Ensure OrderDetails is initialized
                if (order.OrderDetails == null)
                {
                    order.OrderDetails = [];
                }
                else
                {
                    order.OrderDetails = [.. order.OrderDetails];
                }

                if (order.OrderType == Core.Enum.OrderType.Regular && order.OrderStatus == Core.Enum.OrderStatus.Completed)
                {
                    foreach (var item in order.OrderDetails)
                    {
                        var bookData = context.Books.Where(x => x.BookId == item.BookId).FirstOrDefault();
                        if (bookData == null) continue;
                        int currentQuantity = bookData.StockQuantity ?? 0;
                        bookData.StockQuantity = Math.Max(0, (currentQuantity - item.Quantity));
                        context.Books.Update(bookData);
                    }
                }

                //// Attach OrderDetails to the Order (no need to manually set EntityState)
                //foreach (var detail in order.OrderDetails)
                //{
                //    // Ensure OrderId is set properly
                //    detail.OrderId = order.OrderId;
                //}

                context.Orders.Add(order);
                context.SaveChanges();
                transaction.Commit();
                var subTotal = order.OrderDetails.Select(x => x.CalculatePrice()).Sum();
                var discount = order.OrderDetails.Select(x => x.Discount).Sum() ?? 0;
                Dictionary<EmailTemplatePlaceHolder, object> dataMapper = new()
                {
                    {EmailTemplatePlaceHolder.Username,user.Username! },
                    {EmailTemplatePlaceHolder.Status,order.OrderStatus },
                    {EmailTemplatePlaceHolder.OrderId,order.OrderId },
                    {EmailTemplatePlaceHolder.SubTotal,subTotal.ToString() },
                    {EmailTemplatePlaceHolder.Discount,discount.ToString() },
                    {EmailTemplatePlaceHolder.Total,order.TotalAmount },
                    {EmailTemplatePlaceHolder.OrderObject,order },
                    {EmailTemplatePlaceHolder.OrderDate,order.OrderDate },
                };

                if (user?.Email != null)
                {
                    Thread thread = new(() =>
                    {
                        Task task = user.Email.SendHtmlEmailAsync("Order Placement", Helpers.EmailTemplateType.OrderComplete, dataMapper);
                    });
                    thread.Start();
                }
                return new Result<Order>(Data: order);
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return new Result<Order>(Message: "Failed to create the order: " + e.Message);
            }
        }

        public Result<Order> FindOrder(int orderId)
        {
            try
            {
                var findOrder = context.Orders
                    //.AsNoTracking()
                    //.Include(o => o.Customer)
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
                    .Include(o => o.User)
                    .Include(o => o.OrderDetails)
                    .Where(x => x.IsDeleted == false);

                if (GlobalConfig.loggedInUser != null && GlobalConfig.loggedInUser.Role == Core.Enum.UserRole.Customer)
                {
                    findOrder = findOrder.Where(x => x.UserId == GlobalConfig.loggedInUser.UserId);
                }

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
                if (order.OrderType == Core.Enum.OrderType.PreOrder && order.OrderStatus == Core.Enum.OrderStatus.Completed)
                {
                    foreach (var item in order.OrderDetails)
                    {
                        var bookData = context.Books.Where(x => x.BookId == item.BookId).FirstOrDefault();
                        if (bookData == null) continue;
                        int currentQuantity = bookData.StockQuantity ?? 0 - item.Quantity;
                        bookData.StockQuantity = Math.Clamp(0, currentQuantity, currentQuantity);
                        context.Books.Update(bookData);
                    }
                }

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
