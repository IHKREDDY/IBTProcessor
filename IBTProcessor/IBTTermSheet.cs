using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace IBTProcessor
{
 
        public class AdminData
        {

            public string SubmitterInternalReference { get; set; }
            public string DefinitiveTermsFlag { get; set; }
            public string EffectiveFromDate { get; set; }
        }

        public class Evnt
        {
            public string EventType { get; set; }
        }

        public class Events
        {
           public List<Evnt>  Event { get; set; }
     }

        public class Contact
        {
            public string ContactType { get; set; }
            public string ContactName { get; set; }
            public string TelephoneNo { get; set; }
            public string FaxNo { get; set; }
            public string EmailAddress { get; set; }
        }

        public class Contacts
        {
            public List<Contact> Contact { get; set; }
        }

        public class RequestedServiceOffering
        {
            public string RequestedServiceOfferingType { get; set; }
        }

        public class RequestedServiceOfferings
        {
            public List<RequestedServiceOffering> RequestedServiceOffering { get; set; }
        }

        public class SWXData
        {
            public string WarrantType { get; set; }
            public string UnderlyingDescription { get; set; }
            public string ExercisePrice { get; set; }
            public string ExerciseCurrencyCode { get; set; }
            public string IssueExchangeRate { get; set; }
            public string DesignatedMarketMaker { get; set; }
            public string ShareholderOptionFlag { get; set; }
        }


        public class SISData
        {
            public string DeliveryPromiseFlag { get; set; }
            public string SafeCustodyAccountNumber { get; set; }
        }

        public class ServiceData
        {
             public IEnumerable<RequestedServiceOffering> RequestedServiceOfferings { get; set; }
             public IEnumerable<SWXData> SWXData { get; set; }
             public IEnumerable<SISData> SISData { get; set; }
        }

        public class InstrumentClassification
        {
            public string ClassificationSchemeType { get; set; }
            public string ClassificationValue { get; set; }
        }


        public class CHTaxData
        {
            public string CHIssueStampTaxFlag { get; set; }
            public string StampTaxFeedbackFlag { get; set; }
            public string CHWithholdingTaxRate { get; set; }
        }

        public class InstrumentId
        {
            public string IdSchemeCode { get; set; }
            public string IdValue { get; set; }
        }

        public class InstrumentIds
        {
            public List<InstrumentId> InstrumentId { get; set; }
            public BloombergInstrumentId BloombergInstrumentId { get; set; }
        }

        public class BloombergInstrumentId
        {
            public string BBTickerSymbol { get; set; }
            public string BBMarketSectorCode { get; set; }
        }

        public class Underlying
        {
            public string UnderlyingKey { get; set; }
            public string PrincipalFlag { get; set; }
            public string IncomeFlag { get; set; }
            public string PaymentLegFlag { get; set; }
            public string UnderlyingRoleType { get; set; }
            public string UnderlyingQuotedPriceType { get; set; }
            public string QuotedCurrencyCode { get; set; }
            public string UnderlyingAssetType { get; set; }
            public string RolloverFlag { get; set; }
            public string UnderlyingExchangeCode { get; set; }
            public string InitialReferencePrice { get; set; }
            public string UnderlyingCoverRatio { get; set; }
            public string CurrentWeight { get; set; }
            public string CurrencyPairSymbol { get; set; }
            public string CurrencyPairSpotRate { get; set; }
            public string CurrencyPairSourcePage { get; set; }
            public string UnderlyingPriceFeedType { get; set; }
            public string UnderlyingPriceSourcePage { get; set; }
            public IEnumerable<InstrumentId> InstrumentIds { get; set; }
        }

        public class Underlyings
        {
            public Underlying Underlying { get; set; }
        }

        public class StrikeDetail
        {
            public string UnderlyingKey { get; set; }
            public string StrikeLevel { get; set; }
            public string StrikeCurrencyCode { get; set; }
            public string StrikeFixingDate { get; set; }
        }

        public class StrikeDetails
        {
            public StrikeDetail StrikeDetail { get; set; }
        }

        public class StrikeDefinition
        {
            public string StrikeDefinitionKey { get; set; }
            public string StrikeType { get; set; }
            public string StrikeComparatorType { get; set; }
            public string UnderlyingSelectionType { get; set; }
            public string UnderlyingValuationType { get; set; }
            public string ExerciseDate { get; set; }
            public string MonitorPriceType { get; set; }
            public string VariableStrikeFlag { get; set; }
            public IEnumerable<StrikeDetail> StrikeDetails { get; set; }
        }


        public class BarrierDetail
        {
            public string UnderlyingKey { get; set; }
            public string BarrierLevel { get; set; }
            public string BarrierCurrencyCode { get; set; }
        }

        public class BarrierDefinition
        {
            public string BarrierType { get; set; }
            public string ComparatorType { get; set; }
            public string QuantifierType { get; set; }
            public string QuantifierCount { get; set; }
            public string UnderlyingSelectionType { get; set; }
            public string UnderlyingValuationType { get; set; }
            public string MonitorPriceType { get; set; }
            public string ObservationBeginDate { get; set; }
            public string VariableBarrierFlag { get; set; }
            public string BarrierEventValueDays { get; set; }
            public string BarrierEventValueDaysType { get; set; }
            public IEnumerable<BarrierDetail> BarrierDetails { get; set; }
        }


        public class MaturityRetractionProlongation
        {
            public string RedemptionReasonType { get; set; }
            public string RedemptionBeginDate { get; set; }
            public string PaymentCurrencyCode { get; set; }
            public string NoticePeriod { get; set; }
            public string NoticePeriodType { get; set; }
            public string RedemptionInterval { get; set; }
            public string RedemptionIntervalType { get; set; }
        }


        public class Payment
        {
            public string PaymentType { get; set; }
            public string DependUnderlyingRoleType { get; set; }
            public string PaymentValueDays { get; set; }
            public string PaymentValueDaysType { get; set; }
            public string SettlementType { get; set; }
            public string FractionMgmtType { get; set; }
            public string PaymentFixingDayPriceType { get; set; }
            public IEnumerable<StrikeDefinition> StrikeDefinitions { get; set; }
            public IEnumerable<BarrierDefinition> BarrierDefinitions { get; set; }
            public IEnumerable<MaturityRetractionProlongation> MaturityRetractionProlongations { get; set; }
        }

        public class Payments
        {
            public Payment Payment { get; set; }
        }

        public class TradingVenue
        {
            public string TradingExchangeCode { get; set; }
            public string TradingCurrencyCode { get; set; }
            public string ContributorPriceSourcePage { get; set; }
            public string FirstTradingDate { get; set; }
            public string TradingSymbol { get; set; }
            public string SmallestTradeableUnit { get; set; }
        }


        public class Party
        {
            public string PartyType { get; set; }
            public string TKPartyKey { get; set; }
            public string SISPartyBPId { get; set; }
            public string BBCompanyId { get; set; }
            public string PartyName { get; set; }
            public string PartyAreaCode { get; set; }
            public string PartyLocation { get; set; }
            public string GuaranteeType { get; set; }
            public string CertificationType { get; set; }
            public string CustodyType { get; set; }
        }



        public class TransactionRestriction
        {
            public string RestrictionAreaCode { get; set; }
            public string RestrictionBeginDate { get; set; }
        }



        public class Instrument
        {
            public string ProductDescriptionURL { get; set; }
            public string ProductNameFull { get; set; }
            public string ProductBrand { get; set; }
            public string IBTTypeCode { get; set; }
            public string CollateralisationType { get; set; }
            public string PrivatePlacementFlag { get; set; }
            public string IssueCurrencyCode { get; set; }
            public string QuantoFlag { get; set; }
            public string IssuePrice { get; set; }
            public string InstrumentQuotationType { get; set; }
            public string IssueCapitalisation { get; set; }
            public string IssueIncreaseFlag { get; set; }
            public string NumberInIssue { get; set; }
            public string OpenEndFlag { get; set; }
            public string InvestorPutabilityFlag { get; set; }
            public string IssuerCallabilityFlag { get; set; }
            public string IssuerProlongationFlag { get; set; }
            public string AmortisableFlag { get; set; }
            public string MainUnderlyingAssetType { get; set; }
            public string UnderlyingMgmtType { get; set; }
            public string IssueDate { get; set; }
            public string PaymentDate { get; set; }
            public string InitialFixingDateType { get; set; }
            public string InitialFixingDate { get; set; }
            public string InitialFixingDayPriceType { get; set; }
            public string InitialFixingTime { get; set; }
            public string LegalSecurityType { get; set; }
            public string SecurityRankingType { get; set; }
            public string JurisdictionAreaCode { get; set; }
            public string LegalVenue { get; set; }
            public IEnumerable<InstrumentClassification> InstrumentClassifications { get; set; }
            public IEnumerable<CHTaxData> CHTaxData { get; set; }
            public IEnumerable<InstrumentId> InstrumentIds { get; set; }
            public IEnumerable<Underlying> Underlyings { get; set; }
            public IEnumerable<Payment> Payments { get; set; }
            public IEnumerable<TradingVenue> TradingVenues { get; set; }
            public IEnumerable<Party> Parties { get; set; }
            public IEnumerable<TransactionRestriction> TransactionRestrictions { get; set; }
        }


        public class IBTTermSheet
        {
            public IEnumerable<AdminData> AdminData { get; set; }
            public IEnumerable<Evnt> Events { get; set; }
            public IEnumerable<Contact> Contacts { get; set; }
            public IEnumerable<ServiceData> ServiceData { get; set; }
            public IEnumerable<Instrument> Instrument { get; set; }
        }


}
