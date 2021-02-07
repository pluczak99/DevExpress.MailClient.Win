using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Svg;

namespace DevExpress.MailClient.Win
{
	public class PriorityMenu : PopupMenu
	{
		GridView view;
		BarButtonItem lowPriority, mediumPriority, highPriority;
		public PriorityMenu(BarManager manager, GridView view, SvgImage low, SvgImage high)
			: base(manager)
		{
			this.view = view;
			lowPriority = new BarButtonItem(manager, Properties.Resources.LowPriority);
			lowPriority.ImageOptions.SvgImage = low;
			lowPriority.ImageOptions.SvgImageSize = new Size(16, 16);
			mediumPriority = new BarButtonItem(manager, Properties.Resources.MediumPriority);
			highPriority = new BarButtonItem(manager, Properties.Resources.HighPriority);
			highPriority.ImageOptions.SvgImage = high;
			highPriority.ImageOptions.SvgImageSize = new Size(16, 16);
			ItemLinks.AddRange(new BarItem[] { lowPriority, mediumPriority, highPriority });
			lowPriority.ItemClick += new ItemClickEventHandler(lowPriority_ItemClick);
			mediumPriority.ItemClick += new ItemClickEventHandler(mediumPriority_ItemClick);
			highPriority.ItemClick += new ItemClickEventHandler(highPriority_ItemClick);
			lowPriority.ButtonStyle = BarButtonStyle.Check;
			mediumPriority.ButtonStyle = BarButtonStyle.Check;
			highPriority.ButtonStyle = BarButtonStyle.Check;
		}
		protected override void OnBeforePopup(CancelEventArgs e)
		{
			base.OnBeforePopup(e);
			int priority = -1;
			foreach (int row in view.GetSelectedRows())
			{
				if (row >= 0)
				{
					Message message = view.GetRow(row) as Message;
					if (priority == -1)
						priority = message.Priority;
					if (priority != message.Priority)
					{
						priority = -1;
						break;
					}
				}
			}
			lowPriority.Down = priority == 0;
			mediumPriority.Down = priority == 1;
			highPriority.Down = priority == 2;
		}
		void SetPriority(int value)
		{
			foreach (int row in view.GetSelectedRows())
				if (row >= 0)
					((Message)view.GetRow(row)).Priority = value;
			view.LayoutChanged();
			view.MakeRowVisible(view.FocusedRowHandle);
		}
		void highPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(2); }
		void mediumPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(1); }
		void lowPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(0); }
	}
}
