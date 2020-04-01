using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    class Products
    {
        DL.DLA dLA = new DL.DLA();

        public DataTable AllProducts => dLA.SelectCommand("GetProducts", null);
        public DataTable GetAllUnits => dLA.SelectCommand("GetAllUnits", null);
        public DataTable GetAllCatogries() => dLA.SelectCommand("GetAllCatogries", null);
        public DataTable GetCustomProducts(int type)
        {
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0].Value = type;
            return dLA.SelectCommand("GetProducts", sqlParameter);
        }
        public void NewProduct(string Name , string Cat , string Bar , string Sub , string SCost ,string BCost ,string Quan, string Unit,string Inv,string Place )
        {
            /* SqlParameter[] sqlParameters = new SqlParameter[11];
             sqlParameters[0].Value = Bar;
             sqlParameters[1].Value = Name;
             sqlParameters[2].Value = Inv;
             sqlParameters[3].Value = Unit;
             sqlParameters[4].Value = Cat;
             sqlParameters[5].Value = Sub;
             sqlParameters[6].Value = null;
             sqlParameters[7].Value = SCost;
             sqlParameters[8].Value = BCost;
             sqlParameters[9].Value = null;
             sqlParameters[10].Value = Place;
             dLA.ExecuteCommand("NewProduct", sqlParameters);*/
            
            
        }

    }

}
