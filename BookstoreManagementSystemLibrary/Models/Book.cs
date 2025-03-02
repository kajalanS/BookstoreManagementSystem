using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a book in the system.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        [Key]
        public int BookID { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the category.
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// Gets or sets the ISBN of the book.
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Gets or sets the price of the book.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity.
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the publisher of the book.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the publication year.
        /// </summary>
        public int PublicationYear { get; set; }

        /// <summary>
        /// Gets or sets the language of the book.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the book is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property to the associated category.
        /// </summary>
        //[ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        /// <summary>
        /// Navigation property for order details that include this book.
        /// </summary>
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// Navigation property for the many-to-many relationship with suppliers.
        /// </summary>
        public virtual ICollection<BookSupplier> BookSuppliers { get; set; }
    }
}
