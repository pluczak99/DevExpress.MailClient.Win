using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
using MailClient.Data.Service;

namespace DevExpress.MailClient.Win


{
	public class CustomAppointmentRibbonForm : AppointmentRibbonForm
	{
		public ToDoTaskRepository Repository { get; set; }
		public SchedulerControl Scheduler { get; set; }
		public Appointment Appointment { get; set; }
		public new bool OpenRecurrenceForm { get; set; }

		public override bool SaveFormData(Appointment appointment)
		{
			return base.SaveFormData(appointment);
		}

		public CustomAppointmentRibbonForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) : base(control, apt, openRecurrenceForm)
		{

			this.Repository = apt.CustomFields["_repository"] as ToDoTaskRepository;
			this.Scheduler = control;
			this.Appointment = apt;
			this.OpenRecurrenceForm = openRecurrenceForm;
			this.Storage.EnableReminders = true;

			this.Appointment = this.Storage.CreateAppointment(AppointmentType.Normal);
			this.Appointment.Assign(apt);

			//this.Scheduler.DataStorage.Remi
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (this.Appointment.Id == null)
			{
				this.Appointment.SetId(Guid.NewGuid());
				if (this.Appointment.HasReminder == false)
				{
					var r = this.Storage.CreateReminder(this.Appointment);
					if (r != null)
					{
						r.TimeBeforeStart = TimeSpan.FromMinutes(15);
						r.AlertTime = this.Appointment.Start.Subtract(r.TimeBeforeStart);
						
						this.Appointment.Reminders.Add(r);
						this.Ribbon.FindRibbonControl<BarEditItem>("barReminder").EditValue = TimeSpan.FromMinutes(15);
						
					}
				}
				else
				{
					this.Ribbon.FindRibbonControl<BarEditItem>("barReminder").EditValue = this.Appointment.Reminder.TimeBeforeStart;
				}
			}


			this.Controls.FindControl("lblSubject").SetText(Properties.Resources.appointmentRibbonForm_Subject_Label);
			this.Controls.FindControl("lblResource").SetText(Properties.Resources.appointmentRibbonForm_Resource_Label);
			this.Controls.FindControl("btnPrint").SetText(Properties.Resources.appointmentRibbonForm_btn_Print);
			this.Controls.FindControl("btnOptions").SetText(Properties.Resources.appointmentRibbonForm_btn_Options);
			this.Controls.FindControl("chkAllDay").SetText(Properties.Resources.appointmentRibbonForm_AllDay_Label);
			this.Controls.FindControl("lblLocation").SetText(Properties.Resources.appointmentRibbonForm_Location_Label);
			this.Controls.FindControl("lblStartTime").SetText(Properties.Resources.appointmentRibbonForm_StartTime_Label);
			this.Controls.FindControl("lblEndTime").SetText(Properties.Resources.appointmentRibbonForm_EndTime_Label);
			this.Controls.FindControl("lblPercentComplete").SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_lblPercentComplete_Label);

			var descriptions = this.Ribbon.DescribeControls();

			this.Ribbon.FindRibbonControl<BarButtonItem>("btnSaveAndClose").SetBarButtonItemTexts(Properties.Resources.Appointment_btnSaveAndClose_Caption, Properties.Resources.Appointment_btnSaveAndClose_Hint);
			this.Ribbon.FindRibbonControl<BarButtonItem>("btnDelete").SetBarButtonItemTexts(Properties.Resources.Appointment_btnDelete_Caption, Properties.Resources.Appointment_btnDelete_Hint);

			this.Ribbon.Pages[0].Text = Properties.Resources.Appointment_Ribbon_Page_Caption;
			this.Ribbon.FindBarItem("barLabel").SetBarButtonItemTexts(Properties.Resources.Appointment_barLabel_Caption, Properties.Resources.Appointment_barLabel_Hint);
			this.Ribbon.FindBarItem("barStatus").SetBarButtonItemTexts(Properties.Resources.Appointment_barStatus_Caption, Properties.Resources.Appointment_barStatus_Hint);
			this.Ribbon.FindBarItem("barReminder").SetBarButtonItemTexts(Properties.Resources.Appointment_barReminder_Caption, Properties.Resources.Appointment_barReminder_Hint);
			this.Ribbon.FindBarItem("btnRecurrence").SetBarButtonItemTexts(Properties.Resources.Appointment_btnRecurrence_Caption, Properties.Resources.Appointment_btnRecurrence_Hint);
			this.Ribbon.FindBarItem("btnSave").SetBarButtonItemTexts(Properties.Resources.Appointment_btnSave_Caption, Properties.Resources.Appointment_btnSave_Hint);
			this.Ribbon.FindBarItem("btnNext").SetBarButtonItemTexts(Properties.Resources.Appointment_btnNext_Caption, Properties.Resources.Appointment_btnNext_Hint);
			this.Ribbon.FindBarItem("btnPrevious").SetBarButtonItemTexts(Properties.Resources.Appointment_btnPrevious_Caption, Properties.Resources.Appointment_btnPrevious_Hint);

			this.Ribbon.FindBarItem("btnTimeZones").Visibility = BarItemVisibility.Never;


		}

		//protected override void OnShown(EventArgs e)
		//{
		//	base.OnShown(e);
		//}

		//protected override void InitCore()
		//{
		//	base.InitCore();
		//}

		//protected override void OnMove(EventArgs e)
		//{
		//	base.OnMove(e);
		//}

		protected override void OnSaveButton()
		{
			base.OnSaveButton();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.Cancel == false)
			{
			}
			base.OnFormClosing(e);
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
		}

		protected override void OnDeleteButton()
		{
			base.OnDeleteButton();
		}

		protected override DialogResult ShowRecurrenceForm(Form form)
		{
			string name = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
			return base.ShowRecurrenceForm(form);
		}
	}

}
