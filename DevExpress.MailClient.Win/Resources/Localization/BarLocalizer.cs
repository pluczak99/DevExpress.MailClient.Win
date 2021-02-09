using DevExpress.XtraBars.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.MailClient.Win.Localizer
{

	public class PolishBarLocalizer : BarLocalizer
	{
		public override string GetLocalizedString(BarString id)
		{
			switch (id)
			{
				case BarString.NewMenuName:
					return "Główne menu";
				case BarString.SkinsBonus:
					return "Ekstra skiny";
				case BarString.RibbonCustomizationNewGroupDefaultAlias:
					return "Nowa grupa";
				case BarString.PopupMenuEditor:
					return "Edytor menu kontekstowego";
				case BarString.NewToolbarCaption:
					return "Nowy toolbar";
				case BarString.CustomizeQuickAccessToolbar:
					return "Skonfiguruj toolbar Quick Access";
				case BarString.RibbonTouchMouseModeCommandText:
					return "Tryb dotykowy/myszy";
				case BarString.RibbonToolbarBelow:
					return "Wyświetl toolbar Quick Access pod Ribbonem";
				case BarString.SkinsCustom:
					return "Customowe skiny";
				case BarString.RibbonMinimizedItemDescription:
					return "Zminimalizowane taby Ribbona";
				case BarString.NewStatusBarName:
					return "Pasek statusu";
				case BarString.RibbonCustomizationNewCategoryDefaultAlias:
					return "Nowa kategoria";
				case BarString.NewToolbarCustomNameFormat:
					return "Customowy {0}";
				case BarString.RibbonTouchMouseModeGalleryGroupText:
					return "Optymalizuj odstęp między poleceniami";
				case BarString.RibbonToolbarAdd:
					return "Dodaj do toolbara Quick Access";
				case BarString.AddOrRemove:
					return "Dodaj lub usuń przyciski";
				case BarString.CustomizeToolbarText:
					return "Konfiguruj toolbar";
				case BarString.RibbonExpandedItemCaption:
					return "Tryb pokazanych tabów i poleceń";
				case BarString.SkinCaptions:
					return "|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|Whiteprint|VS2010|Metropolis|Metropolis Dark|Office 2013|Office 2013 Gray|Office 2013 Dark|Office 2013 Dark|Office 2013 Light|Office 2013 Blue|Office 2013 Dark Gray|Office 2013 Light Gray|Office 2013 Colorful|Office 2016 Dark|Office 2016 Black|DevExpress Dark Style|DevExpress Style|Office 2019 Dark|Office 2019 Black|Office 2019 White|Office 2019 Colorful|The Bezier|Basic";
				case BarString.RenameToolbarCaption:
					return "Zmień nazwę toolbara";
				case BarString.RibbonTouchMouseModeTouchItemText:
					return "Dotyk";
				case BarString.CloseButton:
					return "Zamknij";
				case BarString.RibbonCustomizationNewCategoryCommand:
					return "Nowa kategoria";
				case BarString.Visible:
					return "Widoczne";
				case BarString.RibbonToolbarMinimizeRibbon:
					return "Minimalizuj Ribbon";
				case BarString.ShowScreenTipsOnToolbarsName:
					return "Pokazuj Screen Tips na toolbarach";
				case BarString.CustomizeWindowCaption:
					return "Konfiguracja";
				case BarString.CustomizeToolbarSuperTipText:
					return "Konfiguruj toolbar Quick Access";
				case BarString.RibbonExpandedItemDescription:
					return "Tryb wyświetlania tabów i poleceń";
				case BarString.RibbonCustomizationNewPageCommand:
					return "Nowy tab";
				case BarString.MinimizeButton:
					return "Minimalizuj";
				case BarString.RibbonTouchMouseModeMouseItemText:
					return "Mysz";
				case BarString.RibbonToolbarRemove:
					return "Usuń z toolbara Quick Access";
				case BarString.ShowShortcutKeysOnScreenTipsName:
					return "Pokazuj klawisze skrótów w Tool Tips";
				case BarString.ResetBar:
					return "Czy chcesz przywrócić ustawienia domyślne dla toolbara {0}?";
				case BarString.RibbonCustomizationOptionAllTabs:
					return "Wszystkie taby";
				case BarString.CustomizeButton:
					return "Konfiguruj...";
				case BarString.MenuAnimationSystem:
					return "(Ustawienie domyślne systemu)";
				case BarString.RibbonTouchMouseModeTouchItemDescription:
					return "Większy odstęp między poleceniami, zoptymalizowany dla interfejsu dotykowego";
				case BarString.RibbonGalleryFilter:
					return "Wszystkie grupy";
				case BarString.RibbonCustomizationNewGroupCommand:
					return "Nowa grupa";
				case BarString.MaximizeButton:
					return "Maksymalizuj";
				case BarString.ResetBarCaption:
					return "Konfiguruj";
				case BarString.ExpandRibbonSuperTipHeader:
					return "Rozszerz Ribbon (Ctrl + F1)";
				case BarString.MenuAnimationNone:
					return "Brak";
				case BarString.RibbonTouchMouseModeMouseItemDescription:
					return "Standardowy ribbon i polecenia, zoptymalizowany dla interfejsu myszy";
				case BarString.RibbonCustomizationOptionAllCommands:
					return "Wszystkie polecenia";
				case BarString.CancelButton:
					return "Anuluj";
				case BarString.RibbonCustomizationRenameText:
					return "Zmień nazwę";
				case BarString.RibbonGalleryFilterNone:
					return "Brak";
				case BarString.MenuAnimationFade:
					return "Gaśnięcie";
				case BarString.CollapseRibbonSuperTipHeader:
					return "Minimalizuj Ribbon (Ctrl + F1)";
				case BarString.RestoreButton:
					return "Przywróć";
				case BarString.ResetButton:
					return "Przywróć ustawienia domyślne toolbara";
				case BarString.RibbonCustomizationStandardCustomItemSuffix:
					return "Specjalne";
				case BarString.MenuAnimationSlide:
					return "Przesunięcie";
				case BarString.ColorAuto:
					return "Automatyczny";
				case BarString.BarUnassignedItems:
					return "(nieprzypisane elementy)";
				case BarString.ToolBarMenu:
					return "Zresetuj $ i usuń $! & $ Name! Domyślne drukarki i styl $ Tylko & tekst (zawsze) $ Tekst i tylko (w menu) $ Obraz & i tekst $! Rozpocznij & ostatnio używaną grupę $ i widoczną $ i więcej";
				case BarString.RibbonCustomizationRemoveText:
					return "Usuń";
				case BarString.HelpButton:
					return "Pomoc";
				case BarString.MenuAnimationUnfold:
					return "Odsłoń";
				case BarString.ExpandRibbonSuperTipText:
					return "Pokaż Ribbon tak, że pozostaje rozwinięty nawet po wybraniu z niego polecenia";
				case BarString.BarAllItems:
					return "Wszystkie elementy";
				case BarString.RibbonToolbarAbove:
					return "Pokaż toolbar Quick Access powyżej Ribbona";
				case BarString.RibbonCustomizationResetSelectedTabSettingsCommand:
					return "Przywróć ustawienia domyślne tylko wybranego taba w Ribbonie";
				case BarString.ToolbarNameCaption:
					return "Nazwa toolbara";
				case BarString.AccordionControlSearchBoxPromptText:
					return "Wpisz tu słowa kluczowe";
				case BarString.FullScreenButton:
					return "Automatycznie ukrywaj Ribbon";
				case BarString.MenuAnimationRandom:
					return "Losowo";
				case BarString.RibbonCustomizationAddText:
					return "Dodaj";
				case BarString.RibbonCustomizationResetSettingsCommand:
					return "Przywróć wszystkie ustawienia domyślne";
				case BarString.CollapseRibbonSuperTipText:
					return "Pokaż tylko nazwy tabów na Ribbonie";
				case BarString.RibbonUnassignedPages:
					return "(nieprzypisane strony)";
				case BarString.RibbonFullScreenItemCaption:
					return "Tryb automatycznego ukrywania Ribbona";
				case BarString.SkinsMain:
					return "Standardowe skiny";
				case BarString.RibbonCustomizationDownText:
					return "Przesuń w dół";
				case BarString.RibbonCustomizationImportSettingsCommand:
					return "Importuj plik z konfiguracją";
				case BarString.MoreCommands:
					return "Więcej poleceń";
				case BarString.RibbonFullScreenItemDescription:
					return "Tryb automatycznego ukrywania Ribbona";
				case BarString.RibbonAllPages:
					return "(wszystkie strony)";
				case BarString.SkinsOffice:
					return "Skiny Office";
				case BarString.RibbonCustomizationUpText:
					return "Przesuń w górę";
				case BarString.RibbonCustomizationExportSettingsCommand:
					return "Eksportuj konfigurację";
				case BarString.CustomizeRibbon:
					return "Konfiguruj Ribbona";
				case BarString.NewToolbarName:
					return "Narzędzia";
				case BarString.RibbonMinimizedItemCaption:
					return "Tryp pokazywania tabów";
				case BarString.SkinsTheme:
					return "Skiny tematyczne";
				case BarString.RibbonCaptionTextNone:
					return "Brak nazwy";
				case BarString.RibbonCustomizationNewTabDefaultAlias:
					return "Nowy tab";
				default:
					return base.GetLocalizedString(id);
			}
		}
	}
}
