using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Library_Mvp.model;
using System.Data;
using System.Data.Common;

namespace Library_Mvp.controls.Services
{
    public static class DBhelper
    {
        public static SqlCommand cmd;
        //this is mothed for conect database
        private static SqlConnection getSQLconnctionstring()
        {
            SqlConnectionStringBuilder Builder = new SqlConnectionStringBuilder();
            Builder.DataSource = Properties.Settings.Default.serverName;
            Builder.InitialCatalog = Properties.Settings.Default.Database;
            Builder.IntegratedSecurity = true;

            return new SqlConnection(Builder.ConnectionString);
        }
        //this mothed insert update delete and delete all from database


        public static bool getconnction(string spdatabase, Action method)
        {
            using (SqlConnection con = getSQLconnctionstring())
            {
                try
                {
                    cmd = new SqlCommand(spdatabase, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //this method that contain in prameters
                    method.Invoke();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    con.Close();
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
            return false;
        }
        //this mothed select  from database
        public static DataTable getData(string spdatabase, Action method)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter da;
            using (SqlConnection con = getSQLconnctionstring())
            {
                try
                {
                    cmd = new SqlCommand(spdatabase, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //this method that contain in prameters
                    method.Invoke();
                    con.Open();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(tbl);
                    da.Dispose();
                    con.Close();
                  
                }
                catch (Exception ex)
                {
                    con.Close();
                    Console.WriteLine(ex.Message);
                    
                }
                finally
                {
                    con.Close();
                   
                }
            }
            return tbl;
        }

    }
}
