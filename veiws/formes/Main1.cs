using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Library_Mvp.veiws.formes
{
    public partial class Main1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_type frm = new frm_type();
            frm.ShowDialog();

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

            frm_Catogry frm = new frm_Catogry();
            frm.ShowDialog();
        }
    }
}