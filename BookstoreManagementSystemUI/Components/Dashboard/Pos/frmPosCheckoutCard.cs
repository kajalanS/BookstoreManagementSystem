using BookstoreManagementSystemLibrary.Database.Core;
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

namespace BookstoreManagementSystemUI.Components
{
  /// <summary>
  /// Represents a user control for the POS checkout card in the bookstore management system.
  /// </summary>
  public partial class frmPosCheckoutCard : UserControl
  {
    public OrderDetail? SelectOrderDetail { get; protected set; }

    public delegate void DeleteOrderDetails(OrderDetail orderDetail);
    public DeleteOrderDetails? DeleteOrderDetailDel { get; set; }

    public frmPosCheckoutCard()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Handles the click event of the delete button.
    /// </summary>
    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (DeleteOrderDetailDel != null && SelectOrderDetail != null)
      {
        DeleteOrderDetailDel.Invoke(SelectOrderDetail);
      }
    }

    /// <summary>
    /// Sets up the order detail information on the UI.
    /// </summary>
    /// <param name="orderDetail">The order detail to be displayed.</param>
    public void SetupOrderDetailInfo(OrderDetail orderDetail)
    {
      lblName.Text = orderDetail?.Book?.Title;
      lblQuantity.Text = orderDetail?.Quantity.ToString();
      lblPrice.Text = $"{Math.Round(orderDetail.CalculatePrice(), 2)} LKR";

      this.SelectOrderDetail = orderDetail;
    }
  }
}
