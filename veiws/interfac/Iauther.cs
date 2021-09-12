using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mvp.veiws.interfac
{
   public interface Iauther
    {
        int ID { get; set; }
        string auther_name { get; set; }
        string barith_date { get; set; }
        string country_name { get; set; }
    }
}
