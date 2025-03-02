using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents an order detail record.
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Gets or sets the unique identifier for the order detail.
        /// </summary>
        [Key]
        public int OrderDetailID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the order.
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the book.
        /// </summary>
        public int BookID { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the book ordered.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the book.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the discount applied to the book.
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the record is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property to the associated order.
        /// </summary>
        //[ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        /// <summary>
        /// Navigation property to the associated book.
        /// </summary>
        //[ForeignKey("BookID")]
        public virtual Book Book { get; set; }
    }
}
