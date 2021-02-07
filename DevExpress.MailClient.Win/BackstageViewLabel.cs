using DevExpress.XtraEditors;

namespace DevExpress.MailClient.Win
{
	public class BackstageViewLabel : LabelControl
	{
		public BackstageViewLabel()
		{
			Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
			LineVisible = true;
			ShowLineShadow = false;
		}
	}
}
