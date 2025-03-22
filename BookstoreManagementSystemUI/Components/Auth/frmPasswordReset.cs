using BookstoreManagementSystemLibrary;
using MaterialSkin.Controls;

namespace BookstoreManagementSystemUI.Components.Auth
{
    public partial class frmPasswordReset : UserControl
    {
        public frmPasswordReset()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnSendMail control.
        /// Sends a password reset email if the email address is valid.
        /// </summary>
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

                if (resetEmailResponse.Data != null)
                {
                    CloseForm();
                    return;
                }

                MaterialMessageBox.Show(resetEmailResponse.Message, "Password Reset", false, FlexibleMaterialForm.ButtonsPosition.Center);
            });
        }


        /// <summary>
        /// Closes the form and displays a message indicating that the password reset email has been sent.
        /// </summary>
        private void CloseForm()
        {
            lblMessage.Text = "We've sent your password to your registered email. Please check your inbox (and spam/junk folder if you don't see it). If you need further assistance, feel free to contact us";
            txtEmail.Visible = false;
            btnSendMail.Enabled = false;
        }
    }
}
