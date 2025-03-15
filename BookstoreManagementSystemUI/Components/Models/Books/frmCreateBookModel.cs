using BookstoreManagementSystemLibrary.Database.Core.Enum;
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
using BookstoreManagementSystemUI.Forms;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Helpers;
//using EFCategory = BookstoreManagementSystemLibrary.Models.Category;

namespace BookstoreManagementSystemUI.Components.Models.Books
{
    public partial class frmCreateBookModel : UserControl
    {
        private Image? imageData;
        private List<BookstoreManagementSystemLibrary.Models.Category>? categoryList;

        public frmCreateBookModel()
        {
            InitializeComponent();
			frmDashboard.LoadCategoriesList += LoadCategories;
        }

        public void LoadCategories(List<BookstoreManagementSystemLibrary.Models.Category>? category)
        {
            categoryList = category;
            if (category != null)
            {
                cmbCategory.Items.AddRange([.. category.Select(x => x.CategoryName)]);
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|\r\nBMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|\r\nJPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|\r\nGIF Files: (*.GIF)|*.GIF|\r\nTIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|\r\nPNG Files: (*.PNG)|*.PNG|\r\nAll Files|*.*",
                Multiselect = false
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                imageData = Image.FromFile(openDialog.FileName);
            }
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAuthor.Text) || string.IsNullOrEmpty(txtIsbn.Text) || string.IsNullOrEmpty(txtLanguage.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtPublisher.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtYear.Text) || string.IsNullOrEmpty(cmbCategory.Text))
                {
                    MaterialMessageBox.Show("Empty or Invalid Data!", "Form Validation", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }


                var selectedCategory = categoryList
                    ?.Where(x => x.CategoryName == cmbCategory.Text)
                    ?.FirstOrDefault();

                if (selectedCategory == null)
                {
                    MaterialMessageBox.Show("Category is Invalid!", "Form Validation", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MaterialMessageBox.Show("Price is Invalid!", "Form Validation", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }
                if (!int.TryParse(txtQuantity.Text, out int quantity))
                {
                    MaterialMessageBox.Show("Quantity is Invalid!", "Form Validation", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }
                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MaterialMessageBox.Show("Year is Invalid!", "Form Validation", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }

                GlobalConfig.Process((process, salt) =>
                {
                    var newBook = new Book()
                    {
                        Title = txtTitle.Text,
                        CategoryId = selectedCategory.CategoryId,
                        Language = txtLanguage.Text,
                        Price = price,
                        Author = txtAuthor.Text,
                        Image = imageData?.ImageToByteArray(),
                        ISBN = txtIsbn.Text,
                        PublicationYear = year,
                        StockQuantity = quantity,
                        Publisher = txtPublisher.Text,
                    };

                    var createUserResult = process.CreateBook(newBook);

                    if (createUserResult.Data == null)
                    {
                        MaterialMessageBox.Show(createUserResult.Message, "Create user", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    }
                });
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Fail to create Book!", "Create Book", false, FlexibleMaterialForm.ButtonsPosition.Center);
                throw;
            }
        }
    }
}
