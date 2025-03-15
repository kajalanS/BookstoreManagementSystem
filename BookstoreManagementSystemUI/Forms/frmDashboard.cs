using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Components;
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
    public partial class frmDashboard : MaterialForm
    {
        #region Delegates

        public delegate void LoadCategory(List<Category>? category);
        public delegate void LoadBooks(List<Book>? books);

        public static LoadCategory? LoadCategoriesList { get; set; }
        public static LoadBooks? LoadBooksList { get; set; }

        #endregion



        #region Property
        public frmLogin FrmLogin { get; }


        private TabPage selectedPage;


        protected Dictionary<Book, OrderDetail>? OrderDetailList = [];


        public List<Book>? BookList { get; protected set; }
        public List<Category>? CategoryList { get; protected set; }

        #endregion

        #region Core


        public frmDashboard(frmLogin frmLogin)
        {
            LoadPagesOnLoad();

            InitializeComponent();
            FrmLogin = frmLogin;

            InitPageDataLoad();

            HandleSubscrioption();

        }

        private void InitPageDataLoad()
        {
            frmPosPage1.LoadBooks(BookList);
            frmPosPage1.LoadCategory(CategoryList);
            frmOrderListView.SetUpPage(false);
            frmPreOrderListView.SetUpPage(true);
        }

        private void HandleSubscrioption()
        {
            this.frmPosPage1.ReloadPageDataDel += LoadPagesOnLoad;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin.Show();
        }

        private void mtcRootLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPage = mtcRootLayout.TabPages[mtcRootLayout.SelectedIndex];
            this.Text = selectedPage.Text;
        }

        #endregion


        private void LoadPagesOnLoad()
        {
            GlobalConfig.Process((process, salt) =>
            {
                var bookResult = process.GetAllBooks();

                if (bookResult.Data != null)
                {
                    BookList = bookResult.Data;
                    LoadBooksList?.Invoke(BookList);
                }
                else
                {
                    MaterialMessageBox.Show(bookResult.Message, "Book Load", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }

                var categoryResult = process.GetAllCategories();

                if (categoryResult.Data != null)
                {
                    CategoryList = categoryResult.Data;
                    LoadCategoriesList?.Invoke(CategoryList);
                }
                else
                {
                    MaterialMessageBox.Show(categoryResult.Message, "Book Load", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
            });
        }

    }
}
