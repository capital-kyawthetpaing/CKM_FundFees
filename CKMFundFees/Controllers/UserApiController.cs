using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserBL;

namespace CKMFundFees.Controllers
{
    [RoutePrefix("CKMFundFees/api/UserApi")]
    public class UserApiController : ApiController
    {
        [UserAuthentication]
        [HttpGet]
        [ActionName("Sp_Select_Login")]

        public string Sp_Select_Login([FromBody] UserModel Umodel)
        {
            User_BL Ubl = new User_BL();
            return Ubl.Sp_Select_Login(Umodel);
        }
        public IHttpActionResult Select_Login([FromBody] UserModel Umodel)
        {
            User_BL Ubl = new User_BL();
            return Ok(Ubl.Sp_Select_Login(Umodel));
        }


    }
}
