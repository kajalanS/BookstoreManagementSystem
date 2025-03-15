using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF.Connectors;
using BookstoreManagementSystemUI.Helpers;
using ClosedXML.Excel;
using MaterialSkin.Controls;

namespace BookstoreManagementSystemUI.Components.Dashboard
{
  /// <summary>
  /// Dashboard component page for the dashboard Form
  /// </summary>
  public partial class frmDashboardPage : UserControl
  {
    public frmDashboardPage()
    {
      InitializeComponent();

      GlobalConfig.Process(ProcessDashboard);
      frmDashboardCardTotalBooks.ExportButtonClicked += TotalBooksClicked;
      frmDashboardCardTotalOrders.ExportButtonClicked += TotalOrdersClicked;
      frmDashboardCardTotalSuppliers.ExportButtonClicked += TotalSuppliersClicked;
      frmDashboardCardTotalIncome.ExportButtonClicked += TotalIncomeClicked;
    }

    /// <summary>
    /// Handles the event when the total books section is clicked.
    /// Initiates the process to export book data using the global configuration.
    /// </summary>
    private void TotalBooksClicked()
    {
      GlobalConfig.Process(ExportBookData);
    }
    private void TotalOrdersClicked()
    {
      GlobalConfig.Process(ExportOrdersData);
    }
    private void TotalSuppliersClicked()
    {
      GlobalConfig.Process(ExportSuppliersData);
    }
    private void TotalIncomeClicked()
    {
      GlobalConfig.Process(ExportIncomeData);
    }
    private void ExportBookData(IDataConnector connector, string arg2)
    {
      if (connector is EFDataConnector container)
      {
        var data = container.Context.Books.ToList();
        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("BookData");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Category";
        worksheet.Cell(1, 3).Value = "Title";
        worksheet.Cell(1, 4).Value = "Author";
        worksheet.Cell(1, 5).Value = "ISBN";
        worksheet.Cell(1, 6).Value = "Price";
        worksheet.Cell(1, 7).Value = "StockQuantity";
        worksheet.Cell(1, 8).Value = "Publisher";
        worksheet.Cell(1, 9).Value = "PublicationYear";
        worksheet.Cell(1, 10).Value = "Language";

        int row = 2;
        foreach (var item in data)
        {
          worksheet.Cell(row, 1).Value = item.BookId;
          worksheet.Cell(row, 2).Value = item.Category?.CategoryName;
          worksheet.Cell(row, 3).Value = item.Title;
          worksheet.Cell(row, 4).Value = item.Author;
          worksheet.Cell(row, 5).Value = item.ISBN;
          worksheet.Cell(row, 6).Value = item.Price;
          worksheet.Cell(row, 7).Value = item.StockQuantity;
          worksheet.Cell(row, 8).Value = item.Publisher;
          worksheet.Cell(row, 9).Value = item.PublicationYear;
          worksheet.Cell(row, 10).Value = item.Language;
          row++;
        }
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"BookExportedData_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Millisecond}.xlsx");
        workbook.SaveAs(filePath);
        MaterialMessageBox.Show("Book Data Exported to Desktop.", "Export", false, FlexibleMaterialForm.ButtonsPosition.Center);
      }
    }

    private void ExportOrdersData(IDataConnector connector, string arg2)
    {
      if (connector is EFDataConnector container)
      {
        var data = container.Context.Orders.ToList();
        using var workbook = new XLWorkbook();

        var worksheet = workbook.Worksheets.Add("OrderData");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Customer";
        worksheet.Cell(1, 3).Value = "User";
        worksheet.Cell(1, 4).Value = "OrderDate";
        worksheet.Cell(1, 5).Value = "TotalAmount";
        worksheet.Cell(1, 6).Value = "OrderStatus";
        worksheet.Cell(1, 7).Value = "DeliveryMethod";
        worksheet.Cell(1, 8).Value = "PaymentMethod";
        worksheet.Cell(1, 9).Value = "PaymentStatus";
        worksheet.Cell(1, 10).Value = "OrderType";
        worksheet.Cell(1, 11).Value = "Receipt ID";

        int row = 2;
        foreach (var item in data)
        {
          worksheet.Cell(row, 1).Value = item.OrderId;
          worksheet.Cell(row, 2).Value = item.Customer?.Name;
          worksheet.Cell(row, 3).Value = item.User?.Username;
          worksheet.Cell(row, 4).Value = item.OrderDate;
          worksheet.Cell(row, 5).Value = item.TotalAmount;
          worksheet.Cell(row, 6).Value = item.OrderStatus.ToString();
          worksheet.Cell(row, 7).Value = item.DeliveryMethod.ToString();
          worksheet.Cell(row, 8).Value = item.PaymentMethod.ToString();
          worksheet.Cell(row, 9).Value = item.PaymentStatus.ToString();
          worksheet.Cell(row, 10).Value = item.OrderType.ToString();
          worksheet.Cell(row, 11).Value = item.Receipt?.ReceiptId.ToString();
          row++;
        }

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"OrderExportedData_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Millisecond}.xlsx");
        workbook.SaveAs(filePath);

        MaterialMessageBox.Show("Order Data Exported to Desktop.", "Export", false, FlexibleMaterialForm.ButtonsPosition.Center);
      }
    }

    private void ExportSuppliersData(IDataConnector connector, string arg2)
    {
      if (connector is EFDataConnector container)
      {
        var data = container.Context.Suppliers.ToList();
        using var workbook = new XLWorkbook();

        var worksheet = workbook.Worksheets.Add("SupplierData");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Name";
        worksheet.Cell(1, 3).Value = "Email";
        worksheet.Cell(1, 4).Value = "PhoneNumber";
        worksheet.Cell(1, 5).Value = "Address";
        worksheet.Cell(1, 6).Value = "Books Count";

        int row = 2;
        foreach (var item in data)
        {
          worksheet.Cell(row, 1).Value = item.SupplierId;
          worksheet.Cell(row, 2).Value = item.Name;
          worksheet.Cell(row, 3).Value = item.Email;
          worksheet.Cell(row, 4).Value = item.PhoneNumber;
          worksheet.Cell(row, 5).Value = item.Address;
          worksheet.Cell(row, 6).Value = (item.Books?.Count ?? 0).ToString();
          row++;
        }

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"SupplierExportedData_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Millisecond}.xlsx");
        workbook.SaveAs(filePath);

        MaterialMessageBox.Show("Supplier Data Exported to Desktop.", "Export", false, FlexibleMaterialForm.ButtonsPosition.Center);
      }
    }

    private void ExportIncomeData(IDataConnector connector, string arg2)
    {
      if (connector is EFDataConnector container)
      {
        var data = container.Context.OrderDetails?.ToList();
        using var workbook = new XLWorkbook();

        var worksheet = workbook.Worksheets.Add("OrderDetailsData");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Order Id";
        worksheet.Cell(1, 3).Value = "Book Id";
        worksheet.Cell(1, 4).Value = "Book Title";
        worksheet.Cell(1, 5).Value = "Quantity";
        worksheet.Cell(1, 6).Value = "Unit Price";
        worksheet.Cell(1, 7).Value = "Discount";
        worksheet.Cell(1, 7).Value = "Customer Name";

        int row = 2;
        foreach (var item in data)
        {
          worksheet.Cell(row, 1).Value = item.OrderDetailId;
          worksheet.Cell(row, 2).Value = item.OrderId;
          worksheet.Cell(row, 3).Value = item.BookId;
          worksheet.Cell(row, 4).Value = item.Book?.Title;
          worksheet.Cell(row, 5).Value = item.Quantity;
          worksheet.Cell(row, 6).Value = item.UnitPrice;
          worksheet.Cell(row, 7).Value = item.Discount;
          worksheet.Cell(row, 8).Value = item.Order?.Customer?.Name;
          row++;
        }

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"SupplierExportedData_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Millisecond}.xlsx");
        workbook.SaveAs(filePath);

        MaterialMessageBox.Show("Income Data Exported to Desktop.", "Export", false, FlexibleMaterialForm.ButtonsPosition.Center);
      }
    }

    private void ExportUserData(IDataConnector connector, string arg2)
    {
      if (connector is EFDataConnector container)
      {
        var data = container.Context.Users.ToList();
        using var workbook = new XLWorkbook();

        var worksheet = workbook.Worksheets.Add("UserData");

        worksheet.Cell(1, 1).Value = "ID";
        worksheet.Cell(1, 2).Value = "Username";
        worksheet.Cell(1, 3).Value = "Role";
        worksheet.Cell(1, 4).Value = "Email";
        worksheet.Cell(1, 5).Value = "LastLogin";

        int row = 2;
        foreach (var item in data)
        {
          worksheet.Cell(row, 1).Value = item.UserId;
          worksheet.Cell(row, 2).Value = item.Username;
          worksheet.Cell(row, 3).Value = item.Role.ToString();
          worksheet.Cell(row, 4).Value = item.Email;
          worksheet.Cell(row, 5).Value = item.LastLogin;
          row++;
        }

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"ExportedData_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{DateTime.Now.Millisecond}.xlsx");
        workbook.SaveAs(filePath);

        MaterialMessageBox.Show("User Data Exported to Desktop.", "Export", false, FlexibleMaterialForm.ButtonsPosition.Center);
      }
    }

    private void frmDashboardPage_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Processes the dashboard data and sets up the dashboard cards with the retrieved data.
    /// </summary>
    /// <param name="connector">The data connector used to retrieve the dashboard data.</param>
    /// <param name="arg2">An additional argument for password hashing</param>
    private void ProcessDashboard(IDataConnector connector, string arg2)
    {
      var dashboardData = connector.GetDashboardData();
      if (dashboardData?.Data == null)
      {
        MaterialMessageBox.Show(dashboardData?.Message, "Dashboard", false, FlexibleMaterialForm.ButtonsPosition.Center);
        return;
      }

      var data = dashboardData.Data;

      // setup the total order card
      Dictionary<DashboardCardDataType, string> sendData = new Dictionary<DashboardCardDataType, string>
      {
        {DashboardCardDataType.Title, "Total Order" },
        {DashboardCardDataType.SubTitle, $"{data.TotalOrder}"  },
      };
      frmDashboardCardTotalOrders.Setup(DashboardCardType.TotalOrder, sendData);
      frmDashboardCardTotalOrders.SetPermission(GlobalConfig.loggedInUser);

      // setup the total book card
      sendData = new Dictionary<DashboardCardDataType, string>
      {
        {DashboardCardDataType.Title, "Total Books" },
        {DashboardCardDataType.SubTitle, $"{data.TotalBooks}"  },
      };
      frmDashboardCardTotalBooks.Setup(DashboardCardType.TotalBooks, sendData);
      frmDashboardCardTotalBooks.SetPermission(GlobalConfig.loggedInUser);

      // setup the total supplier card
      sendData = new Dictionary<DashboardCardDataType, string>
      {
        {DashboardCardDataType.Title, "Total Supplier" },
        {DashboardCardDataType.SubTitle, $"{data.TotalSuppliers}"  },
      };
      frmDashboardCardTotalSuppliers.Setup(DashboardCardType.TotalSuppliers, sendData);
      frmDashboardCardTotalSuppliers.SetPermission(GlobalConfig.loggedInUser);

      // setup the total Income card
      sendData = new Dictionary<DashboardCardDataType, string>
      {
        {DashboardCardDataType.Title, "Total Income" },
        {DashboardCardDataType.SubTitle, $"{data.TotalIncome} LKR"  },
      };
      frmDashboardCardTotalIncome.Setup(DashboardCardType.TotalIncome, sendData);
      frmDashboardCardTotalIncome.SetPermission(GlobalConfig.loggedInUser);
    }
  }
}
