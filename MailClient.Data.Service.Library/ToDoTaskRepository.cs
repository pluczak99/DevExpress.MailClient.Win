using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailClient.Data;
using MailClient.Data.Library;

namespace MailClient.Data.Service
{
	public class ToDoTaskRepository
    {

	    ToDoScheduleDbContext DbContext { get; set; }
        public ToDoTaskRepository()
        {
            this.DbContext = new ToDoScheduleDbContext();
		}
        public List<ToDoTask> ListAllTasks()
        {
            var task1 = new ToDoTask()
            {
                Note = "Test1",
                StartDate = DateTime.Today.AddDays(-1),
                EndDate = DateTime.Today.AddDays(1)
            };

            var task2 = new ToDoTask()
            {
                Note = "Test2",
                StartDate = DateTime.Today.AddDays(0),
                EndDate = DateTime.Today.AddDays(2)
            };

            var tasks = new List<ToDoTask>();
            tasks.AddRange(new ToDoTask[] { task1, task2 });
            
            return tasks;
		}

        // TODO: this method may not be necessary
        public List<ToDoTask> ListTasks( ToDoTaskQuery query)
        {
            // TODO: implement
            return new List<ToDoTask>();
		}

        public ToDoTask CreateNewTodoTask ( ToDoTask task )
        {
            // TODO: implement
            return task;
		}

        public bool UpdateToDoTask ( ToDoTask task )
        {
            // TODO: implement
            return true;
		}

        public void DeleteToDoTaskInstance ( ToDoTask task )
        {
            // TODO: implement
		}

        public void DeleteToDoTaskSeries ( ToDoTask task )
        {
            // TODO: implement
		}
    }
}
