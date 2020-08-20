using DL;
using Models.CKMFundFees.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TransactionBL
{
    public class Transaction_BL
    {
        public DataTable Select_TransactionTypes()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectDatatable("Sp_Select_TransactionType");
        }
        
        public string M_Insert_TransactionTypes(TransactionModel Tmodel)
        {
            BaseDL bdl = new BaseDL();
            Tmodel.Sqlprms = new SqlParameter[6];
            Tmodel.Sqlprms[0] = new SqlParameter("@TransactionDate", SqlDbType.VarChar) { Value = Tmodel.TransactionDate };
            Tmodel.Sqlprms[1] = new SqlParameter("@TransactionType", SqlDbType.VarChar) { Value = Tmodel.TransactionType };
            Tmodel.Sqlprms[2] = new SqlParameter("@MemberID", SqlDbType.VarChar) { Value = Tmodel.MemberID };
            Tmodel.Sqlprms[3] = new SqlParameter("@MemberName", SqlDbType.VarChar) { Value = Tmodel.MemberName };
            Tmodel.Sqlprms[4] = new SqlParameter("@Amount", SqlDbType.VarChar) { Value = Tmodel.Amount };
            Tmodel.Sqlprms[5] = new SqlParameter("@Remarks", SqlDbType.VarChar) { Value = Tmodel.Remarks };
            return bdl.InsertUpdateDeleteData("M_Insert_TransactionTypes", Tmodel.Sqlprms);
        }
    }
}
