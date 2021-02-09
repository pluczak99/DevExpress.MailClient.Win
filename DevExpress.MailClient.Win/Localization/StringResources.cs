using System.Reflection;

namespace DevExpress.MailClient.Win
{
	public class StringResources
	{
		public static string Get(string name)
		{
			return GetDefault(name);
		}
		static string GetDefault(string name)
		{
			FieldInfo fi = typeof(StringResourcesEn).GetField(name);
			return string.Format("{0}", fi.GetValue(null));
		}
		static string GetMailTypeString(MailType type)
		{
			switch (type)
			{
				case MailType.Deleted: return Properties.Resources.DeletedItems;
				case MailType.Draft: return Properties.Resources.Drafts;
				case MailType.Sent: return Properties.Resources.SentItems;
			}
			return Properties.Resources.Inbox;
		}
		public static string GetSearchPrompt(MailType type)
		{
			return string.Format(Properties.Resources.SearchString, GetMailTypeString(type));
		}
		public static string GetMessagesString(int count)
		{
			if (count == 1) return Properties.Resources.Message;
			return Properties.Resources.Messages;
		}
	}
}
