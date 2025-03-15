namespace BookstoreManagementSystemUI.Forms
{
	partial class frmSplashScreen
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
			tableLayoutPanel1 = new TableLayoutPanel();
			mpbSplashScreenProgress = new MaterialSkin.Controls.MaterialProgressBar();
			pictureBox1 = new PictureBox();
			materialCard1 = new MaterialSkin.Controls.MaterialCard();
			tmrSplashScreenTimer = new System.Windows.Forms.Timer(components);
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			materialCard1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(mpbSplashScreenProgress, 0, 1);
			tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(14, 14);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.Size = new Size(766, 419);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// mpbSplashScreenProgress
			// 
			tableLayoutPanel1.SetColumnSpan(mpbSplashScreenProgress, 2);
			mpbSplashScreenProgress.Depth = 0;
			mpbSplashScreenProgress.Dock = DockStyle.Fill;
			mpbSplashScreenProgress.Location = new Point(3, 411);
			mpbSplashScreenProgress.MouseState = MaterialSkin.MouseState.HOVER;
			mpbSplashScreenProgress.Name = "mpbSplashScreenProgress";
			mpbSplashScreenProgress.Size = new Size(760, 5);
			mpbSplashScreenProgress.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = Properties.Resources.BookHaven___Book_Store_Logo;
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(760, 402);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// materialCard1
			// 
			materialCard1.BackColor = Color.FromArgb(255, 255, 255);
			materialCard1.Controls.Add(tableLayoutPanel1);
			materialCard1.Depth = 0;
			materialCard1.Dock = DockStyle.Fill;
			materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
			materialCard1.Location = new Point(3, 0);
			materialCard1.Margin = new Padding(14);
			materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			materialCard1.Name = "materialCard1";
			materialCard1.Padding = new Padding(14);
			materialCard1.Size = new Size(794, 447);
			materialCard1.TabIndex = 1;
			// 
			// tmrSplashScreenTimer
			// 
			tmrSplashScreenTimer.Interval = 50;
			tmrSplashScreenTimer.Tick += tmrSplashScreenTimer_Tick;
			// 
			// frmSplashScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(materialCard1);
			FormStyle = FormStyles.StatusAndActionBar_None;
			MaximumSize = new Size(800, 450);
			MinimumSize = new Size(800, 450);
			Name = "frmSplashScreen";
			Padding = new Padding(3, 0, 3, 3);
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmSplashScreen";
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			materialCard1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private MaterialSkin.Controls.MaterialProgressBar mpbSplashScreenProgress;
		private PictureBox pictureBox1;
		private MaterialSkin.Controls.MaterialCard materialCard1;
		private System.Windows.Forms.Timer tmrSplashScreenTimer;
	}
}