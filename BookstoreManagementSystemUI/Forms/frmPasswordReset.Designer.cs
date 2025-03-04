namespace BookstoreManagementSystemUI.Forms
{
    partial class frmPasswordReset
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
            frmPasswordReset1 = new Components.Auth.frmPasswordReset();
            SuspendLayout();
            // 
            // frmPasswordReset1
            // 
            frmPasswordReset1.Dock = DockStyle.Fill;
            frmPasswordReset1.Font = new Font("Fira Code", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmPasswordReset1.Location = new Point(3, 64);
            frmPasswordReset1.Margin = new Padding(4);
            frmPasswordReset1.MinimumSize = new Size(570, 190);
            frmPasswordReset1.Name = "frmPasswordReset1";
            frmPasswordReset1.Size = new Size(643, 194);
            frmPasswordReset1.TabIndex = 0;
            // 
            // frmPasswordReset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 261);
            Controls.Add(frmPasswordReset1);
            MaximizeBox = false;
            Name = "frmPasswordReset";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Reset";
            Load += frmPasswordReset_Load;
            ResumeLayout(false);
        }

        #endregion

        private Components.Auth.frmPasswordReset frmPasswordReset1;
    }
}