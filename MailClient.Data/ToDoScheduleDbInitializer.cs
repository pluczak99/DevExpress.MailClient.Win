using System.Collections.Generic;
using System.Data.Entity;
using System;

namespace MailClient.Data.Library
{
	public class ToDoScheduleDbInitializer : DropCreateDatabaseIfModelChanges<ToDoScheduleDbContext>
	{
		
		protected override void Seed(ToDoScheduleDbContext context)
		{
			IList<ToDoTask> tasks = new List<ToDoTask>();
			tasks.Add(new ToDoTask() { StartDate = DateTime.Today.AddDays(1), Note = "Note 1" });
			tasks.Add(new ToDoTask() { StartDate = DateTime.Today.AddDays(2), Note = "Note 2" });
			tasks.Add(new ToDoTask() { StartDate = DateTime.Today.AddDays(3), Note = "Note 3" });

			context.ToDoTasks.Add(tasks[0]);
			context.ToDoTasks.Add(tasks[1]);
			context.ToDoTasks.Add(tasks[2]);
			base.Seed(context);
		}
	}

}
