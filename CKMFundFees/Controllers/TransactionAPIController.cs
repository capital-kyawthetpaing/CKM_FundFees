using Models.CKMFundFees.Models;
using System.Data;
using System.Web.Http;
using TransactionBL;

namespace CKMFundFees.Controllers
{
    public class TransactionAPIController : ApiController
    {
        [UserAuthentication]
        [HttpGet]
        [ActionName("Select_TransactionTypes")]
        public IHttpActionResult Select_TransactionTypes()
        {
            Transaction_BL Tbl = new Transaction_BL();
            DataTable dt = Tbl.Select_TransactionTypes();
            return Ok(dt);
            //return Ubl.M_Brand_Select();
        }
        [UserAuthentication]
        [HttpPost]
        [ActionName("Insert_TransactionTypes")]
        public IHttpActionResult Insert_TransactionTypes([FromBody] TransactionModel Tmodel)
        {
            Transaction_BL Tbl = new Transaction_BL();
            return Ok(Tbl.M_Insert_TransactionTypes(Tmodel));
        }
    }
}