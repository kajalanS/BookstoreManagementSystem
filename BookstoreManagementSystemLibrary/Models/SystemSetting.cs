using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a system setting.
    /// </summary>
    public class SystemSetting
    {
        public SystemSetting()
        {
        }

        public SystemSetting(string? settingName, string? settingValue, string? description)
        {
            SettingName = settingName;
            SettingValue = settingValue;
            Description = description;
        }

        public SystemSetting(int? systemSettingId, string? settingName, string? settingValue, string? description) : this(settingName, settingValue, description)
        {
            SystemSettingId = systemSettingId;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the setting.
        /// </summary>
        [Key]
        public required int? SystemSettingId { get; set; }

        /// <summary>
        /// Gets or sets the name of the setting.
        /// </summary>
        public required string? SettingName { get; set; }

        /// <summary>
        /// Gets or sets the value of the setting.
        /// </summary>
        public required string? SettingValue { get; set; }

        /// <summary>
        /// Gets or sets the description of the setting.
        /// </summary>
        public required string? Description { get; set; }
    }
}
