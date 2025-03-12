using BookstoreManagementSystemLibrary.Models;

namespace BookstoreManagementSystemLibrary.Database.Core
{
    public static class CalculateOrderPrice
    {
        public static decimal CalculatePrice(this OrderDetail? orderDetail)
        {
            decimal price = 0;

            if (orderDetail != null && orderDetail.Book != null && orderDetail.Discount != null)
            {
                decimal unitPrice = orderDetail.Book?.Price ?? 0;
                decimal quantity = orderDetail.Quantity;
                decimal discount = orderDetail.Discount ?? 0;

                price = unitPrice * quantity;
                price -= discount;
                price = Math.Max(price, 0);
            }

            return price;
        }
    }

}
