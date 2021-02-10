using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

		// setting selected locale for specific form and all its controls
		public static void SetSelectedUILocale(Form form)
		{
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
					Locale = "pl-PL";
					break;
				default:
					Locale = "en-US";
					break;
			}
			LanguageSelectorFormExt.CultureInfo = new CultureInfo(Locale);
			SetCulture();
			this.DialogResult = DialogResult.OK;
		}

		public static void SetCulture()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo;
			Application.CurrentCulture = LanguageSelectorFormExt.CultureInfo;
			Properties.Resources.Culture = CultureInfo;

			#region DevExpress localization internals
			GridLocalizer.Active = GetActiveGridLocalizer(Locale);
			XtraEditors.Controls.Localizer.Active = GetActiveEditorLocalizer(Locale);
			SchedulerLocalizer.Active = GetActiveSchedulerLocalizer(Locale);
			SchedulerExtensionsLocalizer.Active = GetActiveSchedulerExtensionsLocalizer(Locale);
			BarLocalizer.Active = GetActiveBarLocalizer(Locale);
			NavBarLocalizer.Active = GetActiveNavBarLocalizer(Locale);
			#endregion
		}

		private void LanguageSelectorFormExt_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(ConfigurationManager.ConnectionStrings["DevExpress.MailClient.Win.Properties.Settings.DEVEXPRESSConnectionString"].ConnectionString))
			{
				try
				{
					using (var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DevExpress.MailClient.Win.Properties.Settings.DEVEXPRESSConnectionString"].ConnectionString))
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception exc)
						{
							MessageBox.Show("Database DEVEXPRESS probably cannot be connected to - make sure you created the DB and apply the SQL scripts to create Appointment and Resource tables per documentation");
						}
						finally
						{
							if (sqlConnection.State == ConnectionState.Open)
							{
								sqlConnection.Close();
							}
						}

					}
				}
				catch (Exception exc1)
				{
				}
			}
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
				case "pl-PL":
					return new PolishSchedulerExtensionLocalizer();
				default:
					return SchedulerExtensionsLocalizer.Active;
			}
		}

		private static XtraLocalizer<NavBarStringId> GetActiveNavBarLocalizer(string name)
		{
			switch (name)
			{
				case "pl-PL":
					return new PolishNavBarLocalizer();
				default:
					return NavBarLocalizer.Active;
			}
		}

		private static BarLocalizer GetActiveBarLocalizer(string name)
		{
			switch (name)
			{
				case "pl-PL":
					return new PolishBarLocalizer();
				default:
					return BarLocalizer.Active;
			}
		}

		private static XtraLocalizer<SchedulerStringId> GetActiveSchedulerLocalizer(string name)
		{
			switch (name)
			{
				case "pl-PL":
					return new PolishSchedulerLocalizer();
				default:
					return SchedulerLocalizer.Active;
			}
		}

		private static XtraLocalizer<StringId> GetActiveEditorLocalizer(string name)
		{
			switch (name)
			{
				case "pl-PL":
					return new PolishEditorLocalizer();
				default:
					return XtraEditors.Controls.Localizer.Active;
			}
		}

		private static XtraLocalizer<GridStringId> GetActiveGridLocalizer(string name)
		{
			switch (name)
			{
				case "pl-PL":
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
