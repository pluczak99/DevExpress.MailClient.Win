using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MailClient.Data.Library
{
	public class ToDoTask
	{
		[Key]
		public int Id { get; set; }
		public bool AllDay { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Note { get; set; }
		public string Location { get; set; }
		public string RecurrenceInfo { get; set; }
		public string ReminderInfo { get; set; }
	}

}
