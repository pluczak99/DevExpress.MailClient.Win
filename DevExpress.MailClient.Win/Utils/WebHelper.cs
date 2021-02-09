using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress.MailClient.Win.Utils
{
	public class WebHelper
	{
		private static Dictionary<string, string> dicWebLinks = new Dictionary<string, string>()
		{
			["LinkHelp"] = "https://github.com/pluczak99/DevExpress.MailClient.Win",
			["LinkGetSupport"] = "https://github.com/pluczak99/DevExpress.MailClient.Win",
			["LinkGetStarted"] = "https://www.devexpress.com/support/demos/#winforms"
		};

		public static void RunLinkFromKeyword(string keyword)
		{
			if (dicWebLinks.ContainsKey(keyword))
			{
				ObjectHelper.StartProcess(dicWebLinks[keyword]);
				return;
			}
		}
	}
}
