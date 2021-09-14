using Library_Mvp.controls.Services;
using Library_Mvp.model;
using Library_Mvp.veiws;
using Library_Mvp.veiws.interfac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mvp.controls.presinter
{
    public class catogreyPresenter
    {
        Icatogrey icatogrey;
        catogrey catmodel = new catogrey();
       public catogreyPresenter(Icatogrey view)
        {
            this.icatogrey = view;
        }

        private void connectbetweenModelinterfas()
        {
            icatogrey.ID = icatogrey.ID;
            icatogrey.Cname = icatogrey.Cname;
            icatogrey.Catogrey = icatogrey.Catogrey;
        }
        //method insert for catogreypresenter
        public bool catinsert()
        {
            connectbetweenModelinterfas();
            bool check= catgoreyPrameter.getInsert(icatogrey.ID, icatogrey.Cname, icatogrey.Catogrey);
            DataIngrid();
            autonumber();
            Clear();
            return check;
        }
        //method update for catogreypresenter
        public bool catUpdate()
        {
            connectbetweenModelinterfas();
            bool check = catgoreyPrameter.getUpdate(icatogrey.ID, icatogrey.Cname, icatogrey.Catogrey);
            DataIngrid();
            autonumber();
            Clear();
            return check;
        }
        //method delete for catogreypresenter
        public bool catDelete()
        {
            connectbetweenModelinterfas();
            bool check = catgoreyPrameter.getDelet(icatogrey.ID);
            DataIngrid();
            Clear();
            autonumber();

            return check;
        }
        //method deleteall for catogreypresenter
        public bool catDeleteall()
        {
            connectbetweenModelinterfas();
            bool check = catgoreyPrameter.getDeletall();
            DataIngrid();
            autonumber();
            Clear();
            return check;
        }
        //method deleteall for catogreypresenter
        public void Clear()
        {
            icatogrey.ID = 0;
            icatogrey.Cname = "";
            icatogrey.Catogrey = "";
            autonumber();
        }
        public void DataIngrid()
        {
            icatogrey.Datagrid= catgoreyPrameter.getallData();
        }
        //autonumber  for countrypresenter
        public void autonumber()
        {
            string test = (catgoreyPrameter.getmax().Rows[0][0]).ToString();
            if (test == null || test == "")
            {
                icatogrey.ID = 1;
            }
            else
            {
                icatogrey.ID = Convert.ToInt32(catgoreyPrameter.getmax().Rows[0][0]) + 1;
            }

            icatogrey.Cname = "";
            icatogrey.btn_save_c = false;
            icatogrey.btn_add_c = true;
            icatogrey.btn_delete_c = false;
            icatogrey.btn_removeall_c = false;

        }

        //method get first  preveuse and next 
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = catgoreyPrameter.getallData();

            icatogrey.ID = Convert.ToInt32(tbl.Rows[row][0]);
            icatogrey.Cname = Convert.ToString(tbl.Rows[row][1]);
            icatogrey.Catogrey= Convert.ToString(tbl.Rows[row][2]);

            icatogrey.btn_save_c = true;
            icatogrey.btn_add_c = false;
            icatogrey.btn_delete_c = true;
            icatogrey.btn_removeall_c = true;
        }

        //method last
        public DataTable getrows()
        {
            DataTable tbl = new DataTable();
            tbl = catgoreyPrameter.getallrows();
            return tbl;
        }
    }
}
