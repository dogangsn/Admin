using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Admin.Infrastructure.Extensions;

namespace Admin.App.App
{
    public partial class PrivateSecurity : DevExpress.XtraEditors.XtraForm
    {
        public PrivateSecurity()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sifre = txtSifre.EditValue.ToString().Trim();
            txtConvertSifre.Text = SecurityExtension.Sifrele(sifre);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string sifre = txtSifre.EditValue.ToString().Trim();
            txtConvertSifre.Text = SecurityExtension.Sifre_Coz(sifre);
        }
    }
}