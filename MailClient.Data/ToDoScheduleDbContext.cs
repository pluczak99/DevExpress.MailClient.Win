using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient.Data.Library
{

	public class ToDoScheduleDbContext : DbContext
	{
		public ToDoScheduleDbContext()
			: base("ToDoTasks")
		{

		}
		public DbSet<ToDoTask> ToDoTasks { get; set; }
		public DbSet<ToDoTaskUser> ToDoTasksUsers { get; set; }
	}

}
