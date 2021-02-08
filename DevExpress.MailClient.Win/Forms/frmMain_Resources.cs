using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraRichEdit;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.Utils.About;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraEditors.ColorWheel;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.Utils.Taskbar;
using System.Globalization;
using DevExpress.MailClient.Win.Properties;

namespace DevExpress.MailClient.Win
{
	public partial class frmMain : RibbonForm
	{
		/// <summary>
		/// This method is called from InitializeComponent as a means to customize locale-related strings in the UI
		/// </summary>
		private void InitializeComponentExt()
		{
			this.bvtiInfo.Caption = Properties.Resources.bvtiInfoCaption;
			this.bvtiOpen.Caption = Properties.Resources.bvtiOpenCaption;
			this.bvtiExport.Caption = Properties.Resources.bvtiExportCaption;
			this.bvbiSaveAs.Caption = Properties.Resources.bvbiSaveAsCaption;
			this.bvbiSaveAttachment.Caption = Properties.Resources.bvbiSaveAsCaption;
			this.bvbiSaveCalendar.Caption = Properties.Resources.bvbiSaveCalendarCaption;
			this.bvtiPrint.Caption = Properties.Resources.bvtiPrintCaption;
			this.bvbiExit.Caption = Properties.Resources.bvtiExitCaption;
			this.appointmentRibbonPageGroup1.Text = Properties.Resources.appointmentRibbonPageGroup1Caption;
			this.groupByRibbonPageGroup1.Text = Properties.Resources.groupByRibbonPageGroup1Caption;
			this.layoutRibbonPageGroup1.Text = Properties.Resources.layoutRibbonPageGroup1Caption;
			this.nbgCalendar.Caption = Properties.Resources.CalendarName;
		}
	}
}
