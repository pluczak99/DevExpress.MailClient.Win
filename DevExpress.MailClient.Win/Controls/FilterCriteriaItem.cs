using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MailClient.Win
{
	public class FilterCriteriaItem
	{
		BarButtonItem item;
		string filterCriteria;
		GridColumn column;
		FilterCriteriaManager owner;
		public FilterCriteriaItem(FilterCriteriaManager owner, BarButtonItem item, GridColumn column, string filterCriteria)
		{
			this.item = item;
			this.column = column;
			this.filterCriteria = filterCriteria;
			this.owner = owner;
			item.ButtonStyle = BarButtonStyle.Check;
			item.ItemClick += new ItemClickEventHandler(item_ItemClick);
		}
		GridView View { get { return owner.View; } }
		public bool Checked { get { return item.Down; } }
		internal string FilterCriteria { get { return filterCriteria; } }
		internal bool IsColumnEquals(GridColumn column)
		{
			return this.column.Equals(column);
		}
		void item_ItemClick(object sender, ItemClickEventArgs e)
		{
			UpdateFilterCriteria(column);
		}
		void UpdateFilterCriteria(GridColumn column)
		{
			string filterCriteria = owner.GetFilterCriteriaByColumn(column);
			if (string.IsNullOrEmpty(filterCriteria)) View.ActiveFilter.Remove(column);
			else
				View.ActiveFilter.Add(column, new ColumnFilterInfo(filterCriteria));
		}
		internal void UpdateDown()
		{
			item.Down = View.ActiveFilterString.IndexOf(filterCriteria) >= 0;
		}
	}
}
