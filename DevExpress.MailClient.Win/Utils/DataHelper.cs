using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.EntityClient;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DevAV;
using DevExpress.Utils;
using DevExpress.XtraEditors;


namespace DevExpress.MailClient.Win
{
	public class DataHelper
	{

		internal static bool ShowAllMessageCount = false;
		internal static bool ShowUnreadMessageCount = true;

		internal static DateTime CalendarDate = DateTime.Today;
		internal static string[] ApplicationArguments;
	}
}