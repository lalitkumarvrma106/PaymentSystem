using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payment.Models
{
    public class PaymentTrasaction
    {
         public float Amount { get; set; }
         public string AccountHolderName { get; set; }
         public string BankName { get; set; }
         public string BankIFSCCode { get; set; }
        public int CustomerIdCode { get; set; }
        public string Trasactiontype { get; set; }
        public string Creditdebitstatus { get; set; }
        public DateTime DateTime { get; set; }

    }
}