using MaterialSkin.Controls;

namespace BookstoreManagementSystemUI.Components.Core
{
    public partial class frmFullTableView : UserControl
    {
        #region Delegate

        public delegate void OnEditClickedDel(ListViewItem selected);
        public OnEditClickedDel? OnEditClicked { get; set; }

        public delegate void OnDeleteClickedDel(ListViewItem selected);
        public OnDeleteClickedDel? OnDeleteClicked { get; set; }

        public delegate void OnViewClickedDel(ListViewItem selected);
        public OnViewClickedDel? OnViewClicked { get; set; }

        public delegate void OnExportClickedDel();
        public OnExportClickedDel? OnExportClicked { get; set; }

        public delegate void OnImportClickedDel();
        public OnImportClickedDel? OnImportClicked { get; set; }

        public delegate void OnAddClickedDel();
        public OnAddClickedDel? OnAddClicked { get; set; }

        #endregion

        public frmFullTableView()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handles the Click event of the btnEdit control.
        /// Iterates through the selected items in the mlvTableView ListView,
        /// invokes the OnExportClicked event for each selected item, and disables the btnEdit button.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (var item in mlvTableView.SelectedItems)
            {
                OnEditClicked?.Invoke((ListViewItem)item);
                btnEdit.Enabled = false;
                return;
            }
        }


        /// <summary>
        /// Handles the Click event of the btnDelete control.
        /// Iterates through the selected items in the mlvTableView ListView,
        /// invokes the btnDelete_Click event for each selected item, and disables the btnDelete button.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in mlvTableView.SelectedItems)
            {
                OnDeleteClicked?.Invoke((ListViewItem)item);
                btnDelete.Enabled = false;
                return;
            }
        }


        /// <summary>
        /// Handles the Click event of the btnView control.
        /// Iterates through the selected items in the mlvTableView ListView,
        /// invokes the btnView_Click event for each selected item, and disables the btnView button.
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            foreach (var item in mlvTableView.SelectedItems)
            {
                OnViewClicked?.Invoke((ListViewItem)item);
                btnView.Enabled = false;
                return;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mlvTableView control.
        /// Enables or disables the Edit and Delete buttons based on the selection state of the items in the ListView.
        /// </summary>
        private void mlvTableView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in mlvTableView.SelectedItems)
            {
                if (item is ListViewItem listView && listView.Selected)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnAddClicked?.Invoke();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            OnExportClicked?.Invoke();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OnImportClicked?.Invoke();
        }

    }
}
