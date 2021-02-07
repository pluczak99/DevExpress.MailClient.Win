using DevExpress.DevAV;

namespace DevExpress.MailClient.Win
{
	public class FullName
	{
		PersonPrefix title;
		string first, middle, last;
		public FullName() : this(PersonPrefix.Mr, string.Empty, string.Empty, string.Empty) { }
		public FullName(PersonPrefix title, string first, string middle, string last)
		{
			this.title = title;
			this.first = first;
			this.middle = middle;
			this.last = last;
		}
		public PersonPrefix Title { get { return title; } set { title = value; } }
		public string FirstName { get { return first; } set { first = value; } }
		public string MiddleName { get { return middle; } set { middle = value; } }
		public string LastName { get { return last; } set { last = value; } }
		public override string ToString()
		{
			return string.Format("{1}{2}{3}", GetFormatString(EditorHelper.GetTitleNameByContactTitle(Title)),
				GetFormatString(FirstName), GetFormatString(MiddleName), LastName);
		}
		string GetFormatString(string name)
		{
			if (string.IsNullOrEmpty(name)) return string.Empty;
			return string.Format("{0} ", name);
		}
		public void Assign(FullName name)
		{
			this.title = name.Title;
			this.first = name.FirstName;
			this.middle = name.MiddleName;
			this.last = name.LastName;
		}
	}
}