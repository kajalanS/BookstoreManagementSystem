namespace BookstoreManagementSystemUI.Components.Core
{
  partial class frmFullTableView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            mcActionCard = new MaterialSkin.Controls.MaterialCard();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnView = new MaterialSkin.Controls.MaterialButton();
            btnEdit = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnExport = new MaterialSkin.Controls.MaterialButton();
            btnImport = new MaterialSkin.Controls.MaterialButton();
            btnAdd = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            mlvTableView = new MaterialSkin.Controls.MaterialListView();
            tableLayoutPanel1.SuspendLayout();
            mcActionCard.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(mcActionCard, 2, 0);
            tableLayoutPanel1.Controls.Add(materialCard2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(902, 641);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // mcActionCard
            // 
            mcActionCard.BackColor = Color.FromArgb(255, 255, 255);
            mcActionCard.Controls.Add(tableLayoutPanel3);
            mcActionCard.Depth = 0;
            mcActionCard.Dock = DockStyle.Fill;
            mcActionCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcActionCard.Location = new Point(692, 20);
            mcActionCard.Margin = new Padding(5);
            mcActionCard.MouseState = MaterialSkin.MouseState.HOVER;
            mcActionCard.Name = "mcActionCard";
            mcActionCard.Padding = new Padding(5);
            mcActionCard.Size = new Size(190, 601);
            mcActionCard.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnView, 0, 6);
            tableLayoutPanel3.Controls.Add(btnEdit, 0, 0);
            tableLayoutPanel3.Controls.Add(btnDelete, 0, 1);
            tableLayoutPanel3.Controls.Add(btnExport, 0, 2);
            tableLayoutPanel3.Controls.Add(btnImport, 0, 3);
            tableLayoutPanel3.Controls.Add(btnAdd, 0, 7);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.Size = new Size(180, 591);
            tableLayoutPanel3.TabIndex = 4;
            tableLayoutPanel3.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnView.Depth = 0;
            btnView.Dock = DockStyle.Fill;
            btnView.HighEmphasis = true;
            btnView.Icon = null;
            btnView.Location = new Point(4, 477);
            btnView.Margin = new Padding(4, 6, 4, 6);
            btnView.MouseState = MaterialSkin.MouseState.HOVER;
            btnView.Name = "btnView";
            btnView.NoAccentTextColor = Color.Empty;
            btnView.Size = new Size(172, 48);
            btnView.TabIndex = 6;
            btnView.Text = "View";
            btnView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnView.UseAccentColor = false;
            btnView.UseVisualStyleBackColor = true;
            btnView.Visible = false;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEdit.Depth = 0;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Enabled = false;
            btnEdit.HighEmphasis = true;
            btnEdit.Icon = null;
            btnEdit.Location = new Point(4, 6);
            btnEdit.Margin = new Padding(4, 6, 4, 6);
            btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            btnEdit.Name = "btnEdit";
            btnEdit.NoAccentTextColor = Color.Empty;
            btnEdit.Size = new Size(172, 36);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEdit.UseAccentColor = false;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Enabled = false;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(4, 54);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(172, 36);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExport.Depth = 0;
            btnExport.Dock = DockStyle.Fill;
            btnExport.HighEmphasis = true;
            btnExport.Icon = null;
            btnExport.Location = new Point(4, 102);
            btnExport.Margin = new Padding(4, 6, 4, 6);
            btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            btnExport.Name = "btnExport";
            btnExport.NoAccentTextColor = Color.Empty;
            btnExport.Size = new Size(172, 36);
            btnExport.TabIndex = 2;
            btnExport.Text = "Extra 01";
            btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExport.UseAccentColor = false;
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Visible = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImport.Depth = 0;
            btnImport.Dock = DockStyle.Fill;
            btnImport.HighEmphasis = true;
            btnImport.Icon = null;
            btnImport.Location = new Point(4, 150);
            btnImport.Margin = new Padding(4, 6, 4, 6);
            btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            btnImport.Name = "btnImport";
            btnImport.NoAccentTextColor = Color.Empty;
            btnImport.Size = new Size(172, 36);
            btnImport.TabIndex = 3;
            btnImport.Text = "Extra 2";
            btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImport.UseAccentColor = false;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Visible = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.Location = new Point(4, 537);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(172, 48);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(mlvTableView);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(20, 20);
            materialCard2.Margin = new Padding(5);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(5);
            materialCard2.Size = new Size(642, 601);
            materialCard2.TabIndex = 4;
            // 
            // mlvTableView
            // 
            mlvTableView.Activation = ItemActivation.OneClick;
            mlvTableView.AutoSizeTable = false;
            mlvTableView.BackColor = Color.FromArgb(255, 255, 255);
            mlvTableView.BorderStyle = BorderStyle.None;
            mlvTableView.Depth = 0;
            mlvTableView.Dock = DockStyle.Fill;
            mlvTableView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mlvTableView.FullRowSelect = true;
            mlvTableView.LabelEdit = true;
            mlvTableView.LabelWrap = false;
            mlvTableView.Location = new Point(5, 5);
            mlvTableView.MinimumSize = new Size(200, 100);
            mlvTableView.MouseLocation = new Point(-1, -1);
            mlvTableView.MouseState = MaterialSkin.MouseState.OUT;
            mlvTableView.MultiSelect = false;
            mlvTableView.Name = "mlvTableView";
            mlvTableView.OwnerDraw = true;
            mlvTableView.Size = new Size(632, 591);
            mlvTableView.TabIndex = 3;
            mlvTableView.UseCompatibleStateImageBehavior = false;
            mlvTableView.View = View.Details;
            mlvTableView.SelectedIndexChanged += mlvTableView_SelectedIndexChanged;
            mlvTableView.Click += mlvTableView_SelectedIndexChanged;
            // 
            // frmFullTableView
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmFullTableView";
            Size = new Size(902, 641);
            tableLayoutPanel1.ResumeLayout(false);
            mcActionCard.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            materialCard2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    private MaterialSkin.Controls.MaterialCard materialCard2;
    public MaterialSkin.Controls.MaterialListView mlvTableView;
        private TableLayoutPanel tableLayoutPanel3;
        public MaterialSkin.Controls.MaterialButton btnView;
        public MaterialSkin.Controls.MaterialButton btnEdit;
        public MaterialSkin.Controls.MaterialButton btnDelete;
        public MaterialSkin.Controls.MaterialButton btnExport;
        public MaterialSkin.Controls.MaterialButton btnImport;
        public MaterialSkin.Controls.MaterialButton btnAdd;
        public MaterialSkin.Controls.MaterialCard mcActionCard;
    }
}
