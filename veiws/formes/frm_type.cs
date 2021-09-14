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

        public object Datagrid
        {
            get
            {
                return dgv_data1_cat.DataSource;
            }

            set
            {
                dgv_data1_cat.DataSource = value;
            }
        }
        public object btn_save_c
        {
            get
            {
                return btn_save_cat.Enabled;
            }

            set
            {
                btn_save_cat.Enabled = Convert.ToBoolean(value);
            }
        }

        public object btn_add_c
        {
            get
            {
                return btn_add_cat.Enabled;
            }

            set
            {
                btn_add_cat.Enabled = Convert.ToBoolean(value);
            }
        }

        public object btn_delete_c
        {
            get
            {
                return btn_delete_cat.Enabled;
            }

            set
            {
                btn_delete_cat.Enabled = Convert.ToBoolean(value);
            }
        }

        public object btn_removeall_c
        {
            get
            {
                return btn_removeall_cat.Enabled;
            }

            set
            {
                btn_removeall_cat.Enabled = Convert.ToBoolean(value);
            }
        }

        public object btn_new_c
        {
            get
            {
                return btn_new_cat.Enabled;
            }

            set
            {
                btn_new_cat.Enabled = Convert.ToBoolean(value);
            }
        }

        public int row1
        {
            get
            {
                return row1;
            }

            set
            {
                row1 = value;
            }
        }

        int row = 0;
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
            if (txt_name_cat.Text == "" && txt_desc.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاسم", "تاكيد", MessageBoxButtons.OK);
                return;
            }
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
            if (txt_name_cat.Text == "" && txt_desc.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاسم", "تاكيد", MessageBoxButtons.OK);
                return;
            }
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
            catPresenter.autonumber();
        }

        private void frm_type_Load(object sender, EventArgs e)
        {
            catPresenter.DataIngrid();
            catPresenter.autonumber();
        }

        private void btn_first_cat_Click(object sender, EventArgs e)
        {
            try
            {
                row = 0;
                catPresenter.getrow(row);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_last_cat_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(catPresenter.getrows().Rows[0][0]) - 1;
                row = count;
                catPresenter.getrow(row);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_prev_cat_Click(object sender, EventArgs e)
        {
            try
            {
                int countprev = Convert.ToInt32(catPresenter.getrows().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countprev;
                }
                else
                {
                    row = row - 1;
                }
                catPresenter.getrow(row);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_next_cat_Click(object sender, EventArgs e)
        {
            try
            {
                int countnext = Convert.ToInt32(catPresenter.getrows().Rows[0][0]) - 1;
                if (countnext == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;
                }
                catPresenter.getrow(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
