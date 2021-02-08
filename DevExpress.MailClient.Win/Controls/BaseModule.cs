using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid;
using System.Collections;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraRichEdit;
using DevExpress.XtraPrinting;

namespace DevExpress.MailClient.Win
{
	public class BaseModule : BaseControl
	{
		protected string partName = string.Empty;
		internal frmMain OwnerForm { get { return this.FindForm() as frmMain; } }
		public BaseModule() { }
		internal virtual void ShowModule(bool firstShow)
		{
			frmMain owner = OwnerForm;
			if (owner == null) return;
			owner.SaveAsMenuItem.Enabled = SaveAsEnable;
			owner.SaveAttachmentMenuItem.Enabled = SaveAttachmentEnable;
			owner.SaveCalendar.Visible = SaveCalendarVisible;
			owner.EnableLayoutButtons(true);
			ShowReminder();
			ShowInfo();
			owner.ZoomManager.ZoomFactor = (int)(ZoomFactor * 100);
			SetZoomCaption();
			owner.EnableZoomControl(AllowZoomControl);
		}
		internal virtual void FocusObject(object obj) { }
		protected virtual void ShowReminder()
		{
			if (OwnerForm != null)
				OwnerForm.ShowReminder(null);
		}
		internal void ShowInfo()
		{
			if (OwnerForm == null) return;
			if (Grid == null)
			{
				OwnerForm.ShowInfo(null);
				return;
			}
			ICollection list = Grid.DataSource as ICollection;
			if (list == null)
				OwnerForm.ShowInfo(null);
			else OwnerForm.ShowInfo(list.Count);
		}
		internal virtual void HideModule() { }
		internal virtual void InitModule(IDXMenuManager manager, object data)
		{
			SetMenuManager(this.Controls, manager);
			if (Grid != null && Grid.MainView is ColumnView)
			{
				((ColumnView)Grid.MainView).ColumnFilterChanged += new EventHandler(BaseModule_ColumnFilterChanged);
			}
		}
		internal void ShowInfo(ColumnView view)
		{
			if (OwnerForm == null) return;
			ShowReminder();
			OwnerForm.ShowInfo(view.DataRowCount);
		}
		void BaseModule_ColumnFilterChanged(object sender, EventArgs e)
		{
			ShowInfo(sender as ColumnView);
		}
		void SetMenuManager(ControlCollection controlCollection, IDXMenuManager manager)
		{
			foreach (Control ctrl in controlCollection)
			{
				GridControl grid = ctrl as GridControl;
				if (grid != null)
				{
					grid.MenuManager = manager;
					break;
				}
				BaseEdit edit = ctrl as BaseEdit;
				if (edit != null)
				{
					edit.MenuManager = manager;
					break;
				}
				SetMenuManager(ctrl.Controls, manager);
			}
		}
		protected virtual bool AllowZoomControl { get { return false; } }
		protected virtual void SetZoomCaption() { }
		public virtual float ZoomFactor
		{
			get { return 1; }
			set { }
		}
		public virtual IPrintable PrintableComponent { get { return Grid; } }
		public virtual IPrintable ExportComponent { get { return Grid; } }
		protected virtual GridControl Grid { get { return null; } }
		protected virtual bool SaveAsEnable { get { return false; } }
		protected virtual bool SaveAttachmentEnable { get { return false; } }
		protected virtual bool SaveCalendarVisible { get { return false; } }
		protected internal virtual void ButtonClick(string tag) { }
		protected internal virtual void MessagesDataChanged(DataSourceChangedEventArgs args) { }
		protected internal virtual void SendKeyDown(KeyEventArgs e) { }
		protected internal virtual RichEditControl CurrentRichEdit { get { return null; } }
		public virtual string ModuleName { get { return this.GetType().Name; } }
		public string PartName { get { return partName; } }
	}
}
