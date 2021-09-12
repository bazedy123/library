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
            return countryPrameters.getcountryInsert(icountry.ID, icountry.Coun_name);
        }
        //method update for countrypresenter
        public bool counUpdate()
        {
            connectbetweenModelinterfas();
            return countryPrameters.getcountryUpdate(icountry.ID, icountry.Coun_name);
        }
        //method delete for countrypresenter
        public bool counDelete()
        {
            connectbetweenModelinterfas();
            return countryPrameters.getcountryDelete(icountry.ID);
        }
        //method deleteall for countrypresenter
        public bool countDeleteall()
        {
            connectbetweenModelinterfas();
            return countryPrameters.getcountryDeleteall();
        }
        //method clearall for countrypresenter
        public void Clearfiald()
        {
            connectbetweenModelinterfas();
            icountry.ID = 0;
            icountry.Coun_name = "";
           
        }
    }
}
