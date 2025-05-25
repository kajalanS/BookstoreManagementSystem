using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.Win32;

namespace BookstoreManagementSystemUI.Helpers
{
    public class HtmlInvoicePrinter
    {
        // Backup original IE PageSetup settings so they can be restored later
        private string originalHeader = string.Empty;
        private string originalFooter = string.Empty;
        private PrintDocument printDocument;
        private string receiptContent;

        public static HtmlInvoicePrinter Create(string htmlInvoice)
        {
            // Create an instance of HtmlInvoicePrinter
            return new HtmlInvoicePrinter(htmlInvoice);
        }

        private HtmlInvoicePrinter(string content)
        {
            receiptContent = content;
            printDocument = new PrintDocument();
            //printDocument.DefaultPageSettings = new PageSettings()
            //{
            //    Landscape = false,
            //    PaperSize = new PaperSize()
            //    {
            //        Height = 1169,
            //        Width = 827,
            //        PaperName = "Page Name",
            //    }
            //};

            // Set the paper size to A4 (in hundredths of an inch)
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
        }

        // Method to print an HTML invoice using a print preview dialog.
        public void PrintHtmlInvoice()
        {
            // Create a new WebBrowser control (hidden)
            WebBrowser webBrowserForPrint = new WebBrowser();
            webBrowserForPrint.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser_DocumentCompleted);

            // Load the HTML invoice into the control
            webBrowserForPrint.DocumentText = receiptContent;
        }

        //// Backup current PageSetup settings from the registry
        //private void BackupPageSetupSettings()
        //{
        //    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\PageSetup", true);
        //    if (key != null)
        //    {
        //        originalHeader = key.GetValue("header") as string ?? "";
        //        originalFooter = key.GetValue("footer") as string ?? "";
        //    }
        //}

        //// Remove header and footer by setting them to empty strings
        //private void RemovePageSetupHeadersFooters()
        //{
        //    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\PageSetup", true);
        //    if (key != null)
        //    {
        //        key.SetValue("header", "");
        //        key.SetValue("footer", "");
        //    }
        //}

        //// Restore original PageSetup settings
        //private void RestorePageSetupSettings()
        //{
        //    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\PageSetup", true);
        //    if (key != null)
        //    {
        //        key.SetValue("header", originalHeader);
        //        key.SetValue("footer", originalFooter);
        //    }
        //}

        // Event handler when the document is fully loaded
        private void WebBrowser_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (sender is WebBrowser webBrowserForPrint)
            {
                // Backup original settings and remove headers/footers
                //BackupPageSetupSettings();
                //RemovePageSetupHeadersFooters();

                // Open the print preview dialog
                webBrowserForPrint.ShowPrintPreviewDialog();

                // Restore original settings after printing
                //RestorePageSetupSettings();

                // Dispose of the control
                webBrowserForPrint.Dispose();
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



