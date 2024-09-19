using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsShopManagement
{
    internal class DataAccess
    {
        
            private SqlConnection sqlcon;
            public SqlConnection Sqlcon
            {
                get { return this.sqlcon; }
                set { this.sqlcon = value; }
            }

            private SqlCommand sqlcom;
            public SqlCommand Sqlcom
            {
                get { return this.sqlcom; }
                set { this.sqlcom = value; }
            }

            private SqlDataAdapter sda;
            public SqlDataAdapter Sda
            {
                get { return this.sda; }
                set { this.sda = value; }
            }

            private DataSet ds;
            public DataSet Ds
            {
                get { return this.ds; }
                set { this.ds = value; }
            }

        


        public DataAccess()
            {
                this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-453B3KI\SQLEXPRESS;Initial Catalog=SportsShopManagementSystem;Integrated Security=True");

                //this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-VCDR0MA\SQLEXPRESS;Initial Catalog=CareForPaws;Integrated Security=True");
                Sqlcon.Open();

            }

            private void QueryText(string query)
            {
                this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            }

            public DataSet ExecuteQuery(string sql)
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds;
            }

            public DataTable ExecuteQueryTable(string sql)
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return Ds.Tables[0];
            }

            public int ExecuteDMLQuery(string sql)
            {
                this.QueryText(sql);
                int u = this.Sqlcom.ExecuteNonQuery();
                return u;
            }

        
    }
}

