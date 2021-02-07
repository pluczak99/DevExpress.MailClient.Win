using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System.Reflection;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.MailClient.Win
{
	public class ModulesNavigator
	{
		RibbonControl ribbon;
		PanelControl panel;
		public ModulesNavigator(RibbonControl ribbon, PanelControl panel)
		{
			this.ribbon = ribbon;
			this.panel = panel;
		}
		public void ChangeGroup(NavBarGroup group, object moduleData)
		{
			bool allowSetVisiblePage = true;
			NavBarGroupTagObject groupObject = group.Tag as NavBarGroupTagObject;
			if (groupObject == null) return;
			List<RibbonPage> deferredPagesToShow = new List<RibbonPage>();
			foreach (RibbonPage page in ribbon.Pages)
			{
				if (!string.IsNullOrEmpty(string.Format("{0}", page.Tag)))
				{
					bool isPageVisible = groupObject.Name.Equals(page.Tag);
					if (isPageVisible != page.Visible && isPageVisible)
						deferredPagesToShow.Add(page);
					else
						page.Visible = isPageVisible;
				}
				if (page.Visible && allowSetVisiblePage)
				{
					//page.Text = "Home";
					ribbon.SelectedPage = page;
					allowSetVisiblePage = false;
				}
			}
			bool firstShow = groupObject.Module == null;
			if (firstShow)
			{
				if (SplashScreenManager.Default == null)
					SplashScreenManager.ShowForm(ribbon.FindForm(), typeof(DevExpress.MailClient.Win.Forms.wfMain), false, true);
				ConstructorInfo constructorInfoObj = groupObject.ModuleType.GetConstructor(Type.EmptyTypes);
				if (constructorInfoObj != null)
				{
					groupObject.Module = constructorInfoObj.Invoke(null) as BaseModule;
					groupObject.Module.InitModule(ribbon, moduleData);
				}
				if (SplashScreenManager.Default != null)
				{
					Form frm = moduleData as Form;
					if (frm != null)
					{
						if (SplashScreenManager.FormInPendingState)
							SplashScreenManager.CloseForm();
						else
							SplashScreenManager.CloseForm(false, 500, frm);
					}
					else
						SplashScreenManager.CloseForm();
				}
			}

			foreach (RibbonPage page in deferredPagesToShow)
			{
				page.Visible = true;
			}
			foreach (RibbonPage page in ribbon.Pages)
			{
				if (page.Visible)
				{
					ribbon.SelectedPage = page;
					break;
				}
			}

			if (groupObject.Module != null)
			{
				if (panel.Controls.Count > 0)
				{
					BaseModule currentModule = panel.Controls[0] as BaseModule;
					if (currentModule != null)
						currentModule.HideModule();
				}
				panel.Controls.Clear();
				panel.Controls.Add(groupObject.Module);
				groupObject.Module.Dock = DockStyle.Fill;
				groupObject.Module.ShowModule(firstShow);
			}
		}
		public BaseModule CurrentModule
		{
			get
			{
				if (panel.Controls.Count == 0) return null;
				return panel.Controls[0] as BaseModule;
			}
		}
	}
}
