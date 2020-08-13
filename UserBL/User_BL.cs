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
            return bdl.SelectJson("Sp_Select_Login", Umodel.Sqlprms);
        }
    }
}
