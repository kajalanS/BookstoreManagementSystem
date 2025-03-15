namespace BookstoreManagementSystemUI.Components.Models.Users
{
    partial class frmCreateUserModel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			materialCard1 = new MaterialSkin.Controls.MaterialCard();
			tableLayoutPanel1 = new TableLayoutPanel();
			txtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtPasswordConfirm = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
			btnCreateUser = new MaterialSkin.Controls.MaterialButton();
			cmbRole = new MaterialSkin.Controls.MaterialComboBox();
			materialCard1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// materialCard1
			// 
			materialCard1.BackColor = Color.FromArgb(255, 255, 255);
			materialCard1.Controls.Add(tableLayoutPanel1);
			materialCard1.Depth = 0;
			materialCard1.Dock = DockStyle.Fill;
			materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
			materialCard1.Location = new Point(0, 0);
			materialCard1.Margin = new Padding(20);
			materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			materialCard1.Name = "materialCard1";
			materialCard1.Padding = new Padding(20);
			materialCard1.Size = new Size(641, 413);
			materialCard1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			tableLayoutPanel1.Controls.Add(txtEmail, 0, 4);
			tableLayoutPanel1.Controls.Add(txtPasswordConfirm, 0, 2);
			tableLayoutPanel1.Controls.Add(txtPassword, 0, 1);
			tableLayoutPanel1.Controls.Add(txtUsername, 0, 0);
			tableLayoutPanel1.Controls.Add(btnCreateUser, 0, 5);
			tableLayoutPanel1.Controls.Add(cmbRole, 0, 3);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(20, 20);
			tableLayoutPanel1.Margin = new Padding(10);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.Padding = new Padding(10);
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel1.Size = new Size(601, 373);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// txtEmail
			// 
			txtEmail.AllowPromptAsInput = true;
			txtEmail.AnimateReadOnly = false;
			txtEmail.AsciiOnly = false;
			txtEmail.BackgroundImageLayout = ImageLayout.None;
			txtEmail.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtEmail, 3);
			txtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtEmail.Depth = 0;
			txtEmail.Dock = DockStyle.Fill;
			txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtEmail.HidePromptOnLeave = false;
			txtEmail.HideSelection = true;
			txtEmail.Hint = "Email";
			txtEmail.InsertKeyMode = InsertKeyMode.Default;
			txtEmail.LeadingIcon = null;
			txtEmail.Location = new Point(13, 245);
			txtEmail.Mask = "";
			txtEmail.MaxLength = 32767;
			txtEmail.MouseState = MaterialSkin.MouseState.OUT;
			txtEmail.Name = "txtEmail";
			txtEmail.PasswordChar = '\0';
			txtEmail.PrefixSuffixText = null;
			txtEmail.PromptChar = '_';
			txtEmail.ReadOnly = false;
			txtEmail.RejectInputOnFirstFailure = false;
			txtEmail.ResetOnPrompt = true;
			txtEmail.ResetOnSpace = true;
			txtEmail.RightToLeft = RightToLeft.No;
			txtEmail.SelectedText = "";
			txtEmail.SelectionLength = 0;
			txtEmail.SelectionStart = 0;
			txtEmail.ShortcutsEnabled = true;
			txtEmail.Size = new Size(575, 48);
			txtEmail.SkipLiterals = true;
			txtEmail.TabIndex = 4;
			txtEmail.TabStop = false;
			txtEmail.TextAlign = HorizontalAlignment.Left;
			txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtEmail.TrailingIcon = null;
			txtEmail.UseSystemPasswordChar = false;
			txtEmail.ValidatingType = null;
			// 
			// txtPasswordConfirm
			// 
			txtPasswordConfirm.AllowPromptAsInput = true;
			txtPasswordConfirm.AnimateReadOnly = false;
			txtPasswordConfirm.AsciiOnly = false;
			txtPasswordConfirm.BackgroundImageLayout = ImageLayout.None;
			txtPasswordConfirm.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtPasswordConfirm, 3);
			txtPasswordConfirm.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtPasswordConfirm.Depth = 0;
			txtPasswordConfirm.Dock = DockStyle.Fill;
			txtPasswordConfirm.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtPasswordConfirm.HidePromptOnLeave = false;
			txtPasswordConfirm.HideSelection = true;
			txtPasswordConfirm.Hint = "Password Confirm";
			txtPasswordConfirm.InsertKeyMode = InsertKeyMode.Default;
			txtPasswordConfirm.LeadingIcon = null;
			txtPasswordConfirm.Location = new Point(13, 129);
			txtPasswordConfirm.Mask = "";
			txtPasswordConfirm.MaxLength = 32767;
			txtPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT;
			txtPasswordConfirm.Name = "txtPasswordConfirm";
			txtPasswordConfirm.PasswordChar = '●';
			txtPasswordConfirm.PrefixSuffixText = null;
			txtPasswordConfirm.PromptChar = '_';
			txtPasswordConfirm.ReadOnly = false;
			txtPasswordConfirm.RejectInputOnFirstFailure = false;
			txtPasswordConfirm.ResetOnPrompt = true;
			txtPasswordConfirm.ResetOnSpace = true;
			txtPasswordConfirm.RightToLeft = RightToLeft.No;
			txtPasswordConfirm.SelectedText = "";
			txtPasswordConfirm.SelectionLength = 0;
			txtPasswordConfirm.SelectionStart = 0;
			txtPasswordConfirm.ShortcutsEnabled = true;
			txtPasswordConfirm.Size = new Size(575, 48);
			txtPasswordConfirm.SkipLiterals = true;
			txtPasswordConfirm.TabIndex = 2;
			txtPasswordConfirm.TabStop = false;
			txtPasswordConfirm.TextAlign = HorizontalAlignment.Left;
			txtPasswordConfirm.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtPasswordConfirm.TrailingIcon = null;
			txtPasswordConfirm.UseSystemPasswordChar = true;
			txtPasswordConfirm.ValidatingType = null;
			// 
			// txtPassword
			// 
			txtPassword.AllowPromptAsInput = true;
			txtPassword.AnimateReadOnly = false;
			txtPassword.AsciiOnly = false;
			txtPassword.BackgroundImageLayout = ImageLayout.None;
			txtPassword.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtPassword, 3);
			txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtPassword.Depth = 0;
			txtPassword.Dock = DockStyle.Fill;
			txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtPassword.HidePromptOnLeave = false;
			txtPassword.HideSelection = true;
			txtPassword.Hint = "Password";
			txtPassword.InsertKeyMode = InsertKeyMode.Default;
			txtPassword.LeadingIcon = null;
			txtPassword.Location = new Point(13, 71);
			txtPassword.Mask = "";
			txtPassword.MaxLength = 32767;
			txtPassword.MouseState = MaterialSkin.MouseState.OUT;
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '●';
			txtPassword.PrefixSuffixText = null;
			txtPassword.PromptChar = '_';
			txtPassword.ReadOnly = false;
			txtPassword.RejectInputOnFirstFailure = false;
			txtPassword.ResetOnPrompt = true;
			txtPassword.ResetOnSpace = true;
			txtPassword.RightToLeft = RightToLeft.No;
			txtPassword.SelectedText = "";
			txtPassword.SelectionLength = 0;
			txtPassword.SelectionStart = 0;
			txtPassword.ShortcutsEnabled = true;
			txtPassword.Size = new Size(575, 48);
			txtPassword.SkipLiterals = true;
			txtPassword.TabIndex = 1;
			txtPassword.TabStop = false;
			txtPassword.TextAlign = HorizontalAlignment.Left;
			txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtPassword.TrailingIcon = null;
			txtPassword.UseSystemPasswordChar = true;
			txtPassword.ValidatingType = null;
			// 
			// txtUsername
			// 
			txtUsername.AllowPromptAsInput = true;
			txtUsername.AnimateReadOnly = false;
			txtUsername.AsciiOnly = false;
			txtUsername.BackgroundImageLayout = ImageLayout.None;
			txtUsername.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtUsername, 3);
			txtUsername.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtUsername.Depth = 0;
			txtUsername.Dock = DockStyle.Fill;
			txtUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtUsername.HidePromptOnLeave = false;
			txtUsername.HideSelection = true;
			txtUsername.Hint = "Username";
			txtUsername.InsertKeyMode = InsertKeyMode.Default;
			txtUsername.LeadingIcon = null;
			txtUsername.Location = new Point(13, 13);
			txtUsername.Mask = "";
			txtUsername.MaxLength = 32767;
			txtUsername.MouseState = MaterialSkin.MouseState.OUT;
			txtUsername.Name = "txtUsername";
			txtUsername.PasswordChar = '\0';
			txtUsername.PrefixSuffixText = null;
			txtUsername.PromptChar = '_';
			txtUsername.ReadOnly = false;
			txtUsername.RejectInputOnFirstFailure = false;
			txtUsername.ResetOnPrompt = true;
			txtUsername.ResetOnSpace = true;
			txtUsername.RightToLeft = RightToLeft.No;
			txtUsername.SelectedText = "";
			txtUsername.SelectionLength = 0;
			txtUsername.SelectionStart = 0;
			txtUsername.ShortcutsEnabled = true;
			txtUsername.Size = new Size(575, 48);
			txtUsername.SkipLiterals = true;
			txtUsername.TabIndex = 0;
			txtUsername.TabStop = false;
			txtUsername.TextAlign = HorizontalAlignment.Left;
			txtUsername.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtUsername.TrailingIcon = null;
			txtUsername.UseSystemPasswordChar = false;
			txtUsername.ValidatingType = null;
			// 
			// btnCreateUser
			// 
			btnCreateUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel1.SetColumnSpan(btnCreateUser, 3);
			btnCreateUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			btnCreateUser.Depth = 0;
			btnCreateUser.Dock = DockStyle.Fill;
			btnCreateUser.Font = new Font("Fira Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCreateUser.HighEmphasis = true;
			btnCreateUser.Icon = null;
			btnCreateUser.Location = new Point(14, 306);
			btnCreateUser.Margin = new Padding(4, 6, 4, 6);
			btnCreateUser.MouseState = MaterialSkin.MouseState.HOVER;
			btnCreateUser.Name = "btnCreateUser";
			btnCreateUser.NoAccentTextColor = Color.Empty;
			btnCreateUser.Size = new Size(573, 51);
			btnCreateUser.TabIndex = 5;
			btnCreateUser.Text = "Crete User";
			btnCreateUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			btnCreateUser.UseAccentColor = false;
			btnCreateUser.UseVisualStyleBackColor = true;
			btnCreateUser.Click += btnCreateUser_Click;
			// 
			// cmbRole
			// 
			cmbRole.AutoResize = false;
			cmbRole.BackColor = Color.FromArgb(255, 255, 255);
			tableLayoutPanel1.SetColumnSpan(cmbRole, 3);
			cmbRole.Depth = 0;
			cmbRole.Dock = DockStyle.Fill;
			cmbRole.DrawMode = DrawMode.OwnerDrawVariable;
			cmbRole.DropDownHeight = 174;
			cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbRole.DropDownWidth = 121;
			cmbRole.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
			cmbRole.ForeColor = Color.FromArgb(222, 0, 0, 0);
			cmbRole.FormattingEnabled = true;
			cmbRole.Hint = "Role";
			cmbRole.IntegralHeight = false;
			cmbRole.ItemHeight = 43;
			cmbRole.Location = new Point(13, 187);
			cmbRole.MaxDropDownItems = 4;
			cmbRole.MouseState = MaterialSkin.MouseState.OUT;
			cmbRole.Name = "cmbRole";
			cmbRole.Size = new Size(575, 49);
			cmbRole.StartIndex = 0;
			cmbRole.TabIndex = 6;
			// 
			// frmCreateUserModel
			// 
			AutoScaleDimensions = new SizeF(12F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(materialCard1);
			Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4);
			Name = "frmCreateUserModel";
			Size = new Size(641, 413);
			Load += frmCreateUserModel_Load;
			materialCard1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPasswordConfirm;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnCreateUser;
        private MaterialSkin.Controls.MaterialComboBox cmbRole;
    }
}
