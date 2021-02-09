using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace DevExpress.MailClient.Win
{
	public class ZoomManager
	{
		ZoomTrackBarControl zoomControl;
		int zoomFactor = 0;
		List<int> zoomValues = new List<int>() { 100, 115, 130, 150, 200, 250, 300, 350, 400, 500 };
		RibbonControl ribbon;
		BarEditItem beiZoom;
		ModulesNavigator modulesNavigator;
		public ZoomManager(RibbonControl ribbon, ModulesNavigator modulesNavigator, BarEditItem beItem)
		{
			this.ribbon = ribbon;
			this.modulesNavigator = modulesNavigator;
			this.beiZoom = beItem;
			this.beiZoom.HiddenEditor += new DevExpress.XtraBars.ItemClickEventHandler(this.beiZoom_HiddenEditor);
			this.beiZoom.ShownEditor += new DevExpress.XtraBars.ItemClickEventHandler(this.beiZoom_ShownEditor);
		}
		ZoomTrackBarControl ZoomControl { get { return zoomControl; } }
		public int ZoomFactor
		{
			get { return zoomFactor; }
			set
			{
				zoomFactor = value;
				beiZoom.Caption = string.Format(" {0}%", ZoomFactor);
				int index = zoomValues.IndexOf(ZoomFactor);
				if (index == -1)
					beiZoom.EditValue = ZoomFactor / 10;
				else beiZoom.EditValue = 10 + index;
				modulesNavigator.CurrentModule.ZoomFactor = (float)ZoomFactor / 100;
			}
		}
		public void SetZoomCaption(string caption)
		{
			beiZoom.Caption = caption;
		}
		private void beiZoom_ShownEditor(object sender, ItemClickEventArgs e)
		{
			this.zoomControl = ribbon.Manager.ActiveEditor as ZoomTrackBarControl;
			if (ZoomControl != null)
			{
				ZoomControl.ValueChanged += new EventHandler(OnZoomTackValueChanged);
				OnZoomTackValueChanged(ZoomControl, EventArgs.Empty);
			}
		}
		private void beiZoom_HiddenEditor(object sender, ItemClickEventArgs e)
		{
			ZoomControl.ValueChanged -= new EventHandler(OnZoomTackValueChanged);
			this.zoomControl = null;
		}
		private void OnZoomTackValueChanged(object sender, EventArgs e)
		{
			int val = val = ZoomControl.Value * 10;
			if (ZoomControl.Value > 10) val = zoomValues[ZoomControl.Value - 10];
			ZoomFactor = val;
		}
	}
}
