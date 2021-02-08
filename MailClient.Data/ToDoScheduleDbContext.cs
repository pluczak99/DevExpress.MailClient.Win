using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailClient.Data.Library.Migrations;

namespace MailClient.Data.Library
{

	public class ToDoScheduleDbContext : DbContext
	{
		public ToDoScheduleDbContext()
		: base("TODOLIST")
		{
			Database.SetInitializer<ToDoScheduleDbContext>(new ToDoScheduleDbInitializer());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{ 
			modelBuilder.Configurations.Add(new MailClient.Data.Library.Migrations.ToDoTaskConfiguration());
			modelBuilder.Entity<ToDoTask>().ToTable("ToDoTask");
			modelBuilder.Entity<ToDoTaskUser>().ToTable("ToDoTaskUser");
		}

		public DbSet<ToDoTask> ToDoTasks { get; set; }
		public DbSet<ToDoTaskUser> ToDoTasksUsers { get; set; }
	}

}
