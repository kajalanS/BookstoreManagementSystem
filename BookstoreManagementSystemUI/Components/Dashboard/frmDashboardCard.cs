using BookstoreManagementSystemLibrary.Database.Core.Enum;
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

namespace BookstoreManagementSystemUI.Components.Dashboard
{

	public partial class frmDashboardCard : UserControl
	{
		public DashboardCardType SelectedType { get; private set; }

		public delegate void OnExportClickedDel();
		public event OnExportClickedDel? ExportButtonClicked;

		public frmDashboardCard()
		{
			InitializeComponent();
		}

		public void SetPermission(User? user)
		{
			if (user?.Role == UserRole.Admin)
			{
				onExportClick.Visible = true;
			}
			else
			{
				onExportClick.Visible = false;
			}

		}

		private void frmDashboardCard_Load(object sender, EventArgs e)
		{
		}

		private void onExportClick_Click(object sender, EventArgs e)
		{
			ExportButtonClicked?.Invoke();
		}

		public void Setup(DashboardCardType type, Dictionary<DashboardCardDataType, string> obj)
		{
			SelectedType = type;

			if (obj == null)
			{
				return;
			}

			obj.TryGetValue(DashboardCardDataType.Title, out var title);
			obj.TryGetValue(DashboardCardDataType.SubTitle, out var subtitle);

			lblTitle.Text = title;
			lblSubTitle.Text = subtitle;
			switch (type)
			{
				case DashboardCardType.TotalOrder:
					pbCardImage.Image = "order_bg".GetImageFromResources();
					break;
				case DashboardCardType.TotalIncome:
					pbCardImage.Image = "total_income".GetImageFromResources();
					break;
				case DashboardCardType.TotalBooks:
					pbCardImage.Image = "total_books".GetImageFromResources();
					break;
				case DashboardCardType.TotalSuppliers:
					pbCardImage.Image = "total_suppliers".GetImageFromResources();
					break;
			}
		}
	}
}
