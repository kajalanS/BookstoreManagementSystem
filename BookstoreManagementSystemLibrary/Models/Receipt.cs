using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a receipt for an order.
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// Gets or sets the unique identifier for the receipt.
        /// </summary>
        [Key]
        public int ReceiptID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the order.
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// Gets or sets the issue date of the receipt.
        /// </summary>
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// Gets or sets the total amount of the receipt.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the payment method used for the receipt.
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Navigation property to the associated order.
        /// </summary>
        //[ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
    }
}
