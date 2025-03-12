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
            frmDashboardCardTotalOrders = new frmDashboardCard();
            frmDashboardCardTotalBooks = new frmDashboardCard();
            frmDashboardCardTotalSuppliers = new frmDashboardCard();
            frmDashboardCardTotalIncome = new frmDashboardCard();
            SuspendLayout();
            // 
            // frmDashboardCardTotalOrders
            // 
            frmDashboardCardTotalOrders.Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmDashboardCardTotalOrders.Location = new Point(21, 21);
            frmDashboardCardTotalOrders.Margin = new Padding(4);
            frmDashboardCardTotalOrders.Name = "frmDashboardCardTotalOrders";
            frmDashboardCardTotalOrders.Size = new Size(400, 400);
            frmDashboardCardTotalOrders.TabIndex = 0;
            // 
            // frmDashboardCardTotalBooks
            // 
            frmDashboardCardTotalBooks.Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmDashboardCardTotalBooks.Location = new Point(429, 21);
            frmDashboardCardTotalBooks.Margin = new Padding(4);
            frmDashboardCardTotalBooks.Name = "frmDashboardCardTotalBooks";
            frmDashboardCardTotalBooks.Size = new Size(400, 400);
            frmDashboardCardTotalBooks.TabIndex = 1;
            // 
            // frmDashboardCardTotalSuppliers
            // 
            frmDashboardCardTotalSuppliers.Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmDashboardCardTotalSuppliers.Location = new Point(837, 21);
            frmDashboardCardTotalSuppliers.Margin = new Padding(4);
            frmDashboardCardTotalSuppliers.Name = "frmDashboardCardTotalSuppliers";
            frmDashboardCardTotalSuppliers.Size = new Size(400, 400);
            frmDashboardCardTotalSuppliers.TabIndex = 2;
            // 
            // frmDashboardCardTotalIncome
            // 
            frmDashboardCardTotalIncome.Font = new Font("Fira Code", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frmDashboardCardTotalIncome.Location = new Point(1245, 21);
            frmDashboardCardTotalIncome.Margin = new Padding(4);
            frmDashboardCardTotalIncome.Name = "frmDashboardCardTotalIncome";
            frmDashboardCardTotalIncome.Size = new Size(400, 400);
            frmDashboardCardTotalIncome.TabIndex = 3;
            // 
            // frmDashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(frmDashboardCardTotalIncome);
            Controls.Add(frmDashboardCardTotalSuppliers);
            Controls.Add(frmDashboardCardTotalBooks);
            Controls.Add(frmDashboardCardTotalOrders);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDashboardPage";
            Size = new Size(2144, 580);
            Load += frmDashboardPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private frmDashboardCard frmDashboardCardTotalOrders;
        private frmDashboardCard frmDashboardCardTotalBooks;
        private frmDashboardCard frmDashboardCardTotalSuppliers;
        private frmDashboardCard frmDashboardCardTotalIncome;
    }
}
