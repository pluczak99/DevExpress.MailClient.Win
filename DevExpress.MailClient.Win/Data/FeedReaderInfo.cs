using System.ServiceModel.Syndication;
using System.Xml;

namespace DevExpress.MailClient.Win
{
	public class FeedReaderInfo
	{
		XmlReader reader;
		SyndicationFeed result;
		public FeedReaderInfo(XmlReader reader)
		{
			this.reader = reader;
		}
		public XmlReader Reader { get { return reader; } }
		public SyndicationFeed Feed
		{
			get { return result; }
			set { result = value; }
		}
	}
}