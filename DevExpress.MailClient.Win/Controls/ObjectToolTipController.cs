using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.MailClient.Win
{
	public class ObjectToolTipController : IDisposable
	{
		ToolTipController controller;
		Control parent;
		object editObject;
		public object EditObject { get { return editObject; } }
		public ObjectToolTipController(Control parent)
		{
			this.parent = parent;
			this.parent.Disposed += new EventHandler(delegate { Dispose(); });
			this.controller = new ToolTipController();
			this.controller.ToolTipType = ToolTipType.SuperTip;
			this.controller.AllowHtmlText = true;
			this.controller.ReshowDelay = controller.InitialDelay;
			this.controller.AutoPopDelay = 10000;
			parent.MouseDown += new MouseEventHandler(delegate { HideHint(false); });
			parent.MouseLeave += new EventHandler(delegate { HideHint(true); });
		}
		public void ShowHint(object editObject, Point location)
		{
			if (object.Equals(editObject, this.editObject)) return;
			this.editObject = editObject;
			ToolTipControlInfo info = new ToolTipControlInfo();
			ToolTipItem item = new ToolTipItem();
			InitToolTipItem(item);
			item.ImageToTextDistance = 10;
			info.Object = DateTime.Now.Ticks;
			info.SuperTip = new SuperToolTip();
			info.SuperTip.Items.Add(item);
			info.SuperTip.Items.AddSeparator();
			info.SuperTip.Items.Add((editObject as Appointment).Description);
			info.ToolTipPosition = this.parent.PointToScreen(location);
			controller.ShowHint(info);
		}
		protected virtual void InitToolTipItem(ToolTipItem item)
		{
		}
		public void HideHint(bool clearCurrentObject)
		{
			if (clearCurrentObject) this.editObject = null;
			this.controller.HideHint();
		}
		#region IDisposable Members
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.controller.Dispose();
			}
		}
		~ObjectToolTipController()
		{
			Dispose(false);
		}
		#endregion
	}
}
