using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Components;
using BookstoreManagementSystemUI.Extentions;
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
        #region Property

        private TabPage? selectedPage;
        private Category? selectedCategory;
        public frmLogin FrmLogin { get; }

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
            ArrangeShelf();
        }

        #endregion


        private void LoadPagesOnLoad()
        {
            GlobalConfig.Process((process, salt) =>
            {
                var bookResult = process.GetAllBooks();

                if (bookResult.data != null)
                {
                    BookList = bookResult.data;
                }
                else
                {
                    MaterialMessageBox.Show(bookResult.message, "Book Load", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }

                var categoryResult = process.GetAllCategories();

                if (categoryResult.data != null)
                {
                    CategoryList = categoryResult.data;
                }
                else
                {
                    MaterialMessageBox.Show(categoryResult.message, "Book Load", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }

                ArrangeShelf();
            });
        }

        private void ArrangeShelf()
        {
            ArrangeCategoryData();
            ArrangeBookData();
            ArrangeOrderDetailsData();
        }

        private void ArrangeCategoryData()
        {
            if (flpCategoryShelf != null && CategoryList != null)
            {
                flpCategoryShelf.Controls.Clear();
                foreach (var category in CategoryList)
                {
                    var newCategoryCard = new frmPosCategory
                    {
                        Tag = category.CategoryId,
                    };

                    newCategoryCard.SetupCategoryInfo(category);
                    newCategoryCard.ToggleCategoryDel += OnToggleCategory;
                    flpCategoryShelf.Controls.Add(newCategoryCard);
                }
            }
        }

        private void ArrangeBookData()
        {
            if (flpBookShelf != null && BookList != null)
            {
                flpBookShelf.Controls.Clear();
                foreach (var book in BookList)
                {
                    if (selectedCategory != null && book.CategoryId != selectedCategory.CategoryId)
                    {
                        continue;
                    }

                    var newBookCard = new frmPosCard
                    {
                        Tag = book.BookId
                    };

                    newBookCard.SetupBookInfo(book);
                    newBookCard.AddBookDel += OnAddBook;
                    flpBookShelf.Controls.Add(newBookCard);
                }
            }
        }

        private void ArrangeOrderDetailsData()
        {
            if (flpCheckoutShelf != null && OrderDetailList != null)
            {
                flpCheckoutShelf.Controls.Clear();
                foreach (var checkout in OrderDetailList)
                {
                    var newBookCard = new frmPosCheckoutCard
                    {
                        Tag = checkout.Value.BookId
                    };

                    newBookCard.SetupOrderDetailInfo(checkout.Value);
                    newBookCard.DeleteOrderDetailDel += OnDeleteOrderDetail;
                    flpCheckoutShelf.Controls.Add(newBookCard);
                }
            }
        }

        private void OnDeleteOrderDetail(OrderDetail orderDetail)
        {
            if (orderDetail.Book != null && OrderDetailList != null)
            {
                var book = orderDetail.Book;
                OrderDetailList.Remove(book);
            }
            ArrangeOrderDetailsData();
        }

        private void OnAddBook(Book book)
        {
            if (flpBookShelf != null && OrderDetailList != null)
            {
                if (OrderDetailList.TryGetValue(book, out OrderDetail orderDetail))
                {
                    if (orderDetail != null)
                    {
                        var quantity = orderDetail.Quantity ?? 0;
                        var maxQuantity = orderDetail?.Book?.StockQuantity ?? 0;

                        orderDetail.Quantity = Math.Clamp(quantity + 1, 0, maxQuantity);
                        orderDetail.UnitPrice = orderDetail.CalculatePrice();
                    }
                }
                else
                {
                    var order = new OrderDetail
                    {
                        Discount = 0,
                        IsDeleted = false,
                        Quantity = 1,
                        UnitPrice = book.Price,
                        Book = book,
                        BookId = book.BookId,
                    };
                    OrderDetailList.Add(book, order);
                }
            }
            ArrangeOrderDetailsData();
        }

        private void OnToggleCategory(bool toggle, Category category)
        {
            if (flpCategoryShelf != null)
            {
                foreach (var item in flpCategoryShelf.Controls)
                {
                    if (item is frmPosCategory frmPos)
                    {
                        if (frmPos.SelectCategory?.CategoryId != category.CategoryId)
                        {
                            frmPos.DeselectToggleButton();
                        }
                    }
                }
            }

            selectedCategory = toggle ? category : null;
            ArrangeBookData();
        }
    }
}
