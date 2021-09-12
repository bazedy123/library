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
using Library_Mvp.veiws.interfac;
using Library_Mvp.controls.presinter;

namespace Library_Mvp.veiws.formes
{
    public partial class frm_country : XtraForm,Icountry
    {
        countryPresenter countrypresent;
        public frm_country()
        {
            InitializeComponent();
            countrypresent = new countryPresenter(this);
        }

        public string Coun_name
        {
            get
            {
                return txt_name_con.Text;
            }

            set
            {
                txt_name_con.Text = value.ToString();
            }
        }

        public int ID
        {
            get
            {
                return Convert.ToInt32(txt_id_con.Text);
            }

            set
            {
                txt_id_con.Text = value.ToString();
            }
        }

        private void btn_add_con_Click(object sender, EventArgs e)
        {
            bool check = countrypresent.couninsert();
            if (check)
            {
                MessageBox.Show("تم الاضافة بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_save_con_Click(object sender, EventArgs e)
        {
            bool check = countrypresent.counUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_delete_con_Click(object sender, EventArgs e)
        {
            bool check = countrypresent.counDelete();
            if (check)
            {
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_removeall_con_Click(object sender, EventArgs e)
        {
            bool check = countrypresent.countDeleteall();
            if (check)
            {
                MessageBox.Show("تم حذف الكل");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_new_con_Click(object sender, EventArgs e)
        {
            countrypresent.Clearfiald();
        }
    }
}