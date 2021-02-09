using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.MailClient.Win
{
	public class CustomAppointmentRibbonForm : AppointmentRibbonForm
	{
		public SchedulerControl Scheduler { get; set; }
		public Appointment Appointment { get; set; }
		public new bool OpenRecurrenceForm { get; set; }

		//public override bool SaveFormData(Appointment appointment)
		//{
		//	return base.SaveFormData(appointment);
		//}

		public CustomAppointmentRibbonForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) : base(control, apt, openRecurrenceForm)
		{
			this.OpenRecurrenceForm = openRecurrenceForm;
		}

		protected override DialogResult ShowRecurrenceForm(Form form)
		{
			if (this.OpenRecurrenceForm)
			{
				var dr = form.ShowDialog();
				return dr;
			}
			return DialogResult.Cancel;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			//if (this.Appointment.Id == null)
			//{
			//	this.Appointment.SetId(Guid.NewGuid());
			//	if (this.Appointment.HasReminder == false && this.Appointment.Type != AppointmentType.Pattern)
			//	{
			//		this.Ribbon.FindRibbonControl<BarEditItem>("barReminder").EditValue = TimeSpan.FromMinutes(15);
			//		this.Ribbon.FindRibbonControl<BarEditItem>("barReminder").EditValue = this.Appointment.Reminder.TimeBeforeStart;
			//	}
			//}

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


			if (this.OpenRecurrenceForm)
			{
				//this.Appointment.Type = AppointmentType.Pattern;
			}

		}

	}

}
