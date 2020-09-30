using Models;
using System.Data;
using System.Web.Http;
using TransactionBL;

namespace CKMFundFees.Controllers
{
    public class TransactionAPIController : ApiController
    {
        [UserAuthentication]
        [HttpPost]
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
        public string Transaction_CUD([FromBody] TransactionModel Tmodel)
        {
            Transaction_BL Tbl = new Transaction_BL();
            return Tbl.Transaction_CUD(Tmodel);
        }

        [UserAuthentication]
        [HttpPost]
        [ActionName("SP_Select_TransactionList")]
        public IHttpActionResult SP_Select_TransactionList([FromBody]TransactionModel Tmodel)
        {
            Transaction_BL Tbl = new Transaction_BL();
            return Ok(Tbl.SP_Select_TransactionList(Tmodel));
        }
    }
}