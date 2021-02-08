using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MailClient.Data.Library
{
	public class ToDoTask
	{
		public ToDoTask()
		{
			this.Id = Guid.NewGuid();
		}
		[Key]
		public Guid Id { get; set; }
		public bool AllDay { get; set; }
		[Required]
		public DateTime StartDate { get; set; }
		[Required]
		public DateTime EndDate { get; set; }
		public string Note { get; set; }
		public string Location { get; set; }
		public string RecurrenceInfo { get; set; }
	}

}
