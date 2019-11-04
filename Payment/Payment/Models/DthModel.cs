using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payment.Models
{
    public class DthModel
    {
        public long? SubscriberNumber { get; set; }
        public string Operator { get; set; }

        public string planName { get; set; }
        public double? amount { get; set; }
    }
}