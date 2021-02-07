using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailClient.Data.Library
{
	public class ToDoTaskUser
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; }
	}

}
