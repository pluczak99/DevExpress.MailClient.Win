using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.MailClient.Win
{
	public class GridHelper {

        public static void SetFindControlImages(GridControl grid) {
            FindControl fControl = null;
            foreach(Control ctrl in grid.Controls) {
                fControl = ctrl as FindControl;
                if(fControl != null) break;
            }
            if(fControl != null) {
                fControl.FindButton.ImageOptions.SvgImage = Properties.Resources.Search1;
                fControl.FindButton.ImageOptions.SvgImageSize = new Size(16, 16);
                fControl.ClearButton.ImageOptions.SvgImage = Properties.Resources.Delete;
                fControl.ClearButton.ImageOptions.SvgImageSize = new Size(16, 16);
                fControl.CalcButtonsBestFit();
            }
        }
        public static void GridViewFocusObject(ColumnView cView, object obj) {
            if(obj == null) return;
            int oldFocusedRowHandle = cView.FocusedRowHandle;
            for(int i = 0; i < cView.DataRowCount; ++i) {
                object rowObj = cView.GetRow(i) as object;
                if(rowObj == null) continue;
                if(ReferenceEquals(obj, rowObj)) {
                    if(i == oldFocusedRowHandle)
                        cView.FocusedRowHandle = GridControl.InvalidRowHandle;
                    cView.FocusedRowHandle = i;
                    break;
                }
            }
        }
    }
}
