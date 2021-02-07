using System;

namespace DevExpress.MailClient.Win
{
	public class FeedItem
	{
		public FeedItem() { }
		public string ID { get; set; }
		public DateTime Date { get; set; }
		public string From { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
	}
}