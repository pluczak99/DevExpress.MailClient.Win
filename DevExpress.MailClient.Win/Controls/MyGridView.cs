using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MailClient.Win
{
	public class MyGridView : GridView {
        protected override bool IsAllowPixelScrollingPreview {
            get {
                return true;
            }
        }
    }
}
