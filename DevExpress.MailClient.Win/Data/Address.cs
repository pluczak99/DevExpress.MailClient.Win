namespace DevExpress.MailClient.Win
{
	public class Address
	{
		string address, city = string.Empty, state = string.Empty, zip;
		public Address() : this(string.Empty) { }
		public Address(string address, string city, string state, string zip)
		{
			this.address = address;
			this.city = city;
			this.state = state;
			this.zip = zip;
		}
		internal Address(string addressString)
		{
			if (string.IsNullOrEmpty(addressString)) return;
			try
			{
				string[] lines = addressString.Split(',');
				this.address = lines[0].Trim();
				this.city = lines[1].Trim();
				this.state = lines[2].Trim().Substring(0, 2);
				string temp = lines[2].Trim();
				this.zip = temp.Substring(3, temp.Length - 3);
			}
			catch { }
		}
		public string AddressLine { get { return address; } set { address = value; } }
		public string State { get { return state; } set { state = value; } }
		public string City { get { return city; } set { city = value; } }
		public string Zip { get { return zip; } set { zip = value; } }
		public override string ToString()
		{
			return string.Format("{0}{1}{2}{3}", GetFormatString(AddressLine), GetFormatString(City), GetFormatString(State), Zip);
		}
		string GetFormatString(string name)
		{
			if (string.IsNullOrEmpty(name)) return string.Empty;
			return string.Format("{0}, ", name);
		}
		public void Assign(Address address)
		{
			this.address = address.AddressLine;
			this.state = address.State;
			this.city = address.City;
			this.zip = address.Zip;
		}
	}
}