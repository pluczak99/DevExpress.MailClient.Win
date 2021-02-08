using System.Collections.Generic;
using System.Data.Entity;
using System;

namespace MailClient.Data.Library
{
	public class ToDoScheduleDbInitializer : DropCreateDatabaseIfModelChanges<ToDoScheduleDbContext>
	{
		
		protected override void Seed(ToDoScheduleDbContext context)
		{
			base.Seed(context);
		}
	}

}
