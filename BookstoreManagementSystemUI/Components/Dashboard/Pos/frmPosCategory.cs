using BookstoreManagementSystemLibrary.Models;

namespace BookstoreManagementSystemUI.Components
{
  /// <summary>
  /// Represents the POS category user control in the bookstore management system.
  /// </summary>
  public partial class frmPosCategory : UserControl
  {
    private bool toggleCategory;
    public Category? SelectCategory { get; protected set; }

    public delegate void ToggleCategory(bool toggle, Category category);
    public ToggleCategory? ToggleCategoryDel { get; set; }

    public frmPosCategory()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Handles the click event of the toggle category button.
    /// Toggles the category selection state and updates the button appearance.
    /// </summary>
    private void btnToggleCategory_Click(object sender, EventArgs e)
    {
      if (SelectCategory != null)
      {
        toggleCategory = !toggleCategory;
        ToggleCategoryDel?.Invoke(toggleCategory, SelectCategory);

        if (toggleCategory)
        {
          SelectToggleButton();
        }
        else
        {
          DeselectToggleButton();
        }
      }
    }

    public void DeselectToggleButton()
    {
      toggleCategory = false;
      btnToggleCategory.HighEmphasis = false;
    }

    public void SelectToggleButton()
    {
      toggleCategory = true;
      btnToggleCategory.HighEmphasis = true;
    }

    /// <summary>
    /// Sets up the category information and updates the toggle button text.
    /// </summary>
    /// <param name="category">The category to be set up.</param>
    public void SetupCategoryInfo(Category category)
    {
      if (category != null)
      {
        this.SelectCategory = category;
        btnToggleCategory.Text = category.CategoryName;
      }
    }
  }
}
