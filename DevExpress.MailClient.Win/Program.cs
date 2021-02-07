using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.Skins;
using DevExpress.Data.Filtering;
using DevExpress.MailClient.Win.Forms;
using System.Drawing;
using System.Threading;
using DevExpress.XtraEditors;
using System.Reflection;
using System.IO;
using DevExpress.Tutorials;

namespace DevExpress.MailClient.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments) {
            AppDomain.CurrentDomain.AssemblyResolve += OnCurrentDomainAssemblyResolve;
            DataHelper.ApplicationArguments = arguments;
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            SkinManager.EnableFormSkins();
            EnumProcessingHelper.RegisterEnum<TaskStatus>();
            UnpackHelper.Unpack();
            //SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LanguageSelectorForm.SetCulture("pl");
            DialogResult result = new LanguageSelectorFormExt().ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
			}
			Application.Run(new frmMain());
        }
        static Assembly OnCurrentDomainAssemblyResolve(object sender, ResolveEventArgs args) {
            string partialName = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower();
            if(partialName == "entityframework" || partialName == "system.data.sqlite" || partialName == "system.data.sqlite.ef6") {
                string path = FilePathUtils.FindFilePath("Dll\\" + partialName + ".dll", false);
                return Assembly.LoadFrom(path);
            }
            return null;
        }
    }
}
