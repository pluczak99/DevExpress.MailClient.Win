using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.MailClient.Win
{
	public class FilterColumnsManager
	{
		List<BarButtonItem> items;
		GridView view;
		bool lockUpdate = false;
		public FilterColumnsManager(List<BarButtonItem> items)
		{
			this.items = items;
			foreach (BarButtonItem item in items)
				item.DownChanged += new ItemClickEventHandler(item_DownChanged);
		}
		BarButtonItem GetItemByName(string name)
		{
			foreach (BarButtonItem item in items)
				if (item.Tag.Equals(name)) return item;
			return null;
		}
		public void SetDefault()
		{
			lockUpdate = true;
			foreach (BarButtonItem item in items)
				if (item.CanDown)
					item.Down = false;
			GetItemByName(TagResources.SubjectColumn).Down = true;
			GetItemByName(TagResources.PersonColumn).Down = true;
			lockUpdate = false;
			Update();
		}
		void Update()
		{
			string filterColumns = string.Empty;
			if (GetItemByName(TagResources.SubjectColumn).Down) filterColumns += "Subject;";
			if (GetItemByName(TagResources.PersonColumn).Down) filterColumns += "From;";
			if (GetItemByName(TagResources.DateColumn).Down) filterColumns += "Date;";
			if (GetItemByName(TagResources.PriorityColumn).Down) filterColumns += "Priority;";
			if (GetItemByName(TagResources.AttachmentColumn).Down) filterColumns += "Attachment;";
			view.OptionsFind.FindFilterColumns = filterColumns;
		}
		void item_DownChanged(object sender, ItemClickEventArgs e)
		{
			if (lockUpdate) return;
			Update();
		}
		public void InitGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView)
		{
			if (view != null) return;
			view = gridView;
			SetDefault();
		}
		internal void UpdateColumnsCaption(string date, string person)
		{
			GetItemByName(TagResources.PersonColumn).Caption = person;
			GetItemByName(TagResources.DateColumn).Caption = date;
			GetItemByName(TagResources.DateFilterMenu).Caption = date;
		}
	}
}
