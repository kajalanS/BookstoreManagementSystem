using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a system setting.
    /// </summary>
    public class SystemSetting
    {
        /// <summary>
        /// Gets or sets the unique identifier for the setting.
        /// </summary>
        [Key]
        public int SettingID { get; set; }

        /// <summary>
        /// Gets or sets the name of the setting.
        /// </summary>
        public string SettingName { get; set; }

        /// <summary>
        /// Gets or sets the value of the setting.
        /// </summary>
        public string SettingValue { get; set; }

        /// <summary>
        /// Gets or sets the description of the setting.
        /// </summary>
        public string Description { get; set; }
    }
}
