using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace IBTProcessor
{
    class IBTTermSheetData
    {
        [XmlRoot(ElementName = "AdminData")]
        public class AdminData
        {
            [XmlElement(ElementName = "SubmitterInternalReference")]
            public string SubmitterInternalReference { get; set; }
            [XmlElement(ElementName = "DefinitiveTermsFlag")]
            public string DefinitiveTermsFlag { get; set; }
            [XmlElement(ElementName = "EffectiveFromDate")]
            public string EffectiveFromDate { get; set; }
        }

        [XmlRoot(ElementName = "Event")]
        public class Event
        {
            [XmlElement(ElementName = "EventType")]
            public string EventType { get; set; }
        }

        [XmlRoot(ElementName = "Events")]
        public class Events
        {
            [XmlElement(ElementName = "Event")]
            public Event Event { get; set; }
        }

        [XmlRoot(ElementName = "Contact")]
        public class Contact
        {
            [XmlElement(ElementName = "ContactType")]
            public string ContactType { get; set; }
            [XmlElement(ElementName = "ContactName")]
            public string ContactName { get; set; }
            [XmlElement(ElementName = "TelephoneNo")]
            public string TelephoneNo { get; set; }
            [XmlElement(ElementName = "FaxNo")]
            public string FaxNo { get; set; }
            [XmlElement(ElementName = "EmailAddress")]
            public string EmailAddress { get; set; }
        }

        [XmlRoot(ElementName = "Contacts")]
        public class Contacts
        {
            [XmlElement(ElementName = "Contact")]
            public List<Contact> Contact { get; set; }
        }

        [XmlRoot(ElementName = "RequestedServiceOffering")]
        public class RequestedServiceOffering
        {
            [XmlElement(ElementName = "RequestedServiceOfferingType")]
            public string RequestedServiceOfferingType { get; set; }
        }

        [XmlRoot(ElementName = "RequestedServiceOfferings")]
        public class RequestedServiceOfferings
        {
            [XmlElement(ElementName = "RequestedServiceOffering")]
            public List<RequestedServiceOffering> RequestedServiceOffering { get; set; }
        }

        [XmlRoot(ElementName = "SWXData")]
        public class SWXData
        {
            [XmlElement(ElementName = "WarrantType")]
            public string WarrantType { get; set; }
            [XmlElement(ElementName = "UnderlyingDescription")]
            public string UnderlyingDescription { get; set; }
            [XmlElement(ElementName = "ExercisePrice")]
            public string ExercisePrice { get; set; }
            [XmlElement(ElementName = "ExerciseCurrencyCode")]
            public string ExerciseCurrencyCode { get; set; }
            [XmlElement(ElementName = "IssueExchangeRate")]
            public string IssueExchangeRate { get; set; }
            [XmlElement(ElementName = "DesignatedMarketMaker")]
            public string DesignatedMarketMaker { get; set; }
            [XmlElement(ElementName = "ShareholderOptionFlag")]
            public string ShareholderOptionFlag { get; set; }
        }

        [XmlRoot(ElementName = "SISData")]
        public class SISData
        {
            [XmlElement(ElementName = "DeliveryPromiseFlag")]
            public string DeliveryPromiseFlag { get; set; }
            [XmlElement(ElementName = "SafeCustodyAccountNumber")]
            public string SafeCustodyAccountNumber { get; set; }
        }

        [XmlRoot(ElementName = "ServiceData")]
        public class ServiceData
        {
            [XmlElement(ElementName = "RequestedServiceOfferings")]
            public RequestedServiceOfferings RequestedServiceOfferings { get; set; }
            [XmlElement(ElementName = "SWXData")]
            public SWXData SWXData { get; set; }
            [XmlElement(ElementName = "SISData")]
            public SISData SISData { get; set; }
        }

        [XmlRoot(ElementName = "InstrumentClassification")]
        public class InstrumentClassification
        {
            [XmlElement(ElementName = "ClassificationSchemeType")]
            public string ClassificationSchemeType { get; set; }
            [XmlElement(ElementName = "ClassificationValue")]
            public string ClassificationValue { get; set; }
        }

        [XmlRoot(ElementName = "InstrumentClassifications")]
        public class InstrumentClassifications
        {
            [XmlElement(ElementName = "InstrumentClassification")]
            public List<InstrumentClassification> InstrumentClassification { get; set; }
        }

        [XmlRoot(ElementName = "CHTaxData")]
        public class CHTaxData
        {
            [XmlElement(ElementName = "CHIssueStampTaxFlag")]
            public string CHIssueStampTaxFlag { get; set; }
            [XmlElement(ElementName = "StampTaxFeedbackFlag")]
            public string StampTaxFeedbackFlag { get; set; }
            [XmlElement(ElementName = "CHWithholdingTaxRate")]
            public string CHWithholdingTaxRate { get; set; }
        }

        [XmlRoot(ElementName = "InstrumentId")]
        public class InstrumentId
        {
            [XmlElement(ElementName = "IdSchemeCode")]
            public string IdSchemeCode { get; set; }
            [XmlElement(ElementName = "IdValue")]
            public string IdValue { get; set; }
        }

        [XmlRoot(ElementName = "InstrumentIds")]
        public class InstrumentIds
        {
            [XmlElement(ElementName = "InstrumentId")]
            public List<InstrumentId> InstrumentId { get; set; }
            [XmlElement(ElementName = "BloombergInstrumentId")]
            public BloombergInstrumentId BloombergInstrumentId { get; set; }
        }

        [XmlRoot(ElementName = "BloombergInstrumentId")]
        public class BloombergInstrumentId
        {
            [XmlElement(ElementName = "BBTickerSymbol")]
            public string BBTickerSymbol { get; set; }
            [XmlElement(ElementName = "BBMarketSectorCode")]
            public string BBMarketSectorCode { get; set; }
        }

        [XmlRoot(ElementName = "Underlying")]
        public class Underlying
        {
            [XmlElement(ElementName = "UnderlyingKey")]
            public string UnderlyingKey { get; set; }
            [XmlElement(ElementName = "PrincipalFlag")]
            public string PrincipalFlag { get; set; }
            [XmlElement(ElementName = "IncomeFlag")]
            public string IncomeFlag { get; set; }
            [XmlElement(ElementName = "PaymentLegFlag")]
            public string PaymentLegFlag { get; set; }
            [XmlElement(ElementName = "UnderlyingRoleType")]
            public string UnderlyingRoleType { get; set; }
            [XmlElement(ElementName = "UnderlyingQuotedPriceType")]
            public string UnderlyingQuotedPriceType { get; set; }
            [XmlElement(ElementName = "QuotedCurrencyCode")]
            public string QuotedCurrencyCode { get; set; }
            [XmlElement(ElementName = "UnderlyingAssetType")]
            public string UnderlyingAssetType { get; set; }
            [XmlElement(ElementName = "RolloverFlag")]
            public string RolloverFlag { get; set; }
            [XmlElement(ElementName = "UnderlyingExchangeCode")]
            public string UnderlyingExchangeCode { get; set; }
            [XmlElement(ElementName = "InitialReferencePrice")]
            public string InitialReferencePrice { get; set; }
            [XmlElement(ElementName = "UnderlyingCoverRatio")]
            public string UnderlyingCoverRatio { get; set; }
            [XmlElement(ElementName = "CurrentWeight")]
            public string CurrentWeight { get; set; }
            [XmlElement(ElementName = "CurrencyPairSymbol")]
            public string CurrencyPairSymbol { get; set; }
            [XmlElement(ElementName = "CurrencyPairSpotRate")]
            public string CurrencyPairSpotRate { get; set; }
            [XmlElement(ElementName = "CurrencyPairSourcePage")]
            public string CurrencyPairSourcePage { get; set; }
            [XmlElement(ElementName = "UnderlyingPriceFeedType")]
            public string UnderlyingPriceFeedType { get; set; }
            [XmlElement(ElementName = "UnderlyingPriceSourcePage")]
            public string UnderlyingPriceSourcePage { get; set; }
            [XmlElement(ElementName = "InstrumentIds")]
            public InstrumentIds InstrumentIds { get; set; }
        }

        [XmlRoot(ElementName = "Underlyings")]
        public class Underlyings
        {
            [XmlElement(ElementName = "Underlying")]
            public Underlying Underlying { get; set; }
        }

        [XmlRoot(ElementName = "StrikeDetail")]
        public class StrikeDetail
        {
            [XmlElement(ElementName = "UnderlyingKey")]
            public string UnderlyingKey { get; set; }
            [XmlElement(ElementName = "StrikeLevel")]
            public string StrikeLevel { get; set; }
            [XmlElement(ElementName = "StrikeCurrencyCode")]
            public string StrikeCurrencyCode { get; set; }
            [XmlElement(ElementName = "StrikeFixingDate")]
            public string StrikeFixingDate { get; set; }
        }

        [XmlRoot(ElementName = "StrikeDetails")]
        public class StrikeDetails
        {
            [XmlElement(ElementName = "StrikeDetail")]
            public StrikeDetail StrikeDetail { get; set; }
        }

        [XmlRoot(ElementName = "StrikeDefinition")]
        public class StrikeDefinition
        {
            [XmlElement(ElementName = "StrikeDefinitionKey")]
            public string StrikeDefinitionKey { get; set; }
            [XmlElement(ElementName = "StrikeType")]
            public string StrikeType { get; set; }
            [XmlElement(ElementName = "StrikeComparatorType")]
            public string StrikeComparatorType { get; set; }
            [XmlElement(ElementName = "UnderlyingSelectionType")]
            public string UnderlyingSelectionType { get; set; }
            [XmlElement(ElementName = "UnderlyingValuationType")]
            public string UnderlyingValuationType { get; set; }
            [XmlElement(ElementName = "ExerciseDate")]
            public string ExerciseDate { get; set; }
            [XmlElement(ElementName = "MonitorPriceType")]
            public string MonitorPriceType { get; set; }
            [XmlElement(ElementName = "VariableStrikeFlag")]
            public string VariableStrikeFlag { get; set; }
            [XmlElement(ElementName = "StrikeDetails")]
            public StrikeDetails StrikeDetails { get; set; }
        }

        [XmlRoot(ElementName = "StrikeDefinitions")]
        public class StrikeDefinitions
        {
            [XmlElement(ElementName = "StrikeDefinition")]
            public StrikeDefinition StrikeDefinition { get; set; }
        }

        [XmlRoot(ElementName = "BarrierDetail")]
        public class BarrierDetail
        {
            [XmlElement(ElementName = "UnderlyingKey")]
            public string UnderlyingKey { get; set; }
            [XmlElement(ElementName = "BarrierLevel")]
            public string BarrierLevel { get; set; }
            [XmlElement(ElementName = "BarrierCurrencyCode")]
            public string BarrierCurrencyCode { get; set; }
        }

        [XmlRoot(ElementName = "BarrierDetails")]
        public class BarrierDetails
        {
            [XmlElement(ElementName = "BarrierDetail")]
            public BarrierDetail BarrierDetail { get; set; }
        }

        [XmlRoot(ElementName = "BarrierDefinition")]
        public class BarrierDefinition
        {
            [XmlElement(ElementName = "BarrierType")]
            public string BarrierType { get; set; }
            [XmlElement(ElementName = "ComparatorType")]
            public string ComparatorType { get; set; }
            [XmlElement(ElementName = "QuantifierType")]
            public string QuantifierType { get; set; }
            [XmlElement(ElementName = "QuantifierCount")]
            public string QuantifierCount { get; set; }
            [XmlElement(ElementName = "UnderlyingSelectionType")]
            public string UnderlyingSelectionType { get; set; }
            [XmlElement(ElementName = "UnderlyingValuationType")]
            public string UnderlyingValuationType { get; set; }
            [XmlElement(ElementName = "MonitorPriceType")]
            public string MonitorPriceType { get; set; }
            [XmlElement(ElementName = "ObservationBeginDate")]
            public string ObservationBeginDate { get; set; }
            [XmlElement(ElementName = "VariableBarrierFlag")]
            public string VariableBarrierFlag { get; set; }
            [XmlElement(ElementName = "BarrierEventValueDays")]
            public string BarrierEventValueDays { get; set; }
            [XmlElement(ElementName = "BarrierEventValueDaysType")]
            public string BarrierEventValueDaysType { get; set; }
            [XmlElement(ElementName = "BarrierDetails")]
            public BarrierDetails BarrierDetails { get; set; }
        }

        [XmlRoot(ElementName = "BarrierDefinitions")]
        public class BarrierDefinitions
        {
            [XmlElement(ElementName = "BarrierDefinition")]
            public BarrierDefinition BarrierDefinition { get; set; }
        }

        [XmlRoot(ElementName = "MaturityRetractionProlongation")]
        public class MaturityRetractionProlongation
        {
            [XmlElement(ElementName = "RedemptionReasonType")]
            public string RedemptionReasonType { get; set; }
            [XmlElement(ElementName = "RedemptionBeginDate")]
            public string RedemptionBeginDate { get; set; }
            [XmlElement(ElementName = "PaymentCurrencyCode")]
            public string PaymentCurrencyCode { get; set; }
            [XmlElement(ElementName = "NoticePeriod")]
            public string NoticePeriod { get; set; }
            [XmlElement(ElementName = "NoticePeriodType")]
            public string NoticePeriodType { get; set; }
            [XmlElement(ElementName = "RedemptionInterval")]
            public string RedemptionInterval { get; set; }
            [XmlElement(ElementName = "RedemptionIntervalType")]
            public string RedemptionIntervalType { get; set; }
        }

        [XmlRoot(ElementName = "MaturityRetractionProlongations")]
        public class MaturityRetractionProlongations
        {
            [XmlElement(ElementName = "MaturityRetractionProlongation")]
            public List<MaturityRetractionProlongation> MaturityRetractionProlongation { get; set; }
        }

        [XmlRoot(ElementName = "Payment")]
        public class Payment
        {
            [XmlElement(ElementName = "PaymentType")]
            public string PaymentType { get; set; }
            [XmlElement(ElementName = "DependUnderlyingRoleType")]
            public string DependUnderlyingRoleType { get; set; }
            [XmlElement(ElementName = "PaymentValueDays")]
            public string PaymentValueDays { get; set; }
            [XmlElement(ElementName = "PaymentValueDaysType")]
            public string PaymentValueDaysType { get; set; }
            [XmlElement(ElementName = "SettlementType")]
            public string SettlementType { get; set; }
            [XmlElement(ElementName = "FractionMgmtType")]
            public string FractionMgmtType { get; set; }
            [XmlElement(ElementName = "PaymentFixingDayPriceType")]
            public string PaymentFixingDayPriceType { get; set; }
            [XmlElement(ElementName = "StrikeDefinitions")]
            public StrikeDefinitions StrikeDefinitions { get; set; }
            [XmlElement(ElementName = "BarrierDefinitions")]
            public BarrierDefinitions BarrierDefinitions { get; set; }
            [XmlElement(ElementName = "MaturityRetractionProlongations")]
            public MaturityRetractionProlongations MaturityRetractionProlongations { get; set; }
        }

        [XmlRoot(ElementName = "Payments")]
        public class Payments
        {
            [XmlElement(ElementName = "Payment")]
            public Payment Payment { get; set; }
        }

        [XmlRoot(ElementName = "TradingVenue")]
        public class TradingVenue
        {
            [XmlElement(ElementName = "TradingExchangeCode")]
            public string TradingExchangeCode { get; set; }
            [XmlElement(ElementName = "TradingCurrencyCode")]
            public string TradingCurrencyCode { get; set; }
            [XmlElement(ElementName = "ContributorPriceSourcePage")]
            public string ContributorPriceSourcePage { get; set; }
            [XmlElement(ElementName = "FirstTradingDate")]
            public string FirstTradingDate { get; set; }
            [XmlElement(ElementName = "TradingSymbol")]
            public string TradingSymbol { get; set; }
            [XmlElement(ElementName = "SmallestTradeableUnit")]
            public string SmallestTradeableUnit { get; set; }
        }

        [XmlRoot(ElementName = "TradingVenues")]
        public class TradingVenues
        {
            [XmlElement(ElementName = "TradingVenue")]
            public List<TradingVenue> TradingVenue { get; set; }
        }

        [XmlRoot(ElementName = "Party")]
        public class Party
        {
            [XmlElement(ElementName = "PartyType")]
            public string PartyType { get; set; }
            [XmlElement(ElementName = "TKPartyKey")]
            public string TKPartyKey { get; set; }
            [XmlElement(ElementName = "SISPartyBPId")]
            public string SISPartyBPId { get; set; }
            [XmlElement(ElementName = "BBCompanyId")]
            public string BBCompanyId { get; set; }
            [XmlElement(ElementName = "PartyName")]
            public string PartyName { get; set; }
            [XmlElement(ElementName = "PartyAreaCode")]
            public string PartyAreaCode { get; set; }
            [XmlElement(ElementName = "PartyLocation")]
            public string PartyLocation { get; set; }
            [XmlElement(ElementName = "GuaranteeType")]
            public string GuaranteeType { get; set; }
            [XmlElement(ElementName = "CertificationType")]
            public string CertificationType { get; set; }
            [XmlElement(ElementName = "CustodyType")]
            public string CustodyType { get; set; }
        }

        [XmlRoot(ElementName = "Parties")]
        public class Parties
        {
            [XmlElement(ElementName = "Party")]
            public List<Party> Party { get; set; }
        }

        [XmlRoot(ElementName = "TransactionRestriction")]
        public class TransactionRestriction
        {
            [XmlElement(ElementName = "RestrictionAreaCode")]
            public string RestrictionAreaCode { get; set; }
            [XmlElement(ElementName = "RestrictionBeginDate")]
            public string RestrictionBeginDate { get; set; }
        }

        [XmlRoot(ElementName = "TransactionRestrictions")]
        public class TransactionRestrictions
        {
            [XmlElement(ElementName = "TransactionRestriction")]
            public List<TransactionRestriction> TransactionRestriction { get; set; }
        }

        [XmlRoot(ElementName = "Instrument")]
        public class Instrument
        {
            [XmlElement(ElementName = "ProductDescriptionURL")]
            public string ProductDescriptionURL { get; set; }
            [XmlElement(ElementName = "ProductNameFull")]
            public string ProductNameFull { get; set; }
            [XmlElement(ElementName = "ProductBrand")]
            public string ProductBrand { get; set; }
            [XmlElement(ElementName = "IBTTypeCode")]
            public string IBTTypeCode { get; set; }
            [XmlElement(ElementName = "CollateralisationType")]
            public string CollateralisationType { get; set; }
            [XmlElement(ElementName = "PrivatePlacementFlag")]
            public string PrivatePlacementFlag { get; set; }
            [XmlElement(ElementName = "IssueCurrencyCode")]
            public string IssueCurrencyCode { get; set; }
            [XmlElement(ElementName = "QuantoFlag")]
            public string QuantoFlag { get; set; }
            [XmlElement(ElementName = "IssuePrice")]
            public string IssuePrice { get; set; }
            [XmlElement(ElementName = "InstrumentQuotationType")]
            public string InstrumentQuotationType { get; set; }
            [XmlElement(ElementName = "IssueCapitalisation")]
            public string IssueCapitalisation { get; set; }
            [XmlElement(ElementName = "IssueIncreaseFlag")]
            public string IssueIncreaseFlag { get; set; }
            [XmlElement(ElementName = "NumberInIssue")]
            public string NumberInIssue { get; set; }
            [XmlElement(ElementName = "OpenEndFlag")]
            public string OpenEndFlag { get; set; }
            [XmlElement(ElementName = "InvestorPutabilityFlag")]
            public string InvestorPutabilityFlag { get; set; }
            [XmlElement(ElementName = "IssuerCallabilityFlag")]
            public string IssuerCallabilityFlag { get; set; }
            [XmlElement(ElementName = "IssuerProlongationFlag")]
            public string IssuerProlongationFlag { get; set; }
            [XmlElement(ElementName = "AmortisableFlag")]
            public string AmortisableFlag { get; set; }
            [XmlElement(ElementName = "MainUnderlyingAssetType")]
            public string MainUnderlyingAssetType { get; set; }
            [XmlElement(ElementName = "UnderlyingMgmtType")]
            public string UnderlyingMgmtType { get; set; }
            [XmlElement(ElementName = "IssueDate")]
            public string IssueDate { get; set; }
            [XmlElement(ElementName = "PaymentDate")]
            public string PaymentDate { get; set; }
            [XmlElement(ElementName = "InitialFixingDateType")]
            public string InitialFixingDateType { get; set; }
            [XmlElement(ElementName = "InitialFixingDate")]
            public string InitialFixingDate { get; set; }
            [XmlElement(ElementName = "InitialFixingDayPriceType")]
            public string InitialFixingDayPriceType { get; set; }
            [XmlElement(ElementName = "InitialFixingTime")]
            public string InitialFixingTime { get; set; }
            [XmlElement(ElementName = "LegalSecurityType")]
            public string LegalSecurityType { get; set; }
            [XmlElement(ElementName = "SecurityRankingType")]
            public string SecurityRankingType { get; set; }
            [XmlElement(ElementName = "JurisdictionAreaCode")]
            public string JurisdictionAreaCode { get; set; }
            [XmlElement(ElementName = "LegalVenue")]
            public string LegalVenue { get; set; }
            [XmlElement(ElementName = "InstrumentClassifications")]
            public InstrumentClassifications InstrumentClassifications { get; set; }
            [XmlElement(ElementName = "CHTaxData")]
            public CHTaxData CHTaxData { get; set; }
            [XmlElement(ElementName = "InstrumentIds")]
            public InstrumentIds InstrumentIds { get; set; }
            [XmlElement(ElementName = "Underlyings")]
            public Underlyings Underlyings { get; set; }
            [XmlElement(ElementName = "Payments")]
            public Payments Payments { get; set; }
            [XmlElement(ElementName = "TradingVenues")]
            public TradingVenues TradingVenues { get; set; }
            [XmlElement(ElementName = "Parties")]
            public Parties Parties { get; set; }
            [XmlElement(ElementName = "TransactionRestrictions")]
            public TransactionRestrictions TransactionRestrictions { get; set; }
        }

        [XmlRoot(ElementName = "IBTTermSheet")]
        public class IBTTermSheet
        {
            [XmlElement(ElementName = "AdminData")]
            public AdminData AdminData { get; set; }
            [XmlElement(ElementName = "Events")]
            public Events Events { get; set; }
            [XmlElement(ElementName = "Contacts")]
            public Contacts Contacts { get; set; }
            [XmlElement(ElementName = "ServiceData")]
            public ServiceData ServiceData { get; set; }
            [XmlElement(ElementName = "Instrument")]
            public Instrument Instrument { get; set; }
        }

    }
}
