using MailClient.Data.Service;
using System;

namespace DevExpress.MailClient.Win {
    public partial class Calendar {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
			DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
			DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
			DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
			DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
			DevExpress.XtraScheduler.TimeScaleFixedInterval timeScaleFixedInterval1 = new DevExpress.XtraScheduler.TimeScaleFixedInterval();
			DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
			this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
			this.dEVEXPRESSDataSet = new DevExpress.MailClient.Win.DEVEXPRESSDataSet();
			this.dEVEXPRESSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.resourcesTableAdapter = new DevExpress.MailClient.Win.DEVEXPRESSDataSetTableAdapters.ResourcesTableAdapter();
			this.dEVEXPRESSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSetBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulerStorage1
			// 
			this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ContactInfo", "ContactInfo", DevExpress.XtraScheduler.FieldValueType.String));
			this.schedulerStorage1.Appointments.DataSource = this.dEVEXPRESSDataSetBindingSource1;
			this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
			this.schedulerStorage1.Appointments.Mappings.Description = "Description";
			this.schedulerStorage1.Appointments.Mappings.End = "EndDate";
			this.schedulerStorage1.Appointments.Mappings.Label = "Label";
			this.schedulerStorage1.Appointments.Mappings.Location = "Location";
			this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
			this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
			this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID";
			this.schedulerStorage1.Appointments.Mappings.Start = "StartDate";
			this.schedulerStorage1.Appointments.Mappings.Status = "Status";
			this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
			this.schedulerStorage1.Appointments.Mappings.Type = "EventType";
			this.schedulerStorage1.Resources.DataSource = this.dEVEXPRESSDataSetBindingSource;
			this.schedulerStorage1.Resources.Mappings.Caption = "Name";
			this.schedulerStorage1.Resources.Mappings.Id = "ID";
			// 
			// schedulerControl1
			// 
			this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
			this.schedulerControl1.DataStorage = this.schedulerStorage1;
			resources.ApplyResources(this.schedulerControl1, "schedulerControl1");
			this.schedulerControl1.Name = "schedulerControl1";
			this.schedulerControl1.Start = new System.DateTime(2021, 1, 31, 0, 0, 0, 0);
			this.schedulerControl1.Views.DayView.ShowWorkTimeOnly = true;
			this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
			this.schedulerControl1.Views.FullWeekView.Enabled = true;
			this.schedulerControl1.Views.GanttView.Enabled = false;
			timeScaleMonth1.Enabled = false;
			timeScaleMonth1.Width = 100;
			timeScaleWeek1.Width = 100;
			timeScaleDay1.Width = 100;
			timeScaleHour1.Enabled = false;
			timeScaleHour1.Width = 100;
			timeScaleFixedInterval1.Enabled = false;
			timeScaleFixedInterval1.Value = System.TimeSpan.Parse("00:30:00");
			timeScaleFixedInterval1.Width = 100;
			this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleMonth1);
			this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleWeek1);
			this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleDay1);
			this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleHour1);
			this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleFixedInterval1);
			this.schedulerControl1.Views.WorkWeekView.ShowFullWeek = true;
			this.schedulerControl1.Views.WorkWeekView.ShowWorkTimeOnly = true;
			this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
			this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
			this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.SchedulerControl1_EditAppointmentFormShowing);
			// 
			// dEVEXPRESSDataSet
			// 
			this.dEVEXPRESSDataSet.DataSetName = "DEVEXPRESSDataSet";
			this.dEVEXPRESSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dEVEXPRESSDataSetBindingSource
			// 
			this.dEVEXPRESSDataSetBindingSource.DataSource = this.dEVEXPRESSDataSet;
			this.dEVEXPRESSDataSetBindingSource.Position = 0;
			// 
			// resourcesBindingSource
			// 
			this.resourcesBindingSource.DataMember = "Resources";
			this.resourcesBindingSource.DataSource = this.dEVEXPRESSDataSetBindingSource;
			// 
			// resourcesTableAdapter
			// 
			this.resourcesTableAdapter.ClearBeforeFill = true;
			// 
			// dEVEXPRESSDataSetBindingSource1
			// 
			this.dEVEXPRESSDataSetBindingSource1.DataSource = this.dEVEXPRESSDataSet;
			this.dEVEXPRESSDataSetBindingSource1.Position = 0;
			// 
			// Calendar
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.schedulerControl1);
			this.Name = "Calendar";
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSetBindingSource1)).EndInit();
			this.ResumeLayout(false);

        }

		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;

		private void SchedulerControl1_EditAppointmentFormShowing1(object sender, XtraScheduler.AppointmentFormEventArgs e)
		{
			e.Appointment.CustomFields["_repository"] = this.todoTaskRepository;
		}

		private void SchedulerControl1_InitNewAppointment(object sender, XtraScheduler.AppointmentEventArgs e)
		{
			//e.Appointment.SetId(Guid.NewGuid()); // assign ID to a new appointment and use it while saving
			e.Appointment.CustomFields["_repository"] = this.todoTaskRepository;
		}

		#endregion

		private System.Windows.Forms.BindingSource dEVEXPRESSDataSetBindingSource1;
		private DEVEXPRESSDataSet dEVEXPRESSDataSet;
		private System.Windows.Forms.BindingSource dEVEXPRESSDataSetBindingSource;
		private System.Windows.Forms.BindingSource resourcesBindingSource;
		private DEVEXPRESSDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
	}
}
