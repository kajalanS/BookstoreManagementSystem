namespace BookstoreManagementSystemUI.Forms
{
    partial class frmCreateCustomer
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
            frmCreateUserModel1 = new Components.Models.Users.frmCreateUserModel();
            SuspendLayout();
            // 
            // frmCreateUserModel1
            // 
            frmCreateUserModel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frmCreateUserModel1.Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmCreateUserModel1.Location = new Point(8, 71);
            frmCreateUserModel1.Margin = new Padding(5);
            frmCreateUserModel1.Name = "frmCreateUserModel1";
            frmCreateUserModel1.Size = new Size(607, 554);
            frmCreateUserModel1.TabIndex = 0;
            // 
            // frmCreateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 634);
            Controls.Add(frmCreateUserModel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmCreateCustomer";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New User";
            Load += frmCreateCustomer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Components.Models.Users.frmCreateUserModel frmCreateUserModel1;
    }
}