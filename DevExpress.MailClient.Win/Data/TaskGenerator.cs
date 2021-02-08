using DevExpress.XtraScheduler.Internal.Implementations;
using System;
using System.Collections.Generic;

namespace DevExpress.MailClient.Win
{
	internal class TaskGenerator
	{
		public static int CustomerCount = 10;
		static Random rndGenerator = new Random();
		static List<Contact> customers;
		internal static List<Contact> Customers
		{
			get
			{
				if (customers == null)
				{
					customers = new List<Contact>();
					//List<Contact> temp = DataHelper.GetContacts().Where((c) => c.LastName == "Kowalski").ToList();
					//customers.Add(temp.First());
				}
				return customers;
			}
		}
		static Contact GetCustomer(int index, List<Contact> customers, List<Contact> contacts)
		{
			Contact contact = contacts[index];
			foreach (Contact c in customers)
				if (ReferenceEquals(c, contact)) return null;
			return contact;
		}
		//public static Task CreateTask(string subject, TaskCategory category)
		//{
		//	Task task = new Task(subject, category, DateTime.Now.AddHours(-rndGenerator.Next(96)));
		//	int rndStatus = rndGenerator.Next(10);
		//	if (task.TimeDiff.TotalHours > 12)
		//	{
		//		if (task.TimeDiff.TotalHours > 80)
		//		{
		//			task.Status = TaskStatus.Completed;

		//		}
		//		else
		//		{
		//			task.Status = TaskStatus.InProgress;
		//			task.PercentComplete = rndGenerator.Next(9) * 10;
		//		}
		//		task.StartDate = task.CreatedDate.AddMinutes(rndGenerator.Next(720)).Date;
		//	}
		//	if (rndStatus != 5) task.DueDate = task.CreatedDate.AddHours((90 - rndStatus * 9) + 24).Date;
		//	if (rndStatus > 8) task.Priority = 2;
		//	if (rndStatus < 3) task.Priority = 0;
		//	if (rndStatus == 6 && task.Status == TaskStatus.InProgress) task.Status = TaskStatus.Deferred;
		//	if (rndStatus == 4 && task.Status == TaskStatus.InProgress && task.PercentComplete < 40) task.Status = TaskStatus.WaitingOnSomeoneElse;
		//	if (task.Category == TaskCategory.Office && rndStatus != 7 && Customers.Count > 0)
		//		task.AssignTo = Customers[rndGenerator.Next(Customers.Count)];
		//	if (task.Status == TaskStatus.Completed)
		//	{
		//		if (!task.StartDate.HasValue) task.StartDate = task.CreatedDate.AddHours(12).Date;
		//		task.CompletedDate = task.StartDate.Value.AddHours(rndGenerator.Next(48) + 24);
		//	}
		//	return task;
		//}

		//public static void GenerateTasks ( DevExpress.MailClient.Win.Controls.ucCalendar calendar )
		//{
		//	Task t1 = new Task("Test", TaskCategory.Office);
		//	t1.StartDate = DateTime.Now.AddDays(-1);
		//	t1.DueDate = DateTime.Now.AddDays(1);
		//	t1.Description = "Description";
		//	var appointment = new AppointmentItem();
		//	appointment.Subject = Guid.NewGuid().ToString("X");
		//	//scheduler.DataStorage.Appointments.Add(appointment);
		//}
	}
}