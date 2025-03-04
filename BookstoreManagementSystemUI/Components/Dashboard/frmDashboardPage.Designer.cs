namespace BookstoreManagementSystemUI.Components.Dashboard
{
    partial class frmDashboardPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardPage));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            imageList1 = new ImageList(components);
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(51, 44);
            materialCard1.Margin = new Padding(14, 14, 14, 14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 14, 14, 14);
            materialCard1.Size = new Size(361, 128);
            materialCard1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(27, 74);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(27, 29);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "20";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(27, 24);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(134, 29);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Total Orders";
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = null;
            materialFloatingActionButton1.ImageKey = "book-open-line.png";
            materialFloatingActionButton1.ImageList = imageList1;
            materialFloatingActionButton1.Location = new Point(386, 80);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(56, 56);
            materialFloatingActionButton1.TabIndex = 1;
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "book-open-line.png");
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = null;
            materialFloatingActionButton2.ImageKey = "book-open-line.png";
            materialFloatingActionButton2.ImageList = imageList1;
            materialFloatingActionButton2.Location = new Point(813, 80);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(56, 56);
            materialFloatingActionButton2.TabIndex = 3;
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialLabel3);
            materialCard2.Controls.Add(materialLabel4);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(478, 44);
            materialCard2.Margin = new Padding(14, 14, 14, 14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14, 14, 14, 14);
            materialCard2.Size = new Size(361, 128);
            materialCard2.TabIndex = 2;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(27, 74);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(102, 29);
            materialLabel3.TabIndex = 1;
            materialLabel3.Text = "2000 LKR";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel4.Location = new Point(27, 24);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(143, 29);
            materialLabel4.TabIndex = 0;
            materialLabel4.Text = "Total Income";
            // 
            // frmDashboardPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialFloatingActionButton2);
            Controls.Add(materialCard2);
            Controls.Add(materialFloatingActionButton1);
            Controls.Add(materialCard1);
            Name = "frmDashboardPage";
            Size = new Size(1221, 644);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}
