using DevExpress.XtraScheduler.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.MailClient.Win.Localizer
{

	public class PolishSchedulerLocalizer : SchedulerLocalizer
	{
		public override string GetLocalizedString(SchedulerStringId id)
		{
			switch (id)
			{
				case SchedulerStringId.AppointmentLabel_Anniversary:
					return "Rocznica";
				case SchedulerStringId.Caption_WeekOfMonthLast:
					return "Ostatni tydzień miesiąca";
				case SchedulerStringId.TimeScaleDisplayName_Year:
					return "Rok";
				case SchedulerStringId.MenuCmd_20Minutes:
					return "& 20 minut";
				case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment:
					return "{0}: 1} krok";
				case SchedulerStringId.AppointmentLabel_PhoneCall:
					return "Rozmowa telefoniczna";
				case SchedulerStringId.MenuCmd_OpenAppointment:
					return "&Otwórz";
				case SchedulerStringId.Msg_InvalidDayCount:
					return "Nieprawidłowa liczba dni, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_MinutesShort1:
					return "m";
				case SchedulerStringId.Caption_MonthViewDescription:
					return "Przełącz na widok miesięczny (wielotygodniowy). Widok ułatwia wizualizację planów długoterminowych";
				case SchedulerStringId.DescCmd_OpenAppointment:
					return "Otwórz wybrane zadanie";
				case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence:
					return "Nieprawidłowy dzień tygodnia dla zadania cyklicznego. Tylko WeekDays.EveryDay, WeekDays.WeekendDays oraz WeekDays.WorkDays są dozwolone";
				case SchedulerStringId.Appointment_StartContinueText:
					return "Od {0}";
				case SchedulerStringId.MenuCmd_DeleteAppointment:
					return "Usuń";
				case SchedulerStringId.Msg_InvalidDayCountValue:
					return "Nieprawidłowa liczba dni, proszę podać dodatnią wartość";
				case SchedulerStringId.PrintCalendarDetailsControlDayPeriod:
					return "Dzień";
				case SchedulerStringId.Abbr_MinutesShort2:
					return "min";
				case SchedulerStringId.MenuCmd_PrintAppointment:
					return "Drukuj";
				case SchedulerStringId.Appointment_EndContinueText:
					return "Do {0}";
				case SchedulerStringId.MenuCmd_30Minutes:
					return "30 minut";
				case SchedulerStringId.Caption_TimelineViewDescription:
					return "Przełącz na linię czasu. Zadania są wyświetlane zależnie od czasu";
				case SchedulerStringId.DescCmd_DeleteAppointment:
					return "Usuń wybrane zadania";
				case SchedulerStringId.Msg_InvalidWeekCount:
					return "Nieprawidłowa liczba tygodni, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_Minute:
					return "minut(y)";
				case SchedulerStringId.Msg_InternalError:
					return "Błąd wewnętrzny!";
				case SchedulerStringId.MenuCmd_NewAppointment:
					return "Nowe zadanie";
				case SchedulerStringId.PrintCalendarDetailsControlWeekPeriod:
					return "Tydzień";
				case SchedulerStringId.Msg_InvalidEndDate:
					return "Data którą wprowadziłeś/wprowadziłaś jest wcześniejsza od daty początkowej";
				case SchedulerStringId.MenuCmd_EditSeries:
					return "Edytuj cykl";
				case SchedulerStringId.MenuCmd_60Minutes:
					return "60 minut";
				case SchedulerStringId.Msg_InvalidWeekCountValue:
					return "Nieprawidłowa liczba tygodni, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_Minutes:
					return "minut(y)";
				case SchedulerStringId.DescCmd_NewAppointment:
					return "Utwórz nowe zadanie";
				case SchedulerStringId.Caption_FullWeekViewDescription:
					return "Przełącz na widok pełnego tygodnia. Wyświetla zadania z całego tygodnia";
				case SchedulerStringId.Msg_XtraSchedulerNotAssigned:
					return "Komponent SchedulerStorage nie jest przypisany do ScheduleControl";
				case SchedulerStringId.Caption_Appointment:
					return "{0} - Zadanie";
				case SchedulerStringId.MenuCmd_RestoreOccurrence:
					return "Przywróć domyślny stan";
				case SchedulerStringId.Msg_InvalidMonthCount:
					return "Nieprawidłowa liczba miesięcy, proszę podać dodatnią wartość";
				case SchedulerStringId.PrintCalendarDetailsControlMonthPeriod:
					return "Miesiąc";
				case SchedulerStringId.Abbr_HoursShort:
					return "h";
				case SchedulerStringId.MenuCmd_NewAllDayEvent:
					return "Nowe całodniowe zadanie";
				case SchedulerStringId.Caption_Event:
					return "{0} - Zadanie";
				case SchedulerStringId.MenuCmd_SwitchViewMenu:
					return "Zmień widok na";
				case SchedulerStringId.Caption_GanttViewDescription:
					return "Przełącz na wykres Gantta. Widok dla menedżerów projektów, pokazujący zadania i ich zależności";
				case SchedulerStringId.DescCmd_NewRecurringAppointment:
					return "Utwórz nowe cykliczne zadanie";
				case SchedulerStringId.Msg_InvalidMonthCountValue:
					return "Nieprawidłowa liczba miesięcy, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_Hour:
					return "godzina";
				case SchedulerStringId.Msg_InvalidTimeOfDayInterval:
					return "Nieprawidłowy czas trwania dla TimeOfDayInterval";
				case SchedulerStringId.PrintMonthlyOptControlOnePagePerMonth:
					return "1 strona/miesiąc";
				case SchedulerStringId.MenuCmd_NewRecurringAppointment:
					return "Nowe cykliczne zadanie";
				case SchedulerStringId.Caption_UntitledAppointment:
					return "(bez tytułu)";
				case SchedulerStringId.MenuCmd_NewRecurringEvent:
					return "Nowe cykliczne zadanie";
				case SchedulerStringId.MenuCmd_SwitchToDayView:
					return "Widok dzienny";
				case SchedulerStringId.Msg_InvalidYearCount:
					return "Nieprawidłowa liczba lat, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_Hours:
					return "godzin(y)";
				case SchedulerStringId.Caption_AgendaViewDescription:
					return "Przełącz na widok agendy. Pokazuje listę nadchodzących zadań";
				case SchedulerStringId.DescCmd_GotoToday:
					return "Zmień datę na aktualny dzień";
				case SchedulerStringId.Msg_OverflowTimeOfDayInterval:
					return "Nieprawidłowa wartość dla TimeOfDayInterval. Powinna być nie większa niż 24 godziny";
				case SchedulerStringId.Caption_ReadOnly:
					return "(tryb odczytu)";
				case SchedulerStringId.MenuCmd_EditAppointmentDependency:
					return "Edytuj";
				case SchedulerStringId.PrintMonthlyOptControlTwoPagesPerMonth:
					return "2 strony/miesiąc";
				case SchedulerStringId.Msg_InvalidYearCountValue:
					return "Nieprawidłowa liczba lat, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_DaysShort:
					return "d";
				case SchedulerStringId.MenuCmd_GotoDate:
					return "Nawiguj do daty...";
				case SchedulerStringId.MenuCmd_SwitchToWorkWeekView:
					return "Widok tygodnia roboczego";
				case SchedulerStringId.Caption_WeekDaysEveryDay:
					return "Dzień";
				case SchedulerStringId.Caption_GroupByNoneDescription:
					return "Odgrupuj zadania";
				case SchedulerStringId.DescCmd_EditAppointmentDependency:
					return "Edytuj zależność zadania";
				case SchedulerStringId.Msg_InvalidOccurrencesCount:
					return "Nieprawidłowa liczba powtórzeń, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_Day:
					return "Dzień";
				case SchedulerStringId.Msg_LoadCollectionFromXml:
					return "Scheduler musi być w trybie unbound aby załadować dane z pliku XML";
				case SchedulerStringId.MenuCmd_OtherSettings:
					return "Inne ustawienia";
				case SchedulerStringId.Caption_WeekDaysWeekendDays:
					return "Dzień weekendu";
				case SchedulerStringId.MenuCmd_DeleteAppointmentDependency:
					return "Usuń";
				case SchedulerStringId.Msg_InvalidOccurrencesCountValue:
					return "Nieprawidłowa liczba powtórzeń, proszę podać dodatnią wartość";
				case SchedulerStringId.Abbr_Days:
					return "Dni";
				case SchedulerStringId.MenuCmd_CustomizeCurrentView:
					return "Konfiguruj aktualny widok...";
				case SchedulerStringId.MenuCmd_SwitchToMonthView:
					return "Widok miesięczny";
				case SchedulerStringId.PrintTimeIntervalControlInvalidDuration:
					return "Nieprawidłowy czas trwania. Powinien być nie większy niż 24 godziny i większy od 0";
				case SchedulerStringId.Caption_WeekDaysWorkDays:
					return "Dzień roboczy";
				case SchedulerStringId.DescCmd_DeleteAppointmentDependency:
					return "Usuń zależność zadania";
				case SchedulerStringId.Msg_InvalidDayNumber:
					return "Nieprawidłowy numer dnia, musi być między 1 i {0}";
				case SchedulerStringId.MenuCmd_SwitchToWeekView:
					return "Widok tygodniowy";
				case SchedulerStringId.Abbr_WeeksShort:
					return "tyg.";
				case SchedulerStringId.Abbr_Months:
					return "m-cy";
				case SchedulerStringId.MenuCmd_CustomizeTimeRuler:
					return "Konfiguruj podziałkę czasu";
				case SchedulerStringId.Caption_GroupByDateDescription:
					return "Grupuj zadania według daty";
				case SchedulerStringId.AppointmentLabel_None:
					return "Brak";
				case SchedulerStringId.Caption_WeekOfMonthFirst:
					return "Pierwszy";
				case SchedulerStringId.MenuCmd_GotoThisDay:
					return "Nawiguj do wybranej daty";
				case SchedulerStringId.Msg_InvalidDayNumberValue:
					return "Nieprawidłowy numer dnia, musi być między 1 i {0}";
				case SchedulerStringId.MenuCmd_SwitchToTimelineView:
					return "Widok osi czasu";
				case SchedulerStringId.Abbr_Week:
					return "tydzień/tygodnie";
				case SchedulerStringId.Abbr_Year:
					return "rok/lata";
				case SchedulerStringId.MenuCmd_5Minutes:
					return "5 minut";
				case SchedulerStringId.PrintTimeIntervalControlInvalidStartEndTime:
					return "Czas końcowy musi być później niż czas początkowy";
				case SchedulerStringId.MenuCmd_SwitchToAgendaView:
					return "Widok agendy";
				case SchedulerStringId.Caption_WeekOfMonthSecond:
					return "Sekunda";
				case SchedulerStringId.MenuCmd_GotoToday:
					return "Nawiguj do dnia dzisiejszego";
				case SchedulerStringId.Msg_WarningDayNumber:
					return "Niektóre miesiące mają mniej niż {0} dni. Dla tych miesięcy zadania cykliczne zaplanowane na koniec miesiąca nie odbędą się";
				case SchedulerStringId.Caption_GroupByResourceDescription:
					return "Grupuj zadania według zasobu";
				case SchedulerStringId.Abbr_Weeks:
					return "tydzień/tygodnie";
				case SchedulerStringId.Abbr_Years:
					return "lat";
				case SchedulerStringId.AppointmentLabel_Important:
					return "Ważne";
				case SchedulerStringId.MenuCmd_6Minutes:
					return "6 minut";
				case SchedulerStringId.MenuCmd_SwitchToFullWeekView:
					return "Widok pełnotygodniowy";
				case SchedulerStringId.Caption_WeekOfMonthThird:
					return "Trzeci";
				case SchedulerStringId.MenuCmd_15Minutes:
					return "15 minut";
				case SchedulerStringId.PrintTriFoldOptControlDailyCalendar:
					return "Kalendarz dzienny";
				case SchedulerStringId.Msg_InvalidDayOfWeek:
					return "Nie wybrano dnia tygodnia. Proszę wybrać co najmniej jeden dzień tygodnia";
				case SchedulerStringId.Abbr_Month:
					return "miesiąc";
				case SchedulerStringId.Caption_Reminder:
					return "Przypomnienie";
				case SchedulerStringId.MenuCmd_SwitchToGroupByNone:
					return "Usuń grupowanie";
				case SchedulerStringId.Msg_iCalendar_NotValidFile:
					return "Nieprawidłowy format pliku typu Internet Calendar";
				case SchedulerStringId.MenuCmd_10Minutes:
					return "10 minut";
				case SchedulerStringId.Caption_WeekOfMonthFourth:
					return "Czwarty";
				case SchedulerStringId.MenuCmd_TimeScaleYear:
					return "Rok";
				case SchedulerStringId.AppointmentLabel_Business:
					return "Business";
				case SchedulerStringId.Msg_WarningAppointmentDeleted:
					return "Zadanie zostało usunięte przez innego użytkownika";
				case SchedulerStringId.Format_TimeBeforeStart:
					return "{0} przed rozpoczęciem";
				case SchedulerStringId.MenuCmd_TimeScaleDay:
					return "Dzień";
				case SchedulerStringId.Caption_Reminders:
					return "Przypomnienia";
				case SchedulerStringId.PrintTriFoldOptControlWeeklyCalendar:
					return "Kalendarz tygodniowy";
				case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired:
					return "Wymagana podróż";
				case SchedulerStringId.Caption_Busy:
					return "Zajęty";
				case SchedulerStringId.MenuCmd_ShowTimeAs:
					return "Pokaż czas jako";
				case SchedulerStringId.MenuCmd_SwitchToGroupByResource:
					return "Grupuj według kategorii";
				case SchedulerStringId.ViewShortDisplayName_Timeline:
					return "Oś czasu";
				case SchedulerStringId.Msg_iCalendar_AppointmentsImportWarning:
					return "Błąd podczas importu zadania";
				case SchedulerStringId.Msg_Conflict:
					return "Edytowane zadania ma konflikt z jednym lub więcej istniejących zadań";
				case SchedulerStringId.Caption_StartTime:
					return "Początek: {0}";
				case SchedulerStringId.AppointmentLabel_Personal:
					return "Personalny";
				case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation:
					return "Wymaga przygotowania";
				case SchedulerStringId.MenuCmd_TimeScaleWeek:
					return "Tydzień";
				case SchedulerStringId.Caption_Tentative:
					return "Niezdecydowany";
				case SchedulerStringId.DescCmd_ShowTimeAs:
					return "Zmień status wybranego zadania";
				case SchedulerStringId.PrintTriFoldOptControlMonthlyCalendar:
					return "Kalendarz miesięczny";
				case SchedulerStringId.ViewShortDisplayName_FullWeek:
					return "Pełny tydzień";
				case SchedulerStringId.Msg_InvalidAppointmentDuration:
					return "Nieprawidłowa wartość długości zadania, proszę podać dodatnią wartość";
				case SchedulerStringId.MenuCmd_SwitchToGroupByDate:
					return "Grupuj według daty";
				case SchedulerStringId.Caption_NAppointmentsAreSelected:
					return "Wybrano {0} zadań";
				case SchedulerStringId.MenuCmd_NavigateBackward:
					return "Wstecz";
				case SchedulerStringId.MenuCmd_AppointmentLabelBirthday:
					return "Urodziny";
				case SchedulerStringId.Caption_WorkingElsewhere:
					return "Praca w innym miejscu";
				case SchedulerStringId.MenuCmd_Free:
					return "Wolny";
				case SchedulerStringId.Caption_FirstVisibleResources:
					return "Pierwszy";
				case SchedulerStringId.ViewShortDisplayName_Gantt:
					return "Gantt";
				case SchedulerStringId.AppointmentLabel_Vacation:
					return "Wakacje";
				case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart:
					return "Nieprawidłowa wartość przypomnienia o zadaniu przed jego rozpoczęciem, proszę podać dodatnią wartość";
				case SchedulerStringId.TextWeekly_2Day:
					return "{0} i {1}";
				case SchedulerStringId.MenuCmd_TimeScaleMonth:
					return "Miesiąc";
				case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary:
					return "Kopiuj";
				case SchedulerStringId.Caption_OutOfOffice:
					return "Poza biurem";
				case SchedulerStringId.MenuCmd_Busy:
					return "Zajęty";
				case SchedulerStringId.ViewShortDisplayName_Agenda:
					return "Agenda";
				case SchedulerStringId.PrintWeeklyOptControlOneWeekPerPage:
					return "1 strona/tydzień";
				case SchedulerStringId.TextDuration_FromTo:
					return "od {0} do {1}";
				case SchedulerStringId.TextWeekly_3Day:
					return "{0}, {1} i {2}";
				case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall:
					return "Rozmowa telefoniczna";
				case SchedulerStringId.ViewDisplayName_Day:
					return "Kalendarz dzienny";
				case SchedulerStringId.MenuCmd_Tentative:
					return "Niezdecydowany";
				case SchedulerStringId.MenuCmd_SwitchToGanttView:
					return "Wykres Gantta";
				case SchedulerStringId.MenuCmd_NavigateForward:
					return "Naprzód";
				case SchedulerStringId.TimeScaleDisplayName_Hour:
					return "Godzina";
				case SchedulerStringId.TextDuration_FromForDays:
					return "od {0} do {1}";
				case SchedulerStringId.MenuCmd_ViewZoomOut:
					return "Pomniejsz";
				case SchedulerStringId.Caption_PrevVisibleResourcesPage:
					return "Poprzednia strona";
				case SchedulerStringId.TextWeekly_4Day:
					return "{0}, {1}, {2} i {3}";
				case SchedulerStringId.MenuCmd_AppointmentMove:
					return "Przesuń";
				case SchedulerStringId.ViewDisplayName_WorkDays:
					return "Kalendarz tygodnia roboczego";
				case SchedulerStringId.AppointmentLabel_MustAttend:
					return "Obowiązkowy";
				case SchedulerStringId.MenuCmd_TimeScaleQuarter:
					return "Kwartał";
				case SchedulerStringId.MenuCmd_OutOfOffice:
					return "Poza biurem";
				case SchedulerStringId.TimeScaleDisplayName_Day:
					return "Dzień";
				case SchedulerStringId.TextDuration_FromForDaysHours:
					return "od {0} przez {1} {2}";
				case SchedulerStringId.PrintWeeklyOptControlTwoWeekPerPage:
					return "2 strony/tydzień";
				case SchedulerStringId.MenuCmd_TimeScalesMenu:
					return "Skala czasu";
				case SchedulerStringId.DescCmd_ViewZoomIn:
					return "Powiększ aby wyświetlić zawartość z większymi szczegółami";
				case SchedulerStringId.TextWeekly_5Day:
					return "{0}, {1}, {2}, {3} i {4}";
				case SchedulerStringId.MenuCmd_AppointmentCopy:
					return "Kopiuj";
				case SchedulerStringId.DescCmd_NavigateBackward:
					return "Confij kalendarz jak sugeruje aktualny widok";
				case SchedulerStringId.ViewDisplayName_Week:
					return "Kalendarz tygodniowy";
				case SchedulerStringId.MenuCmd_WorkingElsewhere:
					return "Praca w innym miejscu";
				case SchedulerStringId.TimeScaleDisplayName_Week:
					return "Tydzień";
				case SchedulerStringId.Caption_PrevVisibleResources:
					return "Poprzedni";
				case SchedulerStringId.AppointmentLabel_TravelRequired:
					return "Wymagana podróż";
				case SchedulerStringId.TextDuration_FromForDaysMinutes:
					return "od {0} przez {1} {3}";
				case SchedulerStringId.DescCmd_ViewZoomOut:
					return "Pomniejsz";
				case SchedulerStringId.TextWeekly_6Day:
					return "{0}, {1}, {2}, {3}, {4} i {5}";
				case SchedulerStringId.TextMonthlyPatternString_SubPattern:
					return "co każdy {0} {1} {2}";
				case SchedulerStringId.PrintPageSetupFormCaption:
					return "Brak zainstalowanych drukarek";
				case SchedulerStringId.MenuCmd_AppointmentCancel:
					return "Anuluj";
				case SchedulerStringId.ViewDisplayName_Month:
					return "Kalendarz miesięczny";
				case SchedulerStringId.MenuCmd_LabelAs:
					return "Ustaw etykietę";
				case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu:
					return "Opis osi czasu";
				case SchedulerStringId.TimeScaleDisplayName_Month:
					return "Miesiąc";
				case SchedulerStringId.TextDuration_FromForDaysHoursMinutes:
					return "od {0} przez {1} {2} {3}";
				case SchedulerStringId.DescCmd_NavigateForward:
					return "Przewiń kalendarz w przyszłość tak jak sugeruje aktualny widok";
				case SchedulerStringId.DescCmd_SplitAppointment:
					return "Podziel zadanie na 2 przez ciągnięcie splittera";
				case SchedulerStringId.Caption_PleaseSeeAbove:
					return "Jak wyżej";
				case SchedulerStringId.TextWeekly_7Day:
					return "{0}, {1}, {2}, {3}, {4}, {5} i {6}";
				case SchedulerStringId.Caption_5Minutes:
					return "5 minut";
				case SchedulerStringId.Caption_NextVisibleResources:
					return "Następny";
				case SchedulerStringId.ViewDisplayName_Timeline:
					return "Kalendarz osi czasu";
				case SchedulerStringId.AppointmentLabel_NeedsPreparation:
					return "Wymaga przygotowania";
				case SchedulerStringId.DescCmd_LabelAs:
					return "Zmień opis wybranego zadania";
				case SchedulerStringId.TimeScaleDisplayName_Quarter:
					return "Kwartał";
				case SchedulerStringId.TextMonthlyPatternString1:
					return "dzień {3} {0}";
				case SchedulerStringId.TextDuration_ForPattern:
					return "{0} {1}";
				case SchedulerStringId.Caption_SplitAppointment:
					return "Podziel";
				case SchedulerStringId.TextWeeklyPatternString_EveryWeek:
					return "co każdy {3} {0}";
				case SchedulerStringId.PrintMoreItemsMsg:
					return "Więcej elementów...";
				case SchedulerStringId.MenuCmd_TimeScaleHour:
					return "Godzina";
				case SchedulerStringId.Caption_6Minutes:
					return "6 minut";
				case SchedulerStringId.ViewDisplayName_FullWeek:
					return "Kalendarz całotygodniowy";
				case SchedulerStringId.MenuCmd_AppointmentLabelNone:
					return "Brak";
				case SchedulerStringId.MenuCmd_ViewZoomIn:
					return "Powiększ";
				case SchedulerStringId.Caption_RecurrenceStartTime:
					return "Początek: {0}";
				case SchedulerStringId.TextDailyPatternString_EveryDay:
					return "co każdy {1} {0}";
				case SchedulerStringId.VS_SchedulerReportsToolboxCategoryName:
					return "DX.{0} Scheduler Reporting";
				case SchedulerStringId.Caption_RecurrenceSubject:
					return "Lokalizacja";
				case SchedulerStringId.Caption_NextVisibleResourcesPage:
					return "Następna strona";
				case SchedulerStringId.TextWeeklyPatternString_EveryWeeks:
					return "co każdy {1} {2} w {3} {0}";
				case SchedulerStringId.Caption_10Minutes:
					return "10 minut";
				case SchedulerStringId.ViewDisplayName_Gantt:
					return "Wykres Gantta";
				case SchedulerStringId.AppointmentLabel_Birthday:
					return "Urodziny";
				case SchedulerStringId.MenuCmd_AppointmentLabelImportant:
					return "Ważne";
				case SchedulerStringId.TextMonthlyPatternString2:
					return "{1} {2} {0}";
				case SchedulerStringId.Caption_RecurrenceEndTime:
					return "Koniec:";
				case SchedulerStringId.TextDailyPatternString_EveryDays:
					return "co każdy {2} {1} {0}";
				case SchedulerStringId.PrintNoPrintersInstalled:
					return "Brak zainstalowanych drukarek";
				case SchedulerStringId.UD_SchedulerReportsToolboxCategoryName:
					return "Kontrolki schedulera";
				case SchedulerStringId.Caption_DecreaseVisibleResourcesCount:
					return "Zmniejsz widoczną liczbę zasobów";
				case SchedulerStringId.Caption_15Minutes:
					return "15 minut";
				case SchedulerStringId.Caption_ColorConverterBlackAndWhite:
					return "Czarnobiałe";
				case SchedulerStringId.Reporting_NotAssigned_TimeCells:
					return "Wymagana kontrolka TimeCells nie jest przypisana";
				case SchedulerStringId.ViewDisplayName_Agenda:
					return "Kalendarz agenda";
				case SchedulerStringId.MenuCmd_AppointmentLabelBusiness:
					return "Business";
				case SchedulerStringId.Caption_RecurrenceShowTimeAs:
					return "Pokaż czas jako";
				case SchedulerStringId.Caption_RecurrenceLocation:
					return "Lokalizacja";
				case SchedulerStringId.TextDailyPatternString_EveryWeekDay:
					return "co każdy dzień tygodnia {0}";
				case SchedulerStringId.Caption_LastVisibleResources:
					return "Ostatni";
				case SchedulerStringId.DescCmd_Print:
					return "Wyślij harmonogram bezpośrednio na drukarkę bez żadnych zmian";
				case SchedulerStringId.Caption_ShadingApplyToAllDayArea:
					return "Zakres całego dnia";
				case SchedulerStringId.Msg_InvalidInputFile:
					return "Plik wejściowy jest niepoprawny";
				case SchedulerStringId.Caption_20Minutes:
					return "20 minut";
				case SchedulerStringId.ViewShortDisplayName_Day:
					return "Dzień";
				case SchedulerStringId.MenuCmd_AppointmentLabelPersonal:
					return "Osobiste";
				case SchedulerStringId.TextYearlyPattern_YearString1:
					return "co każdy {3} {4} {0}";
				case SchedulerStringId.Caption_Recurrence:
					return "Cykliczność";
				case SchedulerStringId.TextDailyPatternString_EveryWeekend:
					return "co każdy {0} weekend";
				case SchedulerStringId.MenuCmd_PrintPageSetup:
					return "Ustawienia strony";
				case SchedulerStringId.Msg_MissingRequiredMapping:
					return "Wymagane mapowanie dla właściwości {0} nie istnieje";
				case SchedulerStringId.Caption_ResourceNone:
					return "Brak wybranego zasobu";
				case SchedulerStringId.Caption_ShadingApplyToAppointments:
					return "Zadania";
				case SchedulerStringId.Caption_30Minutes:
					return "30 minut";
				case SchedulerStringId.ViewShortDisplayName_WorkDays:
					return "Tydzień roboczy";
				case SchedulerStringId.Reporting_NotAssigned_View:
					return "Wymagany komponent widoku nie jest przypisany";
				case SchedulerStringId.MenuCmd_AppointmentLabelVacation:
					return "Wakacje";
				case SchedulerStringId.Caption_RecurrencePattern:
					return "Wzorzec cykliczności";
				case SchedulerStringId.Caption_SetupAppointmentStorage:
					return "Skonfiguruj pamięć masową dla zadania";
				case SchedulerStringId.TextWeekly_0Day:
					return "Dzień tygodnia nie jest wybrany";
				case SchedulerStringId.Caption_IncreaseVisibleResourcesCount:
					return "Zwiększ widoczną liczbę zasobów";
				case SchedulerStringId.DescCmd_PrintPageSetup:
					return "Skonfiguruj parametry wydruku i opcje";
				case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses:
					return "Statusy zadań";
				case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription:
					return "Zmodyfikuj pamięć masową zasobów";
				case SchedulerStringId.TextRecurrenceTypeDaily:
					return "Codziennie";
				case SchedulerStringId.TextYearlyPattern_YearString2:
					return "{5} {6} przez {3} {0}";
				case SchedulerStringId.Caption_60Minutes:
					return "60 minut";
				case SchedulerStringId.ViewShortDisplayName_Week:
					return "Tydzień";
				case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend:
					return "Obowiązkowy";
				case SchedulerStringId.Caption_NoneRecurrence:
					return "(Brak)";
				case SchedulerStringId.TextWeekly_1Day:
					return "{0}";
				case SchedulerStringId.DescCmd_TimeScalesMenu:
					return "Zmień skalę osi czasu";
				case SchedulerStringId.Caption_ResourceAll:
					return "(Wszystkie)";
				case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost:
					return "Wszystkie błędy związane z wybranym cyklicznym zadaniem zostaną zignorowane. Czy kontynuować?";
				case SchedulerStringId.Caption_ShadingApplyToHeaders:
					return "Nagłówki";
				case SchedulerStringId.MenuCmd_CellsAutoHeight:
					return "Automatyczna wysokość komórek";
				case SchedulerStringId.Caption_Free:
					return "Wolny";
				case SchedulerStringId.Caption_SetupResourceStorage:
					return "Skonfiguruj mapowania zasobów";
				case SchedulerStringId.ViewShortDisplayName_Month:
					return "Miesiąc";
				case SchedulerStringId.MenuCmd_ToggleRecurrence:
					return "Cykliczność";
				case SchedulerStringId.MemoPrintDateFormat:
					return "{0} {1} {2}";
				case SchedulerStringId.Caption_ModifyAppointmentDependencyStorageTransactionDescription:
					return "Zmodyfikuj pamięć masową dla zależności zadań";
				case SchedulerStringId.TextRecurrenceTypeWeekly:
					return "Co tydzień";
				case SchedulerStringId.DescCmd_OpenSeries:
					return "Otwórz zadanie cykliczne";
				case SchedulerStringId.MenuCmd_ShowWorkTimeOnly:
					return "Pokaż godziny robocze";
				case SchedulerStringId.Caption_ShadingApplyToTimeRulers:
					return "Reguły czasu";
				case SchedulerStringId.TextYearlyPattern_YearsString1:
					return "{3} {4} co każdy {1} {2} {0}";
				case SchedulerStringId.Msg_DuplicateMappingMember:
					return "Mapowanie {0} nie jest unikalne";
				case SchedulerStringId.PrintPageSetupFormatTabControlCustomizeShading:
					return "<Konfiguruj...>";
				case SchedulerStringId.DescCmd_CellsAutoHeight:
					return "Ustaw komórkę czasu tak aby automatycznie zmieniała swój rozmiar żeby się dopasować do zadań, które zawiera";
				case SchedulerStringId.DescCmd_ToggleRecurrence:
					return "Przekształć wybrane zadanie w cykliczne, lub edytuj wzorzec cykliczności";
				case SchedulerStringId.Caption_EmptyResource:
					return "(Dowolne)";
				case SchedulerStringId.DescCmd_CreateAppointmentDependency:
					return "Stwórz zależność między zadaniami";
				case SchedulerStringId.Caption_DayViewDescription:
					return "Przełącz kalendarz na widok dzienny. Najbardziej szczegółowy widok zadania jest dostępny w tym widoku";
				case SchedulerStringId.MenuCmd_DeleteOccurrence:
					return "Usuń cykliczność";
				case SchedulerStringId.Caption_SetupAppointmentDependencyStorage:
					return "Skonfiguruj pamięć masową dla zależności";
				case SchedulerStringId.DescCmd_ShowWorkTimeOnly:
					return "Pokaż tylko godziny robocze";
				case SchedulerStringId.Caption_ShadingApplyToCells:
					return "Komórki";
				case SchedulerStringId.TextRecurrenceTypeMonthly:
					return "Miesięcznie";
				case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI:
					return "Przypomnienie";
				case SchedulerStringId.Caption_DailyPrintStyle:
					return "Typ codzienny";
				case SchedulerStringId.TextYearlyPattern_YearsString2:
					return "co {5} {6} z {3} każdego {1} {2} [0}";
				case SchedulerStringId.Caption_WorkWeekViewDescription:
					return "Przełącz widok na kalendarz tygodnia roboczego. Pokazuje on szczegóły dni roboczych danego tygodnia.";
				case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping:
					return "Aby zastosować cykliczność zadania, konieczne jest zmapowanie zasobów i typu";
				case SchedulerStringId.PrintPageSetupFormatTabControlSizeAndFontName:
					return "{0} pt. {1}";
				case SchedulerStringId.DescCmd_DeleteOccurrence:
					return "Usuń cykliczność";
				case SchedulerStringId.MenuCmd_CreateAppointmentDependency:
					return "Utwórz zależność";
				case SchedulerStringId.MenuCmd_CompressWeekend:
					return "Kompresuj weekend";
				case SchedulerStringId.Msg_InvalidSize:
					return "Nieprawidłowa wartość podana jako rozmiar";
				case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription:
					return "Zmodyfikuj pamięć masową zadań";
				case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI:
					return "Wybierz kiedy przypomnieć o wyybranym zadaniu";
				case SchedulerStringId.Caption_WeeklyPrintStyle:
					return "Typ tygodniowy";
				case SchedulerStringId.TextRecurrenceTypeYearly:
					return "Rocznie";
				case SchedulerStringId.Caption_WeekViewDescription:
					return "Przełącz kalendarz na widok tygodniowy. Pokazuje on zadania dla konkretnego tygodnia w kompaktowej formie";
				case SchedulerStringId.Caption_AllDay:
					return "Całodniowy";
				case SchedulerStringId.MenuCmd_DeleteSeries:
					return "Usuń cykliczne zadanie";
				case SchedulerStringId.DescCmd_CompressWeekend:
					return "Pokaż sobotę i niedzielę jako jedną kolumnę";
				case SchedulerStringId.Msg_MappingsCheckPassedOk:
					return "Mapowania są poprawne";
				case SchedulerStringId.Msg_ApplyToAllStyles:
					return "Zastosuj aktualne ustawienia drukarki dla wszystkich typów wydruków";
				case SchedulerStringId.PrintRangeControlInvalidDate:
					return "Data końcowa musi być większa od daty początkowej lub równa";
				case SchedulerStringId.Caption_NoneReminder:
					return "Brak";
				case SchedulerStringId.Caption_MonthlyPrintStyle:
					return "Typ miesięczny";
				case SchedulerStringId.DescCmd_DeleteSeries:
					return "Utwórz zależność między zadaniami";
				case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart:
					return "Koniec-do-początku (F5)";
				case SchedulerStringId.Msg_MemoPrintNoSelectedItems:
					return "Nie można drukować jeżeli nie jest wybrany żadny element. Proszę wybrać element i spróbować jeszcze raz";
				case SchedulerStringId.TextRecurrenceTypeMinutely:
					return "Minutowo";
				case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth:
					return "Wybierz szeokość kolumny w pikselach do skali bazowej";
				case SchedulerStringId.Caption_TrifoldPrintStyle:
					return "Typ trojaki";
				case SchedulerStringId.Caption_SetupAppointmentMappings:
					return "Skonfiguruj mapowania zadań";
				case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart:
					return "Początek-do-początku (SS)";
				case SchedulerStringId.Msg_SaveBeforeClose:
					return "Czy chcesz zapisać zmiany?";
				case SchedulerStringId.Caption_AllResources:
					return "Wszystkie zasoby";
				case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth:
					return "Szerokość skali";
				case SchedulerStringId.TextRecurrenceTypeHourly:
					return "Godzinnie";
				case SchedulerStringId.Caption_CalendarDetailsPrintStyle:
					return "Typ szczegółów kalendarza";
				case SchedulerStringId.String_to:
					return "do";
				case SchedulerStringId.Caption_VisibleResources:
					return "Widoczne zasoby";
				case SchedulerStringId.MenuCmd_OpenSchedule:
					return "Otwórz";
				case SchedulerStringId.Caption_SetupResourceMappings:
					return "Skonfiguruj mapowania zasobów";
				case SchedulerStringId.Caption_MemoPrintStyle:
					return "Typ memo";
				case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish:
					return "Koniec-do-końca (KK)";
				case SchedulerStringId.Caption_OnScreenResources:
					return "Zasoby OnScreen";
				case SchedulerStringId.DescCmd_OpenSchedule:
					return "Importuj harmonogram z pliku (.ics)";
				case SchedulerStringId.Caption_ColorConverterFullColor:
					return "Pełny kolor";
				case SchedulerStringId.Msg_Warning:
					return "Uwaga!";
				case SchedulerStringId.Caption_GroupByNone:
					return "Brak";
				case SchedulerStringId.Caption_SetupDependencyMappings:
					return "Skonfiguruj mapowania zależności";
				case SchedulerStringId.MenuCmd_SaveSchedule:
					return "Zapisz";
				case SchedulerStringId.Caption_ColorConverterGrayScale:
					return "Skala szarości";
				case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish:
					return "Początek-do-końca (PK)";
				case SchedulerStringId.Caption_GroupByDate:
					return "Data";
				case SchedulerStringId.Msg_CantFitIntoPage:
					return "Nie można zmieścić zawartości na pojedynczej stronie przy aktualnych ustawieniach drukowania. Spróbuj zwiększyć wysokość strony";
				case SchedulerStringId.DescCmd_SaveSchedule:
					return "Zapisz harmonogram do pliku .ics";
				case SchedulerStringId.TextAppointmentSnapToCells_Always:
					return "Zawsze";
				case SchedulerStringId.Caption_GroupByResources:
					return "Zasoby";
				case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription:
					return "Zmodyfikuj mapowania zadań";
				case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI:
					return "Przypasuj do komórek";
				case SchedulerStringId.TextAppointmentSnapToCells_Auto:
					return "Auto";
				case SchedulerStringId.Msg_PrintStyleNameExists:
					return "Styl o nazwie {0} już istnieje. Spróbuj użyć innej nazwy";
				case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription:
					return "Zmodyfikuj mapowanie zasobów";
				case SchedulerStringId.DescCmd_ChangeSnapToCellsUI:
					return "Skonfiguruj tryb przypasowania dla wyświetlania zadań w komórkach czasowych";
				case SchedulerStringId.TextAppointmentSnapToCells_Disabled:
					return "Zablokowane";
				case SchedulerStringId.Msg_OutlookCalendarNotFound:
					return "Kalendarza '{0}' nie znaleziono";
				case SchedulerStringId.MenuCmd_OpenOccurrence:
					return "Otwórz zadanie";
				case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription:
					return "Zmodyfikuj mapowania zależności zadań";
				case SchedulerStringId.TextAppointmentSnapToCells_Never:
					return "Nigdy";
				case SchedulerStringId.Caption_PrevAppointment:
					return "Poprzednie zadanie";
				case SchedulerStringId.DescCmd_OpenOccurrence:
					return "Otwórz pojedyncze wystąpienie zadania";
				case SchedulerStringId.Caption_MappingsValidation:
					return "Walidacja mapowania";
				case SchedulerStringId.MenuCmd_PrintPreview:
					return "Podgląd wydruku";
				case SchedulerStringId.Caption_NextAppointment:
					return "Następne zadanie";
				case SchedulerStringId.MenuCmd_OpenSeries:
					return "Otwórz serię zadań";
				case SchedulerStringId.Caption_MappingsWizard:
					return "Wizard Zależności...";
				case SchedulerStringId.DescCmd_PrintPreview:
					return "Podgląd wydruku";
				case SchedulerStringId.DisplayName_Appointment:
					return "Zadanie";
				case SchedulerStringId.Caption_CheckMappings:
					return "Sprawdź mapowanie";
				case SchedulerStringId.MenuCmd_Print:
					return "Szybki wydruk";
				case SchedulerStringId.Format_CopyOf:
					return "Kopia {0}";
				case SchedulerStringId.Format_CopyNOf:
					return "Kopia {0} z {1}";
				default:
					return base.GetLocalizedString(id);

			}
		}
	}

	public class PolishSchedulerExtensionLocalizer : SchedulerExtensionsLocalizer
	{
		public override string GetLocalizedString(SchedulerExtensionsStringId id)
		{
			switch (id)
			{
				case SchedulerExtensionsStringId.CaptionViewNavigator_Today:
					return "Dziś";
				case SchedulerExtensionsStringId.Caption_GroupActiveView:
					return "Grupuj aktywny widok";
				case SchedulerExtensionsStringId.Caption_PageView:
					return "Widok strony";
				case SchedulerExtensionsStringId.Caption_Event:
					return "Zdarzenie";
				case SchedulerExtensionsStringId.Caption_GroupActions:
					return "Akcje";
				case SchedulerExtensionsStringId.Msg_Some:
					return "Niektóre";
				case SchedulerExtensionsStringId.Caption_GroupGroupBy:
					return "Grupuj według";
				case SchedulerExtensionsStringId.Caption_GroupTimeScale:
					return "Grupuj na skali czasu";
				case SchedulerExtensionsStringId.Caption_PageHome:
					return "Strona główna";
				case SchedulerExtensionsStringId.Caption_GroupAppointment:
					return "Grupuj zadania";
				case SchedulerExtensionsStringId.Caption_GroupOptions:
					return "Opcje";
				case SchedulerExtensionsStringId.Caption_RecurringAppointment:
					return "Cykliczne zadanie";
				case SchedulerExtensionsStringId.Caption_ViewNavigator:
					return "Nawigator widoku";
				case SchedulerExtensionsStringId.Caption_PageAppointment:
					return "Strona zadania";
				case SchedulerExtensionsStringId.Caption_GroupNavigator:
					return "Nawigator kalendarza";
				case SchedulerExtensionsStringId.Caption_GroupCommon:
					return "Wspólna grupa";
				case SchedulerExtensionsStringId.Caption_ViewSelector:
					return "Selektor widoku";
				case SchedulerExtensionsStringId.Caption_GroupLayout:
					return "Rozkład grupy";
				case SchedulerExtensionsStringId.Caption_Reminder:
					return "Przypomnienie";
				case SchedulerExtensionsStringId.Caption_GroupPrint:
					return "Wydruk grupy";
				case SchedulerExtensionsStringId.Caption_PageCategoryCalendarTools:
					return "Narzędzia kalendarza dla strony kategorii";
				case SchedulerExtensionsStringId.Caption_PageFile:
					return "Pobieranie pliku";
				case SchedulerExtensionsStringId.Caption_RecurringEvent:
					return "Zadanie cykliczne";
				case SchedulerExtensionsStringId.Caption_Appointment:
					return "Zadanie";
				case SchedulerExtensionsStringId.Caption_GroupArrange:
					return "Widok kalendarza";
				default:
					return base.GetLocalizedString(id);
			}

		}
	}
}
