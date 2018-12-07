using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class WeightChargeTaxDet
    {
        public double TaxTypeRate { get; set; }
        public string TaxTypeCode { get; set; }
        public double WeightChargeTax { get; set; }
        public double BaseAmt { get; set; }
    }
}
