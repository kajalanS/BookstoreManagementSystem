using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a supplier.
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Gets or sets the unique identifier for the supplier.
        /// </summary>
        [Key]
        public int SupplierID { get; set; }

        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the supplier.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the supplier.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the address of the supplier.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the supplier is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for the relationship with books.
        /// </summary>
        public virtual ICollection<BookSupplier> BookSuppliers { get; set; }
    }
}
