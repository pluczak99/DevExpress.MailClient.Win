namespace DevExpress.MailClient.Win.Controls {
    partial class HelpControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpControl));
			DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1Caption = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2Caption = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3Caption = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
			this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
			this.backstageViewLabel1 = new DevExpress.MailClient.Win.Controls.BackstageViewLabel();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
			this.galleryControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.galleryControl1);
			this.splitContainer1.Panel1.Controls.Add(this.backstageViewLabel1);
			resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.labelControl4);
			// 
			// galleryControl1
			// 
			this.galleryControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.galleryControl1.Controls.Add(this.galleryControlClient1);
			this.galleryControl1.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.galleryControl1, "galleryControl1");
			// 
			// 
			// 
			this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
			this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
			this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
			this.galleryControl1.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = true;
			this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = true;
			this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = true;
			this.galleryControl1.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.galleryControl1.Gallery.AutoFitColumns = false;
			this.galleryControl1.Gallery.BackColor = System.Drawing.Color.Transparent;
			this.galleryControl1.Gallery.ColumnCount = 1;
			this.galleryControl1.Gallery.DistanceItemImageToText = 20;
			this.galleryControl1.Gallery.DrawImageBackground = false;
			this.galleryControl1.Gallery.FixedImageSize = false;
			resources.ApplyResources(galleryItemGroup1, "galleryItemGroup1");
			resources.ApplyResources(galleryItem1, "galleryItem1");


			galleryItem1.Caption= Properties.Resources.backstageViewLabel1_QuickHelp;
			galleryItem1.Description = Properties.Resources.backstageViewLabel1_QuickHelp_Description;
			galleryItem1.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.DevExpressOnlineHelp;
			galleryItem1.Tag = "LinkHelp";
			resources.ApplyResources(galleryItem2, "galleryItem2");
			galleryItem2.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.GettingStarted;
			galleryItem2.Tag = "LinkGetStarted";
			galleryItem2.Caption = Properties.Resources.backstageViewLabel1_GetStarted;
			galleryItem2.Description = Properties.Resources.backstageViewLabel1_GetStarted_Description;
			resources.ApplyResources(galleryItem3, "galleryItem3");
			galleryItem3.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.ContactUs;
			galleryItem3.Tag = "LinkGetSupport";
			galleryItem3.Caption = Properties.Resources.backstageViewLabel1_GetSupport;
			galleryItem3.Description = Properties.Resources.backstageViewLabel1_GetSupport_Description;
			galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3});
			this.galleryControl1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
			this.galleryControl1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left;
			this.galleryControl1.Gallery.ShowGroupCaption = false;
			this.galleryControl1.Gallery.ShowItemText = true;
			this.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
			this.galleryControl1.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
			this.galleryControl1.Name = "galleryControl1";
			// 
			// galleryControlClient1
			// 
			this.galleryControlClient1.GalleryControl = this.galleryControl1;
			resources.ApplyResources(this.galleryControlClient1, "galleryControlClient1");
			// 
			// backstageViewLabel1
			// 
			this.backstageViewLabel1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("backstageViewLabel1.Appearance.Font")));
			this.backstageViewLabel1.Appearance.Options.UseFont = true;
			resources.ApplyResources(this.backstageViewLabel1, "backstageViewLabel1");
			this.backstageViewLabel1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
			this.backstageViewLabel1.LineVisible = true;
			this.backstageViewLabel1.Name = "backstageViewLabel1";
			this.backstageViewLabel1.ShowLineShadow = false;
			// 
			// labelControl4
			// 
			resources.ApplyResources(this.labelControl4, "labelControl4");
			this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
			this.labelControl4.LineVisible = true;
			this.labelControl4.Name = "labelControl4";
			// 
			// HelpControl
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "HelpControl";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
			this.galleryControl1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private BackstageViewLabel backstageViewLabel1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
