using Models;
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
        public ActionResult Transaction(TransactionModel Tmodel)
        {
            if (string.IsNullOrWhiteSpace(Tmodel.Mode))
                Tmodel.Mode = "New";
            return View(Tmodel);
        }

        public ActionResult TransactionList()
        {
            return View();
        }

    }
}