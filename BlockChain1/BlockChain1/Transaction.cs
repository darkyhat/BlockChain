﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain1
{
    class Transaction
    {
        public int Amount { get; set; }
        public string Recipient { get; set; }
        public string Sender { get; set; }
    }
}
