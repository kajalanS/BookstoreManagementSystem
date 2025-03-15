using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Helpers;
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

namespace BookstoreManagementSystemUI.Components.Models.Users
{
  public partial class frmUserProfile : UserControl
  {
    private User? LogedInUser;

    public frmUserProfile()
    {
      InitializeComponent();
      LoadLoginUserData();
    }

    private void LoadLoginUserData()
    {
      var userId = GlobalConfig.loggedInUser?.Username ?? "admin";

      if (userId != null)
      {
        GlobalConfig.Process((process, salt) =>
        {
          var findUser = process.FindUserByUsername(userId);
          if (findUser.Data == null)
          {
            MaterialMessageBox.Show(findUser.Message, "User Profile", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
            return;
          }

          LogedInUser = findUser.Data;
          SetupLoginUser(findUser.Data);
        });
      }
    }

    private void SetupLoginUser(User findUser)
    {
      lblUsername.Text = findUser.Username;
      txtUsername.Text = findUser.Username;
      txtEmail.Text = findUser.Email;
      var lastLoginDate = findUser.LastLogin ?? DateTime.Now;
      txtLastLogin.Text = lastLoginDate.ToLocalTime().ToString();
      txtRole.Text = findUser.Role.ToString();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      GlobalConfig.Process(UpdateUser);
    }

    private void UpdateUser(IDataConnector connector, string salt)
    {
      var user = LogedInUser!;
      user.Email = txtEmail.Text;
      user.Username = txtUsername.Text;
      if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtConfirmPassword.Text) && txtPassword.Text.Equals(txtConfirmPassword.Text))
      {
        user.PasswordHash = txtPassword.Text.GetHash(salt);
      }
      Result<User> updatedUser = connector.UpdateUserProfile(user);
      if (updatedUser.Data == null)
      {
        MaterialMessageBox.Show(updatedUser.Message, "User Profile Update", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
        return;
      }
    }
  }
}
