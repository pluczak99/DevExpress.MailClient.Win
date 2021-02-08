using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.MailClient.Win.Properties;

namespace DevExpress.MailClient.Win.Controls
{
	public partial class HelpControl : RibbonApplicationUserControl
	{
		Form aboutPanel;
		bool isLoaded;
		private System.Resources.ResourceManager ResourceManager;
		public HelpControl()
		{
			this.isLoaded = false;
			InitializeComponent();
			this.ResourceManager = new System.Resources.ResourceManager("DevExpress.MailClient.Win.Controls.Properties.Resources", typeof(Resources).Assembly);
			this.Load += new EventHandler(HelpControl_Load);
			if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
			{
				labelControl4.Dock = DockStyle.Right;
				galleryControl1.Gallery.ItemImageLocation = Locations.Right;
				galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment =
				galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment =
				galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Disabled.TextOptions.HAlignment = galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Disabled.TextOptions.HAlignment = HorzAlignment.Far;
			}
		}

		void HelpControl_Load(object sender, EventArgs e)
		{
			if (isLoaded) return;
			aboutPanel = new AboutForm12(new ProductInfo(ProductKind.DXperienceWin, new ProductStringInfo("WinForms Controls", "Build Your Own Office")));
			aboutPanel.TopLevel = false;
			aboutPanel.Parent = splitContainer1.Panel2;
			ResizeAbout();
			aboutPanel.Show();
			splitContainer1.Panel2.Resize += new EventHandler(Panel2_Resize);
			ResizeAbout();
			isLoaded = true;

			this.backstageViewLabel1.Text = Properties.Resources.backstageViewLabel1;
		}

		void Panel2_Resize(object sender, EventArgs e)
		{
			ResizeAbout();
		}
		void ResizeAbout()
		{
			Panel pnl = aboutPanel.Parent as Panel;
			aboutPanel.Location = new Point((pnl.Width - aboutPanel.Width) / 2, (pnl.Height - aboutPanel.Height) / 2);
		}
		private void galleryControlGallery1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
		{
			string link = string.Format("{0}", e.Item.Tag);
			switch (link)
			{
				case "LinkHelp": link = "https://www.devexpress.com/products/net/controls/winforms/"; break;
				case "LinkGetSupport": link = "https://www.devexpress.com/products/net/controls/winforms/"; break;
				case "LinkGetStarted": link = "https://www.devexpress.com/products/net/controls/winforms/"; break;

			}
			if (!string.IsNullOrEmpty(link)) ObjectHelper.StartProcess(link);
		}
	}
}
