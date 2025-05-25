using BookstoreManagementSystemLibrary.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementSystemUI.Forms
{
    public partial class frmCreateBook : MaterialForm
    {
        private List<Category>? categories;

        public frmCreateBook()
        {
            InitializeComponent();
        }

        public void SetCategory(List<Category>? categoryList)
        {
            categories = categoryList;
            frmCreateBookModel1.LoadCategories(categories);
        }
    }
}
