using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.Core.Enum;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemUI.Forms;
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

namespace BookstoreManagementSystemUI.Components.Dashboard.UserList
{
  public partial class frmUserListPage : UserControl
  {
    public List<User>? UserList { get; private set; }

    public frmUserListPage()
    {
      InitializeComponent();
      SetUp();
      FullTableViewSub();
    }

    private void SetUp()
    {
      frmFullTableView1.btnAdd.Visible = true;
      frmFullTableView1.btnEdit.Visible = true;
      frmFullTableView1.btnEdit.Text = "Reset Password";
      frmFullTableView1.btnDelete.Visible = true;
      frmFullTableView1.btnExport.Visible = false;
      frmFullTableView1.btnImport.Visible = false;
      LoadUserList();
    }

    private void FullTableViewSub()
    {
      frmFullTableView1.OnEditClicked += OnPasswordResetClicked;
      frmFullTableView1.OnDeleteClicked += OnDeleteClicked;
      frmFullTableView1.OnAddClicked += OnAddClicked;
    }

    private void OnAddClicked()
    {
      var frmUser = new frmUserCreate();
      frmUser.ShowDialog();
    }

    private void OnPasswordResetClicked(ListViewItem selected)
    {
      if (!int.TryParse(selected.Text, out int userId)) return;
      var user = UserList?.Find(x => x.UserId.Equals(userId));
      if (user == null) return;

      GlobalConfig.Process((process, salt) =>
      {
        Thread thread = new(async () =>
        {
          var deleteResult = await process.ResetPasswordAsync(user, salt);
          MaterialMessageBox.Show(deleteResult.Message, "User Request Send Succeeful.", false, FlexibleMaterialForm.ButtonsPosition.Center);
          LoadUserList();
        });

        thread.Start();
      });
    }

    private void OnDeleteClicked(ListViewItem selected)
    {
      if (!int.TryParse(selected.Text, out int userId)) return;
      var user = UserList?.Find(x => x.UserId.Equals(userId));
      if (user == null) return;

      GlobalConfig.Process((process, salt) =>
      {
        var deleteResult = process.DeleteUser(user);
        MaterialMessageBox.Show(deleteResult.Message, "User Delete", false, FlexibleMaterialForm.ButtonsPosition.Center);
        LoadUserList();
      });
    }

    private void LoadUserList()
    {
      GlobalConfig.Process(SetUserList);
    }

    private void SetUserList(IDataConnector connector, string arg2)
    {
      Result<List<User>> userResult = connector.GetAllUsers();
      if (userResult.Data == null)
      {
        MaterialMessageBox.Show(userResult.Message, "Users", false, FlexibleMaterialForm.ButtonsPosition.Center);
        return;
      }
      this.UserList = userResult.Data;

      frmFullTableView1.mlvTableView.Columns.Clear();
      frmFullTableView1.mlvTableView.Items.Clear();

      frmFullTableView1.mlvTableView.Columns.Add("UserID", 100);
      frmFullTableView1.mlvTableView.Columns.Add("Username", 300);
      frmFullTableView1.mlvTableView.Columns.Add("Email", 300);
      frmFullTableView1.mlvTableView.Columns.Add("Last Login", 150);
      frmFullTableView1.mlvTableView.Columns.Add("User Status", 150);

      foreach (var item in userResult.Data)
      {
        if (item != null)
        {
          var ls = new ListViewItem
          {
            Text = item.UserId.ToString()
          };

          ls.SubItems.Add(item.Username);
          ls.SubItems.Add(item.Email);
          ls.SubItems.Add(item.LastLogin == null ? "null" : item.LastLogin.Value.ToShortDateString());
          ls.SubItems.Add($"{item.Status}");

          frmFullTableView1.mlvTableView.Items.Add(ls);
        }
      }
    }
  }
}
