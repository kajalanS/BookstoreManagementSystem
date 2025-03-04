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
            frmCreateUserModel1.Dock = DockStyle.Fill;
            frmCreateUserModel1.Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmCreateUserModel1.Location = new Point(3, 64);
            frmCreateUserModel1.Margin = new Padding(4);
            frmCreateUserModel1.Name = "frmCreateUserModel1";
            frmCreateUserModel1.Size = new Size(546, 383);
            frmCreateUserModel1.TabIndex = 0;
            // 
            // frmCreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(frmCreateUserModel1);
            MaximizeBox = false;
            Name = "frmCreateCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create New User";
            Load += frmCreateCustomer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Components.Models.Users.frmCreateUserModel frmCreateUserModel1;
    }
}