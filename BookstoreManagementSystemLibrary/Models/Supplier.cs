using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a supplier.
    /// </summary>
    public class Supplier
    {
        public Supplier()
        {
        }

        public Supplier(string? name, string? email, string? phoneNumber, string? address, bool? isDeleted = false)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            IsDeleted = isDeleted;
        }

        public Supplier(int? supplierId, string? name, string? email, string? phoneNumber, string? address, bool? isDeleted, ICollection<Book>? books) : this(name, email, phoneNumber, address, isDeleted)
        {
            SupplierId = supplierId;
            Books = books;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the supplier.
        /// </summary>
        [Key]
        public required int? SupplierId { get; set; }

        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        public required string? Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the supplier.
        /// </summary>
        public required string? Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the supplier.
        /// </summary>
        public required string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the address of the supplier.
        /// </summary>
        public required string? Address { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the supplier is deleted.
        /// </summary>
        public required bool? IsDeleted { get; set; } = false;

        /// <summary>
        /// Navigation property for the relationship with books.
        /// </summary>
        public virtual ICollection<Book>? Books { get; set; }
    }
}
