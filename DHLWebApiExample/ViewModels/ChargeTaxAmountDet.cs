using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class ChargeTaxAmountDet
    {
        public double TaxTypeRate { get; set; }
        public string TaxTypeCode { get; set; }
        public double TaxAmount { get; set; }
        public double BaseAmount { get; set; }
    }
}
