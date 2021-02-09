namespace DevExpress.MailClient.Win.Controls {
    partial class ucCalendar {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCalendar));
			this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
			((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// dateNavigator1
			// 
			this.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.dateNavigator1.CalendarHorizontalIndent = 0;
			this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateNavigator1.CalendarTimeProperties.Buttons"))))});
			this.dateNavigator1.CalendarVerticalIndent = 0;
			this.dateNavigator1.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
			this.dateNavigator1.CellPadding = new System.Windows.Forms.Padding(-2, -1, -2, -2);
			this.dateNavigator1.DateTime = new System.DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, 1);
			resources.ApplyResources(this.dateNavigator1, "dateNavigator1");
			this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday;
			this.dateNavigator1.Name = "dateNavigator1";
			// 
			// ucCalendar
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateNavigator1);
			this.Name = "ucCalendar";
			((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
		private DevExpress.XtraTreeList.TreeList treeResources;
		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
	}
}
