using System;
using System.Configuration;
using BookstoreManagementSystemLibrary.Helpers;
using System.Windows.Forms;
using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Models;
using BookstoreManagementSystemLibrary.Database.Core.Enum;
using MaterialSkin.Controls;
using BookstoreManagementSystemUI.Forms;

namespace BookstoreManagementSystemUI
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /// NOTE: load with out login - DEV ONLY
            //TriggerLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MaterialMessageBox.Show("Username or Password is empty!", "Login", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }

            GlobalConfig.Process((process, salt) =>
            {
                var findUser = process.FindUserByUsername(username);
                if (findUser.data == null)
                {
                    MaterialMessageBox.Show(findUser.message, "Login", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }

                if (!password.CompareHash(findUser.data.PasswordHash!, salt))
                {
                    MaterialMessageBox.Show("Login Failed!", "Login", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }

                TriggerLogin();
            });
        }

        private void TriggerLogin()
        {
            txtPassword.Clear();
            txtUsername.Clear();

            Hide();
            var dashboard = new frmDashboard(this);
            dashboard.ShowDialog();
        }

        private void lnkResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newFormReset = new frmPasswordReset();
            newFormReset.ShowDialog();
        }

        private void lnkCreateNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newUserForm = new frmCreateCustomer();
            newUserForm.ShowDialog();
        }
    }
}
