using Library_Mvp.controls.Services;
using Library_Mvp.model;
using Library_Mvp.veiws.interfac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Mvp.controls.presinter
{
    public class countryPresenter
    {
        Icountry icountry;
        countryModel counmodel = new countryModel();


        public countryPresenter(Icountry view)
        {
            this.icountry = view;
        }

        private void connectbetweenModelinterfas()
        {
            icountry.ID = icountry.ID;
            icountry.Coun_name = icountry.Coun_name;

        }
        //method insert for countrypresenter
        public bool couninsert()
        {
            connectbetweenModelinterfas();
            bool check = countryPrameters.getcountryInsert(icountry.ID, icountry.Coun_name);
            getalldata();
            autonumber();
            return check;
        }
        //method update for countrypresenter
        public bool counUpdate()
        {
            connectbetweenModelinterfas();
            bool check = countryPrameters.getcountryUpdate(icountry.ID, icountry.Coun_name);
            getalldata();
            autonumber();
            return check;
        }
        //method delete for countrypresenter
        public bool counDelete()
        {
            connectbetweenModelinterfas();
            bool check = countryPrameters.getcountryDelete(icountry.ID);
            getalldata();
            autonumber();
            return check;
        }
        //method deleteall for countrypresenter
        public bool countDeleteall()
        {
            //connectbetweenModelinterfas();
            bool check = countryPrameters.getcountryDeleteall();
            getalldata();
            autonumber();
            return check;
        }
        //method clearall for countrypresenter
        public void Clearfiald()
        {
            icountry.ID = 0;
            icountry.Coun_name = "";
            autonumber();
        }

        //method select for countrypresenter
        public void getalldata()
        {
            icountry.datagridveiw = countryPrameters.getallData();
        }
        //autonumber  for countrypresenter
        public void autonumber()
        {
            string test = (countryPrameters.getmax().Rows[0][0]).ToString();
            if (test == null || test == "")
            {
                icountry.ID = 1;
            }
            else
            {
                icountry.ID = Convert.ToInt32(countryPrameters.getmax().Rows[0][0]) + 1;
            }

            icountry.Coun_name = "";
            icountry.btn_save_c = false;
            icountry.btn_add_c = true;
            icountry.btn_delete_c = false;
            icountry.btn_removeall_c = false;

        }

        //method get first  preveuse and next 
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = countryPrameters.getallData();

            icountry.ID = Convert.ToInt32(tbl.Rows[row][0]);
            icountry.Coun_name = Convert.ToString(tbl.Rows[row][1]);


            icountry.btn_save_c = true;
            icountry.btn_add_c = false;
            icountry.btn_delete_c = true;
            icountry.btn_removeall_c = true;
        }

        //method last
        public DataTable getrows()
        {
            DataTable tbl = new DataTable();
            tbl = countryPrameters.getallrows();
            return tbl;
        }

    }
}
