using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IBTProcessor
{
    class XMLconvertor
    {
        public static IBTTermSheet convertXMLtoIBTTermSheet()
        {
            XDocument xdoc = XDocument.Load("../../IBT.xml");

            IBTTermSheet objIBTTermSheet = new IBTTermSheet();

            IEnumerable<AdminData> adminData = from ad in xdoc.Descendants("AdminData")
                                               select new AdminData
                                               {
                                                   SubmitterInternalReference = (string)ad.Element("SubmitterInternalReference") ?? String.Empty,
                                                   DefinitiveTermsFlag = (string)ad.Element("DefinitiveTermsFlag") ?? String.Empty,
                                                   EffectiveFromDate = (string)ad.Element("EffectiveFromDate") ?? String.Empty,
                                               };

            IEnumerable<Evnt> events = from evt in xdoc.Descendants("Event")
                                       select new Evnt
                                       {
                                           EventType = (string)evt.Element("EventType") ?? String.Empty
                                       };

            IEnumerable<Contact> contacts = from ct in xdoc.Descendants("Contact")
                                            select new Contact
                                            {
                                                ContactType = (string)ct.Element("ContactType") ?? String.Empty,
                                                ContactName = (string)ct.Element("ContactName") ?? String.Empty,
                                                TelephoneNo = (string)ct.Element("TelephoneNo") ?? String.Empty,
                                                FaxNo = (string)ct.Element("FaxNo") ?? String.Empty,
                                                EmailAddress = (string)ct.Element("EmailAddress") ?? String.Empty,
                                            };
            IEnumerable<ServiceData> serviceData = from sd in xdoc.Descendants("ServiceData")
                                                   select new ServiceData()
                                                   {
                                                       RequestedServiceOfferings = from rso in sd.Descendants("RequestedServiceOffering")
                                                                                   select new RequestedServiceOffering()
                                                                                   {
                                                                                       RequestedServiceOfferingType = (string)rso.Element("RequestedServiceOfferingType") ?? String.Empty,
                                                                                   },
                                                       SWXData = from swx in sd.Descendants("SWXData")
                                                                 select new SWXData
                                                                 {
                                                                     WarrantType = (string)swx.Element("WarrantType") ?? String.Empty,
                                                                     UnderlyingDescription = (string)swx.Element("UnderlyingDescription") ?? String.Empty,
                                                                     ExercisePrice = (string)swx.Element("ExercisePrice") ?? String.Empty,
                                                                     ExerciseCurrencyCode = (string)swx.Element("ExerciseCurrencyCode") ?? String.Empty,
                                                                     IssueExchangeRate = (string)swx.Element("IssueExchangeRate") ?? String.Empty,
                                                                     DesignatedMarketMaker = (string)swx.Element("DesignatedMarketMaker") ?? String.Empty,
                                                                     ShareholderOptionFlag = (string)swx.Element("ShareholderOptionFlag") ?? String.Empty
                                                                 },
                                                       SISData = from sis in sd.Descendants("SISData")
                                                                 select new SISData
                                                                 {
                                                                     DeliveryPromiseFlag = (string)sis.Element("DeliveryPromiseFlag") ?? String.Empty,
                                                                     SafeCustodyAccountNumber = (string)sis.Element("SafeCustodyAccountNumber") ?? String.Empty
                                                                 }
                                                   };

            IEnumerable<Instrument> instrument = from ins in xdoc.Descendants("Instrument")
                                                 select new Instrument()
                                                 {
                                                     ProductDescriptionURL = (string)ins.Element("ProductDescriptionURL") ?? String.Empty,
                                                     ProductNameFull = (string)ins.Element("ProductNameFull") ?? String.Empty,
                                                     ProductBrand = (string)ins.Element("ProductBrand") ?? String.Empty,
                                                     IBTTypeCode = (string)ins.Element("IBTTypeCode") ?? String.Empty,
                                                     CollateralisationType = (string)ins.Element("CollateralisationType") ?? String.Empty,
                                                     PrivatePlacementFlag = (string)ins.Element("PrivatePlacementFlag") ?? String.Empty,
                                                     IssueCurrencyCode = (string)ins.Element("IssueCurrencyCode") ?? String.Empty,
                                                     QuantoFlag = (string)ins.Element("QuantoFlag") ?? String.Empty,
                                                     IssuePrice = (string)ins.Element("IssuePrice") ?? String.Empty,
                                                     InstrumentQuotationType = (string)ins.Element("InstrumentQuotationType") ?? String.Empty,
                                                     IssueCapitalisation = (string)ins.Element("IssueCapitalisation") ?? String.Empty,
                                                     IssueIncreaseFlag = (string)ins.Element("IssueIncreaseFlag") ?? String.Empty,
                                                     NumberInIssue = (string)ins.Element("NumberInIssue") ?? String.Empty,
                                                     OpenEndFlag = (string)ins.Element("OpenEndFlag") ?? String.Empty,
                                                     InvestorPutabilityFlag = (string)ins.Element("InvestorPutabilityFlag") ?? String.Empty,
                                                     IssuerCallabilityFlag = (string)ins.Element("IssuerCallabilityFlag") ?? String.Empty,
                                                     IssuerProlongationFlag = (string)ins.Element("IssuerProlongationFlag") ?? String.Empty,
                                                     AmortisableFlag = (string)ins.Element("AmortisableFlag") ?? String.Empty,
                                                     MainUnderlyingAssetType = (string)ins.Element("MainUnderlyingAssetType") ?? String.Empty,
                                                     UnderlyingMgmtType = (string)ins.Element("UnderlyingMgmtType") ?? String.Empty,
                                                     IssueDate = (string)ins.Element("IssueDate") ?? String.Empty,
                                                     PaymentDate = (string)ins.Element("PaymentDate") ?? String.Empty,
                                                     InitialFixingDateType = (string)ins.Element("InitialFixingDateType") ?? String.Empty,
                                                     InitialFixingDate = (string)ins.Element("InitialFixingDate") ?? String.Empty,
                                                     InitialFixingDayPriceType = (string)ins.Element("InitialFixingDayPriceType") ?? String.Empty,
                                                     InitialFixingTime = (string)ins.Element("InitialFixingTime") ?? String.Empty,
                                                     LegalSecurityType = (string)ins.Element("SecurityRankingType") ?? String.Empty,
                                                     SecurityRankingType = (string)ins.Element("SecurityRankingType") ?? String.Empty,
                                                     JurisdictionAreaCode = (string)ins.Element("JurisdictionAreaCode") ?? String.Empty,
                                                     LegalVenue = (string)ins.Element("LegalVenue") ?? String.Empty,
                                                     InstrumentClassifications = from ic in ins.Descendants("InstrumentClassification")
                                                                                 select new InstrumentClassification
                                                                                 {
                                                                                     ClassificationSchemeType = (string)ic.Element("ClassificationSchemeType") ?? String.Empty,
                                                                                     ClassificationValue = (string)ic.Element("ClassificationValue") ?? String.Empty
                                                                                 },
                                                     CHTaxData = from cht in ins.Descendants("CHTaxData")
                                                                 select new CHTaxData
                                                                 {
                                                                     CHIssueStampTaxFlag = (string)cht.Element("CHIssueStampTaxFlag") ?? String.Empty,
                                                                     StampTaxFeedbackFlag = (string)cht.Element("StampTaxFeedbackFlag") ?? String.Empty,
                                                                     CHWithholdingTaxRate = (string)cht.Element("CHWithholdingTaxRate") ?? String.Empty
                                                                 },
                                                     InstrumentIds = from Iid in ins.Descendants("InstrumentId")
                                                                     where Iid.Parent.Parent.Name.LocalName == "Instrument"
                                                                     select new InstrumentId
                                                                     {
                                                                         IdSchemeCode = (string)Iid.Element("IdSchemeCode") ?? String.Empty,
                                                                         IdValue = (string)Iid.Element("IdValue") ?? String.Empty
                                                                     },
                                                     Underlyings = from uls in ins.Descendants("Underlying")
                                                                   select new Underlying
                                                                   {
                                                                       UnderlyingKey = (string)uls.Element("UnderlyingKey") ?? String.Empty,
                                                                       PrincipalFlag = (string)uls.Element("PrincipalFlag") ?? String.Empty,
                                                                       IncomeFlag = (string)uls.Element("IncomeFlag") ?? String.Empty,
                                                                       PaymentLegFlag = (string)uls.Element("PaymentLegFlag") ?? String.Empty,
                                                                       UnderlyingRoleType = (string)uls.Element("UnderlyingRoleType") ?? String.Empty,
                                                                       UnderlyingQuotedPriceType = (string)uls.Element("UnderlyingQuotedPriceType") ?? String.Empty,
                                                                       QuotedCurrencyCode = (string)uls.Element("QuotedCurrencyCode") ?? String.Empty,
                                                                       UnderlyingAssetType = (string)uls.Element("UnderlyingAssetType") ?? String.Empty,
                                                                       RolloverFlag = (string)uls.Element("RolloverFlag") ?? String.Empty,
                                                                       UnderlyingExchangeCode = (string)uls.Element("UnderlyingExchangeCode") ?? String.Empty,
                                                                       InitialReferencePrice = (string)uls.Element("InitialReferencePrice") ?? String.Empty,
                                                                       UnderlyingCoverRatio = (string)uls.Element("UnderlyingCoverRatio") ?? String.Empty,
                                                                       CurrentWeight = (string)uls.Element("CurrentWeight") ?? String.Empty,
                                                                       CurrencyPairSymbol = (string)uls.Element("CurrencyPairSymbol") ?? String.Empty,
                                                                       CurrencyPairSpotRate = (string)uls.Element("CurrencyPairSourcePage") ?? String.Empty,
                                                                       CurrencyPairSourcePage = (string)uls.Element("CurrencyPairSourcePage") ?? String.Empty,
                                                                       UnderlyingPriceFeedType = (string)uls.Element("UnderlyingPriceFeedType") ?? String.Empty,
                                                                       UnderlyingPriceSourcePage = (string)uls.Element("UnderlyingPriceSourcePage") ?? String.Empty,
                                                                       InstrumentIds = from Iid in uls.Descendants("InstrumentId")
                                                                                       select new InstrumentId
                                                                                       {
                                                                                           IdSchemeCode = (string)Iid.Element("IdSchemeCode") ?? String.Empty,
                                                                                           IdValue = (string)Iid.Element("IdValue") ?? String.Empty
                                                                                       }
                                                                   },
                                                     Payments = from pymt in ins.Descendants("Payment")
                                                                select new Payment
                                                                {
                                                                    PaymentType = (string)pymt.Element("PaymentType") ?? String.Empty,
                                                                    DependUnderlyingRoleType = (string)pymt.Element("DependUnderlyingRoleType") ?? String.Empty,
                                                                    PaymentValueDays = (string)pymt.Element("PaymentValueDays") ?? String.Empty,
                                                                    PaymentValueDaysType = (string)pymt.Element("PaymentValueDaysType") ?? String.Empty,
                                                                    SettlementType = (string)pymt.Element("SettlementType") ?? String.Empty,
                                                                    FractionMgmtType = (string)pymt.Element("FractionMgmtType") ?? String.Empty,
                                                                    PaymentFixingDayPriceType = (string)pymt.Element("PaymentFixingDayPriceType") ?? String.Empty,
                                                                    StrikeDefinitions = from sds in pymt.Descendants("StrikeDefinition")
                                                                                        select new StrikeDefinition
                                                                                        {
                                                                                            StrikeDefinitionKey = (string)sds.Element("StrikeDefinitionKey") ?? String.Empty,
                                                                                            StrikeType = (string)sds.Element("StrikeType") ?? String.Empty,
                                                                                            StrikeComparatorType = (string)sds.Element("StrikeComparatorType") ?? String.Empty,
                                                                                            UnderlyingSelectionType = (string)sds.Element("UnderlyingSelectionType") ?? String.Empty,
                                                                                            UnderlyingValuationType = (string)sds.Element("UnderlyingValuationType") ?? String.Empty,
                                                                                            ExerciseDate = (string)sds.Element("ExerciseDate") ?? String.Empty,
                                                                                            MonitorPriceType = (string)sds.Element("MonitorPriceType") ?? String.Empty,
                                                                                            VariableStrikeFlag = (string)sds.Element("VariableStrikeFlag") ?? String.Empty,
                                                                                            StrikeDetails = from sd in pymt.Descendants("StrikeDetail")
                                                                                                            select new StrikeDetail
                                                                                                            {
                                                                                                                UnderlyingKey = (string)sd.Element("UnderlyingKey") ?? String.Empty,
                                                                                                                StrikeLevel = (string)sd.Element("StrikeLevel") ?? String.Empty,
                                                                                                                StrikeCurrencyCode = (string)sd.Element("StrikeCurrencyCode") ?? String.Empty,
                                                                                                                StrikeFixingDate = (string)sd.Element("StrikeFixingDate") ?? String.Empty,
                                                                                                            }
                                                                                        },
                                                                    BarrierDefinitions = from bdf in pymt.Descendants("BarrierDefinition")
                                                                                         select new BarrierDefinition
                                                                                         {
                                                                                             BarrierType = (string)bdf.Element("BarrierType") ?? String.Empty,
                                                                                             ComparatorType = (string)bdf.Element("ComparatorType") ?? String.Empty,
                                                                                             QuantifierType = (string)bdf.Element("QuantifierType") ?? String.Empty,
                                                                                             QuantifierCount = (string)bdf.Element("QuantifierCount") ?? String.Empty,
                                                                                             UnderlyingSelectionType = (string)bdf.Element("UnderlyingSelectionType") ?? String.Empty,
                                                                                             UnderlyingValuationType = (string)bdf.Element("UnderlyingValuationType") ?? String.Empty,
                                                                                             MonitorPriceType = (string)bdf.Element("MonitorPriceType") ?? String.Empty,
                                                                                             ObservationBeginDate = (string)bdf.Element("ObservationBeginDate") ?? String.Empty,
                                                                                             VariableBarrierFlag = (string)bdf.Element("VariableBarrierFlag") ?? String.Empty,
                                                                                             BarrierEventValueDays = (string)bdf.Element("BarrierEventValueDays") ?? String.Empty,
                                                                                             BarrierEventValueDaysType = (string)bdf.Element("BarrierEventValueDaysType") ?? String.Empty,
                                                                                             BarrierDetails = from bd in bdf.Descendants("BarrierDetail")
                                                                                                              select new BarrierDetail
                                                                                                              {
                                                                                                                  UnderlyingKey = (string)bdf.Element("UnderlyingKey") ?? String.Empty,
                                                                                                                  BarrierLevel = (string)bdf.Element("BarrierLevel") ?? String.Empty,
                                                                                                                  BarrierCurrencyCode = (string)bdf.Element("BarrierCurrencyCode") ?? String.Empty
                                                                                                              }
                                                                                         },
                                                                    MaturityRetractionProlongations = from mrp in pymt.Descendants("MaturityRetractionProlongation")
                                                                                                      select new MaturityRetractionProlongation
                                                                                                      {
                                                                                                          RedemptionReasonType = (string)mrp.Element("RedemptionReasonType") ?? String.Empty,
                                                                                                          RedemptionBeginDate = (string)mrp.Element("RedemptionBeginDate") ?? String.Empty,
                                                                                                          PaymentCurrencyCode = (string)mrp.Element("PaymentCurrencyCode") ?? String.Empty,
                                                                                                          NoticePeriod = (string)mrp.Element("NoticePeriod") ?? String.Empty,
                                                                                                          NoticePeriodType = (string)mrp.Element("NoticePeriodType") ?? String.Empty,
                                                                                                          RedemptionInterval = (string)mrp.Element("RedemptionInterval") ?? String.Empty,
                                                                                                          RedemptionIntervalType = (string)mrp.Element("RedemptionIntervalType") ?? String.Empty
                                                                                                      }

                                                                },
                                                     TradingVenues = from tv in ins.Descendants("TradingVenue")
                                                                     select new TradingVenue
                                                                     {
                                                                         TradingExchangeCode = (string)tv.Element("TradingExchangeCode") ?? String.Empty,
                                                                         TradingCurrencyCode = (string)tv.Element("TradingCurrencyCode") ?? String.Empty,
                                                                         ContributorPriceSourcePage = (string)tv.Element("ContributorPriceSourcePage") ?? String.Empty,
                                                                         FirstTradingDate = (string)tv.Element("FirstTradingDate") ?? String.Empty,
                                                                         TradingSymbol = (string)tv.Element("TradingSymbol") ?? String.Empty,
                                                                         SmallestTradeableUnit = (string)tv.Element("SmallestTradeableUnit") ?? String.Empty
                                                                     },
                                                     Parties = from pty in ins.Descendants("Party")
                                                               select new Party
                                                               {
                                                                   PartyType = (string)pty.Element("PartyType") ?? String.Empty,
                                                                   TKPartyKey = (string)pty.Element("TKPartyKey") ?? String.Empty,
                                                                   SISPartyBPId = (string)pty.Element("SISPartyBPId") ?? String.Empty,
                                                                   BBCompanyId = (string)pty.Element("BBCompanyId") ?? String.Empty,
                                                                   PartyName = (string)pty.Element("PartyName") ?? String.Empty,
                                                                   PartyAreaCode = (string)pty.Element("PartyAreaCode") ?? String.Empty,
                                                                   PartyLocation = (string)pty.Element("PartyLocation") ?? String.Empty,
                                                                   GuaranteeType = (string)pty.Element("GuaranteeType") ?? String.Empty,
                                                                   CertificationType = (string)pty.Element("CertificationType") ?? String.Empty,
                                                                   CustodyType = (string)pty.Element("CustodyType") ?? String.Empty
                                                               },
                                                     TransactionRestrictions = from trs in ins.Descendants("TransactionRestriction")
                                                                               select new TransactionRestriction
                                                                               {
                                                                                   RestrictionAreaCode = (string)trs.Element("RestrictionAreaCode") ?? String.Empty,
                                                                                   RestrictionBeginDate = (string)trs.Element("RestrictionBeginDate") ?? String.Empty
                                                                               },



                                                 };


            objIBTTermSheet.AdminData = adminData;
            objIBTTermSheet.Events = events;
            objIBTTermSheet.Contacts = contacts;
            objIBTTermSheet.ServiceData = serviceData;
            objIBTTermSheet.Instrument = instrument;
            return objIBTTermSheet;
        }
    }
}
