using System;

namespace DevExpress.MailClient.Win
{
	public class NavBarGroupTagObject
	{
		string name;
		Type moduleType;
		BaseModule module;
		public NavBarGroupTagObject(string name, Type moduleType)
		{
			this.name = name;
			this.moduleType = moduleType;
			module = null;
		}
		public string Name { get { return name; } }
		public Type ModuleType { get { return moduleType; } }
		public BaseModule Module
		{
			get { return module; }
			set { module = value; }
		}

	}
}
