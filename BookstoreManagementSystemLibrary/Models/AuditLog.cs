using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents an audit log entry.
    /// </summary>
    public class AuditLog
    {
        public AuditLog()
        {
        }

        public AuditLog(string? action, DateTime? timestamp, string? description)
        {
            Action = action;
            Timestamp = timestamp;
            Description = description;
        }

        public AuditLog(int logId, int userId, string? action, DateTime? timestamp, string? description, User? user) : this(action, timestamp, description)
        {
            LogId = logId;
            UserId = userId;
            User = user;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the audit log entry.
        /// </summary>
        [Key]
        public int LogId { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the user who performed the action.
        /// </summary>
        public required int UserId { get; set; }

        /// <summary>
        /// Gets or sets the action performed.
        /// </summary>
        public required string? Action { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the action.
        /// </summary>
        public required DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the description of the action.
        /// </summary>
        public required string? Description { get; set; }

        /// <summary>
        /// Navigation property to the user who performed the action.
        /// </summary>
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}
