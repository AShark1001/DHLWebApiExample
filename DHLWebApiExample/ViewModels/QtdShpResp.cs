using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHLWebApiExample.ViewModels
{
    public class QtdShpResp
    {
        public ServiceArea OriginServiceArea { get; set; }
        public ServiceArea DestinationServiceArea { get; set; }
        public string GlobalProductCode { get; set; }
        public string LocalProductCode { get; set; }
        public string ProductShortName { get; set; }
        public string LocalProductName { get; set; }
        public string NetworkTypeCode { get; set; }
        public string POfferedCustAgreement { get; set; }
        public string TransInd { get; set; }
        
        // Date
        public string PickupDate { get; set; }
        // Duration
        public string PickupCutoffTime { get; set; }

        public string BookingTime { get; set; }
        public string CurrencyCode { get; set; }
        public double ExchangeRate { get; set; }
        public double WeightCharge { get; set; }
        public double WeightChargeTax { get; set; }
        public double weightChargeTaxRate { get; set; }
        public int TotalTransitDays { get; set; }
        public int PickupPostalLocAddDays { get; set; }
        public int DeliveryPostalLocAddDays { get; set; }

        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }

        public string DeliveryTimeGMT { get; set; }
        public double DimensionalWeight { get; set; }
        public string WeightUnit { get; set; }
        public string PickupDayOfWeekNum { get; set; }
        public string DestinationDayOfWeekNum { get; set; }

        public double QuotedWeight { get; set; }
        public string QuotedWeightUOM { get; set; }

        public List<QtdShpExChrg> QtdShpExChrgs { get; set; }
        public string PricingDate { get; set; }
        public double ShippingCharge { get; set; }
        public double TotalTaxAmount { get; set; }
        public double TotalDiscount { get; set; }
        public WeightChargeTaxDet WeightChargeTaxDet { get; set; }
        public List<QtdSInAdCur> QtdSInAdCurList { get; set; }
        public string PickupWindowEarliestTime { get; set; }
        public string PickupWindowLatestTime { get; set; }
        public string BookingCutoffOffset { get; set; }
        public string PickupLeadTime { get; set; }
        public string PickupCloseTime { get; set; }
        public WeightChargeDisc WeightChargeDisc { get; set; }
        public QtdShpExChrgDisc QtdShpExChrgDisc { get; set; }
}
}
