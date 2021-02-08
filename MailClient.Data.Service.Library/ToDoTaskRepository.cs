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
            var tasks = this.DbContext.ToDoTasks.ToList();
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
