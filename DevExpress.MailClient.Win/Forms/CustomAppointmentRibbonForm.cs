using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
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

			//this.edtStartDate.Text = Properties.Resources.appointmentRibbonForm_StartTime_Label;

		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			this.Controls.Find("lblSubject", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_Subject_Label);
			this.Controls.Find("lblResource", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_Resource_Label);
			this.Controls.Find("btnPrint", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_btn_Print);
			this.Controls.Find("btnOptions", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_btn_Options);
			this.Controls.Find("chkAllDay", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_AllDay_Label);
			this.Controls.Find("lblLocation", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_Location_Label);
			this.Controls.Find("lblStartTime", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_StartTime_Label);
			this.Controls.Find("lblEndTime", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_EndTime_Label);
			this.Controls.Find("lblPercentComlete", true)[0].SetStringProperty("Text", Properties.Resources.appointmentRibbonForm_lblPercentComplete_Label);
		}

		protected override void InitCore()
		{
			base.InitCore();
		}

		protected override void OnMove(EventArgs e)
		{
			base.OnMove(e);
		}

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
