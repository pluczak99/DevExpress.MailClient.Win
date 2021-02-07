using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.MailClient.Win
{
	public class CustomAppointmentRibbonForm : AppointmentRibbonForm
	{
		public override bool SaveFormData(Appointment appointment)
		{
			return base.SaveFormData(appointment);
		}

		public CustomAppointmentRibbonForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) : base(control, apt, openRecurrenceForm)
		{
		}

		protected override DialogResult ShowRecurrenceForm(Form form)
		{
			string name = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
			return base.ShowRecurrenceForm(form);
		}
	}

}
