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
        public void NewProduct(string Bar,string PName ,string Inv_Id,string unit ,string quan, string Cat_Id , string Desc , string SCost ,string BCost ,string Place,string Sup_Id,string Emp_Id,string Inv_Type)
        {
            
            SqlParameter[] sqlParameters = new SqlParameter[15];
            sqlParameters[0] = new SqlParameter("@SKU", SqlDbType.BigInt);
            sqlParameters[0].Value = Bar;
            sqlParameters[1] = new SqlParameter("@PName", SqlDbType.NVarChar , 50);
            sqlParameters[1].Value = PName;
            sqlParameters[2] = new SqlParameter("@Inv_ID", SqlDbType.Int);
            sqlParameters[2].Value = Inv_Id;
            sqlParameters[3] = new SqlParameter("@UNIT", SqlDbType.Int);
            sqlParameters[3].Value = unit;
            sqlParameters[4] = new SqlParameter("@Quan", SqlDbType.Float);
            sqlParameters[4].Value = quan;
            sqlParameters[5] = new SqlParameter("@Cat_Id", SqlDbType.Int);
            sqlParameters[5].Value = Cat_Id;
            sqlParameters[6] = new SqlParameter("@Desc", SqlDbType.Text);
            sqlParameters[6].Value = Desc;
            sqlParameters[7] = new SqlParameter("@SPrice", SqlDbType.Money);
            sqlParameters[7].Value = SCost;
            sqlParameters[8] = new SqlParameter("@BPrice", SqlDbType.Money);
            sqlParameters[8].Value = BCost;
            sqlParameters[9] = new SqlParameter("@Tax", SqlDbType.Money);
            sqlParameters[9].Value = "0";
            sqlParameters[10] = new SqlParameter("@Place_Id", SqlDbType.Int);
            sqlParameters[10].Value = Place;
            sqlParameters[11] = new SqlParameter("@Sup_Id", SqlDbType.Int);
            sqlParameters[11].Value = Sup_Id;
         
            sqlParameters[12] = new SqlParameter("@Discount", SqlDbType.Money);
            sqlParameters[12].Value = 0;
            sqlParameters[13] = new SqlParameter("@Emp_Id", SqlDbType.Int);
            sqlParameters[13].Value = Emp_Id;
            sqlParameters[14] = new SqlParameter("@type", SqlDbType.Bit);
            sqlParameters[14].Value = true;
            dLA.ExecuteCommand("AddSupInvoice", sqlParameters);
            
        }

    }

}
