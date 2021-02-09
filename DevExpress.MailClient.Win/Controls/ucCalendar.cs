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
				//remindersForm.FormClosed += RemindersForm_FormClosed;
                remindersForm.OnReminderAlert(args);
			}
            e.Handled = true;
		}

		//private void RemindersForm_FormClosed(object sender, FormClosedEventArgs e)
		//{
  //          // TODO: handle alert actions
		//}

		public void InitResourcesTree(SchedulerStorage storage) {
        }
        public void InitBarController(SchedulerControl scheduler) {
            this.barController.Control = scheduler;
        }        
        protected int CalculateResourceCategory(int resourceId) {
            return resourceId < 3 ? 0 : 1;
        }
        private void treeResources_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            //foreach (TreeListNode node in e.Node.Nodes) {
            //    node.CheckState = e.Node.CheckState;
            //}
            //if (e.Node.ParentNode != null) 
            //    e.Node.ParentNode.CheckState = GetParentNodeState(e.Node.ParentNode.Nodes);

            //this.schedulerControl.ActiveView.LayoutChanged();
        }
        //CheckState GetParentNodeState(TreeListNodes nodes) {
        //    //CheckState state = nodes[0].CheckState;
        //    //foreach (TreeListNode node in nodes)
        //    //    if (node.CheckState != state) return CheckState.Indeterminate;
        //    //return state;
        //}
        public List<int> GetSelectedResourceIds() {
            List<int> result = new List<int>();
            //FillSelectedNodes(treeResources.Nodes[0], result);
            //FillSelectedNodes(treeResources.Nodes[1], result);
            return result;
        }
        private void FillSelectedNodes(TreeListNode node, List<int> resourceIds) {
            foreach (TreeListNode item in node.Nodes)
                if (item.CheckState == CheckState.Checked)
                    resourceIds.Add((int)item.Tag);
        }

        private void treeResources_AfterCollapse(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            EndCalcTreeListHeight();
        }

        private void treeResources_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e) {
            EndCalcTreeListHeight();
        }
        void StartCalcTreeListHeight() {
            //treeResources.BeginUpdate();
        }
        void CalcTreeListHeight() {
            //treeResources.Height = GetExpandedRowCount(treeResources.Nodes) * treeResources.ViewInfo.RowHeight + 2;
        }
        void EndCalcTreeListHeight() {
            CalcTreeListHeight();
            //treeResources.EndUpdate();
        }
        public void UpdateTreeListHeight() {
            BeginInvoke(new MethodInvoker(CalcTreeListHeight));
        }
        int GetExpandedRowCount(TreeListNodes nodes) {
            int count = 0;
            foreach(TreeListNode node in nodes) {
                count++;
                if(node.Expanded)
                    count += GetExpandedRowCount(node.Nodes);
            }
            return count;
        }

        private void treeResources_BeforeCollapse(object sender, DevExpress.XtraTreeList.BeforeCollapseEventArgs e) {
            StartCalcTreeListHeight();
        }

        private void treeResources_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e) {
            StartCalcTreeListHeight();
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            CalcTreeListHeight();
        }

        public void SetBarController(SchedulerBarController barController) {
            this.barController = barController;
        }
    }
}
