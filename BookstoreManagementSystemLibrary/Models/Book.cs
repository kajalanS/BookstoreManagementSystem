using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a book in the system.
    /// </summary>
    public class Book
    {
        public Book()
        {
        }

        public Book(string? title, string? author, string? iSBN, decimal? price, int? stockQuantity, string? publisher, int? publicationYear, string? language, bool? isDeleted = false)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Price = price;
            StockQuantity = stockQuantity;
            Publisher = publisher;
            PublicationYear = publicationYear;
            Language = language;
            IsDeleted = isDeleted;
        }

        public Book(int? bookId, int? categoryId, string? title, string? author, string? iSBN, decimal? price, int? stockQuantity, string? publisher, int? publicationYear, string? language, bool? isDeleted, Category? category, ICollection<OrderDetail>? orderDetails, ICollection<Supplier>? suppliers) : this(title, author, iSBN, price, stockQuantity, publisher, publicationYear, language, isDeleted)
        {
            BookId = bookId;
            CategoryId = categoryId;
            Category = category;
            OrderDetails = orderDetails;
            Suppliers = suppliers;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the book.
        /// </summary>
        [Key]
        public int? BookId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the category.
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public required string? Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public required string? Author { get; set; }

        /// <summary>
        /// Gets or sets the ISBN of the book.
        /// </summary>
        public required string? ISBN { get; set; }

        /// <summary>
        /// Gets or sets the price of the book.
        /// </summary>
        public required decimal? Price { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity.
        /// </summary>
        public required int? StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the publisher of the book.
        /// </summary>
        public required string? Publisher { get; set; }

        /// <summary>
        /// Gets or sets the publication year.
        /// </summary>
        public required int? PublicationYear { get; set; }

        /// <summary>
        /// Gets or sets the language of the book.
        /// </summary>
        public required string? Language { get; set; }

        /// <summary>
        /// Gets or sets the image of the book.
        /// </summary>
        public required byte[]? Image { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the book is deleted.
        /// </summary>
        public required bool? IsDeleted { get; set; } = false;

        /// <summary>
        /// Navigation property to the associated category.
        /// </summary>
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        /// <summary>
        /// Navigation property for order details that include this book.
        /// </summary>
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

        /// <summary>
        /// Navigation property for the many-to-many relationship with suppliers.
        /// </summary>
        public virtual ICollection<Supplier>? Suppliers { get; set; }
    }
}
