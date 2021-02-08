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
		[Required]
		public bool AllDay { get; set; }
		[Required]
		public DateTime StartDate { get; set; }
		[Required]
		public DateTime EndDate { get; set; }

		[NotMapped]
		public TimeSpan Duration
		{
			get
			{
				if (this.AllDay)
				{
					return TimeSpan.FromDays(this.EndDate.Subtract(this.StartDate).TotalDays);
				}
				return this.EndDate.Subtract(this.StartDate);
			}
		}

		public string Note { get; set; }
		public string Location { get; set; }
		public string RecurrenceInfo { get; set; }

		public string RecurrenceInfoXml { get; set; }
		public string Reminder { get; set; }
	}

}
