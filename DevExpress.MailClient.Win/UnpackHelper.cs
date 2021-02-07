using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.MailClient.Win {
    internal static class UnpackHelper {
        static string Polish = "pl";
        static string PolishResource = ".pl.";
        internal static void Unpack(){
            try {
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                DirectoryInfo startPath = new DirectoryInfo(Application.StartupPath);
                if(!Directory.Exists(Path.Combine(startPath.ToString(), Polish))) Directory.CreateDirectory(Path.Combine(startPath.ToString(), Polish));
                string[] resources = executingAssembly.GetManifestResourceNames();
                foreach(string resource in resources) {
                    if(!resource.EndsWith("resources.dll")) continue;
                    CreateResourceIfNeed(executingAssembly, startPath, resource, PolishResource, Polish);
                }
            } catch { }
        }

        static void CreateResourceIfNeed(Assembly executingAssembly, DirectoryInfo startPath, string resource, string resourcePrefix , string resourceLanguagePrefix) {
            if(resource.Contains(resourcePrefix)) {
                string fileName = resource.Remove(0, resource.LastIndexOf(resourcePrefix) + resourcePrefix.Length);
                using(FileStream fs = new FileStream(Path.Combine(startPath.ToString(), resourceLanguagePrefix) + "\\" + fileName, FileMode.OpenOrCreate)) {
                    executingAssembly.GetManifestResourceStream(resource).CopyTo(fs);
                }
            }
        }
    }
}
