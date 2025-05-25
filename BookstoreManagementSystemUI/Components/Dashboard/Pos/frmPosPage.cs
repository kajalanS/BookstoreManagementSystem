using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.Core.Enum;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Forms;
using BookstoreManagementSystemUI.Helpers;
using MaterialSkin.Controls;

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
        public List<User>? CustomerList { get; protected set; }

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
            frmDashboard.LoadCustomersList += LoadCustomer;
        }

        public void LoadCustomer(List<User>? customers)
        {
            if (customers != null)
            {
                CustomerList = customers;
                ArrangeShelf();
            }
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
            ArrangeCustomerData();
        }

        private void ArrangeCustomerData()
        {
            if (CustomerList != null)
            {
                cmbCustomer.Items.Clear();
                //cmbCustomer.Items.Add("Walk In Customer");
                foreach (var customer in CustomerList)
                {
                    cmbCustomer.Items.Add($"{customer.Username} ({customer.UserId})");
                    //cmbCustomer.Items.Add(customer);
                }
            }
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
                decimal total = 0;
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

                    total += checkout.Value.CalculatePrice();
                }

                lblTotalOrderList.Text = $"{Math.Round(total, 2)} LKR";
            }

            bool disableButton = OrderDetailList != null && OrderDetailList.Count > 0;

            btnCheckout.Enabled = disableButton;
            btnPreBooking.Enabled = disableButton;
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
                if (OrderDetailList.TryGetValue(book, out var orderDetail))
                {
                    if (orderDetail != null)
                    {
                        var quantity = orderDetail.Quantity;
                        var maxQuantity = orderDetail.Book?.StockQuantity ?? 0;

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
            DeselectAllCategory(category);

            selectedCategory = toggle ? category : null;
            ArrangeBookData();
        }

        private void DeselectAllCategory(Category category)
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
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            var frmBook = new frmCreateBook();
            frmBook.SetCategory(CategoryList);
            frmBook.ShowDialog();
        }

        /// <summary>
        /// Handles the click event of the btnFindText button.
        /// </summary>
        private void btnFindText_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                DeselectAllCategory(selectedCategory);
            }

            if (string.IsNullOrEmpty(txtFinText.Text))
            {
                MaterialMessageBox.Show("Find text must not be empty!", "Find", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }
            GlobalConfig.Process(FindBookFromCategory);
        }

        /// <summary>
        /// Finds books from a specified category using the provided data connector and search argument.
        /// </summary>
        private void FindBookFromCategory(IDataConnector connector, string arg2)
        {
            var books = connector.FindBook(txtFinText.Text);
            if (books.Data == null)
            {
                MaterialMessageBox.Show(books.Message, "Find", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }
            LoadBooks(books?.Data);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            OrderDetailList?.Clear();
            ArrangeShelf();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            GlobalConfig.Process((process, key) => CreateBooking(process, key, OrderType.Regular));
        }

        private void btnPreBooking_Click(object sender, EventArgs e)
        {
            GlobalConfig.Process((process, key) => CreateBooking(process, key, OrderType.PreOrder));
        }

        private int GetSelectedCustomer()
        {
            if (cmbCustomer.SelectedItem == null) return 0;
            var selectedCustomer = CustomerList?.Where(x => $"{x.Username} ({x.UserId})" == cmbCustomer.SelectedItem.ToString()).FirstOrDefault();
            return selectedCustomer?.UserId ?? 0;
        }

        private void CreateBooking(IDataConnector connector, string arg2, OrderType orderType)
        {
            if (OrderDetailList != null)
            {
                var totalValue = OrderDetailList.Values.Select(x => x.CalculatePrice()).Sum();
                Order newOrder = new()
                {
                    UserId = GetSelectedCustomer(),
                    DeliveryMethod = DeliveryMethod.InStorePickup,
                    OrderDate = DateTime.Now,
                    OrderStatus = OrderStatus.Completed,
                    OrderType = orderType,
                    PaymentMethod = PaymentMethod.Cash,
                    PaymentStatus = PaymentStatus.Paid,
                    TotalAmount = totalValue,
                    OrderDetails = OrderDetailList.Values,
                };

                if (orderType == OrderType.PreOrder)
                {
                    newOrder.OrderStatus = OrderStatus.Pending;
                    newOrder.PaymentStatus = PaymentStatus.Pending;
                }

                var orderResult = connector.CreateOrder(newOrder);

                if (orderResult.Data == null)
                {
                    MaterialMessageBox.Show(orderResult.Message, "Create Order", false);
                    return;
                }

                newOrder = orderResult.Data;

                var dicount = newOrder.OrderDetails?.Select(x => x.Discount ?? 0).Sum() ?? 0;
                var subTotal = newOrder.OrderDetails?.Select(x => x.UnitPrice).Sum() ?? 0;
                Dictionary<EmailTemplatePlaceHolder, object> mapper = new()
                {
                    {EmailTemplatePlaceHolder.OrderId, newOrder.OrderId.ToString() },
                    {EmailTemplatePlaceHolder.SubTotal,  Math.Round(subTotal,2).ToString() },
                    {EmailTemplatePlaceHolder.Total, Math.Round(newOrder.TotalAmount,2).ToString() },
                    {EmailTemplatePlaceHolder.Discount, Math.Round(dicount,2).ToString() },
                    {EmailTemplatePlaceHolder.OrderObject, newOrder },
                    {EmailTemplatePlaceHolder.OrderDate, newOrder.OrderDate.ToString("MMMM, dd yyyy hh:mm tt") },
                };

                string htmlInvoice = EmailTemplateType.Invoice.ProcessTemplate(mapper);
                HtmlInvoicePrinter printer = HtmlInvoicePrinter.Create(htmlInvoice);
                printer.PrintHtmlInvoice();

                Reset();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new frmCreateCustomer();
            customer.ShowDialog();
        }
    }
}
