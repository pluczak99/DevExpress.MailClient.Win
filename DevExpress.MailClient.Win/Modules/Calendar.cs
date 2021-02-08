﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
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
using MailClient.Data.Service;
using MailClient.Data.Library;

namespace DevExpress.MailClient.Win
{
	public partial class Calendar : BaseModule
	{
		RibbonControl ribbon;
		ucCalendar calendarControls;
		RibbonPageCategory appointmentCategory = null;
		RibbonPage lastSelectedPage = null;

		public ToDoTaskRepository todoTaskRepository { get; set; }

		public override string ModuleName { get { return Properties.Resources.CalendarName; } }
		public Calendar()
		{
			InitializeComponent();
			DatabindScheduler();
			schedulerControl1.Start = DateTime.Today;

		}
		public override DevExpress.XtraPrinting.IPrintable PrintableComponent
		{
			get
			{
				return schedulerControl1;
			}
		}

		public List<Appointment> ConvertToDoTasksToAppointments ( IEnumerable<ToDoTask> tasks )
		{
			List<Appointment> appointments = new List<Appointment>();
			foreach (var task in tasks)
			{
				var appointment = new AppointmentInstance();
				appointment.Start = task.StartDate;
				appointment.End = task.EndDate;
				appointment.Description = task.Note;
				appointments.Add(appointment);
			}
			return appointments;
		}
		protected override bool SaveCalendarVisible { get { return true; } }
		private void DatabindScheduler()
		{
			//schedulerStorage1.Resources.DataSource = DataHelper.CalendarResources;
			//schedulerStorage1.Appointments.DataSource = this.todoTaskRepository.ListAllTasks();
			//ToDoTaskRepository todoTaskRepository = new ToDoTaskRepository();

		}
		internal override void InitModule(DevExpress.Utils.Menu.IDXMenuManager manager, object data)
		{
			base.InitModule(manager, data);
			schedulerControl1.MenuManager = manager;
			this.ribbon = manager as RibbonControl;
			this.appointmentCategory = FindAppointmentPage(this.ribbon);
			//this.todoTaskRepository = new ToDoTaskRepository();

			var appointment = new AppointmentInstance();
			appointment.Start = DateTime.Now;
			appointment.End = DateTime.Now.AddDays(1);
			appointment.Subject = "BLAH";
			appointment.Duration = TimeSpan.FromHours(2);
			appointment.HasReminder = true;
			appointment.Reminder.TimeBeforeStart = TimeSpan.FromDays(5);
			this.schedulerControl1.DataStorage.Appointments.Add(appointment);


			if (calendarControls == null)
			{
				this.calendarControls = data as ucCalendar;
				this.calendarControls.InitDateNavigator(this.schedulerControl1);
				this.calendarControls.InitResourcesTree(this.schedulerStorage1);
				this.calendarControls.InitBarController(this.schedulerControl1);
			}

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
			SubscribeSchedulerEvents();
			UpdateAppointmentCategory();
		}
		internal override void HideModule()
		{
			UnsubscribeSchedulerEvents();
			HideAppointmentCategory();
			base.HideModule();
		}
		private void SubscribeSchedulerEvents()
		{
			this.schedulerStorage1.FilterAppointment += new PersistentObjectCancelEventHandler(this.schedulerStorage1_FilterAppointment);
			this.schedulerStorage1.AppointmentsDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsDeleted);
			this.schedulerStorage1.AppointmentDeleting += new PersistentObjectCancelEventHandler(schedulerStorage1_AppointmentDeleting);
			this.schedulerControl1.SelectionChanged += new EventHandler(schedulerControl1_SelectionChanged);
			//this.schedulerControl1.EditAppointmentFormShowing += SchedulerControl1_EditAppointmentFormShowing;
		}

		void UnsubscribeSchedulerEvents()
		{
			this.schedulerStorage1.FilterAppointment -= new PersistentObjectCancelEventHandler(this.schedulerStorage1_FilterAppointment);
			this.schedulerControl1.SelectionChanged -= new EventHandler(schedulerControl1_SelectionChanged);
			this.schedulerStorage1.AppointmentsDeleted -= new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsDeleted);
			this.schedulerControl1.SelectionChanged -= new EventHandler(schedulerControl1_SelectionChanged);
			//this.schedulerControl1.EditAppointmentFormShowing -= SchedulerControl1_EditAppointmentFormShowing;
		}

		void SchedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
		{
			if (e.Appointment != null && e.Appointment.Id != null)
			{
				//var serializer = new XmlSerializer(typeof(AppointmentInstance));
				//var stringWriter = new StringWriter();
				//serializer.Serialize(stringWriter, e.Appointment);
				//Console.WriteLine(stringWriter.ToString());
			}

			var form = new CustomAppointmentRibbonForm(this.schedulerControl1, e.Appointment, e.OpenRecurrenceForm);
			form.LookAndFeel.ParentLookAndFeel = LookAndFeel;
			form.SetMenuManager(this.schedulerControl1.MenuManager);
			form.RightToLeftLayout = WindowsFormsSettings.GetIsRightToLeft(this.schedulerControl1);
			form.RightToLeft = WindowsFormsSettings.GetRightToLeft(this.schedulerControl1);
			e.DialogResult = form.ShowDialog(this);
			e.Handled = true;
		}

		void schedulerStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
		{
			HideAppointmentCategory();
		}

		void schedulerControl1_SelectionChanged(object sender, EventArgs e)
		{
			UpdateAppointmentCategory();
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
		void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
		{
			HideAppointmentCategory();
		}
		private void schedulerControl1_InitNewAppointment(object sender, AppointmentEventArgs e)
		{
			List<int> selectedIds = this.calendarControls.GetSelectedResourceIds();
			if (selectedIds.Count > 0)
				e.Appointment.ResourceId = selectedIds[0];
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

			this.schedulerControl1.DataStorage.Appointments.Add(new AppointmentInstance() { Start = DateTime.Now, Subject = "Surprise!" });
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

		//private void schedulerControl1_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
		//{
		//	DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
		//	DevExpress.MailClient.Win.Modules.OutlookAppointmentForm form = new DevExpress.MailClient.Win.Modules.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
		//	try
		//	{
		//		e.DialogResult = form.ShowDialog();
		//		e.Handled = true;
		//	}
		//	finally
		//	{
		//		form.Dispose();
		//	}

		//}
	}

}
