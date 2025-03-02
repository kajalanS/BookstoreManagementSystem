using BookstoreManagementSystemLibrary.Database.Core.Enum;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a user in the BookHaven Bookstore Management System.
    /// </summary>
    public class User
    {
        public User()
        {
        }

        public User(string? username, string? passwordHash, UserRole? role, string? email, DateTime? lastLogin, UserStatus? status = UserStatus.Active, bool? isDeleted = false)
        {
            Username = username;
            PasswordHash = passwordHash;
            Role = role;
            Email = email;
            LastLogin = lastLogin;
            Status = status;
            IsDeleted = isDeleted;
        }

        public User(int? userId, string? username, string? passwordHash, UserRole? role, string? email, DateTime? lastLogin, UserStatus? status, bool? isDeleted, ICollection<Order>? orders, ICollection<AuditLog>? auditLogs) : this(username, passwordHash, role, email, lastLogin, status, isDeleted)
        {
            UserId = userId;
            Orders = orders;
            AuditLogs = auditLogs;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        [Key]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string? Username { get; set; }

        /// <summary>
        /// Gets or sets the hashed password.
        /// </summary>
        public string? PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the role of the user.
        /// </summary>
        public UserRole? Role { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the last login time.
        /// </summary>
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// Gets or sets the status of the user.
        /// </summary>
        public UserStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is deleted.
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for orders created by the user.
        /// </summary>
        public ICollection<Order>? Orders { get; set; }

        /// <summary>
        /// Navigation property for audit logs created by the user.
        /// </summary>
        public ICollection<AuditLog>? AuditLogs { get; set; }
    }
}
