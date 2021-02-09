using System;
using DevExpress.XtraEditors.DXErrorProvider;

namespace DevExpress.MailClient.Win
{
	public class Task : IDXDataErrorInfo
	{
		int priority = 1;
		int percentComplete = 0;
		DateTime createdDate;
		DateTime? startDate = null, dueDate = null, completedDate = null;
		string subject, description;
		TaskStatus status = TaskStatus.NotStarted;
		TaskCategory category;
		public Task(string subject, TaskCategory category)
			: this(subject, category, DateTime.Now)
		{
		}
		internal Task(string subject, TaskCategory category, DateTime date)
		{
			this.subject = subject;
			this.category = category;
			this.createdDate = date;
		}
		public int Priority { get { return priority; } set { priority = value; } }
		public int PercentComplete
		{
			get { return percentComplete; }
			set
			{
				value = Math.Min(Math.Max(value, 0), 100);
				if (percentComplete == value) return;
				percentComplete = value;
				switch (percentComplete)
				{
					case 0:
						Status = TaskStatus.NotStarted;
						break;
					case 100:
						Status = TaskStatus.Completed;
						break;
					default:
						Status = TaskStatus.InProgress;
						break;
				}
			}
		}
		public DateTime CreatedDate { get { return createdDate; } }
		public DateTime? StartDate { get { return startDate; } set { startDate = value; } }
		public DateTime? DueDate { get { return dueDate; } set { dueDate = value; } }
		public DateTime? CompletedDate { get { return completedDate; } set { completedDate = value; } }
		public string Subject { get { return subject; } set { subject = value; } }
		public string Description { get { return description; } set { description = value; } }
		public TaskCategory Category { get { return category; } set { category = value; } }
		public TaskStatus Status
		{
			get { return status; }
			set
			{
				status = value;
				if (status == TaskStatus.Completed)
				{
					PercentComplete = 100;
					CompletedDate = DateTime.Now;
				}
				else
					CompletedDate = null;
				if (status == TaskStatus.NotStarted)
					PercentComplete = 0;
				if (status == TaskStatus.InProgress && PercentComplete == 100)
					PercentComplete = 75;
				if (status == TaskStatus.Deferred || status == TaskStatus.WaitingOnSomeoneElse)
					DueDate = null;
			}
		}
		internal TimeSpan TimeDiff { get { return (DateTime.Now - CreatedDate); } }
		public bool Overdue
		{
			get
			{
				if (Status == TaskStatus.Completed || !DueDate.HasValue) return false;
				DateTime dDate = DueDate.Value.Date.AddDays(1);
				if (DateTime.Now >= dDate) return true;
				return false;
			}
		}
		public bool Complete
		{
			get { return Status == TaskStatus.Completed; }
			set
			{
				if (value)
					Status = TaskStatus.Completed;
				else Status = TaskStatus.NotStarted;
			}
		}
		public int Icon { get { return Complete ? 0 : 1; } }
		public FlagStatus FlagStatus
		{
			get
			{
				DateTime today = DateTime.Today;
				if (Complete) return FlagStatus.Completed;
				if (!DueDate.HasValue) return FlagStatus.NoDate;
				if (DueDate.Value.Date.Equals(today)) return FlagStatus.Today;
				if (DueDate.Value.Date.Equals(today.AddDays(1))) return FlagStatus.Tomorrow;
				DateTime thisWeekStart = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(today);
				if (DueDate.Value.Date >= thisWeekStart && DueDate.Value.Date < thisWeekStart.AddDays(7)) return FlagStatus.ThisWeek;
				if (DueDate.Value.Date >= thisWeekStart.AddDays(7) && DueDate.Value.Date < thisWeekStart.AddDays(14)) return FlagStatus.NextWeek;
				return FlagStatus.Custom;
			}
		}
		public void Assign(Task task)
		{
			this.subject = task.Subject;
			this.priority = task.Priority;
			this.percentComplete = task.PercentComplete;
			this.createdDate = task.CreatedDate;
			this.startDate = task.StartDate;
			this.dueDate = task.DueDate;
			this.completedDate = task.CompletedDate;
			this.description = task.Description;
			this.category = task.Category;
			this.status = task.Status;
			//this.assignTo = task.AssignTo;
		}
		public Task Clone()
		{
			Task task = new Task(this.Subject, this.Category);
			task.Assign(this);
			return task;
		}
		public string DueIn
		{
			get
			{
				if (DueDate.HasValue)
				{
					int oDays = (DateTime.Today - DueDate.Value).Days;
					return oDays > 0 ? string.Format("{0} day{1} overdue", oDays, oDays > 1 ? "s" : string.Empty) : string.Empty;
				}
				return string.Empty;
			}
		}
		#region IDXDataErrorInfo Members
		public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info) { }

		public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info)
		{
			if (propertyName == "DueDate")
			{
				if ((DueDate.HasValue && StartDate.HasValue) && DueDate < StartDate)
					SetErrorInfo(info, Properties.Resources.DueDateError, ErrorType.Critical);
				if (!DueDate.HasValue && Status == TaskStatus.InProgress)
					SetErrorInfo(info, Properties.Resources.DueDateWarning, ErrorType.Warning);
			}
		}
		void SetErrorInfo(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info, string errorText, ErrorType errorType)
		{
			info.ErrorText = errorText;
			info.ErrorType = errorType;
		}
		#endregion
	}
}