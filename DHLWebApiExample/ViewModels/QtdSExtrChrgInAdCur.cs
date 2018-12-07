using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class QtdSExtrChrgInAdCur
    {
        public double ChargeValue { get; set; }
        public double ChargeExchangeRate { get; set; }
        public double ChargeTaxAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyRoleTypeCode { get; set; }
        public ChargeTaxAmountDet ChargeTaxAmountDet { get; set; }
    }
}
