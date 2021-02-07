using System;
using System.ComponentModel;
using System.Data;

namespace DevExpress.MailClient.Win
{
	public class Message : INotifyPropertyChanged
	{
		DataRow row;
		DateTime date;
		bool read, deleted, hasAttachment;
		int priority = 1;
		MailType mailType;
		int mailFolder;
		string from = String.Empty, subject = String.Empty, text = String.Empty, plainText = string.Empty, email = String.Empty;

		public Message()
		{
			date = DateTime.Now;
		}
		public Message(DataRow row)
		{
			this.row = row;
			date = DateTime.Now.AddDays((int)row["Day"]).AddSeconds(-new Random().Next(10000));
			email = string.Format("{0}", row["From"]);
			from = DataHelper.GetNameByEmail(email);
			subject = string.Format("{0}", row["Subject"]);
			read = Delay > TimeSpan.FromHours(48);
			text = string.Format("{0}", row["Text"]);
			deleted = false;
			mailType = MailType.Inbox;
			mailFolder = (int)GetFolder(row);
			plainText = GetPlainText();
			DataTweaking();
		}
		public string FullName
		{
			get
			{
				if (string.IsNullOrEmpty(email)) return from;
				return string.Format("{0} ({1})", from, email);
			}
		}
		public DateTime Date { get { return date; } set { date = value; } }
		public string From { get { return from; } set { from = value; } }
		public string Email { get { return email; } set { email = value; } }
		public string Subject { get { return subject; } set { subject = value; } }
		public string SubjectDisplayText { get { return Subject; } }
		public int Attachment { get { return hasAttachment ? 1 : 0; } }
		public int Read { get { return read ? 1 : 0; } }
		public int Priority { get { return priority; } set { priority = value; } }
		public bool IsUnread { get { return !read; } }
		internal string Folder { get { return string.Format("{0}", mailFolder); } }
		public string Text { get { return text; } set { text = value; } }
		public string PlainText { get { return GetPlainText(); } }

		string GetPlainText()
		{
			if (string.IsNullOrEmpty(plainText))
			{
				plainText = ObjectHelper.GetPlainTextFromMHT(text).Replace("\r\n", " ");
			}
			return plainText;
		}
		public MailType MailType { get { return mailType; } set { mailType = value; } }
		public int MailFolder
		{
			get { return mailFolder; }
			set
			{
				if (MailFolder == value) return;
				mailFolder = value;
				OnPropertyChanged("MailFolder");
			}
		}
		public bool Deleted
		{
			get { return deleted; }
			set { deleted = value; }
		}
		internal TimeSpan Delay { get { return DateTime.Now - date; } }

		public void ToggleRead()
		{
			read = !read;
		}
		void DataTweaking()
		{
			if (Delay > TimeSpan.FromHours(50) && Delay < TimeSpan.FromHours(100)) read = false;
			if (subject.IndexOf("RE:") >= 0 || subject.IndexOf("FW:") >= 0) read = false;
			this.hasAttachment = text.Length > 20000;
			if (subject.IndexOf("Review") >= 0 || subject.IndexOf("Important") >= 0) priority = 2;
			if (subject.IndexOf("FW:") >= 0 && Delay > TimeSpan.FromHours(48)) priority = 0;
			if (subject.IndexOf("New") >= 0 || subject.IndexOf("Meeting") >= 0)
				mailFolder += 1;
		}
		MailFolder GetFolder(DataRow row)
		{
			object category = row["CategoryID"];
			string ret = string.Format("{0}", (Categories)(category == DBNull.Value ? 1 : (int)category));
			if (string.IsNullOrEmpty(ret)) return DevExpress.MailClient.Win.MailFolder.All;
			return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
		}
		public void SetPlainText(string text) { plainText = text; }

		#region INotifyPropertyChanged Members
		PropertyChangedEventHandler propertyChanged;
		event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
		{
			add { propertyChanged += value; }
			remove { propertyChanged -= value; }
		}
		protected void OnPropertyChanged(string name)
		{
			if (propertyChanged != null) propertyChanged(this, new PropertyChangedEventArgs(name));
		}
		#endregion
	}
}