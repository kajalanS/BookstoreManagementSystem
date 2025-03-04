namespace BookstoreManagementSystemUI.Components.Auth
{
    partial class frmPasswordReset
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
            lblMessage = new MaterialSkin.Controls.MaterialLabel();
            txtEmail = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnSendMail = new MaterialSkin.Controls.MaterialButton();
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
            materialCard1.Margin = new Padding(15);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(15);
            materialCard1.Size = new Size(635, 233);
            materialCard1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lblMessage, 0, 0);
            tableLayoutPanel1.Controls.Add(txtEmail, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSendMail, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(15, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(605, 203);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblMessage, 3);
            lblMessage.Depth = 0;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblMessage.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblMessage.Location = new Point(3, 0);
            lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(599, 101);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Enter the email address you used when you joined and we'll send you Instructons to reset your password.";
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
            txtEmail.LeadingIcon = Properties.Resources.email;
            txtEmail.Location = new Point(3, 104);
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
            txtEmail.Size = new Size(599, 48);
            txtEmail.SkipLiterals = true;
            txtEmail.TabIndex = 1;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
            // 
            // btnSendMail
            // 
            btnSendMail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSendMail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSendMail.Depth = 0;
            btnSendMail.Dock = DockStyle.Fill;
            btnSendMail.HighEmphasis = true;
            btnSendMail.Icon = null;
            btnSendMail.Location = new Point(406, 161);
            btnSendMail.Margin = new Padding(4, 6, 4, 6);
            btnSendMail.MouseState = MaterialSkin.MouseState.HOVER;
            btnSendMail.Name = "btnSendMail";
            btnSendMail.NoAccentTextColor = Color.Empty;
            btnSendMail.Size = new Size(195, 36);
            btnSendMail.TabIndex = 2;
            btnSendMail.Text = "Send Email";
            btnSendMail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSendMail.UseAccentColor = false;
            btnSendMail.UseVisualStyleBackColor = true;
            btnSendMail.Click += btnSendMail_Click;
            // 
            // frmPasswordReset
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(570, 190);
            Name = "frmPasswordReset";
            Size = new Size(635, 233);
            materialCard1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private MaterialSkin.Controls.MaterialButton btnSendMail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmail;
    }
}
