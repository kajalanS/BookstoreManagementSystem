using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Extentions;
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

namespace BookstoreManagementSystemUI.Components
{
    public partial class frmPosCheckoutCard : UserControl
    {
        public OrderDetail? SelectOrderDetail { get; protected set; }

        public delegate void DeleteOrderDetails(OrderDetail orderDetail);
        public DeleteOrderDetails? DeleteOrderDetailDel { get; set; }

        public frmPosCheckoutCard()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteOrderDetailDel != null && SelectOrderDetail != null)
            {
                DeleteOrderDetailDel.Invoke(SelectOrderDetail);
            }
        }

        public void SetupOrderDetailInfo(OrderDetail orderDetail)
        {
            lblName.Text = orderDetail?.Book?.Title;
            lblQuantity.Text = orderDetail?.Quantity?.ToString();
            lblPrice.Text = $"{Math.Round(orderDetail.CalculatePrice(), 2)} LKR";

            this.SelectOrderDetail = orderDetail;
        }
    }
}
