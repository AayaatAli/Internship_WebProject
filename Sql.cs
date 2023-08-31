using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Second
{
    public class Sql
    {
        static SqlConnection con;

        public Sql()
        {
            con = cls_SQLConnection.getConnection();
        }

        static SqlConnection resetConnection()
        {
            con = cls_SQLConnection.getConnection();
            return con;
        }

        public static DataTable getAllProd()
        {
            return fillDataTable("select * from Product");
        }

        public static DataTable getAllShipping()
        {
            return fillDataTable("select * from ShippingInfo");
        }

        public static DataTable fillDataTable(string query)
        {

            SqlCommand cmd = new SqlCommand(query, con);
            return fillDataTable(cmd);
        }

        public static DataTable getProduct(int PID)
        {
            String sql = "select * from dbo.Product where Product_ID= @P_ID  ";
            SqlParameter param = new SqlParameter() { SqlValue = PID, ParameterName = "@P_ID" };
            //param.A("@ID", SqlDbType.Int);
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add(param);
            return Sql.fillDataTable(cmd);//"select * from dbo.Product where Product_ID= @P_ID + ");
            //return Sql.fillDataTable("select * from dbo.Product where Product_ID= @P_ID + ");
        }

        public static DataTable fillDataTable(string query, SqlParameter sqlParameter)
        {

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(sqlParameter);
            return fillDataTable(cmd);
        }

        public static DataTable fillDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con = resetConnection();
                //con.Open();
                //SqlCommand cmd = cmd_;
                //dt.Load(cmd.ExecuteReader());
                cmd.Connection = con;
                con.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);
                sqlDA.Fill(ds);
                dt = ds.Tables[0];

                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                con.Close();

            }
        }
    }

    public class cls_SQLConnection
    {
        static SqlConnection con;
        static cls_SQLConnection sqlConnCls;
        private cls_SQLConnection()
        {
            string strcon = ConfigurationManager.ConnectionStrings["ConnectionStringName"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            con = new SqlConnection(strcon);
        }

        public static SqlConnection getConnection()
        {
            if (sqlConnCls == null)
            {
                sqlConnCls = new cls_SQLConnection();
            }
            return con;
        }


        

        //public static cls_SQLConnection getInstance()
        //{
        //    if (sqlConnCls == null)
        //    {
        //        sqlConnCls = new cls_SQLConnection();
        //    }
        //    return sqlConnCls;
        //}
    }
    //SQL Injection
}