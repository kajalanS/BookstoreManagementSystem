namespace BookstoreManagementSystemUI.Components.Dashboard
{
    partial class frmDashboardCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardCard));
            panel1 = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbCardImage = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblSubTitle = new Label();
            onExportClick = new Button();
            lblTitle = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCardImage).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(tableLayoutPanel1);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(20, 20);
            materialCard1.Margin = new Padding(16, 19, 16, 19);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16, 19, 16, 19);
            materialCard1.Size = new Size(360, 360);
            materialCard1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pbCardImage, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(16, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(328, 322);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pbCardImage
            // 
            tableLayoutPanel1.SetColumnSpan(pbCardImage, 4);
            pbCardImage.Dock = DockStyle.Fill;
            pbCardImage.Image = Properties.Resources.order_bg;
            pbCardImage.Location = new Point(3, 3);
            pbCardImage.Name = "pbCardImage";
            tableLayoutPanel1.SetRowSpan(pbCardImage, 3);
            pbCardImage.Size = new Size(322, 234);
            pbCardImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbCardImage.TabIndex = 2;
            pbCardImage.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 4);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769234F));
            tableLayoutPanel2.Controls.Add(lblSubTitle, 0, 1);
            tableLayoutPanel2.Controls.Add(onExportClick, 2, 0);
            tableLayoutPanel2.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 243);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(322, 76);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(lblSubTitle, 2);
            lblSubTitle.Dock = DockStyle.Fill;
            lblSubTitle.Font = new Font("Fira Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.ForestGreen;
            lblSubTitle.Location = new Point(3, 38);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(240, 38);
            lblSubTitle.TabIndex = 4;
            lblSubTitle.Text = "100";
            lblSubTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // onExportClick
            // 
            onExportClick.BackColor = Color.WhiteSmoke;
            onExportClick.Dock = DockStyle.Fill;
            onExportClick.FlatAppearance.BorderSize = 0;
            onExportClick.FlatStyle = FlatStyle.Flat;
            onExportClick.Image = (Image)resources.GetObject("onExportClick.Image");
            onExportClick.Location = new Point(249, 3);
            onExportClick.Name = "onExportClick";
            tableLayoutPanel2.SetRowSpan(onExportClick, 2);
            onExportClick.Size = new Size(70, 70);
            onExportClick.TabIndex = 3;
            onExportClick.UseVisualStyleBackColor = false;
            onExportClick.Click += onExportClick_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(lblTitle, 2);
            lblTitle.Depth = 0;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTitle.Location = new Point(3, 0);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(240, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Total Orders";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDashboardCard
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDashboardCard";
            Size = new Size(400, 400);
            Load += frmDashboardCard_Load;
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCardImage).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbCardImage;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblSubTitle;
        private Button onExportClick;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
    }
}
