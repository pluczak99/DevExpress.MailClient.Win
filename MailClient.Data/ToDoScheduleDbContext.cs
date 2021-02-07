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

		public void FixEfProviderServicesProblem()
		{
			//The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
			//for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
			//Make sure the provider assembly is available to the running application. 
			//See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

			//var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
		}


		public DbSet<ToDoTask> ToDoTasks { get; set; }
		public DbSet<ToDoTaskUser> ToDoTasksUsers { get; set; }
	}

}
