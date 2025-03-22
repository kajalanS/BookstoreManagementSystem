using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace BookstoreManagementSystemUI.Helpers
{

    public class ReceiptPrinter
    {
        private PrintDocument printDocument;
        private string receiptContent;

        public static ReceiptPrinter Create(Order order)
        {
            var dateString = order.OrderDate.ToString("MM/dd/yyyy");

            var receiptText = new StringBuilder();
            receiptText.AppendLine($"Date: {dateString}");
            receiptText.AppendLine(new string('-', 40));
            receiptText.AppendLine("Item         Qty   Price     Total");
            receiptText.AppendLine(new string('-', 40));

            foreach (var item in order.OrderDetails!)
            {
                // Get book title trimmed to 12 characters if needed
                var name = item.Book?.Title ?? "";
                if (name.Length > 12)
                {
                    name = name.Substring(0, 12);
                }
                // Format columns using PadRight/PadLeft
                string nameColumn = name.PadRight(12);
                string qtyColumn = item.Quantity.ToString().PadRight(5);
                string priceColumn = Math.Round(item.UnitPrice, 2).ToString("0.00").PadLeft(8);
                string totalColumn = Math.Round(item.CalculatePrice(), 2).ToString("0.00").PadLeft(8);

                receiptText.AppendLine($"{nameColumn}{qtyColumn}{priceColumn} LKR{totalColumn} LKR");
            }

            receiptText.AppendLine(new string('-', 40));
            receiptText.AppendLine("Subtotal:".PadRight(30) + "$35");
            receiptText.AppendLine("Tax:".PadRight(30) + "$3.50");
            receiptText.AppendLine("Total:".PadRight(30) + "$38.50");

            return new ReceiptPrinter(receiptText.ToString());
        }

        private ReceiptPrinter(string content)
        {
            receiptContent = content;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
        }

        // Method to show Print Preview and print receipt
        public void PrintReceipt()
        {
            // Optionally, show a print preview dialog
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        // The event handler that prints the page
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set up fonts and brushes
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;

            // Draw header (store name)
            string header = "BookHaven Bookstore";
            e.Graphics.DrawString(header, headerFont, brush, leftMargin, yPos);
            yPos += headerFont.GetHeight(e.Graphics) + 10;

            // Draw a separator line
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 10;

            // Draw the receipt content (each line)
            string[] lines = receiptContent.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, bodyFont, brush, leftMargin, yPos);
                yPos += bodyFont.GetHeight(e.Graphics) + 5;
            }

            // Draw footer (thank you note)
            yPos += 20;
            string footer = "Thank you for your purchase!";
            e.Graphics.DrawString(footer, bodyFont, brush, leftMargin, yPos);
        }
    }
}
