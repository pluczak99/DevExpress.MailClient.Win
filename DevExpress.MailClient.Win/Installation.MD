# Introduction

**DevExpress.MailClient.Win** is a .NET Framework 4.7.2 Windows Forms application, utilizing:
- evaluation version of DevExpress WinForms components for superior user experience, resembling familiar UI of Microsoft Outlook, and allowing very flexible capabilities for UI theme selection at runtime.
- MS SQL Server/SQL Express database as the backend

# Functionality Description

1. Application allows adding/editing/removing ToDo tasks, similarly like Microsoft Outlook allows task management:
   1. tasks can be scheduled for a particular day and time, they end at a particular time, day, or take entire day or multiple days
   2. tasks can be one-time or recurrent - in the latter case, a task can have its recurrence pattern defined using the familiar Microsoft Outlook UI
   3. tasks can have categories, which provide a specific background task color on the schedule view
   4. tasks can have a location
   5. tasks can have a task disposition specifying whether the user is available, out of office etc.
   5. tasks can have a description
   6. tasks can have a **reminder** defined, which ensures that before the task is due to start the user is reminded of it by seeing a window, just like the one in Microsoft Outlook
   7. existing tasks can be edited and their details can be changed
   8. existing tasks can be deleted - it applies to both one-time tasks, recurrent task series or recurrent task occurence
   9. tasks can be moved around the calendar by simply using drag and drop
   10. tasks are saved to SQL Server and after the application is restarted they are reloaded

NOTE: in the current implementation recurrent tasks cannot have reminders, applicable to each occurence of a recurrence pattern

2. Tasks and calendars can be:
   1. Printed
   2. Exported as .ics format
   3. Imported as .ics format
   4. Exported in a multitude of text/rich text formats

# Application Design

1. **The application is built using Office 2016/2019 UI components** - with ribbon, ribbon items and very familiar and extremely configurable Microsoft Outlook Calendar UI.



# Application Use
1. Upon starting the application, select UI language (Polish or English) by using the dropdown.
2. Default option is Polish and it is sufficient to press Space key or Enter to continue with this selection.
 
<p align="center">
<img align="center" src="Documentation/App_LanguageSelection.png"></img>
</p>

3. The main screen of the application shows calendar view with lots of options to configure parameters of the view (current day, current workweek, current full week, current month etc.)

<p align="center">
<img align="center" src="Documentation/App_CalendarView.png"></img>
</p>


4. Creating new to-do one-time tasks can be done by clicking "Nowe zadanie to-do" in the top left corner of the window and it opens a new form:
<p align="center">
<img align="center" src="Documentation/App_ToDoTaskForm.png"></img>
</p>

5. Creating new cyclical tasks can be done by clicking "Nowe cykliczne zadanie to-do" in the top left corner of the window and it opens a similar task edit form like in case of one-time to-do tasks:
<p align="center">
<img align="center" src="Documentation/App_ToDoCyclicalTaskForm.png"></img>
</p>. 

NOTE: in the current implementation the recurrence edit form has not been localized fully for the Polish language.