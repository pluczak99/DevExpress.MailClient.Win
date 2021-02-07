using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.MailClient.Win
{
	public static class RibbonUtils
	{
		public static void SetBarButtonItemTexts ( this BarItem item, string caption, string description, BarShortcut keyShortcut = null)
		{
			item.Caption = caption;
			item.SuperTip = new Utils.SuperToolTip();
			if (keyShortcut != null)
			{
				item.ShowItemShortcut = Utils.DefaultBoolean.True;
				item.ItemShortcut = keyShortcut;
				item.SuperTip.Items.AddTitle(caption + " (" + item.ItemShortcut.ToString() + ")");
			}
			else
			{
				item.SuperTip.Items.AddTitle(caption);
			}
			item.SuperTip.Items.Add(description);

		}
	}
}
