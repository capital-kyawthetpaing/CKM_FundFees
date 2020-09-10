using DL;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace TransactionBL
{
    public class Transaction_BL
    {
        public DataTable Select_TransactionTypes()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectDatatable("Sp_Select_TransactionType");
        }  
        public string Transaction_CUD(TransactionModel Tmodel)
        {
            BaseDL bdl = new BaseDL();
            if (Tmodel.Mode.Equals("New"))
            {
                Tmodel.SPName = "SP_Insert_Transaction";
                Tmodel.Sqlprms = new SqlParameter[6];
                Tmodel.Sqlprms[0] = new SqlParameter("@TransactionID", SqlDbType.VarChar) { Value = Tmodel.TransactionID };
                Tmodel.Sqlprms[1] = new SqlParameter("@TransactionDate", SqlDbType.VarChar) { Value = Tmodel.TransactionDate };
                Tmodel.Sqlprms[2] = new SqlParameter("@TransactionTypeID", SqlDbType.VarChar) { Value = Tmodel.TransactionType };
                Tmodel.Sqlprms[3] = new SqlParameter("@MemberID", SqlDbType.VarChar) { Value = Tmodel.MemberID };
                //Sqlprms[3] = new SqlParameter("@MemberName", SqlDbType.VarChar) { Value = Tmodel.MemberName };
                Tmodel.Sqlprms[4] = new SqlParameter("@Amount", SqlDbType.VarChar) { Value = Tmodel.Amount };
                Tmodel.Sqlprms[5] = new SqlParameter("@Remark", SqlDbType.VarChar) { Value = Tmodel.Remarks };
                
            }
            else if (Tmodel.Mode.Equals("Edit"))
            {
                Tmodel.SPName = "SP_Update_Transaction";
                Tmodel.Sqlprms = new SqlParameter[6];
                Tmodel.Sqlprms[0] = new SqlParameter("@TransactionID", SqlDbType.VarChar) { Value = Tmodel.TransactionID };
                Tmodel.Sqlprms[1] = new SqlParameter("@TransactionDate", SqlDbType.VarChar) { Value = Tmodel.TransactionDate };
                Tmodel.Sqlprms[2] = new SqlParameter("@TransactionTypeID", SqlDbType.VarChar) { Value = Tmodel.TransactionType };
                Tmodel.Sqlprms[3] = new SqlParameter("@MemberID", SqlDbType.VarChar) { Value = Tmodel.MemberID };
                //Sqlprms[3] = new SqlParameter("@MemberName", SqlDbType.VarChar) { Value = Tmodel.MemberName };
                Tmodel.Sqlprms[4] = new SqlParameter("@Amount", SqlDbType.VarChar) { Value = Tmodel.Amount };
                Tmodel.Sqlprms[5] = new SqlParameter("@Remark", SqlDbType.VarChar) { Value = Tmodel.Remarks };
            }
            else if (Tmodel.Mode.Equals("Delete"))
            {
                Tmodel.SPName = "SP_Delete_Transaction";
                Tmodel.Sqlprms = new SqlParameter[1];
                Tmodel.Sqlprms[0] = new SqlParameter("@TransactionID", SqlDbType.VarChar) { Value = Tmodel.TransactionID };
            }

            return bdl.SelectJson(Tmodel.SPName, Tmodel.Sqlprms);
        }
        public DataTable SP_Select_TransactionList()
        {
            BaseDL bdl = new BaseDL();
            return bdl.SelectDatatable("SP_Select_TransactionList");
        }
    }
}