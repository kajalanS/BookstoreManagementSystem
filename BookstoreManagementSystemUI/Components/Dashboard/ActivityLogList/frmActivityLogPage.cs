using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Models;
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

namespace BookstoreManagementSystemUI.Components.Dashboard.ActivityLogList
{
	public partial class frmActivityLogPage : UserControl
	{
		public frmActivityLogPage()
		{
			InitializeComponent();
			FullTableViewSub();
			SetUp();
		}

		public List<AuditLog>? AuditLogList { get; private set; }

		private void SetUp()
		{
			frmFullTableView1.btnAdd.Visible = false;
			frmFullTableView1.btnEdit.Visible = false;
			frmFullTableView1.btnDelete.Visible = false;
			frmFullTableView1.btnExport.Visible = false;
			frmFullTableView1.btnImport.Visible = false;
			LoadAuditLogList();
		}

		private void FullTableViewSub()
		{
			//frmFullTableView1.OnExportClicked += OnExportClicked;
			//frmFullTableView1.OnDeleteClicked += OnDeleteClicked;
		}


		//private void OnExportClicked(ListViewItem selected)
		//{
		//	if (!int.TryParse(selected.Text, out int AuditLogId)) return;
		//	var AuditLog = AuditLogList?.Find(x => x.LogId.Equals(AuditLogId));
		//	if (AuditLog == null) return;

		//	GlobalConfig.Process((process, salt) =>
		//	{
		//		Thread thread = new(() =>
		//		{
		//			var editResult = process.EditAuditLog(AuditLog);
		//			MaterialMessageBox.Show(editResult.Message, "AuditLog Request Send Succeeful.", false, FlexibleMaterialForm.ButtonsPosition.Center);
		//			LoadAuditLogList();
		//		});

		//		thread.Start();
		//	});
		//}

		//private void OnDeleteClicked(ListViewItem selected)
		//{
		//	if (!int.TryParse(selected.Text, out int AuditLogId)) return;
		//	var AuditLog = AuditLogList?.Find(x => x.LogId.Equals(AuditLogId));
		//	if (AuditLog == null) return;

		//	GlobalConfig.Process((process, salt) =>
		//	{
		//		var deleteResult = process.DeleteAuditLog(AuditLog);
		//		MaterialMessageBox.Show(deleteResult.Message, "AuditLog Delete", false, FlexibleMaterialForm.ButtonsPosition.Center);
		//		LoadAuditLogList();
		//	});
		//}


		private void LoadAuditLogList()
		{
			GlobalConfig.Process(SetAuditLogList);
		}

		private void SetAuditLogList(IDataConnector connector, string arg2)
		{
			Result<List<AuditLog>> AuditLogResult = connector.GetAllAuditLog();
			if (AuditLogResult.Data == null)
			{
				MaterialMessageBox.Show(AuditLogResult.Message, "AuditLogs", false, FlexibleMaterialForm.ButtonsPosition.Center);
				return;
			}
			this.AuditLogList = AuditLogResult.Data;

			frmFullTableView1.mlvTableView.Columns.Clear();
			frmFullTableView1.mlvTableView.Items.Clear();

			frmFullTableView1.mlvTableView.Columns.Add("AuditLogID", 100);
			frmFullTableView1.mlvTableView.Columns.Add("User Id", 100);
			frmFullTableView1.mlvTableView.Columns.Add("Username", 200);
			frmFullTableView1.mlvTableView.Columns.Add("Action", 200);
			frmFullTableView1.mlvTableView.Columns.Add("Timestamp", 200);
			frmFullTableView1.mlvTableView.Columns.Add("Description", 550);

			foreach (var item in AuditLogResult.Data)
			{
				if (item != null)
				{
					var ls = new ListViewItem
					{
						Text = item.LogId.ToString()
					};

					ls.SubItems.Add(item.UserId.ToString());
					ls.SubItems.Add(item.User?.Username);
					ls.SubItems.Add(item.Action);
					ls.SubItems.Add($"{(item.Timestamp == null ? null : item.Timestamp.Value.ToLocalTime())}");
					ls.SubItems.Add(item.Description);

					frmFullTableView1.mlvTableView.Items.Add(ls);
				}
			}
		}
	}
}
