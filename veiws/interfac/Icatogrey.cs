using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mvp.veiws.interfac
{
    public interface Icatogrey
    {
        int ID { get; set; }
        string Cname { get; set; }
        string Catogrey { get; set; }
        object Datagrid { get; set; }
        int row1 { get; set; }
        object btn_save_c { get; set; }
        object btn_add_c { get; set; }
        object btn_delete_c { get; set; }
        object btn_removeall_c { get; set; }
        object btn_new_c { get; set; }
    }
}
