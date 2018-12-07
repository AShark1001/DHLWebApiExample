using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class QtdShpExChrg
    {
        public string SpecialServiceType { get; set; }
        public string LocalServiceType { get; set; }
        public string GlobalServiceName { get; set; }
        public string LocalServiceTypeName { get; set; }
        public string SOfferedCustAgreement { get; set; }
        public string ChargeCodeType { get; set; }
        public int InsPrmRateInPercentage { get; set; }
        public string CurrencyCode { get; set; }
        public double ChargeValue { get; set; }
        public double ChargeTaxAmount { get; set; }
        public double ChargeTaxRate { get; set; }
        public ChargeTaxAmountDet ChargeTaxAmountDet { get; set; }
        public List<QtdSExtrChrgInAdCur> QtdSExtrChrgInAdCurList { get; set; }
    }
}
