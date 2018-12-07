using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class QtdSInAdCur
    {
        public double CustomsValue { get; set; }
        public double ExchangeRate { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyRoleTypeCode { get; set; }
        public double WeightCharge { get; set; }
        public double TotalAmount { get; set; }
        public double TotalTaxAmount { get; set; }
        public double WeightChargeTax { get; set; }
        public WeightChargeTaxDet WeightChargeTaxDet { get; set; }
    }
}
