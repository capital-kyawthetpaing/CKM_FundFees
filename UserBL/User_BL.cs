using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBL
{
    public class User_BL
    {
        public string Sp_Select_Login(UserModel Umodel)
        {
            BaseDL bdl = new BaseDL();
            Umodel.Sqlprms = new SqlParameter[2];
            Umodel.Sqlprms[0] = new SqlParameter("@MemberID", SqlDbType.VarChar) { Value = Umodel.MemberID };
            Umodel.Sqlprms[1] = new SqlParameter("@Password", SqlDbType.VarChar) { Value = Umodel.Password };
            return bdl.SelectJson("SP_Select_Login", Umodel.Sqlprms);
        }
 
        public string Sp_Select_MemberList(UserModel model)
        {
            BaseDL bdl = new BaseDL();
            model.Sqlprms = new SqlParameter[1];
            model.Sqlprms[0] = new SqlParameter("@MemberID", model.MemberID);
            return bdl.SelectJson("Sp_Select_MemberList", model.Sqlprms);
        }
        public string SP_Insert_MemberEntry(UserModel Umodel)
        {
            BaseDL bdl = new BaseDL();
            Umodel.Sqlprms = new SqlParameter[3];
            Umodel.Sqlprms[0] = new SqlParameter("@MemberID", SqlDbType.VarChar) { Value = Umodel.MemberID };
            Umodel.Sqlprms[1] = new SqlParameter("@MemberName", SqlDbType.VarChar) { Value = Umodel.MemberName};
            Umodel.Sqlprms[2] = new SqlParameter("@Password", SqlDbType.VarChar) { Value = Umodel.Password};
            Umodel.Sqlprms[3] = new SqlParameter("@PhoneNo", SqlDbType.VarChar) { Value = Umodel.PhoneNo };
            Umodel.Sqlprms[4] = new SqlParameter("@JoinDate", SqlDbType.Date) { Value = Umodel.JoinDate };
            return bdl.InsertUpdateDeleteData("SP_Insert_MemberEntry", Umodel.Sqlprms);
        }

        public string SP_Select_PageList(EntryModel Umodel)
        {
            BaseDL bdl = new BaseDL();
            Umodel.Sqlprms = new SqlParameter[1];
            Umodel.Sqlprms[0] = new SqlParameter("@PageID", Umodel.PageID);
            return bdl.SelectJson("SP_Select_PageList", Umodel.Sqlprms);
        }

    }
    }

    

