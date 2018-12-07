using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class QtdShpExChrgDisc
    {
        public double DiscAmt { get; set; }
        public double BaseAmt { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyRoleTypeCode { get; set; }
        public double DiscPercentage { get; set; }
    }
}
