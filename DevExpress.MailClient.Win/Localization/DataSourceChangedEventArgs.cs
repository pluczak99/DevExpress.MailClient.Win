using System;

namespace DevExpress.MailClient.Win
{
	public class DataSourceChangedEventArgs : EventArgs
	{
		//List<Message> list;
		MailType type;
		string caption;
		public DataSourceChangedEventArgs(object caption, object list, object type)
		{
			//this.list = (List<Message>)list;
			this.type = (MailType)type;
			this.caption = string.Format("{0}", caption);
		}
		//public List<Message> List { get { return list; } }
		//public MailType Type { get { return type; } }
		//public string Caption { get { return caption; } }
	}
}
