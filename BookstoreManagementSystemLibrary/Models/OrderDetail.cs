using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents an order detail record.
    /// </summary>
    public class OrderDetail
    {
        public OrderDetail()
        {
        }

        public OrderDetail(int quantity, decimal unitPrice, decimal? discount, bool isDeleted = false)
        {
            Quantity = quantity;
            UnitPrice = unitPrice;
            Discount = discount;
            IsDeleted = isDeleted;
        }
        public OrderDetail(int quantity, decimal unitPrice, Order order, Book book, decimal? discount = 0, bool isDeleted = false) : this(quantity, unitPrice, discount, isDeleted)
        {
            Order = order;
            Book = book;
            OrderId = order.OrderId;
            BookId = book.BookId;
        }

        public OrderDetail(int orderDetailId, int orderId, int bookId, int quantity, decimal unitPrice, decimal? discount, bool isDeleted, Order? order, Book? book) : this(quantity, unitPrice, discount, isDeleted)
        {
            OrderDetailId = orderDetailId;
            OrderId = orderId;
            BookId = bookId;
            Order = order;
            Book = book;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the order detail.
        /// </summary>
        [Key]
        public int OrderDetailId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the book.
        /// </summary>
        public required int BookId { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the book ordered.
        /// </summary>
        public required int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the book.
        /// </summary>
        public required decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the discount applied to the book.
        /// </summary>
        public decimal? Discount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the record is deleted.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Navigation property to the associated order.
        /// </summary>
        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }

        /// <summary>
        /// Navigation property to the associated book.
        /// </summary>
        [ForeignKey("BookId")]
        public virtual Book? Book { get; set; }
    }
}
