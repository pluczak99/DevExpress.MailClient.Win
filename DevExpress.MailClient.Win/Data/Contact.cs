using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.DevAV;
using DevExpress.Utils.Svg;

namespace DevExpress.MailClient.Win
{
	public class Contact : IComparable
	{
		Image photo;
		FullName name;
		string email, phone, note, fullname;
		DateTime? birthDate;
		Address address;
		public Contact()
		{
			name = new FullName(PersonPrefix.Mr, Properties.Resources.NewFirstName, string.Empty, Properties.Resources.NewLastName);
			address = new Address();
		}
		public Contact(Contact contact)
		{
			name = new FullName();
			address = new Address();
			this.Assign(contact);
		}
		public Contact(Employee employee)
		{
			photo = employee.Photo;
			name = new FullName(employee.Prefix, employee.FirstName, string.Empty, employee.LastName);
			fullname = employee.FullName;
			email = employee.Email;
			birthDate = employee.BirthDate;
			phone = employee.MobilePhone;
			address = new Address(employee.Address.ToString());
		}
		public string Name { get { return name.ToString(); } }
		public string EmployeeName { get { return fullname; } }
		public string FirstName { get { return name.FirstName; } }
		public string MiddleName { get { return name.MiddleName; } }
		public string LastName { get { return name.LastName; } }
		public string Email { get { return email; } set { email = value; } }
		public DateTime? BirthDate { get { return birthDate; } }
		readonly DateTime DefaultBirthDate = new DateTime(1970, 1, 1);
		public DateTime BindingBirthDate
		{
			get
			{
				if (BirthDate.HasValue)
					return BirthDate.Value;
				return DefaultBirthDate;
			}
			set
			{
				birthDate = value;
			}
		}
		public PersonPrefix Title { get { return name.Title; } }
		public string Phone { get { return phone; } set { phone = value; } }
		public string State { get { return address.State; } }
		public string City { get { return address.City; } }
		public string Zip { get { return address.Zip; } }
		public string AddressLine { get { return address.AddressLine; } }
		public Address Address { get { return address; } }
		public FullName FullName { get { return name; } }
		public Image Photo { get { return photo; } set { photo = value; } }
		public string Note { get { return note; } set { note = value; } }
		public string GetContactInfoHtml()
		{
			string ret = string.Format("<size=+2><b>{0}</b><size=-2>", Name);
			ret += "<br>";
			if (BirthDate != null && BirthDate != DateTime.MinValue) ret += string.Format(Properties.Resources.BirthDateHtml, BirthDate);
			if (!string.IsNullOrEmpty(Email)) ret += string.Format(Properties.Resources.EmailHtml, Email);
			if (!string.IsNullOrEmpty(Phone)) ret += string.Format(Properties.Resources.PhoneHtml, Phone);
			ret += string.Format(Properties.Resources.AddressHtml, Address);

			return ret;
		}
		public override string ToString() { return Name; }
		public SvgImage Icon
		{
			get
			{
				switch (name.Title)
				{
					case PersonPrefix.Dr:
						return Properties.Resources.Doctor1;
					case PersonPrefix.Ms:
						return Properties.Resources.Ms1;
					case PersonPrefix.Miss:
						return Properties.Resources.Miss1;
					case PersonPrefix.Mrs:
						return Properties.Resources.Mrs1;
				}
				return Properties.Resources.Mr1;
			}
		}
		public void Assign(Contact contact)
		{
			this.photo = contact.Photo;
			this.name.Assign(contact.FullName);
			this.address.Assign(contact.Address);
			this.email = contact.Email;
			this.birthDate = contact.BirthDate;
			this.phone = contact.Phone;
			this.note = contact.Note;
		}
		public Contact Clone()
		{
			return new Contact(this);
		}
		#region IComparable Members

		public int CompareTo(object obj)
		{
			return Comparer<string>.Default.Compare(Name, obj.ToString());
		}

		#endregion
	}
}