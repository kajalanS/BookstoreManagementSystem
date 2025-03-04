using BookstoreManagementSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementSystemUI.Components
{
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
