namespace BookstoreManagementSystemUI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            pictureBox1 = new PictureBox();
            txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            lnkCreateNewUser = new LinkLabel();
            lnkResetPassword = new LinkLabel();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.DialogResult = DialogResult.OK;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(21, 643);
            btnLogin.Margin = new Padding(5, 6, 5, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(501, 36);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(txtPassword);
            materialCard1.Controls.Add(txtUsername);
            materialCard1.Controls.Add(btnLogin);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(21, 73);
            materialCard1.Margin = new Padding(18, 15, 18, 15);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(18, 15, 18, 15);
            materialCard1.Size = new Size(543, 710);
            materialCard1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BookHaven___Book_Store_Logo;
            pictureBox1.Location = new Point(21, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.AllowPromptAsInput = true;
            txtPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.AnimateReadOnly = false;
            txtPassword.AsciiOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.BeepOnError = false;
            txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(21, 586);
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
            txtPassword.Size = new Size(501, 48);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 2;
            txtPassword.TabStop = false;
            txtPassword.Text = "password";
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ValidatingType = null;
            // 
            // txtUsername
            // 
            txtUsername.AllowPromptAsInput = true;
            txtUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.AnimateReadOnly = false;
            txtUsername.AsciiOnly = false;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.BeepOnError = false;
            txtUsername.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.HidePromptOnLeave = false;
            txtUsername.HideSelection = true;
            txtUsername.Hint = "Username";
            txtUsername.InsertKeyMode = InsertKeyMode.Default;
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(21, 532);
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
            txtUsername.Size = new Size(501, 48);
            txtUsername.SkipLiterals = true;
            txtUsername.TabIndex = 1;
            txtUsername.TabStop = false;
            txtUsername.Text = "username";
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            txtUsername.ValidatingType = null;
            // 
            // lnkCreateNewUser
            // 
            lnkCreateNewUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lnkCreateNewUser.AutoSize = true;
            lnkCreateNewUser.LinkColor = Color.FromArgb(79, 55, 138);
            lnkCreateNewUser.Location = new Point(21, 807);
            lnkCreateNewUser.Name = "lnkCreateNewUser";
            lnkCreateNewUser.Size = new Size(143, 17);
            lnkCreateNewUser.TabIndex = 2;
            lnkCreateNewUser.TabStop = true;
            lnkCreateNewUser.Text = "Create New User";
            lnkCreateNewUser.LinkClicked += lnkCreateNewUser_LinkClicked;
            // 
            // lnkResetPassword
            // 
            lnkResetPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lnkResetPassword.AutoSize = true;
            lnkResetPassword.LinkColor = Color.FromArgb(79, 55, 138);
            lnkResetPassword.Location = new Point(437, 807);
            lnkResetPassword.Name = "lnkResetPassword";
            lnkResetPassword.Size = new Size(134, 17);
            lnkResetPassword.TabIndex = 3;
            lnkResetPassword.TabStop = true;
            lnkResetPassword.Text = "Reset Password";
            lnkResetPassword.LinkClicked += lnkResetPassword_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 855);
            Controls.Add(lnkResetPassword);
            Controls.Add(lnkCreateNewUser);
            Controls.Add(materialCard1);
            Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmLogin";
            Padding = new Padding(3, 24, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore Management System";
            Load += frmLogin_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername;
        private LinkLabel lnkCreateNewUser;
        private LinkLabel lnkResetPassword;
        private PictureBox pictureBox1;
    }
}
