using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class WeightChargeDisc
    {
        public double DiscAmt { get; set; }
        public double BaseAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string DiscType { get; set; }
        public double DiscPercentage { get; set; }
    }
}
