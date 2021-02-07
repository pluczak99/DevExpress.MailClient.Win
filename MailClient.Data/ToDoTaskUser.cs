using System;
using System.ComponentModel.DataAnnotations;

namespace MailClient.Data.Library
{
	public class ToDoTaskUser
	{
		[Key]
		public Int64 Id { get; set; }
		public string Name { get; set; }
	}

}
