﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineTicaret.Controllers
{
    public class AgreementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}