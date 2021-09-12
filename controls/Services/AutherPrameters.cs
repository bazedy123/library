using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mvp.controls.Services
{
   static class AutherPrameters
    {
        //this method conct in class that contain method excute insert
        public static bool getAutherInsert(int id, string name, string braith_date, string country_name)
        {
            return DBhelper.getconnction("autherInsert", () => getAutherPrametersinsert(id, name, braith_date, country_name, DBhelper.cmd));

        }
        //this method contain in parameters insert for storproseduer
        private static void getAutherPrametersinsert (int id, string name,string braith_date, string country_name, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Auther_name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@Barith_date", SqlDbType.NVarChar).Value = braith_date;
            cmd.Parameters.Add("@Country_Name", SqlDbType.NVarChar).Value = country_name;
        }

        //this method conct in class that contain method excute delete
        public static bool getAutherdelete(int id)
        {
            return DBhelper.getconnction("autherDelete", () => getAutherPrametersdelete(id, DBhelper.cmd));

        }
        //this method contain in parameters delete for storproseduer
        private static void getAutherPrametersdelete(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //this method conct in class that contain method excute update
        public static bool getAutherupdate(int id, string name, string braith_date, string country_name)
        {
            return DBhelper.getconnction("autherUpdate", () => getAutherPrametersupdate(id, name, braith_date, country_name, DBhelper.cmd));

        }
        //this method contain in parameters update for storproseduer
        private static void getAutherPrametersupdate(int id, string name, string braith_date, string country_name, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Auther_name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@Barith_date", SqlDbType.NVarChar).Value = braith_date;
            cmd.Parameters.Add("@Country_Name", SqlDbType.NVarChar).Value = country_name;
        }

        public static bool getAutherdeleteall()
        {
            return DBhelper.getconnction("autherleteall", () => getAutherPrametersdeleteall());

        }
        //this method contain in parameters delete for storproseduer
        private static void getAutherPrametersdeleteall()
        {
            
        }

    }
}
