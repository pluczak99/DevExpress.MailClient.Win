using System;

namespace DevExpress.MailClient.Win
{
	public class DataSourceChangedEventArgs : EventArgs
	{
		string caption;
		public DataSourceChangedEventArgs(object caption, object list, object type)
		{
			this.caption = string.Format("{0}", caption);
		}
	}
}
