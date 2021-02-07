using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.MailClient.Win.Localizer
{

	public class PolishNavBarLocalizer : NavBarLocalizer
	{
		public override string GetLocalizedString(NavBarStringId id)
		{
			switch (id)
			{
				case NavBarStringId.NavPaneMenuShowFewerButtons:
					return "Pokaż mniej przycisków";
				case NavBarStringId.NavPaneOptionsFormDescription:
					return "Opcje formularza";
				case NavBarStringId.NavPaneMenuShowMoreButtons:
					return "Pokaż więcej przycisków";
				case NavBarStringId.NavPaneMenuAddRemoveButtons:
					return "Dodaj lub usuń przyciski";
				case NavBarStringId.NavPaneChevronHint:
					return "Rozwiń";
				case NavBarStringId.NavPaneMenuPaneOptions:
					return "Na&wigacja";
				case NavBarStringId.NavPaneOptionsFormMoveUp:
					return "Przesuń do góry";
				case NavBarStringId.NavPaneOptionsFormMoveDown:
					return "Przesuń do dołu";
				case NavBarStringId.NavPaneOptionsFormFont:
					return "Czcionka";
				case NavBarStringId.NavPaneOptionsFormReset:
					return "Przywróć ustawienia domyślne";
				case NavBarStringId.NavPaneOptionsFormOk:
					return "OK";
				case NavBarStringId.NavPaneOptionsFormCancel:
					return "Anuluj";
				default:
					return base.GetLocalizedString(id);
			}
		}
	}
}
