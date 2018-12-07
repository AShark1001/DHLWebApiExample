using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class MrkSrv
    {
        public string LocalProductCode { get; set; }
        public string LocalServiceType { get; set; }
        public string ProductShortName { get; set; }
        public string GlobalServiceName { get; set; }
        public string LocalProductName { get; set; }
        public string LocalServiceTypeName { get; set; }
        public string ProductDesc { get; set; }
        public string ServiceDesc { get; set; }
        public string NetworkTypeCode { get; set; }
        public string POfferedCustAgreement { get; set; }
        public string SOfferedCustAgreement { get; set; }
        public string TransInd { get; set; }
        public string ChargeCodeType { get; set; }
        public string MrkSrvInd { get; set; }
        public string LocalProductCityCd { get; set; }
        public string LocalProductDesc { get; set; }
        public string GlobalProductDesc { get; set; }
        public string GlobalServiceType { get; set; }
        public string BillingServiceIndicator { get; set; }
        public string LocalServiceName { get; set; }
    }
}
