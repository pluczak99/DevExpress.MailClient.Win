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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments)
        {
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
            DialogResult result = new LanguageSelectorFormExt().ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
			LanguageSelectorFormExt.SetSelectedUILocale();
			Application.Run(new frmMain());
		}
    }
}
