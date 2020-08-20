using DL;
using Models.CKMFundFees.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Tmodel.Sqlprms = new SqlParameter[4];
            Tmodel.Sqlprms[1] = new SqlParameter("@TransactionName", SqlDbType.VarChar) { Value = Tmodel.TransactionDate };
            Tmodel.Sqlprms[0] = new SqlParameter("@TransactionTypeID", SqlDbType.VarChar) { Value = Tmodel.TransactionType };
            Tmodel.Sqlprms[2] = new SqlParameter("@Member", SqlDbType.VarChar) { Value = Tmodel.Member };
            Tmodel.Sqlprms[2] = new SqlParameter("@Amount", SqlDbType.VarChar) { Value = Tmodel.Amount };
            return bdl.InsertUpdateDeleteData("M_Insert_TransactionTypes", Tmodel.Sqlprms);
        }
    }
}
