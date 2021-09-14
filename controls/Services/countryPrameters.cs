using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mvp.controls.Services
{
   static class countryPrameters
    {
        //this method conct in class that contain method excute insert
        public static bool getcountryInsert(int id, string name)
        {
            return DBhelper.getconnction("countryInsert", () => getcountryPrametersinsert(id, name, DBhelper.cmd));

        }
        //this method contain in parameters insert for storproseduer
        private static void getcountryPrametersinsert (int id, string name, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@country", SqlDbType.NVarChar).Value = name;
        }


        //this method conct in class that contain method excute update
        public static bool getcountryUpdate(int id, string name)
        {
            return DBhelper.getconnction("countryUpdate", () => getcountryPrametersUpdate(id, name, DBhelper.cmd));

        }
        //this method contain in parameters update for storproseduer
        private static void getcountryPrametersUpdate (int id, string name, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@country", SqlDbType.NVarChar).Value = name;
        }


        //this method conct in class that contain method excute delet
        public static bool getcountryDelete(int id)
        {
            return DBhelper.getconnction("countryDelete", () => getcountryPrametDelete(id, DBhelper.cmd));

        }
        //this method contain in parameters delete for storproseduer
        private static void getcountryPrametDelete (int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }


        //this method conct in class that contain method excute deletall
        public static bool getcountryDeleteall()
        {
            return DBhelper.getconnction("countryDeleteAll", () => { });

        }
        //this method contain in parameters delete for storproseduer
        //private static void getcountryPrametDeleteall()
        //{
        //}
        //this method contain in parameters select for storproseduer
        public static DataTable getallData()
        {
            return DBhelper.getData("countryGetall", () => { });
        }

        //this method contain in parameters get all rows
        public static DataTable getallrows()
        {
            return DBhelper.getData("countryallrow", () => { });
        }

        //this method contain in parameters get all rows max
        public static DataTable getmax()
        {
            return DBhelper.getData("countryallmax", () => { });
        }
    }
}
