namespace DevExpress.MailClient.Win
{
	public class UnknownContact : Contact
	{
		public UnknownContact(string email)
		{
			Email = email;
		}
		public override string ToString()
		{
			return Email;
		}
	}
}