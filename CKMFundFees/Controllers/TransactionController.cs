using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CKMFundFees.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Transaction()
        {
            return View();
        }

        public ActionResult TransactionList()
        {
            return View();
        }

    }
}