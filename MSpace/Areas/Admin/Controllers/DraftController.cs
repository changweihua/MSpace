﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Areas.Admin.Controllers
{
    public class DraftController : AdminBaseController
    {
        //
        // GET: /Admin/Draft/

        public ActionResult Index()
        {
            return View();
        }

    }
}
