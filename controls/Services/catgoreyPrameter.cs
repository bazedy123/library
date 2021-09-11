using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_Mvp.controls.Services
{
   static class catgoreyPrameter
    {
        //this method conct in class that contain method excute insert
        public static bool getInsert(int id,string name,string catogreey)
        {
            return DBhelper.getconnction("catogreyInsert",()=> getPrametersinsert(id,name,catogreey,DBhelper.cmd));
           
        }
        //this method contain in parameters insert for storproseduer
        private static void getPrametersinsert(int id, string name, string catogrey, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@catogrey_name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@catogrey", SqlDbType.NVarChar).Value = catogrey;
        }
        //this method conct in class that contain method excute delete
        public static bool getDelet(int id)
        {
            return DBhelper.getconnction("catogreyDelete", () => getPrameterDelete(id, DBhelper.cmd));
            
        }
        //this method contain in parameters delete for storproseduer
        private static void getPrameterDelete(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //this method conct in class that contain method excute update
        public static bool getUpdate(int id,string name,string catogrey)
        {
            return DBhelper.getconnction("catogreyUpdate", () => getPrameterUpdate(id,name,catogrey, DBhelper.cmd));
       
        }
        //this method contain in parameters update for storproseduer
        private static void getPrameterUpdate(int id,string name,string catogrey, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@catogrey_name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@catogrey", SqlDbType.NVarChar).Value = catogrey;
        }

        //this method conct in class that contain method excute delete all
        public static bool getDeletall()
        {
            return DBhelper.getconnction("catogreyDeleteall", () => getPrameterDeleteall( DBhelper.cmd));
         
        }
        //this method contain in parameters deleteall for storproseduer
        private static void getPrameterDeleteall( SqlCommand cmd)
        {
           // cmd.Parameters.RemoveAt();
        }
    }
}
