using Library_Mvp.controls.Services;
using Library_Mvp.model;
using Library_Mvp.veiws.interfac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mvp.controls.presinter
{
   public class AutherPresenter
    {
        Iauther iauther;
        AutherModel authermodel = new AutherModel();


        public AutherPresenter(Iauther view)
        {
            this.iauther = view;
        }

        private void connectbetweenModelinterfas()
        {
            iauther.ID = iauther.ID;
            iauther.auther_name = iauther.auther_name;
            iauther.barith_date = iauther.barith_date;
            iauther.country_name = iauther.country_name;
        }
        //method insert for autherpresenter
        public bool autherinsert()
        {
            connectbetweenModelinterfas();
            return AutherPrameters.getAutherInsert(iauther.ID, iauther.auther_name, iauther.barith_date, iauther.country_name);
        }
        //method update for autherpresenter
        public bool autherUpdate()
        {
            connectbetweenModelinterfas();
            return AutherPrameters.getAutherupdate(iauther.ID, iauther.auther_name, iauther.barith_date, iauther.country_name);
        }
        //method delete for autherpresenter
        public bool autherDelete()
        {
            connectbetweenModelinterfas();
            return AutherPrameters.getAutherdelete(iauther.ID);
        }
        //method deleteall for autherpresenter
        public bool autherDeleteall()
        {
            connectbetweenModelinterfas();
            return AutherPrameters.getAutherdeleteall();
        }
        //method clearall for autherpresenter
        public void Clearfialds()
        {
            connectbetweenModelinterfas();
            iauther.ID =0;
            iauther.auther_name ="";
            iauther.barith_date = "";
            iauther.country_name = "";

        }
    }
}
