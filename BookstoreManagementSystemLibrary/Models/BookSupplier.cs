using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents the many-to-many relationship between a book and a supplier.
    /// </summary>
    public class BookSupplier
    {
        /// <summary>
        /// Gets or sets the foreign key to the book.
        /// </summary>
        [Key]
        public int BookID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the supplier.
        /// </summary>
        public int SupplierID { get; set; }

        /// <summary>
        /// Navigation property to the associated book.
        /// </summary>
        //[ForeignKey("BookID")]
        public virtual Book Book { get; set; }

        /// <summary>
        /// Navigation property to the associated supplier.
        /// </summary>
        //[ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
    }
}
