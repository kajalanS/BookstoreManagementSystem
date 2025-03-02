using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        [Key]
        public int OrderID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key for the customer placing the order.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key for the user who created the order.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the date the order was placed.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the total amount of the order.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        public string OrderStatus { get; set; }

        /// <summary>
        /// Gets or sets the method used for order delivery.
        /// </summary>
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets the payment method used for the order.
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the payment status of the order.
        /// </summary>
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Gets or sets the type of the order.
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property to the associated customer.
        /// </summary>
        //[ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Navigation property to the associated user.
        /// </summary>
        //[ForeignKey("UserID")]
        public virtual User User { get; set; }

        /// <summary>
        /// Navigation property for the order details.
        /// </summary>
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// Navigation property for the receipt generated for this order.
        /// </summary>
        public virtual Receipt Receipt { get; set; }
    }
}
