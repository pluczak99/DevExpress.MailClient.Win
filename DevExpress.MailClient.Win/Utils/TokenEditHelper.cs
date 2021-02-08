using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.Data.Helpers;
using System.Collections;
using DevExpress.XtraSpellChecker;
using System.IO;
using DevExpress.Utils.Zip;
using System.Globalization;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace DevExpress.MailClient.Win
{
	public class TokenEditHelper {
        public static void Initialize(TokenEdit tokenEdit) {
            //foreach(Contact contact in DataHelper.Contacts.OrderBy(p => p.EmployeeName)) {
            //    TokenEditToken item = new TokenEditToken(contact.EmployeeName, contact);
            //    tokenEdit.Properties.Tokens.Add(item);
            //}
        }
        public static IList<Contact> ParseFromField(string fromField) {
            BindingList<Contact> contactList = new BindingList<Contact>();
            if(string.IsNullOrEmpty(fromField)) return contactList;
            foreach(string from in SplitFromField(fromField)) {
                //Contact contact = DataHelper.FindByName(from);
                //if(contact == null) {
                //    contact = new UnknownContact(FormatEmail(from));
                //}
                //contactList.Add(contact);
            }
            return contactList;
        }
        public static string FormatContactList(IList<Contact> contactList) {
            return string.Join(", ", contactList);
        }
        public static bool ValidateEmail(string email) {
            return EmailRegex.IsMatch(email);
        }
        static IEnumerable<string> SplitFromField(string fromField) {
            string[] parts = fromField.Split(PossibleSeparators);
            for(int n = 0; n < parts.Length; n++) {
                yield return parts[n].Trim();
            }
        }
        static readonly char[] PossibleSeparators = new char[] { ',' };

        static string FormatEmail(string from) {
            if(ValidateEmail(from)) return from;
            return FormatEmailCore(from);
        }
        static string FormatEmailCore(string value) {
            StringBuilder builder = new StringBuilder(value);
            builder.Replace(" (", "_");
            builder.Replace(')', '_');
            builder.Replace(' ', '_');
            builder.Replace('-', '_');
            builder.Append("@dxmail.net");
            return builder.ToString();
        }
        static Regex EmailRegex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled);
    }
}
