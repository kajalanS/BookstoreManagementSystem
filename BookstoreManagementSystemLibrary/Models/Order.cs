using BookstoreManagementSystemLibrary.Database.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order
    {
        public Order()
        {
        }

        public Order(DateTime orderDate, decimal totalAmount, OrderStatus orderStatus, DeliveryMethod deliveryMethod, PaymentMethod paymentMethod, PaymentStatus paymentStatus, OrderType orderType, bool isDeleted = false)
        {
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            OrderStatus = orderStatus;
            DeliveryMethod = deliveryMethod;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;
            OrderType = orderType;
            IsDeleted = isDeleted;
        }

        public Order(int orderId, int userId, DateTime orderDate, decimal totalAmount, OrderStatus orderStatus, DeliveryMethod deliveryMethod, PaymentMethod paymentMethod, PaymentStatus paymentStatus, OrderType orderType, bool isDeleted, User? user, ICollection<OrderDetail>? orderDetails, Receipt? receipt) : this(orderDate, totalAmount, orderStatus, deliveryMethod, paymentMethod, paymentStatus, orderType, isDeleted)
        {
            OrderId = orderId;
            //CustomerId = customerId;
            UserId = userId;
            //Customer = customer;
            User = user;
            OrderDetails = orderDetails;
            Receipt = receipt;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        [Key]
        public int OrderId { get; set; }

        ///// <summary>
        ///// Gets or sets the foreign key for the customer placing the order.
        ///// </summary>
        //public required int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key for the user who created the order.
        /// </summary>
        public required int UserId { get; set; }

        /// <summary>
        /// Gets or sets the date the order was placed.
        /// </summary>
        public required DateTime OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the total amount of the order.
        /// </summary>
        public required decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        public required OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Gets or sets the method used for order delivery.
        /// </summary>
        public required DeliveryMethod DeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets the payment method used for the order.
        /// </summary>
        public required PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the payment status of the order.
        /// </summary>
        public required PaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// Gets or sets the type of the order.
        /// </summary>
        public required OrderType OrderType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order is deleted.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        ///// <summary>
        ///// Navigation property to the associated customer.
        ///// </summary>
        //[ForeignKey("CustomerId")]
        //public Customer? Customer { get; set; }

        /// <summary>
        /// Navigation property to the associated user.
        /// </summary>
        [ForeignKey("UserId")]
        public User? User { get; set; }

        /// <summary>
        /// Navigation property for the order details.
        /// </summary>
        public ICollection<OrderDetail>? OrderDetails { get; set; }

        /// <summary>
        /// Navigation property for the receipt generated for this order.
        /// </summary>
        public Receipt? Receipt { get; set; }
    }
}
