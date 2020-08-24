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
            if (Tmodel == null)
            {
                throw new System.ArgumentNullException(nameof(Tmodel));
            }

            Transaction_BL Tbl = new Transaction_BL();
            return Ok(Tbl.M_Insert_TransactionTypes(Tmodel));
        }
        [UserAuthentication]
        [HttpGet]
        [ActionName("SP_Select_TransactionList")]
        public IHttpActionResult SP_Select_TransactionList()
        {

            Transaction_BL Tbl = new Transaction_BL();
            DataTable dt = Tbl.SP_Select_TransactionList();
            return Ok(dt);
            //return Ubl.Sp_Select_MemberList();
        }
    }
}