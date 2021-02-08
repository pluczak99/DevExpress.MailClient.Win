using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;

namespace DevExpress.MailClient.Win
{
	public class ObjectHelper {
        static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainTextFromMHT(string mhtText) {
            rich.MhtText = mhtText;
            return rich.Text.TrimStart();
        }
        public static string GetMHTTextFromHTML(string htmlText) {
            rich.HtmlText = htmlText;
            return rich.MhtText;
        }
        public static void ShowWebSite(string url) {
            if(url == null) return;
            string processName = GetCorrectUrl(url);
            if(processName.Length == 0) return;
            StartProcess(processName);
        }
        public static string GetCorrectUrl(string url) {
            string ret = url.Replace(" ", string.Empty);
            if(ret.Length == 0) return string.Empty;
            const string protocol = "http://";
            const string protocol2 = "https://";
            if(ret.IndexOf(protocol) != 0 && ret.IndexOf(protocol2) != 0)
                ret = protocol + ret;
            return ret;
        }
        public static void StartProcess(string processName) {
            if(Data.Utils.SafeProcess.Start(processName) == null)
                XtraMessageBox.Show("", Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
