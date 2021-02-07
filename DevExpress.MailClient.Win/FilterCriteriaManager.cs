using System;
using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MailClient.Win
{
	public class FilterCriteriaManager
	{
		GridView view;
		List<FilterCriteriaItem> itemList;
		BarButtonItem clearFilterItem;
		public FilterCriteriaManager(GridView view)
		{
			this.view = view;
			itemList = new List<FilterCriteriaItem>();
			view.ColumnFilterChanged += new EventHandler(view_ColumnFilterChanged);
		}
		public GridView View { get { return view; } }
		void view_ColumnFilterChanged(object sender, EventArgs e)
		{
			UpdateFilterInfo();
		}
		void UpdateFilterInfo()
		{
			foreach (FilterCriteriaItem item in itemList)
				item.UpdateDown();
			if (clearFilterItem != null)
				clearFilterItem.Enabled = !view.ActiveFilter.IsEmpty;
		}
		public void AddBarItem(BarButtonItem item, GridColumn column, string filterCriteria)
		{
			itemList.Add(new FilterCriteriaItem(this, item, column, filterCriteria));
		}
		public void AddClearFilterButton(BarButtonItem item)
		{
			clearFilterItem = item;
			UpdateFilterInfo();
		}
		internal string GetFilterCriteriaByColumn(GridColumn column)
		{
			string ret = string.Empty;
			foreach (FilterCriteriaItem item in itemList)
				if (item.Checked && item.IsColumnEquals(column))
					ret = AddCriteria(ret, item.FilterCriteria);
			return ret;
		}

		string AddCriteria(string ret, string filterCriteria)
		{
			if (!string.IsNullOrEmpty(ret))
				ret = string.Format("{0} Or {1}", ret, filterCriteria);
			else ret = filterCriteria;
			return ret;
		}
	}
}
