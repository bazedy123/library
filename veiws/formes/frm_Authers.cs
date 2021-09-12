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
    public partial class frm_Authers :XtraForm,Iauther
    {
        AutherPresenter autherpresenter;
        public frm_Authers()
        {
            InitializeComponent();
            autherpresenter = new AutherPresenter(this);
        }

        public string auther_name
        {
            get
            {
               return txt_name_Autheer.Text;
            }

            set
            {
                txt_name_Autheer.Text = value.ToString();
            }
        }

        public string barith_date
        {
            get
            {
                return txt_date_Autheer.Text.ToString();
            }

            set
            {
                txt_date_Autheer.Text = value.ToString();
            }
        }

        public string country_name
        {
            get
            {
                return txt_con_Autheer.Text;
            }

            set
            {
                txt_con_Autheer.Text = value.ToString();
            }
        }

        public int ID
        {
            get
            {
                return Convert.ToInt32(txt_id_Auther.Text);
            }

            set
            {
                txt_id_Auther.Text = value.ToString();
            }
        }

        private void btn_add_Auther_Click(object sender, EventArgs e)
        {
            bool check = autherpresenter.autherinsert();
            if (check)
            {
                MessageBox.Show("تم الاضافة بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_removeall_Auther_Click(object sender, EventArgs e)
        {
            bool check = autherpresenter.autherDeleteall();
            if (check)
            {
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_delete_Auther_Click(object sender, EventArgs e)
        {
            bool check = autherpresenter.autherDelete();
            if (check)
            {
                MessageBox.Show("تم حذف الكل بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_save_Auther_Click(object sender, EventArgs e)
        {
            bool check = autherpresenter.autherUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_new_Auther_Click(object sender, EventArgs e)
        {
            autherpresenter.Clearfialds();
        }
    }
}