﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HslHomepage.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            HslHomepage.Data.StaticInfomation.AccessCount++;
            Utils.SoftUtils.NumericalOrder.GetLongOrder( );
        }
    }
}
