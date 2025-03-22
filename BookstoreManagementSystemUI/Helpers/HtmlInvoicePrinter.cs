//using System;
//using System.Windows.Forms;

//namespace BookstoreManagementSystemUI.Helpers
//{
//    public class HtmlInvoicePrinter
//    {
//        // Method to print an HTML invoice using a print preview dialog.
//        public void PrintHtmlInvoice(string htmlInvoice)
//        {
//            // Create a new WebBrowser control (hidden)
//            WebBrowser webBrowserForPrint = new WebBrowser();
//            webBrowserForPrint.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser_DocumentCompleted);

//            // Load the HTML invoice into the control
//            webBrowserForPrint.DocumentText = htmlInvoice;
//        }

//        // Event handler when the document is fully loaded
//        private void WebBrowser_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
//        {
//            if (sender is WebBrowser webBrowserForPrint)
//            {
//                WebBrowser webBrowser = (WebBrowser)webBrowserForPrint;

//                // Open the print preview dialog
//                webBrowser.ShowPrintPreviewDialog();

//                // Optionally, dispose of the control after printing
//                webBrowser.Dispose();
//            }
//        }
//    }
//}

//using System;
//using System.Windows.Forms;
//using Microsoft.Win32;

//namespace BookstoreManagementSystemUI.Helpers
//{
//    public class HtmlInvoicePrinter
//    {
//        // Backup original IE PageSetup settings so they can be restored later
//        private string originalHeader = string.Empty;
//        private string originalFooter = string.Empty;

//        // Method to print an HTML invoice using a print preview dialog.
//        public void PrintHtmlInvoice(string htmlInvoice)
//        {
//            // Create a new WebBrowser control (hidden)
//            WebBrowser webBrowserForPrint = new WebBrowser();
//            webBrowserForPrint.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser_DocumentCompleted);

//            // Load the HTML invoice into the control
//            webBrowserForPrint.DocumentText = htmlInvoice;
//        }

//        // Method to backup current PageSetup settings
//        private void BackupPageSetupSettings()
//        {
//            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\PageSetup", true);
//            if (key != null)
//            {
//                originalHeader = key.GetValue("header") as string ?? "";
//                originalFooter = key.GetValue("footer") as string ?? "";
//            }
//        }

//        // Method to remove headers and footers
//        private void RemovePageSetupHeadersFooters()
//        {
//            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\PageSetup", true);
//            if (key != null)
//            {
//                key.SetValue("header", "");
//                key.SetValue("footer", "");
//            }
//        }

//        // Method to restore original PageSetup settings
//        private void RestorePageSetupSettings()
//        {
//            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\PageSetup", true);
//            if (key != null)
//            {
//                key.SetValue("header", originalHeader);
//                key.SetValue("footer", originalFooter);
//            }
//        }

//        // Event handler when the document is fully loaded
//        private void WebBrowser_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
//        {
//            if (sender is WebBrowser webBrowserForPrint)
//            {
//                // Backup original settings
//                BackupPageSetupSettings();
//                // Remove header and footer
//                RemovePageSetupHeadersFooters();

//                // Open the print preview dialog
//                webBrowserForPrint.ShowPrintPreviewDialog();

//                // Restore original settings after printing
//                RestorePageSetupSettings();

//                // Dispose of the control
//                webBrowserForPrint.Dispose();
//            }
//        }
//    }
//}


using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace BookstoreManagementSystemUI.Helpers
{
    public class HtmlInvoicePrinter
    {
        private string originalHeader;
        private string originalFooter;

        public void PrintHtmlInvoice(string htmlInvoice)
        {
            WebBrowser wb = new WebBrowser();
            wb.DocumentCompleted += Wb_DocumentCompleted;
            wb.DocumentText = htmlInvoice;
        }

        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = (WebBrowser)sender;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\PageSetup", true);

            // Backup current header/footer
            originalHeader = key.GetValue("header") as string;
            originalFooter = key.GetValue("footer") as string;

            // Remove header and footer
            key.SetValue("header", "");
            key.SetValue("footer", "");

            // Show print preview
            wb.ShowPrintPreviewDialog();

            // Restore original header and footer
            key.SetValue("header", originalHeader);
            key.SetValue("footer", originalFooter);

            wb.Dispose();
        }
    }
}
