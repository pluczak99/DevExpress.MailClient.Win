using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.iCalendar;
using DevExpress.MailClient.Win.Controls;
using System.IO;
using DevExpress.XtraEditors;
using System.Xml.Serialization;

using System.Configuration;
using DevExpress.XtraScheduler.Internal.Implementations;

using DevExpress.MailClient.Win;
using static DevExpress.MailClient.Win.DEVEXPRESSDataSet1;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Drawing;

namespace DevExpress.MailClient.Win
{
	public partial class Calendar : BaseModule
	{
		RibbonControl ribbon;
		ucCalendar calendarControls;
		RibbonPageCategory appointmentCategory = null;
		RibbonPage lastSelectedPage = null;
		public DEVEXPRESSDataSet1 dataSet1 { get; set; }
		public DEVEXPRESSDataSet1TableAdapters.AppointmentsTableAdapter adapterAppointments;
		public DEVEXPRESSDataSet1TableAdapters.ResourcesTableAdapter adapterResources;


		public override string ModuleName { get { return Properties.Resources.CalendarName; } }
		public Calendar()
		{
			InitializeComponent();
			schedulerControl1.Start = DateTime.Today;
			this.dataSet1 = new DEVEXPRESSDataSet1();

			toolTipController1.ShowBeak = true;
			toolTipController1.ToolTipType = ToolTipType.SuperTip;
			schedulerControl1.OptionsView.ToolTipVisibility = ToolTipVisibility.Always;
		}

		#region #ToolTipControllerBeforeShow
		readonly Font titleFont = new Font("Times New Roman", 14),
					  footerFont = new Font("Comic Sans MS", 8);
		private void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e)
		{
			ToolTipController controller = sender as ToolTipController;
			AppointmentViewInfo aptViewInfo = controller.ActiveObject as AppointmentViewInfo;
			if (aptViewInfo == null) return;

			if (toolTipController1.ToolTipType == ToolTipType.Standard)
			{
				e.IconType = ToolTipIconType.Information;
				e.ToolTip = aptViewInfo.Description;
			}

			if (toolTipController1.ToolTipType == ToolTipType.SuperTip)
			{
				SuperToolTip SuperTip = new SuperToolTip();
				SuperToolTipSetupArgs args = new SuperToolTipSetupArgs();
				args.Title.Text = "Info";
				args.Title.Font = titleFont;
				args.Contents.Text = aptViewInfo.Description;
				//args.Contents.Image = resImage;
				args.ShowFooterSeparator = true;
				args.Footer.Font = footerFont;
				args.Footer.Text = "SuperTip";
				SuperTip.Setup(args);
				e.SuperTip = SuperTip;
			}
		}
		#endregion #ToolTipControllerBeforeShow


		public override DevExpress.XtraPrinting.IPrintable PrintableComponent
		{
			get
			{
				return schedulerControl1;
			}
		}

		protected override bool SaveCalendarVisible { get { return true; } }

		internal override void InitModule(DevExpress.Utils.Menu.IDXMenuManager manager, object data)
		{
			base.InitModule(manager, data);
			schedulerControl1.MenuManager = manager;
			this.ribbon = manager as RibbonControl;
			this.appointmentCategory = FindAppointmentPage(this.ribbon);

			if (calendarControls == null)
			{
				this.calendarControls = data as ucCalendar;
				this.calendarControls?.InitDateNavigator(this.schedulerControl1);
				this.calendarControls?.InitResourcesTree(this.schedulerStorage1);
				this.calendarControls?.InitBarController(this.schedulerControl1);
			}


			this.adapterAppointments = new DEVEXPRESSDataSet1TableAdapters.AppointmentsTableAdapter();
			this.adapterAppointments.Fill(dataSet1.Appointments);

			this.adapterResources = new DEVEXPRESSDataSet1TableAdapters.ResourcesTableAdapter();
			this.adapterResources.Fill(dataSet1.Resources);

		}
		private RibbonPageCategory FindAppointmentPage(RibbonControl ribbonControl)
		{
			foreach (RibbonPageCategory category in ribbonControl.PageCategories)
				if (category.Tag != null && category.Tag.ToString() == "CalendarTools")
					return category;
			return null;
		}
		protected internal override void ButtonClick(string tag)
		{
			switch (tag)
			{
				case TagResources.OpenCalendar:
					LoadCalendar();
					break;
				case TagResources.MenuSaveCalendar:
					SaveCalendar();
					break;
			}
		}
		internal override void ShowModule(bool firstShow)
		{

			base.ShowModule(firstShow);
			this.schedulerControl1.DataStorage.Appointments.DataSource = dataSet1.Appointments;
			this.schedulerControl1.DataStorage.Resources.DataSource = dataSet1.Resources;

			SubscribeSchedulerEvents();

			this.schedulerControl1.OptionsCustomization.AllowDisplayAppointmentFlyout = false;
			toolTipController1.BeforeShow += toolTipController1_BeforeShow;
		}
		internal override void HideModule()
		{
			UnsubscribeSchedulerEvents();
			HideAppointmentCategory();
			toolTipController1.BeforeShow -= toolTipController1_BeforeShow;
			base.HideModule();
		}

		#region Appointment modification
		private void SubscribeSchedulerEvents()
		{
			this.schedulerStorage1.FilterAppointment += new PersistentObjectCancelEventHandler(this.schedulerStorage1_FilterAppointment);
			this.schedulerStorage1.AppointmentsDeleted += new PersistentObjectsEventHandler(SchedulerStorage1_AppointmentsDeleted);
			this.schedulerStorage1.AppointmentsChanged += new PersistentObjectsEventHandler(SchedulerStorage1_AppointmentsChanged1);
			this.schedulerStorage1.AppointmentsInserted += new PersistentObjectsEventHandler(SchedulerStorage1_AppointmentsInserted);
		}

		void UnsubscribeSchedulerEvents()
		{
			this.schedulerStorage1.FilterAppointment -= new PersistentObjectCancelEventHandler(this.schedulerStorage1_FilterAppointment);
			this.schedulerStorage1.AppointmentsDeleted -= new PersistentObjectsEventHandler(SchedulerStorage1_AppointmentsDeleted);
			this.schedulerStorage1.AppointmentsChanged -= new PersistentObjectsEventHandler(SchedulerStorage1_AppointmentsChanged1);
			this.schedulerStorage1.AppointmentsInserted -= new PersistentObjectsEventHandler(SchedulerStorage1_AppointmentsInserted);
		}


		private void SchedulerStorage1_AppointmentsChanged1(object sender, PersistentObjectsEventArgs e)
		{
			this.adapterAppointments.Adapter.Update(this.dataSet1);
			this.dataSet1.AcceptChanges();

		}

		private void SchedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
		{
			this.adapterAppointments.Adapter.Update(this.dataSet1);
			this.dataSet1.AcceptChanges();
		}

		private void SchedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
		{
			this.adapterAppointments.Adapter.Update(this.dataSet1);
			this.dataSet1.AcceptChanges();
		}
		#endregion

		void SchedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
		{
			var form = new CustomAppointmentRibbonForm(this.schedulerControl1, e.Appointment, e.OpenRecurrenceForm);
			form.LookAndFeel.ParentLookAndFeel = LookAndFeel;
			form.SetMenuManager(this.schedulerControl1.MenuManager);

			e.DialogResult = form.ShowDialog(this);
			if (e.DialogResult == DialogResult.OK)
			{

			}
			e.Handled = true;
		}

		void UpdateAppointmentCategory()
		{
			if (this.schedulerControl1.SelectedAppointments.Count > 0)
				ShowAppointmentCategory();
			else
				HideAppointmentCategory();
		}
		private void schedulerStorage1_FilterAppointment(object sender, PersistentObjectCancelEventArgs e)
		{
			Appointment apt = (Appointment)e.Object;
			if (EmptyResourceId.Id.Equals(apt.ResourceId))
				return;
			List<int> selectedIds = this.calendarControls.GetSelectedResourceIds();
			int resourceId = Convert.ToInt32(apt.ResourceId);
			e.Cancel = !selectedIds.Contains(resourceId);
		}
		private void SaveCalendar()
		{
			SaveFileDialog fileDialog = new SaveFileDialog();
			fileDialog.Filter = "iCalendar files (*.ics)|*.ics";
			fileDialog.FilterIndex = 1;
			if (fileDialog.ShowDialog() != DialogResult.OK)
				return;
			try
			{
				using (Stream stream = fileDialog.OpenFile())
					ExportAppointments(stream);
			}
			catch
			{
				XtraMessageBox.Show(Properties.Resources.AppointmentError, Properties.Resources.Error);
			}
		}

		private void LoadCalendar()
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "iCalendar files (*.ics)|*.ics";
			dialog.FilterIndex = 1;
			if (dialog.ShowDialog() != DialogResult.OK)
				return;
			using (Stream stream = dialog.OpenFile())
			{
				ImportAppointments(stream);
			}

			//this.schedulerControl1.DataStorage.Appointments.Add(new AppointmentInstance() { Start = DateTime.Now, Subject = "Surprise!" });
		}

		void ExportAppointments(Stream stream)
		{
			if (stream == null)
				return;
			iCalendarExporter exporter = new iCalendarExporter(schedulerStorage1);
			exporter.ProductIdentifier = "-//Developer Express Inc.//XtraScheduler iCalendarExportDemo//EN";
			exporter.AppointmentExporting += new AppointmentExportingEventHandler(exporter_AppointmentExporting);
			exporter.Export(stream);
		}

		void ImportAppointments(Stream stream)
		{
			if (stream == null)
				return;
			iCalendarImporter importer = new iCalendarImporter(schedulerStorage1);
			importer.AppointmentImporting += new AppointmentImportingEventHandler(importer_AppointmentImporting);
			importer.Import(stream);
		}

		void exporter_AppointmentExporting(object sender, AppointmentExportingEventArgs e)
		{
		}

		void importer_AppointmentImporting(object sender, AppointmentImportingEventArgs e)
		{
		}
		void ShowAppointmentCategory()
		{
			if (this.appointmentCategory == null)
				return;
			if (this.lastSelectedPage == null)
				this.lastSelectedPage = this.ribbon.SelectedPage;
			this.appointmentCategory.Visible = true;
			this.ribbon.SelectedPage = GetFirstVisiblePage(this.appointmentCategory);
		}
		void HideAppointmentCategory()
		{
			if (this.appointmentCategory == null)
				return;
			this.appointmentCategory.Visible = false;
			if (this.lastSelectedPage != null)
			{
				this.ribbon.SelectedPage = this.lastSelectedPage;
				this.lastSelectedPage = null;
			}
		}
		RibbonPage GetFirstVisiblePage(RibbonPageCategory ribbonPageCategory)
		{
			foreach (RibbonPage page in ribbonPageCategory.Pages)
				if (page.Visible)
					return page;
			return null;
		}



	}

}
