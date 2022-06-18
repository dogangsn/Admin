using Admin.App.App;
using Admin.App.MSP;
using Admin.App.MSP.Licence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.App
{
    public class Screns
    {


        public void Help(Form _MdiForm)
        {
            Helps Help = new Helps();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }

        public void frnLisansCreate(Form _MdiForm)
        {
            frnLisansCreate Help = new frnLisansCreate();
            Help.MdiParent = _MdiForm;
            Help.Show();
        }

        public void PrivateSecurity(Form _MdiForm)
        {
            PrivateSecurity frm = new PrivateSecurity();
            frm.MdiParent = _MdiForm;
            frm.Show();
        }

        public void MD5Security(Form _MdiForm)
        {
            MD5Security frm = new MD5Security();
            frm.MdiParent = _MdiForm;
            frm.Show();
        }
    }
}
