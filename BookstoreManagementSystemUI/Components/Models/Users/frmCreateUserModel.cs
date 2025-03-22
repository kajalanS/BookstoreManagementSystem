using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.Core.Enum;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using MaterialSkin.Controls;

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

        private void frmCreateUserModel_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Sets the form to customer-only creation mode, disabling role selection and pre-selecting the customer role.
        /// </summary>
        public void CustomerOnlyCreateMode()
        {
            cmbRole.Enabled = false;
            int index = userRoleList.FindIndex(x => UserRole.Customer.ToString() == x);
            cmbRole.SelectedIndex = index;
        }
        /// <summary>
        /// Handles the Click event of the btnCreateUser button.
        /// Validates the form data and creates a new user if the data is valid.
        /// </summary>
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

                MaterialMessageBox.Show(createUserResult.Message, "Create user", false, FlexibleMaterialForm.ButtonsPosition.Center);
            });
        }
    }
}


/*



    /// <summary>
    /// Sets the form to customer-only creation mode, disabling role selection and pre-selecting the customer role.
    /// </summary>
    public void CustomerOnlyCreateMode()
    {
      // Method implementation here
    }

    /// <summary>
    /// Handles the Load event of the frmCreateUserModel control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void frmCreateUserModel_Load(object sender, EventArgs e)
    {
      // Event handler implementation here
    }

    /// <summary>
    /// Handles the Click event of the btnCreateUser button.
    /// Validates the form data and creates a new user if the data is valid.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

*/
