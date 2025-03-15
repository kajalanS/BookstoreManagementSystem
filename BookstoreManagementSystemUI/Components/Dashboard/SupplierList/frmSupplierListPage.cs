using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
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

namespace BookstoreManagementSystemUI.Components.Dashboard.SupplierList
{
  /// <summary>
  /// Represents the supplier list page in the bookstore management system.
  /// </summary>
  public partial class frmSupplierListPage : UserControl
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="frmSupplierListPage"/> class.
    /// </summary>
    public frmSupplierListPage()
    {
      InitializeComponent();
      FullTableViewSub();
      SetUp();
    }

    /// <summary>
    /// Gets the list of suppliers.
    /// </summary>
    public List<Supplier>? SupplierList { get; private set; }

    /// <summary>
    /// Sets up the initial configuration for the supplier list page.
    /// </summary>
    private void SetUp()
    {
      frmFullTableView1.btnAdd.Visible = true;
      frmFullTableView1.btnEdit.Visible = true;
      frmFullTableView1.btnDelete.Visible = true;
      frmFullTableView1.btnExport.Visible = false;
      frmFullTableView1.btnImport.Visible = false;
      LoadSupplierList();
    }

    /// <summary>
    /// Subscribes to the events of the full table view.
    /// </summary>
    private void FullTableViewSub()
    {
      frmFullTableView1.OnEditClicked += OnEditClicked;
      frmFullTableView1.OnDeleteClicked += OnDeleteClicked;
      frmFullTableView1.OnAddClicked += OnAddClicked;
    }

    /// <summary>
    /// Handles the Add button click event.
    /// </summary>
    private void OnAddClicked()
    {
      var frmSupplier = new frmCreateSupplier();
      frmSupplier.ShowDialog();
    }

    /// <summary>
    /// Handles the Edit button click event.
    /// </summary>
    /// <param name="selected">The selected list view item.</param>
    private void OnEditClicked(ListViewItem selected)
    {
      if (!int.TryParse(selected.Text, out int supplierId)) return;
      var supplier = SupplierList?.Find(x => x.SupplierId.Equals(supplierId));
      if (supplier == null) return;

      GlobalConfig.Process((process, salt) =>
      {
        Thread thread = new(() =>
        {
          var editResult = process.EditSupplier(supplier);
          MaterialMessageBox.Show(editResult.Message, "Supplier Request Send Successful.", false, FlexibleMaterialForm.ButtonsPosition.Center);
          LoadSupplierList();
        });

        thread.Start();
      });
    }

    /// <summary>
    /// Handles the Delete button click event.
    /// </summary>
    /// <param name="selected">The selected list view item.</param>
    private void OnDeleteClicked(ListViewItem selected)
    {
      if (!int.TryParse(selected.Text, out int supplierId)) return;
      var supplier = SupplierList?.Find(x => x.SupplierId.Equals(supplierId));
      if (supplier == null) return;

      GlobalConfig.Process((process, salt) =>
      {
        var deleteResult = process.DeleteSupplier(supplier);
        MaterialMessageBox.Show(deleteResult.Message, "Supplier Delete", false, FlexibleMaterialForm.ButtonsPosition.Center);
        LoadSupplierList();
      });
    }

    /// <summary>
    /// Loads the list of suppliers.
    /// </summary>
    private void LoadSupplierList()
    {
      GlobalConfig.Process(SetSupplierList);
    }

    /// <summary>
    /// Sets the supplier list and updates the table view.
    /// </summary>
    private void SetSupplierList(IDataConnector connector, string arg2)
    {
      Result<List<Supplier>> supplierResult = connector.GetAllSupplier();
      if (supplierResult.Data == null)
      {
        MaterialMessageBox.Show(supplierResult.Message, "Suppliers", false, FlexibleMaterialForm.ButtonsPosition.Center);
        return;
      }
      this.SupplierList = supplierResult.Data;

      frmFullTableView1.mlvTableView.Columns.Clear();
      frmFullTableView1.mlvTableView.Items.Clear();

      frmFullTableView1.mlvTableView.Columns.Add("SupplierID", 100);
      frmFullTableView1.mlvTableView.Columns.Add("Name", 300);
      frmFullTableView1.mlvTableView.Columns.Add("Email", 300);
      frmFullTableView1.mlvTableView.Columns.Add("Address", 300);
      frmFullTableView1.mlvTableView.Columns.Add("PhoneNumber", 150);

      foreach (var item in supplierResult.Data)
      {
        if (item != null)
        {
          var ls = new ListViewItem
          {
            Text = item.SupplierId.ToString()
          };

          ls.SubItems.Add(item.Name);
          ls.SubItems.Add(item.Email);
          ls.SubItems.Add(item.Address);
          ls.SubItems.Add(item.PhoneNumber);

          frmFullTableView1.mlvTableView.Items.Add(ls);
        }
      }
    }
  }
}
