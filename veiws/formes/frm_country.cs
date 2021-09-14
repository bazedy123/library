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
        public int row1
        {
            get
            {
              return  row1;
            }
            set
            {
                row1 = value;
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

        public object datagridveiw
        {
           get
            {
              return Convert.ToString( dgv_data1_con.DataSource);
            }
            set
            {
                dgv_data1_con.DataSource = value;
            }
        }

        public object btn_save_c
        {
            get
            {
                return btn_save_con.Enabled;
            }

            set
            {
                btn_save_con.Enabled = Convert.ToBoolean( value);
            }
        }

        public object btn_add_c
        {
            get
            {
                return btn_add_con.Enabled;
            }

            set
            {
                btn_add_con.Enabled = Convert.ToBoolean(value);
            }
        }

        public object btn_delete_c
        {
            get
            {
                return btn_delete_con.Enabled;
            }

            set
            {
                btn_delete_con.Enabled = Convert.ToBoolean(value);
            }
        }

        public object btn_removeall_c
        {
            get
            {
                return btn_removeall_con.Enabled;
            }

            set
            {
                btn_removeall_con.Enabled = Convert.ToBoolean(value);
            }
        }

        public object btn_new_c
        {
            get
            {
                return btn_new_con.Enabled;
            }

            set
            {
                btn_new_con.Enabled = Convert.ToBoolean(value);
            }
        }

        int row = 0;
       
        //button add
        private void btn_add_con_Click(object sender, EventArgs e)
        {
            if (txt_name_con.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاسم","تاكيد",MessageBoxButtons.OK);
                return;
            }
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
        //button edit
        private void btn_save_con_Click(object sender, EventArgs e)
        {
            if (txt_name_con.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الاسم", "تاكيد", MessageBoxButtons.OK);
                return;
            }
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
        //button delete
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
        //buttondelete all
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
        //button new
        private void btn_new_con_Click(object sender, EventArgs e)
        {
            countrypresent.Clearfiald();
        }
        //form load
        private void frm_country_Load(object sender, EventArgs e)
        {
            countrypresent.getalldata();
            countrypresent.autonumber();
        }
        //bottun frist
        private void btn_first_con_Click(object sender, EventArgs e)
        {
            try
            {
                row = 0;
                countrypresent.getrow(row);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        //button last
        private void btn_last_con_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(countrypresent.getrows().Rows[0][0]) - 1;
                row = count;
                countrypresent.getrow(row);

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        //button preve
        private void btn_prev_con_Click(object sender, EventArgs e)
        {
            try
            {
                int countprev = Convert.ToInt32(countrypresent.getrows().Rows[0][0]) - 1;
                if (row == 0)
                {
                   row = countprev;
                }
                else
                {
                    row = row - 1;
                }
                countrypresent.getrow(row);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //button next
        private void btn_next_con_Click(object sender, EventArgs e)
        {
            try
            {
                int countnext = Convert.ToInt32(countrypresent.getrows().Rows[0][0])-1;
                if (countnext == row)
                {
                    row = 0;
                }else
                {
                    row = row + 1;
                }
                countrypresent.getrow(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}