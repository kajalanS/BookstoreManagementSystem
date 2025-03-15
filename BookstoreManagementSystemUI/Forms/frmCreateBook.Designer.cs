namespace BookstoreManagementSystemUI.Forms
{
    partial class frmCreateBook
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
            frmCreateBookModel1 = new Components.Models.Books.frmCreateBookModel();
            SuspendLayout();
            // 
            // frmCreateBookModel1
            // 
            frmCreateBookModel1.Dock = DockStyle.Fill;
            frmCreateBookModel1.Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmCreateBookModel1.Location = new Point(3, 64);
            frmCreateBookModel1.Margin = new Padding(4);
            frmCreateBookModel1.Name = "frmCreateBookModel1";
            frmCreateBookModel1.Size = new Size(694, 533);
            frmCreateBookModel1.TabIndex = 0;
            // 
            // frmCreateBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 600);
            Controls.Add(frmCreateBookModel1);
            MaximizeBox = false;
            MaximumSize = new Size(700, 600);
            MinimumSize = new Size(700, 600);
            Name = "frmCreateBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Book";
            ResumeLayout(false);
        }

        #endregion

        private Components.Models.Books.frmCreateBookModel frmCreateBookModel1;
    }
}