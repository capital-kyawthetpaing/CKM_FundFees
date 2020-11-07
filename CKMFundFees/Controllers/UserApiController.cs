using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserBL;

namespace CKMFundFees.Controllers
{
    //[RoutePrefix("CKMFundFees/api/UserApi")]
    public class UserApiController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
        [ActionName("Sp_Select_Login")]      
        public IHttpActionResult Sp_Select_Login([FromBody]UserModel Umodel)
        {
            User_BL Ubl = new User_BL();
            return Ok(Ubl.Sp_Select_Login(Umodel));
        }

        //[UserAuthentication]
        //[HttpPost]
        //[ActionName("Login")]
        //public IHttpActionResult Login(UserModel model)
        //{
        //    User_BL obj = new User_BL();
        //    return Ok(obj);
        //}

        [UserAuthentication]
        [HttpPost]
        [ActionName("Sp_Select_MemberList")]
        public IHttpActionResult Sp_Select_MemberList([FromBody]UserModel Umodel)
        {
            User_BL Ubl = new User_BL();
            return Ok(Ubl.Sp_Select_MemberList(Umodel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("SP_Insert_MemberEntry")]
        public IHttpActionResult SP_Insert_MemberEntry([FromBody] UserModel Umodel)
        {
            User_BL Tbl = new User_BL();
            return Ok(Tbl.SP_Insert_MemberEntry(Umodel));
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("SP_Select_PageList")]
        public IHttpActionResult SP_Select_PageList([FromBody]EntryModel Umodel)
        {
            User_BL Ubl = new User_BL();
            return Ok(Ubl.SP_Select_PageList(Umodel));
        }


    }
}
