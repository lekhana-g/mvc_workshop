﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class SbaccountSankalp
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
