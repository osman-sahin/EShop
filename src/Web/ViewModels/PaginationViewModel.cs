﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class PaginationViewModel
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int ActualPage { get; set; }
        public int ItemsOnPage { get; set; }
    }
}
