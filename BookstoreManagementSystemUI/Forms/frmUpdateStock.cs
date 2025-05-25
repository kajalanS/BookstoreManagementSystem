using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Components.Models.Books;
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
    public partial class frmUpdateStock : MaterialForm
    {
        public frmUpdateStock(Book book)
        {
            InitializeComponent();
            frmCreateBookModel1.SetupStockUpdate(book);
        }
    }
}
