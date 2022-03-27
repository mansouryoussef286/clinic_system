using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic_system
{
    static class appManager
    {
        public static login loginForm;
        public static MainForm mainForm;

        public static ConfirmDialog confirmDlg;

        public static clinicEntities entities;

        public static patient selectedPatient { get; set; }
        public static visit selectedVisit{ get; set; }

        static appManager()
        {
            //initialize the three main forms to use them during the app
            //to show and close them anywhere in the app and easily access them
            entities = new clinicEntities();
            loginForm = new login();


        }
    }
}
