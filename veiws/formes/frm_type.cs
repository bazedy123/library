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
using Library_Mvp.controls.presinter;
using Library_Mvp.veiws.interfac;

namespace Library_Mvp.veiws.formes
{
    public partial class frm_type : XtraForm, Icatogrey
    {
        catogreyPresenter catPresenter;

        public int ID
        {
            get
            {
                return Convert.ToInt32(txt_id_cat.Text);

            }

            set
            {
                txt_id_cat.Text = value.ToString();

            }
        }

        public string Cname
        {
            get
            {
                return txt_name_cat.Text;
            }

            set
            {
                txt_name_cat.Text = value.ToString();
            }
        }

        public string Catogrey
        {
            get
            {
                return txt_desc.Text;
            }

            set
            {
                txt_desc.Text = value.ToString();
            }
        }

        public frm_type()
        {
            InitializeComponent();
            catPresenter = new catogreyPresenter(this);
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            bool check = catPresenter.catinsert();
            if (check)
            {
                MessageBox.Show("تم الاضافة بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_save_cat_Click(object sender, EventArgs e)
        {
            bool check = catPresenter.catUpdate();
            if (check)
            {
                MessageBox.Show("تم التعديل بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_delete_cat_Click(object sender, EventArgs e)
        {
            bool check = catPresenter.catDelete();
            if (check)
            {
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_removeall_cat_Click(object sender, EventArgs e)
        {
            bool check = catPresenter.catDeleteall();
            if (check)
            {
                MessageBox.Show("تم حذف الكل");
            }
            else
            {
                MessageBox.Show("هناك مشكلة");
            }
        }

        private void btn_new_cat_Click(object sender, EventArgs e)
        {
            catPresenter.Clear();
        }
    }
}
