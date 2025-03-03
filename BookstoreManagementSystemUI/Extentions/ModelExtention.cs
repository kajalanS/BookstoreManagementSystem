using BookstoreManagementSystemLibrary.Models;

namespace BookstoreManagementSystemUI.Extentions
{
    public static class ModelExtention
    {
        public static decimal CalculatePrice(this OrderDetail? orderDetail)
        {
            decimal price = 0;

            if (orderDetail != null && orderDetail.Quantity != null && orderDetail.UnitPrice != null)
            {
                decimal unitPrice = orderDetail.Book?.Price ?? 0;
                decimal quantity = orderDetail.Quantity ?? 0;
                decimal discount = orderDetail.Discount ?? 0;

                price = unitPrice * quantity;
                price -= discount;
                price = Math.Max(price, 0);
            }

            return price;
        }
    }
}
