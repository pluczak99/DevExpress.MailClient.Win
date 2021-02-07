using System;
using DevExpress.XtraEditors;
using DevExpress.Utils.Design;

namespace DevExpress.MailClient.Win
{
	public class BaseControl : XtraUserControl
	{
		public BaseControl()
		{
			if (!DesignTimeTools.IsDesignMode)
				LookAndFeel.ActiveLookAndFeel.StyleChanged += new EventHandler(ActiveLookAndFeel_StyleChanged);
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (!DesignTimeTools.IsDesignMode)
				LookAndFeelStyleChanged();
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && !DesignTimeTools.IsDesignMode)
				LookAndFeel.ActiveLookAndFeel.StyleChanged -= new EventHandler(ActiveLookAndFeel_StyleChanged);
			base.Dispose(disposing);
		}
		void ActiveLookAndFeel_StyleChanged(object sender, EventArgs e)
		{
			LookAndFeelStyleChanged();
		}
		protected virtual void LookAndFeelStyleChanged() { }
	}
}
