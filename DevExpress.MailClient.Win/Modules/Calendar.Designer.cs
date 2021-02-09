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
			this.dEVEXPRESSDataSet1 = new DevExpress.MailClient.Win.DEVEXPRESSDataSet1();
			this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.appointmentsTableAdapter = new DevExpress.MailClient.Win.DEVEXPRESSDataSet1TableAdapters.AppointmentsTableAdapter();
			this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.resourcesTableAdapter = new DevExpress.MailClient.Win.DEVEXPRESSDataSet1TableAdapters.ResourcesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// schedulerStorage1
			// 
			this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ContactInfo", "ContactInfo", DevExpress.XtraScheduler.FieldValueType.String));
			this.schedulerStorage1.Appointments.DataSource = this.appointmentsBindingSource;
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
			this.schedulerStorage1.Resources.DataSource = this.resourcesBindingSource;
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
			// dEVEXPRESSDataSet1
			// 
			this.dEVEXPRESSDataSet1.DataSetName = "DEVEXPRESSDataSet1";
			this.dEVEXPRESSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// appointmentsBindingSource
			// 
			this.appointmentsBindingSource.DataMember = "Appointments";
			this.appointmentsBindingSource.DataSource = this.dEVEXPRESSDataSet1;
			// 
			// appointmentsTableAdapter
			// 
			this.appointmentsTableAdapter.ClearBeforeFill = true;
			// 
			// resourcesBindingSource
			// 
			this.resourcesBindingSource.DataMember = "Resources";
			this.resourcesBindingSource.DataSource = this.dEVEXPRESSDataSet1;
			// 
			// resourcesTableAdapter
			// 
			this.resourcesTableAdapter.ClearBeforeFill = true;
			// 
			// Calendar
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.schedulerControl1);
			this.Name = "Calendar";
			((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dEVEXPRESSDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

		private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
		private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;

		#endregion

		private System.Windows.Forms.BindingSource appointmentsBindingSource;
		private DEVEXPRESSDataSet1 dEVEXPRESSDataSet1;
		private System.Windows.Forms.BindingSource resourcesBindingSource;
		private DEVEXPRESSDataSet1TableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
		private DEVEXPRESSDataSet1TableAdapters.ResourcesTableAdapter resourcesTableAdapter;
	}
}
