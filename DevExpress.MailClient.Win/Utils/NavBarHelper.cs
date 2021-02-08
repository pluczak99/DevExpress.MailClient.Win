using System;
using System.Collections.Generic;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System.Drawing;

namespace DevExpress.MailClient.Win
{
	public class NavBarHelper {
        public static void DeleteEmptyGroup(NavBarControl nb) {
            for(int i = nb.Groups.Count - 1; i >= 0; i--)
                if(nb.Groups[i].ItemLinks.Count == 0)
                    nb.Groups.RemoveAt(i);
        }
        public static NavBarItemLink GetFirstItem(NavBarControl nb) {
            foreach(NavBarGroup group in nb.Groups)
                foreach(NavBarItemLink link in group.ItemLinks)
                    return link;
            return null;
        }
        public static NavBarGroup GetGroupByName(string groupName, NavBarControl navBar) {
            NavBarGroup group = null;
            foreach(NavBarGroup fGroup in navBar.Groups)
                if(fGroup.Name.Equals(groupName))
                    group = fGroup;
            if(group == null) {
                group = new NavBarGroup(groupName);
                group.Name = groupName;
                navBar.Groups.Add(group);
            }
            return group;
        }
        public static void SetNavBarItemImage(NavBarItem item, string link) {
            PictureEdit pe = new PictureEdit();
            pe.LoadAsync(ImageHelper.GetFaviconIconPath(link));
            pe.Tag = item;
            pe.LoadCompleted += new EventHandler(pe_LoadCompleted);

        }
        static void pe_LoadCompleted(object sender, EventArgs e) {
            RepositoryItemPictureEdit pe = sender as RepositoryItemPictureEdit;
            NavBarItem item = pe.OwnerEdit.Tag as NavBarItem;
            item.SmallImage = ImageHelper.GetScaleImage(((PictureEdit)pe.OwnerEdit).Image, new Size(16, 16));
            pe.OwnerEdit.Dispose();
            pe.Dispose();
        }
        public static object[] GetGroupNames(NavBarControl navBar) {
            List<string> ret = new List<string>();
            foreach(NavBarGroup group in navBar.Groups) 
                ret.Add(group.Caption);
            return ret.ToArray();
        }
        public static List<string> GetItemNames(NavBarControl navBar) {
            List<string> ret = new List<string>();
            foreach(NavBarItem item in navBar.Items) 
                ret.Add(item.Caption);
            return ret;
        }

        public static string GetUniqueItemName(string name, NavBarControl navBar) {
            List<string> names = GetItemNames(navBar);
            for(int i = 1; i < 9999; i++) {
                string ret = string.Format("{0}{1}", name, i);
                if(!names.Contains(ret)) return ret;
            }
            return string.Empty;
            
        }
    }
}
