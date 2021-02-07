using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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

		//static List<Message> messages = null;
		static List<Contact> contacts = null;
		static List<Task> tasks = null;
		//static BindingList<Employee> employees = null;
		static DataTable calendarResourcesTable;
		static DataTable calendarAppointmentsTable;


		internal static DateTime CalendarDate = DateTime.Today;
		internal static string[] ApplicationArguments;


//		internal static DataTable MailTable
//		{
//			get
//			{
//				string table = "Messages";
//				DataTable messages = CreateDataTable(table);
//				return messages;
//			}
//		}
//		internal static BindingList<Employee> Employees
//		{
//			get
//			{
//				if (employees == null)
//				{
//#if !DXCORE3
//					DevAVDb devAvDb = new DevAVDb();
//#else
//                    DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3", DevAVDataDirectoryHelper.DataFolderName)}");
//#endif
//					devAvDb.Employees.Load();
//					employees = devAvDb.Employees.Local.ToBindingList();
//				}
//				return employees;
//			}
//		}
		//public static string GetNameByEmail(string email)
		//{
		//	Employee employee = Employees.FirstOrDefault(p => p.Email == email);
		//	return (employee != null) ? employee.FullName : string.Empty;
		//}
		//public static Image GetPhotoByEmail(string email)
		//{
		//	Employee employee = Employees.FirstOrDefault(p => p.Email == email);
		//	return (employee != null && employee.Picture != null) ? employee.Photo : null;
		//}
		//static List<Task> GenerateTasks()
		//{
		//	List<Task> ret = new List<Task>();
		//	for (int i = 0; i < TaskGenerator.CustomerCount; i++)
		//		foreach (string s in CollectionResources.OfficeTasks)
		//			ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Office));
		//	foreach (string s in CollectionResources.HouseTasks)
		//		ret.Add(TaskGenerator.CreateTask(s, TaskCategory.HouseChores));
		//	foreach (string s in CollectionResources.ShoppingTasks)
		//		ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Shopping));
		//	return ret;
		//}
		//internal static List<Contact> GetContacts()
		//{
		//	List<Contact> ret = new List<Contact>();
		//	foreach (Employee emp in Employees)
		//		ret.Add(new Contact(emp));
		//	return ret;
		//}
		//internal static Contact FindByName(string name)
		//{
		//	if (string.IsNullOrEmpty(name)) return null;
		//	return Contacts.FirstOrDefault(p => p.Name == name || p.EmployeeName == name);
		//}
		static Message CreateMessageAbout()
		{
			Message ret = new Message();
			ret.Subject = Properties.Resources.AboutSubj;
			ret.From = Properties.Resources.AboutFrom;
			ret.Priority = 2;
			ret.Text = ObjectHelper.GetMHTTextFromHTML(StringResources.Get("AboutMessage"));
			ret.SetPlainText(StringResources.Get("AboutMessagePlain"));
			ret.MailFolder = (int)MailFolder.Announcements;
			return ret;
		}

		//internal static DataTable CalendarResources
		//{
		//	get
		//	{
		//		if (calendarResourcesTable == null)
		//		{
		//			string table = "Resources";
		//			calendarResourcesTable = CreateDataTable(table);
		//		}
		//		return calendarResourcesTable;
		//	}
		//}
		internal static DataTable CalendarAppointments
		{
			get
			{
				if (calendarAppointmentsTable == null)
				{
					string table = "Appointments";
					calendarAppointmentsTable = CreateDataTable(table);
				}
				return calendarAppointmentsTable;
			}
		}

		private static DataTable CreateDataTable(string table)
		{
			DataSet ds = new DataSet();
			DataSet dataSet = new DataSet();
			var singleTable = dataSet.Tables.Add(table);
			return singleTable;
		}
	}
}