using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Controls;

namespace DevExpress.MailClient.Win
{
	public class FindControlManager : IDisposable
	{
		RibbonControl ribbon;
		FindControl fControl;
		public FindControlManager(RibbonControl ribbon, FindControl control)
		{
			this.ribbon = ribbon;
			this.fControl = control;
			AddFindControlEvents();
		}
		void AddFindControlEvents()
		{
			fControl.FindButton.GotFocus += new EventHandler(FindControl_GotFocus);
			fControl.FindEdit.GotFocus += new EventHandler(FindControl_GotFocus);
			fControl.ClearButton.GotFocus += new EventHandler(FindControl_GotFocus);
			fControl.FindButton.Leave += new EventHandler(FindControl_Leave);
			fControl.FindEdit.Leave += new EventHandler(FindControl_Leave);
			fControl.ClearButton.Leave += new EventHandler(FindControl_Leave);
			fControl.FindButton.ImageOptions.SvgImage = Properties.Resources.Search1;
			fControl.FindButton.ImageOptions.SvgImageSize = new Size(16, 16);
			fControl.ClearButton.ImageOptions.SvgImage = Properties.Resources.Delete;
			fControl.ClearButton.ImageOptions.SvgImageSize = new Size(16, 16);
			fControl.FindButton.TabStop = false;
			fControl.ClearButton.TabStop = false;
			fControl.CalcButtonsBestFit();
		}
		void FindControl_Leave(object sender, EventArgs e)
		{
			fControl.BeginInvoke(new MethodInvoker(UpdateSearchTools));
		}
		void FindControl_GotFocus(object sender, EventArgs e)
		{
			UpdateSearchTools();
		}
		void UpdateSearchTools()
		{
			if (fControl.FindButton.Focused ||
				fControl.FindEdit.ContainsFocus ||
				fControl.ClearButton.Focused)
			{
				ribbon.PageCategories[TagResources.SearchTools].Visible = true;
				ribbon.SelectedPage = ribbon.PageCategories[TagResources.SearchTools].Pages[0];
			}
			else
			{
				ribbon.PageCategories[TagResources.SearchTools].Visible = false;
				ribbon.SelectedPage = ribbon.DefaultPageCategory.Pages[0];
			}
		}

		#region IDisposable Members
		public void Dispose()
		{
			fControl.FindButton.GotFocus -= new EventHandler(FindControl_GotFocus);
			fControl.FindEdit.GotFocus -= new EventHandler(FindControl_GotFocus);
			fControl.ClearButton.GotFocus -= new EventHandler(FindControl_GotFocus);
			fControl.FindButton.Leave -= new EventHandler(FindControl_Leave);
			fControl.FindEdit.Leave -= new EventHandler(FindControl_Leave);
			fControl.ClearButton.Leave -= new EventHandler(FindControl_Leave);
		}
		#endregion
	}
}
