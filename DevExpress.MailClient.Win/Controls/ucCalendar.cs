using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraScheduler.Forms;
using DevExpress.Skins;
using DevExpress.XtraNavBar;
using DevExpress.XtraScheduler.UI;

namespace DevExpress.MailClient.Win.Controls {
    public partial class ucCalendar : NavPanePanel {
        SchedulerControl schedulerControl;
        SchedulerBarController barController;
		private DEVEXPRESSDataSet1 dataSet;
		private System.Windows.Forms.BindingSource dEVEXPRESSDataSetBindingSource1;
		private DEVEXPRESSDataSet dEVEXPRESSDataSet;
		private System.Windows.Forms.BindingSource dEVEXPRESSDataSetBindingSource;
		private System.Windows.Forms.BindingSource resourcesBindingSource;
		private DEVEXPRESSDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;



		public ucCalendar() {
            InitializeComponent();
        }
        public void StateChanged(NavPaneState state) {
            this.State = state;
        }
        public void InitDateNavigator(SchedulerControl schedulerControl) {
            this.schedulerControl = schedulerControl;
            this.dateNavigator1.SchedulerControl = schedulerControl;
			this.schedulerControl.RemindersFormShowing += SchedulerControl_RemindersFormShowing;
        }

		private void SchedulerControl_RemindersFormShowing(object sender, RemindersFormEventArgs e)
		{
			foreach (ReminderAlertNotification alert in e.AlertNotifications)
            {
                if (string.IsNullOrEmpty(alert.Reminder.Subject))
                {
                    //alert.Reminder.Appointment.Subject = $"To-Do Task (starts at {alert.ActualAppointment.Start.ToString()})";
				}
			}
            if (e.AlertNotifications.Count > 0)
            {
                RemindersForm remindersForm = new RemindersForm((SchedulerControl)sender);
                remindersForm.Controls.FindControl("btnSnooze").SetText(Properties.Resources.Reminder_btnSnooze_Caption);
                remindersForm.Controls.FindControl("lblStart").SetText(Properties.Resources.Reminder_lblStart_Caption);
                remindersForm.Controls.FindControl("lblSnooze").SetText(Properties.Resources.Reminder_lblSnooze_Caption);
                remindersForm.Controls.FindControl("btnDismiss").SetText(Properties.Resources.Reminder_btnDismiss_Caption);
                remindersForm.Controls.FindControl("btnDismissAll").SetText(Properties.Resources.Reminder_btnDismissAll_Caption);
                remindersForm.Controls.FindControl("btnOpenItem").SetText(Properties.Resources.Reminder_btnOpenItem_Caption);
                remindersForm.Controls.FindControl("lblSubject").SetText(Properties.Resources.Reminder_lblSubject_Caption);
                ReminderEventArgs args = new ReminderEventArgs(e.AlertNotifications);
                remindersForm.OnReminderAlert(args);
			}
            e.Handled = true;
		}

		public void InitResourcesTree(SchedulerStorage storage) {
        }
        public void InitBarController(SchedulerControl scheduler) {
            this.barController.Control = scheduler;
        }        
        protected int CalculateResourceCategory(int resourceId) {
            return resourceId < 3 ? 0 : 1;
        }
        public List<int> GetSelectedResourceIds() {
            List<int> result = new List<int>();
            return result;
        }
        public void SetBarController(SchedulerBarController barController) {
            this.barController = barController;
        }
    }
}
