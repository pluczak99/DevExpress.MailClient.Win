using System;

namespace MailClient.Data.Service
{
	public class ToDoTaskQuery
    {
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
		public string ToDoTaskSubjectSubtext { get; set; }
		public string ToDoTaskContentSubtext { get; set; }
	}
}
