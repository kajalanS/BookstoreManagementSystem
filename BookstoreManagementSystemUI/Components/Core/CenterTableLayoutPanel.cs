using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookstoreManagementSystemUI.Components
{
    public partial class CenterTableLayoutPanel : TableLayoutPanel
    {
        public CenterTableLayoutPanel()
        {
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            CenterControls();
        }

        private void CenterControls()
        {
            int totalWidth = this.Width;
            int totalHeight = this.Height;

            for (int row = 0; row < this.RowCount; row++)
            {
                for (int col = 0; col < this.ColumnCount; col++)
                {
                    Control control = GetControlFromPosition(col, row);
                    if (control != null)
                    {
                        Rectangle cellBounds = CalculateCellBounds(col, row, totalWidth, totalHeight);

                        // Center the control inside the calculated cell
                        control.Location = new Point(
                            cellBounds.X + (cellBounds.Width - control.Width) / 2,
                            cellBounds.Y + (cellBounds.Height - control.Height) / 2
                        );
                    }
                }
            }
        }

        private Rectangle CalculateCellBounds(int column, int row, int totalWidth, int totalHeight)
        {
            int x = 0, y = 0;
            int columnWidth = totalWidth / ColumnCount;
            int rowHeight = totalHeight / RowCount;

            x = column * columnWidth;
            y = row * rowHeight;

            return new Rectangle(x, y, columnWidth, rowHeight);
        }
    }
}
