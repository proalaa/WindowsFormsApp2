using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace WindowsFormsApp2.DL
{
    public class DLA
    {
        public DLA()
        {
            ConnectionString = @"Data Source=.;Initial Catalog=Al-Haddad_for_trading;Integrated Security=True";
        }
        
        
        string ConnectionString;
       /* public void Open()
        {

            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();

            }

        }
        //Method To Close The Connection
        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        */

        public DataTable SelectCommand(string Sp , SqlParameter[] pars)
        {

            using (SqlConnection ConObj = new SqlConnection(ConnectionString))
            {
                ConObj.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = Sp;
                sqlCommand.CommandType = CommandType.StoredProcedure;
               
                if (pars != null)
                {
                    foreach (var par in pars)
                    {
                        sqlCommand.Parameters.Add(par);
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void ExecuteCommand(string Sp, SqlParameter[] pars)
        {
            
                try
                {
                    using (SqlConnection objConn = new SqlConnection(ConnectionString))
                    {
                        objConn.Open();
                        SqlCommand sqlCommand1 = new SqlCommand();
                        sqlCommand1.CommandText = Sp;
                        sqlCommand1.CommandType = CommandType.StoredProcedure;
                        sqlCommand1.Connection = objConn;
                        if (pars != null)
                        {
                            foreach (var par in pars)
                            {
                                sqlCommand1.Parameters.Add(par);
                            }
                        }
                        sqlCommand1.ExecuteNonQuery();
                        sqlCommand1.Dispose();
                        
                    }
                }
                catch (Exception ex)
                {
                    // Log error    
                    

                    MessageBox.Show(ex.Message);
                }
            }
           
            
          
        
           


    }
}
