using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core.Enum;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Components;
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
    public partial class frmDashboard : MaterialForm
    {
        #region Delegates
        public delegate void LoadCategory(List<Category>? category);
        public delegate void LoadBooks(List<Book>? books);
        public delegate void LoadCustomers(List<User>? customers);
        public static LoadCategory? LoadCategoriesList { get; set; }
        public static LoadBooks? LoadBooksList { get; set; }
        public static LoadCustomers? LoadCustomersList { get; set; }
        #endregion

        #region Property
        public frmLogin FrmLogin { get; }

        private TabPage selectedPage;

        protected Dictionary<Book, OrderDetail>? OrderDetailList = [];

        public List<Book>? BookList { get; protected set; }
        public List<Category>? CategoryList { get; protected set; }
        public List<User>? CustomerList { get; protected set; }

        #endregion

        #region Core


        public frmDashboard(frmLogin frmLogin)
        {
            LoadPagesOnLoad();

            InitializeComponent();

            LoginUserControll();

            FrmLogin = frmLogin;

            InitPageDataLoad();

            HandleSubscrioption();
        }

        private void LoginUserControll()
        {
            var loggedInUser = GlobalConfig.loggedInUser;
            if (loggedInUser == null)
            {
                mtcRootLayout.Visible = false;
                return;
            }
            ConfigLayout(loggedInUser.Role);
        }

        private void ConfigLayout(UserRole role)
        {
            ResetLayout();
            if (role == UserRole.Admin)
            {
                ToggleTapPage(tpDashboard, true);
                ToggleTapPage(tpPOS, true);
                ToggleTapPage(tpOrderList, true);
                ToggleTapPage(tpPreBooking, true);
                ToggleTapPage(tpBookList, true);
                ToggleTapPage(tpSupplierList, true);
                ToggleTapPage(tpUserList, true);
                ToggleTapPage(tpProfile, true);
                ToggleTapPage(tpActivityLog, true);
                // ToggleTapPage(tpGeneral, true);
            }
            else if (role == UserRole.Employee)
            {
                ToggleTapPage(tpDashboard, true);
                ToggleTapPage(tpPOS, true);
                ToggleTapPage(tpOrderList, true);
                ToggleTapPage(tpPreBooking, true);
                ToggleTapPage(tpProfile, true);
                ToggleTapPage(tpBookList, true);
                ToggleTapPage(tpActivityLog, true);
                // ToggleTapPage(tpGeneral, true);
                // ToggleTapPage(tpSupplierList, true);
                // ToggleTapPage(tpUserList, true);
            }
            else if (role == UserRole.Customer)
            {
                ToggleTapPage(tpOrderList, true);
                ToggleTapPage(tpPreBooking, true);
                ToggleTapPage(tpBookList, true);
                ToggleTapPage(tpProfile, true);
            }
            else
            {
                ToggleTapPage(tpNoAccess, true);
            }
        }

        private void ResetLayout()
        {
            ToggleTapPage(tpActivityLog, false);
            ToggleTapPage(tpBookList, false);
            ToggleTapPage(tpGeneral, false);
            ToggleTapPage(tpOrderList, false);
            ToggleTapPage(tpPOS, false);
            ToggleTapPage(tpPreBooking, false);
            ToggleTapPage(tpProfile, false);
            ToggleTapPage(tpSupplierList, false);
            ToggleTapPage(tpUserList, false);
            ToggleTapPage(tpDashboard, false);
            ToggleTapPage(tpNoAccess, false);
        }

        private void ToggleTapPage(TabPage tapPage, bool toggle)
        {
            if (toggle)
            {
                tapPage.Visible = true;
                mtcRootLayout.TabPages.Add(tapPage);
            }
            else
            {
                tapPage.Visible = false;
                mtcRootLayout.TabPages.Remove(tapPage);
            }
        }

        private void InitPageDataLoad()
        {
            frmPosPage1.LoadBooks(BookList);
            frmPosPage1.LoadCategory(CategoryList);
            frmPosPage1.LoadCustomer(CustomerList);
            frmOrderListView.SetUpPage(false);
            frmPreOrderListView.SetUpPage(true);
        }

        private void HandleSubscrioption()
        {
            this.frmPosPage1.ReloadPageDataDel += LoadPagesOnLoad;
            frmCreateBookModel.FullReloadRequest += LoadPagesOnLoad;
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

                var customerResult = process.GetAllCustomer();

                if (customerResult.Data != null)
                {
                    CustomerList = customerResult.Data;
                    LoadCustomersList?.Invoke(CustomerList);
                }
                else
                {
                    MaterialMessageBox.Show(categoryResult.Message, "Book Load", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
            });
        }

    }
}
