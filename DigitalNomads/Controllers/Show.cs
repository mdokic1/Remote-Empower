﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigitalNomads.Controllers
{
    public class Show : Controller
    {
        public IActionResult ShowCards()
        {
            return View();
        }
    }
}
