using System;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.MailClient.Win


{
	public static class ControlExtensions
	{
		private static void ListAllControls(this System.Windows.Forms.Control parent, ref List<System.Windows.Forms.Control> mainList)
		{
			foreach (System.Windows.Forms.Control control in parent.Controls)
			{
				mainList.Add(control);
				if (control.Controls != null && control.Controls.Count > 0)
				{
					control.ListAllControls(ref mainList);
				}
			}
		}
		public static List<Control> ListAllControls (this Form form)
		{
			List<System.Windows.Forms.Control> controls = new List<System.Windows.Forms.Control>();
			form.ListAllControls(ref controls);
			return controls;
		}

		private static string GetStringProperty( Control control, string propertyName )
		{
			try
			{
				PropertyInfo pi = control.GetType().GetProperty(propertyName);
				if (pi != null)
				{
					return pi.GetValue(control).ToString();
				}
			}
			catch (Exception exc)
			{
				Debug.WriteLine($"Exception: {exc.GetType().FullName}, Message: {exc.Message}");
			}
			return null;

		}

		public static void SetStringProperty ( this Control control, string propertyName, string value )
		{
			try
			{
				PropertyInfo pi = control.GetType().GetProperty(propertyName);
				if (pi != null)
				{
					pi.SetValue(control, value);
				}
			}
			catch (Exception exc)
			{
				Debug.WriteLine($"Exception: {exc.GetType().FullName}, Message: {exc.Message}");
			}
		}

		private static string GetTextProperties ( Control control )
		{
			StringBuilder sb = new StringBuilder();
			sb.Append($"{control.GetType().ToString()}, ");
			var name = GetStringProperty(control, "Name");
			sb.Append($"Name: {(string.IsNullOrEmpty(name) ? "(none)" : name)}, ");
			var caption = GetStringProperty(control, "Caption");
			sb.Append($"Caption: '{(string.IsNullOrEmpty(caption) ? "(none)" : caption)}', ");
			var text = GetStringProperty(control, "Text");
			sb.Append($"Text: '{(string.IsNullOrEmpty(text) ? "(none)" : text)}', ");
			var description = GetStringProperty(control, "Description");
			sb.Append($"Description: '{(string.IsNullOrEmpty(description) ? "(none)" : description)}'");
			return sb.ToString();
		}

		public static List<string> DescribeControls (this Form form)
		{
			List<System.Windows.Forms.Control> controls = new List<System.Windows.Forms.Control>();
			form.ListAllControls(ref controls);
			List<string> descriptions = new List<string>();
			foreach (var control in controls)
			{
				string desc = GetTextProperties(control);
				descriptions.Add(desc);
			}
			return descriptions;
		}
	}

}
