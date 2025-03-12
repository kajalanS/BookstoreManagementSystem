using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementSystemUI
{
    public partial class frmPosCard : UserControl
    {
        public Book? SelectBook { get; protected set; }

        public delegate void AddBook(Book book);
        public AddBook? AddBookDel { get; set; }


        public frmPosCard()
        {
            InitializeComponent();
        }

        private void frmPosCard_Load(object sender, EventArgs e)
        {
        }

        public void SetupBookInfo(Book book)
        {
            if (book.Image != null)
            {
                pbCard.Image = book.Image.ByteArrayToImage();
            }

            txtTitle.Text = $"{book.Title} ({book.StockQuantity ?? 0})";
            txtPrice.Text = $"{Math.Round(book.Price, 2)} LKR";

            this.SelectBook = book;
        }

        private void POSCard_Click(object sender, EventArgs e)
        {
            if (SelectBook != null)
            {
                AddBookDel?.Invoke(SelectBook);
            }
        }
    }
}
