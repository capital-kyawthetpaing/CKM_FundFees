﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CKMFundFees.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserLogin()

        {
            return View();
        }

        public ActionResult MemberList()
        { return View();
        }

        public ActionResult MemberEntry()
        {
            return View();
        }
    }
}