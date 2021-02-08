using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MailClient.Win
{
	public class DateFilterMenu : PopupMenu
	{
		GridView view;
		FilterCriteriaManager filterManager;
		public DateFilterMenu(BarManager manager, GridView view, FilterCriteriaManager filterManager)
			: base(manager)
		{
			this.view = view;
			this.filterManager = filterManager;
			CreateBarItem(Properties.Resources.IsToday, "IsOutlookIntervalToday([Date])");
			CreateBarItem(Properties.Resources.IsYesterday, "IsOutlookIntervalYesterday([Date])");
			CreateBarItem(Properties.Resources.IsEarlierThisWeek, "IsOutlookIntervalEarlierThisWeek([Date])");
			CreateBarItem(Properties.Resources.IsLastWeek, "IsOutlookIntervalLastWeek([Date])");
			CreateBarItem(Properties.Resources.IsEarlierThisMonth, "IsOutlookIntervalEarlierThisMonth([Date])");
			CreateBarItem(Properties.Resources.IsEarlierThisYear, "IsOutlookIntervalEarlierThisYear([Date])");
		}
		void CreateBarItem(string caption, string filterString)
		{
			BarButtonItem item = new BarButtonItem(this.Manager, caption);
			item.Tag = filterString;
			item.CloseSubMenuOnClick = false;
			ItemLinks.Add(item);
			filterManager.AddBarItem(item, view.Columns["Date"], filterString);
		}
	}
}
