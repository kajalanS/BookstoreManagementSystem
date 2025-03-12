using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core.Enum;
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
    public partial class frmCreateUserModel : UserControl
    {
        private readonly List<string> userRoleList = [.. UserRole.GetNames(typeof(UserRole))];

        public frmCreateUserModel()
        {
            InitializeComponent();
            cmbRole.Items.AddRange([.. userRoleList]);
        }

        public void CustomerOnlyCreateMode()
        {
            cmbRole.Enabled = false;
            int index = userRoleList.FindIndex(x => UserRole.Customer.ToString() == x);
            cmbRole.SelectedIndex = index;
        }

        private void frmCreateUserModel_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex == 0 || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPasswordConfirm.Text))
            {
                MaterialMessageBox.Show("Invalid Data!", "Form Validation", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }

            UserRole selectedRole = (UserRole)cmbRole.SelectedIndex;

            GlobalConfig.Process((process, salt) =>
            {
                var newUser = new User
                {
                    Username = txtUsername.Text,
                    PasswordHash = txtPassword.Text.GetHash(salt),
                    Email = txtEmail.Text,
                    Role = selectedRole,
                    Status = UserStatus.Active,
                };

                var createUserResult = process.CreateUser(newUser);

                if (createUserResult.Data == null)
                {
                    MaterialMessageBox.Show(createUserResult.Message, "Create user", false, FlexibleMaterialForm.ButtonsPosition.Center);
                }
            });
        }
    }
}
