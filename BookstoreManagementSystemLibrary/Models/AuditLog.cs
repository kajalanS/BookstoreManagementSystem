using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents an audit log entry.
    /// </summary>
    public class AuditLog
    {
        /// <summary>
        /// Gets or sets the unique identifier for the audit log entry.
        /// </summary>
        [Key]
        public int LogID { get; set; }

        /// <summary>
        /// Gets or sets the foreign key to the user who performed the action.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the action performed.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the action.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the description of the action.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Navigation property to the user who performed the action.
        /// </summary>
        //[ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}
