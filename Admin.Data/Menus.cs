using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Data
{
    public class Menus
    {
        public Menus(int id, string menuMainGroup, string menuSubGroup, string menuGroup, string menuText, string menuHint, string menuRemark, string menuForm, string menuFormType, int[] applications)
        {
            Id = id;
            MenuMainGroup = menuMainGroup;
            MenuSubGroup = menuSubGroup;
            MenuGroup = menuGroup;
            MenuText = menuText;
            MenuHint = menuHint;
            MenuRemark = menuRemark;
            MenuForm = menuForm;
            MenuFormType = menuFormType;
            Applications = applications;

        }
        public int Id { get; set; }
        public string MenuMainGroup { get; set; }
        public string MenuSubGroup { get; set; }
        public string MenuGroup { get; set; }
        public string MenuText { get; set; }
        public string MenuHint { get; set; }
        public string MenuRemark { get; set; }
        public string MenuForm { get; set; }
        public string MenuFormType { get; set; }
        private int[] applications;

        public int[] Applications
        {
            get { return applications; }
            set { applications = value; }
        }
    }
}
