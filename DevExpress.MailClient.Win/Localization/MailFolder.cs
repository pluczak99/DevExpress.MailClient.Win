using System;

namespace DevExpress.MailClient.Win
{
	[Flags]
	public enum MailFolder { All = 0, Announcements = 1, General = 2, Management = 4, IT = 8, Sales = 16, Support = 32, Engineering = 64, Deleted = 128, Custom = 1024 };
}
