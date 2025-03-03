namespace BookstoreManagementSystemUI.Forms
{
    partial class frmDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            mtcRootLayout = new MaterialSkin.Controls.MaterialTabControl();
            tpDashboard = new TabPage();
            tpPOS = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label5 = new Label();
            lblTotalOrderList = new Label();
            flpCheckoutShelf = new FlowLayoutPanel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel4 = new TableLayoutPanel();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            flpCategoryShelf = new FlowLayoutPanel();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            flpBookShelf = new FlowLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            tpOrderList = new TabPage();
            tpPreBooking = new TabPage();
            tpProfile = new TabPage();
            tpPasswordChange = new TabPage();
            tpUserList = new TabPage();
            tpBookList = new TabPage();
            tpSupplierList = new TabPage();
            tpGeneral = new TabPage();
            tpActivityLog = new TabPage();
            imageList1 = new ImageList(components);
            mtcRootLayout.SuspendLayout();
            tpPOS.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            materialCard1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            materialCard2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // mtcRootLayout
            // 
            mtcRootLayout.Controls.Add(tpDashboard);
            mtcRootLayout.Controls.Add(tpPOS);
            mtcRootLayout.Controls.Add(tpOrderList);
            mtcRootLayout.Controls.Add(tpPreBooking);
            mtcRootLayout.Controls.Add(tpProfile);
            mtcRootLayout.Controls.Add(tpPasswordChange);
            mtcRootLayout.Controls.Add(tpUserList);
            mtcRootLayout.Controls.Add(tpBookList);
            mtcRootLayout.Controls.Add(tpSupplierList);
            mtcRootLayout.Controls.Add(tpGeneral);
            mtcRootLayout.Controls.Add(tpActivityLog);
            mtcRootLayout.Depth = 0;
            mtcRootLayout.Dock = DockStyle.Fill;
            mtcRootLayout.ImageList = imageList1;
            mtcRootLayout.Location = new Point(4, 77);
            mtcRootLayout.Margin = new Padding(4);
            mtcRootLayout.MouseState = MaterialSkin.MouseState.HOVER;
            mtcRootLayout.Multiline = true;
            mtcRootLayout.Name = "mtcRootLayout";
            mtcRootLayout.SelectedIndex = 0;
            mtcRootLayout.Size = new Size(1228, 789);
            mtcRootLayout.SizeMode = TabSizeMode.FillToRight;
            mtcRootLayout.TabIndex = 0;
            mtcRootLayout.SelectedIndexChanged += mtcRootLayout_SelectedIndexChanged;
            // 
            // tpDashboard
            // 
            tpDashboard.ImageKey = "dashboard.png";
            tpDashboard.Location = new Point(4, 58);
            tpDashboard.Margin = new Padding(4);
            tpDashboard.Name = "tpDashboard";
            tpDashboard.Padding = new Padding(4);
            tpDashboard.Size = new Size(1220, 727);
            tpDashboard.TabIndex = 0;
            tpDashboard.Text = "Dashboard";
            tpDashboard.UseVisualStyleBackColor = true;
            // 
            // tpPOS
            // 
            tpPOS.Controls.Add(tableLayoutPanel1);
            tpPOS.ImageKey = "POS.png";
            tpPOS.Location = new Point(4, 58);
            tpPOS.Margin = new Padding(4);
            tpPOS.Name = "tpPOS";
            tpPOS.Padding = new Padding(4);
            tpPOS.Size = new Size(1220, 727);
            tpPOS.TabIndex = 1;
            tpPOS.Text = "POS";
            tpPOS.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.210787F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.7892151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(materialButton1, 3, 5);
            tableLayoutPanel1.Controls.Add(materialCard1, 3, 1);
            tableLayoutPanel1.Controls.Add(materialCard2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.36351871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 96.63648F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1212, 719);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Fill;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(795, 633);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(392, 59);
            materialButton1.TabIndex = 0;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel2);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(791, 15);
            materialCard1.Margin = new Padding(0);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            tableLayoutPanel1.SetRowSpan(materialCard1, 3);
            materialCard1.Size = new Size(400, 603);
            materialCard1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Controls.Add(label1, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 1, 3);
            tableLayoutPanel2.Controls.Add(lblTotalOrderList, 2, 3);
            tableLayoutPanel2.Controls.Add(flpCheckoutShelf, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(14, 14);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(372, 575);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Fira Code", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(345, 90);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(13, 493);
            label5.Name = "label5";
            label5.Size = new Size(111, 62);
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
            lblTotalOrderList.Location = new Point(130, 493);
            lblTotalOrderList.Name = "lblTotalOrderList";
            lblTotalOrderList.Size = new Size(228, 62);
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
            flpCheckoutShelf.Location = new Point(13, 113);
            flpCheckoutShelf.Name = "flpCheckoutShelf";
            flpCheckoutShelf.Size = new Size(356, 377);
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
            materialCard2.Location = new Point(9, 15);
            materialCard2.Margin = new Padding(0);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            tableLayoutPanel1.SetRowSpan(materialCard2, 3);
            materialCard2.Size = new Size(774, 603);
            materialCard2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.WhiteSmoke;
            tableLayoutPanel4.ColumnCount = 9;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(materialButton5, 1, 1);
            tableLayoutPanel4.Controls.Add(flpCategoryShelf, 1, 5);
            tableLayoutPanel4.Controls.Add(materialButton4, 7, 1);
            tableLayoutPanel4.Controls.Add(materialMaskedTextBox1, 5, 1);
            tableLayoutPanel4.Controls.Add(flpBookShelf, 1, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(14, 14);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(746, 575);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // materialButton5
            // 
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.Dock = DockStyle.Fill;
            materialButton5.DrawShadows = false;
            materialButton5.HighEmphasis = false;
            materialButton5.Icon = (Image)resources.GetObject("materialButton5.Icon");
            materialButton5.Location = new Point(24, 26);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(149, 48);
            materialButton5.TabIndex = 1;
            materialButton5.Text = "Add New Book";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            // 
            // flpCategoryShelf
            // 
            flpCategoryShelf.AutoScroll = true;
            tableLayoutPanel4.SetColumnSpan(flpCategoryShelf, 7);
            flpCategoryShelf.Dock = DockStyle.Fill;
            flpCategoryShelf.Location = new Point(23, 485);
            flpCategoryShelf.Name = "flpCategoryShelf";
            flpCategoryShelf.Size = new Size(699, 67);
            flpCategoryShelf.TabIndex = 2;
            flpCategoryShelf.WrapContents = false;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.Dock = DockStyle.Fill;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = Properties.Resources.search_2_line;
            materialButton4.Location = new Point(637, 26);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(84, 48);
            materialButton4.TabIndex = 3;
            materialButton4.Text = "Find";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Dock = DockStyle.Fill;
            materialMaskedTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.Hint = "Search Books";
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(421, 23);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(197, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 4;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // flpBookShelf
            // 
            flpBookShelf.AutoScroll = true;
            tableLayoutPanel4.SetColumnSpan(flpBookShelf, 7);
            flpBookShelf.Dock = DockStyle.Fill;
            flpBookShelf.Location = new Point(23, 95);
            flpBookShelf.Name = "flpBookShelf";
            flpBookShelf.Size = new Size(699, 376);
            flpBookShelf.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.7175F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.2825011F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(materialButton2, 4, 0);
            tableLayoutPanel3.Controls.Add(materialButton3, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(12, 630);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(768, 65);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Dock = DockStyle.Fill;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(585, 6);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(158, 53);
            materialButton2.TabIndex = 0;
            materialButton2.Text = "materialButton2";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.Dock = DockStyle.Fill;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(410, 6);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(158, 53);
            materialButton3.TabIndex = 1;
            materialButton3.Text = "materialButton3";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // tpOrderList
            // 
            tpOrderList.ImageKey = "orderList.png";
            tpOrderList.Location = new Point(4, 31);
            tpOrderList.Margin = new Padding(4);
            tpOrderList.Name = "tpOrderList";
            tpOrderList.Size = new Size(1220, 754);
            tpOrderList.TabIndex = 2;
            tpOrderList.Text = "Order List";
            tpOrderList.UseVisualStyleBackColor = true;
            // 
            // tpPreBooking
            // 
            tpPreBooking.ImageKey = "preBooking.png";
            tpPreBooking.Location = new Point(4, 31);
            tpPreBooking.Margin = new Padding(4);
            tpPreBooking.Name = "tpPreBooking";
            tpPreBooking.Size = new Size(1220, 754);
            tpPreBooking.TabIndex = 3;
            tpPreBooking.Text = "Pre-Booking";
            tpPreBooking.UseVisualStyleBackColor = true;
            // 
            // tpProfile
            // 
            tpProfile.ImageKey = "profile.png";
            tpProfile.Location = new Point(4, 31);
            tpProfile.Margin = new Padding(4);
            tpProfile.Name = "tpProfile";
            tpProfile.Size = new Size(1220, 754);
            tpProfile.TabIndex = 4;
            tpProfile.Text = "Profile";
            tpProfile.UseVisualStyleBackColor = true;
            // 
            // tpPasswordChange
            // 
            tpPasswordChange.ImageKey = "changePassword.png";
            tpPasswordChange.Location = new Point(4, 31);
            tpPasswordChange.Margin = new Padding(4);
            tpPasswordChange.Name = "tpPasswordChange";
            tpPasswordChange.Size = new Size(1220, 754);
            tpPasswordChange.TabIndex = 5;
            tpPasswordChange.Text = "Password Change";
            tpPasswordChange.UseVisualStyleBackColor = true;
            // 
            // tpUserList
            // 
            tpUserList.ImageKey = "userList.png";
            tpUserList.Location = new Point(4, 31);
            tpUserList.Margin = new Padding(4);
            tpUserList.Name = "tpUserList";
            tpUserList.Size = new Size(1220, 754);
            tpUserList.TabIndex = 6;
            tpUserList.Text = "User List";
            tpUserList.UseVisualStyleBackColor = true;
            // 
            // tpBookList
            // 
            tpBookList.ImageKey = "bookList.png";
            tpBookList.Location = new Point(4, 31);
            tpBookList.Margin = new Padding(4);
            tpBookList.Name = "tpBookList";
            tpBookList.Size = new Size(1220, 754);
            tpBookList.TabIndex = 7;
            tpBookList.Text = "Book List";
            tpBookList.UseVisualStyleBackColor = true;
            // 
            // tpSupplierList
            // 
            tpSupplierList.ImageKey = "suppliesrList.png";
            tpSupplierList.Location = new Point(4, 31);
            tpSupplierList.Margin = new Padding(4);
            tpSupplierList.Name = "tpSupplierList";
            tpSupplierList.Size = new Size(1220, 754);
            tpSupplierList.TabIndex = 8;
            tpSupplierList.Text = "Supplier List";
            tpSupplierList.UseVisualStyleBackColor = true;
            // 
            // tpGeneral
            // 
            tpGeneral.ImageKey = "general.png";
            tpGeneral.Location = new Point(4, 31);
            tpGeneral.Margin = new Padding(4);
            tpGeneral.Name = "tpGeneral";
            tpGeneral.Size = new Size(1220, 754);
            tpGeneral.TabIndex = 9;
            tpGeneral.Text = "General";
            tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpActivityLog
            // 
            tpActivityLog.ImageKey = "activityLog.png";
            tpActivityLog.Location = new Point(4, 31);
            tpActivityLog.Margin = new Padding(4);
            tpActivityLog.Name = "tpActivityLog";
            tpActivityLog.Size = new Size(1220, 754);
            tpActivityLog.TabIndex = 10;
            tpActivityLog.Text = "Activity Log";
            tpActivityLog.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "activityLog.png");
            imageList1.Images.SetKeyName(1, "add-circle-line.png");
            imageList1.Images.SetKeyName(2, "add-large-line.png");
            imageList1.Images.SetKeyName(3, "bookList.png");
            imageList1.Images.SetKeyName(4, "changePassword.png");
            imageList1.Images.SetKeyName(5, "dashboard.png");
            imageList1.Images.SetKeyName(6, "delete-bin-line.png");
            imageList1.Images.SetKeyName(7, "general.png");
            imageList1.Images.SetKeyName(8, "indeterminate-circle-line.png");
            imageList1.Images.SetKeyName(9, "orderList.png");
            imageList1.Images.SetKeyName(10, "POS.png");
            imageList1.Images.SetKeyName(11, "preBooking.png");
            imageList1.Images.SetKeyName(12, "profile.png");
            imageList1.Images.SetKeyName(13, "search-2-line.png");
            imageList1.Images.SetKeyName(14, "suppliesrList.png");
            imageList1.Images.SetKeyName(15, "userList.png");
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 870);
            Controls.Add(mtcRootLayout);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = mtcRootLayout;
            Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Padding = new Padding(4, 77, 4, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmDashboard_FormClosed;
            Load += frmDashboard_Load;
            mtcRootLayout.ResumeLayout(false);
            tpPOS.ResumeLayout(false);
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

        private MaterialSkin.Controls.MaterialTabControl mtcRootLayout;
        private TabPage tpDashboard;
        private TabPage tpPOS;
        private ImageList imageList1;
        private TabPage tpOrderList;
        private TabPage tpPreBooking;
        private TabPage tpProfile;
        private TabPage tpPasswordChange;
        private TabPage tpUserList;
        private TabPage tpBookList;
        private TabPage tpSupplierList;
        private TabPage tpGeneral;
        private TabPage tpActivityLog;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label5;
        private Label lblTotalOrderList;
        private FlowLayoutPanel flpCheckoutShelf;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private FlowLayoutPanel flpCategoryShelf;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private FlowLayoutPanel flpBookShelf;
    }
}