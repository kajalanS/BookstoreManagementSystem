using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BookstoreManagementSystemUI.Extentions;
using static BookstoreManagementSystemUI.Forms.frmDashboard;
using BookstoreManagementSystemUI.Forms;

namespace BookstoreManagementSystemUI.Components.Pos
{
    public partial class frmPosPage : UserControl
    {
        #region Delegate

        public delegate void LoadReloadData();
        public LoadReloadData? ReloadPageDataDel { get; set; }

        #endregion

        #region Property

        private TabPage? selectedPage;
        private Category? selectedCategory;

        protected Dictionary<Book, OrderDetail>? OrderDetailList = [];
        public List<Book>? BookList { get; protected set; }
        public List<Category>? CategoryList { get; protected set; }

        #endregion

        public frmPosPage()
        {
            InitializeComponent();
            ArrangeShelf();
        }

        private void frmPosPage_Load(object sender, EventArgs e)
        {
            frmDashboard.LoadCategoriesList += LoadCategory;
            frmDashboard.LoadBooksList += LoadBooks;
        }

        public void LoadBooks(List<Book>? books)
        {
            if (books != null)
            {
                BookList = books;
                ArrangeShelf();
            }
        }

        public void LoadCategory(List<Category>? category)
        {
            if (category != null)
            {
                CategoryList = category;
                ArrangeShelf();
            }
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
