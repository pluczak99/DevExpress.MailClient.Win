using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Localization;
using DevExpress.Utils.Localization;
using DevExpress.MailClient.Win.Localizer;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraNavBar;

namespace DevExpress.MailClient.Win
{
	public partial class LanguageSelectorFormExt : XtraForm
	{
		private Brush DropdownBrush { get; set; }
		private Color DropdownBackColor { get; set; }

		private Color DropdownFontColor { get; set; }

		public static string Locale { get; private set; }
		public static CultureInfo CultureInfo { get; private set; }
		public LanguageSelectorFormExt()
		{
			InitializeComponent();
		}

		// setting selected locale for threads and UI
		public static void SetSelectedUILocale()
		{
			LanguageSelectorFormExt.CultureInfo = new CultureInfo(Locale);
			SetCulture(Locale);
		}

		// setting selected locale for specific form and all its controls
		public static void SetSelectedUILocale(Form form)
		{
			SetCulture(Locale);
			
			if (form != null)
			{
				ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
				try
				{

					foreach (var control in form.ListAllControls())
					{ 
						resources.ApplyResources(control, control.Name, CultureInfo);
					}
				}
				catch (Exception exc)
				{
					Debug.WriteLine($"Exception: {exc.GetType().FullName}, Message: {exc.Message}");
				}

			}
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			string locale = "";
			switch (dropdownLanguages.SelectedItem.ToString().ToLowerInvariant())
			{
				case "polish":
					Locale = "pl";
					break;
				default:
					Locale = "en";
					break;
			}
			this.DialogResult = DialogResult.OK;
		}

		private static void SetCulture(string name)
		{
			if (!string.IsNullOrEmpty(name))
			{
				System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo;
				System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo;
				Properties.Resources.Culture = CultureInfo;

				#region DevExpress localization internals
				GridLocalizer.Active = GetActiveGridLocalizer(name);
				XtraEditors.Controls.Localizer.Active = GetActiveEditorLocalizer(name);
				SchedulerLocalizer.Active = GetActiveSchedulerLocalizer(name);
				SchedulerExtensionsLocalizer.Active = GetActiveSchedulerExtensionsLocalizer(name);
				BarLocalizer.Active = GetActiveBarLocalizer(name);
				NavBarLocalizer.Active = GetActiveNavBarLocalizer(name);
				#endregion
			}
		}

		private void LanguageSelectorFormExt_Load(object sender, EventArgs e)
		{
			dropdownLanguages.Items.Add("Polish");
			dropdownLanguages.Items.Add("English");
			dropdownLanguages.SelectedIndex = 0;
			this.ActiveControl = dropdownLanguages;
		}

		#region Handling DevExpress localizers depending on selected UI language
		private static XtraLocalizer<SchedulerExtensionsStringId> GetActiveSchedulerExtensionsLocalizer(string name)
		{
			switch (name)
			{
				case "pl":
					return new PolishSchedulerExtensionLocalizer();
				default:
					return SchedulerExtensionsLocalizer.Active;
			}
		}

		private static XtraLocalizer<NavBarStringId> GetActiveNavBarLocalizer(string name)
		{
			switch (name)
			{
				case "pl":
					return new PolishNavBarLocalizer();
				default:
					return NavBarLocalizer.Active;
			}
		}

		private static BarLocalizer GetActiveBarLocalizer(string name)
		{
			switch (name)
			{
				case "pl":
					return new PolishBarLocalizer();
				default:
					return BarLocalizer.Active;
			}
		}

		private static XtraLocalizer<SchedulerStringId> GetActiveSchedulerLocalizer(string name)
		{
			switch (name)
			{
				case "pl":
					return new PolishSchedulerLocalizer();
				default:
					return SchedulerLocalizer.Active;
			}
		}

		private static XtraLocalizer<StringId> GetActiveEditorLocalizer(string name)
		{
			switch (name)
			{
				case "pl":
					return new PolishEditorLocalizer();
				default:
					return XtraEditors.Controls.Localizer.Active;
			}
		}

		private static XtraLocalizer<GridStringId> GetActiveGridLocalizer(string name)
		{
			switch (name)
			{
				case "pl":
					return new PolishGridLocalizer();
				default:
					return GridLocalizer.Active;
			}
		}
		#endregion

		#region Handling keyboard while selecting UI language
		private void dropdownLanguages_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressEventArgs args = new KeyPressEventArgs(e.KeyChar);
			switch (args.KeyChar)
			{
				case '\r':
				case ' ':
					args.KeyChar = '\r';
					this.btnOK_Click(this.btnOK, args);
					break;
			}
		}

		private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '\r':
				case ' ':
					this.btnOK_Click(sender, new KeyPressEventArgs('\r'));
					break;
			}
		}
		#endregion
	}
}
