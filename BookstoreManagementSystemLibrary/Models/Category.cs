using System.ComponentModel.DataAnnotations;

namespace BookstoreManagementSystemLibrary.Models
{
    /// <summary>
    /// Represents a category for books.
    /// </summary>
    public class Category
    {
        public Category()
        {
        }

        public Category(string? categoryName, string? description, bool? isDeleted = false)
        {
            CategoryName = categoryName;
            Description = description;
            IsDeleted = isDeleted;
        }

        public Category(int categoryId, string? categoryName, string? description, bool? isDeleted, ICollection<Book>? books) : this(categoryName, description, isDeleted)
        {
            CategoryId = categoryId;
            Books = books;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the category.
        /// </summary>
        [Key]
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        public required string? CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the description of the category.
        /// </summary>
        public required string? Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the category is deleted.
        /// </summary>
        public required bool? IsDeleted { get; set; } = false;

        /// <summary>
        /// Navigation property for the books in this category.
        /// </summary>
        public virtual ICollection<Book>? Books { get; set; }
    }
}
