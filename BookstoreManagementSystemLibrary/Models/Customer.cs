using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a customer.
    /// </summary>
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string name, string email, string? phoneNumber, string? address, bool isDeleted = false)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            IsDeleted = isDeleted;
        }

        public Customer(int customerId, string name, string email, string? phoneNumber, string? address, bool isDeleted, ICollection<Order>? orders) : this(name, email, phoneNumber, address, isDeleted)
        {
            CustomerId = customerId;
            Orders = orders;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        [Key]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the customer.
        /// </summary>
        public required string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the customer.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the address of the customer.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer is deleted.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Navigation property for orders placed by the customer.
        /// </summary>
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
