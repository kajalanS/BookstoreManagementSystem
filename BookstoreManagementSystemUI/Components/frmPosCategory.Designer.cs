namespace BookstoreManagementSystemUI.Components
{
    partial class frmPosCategory
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
            btnToggleCategory = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnToggleCategory
            // 
            btnToggleCategory.AutoSize = false;
            btnToggleCategory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnToggleCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnToggleCategory.Depth = 0;
            btnToggleCategory.Dock = DockStyle.Fill;
            btnToggleCategory.DrawShadows = false;
            btnToggleCategory.HighEmphasis = false;
            btnToggleCategory.Icon = null;
            btnToggleCategory.Location = new Point(0, 0);
            btnToggleCategory.Margin = new Padding(4, 6, 4, 6);
            btnToggleCategory.MouseState = MaterialSkin.MouseState.HOVER;
            btnToggleCategory.Name = "btnToggleCategory";
            btnToggleCategory.NoAccentTextColor = Color.Empty;
            btnToggleCategory.Size = new Size(200, 40);
            btnToggleCategory.TabIndex = 0;
            btnToggleCategory.Text = "materialButton1";
            btnToggleCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnToggleCategory.UseAccentColor = false;
            btnToggleCategory.UseVisualStyleBackColor = true;
            btnToggleCategory.Click += btnToggleCategory_Click;
            // 
            // frmPosCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnToggleCategory);
            Name = "frmPosCategory";
            Size = new Size(200, 40);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnToggleCategory;
    }
}
