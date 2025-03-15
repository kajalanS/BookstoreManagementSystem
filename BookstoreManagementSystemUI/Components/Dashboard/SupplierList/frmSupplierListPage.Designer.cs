namespace BookstoreManagementSystemUI.Components.Dashboard.SupplierList
{
	partial class frmSupplierListPage
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
			frmFullTableView1 = new Core.frmFullTableView();
			SuspendLayout();
			// 
			// frmFullTableView1
			// 
			frmFullTableView1.Dock = DockStyle.Fill;
			frmFullTableView1.Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			frmFullTableView1.Location = new Point(0, 0);
			frmFullTableView1.Margin = new Padding(4, 3, 4, 3);
			frmFullTableView1.Name = "frmFullTableView1";
			frmFullTableView1.OnAddClicked = null;
			frmFullTableView1.OnDeleteClicked = null;
			frmFullTableView1.OnEditClicked = null;
			frmFullTableView1.OnExportClicked = null;
			frmFullTableView1.OnImportClicked = null;
			frmFullTableView1.OnViewClicked = null;
			frmFullTableView1.Size = new Size(1004, 666);
			frmFullTableView1.TabIndex = 0;
			// 
			// frmSupplierListPage
			// 
			AutoScaleDimensions = new SizeF(11F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(frmFullTableView1);
			Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4, 3, 4, 3);
			Name = "frmSupplierListPage";
			Size = new Size(1004, 666);
			ResumeLayout(false);
		}

		#endregion

		private Core.frmFullTableView frmFullTableView1;
	}
}
