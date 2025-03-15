namespace BookstoreManagementSystemUI.Components.Pos
{
    partial class frmPosPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosPage));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCheckout = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label5 = new Label();
            lblTotalOrderList = new Label();
            flpCheckoutShelf = new FlowLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnCreateBook = new MaterialSkin.Controls.MaterialButton();
            flpCategoryShelf = new FlowLayoutPanel();
            btnFindText = new MaterialSkin.Controls.MaterialButton();
            txtFinText = new MaterialSkin.Controls.MaterialMaskedTextBox();
            flpBookShelf = new FlowLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnPreBooking = new MaterialSkin.Controls.MaterialButton();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            materialCard1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            materialCard2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnCheckout, 3, 5);
            tableLayoutPanel1.Controls.Add(materialCard1, 3, 1);
            tableLayoutPanel1.Controls.Add(materialCard2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.363519F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 96.63648F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 228F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(1353, 758);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCheckout
            // 
            btnCheckout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCheckout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCheckout.Depth = 0;
            btnCheckout.Dock = DockStyle.Fill;
            btnCheckout.HighEmphasis = true;
            btnCheckout.Icon = null;
            btnCheckout.Location = new Point(951, 663);
            btnCheckout.Margin = new Padding(6, 8, 6, 8);
            btnCheckout.MouseState = MaterialSkin.MouseState.HOVER;
            btnCheckout.Name = "btnCheckout";
            btnCheckout.NoAccentTextColor = Color.Empty;
            btnCheckout.Size = new Size(375, 58);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Checkout";
            btnCheckout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCheckout.UseAccentColor = false;
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel2);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(945, 13);
            materialCard1.Margin = new Padding(0);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(20);
            tableLayoutPanel1.SetRowSpan(materialCard1, 3);
            materialCard1.Size = new Size(387, 629);
            materialCard1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 1, 3);
            tableLayoutPanel2.Controls.Add(lblTotalOrderList, 2, 3);
            tableLayoutPanel2.Controls.Add(flpCheckoutShelf, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 20);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.Size = new Size(347, 589);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Fira Code", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 126);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(19, 474);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 87);
            label5.TabIndex = 4;
            label5.Text = "Total";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalOrderList
            // 
            lblTotalOrderList.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(lblTotalOrderList, 2);
            lblTotalOrderList.Dock = DockStyle.Fill;
            lblTotalOrderList.Font = new Font("Fira Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOrderList.Location = new Point(124, 474);
            lblTotalOrderList.Margin = new Padding(4, 0, 4, 0);
            lblTotalOrderList.Name = "lblTotalOrderList";
            lblTotalOrderList.Size = new Size(202, 87);
            lblTotalOrderList.TabIndex = 5;
            lblTotalOrderList.Text = "100 LKR";
            lblTotalOrderList.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpCheckoutShelf
            // 
            flpCheckoutShelf.AutoScroll = true;
            flpCheckoutShelf.BackColor = SystemColors.InactiveBorder;
            tableLayoutPanel2.SetColumnSpan(flpCheckoutShelf, 4);
            flpCheckoutShelf.Dock = DockStyle.Fill;
            flpCheckoutShelf.FlowDirection = FlowDirection.TopDown;
            flpCheckoutShelf.Location = new Point(19, 158);
            flpCheckoutShelf.Margin = new Padding(4);
            flpCheckoutShelf.Name = "flpCheckoutShelf";
            flpCheckoutShelf.Size = new Size(324, 312);
            flpCheckoutShelf.TabIndex = 6;
            flpCheckoutShelf.WrapContents = false;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(tableLayoutPanel4);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(20, 13);
            materialCard2.Margin = new Padding(0);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(20);
            tableLayoutPanel1.SetRowSpan(materialCard2, 3);
            materialCard2.Size = new Size(905, 629);
            materialCard2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.WhiteSmoke;
            tableLayoutPanel4.ColumnCount = 9;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(btnCreateBook, 1, 1);
            tableLayoutPanel4.Controls.Add(flpCategoryShelf, 1, 5);
            tableLayoutPanel4.Controls.Add(btnFindText, 7, 1);
            tableLayoutPanel4.Controls.Add(txtFinText, 5, 1);
            tableLayoutPanel4.Controls.Add(flpBookShelf, 1, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(20, 20);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel4.Size = new Size(865, 589);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnCreateBook
            // 
            btnCreateBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreateBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreateBook.Depth = 0;
            btnCreateBook.Dock = DockStyle.Fill;
            btnCreateBook.DrawShadows = false;
            btnCreateBook.HighEmphasis = false;
            btnCreateBook.Icon = (Image)resources.GetObject("btnCreateBook.Icon");
            btnCreateBook.Location = new Point(26, 29);
            btnCreateBook.Margin = new Padding(6, 8, 6, 8);
            btnCreateBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreateBook.Name = "btnCreateBook";
            btnCreateBook.NoAccentTextColor = Color.Empty;
            btnCreateBook.Size = new Size(188, 40);
            btnCreateBook.TabIndex = 1;
            btnCreateBook.Text = "Add New Book";
            btnCreateBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreateBook.UseAccentColor = false;
            btnCreateBook.UseVisualStyleBackColor = true;
            btnCreateBook.Click += btnCreateBook_Click;
            // 
            // flpCategoryShelf
            // 
            flpCategoryShelf.AutoScroll = true;
            tableLayoutPanel4.SetColumnSpan(flpCategoryShelf, 7);
            flpCategoryShelf.Dock = DockStyle.Fill;
            flpCategoryShelf.Location = new Point(24, 470);
            flpCategoryShelf.Margin = new Padding(4);
            flpCategoryShelf.Name = "flpCategoryShelf";
            flpCategoryShelf.Size = new Size(816, 94);
            flpCategoryShelf.TabIndex = 2;
            flpCategoryShelf.WrapContents = false;
            // 
            // btnFindText
            // 
            btnFindText.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFindText.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFindText.Depth = 0;
            btnFindText.Dock = DockStyle.Fill;
            btnFindText.HighEmphasis = true;
            btnFindText.Icon = Properties.Resources.search_2_line;
            btnFindText.Location = new Point(720, 29);
            btnFindText.Margin = new Padding(6, 8, 6, 8);
            btnFindText.MouseState = MaterialSkin.MouseState.HOVER;
            btnFindText.Name = "btnFindText";
            btnFindText.NoAccentTextColor = Color.Empty;
            btnFindText.Size = new Size(118, 40);
            btnFindText.TabIndex = 3;
            btnFindText.Text = "Find";
            btnFindText.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFindText.UseAccentColor = false;
            btnFindText.UseVisualStyleBackColor = true;
            btnFindText.Click += btnFindText_Click;
            // 
            // txtFinText
            // 
            txtFinText.AllowPromptAsInput = true;
            txtFinText.AnimateReadOnly = false;
            txtFinText.AsciiOnly = false;
            txtFinText.BackgroundImageLayout = ImageLayout.None;
            txtFinText.BeepOnError = false;
            txtFinText.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtFinText.Depth = 0;
            txtFinText.Dock = DockStyle.Fill;
            txtFinText.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFinText.HidePromptOnLeave = false;
            txtFinText.HideSelection = true;
            txtFinText.Hint = "Search Books";
            txtFinText.InsertKeyMode = InsertKeyMode.Default;
            txtFinText.LeadingIcon = null;
            txtFinText.Location = new Point(481, 25);
            txtFinText.Margin = new Padding(4);
            txtFinText.Mask = "";
            txtFinText.MaxLength = 32767;
            txtFinText.MouseState = MaterialSkin.MouseState.OUT;
            txtFinText.Name = "txtFinText";
            txtFinText.PasswordChar = '\0';
            txtFinText.PrefixSuffixText = null;
            txtFinText.PromptChar = '_';
            txtFinText.ReadOnly = false;
            txtFinText.RejectInputOnFirstFailure = false;
            txtFinText.ResetOnPrompt = true;
            txtFinText.ResetOnSpace = true;
            txtFinText.RightToLeft = RightToLeft.No;
            txtFinText.SelectedText = "";
            txtFinText.SelectionLength = 0;
            txtFinText.SelectionStart = 0;
            txtFinText.ShortcutsEnabled = true;
            txtFinText.Size = new Size(209, 48);
            txtFinText.SkipLiterals = true;
            txtFinText.TabIndex = 4;
            txtFinText.TabStop = false;
            txtFinText.TextAlign = HorizontalAlignment.Left;
            txtFinText.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtFinText.TrailingIcon = null;
            txtFinText.UseSystemPasswordChar = false;
            txtFinText.ValidatingType = null;
            // 
            // flpBookShelf
            // 
            flpBookShelf.AutoScroll = true;
            tableLayoutPanel4.SetColumnSpan(flpBookShelf, 7);
            flpBookShelf.Dock = DockStyle.Fill;
            flpBookShelf.Location = new Point(24, 97);
            flpBookShelf.Margin = new Padding(4);
            flpBookShelf.Name = "flpBookShelf";
            flpBookShelf.Size = new Size(816, 349);
            flpBookShelf.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.7175F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.2825011F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Controls.Add(btnPreBooking, 4, 0);
            tableLayoutPanel3.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(24, 659);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(897, 66);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // btnPreBooking
            // 
            btnPreBooking.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPreBooking.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPreBooking.Depth = 0;
            btnPreBooking.Dock = DockStyle.Fill;
            btnPreBooking.HighEmphasis = true;
            btnPreBooking.Icon = null;
            btnPreBooking.Location = new Point(744, 8);
            btnPreBooking.Margin = new Padding(6, 8, 6, 8);
            btnPreBooking.MouseState = MaterialSkin.MouseState.HOVER;
            btnPreBooking.Name = "btnPreBooking";
            btnPreBooking.NoAccentTextColor = Color.Empty;
            btnPreBooking.Size = new Size(116, 50);
            btnPreBooking.TabIndex = 0;
            btnPreBooking.Text = "Pre-Booking";
            btnPreBooking.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPreBooking.UseAccentColor = false;
            btnPreBooking.Click += btnPreBooking_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.ForeColor = Color.IndianRed;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(643, 8);
            btnCancel.Margin = new Padding(6, 8, 6, 8);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 50);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = true;
            btnCancel.UseCompatibleTextRendering = true;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmPosPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPosPage";
            Size = new Size(1353, 758);
            Load += frmPosPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            materialCard1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            materialCard2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnCheckout;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label5;
        private Label lblTotalOrderList;
        private FlowLayoutPanel flpCheckoutShelf;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialButton btnCreateBook;
        private FlowLayoutPanel flpCategoryShelf;
        private MaterialSkin.Controls.MaterialButton btnFindText;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtFinText;
        private FlowLayoutPanel flpBookShelf;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnPreBooking;
        private MaterialSkin.Controls.MaterialButton btnCancel;
    }
}
