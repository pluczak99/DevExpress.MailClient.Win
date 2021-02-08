using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.Skins;

namespace DevExpress.MailClient.Win
{
	public class NavPanePanel : BaseControl
	{
		NavPaneState state = NavPaneState.Collapsed;
		public NavPaneState State
		{
			get { return state; }
			set
			{
				state = value;
				RefreshBackColor();
			}
		}
		protected override void LookAndFeelStyleChanged()
		{
			base.LookAndFeelStyleChanged();
			RefreshBackColor();
		}
		public void RefreshBackColor()
		{
			this.BackColor = new SkinElementInfo(CommonSkins.GetSkin(this.LookAndFeel)[CommonSkins.SkinTextBorder]).Element.Border.GetBottom();
			Padding = new Padding(BorderByState(state), 1, 1, IsOfficeStyle ? BorderByState(state) : 1);
		}
		static int BorderByState(NavPaneState state)
		{
			return state == NavPaneState.Collapsed ? 0 : 1;
		}
		bool IsOfficeStyle
		{
			get
			{
				return this.LookAndFeel.ActiveSkinName.IndexOf("Office") > -1;
			}
		}
	}
}
