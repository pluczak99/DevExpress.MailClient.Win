using System.Collections.Generic;
using System.Drawing;
using DevExpress.Utils.Drawing;

namespace DevExpress.MailClient.Win
{
	public class ImageHelper {
        static Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
        public static Bitmap GetScaleImage(Image image, Size size) {
            return new Bitmap(image, size.Width, size.Height);
        }
        public static string GetFaviconIconPath(string link) {
            link = ObjectHelper.GetCorrectUrl(link);
            string[] links = link.Split('/');
            if(links.Length > 1)
                return string.Format("http://{0}/favicon.ico", links[2]);
            return null;
        }
        public static Bitmap CreateSenderImage(string sender, Size size, DevExpress.LookAndFeel.UserLookAndFeel ulf) {
            if(images.ContainsKey(sender)) return images[sender]; 
            Size imageSize = new System.Drawing.Size(size.Width, size.Height);
            string[] parsedText = sender.Split(' ');
            string result = string.Empty;
            int count = 0;
            for(int i = 0; i < parsedText.Length; i++) {
                if(parsedText[i].Length > 0) {
                    result += parsedText[i][0];
                    count++;
                    if(count == 2) break;
                }
            }
            images.Add(sender, GlyphPainter.CreateRoundedStubGlyph(ulf, imageSize, result));
            return images[sender];
        }
    }
}
