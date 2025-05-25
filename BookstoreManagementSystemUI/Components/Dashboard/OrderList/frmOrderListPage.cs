using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.Core.Enum;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Components.Core;
using MaterialSkin.Controls;

namespace BookstoreManagementSystemUI.Components.Dashboard.OrderList
{
    public partial class frmOrderListPage : UserControl
    {
        public List<Order>? OrderList { get; private set; }
        public bool IsPreOrder { get; private set; }

        public frmOrderListPage()
        {
            InitializeComponent();
            FullTableViewSub();
            LoadOrderList();
        }

        public void SetUpPage(bool isPreOrder)
        {
            IsPreOrder = isPreOrder;
            frmFullTableView1.btnAdd.Visible = false;
            frmFullTableView1.btnEdit.Visible = false;
            frmFullTableView1.btnDelete.Visible = true;
            frmFullTableView1.btnExport.Visible = false;
            frmFullTableView1.btnImport.Visible = true;

            frmFullTableView1.btnImport.Text = "Reload";

            LoadOrderList();
        }

        private void FullTableViewSub()
        {
            frmFullTableView1.OnDeleteClicked += OnDeleteClicked;
            frmFullTableView1.OnImportClicked += LoadOrderList;
        }

        private void OnDeleteClicked(ListViewItem selected)
        {
            if (!int.TryParse(selected.Text, out int orderId)) return;
            var order = OrderList?.Find(x => x.OrderId.Equals(orderId));
            if (order == null) return;

            GlobalConfig.Process((process, salt) =>
            {
                var deleteResult = process.DeleteOrder(order);
                MaterialMessageBox.Show(deleteResult.Message, "Order Delete", false, FlexibleMaterialForm.ButtonsPosition.Center);
                LoadOrderList();
            });
        }


        private void LoadOrderList()
        {
            GlobalConfig.Process(SetOrderList);
        }


        /// <summary>
        /// Sets the order list using the specified data connector.
        /// </summary>
        private void SetOrderList(IDataConnector connector, string arg2)
        {
            var orderResult = connector.GetAllOrders();
            if (orderResult.Data == null)
            {
                MaterialMessageBox.Show(orderResult.Message, "Orders", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }
            this.OrderList = orderResult.Data;

            frmFullTableView1.mlvTableView.Columns.Clear();
            frmFullTableView1.mlvTableView.Items.Clear();

            frmFullTableView1.mlvTableView.Columns.Add("OrderID", 100);
            frmFullTableView1.mlvTableView.Columns.Add("Customer", 300);
            frmFullTableView1.mlvTableView.Columns.Add("Order Date", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Order Amount", 250);
            frmFullTableView1.mlvTableView.Columns.Add("Order Status", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Delivery Method", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Payment Method", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Payment Status", 150);
            frmFullTableView1.mlvTableView.Columns.Add("Order Type", 150);

            foreach (var item in orderResult.Data)
            {
                if (IsPreOrder && item.OrderType != OrderType.PreOrder) continue;
                if (!IsPreOrder && item.OrderType != OrderType.Regular) continue;

                if (item != null)
                {
                    var ls = new ListViewItem
                    {
                        Text = item.OrderId.ToString()
                    };

                    ls.SubItems.Add(item.User?.Username);
                    ls.SubItems.Add(item.OrderDate.ToShortDateString());
                    ls.SubItems.Add($"{Math.Round(item.TotalAmount, 2)} LKR");
                    ls.SubItems.Add($"{item.OrderStatus}");
                    ls.SubItems.Add($"{item.DeliveryMethod}");
                    ls.SubItems.Add($"{item.PaymentMethod}");
                    ls.SubItems.Add($"{item.PaymentStatus}");
                    ls.SubItems.Add($"{item.OrderType}");

                    frmFullTableView1.mlvTableView.Items.Add(ls);
                }
            }
        }
    }
}
