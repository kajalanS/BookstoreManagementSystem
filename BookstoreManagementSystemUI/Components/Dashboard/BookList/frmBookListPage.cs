using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary;
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
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Forms;
using BookstoreManagementSystemLibrary.Database.Core.Enum;

namespace BookstoreManagementSystemUI.Components.Dashboard.BookList
{
    public partial class frmBookListPage : UserControl
    {
        public delegate void ReloadRequest();
        public ReloadRequest? FullReloadRequest { get; set; }

        public frmBookListPage()
        {
            InitializeComponent();
            SetUp();
            FullTableViewSub();
        }

        public List<Book>? BookList { get; private set; }

        private void SetUp()
        {
            frmFullTableView1.btnAdd.Visible = true;
            frmFullTableView1.btnEdit.Visible = true;
            frmFullTableView1.btnDelete.Visible = true;
            frmFullTableView1.btnExport.Visible = false;
            frmFullTableView1.btnImport.Visible = true;

            frmFullTableView1.btnImport.Text = "Reload";

            if (GlobalConfig.loggedInUser != null && GlobalConfig.loggedInUser.Role == UserRole.Customer)
            {
                frmFullTableView1.btnAdd.Enabled = false;
                frmFullTableView1.btnEdit.Visible = false;
                frmFullTableView1.btnDelete.Visible = false;
                frmFullTableView1.btnImport.Visible = false;
            }

            LoadBookList();
        }

        private void FullTableViewSub()
        {
            frmFullTableView1.OnEditClicked += OnEditClicked;
            frmFullTableView1.OnDeleteClicked += OnDeleteClicked;
            frmFullTableView1.OnAddClicked += OnAddClicked;
            frmFullTableView1.OnImportClicked += LoadBookListReload;
        }

        private void LoadBookListReload()
        {
            LoadBookList();
        }

        private void OnAddClicked()
        {
            var frmBook = new frmCreateBook();
            frmBook.ShowDialog();
            FullReloadRequest?.Invoke();
            LoadBookList();
        }

        private void OnEditClicked(ListViewItem selected)
        {
            if (!int.TryParse(selected.Text, out int bookId)) return;
            var book = BookList?.Find(x => x.BookId.Equals(bookId));
            if (book == null) return;

            var updateStock = new frmUpdateStock(book);
            updateStock.ShowDialog();
            FullReloadRequest?.Invoke();
            LoadBookList();

            //  GlobalConfig.Process((process, salt) =>
            //  {
            //      Thread thread = new(() =>
            //{
            //        var editResult = process.EditBook(book);
            //        MaterialMessageBox.Show(editResult.Message, "Book Request Send Succeeful.", false, FlexibleMaterialForm.ButtonsPosition.Center);
            //        LoadBookList();
            //    });

            //      thread.Start();
            //  });
        }

        private void OnDeleteClicked(ListViewItem selected)
        {
            if (!int.TryParse(selected.Text, out int bookId)) return;
            var book = BookList?.Find(x => x.BookId.Equals(bookId));
            if (book == null) return;

            GlobalConfig.Process((process, salt) =>
            {
                var deleteResult = process.DeleteBook(book);
                MaterialMessageBox.Show(deleteResult.Message, "Book Delete", false, FlexibleMaterialForm.ButtonsPosition.Center);
                FullReloadRequest?.Invoke();
                LoadBookList();
            });
        }


        private void LoadBookList()
        {
            GlobalConfig.Process(SetupBookListTable);
        }

        /// <summary>
        /// Sets the book list in the UI by retrieving all books from the data connector and populating the ListView with the book details.
        /// </summary>
        private void SetupBookListTable(IDataConnector connector, string arg2)
        {
            Result<List<Book>> bookResult = connector.GetAllBooks();
            if (bookResult.Data == null)
            {
                MaterialMessageBox.Show(bookResult.Message, "Books", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }
            this.BookList = bookResult.Data;

            frmFullTableView1.mlvTableView.Columns.Clear();
            frmFullTableView1.mlvTableView.Items.Clear();

            frmFullTableView1.mlvTableView.Columns.Add("BookID", 100);
            frmFullTableView1.mlvTableView.Columns.Add("Title", 300);
            frmFullTableView1.mlvTableView.Columns.Add("Author", 300);
            frmFullTableView1.mlvTableView.Columns.Add("ISBN", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Publisher", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Language", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Stock Quantity", 150);
            frmFullTableView1.mlvTableView.Columns.Add("PublicationYear", 150);
            frmFullTableView1.mlvTableView.Columns.Add("CategoryName", 150);

            foreach (var item in bookResult.Data)
            {
                if (item != null)
                {
                    var ls = new ListViewItem
                    {
                        Text = item.BookId.ToString()
                    };
                    ls.SubItems.Add(item.Title);
                    ls.SubItems.Add(item.Author);
                    ls.SubItems.Add(item.ISBN);
                    ls.SubItems.Add(item.Publisher);
                    ls.SubItems.Add(item.Language);
                    ls.SubItems.Add(item.StockQuantity.ToString());
                    ls.SubItems.Add($"{item.PublicationYear ?? null}");
                    ls.SubItems.Add($"{item.Category?.CategoryName}");
                    frmFullTableView1.mlvTableView.Items.Add(ls);
                }
            }
        }
    }
}
