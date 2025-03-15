namespace BookstoreManagementSystemUI
{
    partial class frmPosCard
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
			pbCard = new PictureBox();
			txtTitle = new MaterialSkin.Controls.MaterialLabel();
			txtPrice = new Label();
			materialCard1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbCard).BeginInit();
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
			materialCard1.Size = new Size(200, 265);
			materialCard1.TabIndex = 0;
			materialCard1.Click += POSCard_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(pbCard, 0, 0);
			tableLayoutPanel1.Controls.Add(txtTitle, 0, 1);
			tableLayoutPanel1.Controls.Add(txtPrice, 0, 2);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(15, 15);
			tableLayoutPanel1.Margin = new Padding(4);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
			tableLayoutPanel1.Size = new Size(170, 235);
			tableLayoutPanel1.TabIndex = 2;
			tableLayoutPanel1.Click += POSCard_Click;
			// 
			// pbCard
			// 
			pbCard.Dock = DockStyle.Fill;
			pbCard.Image = Properties.Resources.book_open_line;
			pbCard.Location = new Point(4, 4);
			pbCard.Margin = new Padding(4);
			pbCard.Name = "pbCard";
			pbCard.Size = new Size(162, 133);
			pbCard.SizeMode = PictureBoxSizeMode.Zoom;
			pbCard.TabIndex = 0;
			pbCard.TabStop = false;
			pbCard.Click += POSCard_Click;
			// 
			// txtTitle
			// 
			txtTitle.AutoSize = true;
			txtTitle.Depth = 0;
			txtTitle.Dock = DockStyle.Fill;
			txtTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
			txtTitle.Location = new Point(4, 141);
			txtTitle.Margin = new Padding(4, 0, 4, 0);
			txtTitle.MouseState = MaterialSkin.MouseState.HOVER;
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(162, 67);
			txtTitle.TabIndex = 1;
			txtTitle.Text = "materialLa bel1sd fsdfsdf";
			txtTitle.TextAlign = ContentAlignment.MiddleCenter;
			txtTitle.Click += POSCard_Click;
			// 
			// txtPrice
			// 
			txtPrice.AutoSize = true;
			txtPrice.Dock = DockStyle.Fill;
			txtPrice.Font = new Font("Fira Code", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtPrice.ForeColor = Color.Green;
			txtPrice.Location = new Point(4, 208);
			txtPrice.Margin = new Padding(4, 0, 4, 0);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(162, 27);
			txtPrice.TabIndex = 2;
			txtPrice.Text = "100 LKR";
			txtPrice.TextAlign = ContentAlignment.MiddleCenter;
			txtPrice.Click += POSCard_Click;
			// 
			// frmPosCard
			// 
			AutoScaleDimensions = new SizeF(12F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(materialCard1);
			Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4);
			Name = "frmPosCard";
			Size = new Size(200, 265);
			Click += POSCard_Click;
			materialCard1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbCard).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private MaterialSkin.Controls.MaterialCard materialCard1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbCard;
        private MaterialSkin.Controls.MaterialLabel txtTitle;
        private Label txtPrice;
    }
}
