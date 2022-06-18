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
using SKGL;

namespace Admin.App.MSP.Licence
{
    public partial class frnLisansCreate : DevExpress.XtraEditors.XtraForm
    {
        public frnLisansCreate()
        {
            InitializeComponent();
        }

        private void frnLisansCreate_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateLicence_Click(object sender, EventArgs e)
        {
            Generate generate = new Generate();
            generate.secretPhase = txtSifre.Text;
            txtSeriAnahtar.Text = generate.doKey(int.Parse(txtGun.Text));

        }

        private void btn_LicenceOku_Click(object sender, EventArgs e)
        {
            Validate validate = new Validate();
            validate.secretPhase = txtSifre.Text;
            validate.Key = txtSeriAnahtar.Text;
            lblBaslangiDate.Text = Convert.ToString(validate.CreationDate);
            lblEndDate.Text = Convert.ToString(validate.ExpireDate);
            lblKalanGun.Text = Convert.ToString(validate.DaysLeft);

        }
    }
}