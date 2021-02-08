using System;
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
		public bool OpenRecurrenceForm { get; set; }

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
