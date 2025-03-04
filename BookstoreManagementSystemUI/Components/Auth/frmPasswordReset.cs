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

namespace BookstoreManagementSystemUI.Components.Auth
{
    public partial class frmPasswordReset : UserControl
    {
        public frmPasswordReset()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MaterialMessageBox.Show("Invalid Email!", "Form Validation", false, FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }

            GlobalConfig.Process(async (process, salt) =>
            {
                var resetEmailResponse = await process.ResetPasswordAsync(txtEmail.Text, salt);

                if (resetEmailResponse.data == null)
                {
                    MaterialMessageBox.Show(resetEmailResponse.message, "Password Reset", false, FlexibleMaterialForm.ButtonsPosition.Center);
                    return;
                }

                CloseForm();

            });


        }

        private void CloseForm()
        {
            lblMessage.Text = "We've sent your password to your registered email. Please check your inbox (and spam/junk folder if you don't see it). If you need further assistance, feel free to contact us";
            txtEmail.Visible = false;
            btnSendMail.Enabled = false;
        }
    }
}
