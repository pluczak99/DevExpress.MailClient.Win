using System;
using System.Collections.Generic;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.DevAV;

namespace DevExpress.MailClient.Win
{
	public class EditorHelper {
        public static RepositoryItemImageComboBox CreateTaskStatusImageComboBox(RepositoryItemImageComboBox edit) {
            Array arr = Enum.GetValues(typeof(TaskStatus));
            edit.Items.Clear();
            foreach(TaskStatus status in arr)
                edit.Items.Add(new ImageComboBoxItem(GetStringByTaskStatus(status), status, (int)status));
            return edit;
        }
        static string GetStringByTaskStatus(TaskStatus status) {
            switch(status) {
                case TaskStatus.Completed: return Properties.Resources.TaskStatusCompleted;
                case TaskStatus.Deferred: return Properties.Resources.TaskStatusDeferred;
                case TaskStatus.InProgress: return Properties.Resources.TaskStatusInProgress;
                case TaskStatus.WaitingOnSomeoneElse: return Properties.Resources.TaskStatusWaitingOnSomeoneElse;
            }
            return Properties.Resources.TaskStatusNotStarted;
        }
        public static RepositoryItemImageComboBox CreateTaskCategoryImageComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryHouseChores, TaskCategory.HouseChores, 0));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryShopping, TaskCategory.Shopping, 1));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.TaskCategoryOffice, TaskCategory.Office, 2));
            return edit;
        }
        public static RepositoryItemImageComboBox CreateFlagStatusImageComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.SmallImages = CreateFlagStatusSvgImageCollection();
            edit.GlyphAlignment = HorzAlignment.Center;
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Today, FlagStatus.Today, (int)FlagStatus.Today));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Tomorrow, FlagStatus.Tomorrow, (int)FlagStatus.Tomorrow));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.ThisWeek, FlagStatus.ThisWeek, (int)FlagStatus.ThisWeek));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NextWeek, FlagStatus.NextWeek, (int)FlagStatus.NextWeek));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.NoDate, FlagStatus.NoDate, (int)FlagStatus.NoDate));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Custom, FlagStatus.Custom, (int)FlagStatus.Custom));
            edit.Items.Add(new ImageComboBoxItem(Properties.Resources.Completed, FlagStatus.Completed, (int)FlagStatus.Completed));
            return edit;
        }
        public static void InitPriorityComboBox(RepositoryItemImageComboBox edit) {
            edit.Items.Clear();
            edit.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityLow, 0, 0),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityMedium, 1, -1),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem(Properties.Resources.PriorityHigh, 2, 1)});
        }
        public static void InitTitleComboBox(RepositoryItemImageComboBox edit) {
            var iCollection = new SvgImageCollection();
            iCollection.Add(Properties.Resources.Doctor1);
            iCollection.Add(Properties.Resources.Miss1);
            iCollection.Add(Properties.Resources.Mr1);
            iCollection.Add(Properties.Resources.Mrs1);
            iCollection.Add(Properties.Resources.Ms1);
            iCollection.Add(Properties.Resources.Professor1);
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Dr), PersonPrefix.Dr, 0));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Miss), PersonPrefix.Miss, 1));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mr), PersonPrefix.Mr, 2));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Mrs), PersonPrefix.Mrs, 3));
            edit.Items.Add(new ImageComboBoxItem(GetTitleNameByContactTitle(PersonPrefix.Ms), PersonPrefix.Ms, 4));
            edit.SmallImages = iCollection;
        }
        public static string GetTitleNameByContactTitle(PersonPrefix title) {
            switch(title) {
                case PersonPrefix.Dr: return Properties.Resources.ContactTitleDr;
                case PersonPrefix.Miss: return Properties.Resources.ContactTitleMiss;
                case PersonPrefix.Mr: return Properties.Resources.ContactTitleMr;
                case PersonPrefix.Mrs: return Properties.Resources.ContactTitleMrs;
                case PersonPrefix.Ms: return Properties.Resources.ContactTitleMs;
            }
            return string.Empty;
        }

        static SvgImageCollection CreateFlagStatusSvgImageCollection() {
            var collection = new SvgImageCollection();
            collection.Add(Properties.Resources.Today1);
            collection.Add(Properties.Resources.Tomorrow1);
            collection.Add(Properties.Resources.ThisWeek1);
            collection.Add(Properties.Resources.NextWeek1);
            collection.Add(Properties.Resources.NoDate1);
            collection.Add(Properties.Resources.Custom1);
            collection.Add(Properties.Resources.Completed1);
            return collection;
        }
        internal static List<string> GetCities() {
            //IEnumerable cities = (from contact in DataHelper.Contacts select contact.City).OrderBy(s => s).Distinct();
            //return cities.Cast<string>().ToList();
            return new List<string>();
        }
        internal static List<string> GetStates() {
            //IEnumerable states = (from contact in DataHelper.Contacts select contact.State).OrderBy(s => s).Distinct();
            //return states.Cast<string>().ToList();
			return new List<string>();
        }
    }
}
