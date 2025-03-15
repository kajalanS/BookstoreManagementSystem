namespace BookstoreManagementSystemUI.Components.Models.Users
{
    partial class frmUserProfile
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
			materialCard2 = new MaterialSkin.Controls.MaterialCard();
			lblUsername = new Label();
			txtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
			materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			txtRole = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
			btnUpdate = new MaterialSkin.Controls.MaterialButton();
			txtLastLogin = new MaterialSkin.Controls.MaterialMaskedTextBox();
			materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
			txtConfirmPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
			materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			materialCard1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			materialCard2.SuspendLayout();
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
			materialCard1.Margin = new Padding(5);
			materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			materialCard1.Name = "materialCard1";
			materialCard1.Padding = new Padding(5);
			materialCard1.Size = new Size(1129, 654);
			materialCard1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 302F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
			tableLayoutPanel1.Controls.Add(materialCard2, 0, 0);
			tableLayoutPanel1.Controls.Add(txtUsername, 1, 2);
			tableLayoutPanel1.Controls.Add(materialLabel1, 0, 2);
			tableLayoutPanel1.Controls.Add(materialLabel2, 0, 4);
			tableLayoutPanel1.Controls.Add(materialLabel3, 0, 5);
			tableLayoutPanel1.Controls.Add(txtRole, 1, 5);
			tableLayoutPanel1.Controls.Add(txtEmail, 1, 4);
			tableLayoutPanel1.Controls.Add(btnUpdate, 3, 10);
			tableLayoutPanel1.Controls.Add(txtLastLogin, 1, 6);
			tableLayoutPanel1.Controls.Add(materialLabel4, 0, 6);
			tableLayoutPanel1.Controls.Add(txtPassword, 1, 7);
			tableLayoutPanel1.Controls.Add(txtConfirmPassword, 1, 8);
			tableLayoutPanel1.Controls.Add(materialLabel5, 0, 7);
			tableLayoutPanel1.Controls.Add(materialLabel6, 0, 8);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(5, 5);
			tableLayoutPanel1.Margin = new Padding(15);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.Padding = new Padding(15);
			tableLayoutPanel1.RowCount = 10;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(1119, 644);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// materialCard2
			// 
			materialCard2.BackColor = Color.FromArgb(255, 255, 255);
			tableLayoutPanel1.SetColumnSpan(materialCard2, 4);
			materialCard2.Controls.Add(lblUsername);
			materialCard2.Depth = 0;
			materialCard2.Dock = DockStyle.Fill;
			materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
			materialCard2.Location = new Point(15, 15);
			materialCard2.Margin = new Padding(0);
			materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
			materialCard2.Name = "materialCard2";
			materialCard2.Padding = new Padding(14);
			materialCard2.Size = new Size(1089, 100);
			materialCard2.TabIndex = 0;
			// 
			// lblUsername
			// 
			lblUsername.Dock = DockStyle.Fill;
			lblUsername.Font = new Font("Fira Code", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblUsername.Location = new Point(14, 14);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(1061, 72);
			lblUsername.TabIndex = 0;
			lblUsername.Text = "UserName";
			lblUsername.TextAlign = ContentAlignment.MiddleCenter;
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
			txtUsername.Location = new Point(218, 138);
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
			txtUsername.Size = new Size(883, 48);
			txtUsername.SkipLiterals = true;
			txtUsername.TabIndex = 1;
			txtUsername.TabStop = false;
			txtUsername.TextAlign = HorizontalAlignment.Left;
			txtUsername.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtUsername.TrailingIcon = null;
			txtUsername.UseSystemPasswordChar = false;
			txtUsername.ValidatingType = null;
			// 
			// materialLabel1
			// 
			materialLabel1.AutoSize = true;
			materialLabel1.Depth = 0;
			materialLabel1.Dock = DockStyle.Fill;
			materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel1.Location = new Point(18, 135);
			materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel1.Name = "materialLabel1";
			materialLabel1.Size = new Size(194, 54);
			materialLabel1.TabIndex = 3;
			materialLabel1.Text = "Username";
			materialLabel1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// materialLabel2
			// 
			materialLabel2.AutoSize = true;
			materialLabel2.Depth = 0;
			materialLabel2.Dock = DockStyle.Fill;
			materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel2.Location = new Point(18, 189);
			materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel2.Name = "materialLabel2";
			materialLabel2.Size = new Size(194, 54);
			materialLabel2.TabIndex = 4;
			materialLabel2.Text = "Email";
			materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// materialLabel3
			// 
			materialLabel3.AutoSize = true;
			materialLabel3.Depth = 0;
			materialLabel3.Dock = DockStyle.Fill;
			materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel3.Location = new Point(18, 243);
			materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel3.Name = "materialLabel3";
			materialLabel3.Size = new Size(194, 54);
			materialLabel3.TabIndex = 5;
			materialLabel3.Text = "Role";
			materialLabel3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtRole
			// 
			txtRole.AllowPromptAsInput = true;
			txtRole.AnimateReadOnly = false;
			txtRole.AsciiOnly = false;
			txtRole.BackgroundImageLayout = ImageLayout.None;
			txtRole.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtRole, 3);
			txtRole.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtRole.Depth = 0;
			txtRole.Dock = DockStyle.Fill;
			txtRole.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtRole.HidePromptOnLeave = false;
			txtRole.HideSelection = true;
			txtRole.Hint = "Role";
			txtRole.InsertKeyMode = InsertKeyMode.Default;
			txtRole.LeadingIcon = null;
			txtRole.Location = new Point(218, 246);
			txtRole.Mask = "";
			txtRole.MaxLength = 32767;
			txtRole.MouseState = MaterialSkin.MouseState.OUT;
			txtRole.Name = "txtRole";
			txtRole.PasswordChar = '\0';
			txtRole.PrefixSuffixText = null;
			txtRole.PromptChar = '_';
			txtRole.ReadOnly = true;
			txtRole.RejectInputOnFirstFailure = false;
			txtRole.ResetOnPrompt = true;
			txtRole.ResetOnSpace = true;
			txtRole.RightToLeft = RightToLeft.No;
			txtRole.SelectedText = "";
			txtRole.SelectionLength = 0;
			txtRole.SelectionStart = 0;
			txtRole.ShortcutsEnabled = true;
			txtRole.Size = new Size(883, 48);
			txtRole.SkipLiterals = true;
			txtRole.TabIndex = 7;
			txtRole.TabStop = false;
			txtRole.TextAlign = HorizontalAlignment.Left;
			txtRole.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtRole.TrailingIcon = null;
			txtRole.UseSystemPasswordChar = false;
			txtRole.ValidatingType = null;
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
			txtEmail.Location = new Point(218, 192);
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
			txtEmail.Size = new Size(883, 48);
			txtEmail.SkipLiterals = true;
			txtEmail.TabIndex = 6;
			txtEmail.TabStop = false;
			txtEmail.TextAlign = HorizontalAlignment.Left;
			txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtEmail.TrailingIcon = null;
			txtEmail.UseSystemPasswordChar = false;
			txtEmail.ValidatingType = null;
			// 
			// btnUpdate
			// 
			btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			btnUpdate.Depth = 0;
			btnUpdate.Dock = DockStyle.Fill;
			btnUpdate.HighEmphasis = true;
			btnUpdate.Icon = null;
			btnUpdate.Location = new Point(908, 575);
			btnUpdate.Margin = new Padding(4, 6, 4, 6);
			btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
			btnUpdate.Name = "btnUpdate";
			btnUpdate.NoAccentTextColor = Color.Empty;
			btnUpdate.Size = new Size(192, 48);
			btnUpdate.TabIndex = 8;
			btnUpdate.Text = "Update";
			btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			btnUpdate.UseAccentColor = false;
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtLastLogin
			// 
			txtLastLogin.AllowPromptAsInput = true;
			txtLastLogin.AnimateReadOnly = false;
			txtLastLogin.AsciiOnly = false;
			txtLastLogin.BackgroundImageLayout = ImageLayout.None;
			txtLastLogin.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtLastLogin, 3);
			txtLastLogin.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtLastLogin.Depth = 0;
			txtLastLogin.Dock = DockStyle.Fill;
			txtLastLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtLastLogin.HidePromptOnLeave = false;
			txtLastLogin.HideSelection = true;
			txtLastLogin.Hint = "Last Login";
			txtLastLogin.InsertKeyMode = InsertKeyMode.Default;
			txtLastLogin.LeadingIcon = null;
			txtLastLogin.Location = new Point(218, 300);
			txtLastLogin.Mask = "";
			txtLastLogin.MaxLength = 32767;
			txtLastLogin.MouseState = MaterialSkin.MouseState.OUT;
			txtLastLogin.Name = "txtLastLogin";
			txtLastLogin.PasswordChar = '\0';
			txtLastLogin.PrefixSuffixText = null;
			txtLastLogin.PromptChar = '_';
			txtLastLogin.ReadOnly = true;
			txtLastLogin.RejectInputOnFirstFailure = false;
			txtLastLogin.ResetOnPrompt = true;
			txtLastLogin.ResetOnSpace = true;
			txtLastLogin.RightToLeft = RightToLeft.No;
			txtLastLogin.SelectedText = "";
			txtLastLogin.SelectionLength = 0;
			txtLastLogin.SelectionStart = 0;
			txtLastLogin.ShortcutsEnabled = true;
			txtLastLogin.Size = new Size(883, 48);
			txtLastLogin.SkipLiterals = true;
			txtLastLogin.TabIndex = 9;
			txtLastLogin.TabStop = false;
			txtLastLogin.TextAlign = HorizontalAlignment.Left;
			txtLastLogin.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtLastLogin.TrailingIcon = null;
			txtLastLogin.UseSystemPasswordChar = false;
			txtLastLogin.ValidatingType = null;
			// 
			// materialLabel4
			// 
			materialLabel4.AutoSize = true;
			materialLabel4.Depth = 0;
			materialLabel4.Dock = DockStyle.Fill;
			materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel4.Location = new Point(18, 297);
			materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel4.Name = "materialLabel4";
			materialLabel4.Size = new Size(194, 54);
			materialLabel4.TabIndex = 10;
			materialLabel4.Text = "Last Login";
			materialLabel4.TextAlign = ContentAlignment.MiddleLeft;
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
			txtPassword.Location = new Point(218, 354);
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
			txtPassword.Size = new Size(883, 48);
			txtPassword.SkipLiterals = true;
			txtPassword.TabIndex = 11;
			txtPassword.TabStop = false;
			txtPassword.TextAlign = HorizontalAlignment.Left;
			txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtPassword.TrailingIcon = null;
			txtPassword.UseSystemPasswordChar = true;
			txtPassword.ValidatingType = null;
			// 
			// txtConfirmPassword
			// 
			txtConfirmPassword.AllowPromptAsInput = true;
			txtConfirmPassword.AnimateReadOnly = false;
			txtConfirmPassword.AsciiOnly = false;
			txtConfirmPassword.BackgroundImageLayout = ImageLayout.None;
			txtConfirmPassword.BeepOnError = false;
			tableLayoutPanel1.SetColumnSpan(txtConfirmPassword, 3);
			txtConfirmPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			txtConfirmPassword.Depth = 0;
			txtConfirmPassword.Dock = DockStyle.Fill;
			txtConfirmPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtConfirmPassword.HidePromptOnLeave = false;
			txtConfirmPassword.HideSelection = true;
			txtConfirmPassword.Hint = "Password";
			txtConfirmPassword.InsertKeyMode = InsertKeyMode.Default;
			txtConfirmPassword.LeadingIcon = null;
			txtConfirmPassword.Location = new Point(218, 408);
			txtConfirmPassword.Mask = "";
			txtConfirmPassword.MaxLength = 32767;
			txtConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
			txtConfirmPassword.Name = "txtConfirmPassword";
			txtConfirmPassword.PasswordChar = '●';
			txtConfirmPassword.PrefixSuffixText = null;
			txtConfirmPassword.PromptChar = '_';
			txtConfirmPassword.ReadOnly = false;
			txtConfirmPassword.RejectInputOnFirstFailure = false;
			txtConfirmPassword.ResetOnPrompt = true;
			txtConfirmPassword.ResetOnSpace = true;
			txtConfirmPassword.RightToLeft = RightToLeft.No;
			txtConfirmPassword.SelectedText = "";
			txtConfirmPassword.SelectionLength = 0;
			txtConfirmPassword.SelectionStart = 0;
			txtConfirmPassword.ShortcutsEnabled = true;
			txtConfirmPassword.Size = new Size(883, 48);
			txtConfirmPassword.SkipLiterals = true;
			txtConfirmPassword.TabIndex = 12;
			txtConfirmPassword.TabStop = false;
			txtConfirmPassword.TextAlign = HorizontalAlignment.Left;
			txtConfirmPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			txtConfirmPassword.TrailingIcon = null;
			txtConfirmPassword.UseSystemPasswordChar = true;
			txtConfirmPassword.ValidatingType = null;
			// 
			// materialLabel5
			// 
			materialLabel5.AutoSize = true;
			materialLabel5.Depth = 0;
			materialLabel5.Dock = DockStyle.Fill;
			materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel5.Location = new Point(18, 351);
			materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel5.Name = "materialLabel5";
			materialLabel5.Size = new Size(194, 54);
			materialLabel5.TabIndex = 13;
			materialLabel5.Text = "Password";
			materialLabel5.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// materialLabel6
			// 
			materialLabel6.AutoSize = true;
			materialLabel6.Depth = 0;
			materialLabel6.Dock = DockStyle.Fill;
			materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			materialLabel6.Location = new Point(18, 405);
			materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			materialLabel6.Name = "materialLabel6";
			materialLabel6.Size = new Size(194, 54);
			materialLabel6.TabIndex = 14;
			materialLabel6.Text = "Confirm Password";
			materialLabel6.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// frmUserProfile
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(materialCard1);
			Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4);
			Name = "frmUserProfile";
			Size = new Size(1129, 654);
			materialCard1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			materialCard2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label lblUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtRole;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmail;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtLastLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
		private MaterialSkin.Controls.MaterialMaskedTextBox txtConfirmPassword;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
	}
}
