﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class ManishaSbaccount
    {
        public int Accno { get; set; }
        public decimal? Bal { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
