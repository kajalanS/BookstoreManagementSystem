using BookstoreManagementSystemLibrary.Database.Core.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a receipt for an order.
    /// </summary>
    public class Receipt
    {
        public Receipt()
        {
        }

        public Receipt(DateTime issueDate, decimal totalAmount, PaymentMethod paymentMethod)
        {
            IssueDate = issueDate;
            TotalAmount = totalAmount;
            PaymentMethod = paymentMethod;
        }

        public Receipt(int receiptId, int orderId, DateTime issueDate, decimal totalAmount, PaymentMethod paymentMethod, Order order) : this(issueDate, totalAmount, paymentMethod)
        {
            ReceiptId = receiptId;
            OrderId = orderId;
            Order = order;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the receipt.
        /// </summary>
        [Key]
        public int ReceiptId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the order.
        /// </summary>
        public required int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the issue date of the receipt.
        /// </summary>
        public required DateTime IssueDate { get; set; }

        /// <summary>
        /// Gets or sets the total amount of the receipt.
        /// </summary>
        public required decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the payment method used for the receipt.
        /// </summary>
        public required PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Navigation property to the associated order.
        /// </summary>
        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }
    }
}
