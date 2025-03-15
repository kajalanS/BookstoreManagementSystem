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
			frmDashboardPage1 = new Components.Dashboard.frmDashboardPage();
			tpPOS = new TabPage();
			frmPosPage1 = new Components.Pos.frmPosPage();
			tpOrderList = new TabPage();
			frmOrderListView = new Components.Dashboard.OrderList.frmOrderListPage();
			tpPreBooking = new TabPage();
			frmPreOrderListView = new Components.Dashboard.OrderList.frmOrderListPage();
			tpProfile = new TabPage();
			frmUserProfile1 = new Components.Models.Users.frmUserProfile();
			tpUserList = new TabPage();
			frmUserListPage1 = new Components.Dashboard.UserList.frmUserListPage();
			tpBookList = new TabPage();
			frmBookListPage1 = new Components.Dashboard.BookList.frmBookListPage();
			tpSupplierList = new TabPage();
			frmSupplierListPage1 = new Components.Dashboard.SupplierList.frmSupplierListPage();
			tpGeneral = new TabPage();
			tpActivityLog = new TabPage();
			frmActivityLogPage1 = new Components.Dashboard.ActivityLogList.frmActivityLogPage();
			imageList1 = new ImageList(components);
			mtcRootLayout.SuspendLayout();
			tpDashboard.SuspendLayout();
			tpPOS.SuspendLayout();
			tpOrderList.SuspendLayout();
			tpPreBooking.SuspendLayout();
			tpProfile.SuspendLayout();
			tpUserList.SuspendLayout();
			tpBookList.SuspendLayout();
			tpSupplierList.SuspendLayout();
			tpActivityLog.SuspendLayout();
			SuspendLayout();
			// 
			// mtcRootLayout
			// 
			mtcRootLayout.Controls.Add(tpDashboard);
			mtcRootLayout.Controls.Add(tpPOS);
			mtcRootLayout.Controls.Add(tpOrderList);
			mtcRootLayout.Controls.Add(tpPreBooking);
			mtcRootLayout.Controls.Add(tpProfile);
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
			mtcRootLayout.Size = new Size(1151, 619);
			mtcRootLayout.SizeMode = TabSizeMode.FillToRight;
			mtcRootLayout.TabIndex = 0;
			mtcRootLayout.SelectedIndexChanged += mtcRootLayout_SelectedIndexChanged;
			// 
			// tpDashboard
			// 
			tpDashboard.Controls.Add(frmDashboardPage1);
			tpDashboard.ImageKey = "dashboard.png";
			tpDashboard.Location = new Point(4, 62);
			tpDashboard.Margin = new Padding(4);
			tpDashboard.Name = "tpDashboard";
			tpDashboard.Padding = new Padding(4);
			tpDashboard.Size = new Size(1143, 553);
			tpDashboard.TabIndex = 0;
			tpDashboard.Text = "Dashboard";
			tpDashboard.UseVisualStyleBackColor = true;
			// 
			// frmDashboardPage1
			// 
			frmDashboardPage1.Dock = DockStyle.Fill;
			frmDashboardPage1.Location = new Point(4, 4);
			frmDashboardPage1.Margin = new Padding(3, 4, 3, 4);
			frmDashboardPage1.Name = "frmDashboardPage1";
			frmDashboardPage1.Size = new Size(1135, 545);
			frmDashboardPage1.TabIndex = 0;
			// 
			// tpPOS
			// 
			tpPOS.Controls.Add(frmPosPage1);
			tpPOS.ImageKey = "POS.png";
			tpPOS.Location = new Point(4, 62);
			tpPOS.Margin = new Padding(4);
			tpPOS.Name = "tpPOS";
			tpPOS.Padding = new Padding(4);
			tpPOS.Size = new Size(1143, 553);
			tpPOS.TabIndex = 1;
			tpPOS.Text = "POS";
			tpPOS.UseVisualStyleBackColor = true;
			// 
			// frmPosPage1
			// 
			frmPosPage1.Dock = DockStyle.Fill;
			frmPosPage1.Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			frmPosPage1.Location = new Point(4, 4);
			frmPosPage1.Margin = new Padding(4);
			frmPosPage1.Name = "frmPosPage1";
			frmPosPage1.ReloadPageDataDel = null;
			frmPosPage1.Size = new Size(1135, 545);
			frmPosPage1.TabIndex = 1;
			// 
			// tpOrderList
			// 
			tpOrderList.Controls.Add(frmOrderListView);
			tpOrderList.ImageKey = "orderList.png";
			tpOrderList.Location = new Point(4, 62);
			tpOrderList.Margin = new Padding(4);
			tpOrderList.Name = "tpOrderList";
			tpOrderList.Size = new Size(1143, 553);
			tpOrderList.TabIndex = 2;
			tpOrderList.Text = "Order List";
			tpOrderList.UseVisualStyleBackColor = true;
			// 
			// frmOrderListView
			// 
			frmOrderListView.Dock = DockStyle.Fill;
			frmOrderListView.Location = new Point(0, 0);
			frmOrderListView.Margin = new Padding(3, 2, 3, 2);
			frmOrderListView.Name = "frmOrderListView";
			frmOrderListView.Size = new Size(1143, 553);
			frmOrderListView.TabIndex = 0;
			// 
			// tpPreBooking
			// 
			tpPreBooking.Controls.Add(frmPreOrderListView);
			tpPreBooking.ImageKey = "preBooking.png";
			tpPreBooking.Location = new Point(4, 62);
			tpPreBooking.Margin = new Padding(4);
			tpPreBooking.Name = "tpPreBooking";
			tpPreBooking.Size = new Size(1143, 553);
			tpPreBooking.TabIndex = 3;
			tpPreBooking.Text = "Pre-Booking";
			tpPreBooking.UseVisualStyleBackColor = true;
			// 
			// frmPreOrderListView
			// 
			frmPreOrderListView.Dock = DockStyle.Fill;
			frmPreOrderListView.Location = new Point(0, 0);
			frmPreOrderListView.Margin = new Padding(3, 2, 3, 2);
			frmPreOrderListView.Name = "frmPreOrderListView";
			frmPreOrderListView.Size = new Size(1143, 553);
			frmPreOrderListView.TabIndex = 0;
			// 
			// tpProfile
			// 
			tpProfile.Controls.Add(frmUserProfile1);
			tpProfile.ImageKey = "profile.png";
			tpProfile.Location = new Point(4, 62);
			tpProfile.Margin = new Padding(4);
			tpProfile.Name = "tpProfile";
			tpProfile.Size = new Size(1143, 553);
			tpProfile.TabIndex = 4;
			tpProfile.Text = "Profile";
			tpProfile.UseVisualStyleBackColor = true;
			// 
			// frmUserProfile1
			// 
			frmUserProfile1.Dock = DockStyle.Fill;
			frmUserProfile1.Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			frmUserProfile1.Location = new Point(0, 0);
			frmUserProfile1.Margin = new Padding(4);
			frmUserProfile1.Name = "frmUserProfile1";
			frmUserProfile1.Size = new Size(1143, 553);
			frmUserProfile1.TabIndex = 0;
			// 
			// tpUserList
			// 
			tpUserList.Controls.Add(frmUserListPage1);
			tpUserList.ImageKey = "userList.png";
			tpUserList.Location = new Point(4, 31);
			tpUserList.Margin = new Padding(4);
			tpUserList.Name = "tpUserList";
			tpUserList.Size = new Size(1830, 986);
			tpUserList.TabIndex = 6;
			tpUserList.Text = "User List";
			tpUserList.UseVisualStyleBackColor = true;
			// 
			// frmUserListPage1
			// 
			frmUserListPage1.Dock = DockStyle.Fill;
			frmUserListPage1.Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			frmUserListPage1.Location = new Point(0, 0);
			frmUserListPage1.Margin = new Padding(4, 3, 4, 3);
			frmUserListPage1.Name = "frmUserListPage1";
			frmUserListPage1.Size = new Size(1830, 986);
			frmUserListPage1.TabIndex = 0;
			// 
			// tpBookList
			// 
			tpBookList.Controls.Add(frmBookListPage1);
			tpBookList.ImageKey = "bookList.png";
			tpBookList.Location = new Point(4, 31);
			tpBookList.Margin = new Padding(4);
			tpBookList.Name = "tpBookList";
			tpBookList.Size = new Size(1830, 986);
			tpBookList.TabIndex = 7;
			tpBookList.Text = "Book List";
			tpBookList.UseVisualStyleBackColor = true;
			// 
			// frmBookListPage1
			// 
			frmBookListPage1.Dock = DockStyle.Fill;
			frmBookListPage1.Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			frmBookListPage1.Location = new Point(0, 0);
			frmBookListPage1.Margin = new Padding(4, 3, 4, 3);
			frmBookListPage1.Name = "frmBookListPage1";
			frmBookListPage1.Size = new Size(1830, 986);
			frmBookListPage1.TabIndex = 0;
			// 
			// tpSupplierList
			// 
			tpSupplierList.Controls.Add(frmSupplierListPage1);
			tpSupplierList.ImageKey = "suppliesrList.png";
			tpSupplierList.Location = new Point(4, 62);
			tpSupplierList.Margin = new Padding(4);
			tpSupplierList.Name = "tpSupplierList";
			tpSupplierList.Size = new Size(1143, 553);
			tpSupplierList.TabIndex = 8;
			tpSupplierList.Text = "Supplier List";
			tpSupplierList.UseVisualStyleBackColor = true;
			// 
			// frmSupplierListPage1
			// 
			frmSupplierListPage1.Dock = DockStyle.Fill;
			frmSupplierListPage1.Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			frmSupplierListPage1.Location = new Point(0, 0);
			frmSupplierListPage1.Margin = new Padding(4, 3, 4, 3);
			frmSupplierListPage1.Name = "frmSupplierListPage1";
			frmSupplierListPage1.Size = new Size(1143, 553);
			frmSupplierListPage1.TabIndex = 0;
			// 
			// tpGeneral
			// 
			tpGeneral.ImageKey = "general.png";
			tpGeneral.Location = new Point(4, 62);
			tpGeneral.Margin = new Padding(4);
			tpGeneral.Name = "tpGeneral";
			tpGeneral.Size = new Size(1143, 553);
			tpGeneral.TabIndex = 9;
			tpGeneral.Text = "General";
			tpGeneral.UseVisualStyleBackColor = true;
			// 
			// tpActivityLog
			// 
			tpActivityLog.Controls.Add(frmActivityLogPage1);
			tpActivityLog.ImageKey = "activityLog.png";
			tpActivityLog.Location = new Point(4, 62);
			tpActivityLog.Margin = new Padding(4);
			tpActivityLog.Name = "tpActivityLog";
			tpActivityLog.Size = new Size(1143, 553);
			tpActivityLog.TabIndex = 10;
			tpActivityLog.Text = "Activity Log";
			tpActivityLog.UseVisualStyleBackColor = true;
			// 
			// frmActivityLogPage1
			// 
			frmActivityLogPage1.Dock = DockStyle.Fill;
			frmActivityLogPage1.Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			frmActivityLogPage1.Location = new Point(0, 0);
			frmActivityLogPage1.Margin = new Padding(4, 3, 4, 3);
			frmActivityLogPage1.Name = "frmActivityLogPage1";
			frmActivityLogPage1.Size = new Size(1143, 553);
			frmActivityLogPage1.TabIndex = 0;
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
			AutoScaleDimensions = new SizeF(12F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1159, 700);
			Controls.Add(mtcRootLayout);
			DrawerShowIconsWhenHidden = true;
			DrawerTabControl = mtcRootLayout;
			DrawerWidth = 250;
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
			tpDashboard.ResumeLayout(false);
			tpPOS.ResumeLayout(false);
			tpOrderList.ResumeLayout(false);
			tpPreBooking.ResumeLayout(false);
			tpProfile.ResumeLayout(false);
			tpUserList.ResumeLayout(false);
			tpBookList.ResumeLayout(false);
			tpSupplierList.ResumeLayout(false);
			tpActivityLog.ResumeLayout(false);
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
        private TabPage tpUserList;
        private TabPage tpBookList;
        private TabPage tpSupplierList;
        private TabPage tpGeneral;
        private TabPage tpActivityLog;
        private Components.Pos.frmPosPage frmPosPage1;
        private Components.Dashboard.frmDashboardPage frmDashboardPage1;
        private Components.Dashboard.OrderList.frmOrderListPage frmOrderListView;
        private Components.Dashboard.OrderList.frmOrderListPage frmPreOrderListView;
		private Components.Dashboard.UserList.frmUserListPage frmUserListPage1;
		private Components.Dashboard.BookList.frmBookListPage frmBookListPage1;
		private Components.Dashboard.SupplierList.frmSupplierListPage frmSupplierListPage1;
		private Components.Dashboard.ActivityLogList.frmActivityLogPage frmActivityLogPage1;
		private Components.Models.Users.frmUserProfile frmUserProfile1;
	}
}