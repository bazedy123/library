using Library_Mvp.controls.Services;
using Library_Mvp.model;
using Library_Mvp.veiws;
using Library_Mvp.veiws.interfac;
using System;
using System.Collections.Generic;
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
            return catgoreyPrameter.getInsert(icatogrey.ID, icatogrey.Cname, icatogrey.Catogrey);
        }
        //method update for catogreypresenter
        public bool catUpdate()
        {
            connectbetweenModelinterfas();
            return catgoreyPrameter.getUpdate(icatogrey.ID, icatogrey.Cname, icatogrey.Catogrey);
        }
        //method delete for catogreypresenter
        public bool catDelete()
        {
            connectbetweenModelinterfas();
            return catgoreyPrameter.getDelet(icatogrey.ID);
        }
        //method deleteall for catogreypresenter
        public bool catDeleteall()
        {
            connectbetweenModelinterfas();
            return catgoreyPrameter.getDeletall();
        }
        //method deleteall for catogreypresenter
        public void Clear()
        {
            connectbetweenModelinterfas();
            icatogrey.ID = 0;
            icatogrey.Cname = "";
            icatogrey.Catogrey = "";
        }
    }
}
