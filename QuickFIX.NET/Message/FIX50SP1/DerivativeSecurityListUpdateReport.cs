// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1 
    {
        public class DerivativeSecurityListUpdateReport : Message
        {
            public const string MsgType = "BR";

            public DerivativeSecurityListUpdateReport() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("BR"));
            }


            public QuickFix.Fields.SecurityReqID securityReqID
            { 
                get 
                {
                    QuickFix.Fields.SecurityReqID val = new QuickFix.Fields.SecurityReqID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityReqID val) 
            { 
                this.securityReqID = val;
            }
            
            public QuickFix.Fields.SecurityReqID get(QuickFix.Fields.SecurityReqID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityReqID val) 
            { 
                return isSetSecurityReqID();
            }
            
            public bool isSetSecurityReqID() 
            { 
                return isSetField(Tags.SecurityReqID);
            }
            public QuickFix.Fields.SecurityResponseID securityResponseID
            { 
                get 
                {
                    QuickFix.Fields.SecurityResponseID val = new QuickFix.Fields.SecurityResponseID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityResponseID val) 
            { 
                this.securityResponseID = val;
            }
            
            public QuickFix.Fields.SecurityResponseID get(QuickFix.Fields.SecurityResponseID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityResponseID val) 
            { 
                return isSetSecurityResponseID();
            }
            
            public bool isSetSecurityResponseID() 
            { 
                return isSetField(Tags.SecurityResponseID);
            }
            public QuickFix.Fields.SecurityRequestResult securityRequestResult
            { 
                get 
                {
                    QuickFix.Fields.SecurityRequestResult val = new QuickFix.Fields.SecurityRequestResult();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityRequestResult val) 
            { 
                this.securityRequestResult = val;
            }
            
            public QuickFix.Fields.SecurityRequestResult get(QuickFix.Fields.SecurityRequestResult val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityRequestResult val) 
            { 
                return isSetSecurityRequestResult();
            }
            
            public bool isSetSecurityRequestResult() 
            { 
                return isSetField(Tags.SecurityRequestResult);
            }
            public QuickFix.Fields.SecurityUpdateAction securityUpdateAction
            { 
                get 
                {
                    QuickFix.Fields.SecurityUpdateAction val = new QuickFix.Fields.SecurityUpdateAction();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                this.securityUpdateAction = val;
            }
            
            public QuickFix.Fields.SecurityUpdateAction get(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityUpdateAction val) 
            { 
                return isSetSecurityUpdateAction();
            }
            
            public bool isSetSecurityUpdateAction() 
            { 
                return isSetField(Tags.SecurityUpdateAction);
            }
            public QuickFix.Fields.UnderlyingSymbol underlyingSymbol
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                this.underlyingSymbol = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbol get(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSymbol val) 
            { 
                return isSetUnderlyingSymbol();
            }
            
            public bool isSetUnderlyingSymbol() 
            { 
                return isSetField(Tags.UnderlyingSymbol);
            }
            public QuickFix.Fields.UnderlyingSymbolSfx underlyingSymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                this.underlyingSymbolSfx = val;
            }
            
            public QuickFix.Fields.UnderlyingSymbolSfx get(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSymbolSfx val) 
            { 
                return isSetUnderlyingSymbolSfx();
            }
            
            public bool isSetUnderlyingSymbolSfx() 
            { 
                return isSetField(Tags.UnderlyingSymbolSfx);
            }
            public QuickFix.Fields.UnderlyingSecurityID underlyingSecurityID
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                this.underlyingSecurityID = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityID get(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityID val) 
            { 
                return isSetUnderlyingSecurityID();
            }
            
            public bool isSetUnderlyingSecurityID() 
            { 
                return isSetField(Tags.UnderlyingSecurityID);
            }
            public QuickFix.Fields.UnderlyingSecurityIDSource underlyingSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                this.underlyingSecurityIDSource = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityIDSource get(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityIDSource val) 
            { 
                return isSetUnderlyingSecurityIDSource();
            }
            
            public bool isSetUnderlyingSecurityIDSource() 
            { 
                return isSetField(Tags.UnderlyingSecurityIDSource);
            }
            public QuickFix.Fields.NoUnderlyingSecurityAltID noUnderlyingSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                this.noUnderlyingSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoUnderlyingSecurityAltID get(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) 
            { 
                return isSetNoUnderlyingSecurityAltID();
            }
            
            public bool isSetNoUnderlyingSecurityAltID() 
            { 
                return isSetField(Tags.NoUnderlyingSecurityAltID);
            }
            public QuickFix.Fields.UnderlyingProduct underlyingProduct
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingProduct val) 
            { 
                this.underlyingProduct = val;
            }
            
            public QuickFix.Fields.UnderlyingProduct get(QuickFix.Fields.UnderlyingProduct val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingProduct val) 
            { 
                return isSetUnderlyingProduct();
            }
            
            public bool isSetUnderlyingProduct() 
            { 
                return isSetField(Tags.UnderlyingProduct);
            }
            public QuickFix.Fields.UnderlyingCFICode underlyingCFICode
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                this.underlyingCFICode = val;
            }
            
            public QuickFix.Fields.UnderlyingCFICode get(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCFICode val) 
            { 
                return isSetUnderlyingCFICode();
            }
            
            public bool isSetUnderlyingCFICode() 
            { 
                return isSetField(Tags.UnderlyingCFICode);
            }
            public QuickFix.Fields.UnderlyingSecurityType underlyingSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                this.underlyingSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityType get(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityType val) 
            { 
                return isSetUnderlyingSecurityType();
            }
            
            public bool isSetUnderlyingSecurityType() 
            { 
                return isSetField(Tags.UnderlyingSecurityType);
            }
            public QuickFix.Fields.UnderlyingSecuritySubType underlyingSecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecuritySubType val = new QuickFix.Fields.UnderlyingSecuritySubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                this.underlyingSecuritySubType = val;
            }
            
            public QuickFix.Fields.UnderlyingSecuritySubType get(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecuritySubType val) 
            { 
                return isSetUnderlyingSecuritySubType();
            }
            
            public bool isSetUnderlyingSecuritySubType() 
            { 
                return isSetField(Tags.UnderlyingSecuritySubType);
            }
            public QuickFix.Fields.UnderlyingMaturityMonthYear underlyingMaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                this.underlyingMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityMonthYear get(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) 
            { 
                return isSetUnderlyingMaturityMonthYear();
            }
            
            public bool isSetUnderlyingMaturityMonthYear() 
            { 
                return isSetField(Tags.UnderlyingMaturityMonthYear);
            }
            public QuickFix.Fields.UnderlyingMaturityDate underlyingMaturityDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                this.underlyingMaturityDate = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityDate get(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityDate val) 
            { 
                return isSetUnderlyingMaturityDate();
            }
            
            public bool isSetUnderlyingMaturityDate() 
            { 
                return isSetField(Tags.UnderlyingMaturityDate);
            }
            public QuickFix.Fields.UnderlyingCouponPaymentDate underlyingCouponPaymentDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                this.underlyingCouponPaymentDate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponPaymentDate get(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) 
            { 
                return isSetUnderlyingCouponPaymentDate();
            }
            
            public bool isSetUnderlyingCouponPaymentDate() 
            { 
                return isSetField(Tags.UnderlyingCouponPaymentDate);
            }
            public QuickFix.Fields.UnderlyingIssueDate underlyingIssueDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                this.underlyingIssueDate = val;
            }
            
            public QuickFix.Fields.UnderlyingIssueDate get(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingIssueDate val) 
            { 
                return isSetUnderlyingIssueDate();
            }
            
            public bool isSetUnderlyingIssueDate() 
            { 
                return isSetField(Tags.UnderlyingIssueDate);
            }
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType underlyingRepoCollateralSecurityType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                this.underlyingRepoCollateralSecurityType = val;
            }
            
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) 
            { 
                return isSetUnderlyingRepoCollateralSecurityType();
            }
            
            public bool isSetUnderlyingRepoCollateralSecurityType() 
            { 
                return isSetField(Tags.UnderlyingRepoCollateralSecurityType);
            }
            public QuickFix.Fields.UnderlyingRepurchaseTerm underlyingRepurchaseTerm
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                this.underlyingRepurchaseTerm = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseTerm get(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) 
            { 
                return isSetUnderlyingRepurchaseTerm();
            }
            
            public bool isSetUnderlyingRepurchaseTerm() 
            { 
                return isSetField(Tags.UnderlyingRepurchaseTerm);
            }
            public QuickFix.Fields.UnderlyingRepurchaseRate underlyingRepurchaseRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                this.underlyingRepurchaseRate = val;
            }
            
            public QuickFix.Fields.UnderlyingRepurchaseRate get(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRepurchaseRate val) 
            { 
                return isSetUnderlyingRepurchaseRate();
            }
            
            public bool isSetUnderlyingRepurchaseRate() 
            { 
                return isSetField(Tags.UnderlyingRepurchaseRate);
            }
            public QuickFix.Fields.UnderlyingFactor underlyingFactor
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFactor val) 
            { 
                this.underlyingFactor = val;
            }
            
            public QuickFix.Fields.UnderlyingFactor get(QuickFix.Fields.UnderlyingFactor val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFactor val) 
            { 
                return isSetUnderlyingFactor();
            }
            
            public bool isSetUnderlyingFactor() 
            { 
                return isSetField(Tags.UnderlyingFactor);
            }
            public QuickFix.Fields.UnderlyingCreditRating underlyingCreditRating
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                this.underlyingCreditRating = val;
            }
            
            public QuickFix.Fields.UnderlyingCreditRating get(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCreditRating val) 
            { 
                return isSetUnderlyingCreditRating();
            }
            
            public bool isSetUnderlyingCreditRating() 
            { 
                return isSetField(Tags.UnderlyingCreditRating);
            }
            public QuickFix.Fields.UnderlyingInstrRegistry underlyingInstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                this.underlyingInstrRegistry = val;
            }
            
            public QuickFix.Fields.UnderlyingInstrRegistry get(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingInstrRegistry val) 
            { 
                return isSetUnderlyingInstrRegistry();
            }
            
            public bool isSetUnderlyingInstrRegistry() 
            { 
                return isSetField(Tags.UnderlyingInstrRegistry);
            }
            public QuickFix.Fields.UnderlyingCountryOfIssue underlyingCountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                this.underlyingCountryOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingCountryOfIssue get(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCountryOfIssue val) 
            { 
                return isSetUnderlyingCountryOfIssue();
            }
            
            public bool isSetUnderlyingCountryOfIssue() 
            { 
                return isSetField(Tags.UnderlyingCountryOfIssue);
            }
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue underlyingStateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                this.underlyingStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) 
            { 
                return isSetUnderlyingStateOrProvinceOfIssue();
            }
            
            public bool isSetUnderlyingStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.UnderlyingStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.UnderlyingLocaleOfIssue underlyingLocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                this.underlyingLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.UnderlyingLocaleOfIssue get(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) 
            { 
                return isSetUnderlyingLocaleOfIssue();
            }
            
            public bool isSetUnderlyingLocaleOfIssue() 
            { 
                return isSetField(Tags.UnderlyingLocaleOfIssue);
            }
            public QuickFix.Fields.UnderlyingRedemptionDate underlyingRedemptionDate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                this.underlyingRedemptionDate = val;
            }
            
            public QuickFix.Fields.UnderlyingRedemptionDate get(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingRedemptionDate val) 
            { 
                return isSetUnderlyingRedemptionDate();
            }
            
            public bool isSetUnderlyingRedemptionDate() 
            { 
                return isSetField(Tags.UnderlyingRedemptionDate);
            }
            public QuickFix.Fields.UnderlyingStrikePrice underlyingStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                this.underlyingStrikePrice = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikePrice get(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStrikePrice val) 
            { 
                return isSetUnderlyingStrikePrice();
            }
            
            public bool isSetUnderlyingStrikePrice() 
            { 
                return isSetField(Tags.UnderlyingStrikePrice);
            }
            public QuickFix.Fields.UnderlyingStrikeCurrency underlyingStrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStrikeCurrency val = new QuickFix.Fields.UnderlyingStrikeCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                this.underlyingStrikeCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingStrikeCurrency get(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStrikeCurrency val) 
            { 
                return isSetUnderlyingStrikeCurrency();
            }
            
            public bool isSetUnderlyingStrikeCurrency() 
            { 
                return isSetField(Tags.UnderlyingStrikeCurrency);
            }
            public QuickFix.Fields.UnderlyingOptAttribute underlyingOptAttribute
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                this.underlyingOptAttribute = val;
            }
            
            public QuickFix.Fields.UnderlyingOptAttribute get(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingOptAttribute val) 
            { 
                return isSetUnderlyingOptAttribute();
            }
            
            public bool isSetUnderlyingOptAttribute() 
            { 
                return isSetField(Tags.UnderlyingOptAttribute);
            }
            public QuickFix.Fields.UnderlyingContractMultiplier underlyingContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                this.underlyingContractMultiplier = val;
            }
            
            public QuickFix.Fields.UnderlyingContractMultiplier get(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingContractMultiplier val) 
            { 
                return isSetUnderlyingContractMultiplier();
            }
            
            public bool isSetUnderlyingContractMultiplier() 
            { 
                return isSetField(Tags.UnderlyingContractMultiplier);
            }
            public QuickFix.Fields.UnderlyingCouponRate underlyingCouponRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                this.underlyingCouponRate = val;
            }
            
            public QuickFix.Fields.UnderlyingCouponRate get(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCouponRate val) 
            { 
                return isSetUnderlyingCouponRate();
            }
            
            public bool isSetUnderlyingCouponRate() 
            { 
                return isSetField(Tags.UnderlyingCouponRate);
            }
            public QuickFix.Fields.UnderlyingSecurityExchange underlyingSecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                this.underlyingSecurityExchange = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityExchange get(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityExchange val) 
            { 
                return isSetUnderlyingSecurityExchange();
            }
            
            public bool isSetUnderlyingSecurityExchange() 
            { 
                return isSetField(Tags.UnderlyingSecurityExchange);
            }
            public QuickFix.Fields.UnderlyingIssuer underlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                this.underlyingIssuer = val;
            }
            
            public QuickFix.Fields.UnderlyingIssuer get(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingIssuer val) 
            { 
                return isSetUnderlyingIssuer();
            }
            
            public bool isSetUnderlyingIssuer() 
            { 
                return isSetField(Tags.UnderlyingIssuer);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuerLen encodedUnderlyingIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                this.encodedUnderlyingIssuerLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuerLen get(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) 
            { 
                return isSetEncodedUnderlyingIssuerLen();
            }
            
            public bool isSetEncodedUnderlyingIssuerLen() 
            { 
                return isSetField(Tags.EncodedUnderlyingIssuerLen);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuer encodedUnderlyingIssuer
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                this.encodedUnderlyingIssuer = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingIssuer get(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingIssuer val) 
            { 
                return isSetEncodedUnderlyingIssuer();
            }
            
            public bool isSetEncodedUnderlyingIssuer() 
            { 
                return isSetField(Tags.EncodedUnderlyingIssuer);
            }
            public QuickFix.Fields.UnderlyingSecurityDesc underlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                this.underlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.UnderlyingSecurityDesc get(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSecurityDesc val) 
            { 
                return isSetUnderlyingSecurityDesc();
            }
            
            public bool isSetUnderlyingSecurityDesc() 
            { 
                return isSetField(Tags.UnderlyingSecurityDesc);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen encodedUnderlyingSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                this.encodedUnderlyingSecurityDescLen = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) 
            { 
                return isSetEncodedUnderlyingSecurityDescLen();
            }
            
            public bool isSetEncodedUnderlyingSecurityDescLen() 
            { 
                return isSetField(Tags.EncodedUnderlyingSecurityDescLen);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc encodedUnderlyingSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                this.encodedUnderlyingSecurityDesc = val;
            }
            
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) 
            { 
                return isSetEncodedUnderlyingSecurityDesc();
            }
            
            public bool isSetEncodedUnderlyingSecurityDesc() 
            { 
                return isSetField(Tags.EncodedUnderlyingSecurityDesc);
            }
            public QuickFix.Fields.UnderlyingCPProgram underlyingCPProgram
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCPProgram val = new QuickFix.Fields.UnderlyingCPProgram();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                this.underlyingCPProgram = val;
            }
            
            public QuickFix.Fields.UnderlyingCPProgram get(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCPProgram val) 
            { 
                return isSetUnderlyingCPProgram();
            }
            
            public bool isSetUnderlyingCPProgram() 
            { 
                return isSetField(Tags.UnderlyingCPProgram);
            }
            public QuickFix.Fields.UnderlyingCPRegType underlyingCPRegType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCPRegType val = new QuickFix.Fields.UnderlyingCPRegType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                this.underlyingCPRegType = val;
            }
            
            public QuickFix.Fields.UnderlyingCPRegType get(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCPRegType val) 
            { 
                return isSetUnderlyingCPRegType();
            }
            
            public bool isSetUnderlyingCPRegType() 
            { 
                return isSetField(Tags.UnderlyingCPRegType);
            }
            public QuickFix.Fields.UnderlyingCurrency underlyingCurrency
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCurrency val = new QuickFix.Fields.UnderlyingCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                this.underlyingCurrency = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrency get(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCurrency val) 
            { 
                return isSetUnderlyingCurrency();
            }
            
            public bool isSetUnderlyingCurrency() 
            { 
                return isSetField(Tags.UnderlyingCurrency);
            }
            public QuickFix.Fields.UnderlyingQty underlyingQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingQty val = new QuickFix.Fields.UnderlyingQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingQty val) 
            { 
                this.underlyingQty = val;
            }
            
            public QuickFix.Fields.UnderlyingQty get(QuickFix.Fields.UnderlyingQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingQty val) 
            { 
                return isSetUnderlyingQty();
            }
            
            public bool isSetUnderlyingQty() 
            { 
                return isSetField(Tags.UnderlyingQty);
            }
            public QuickFix.Fields.UnderlyingPx underlyingPx
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPx val = new QuickFix.Fields.UnderlyingPx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPx val) 
            { 
                this.underlyingPx = val;
            }
            
            public QuickFix.Fields.UnderlyingPx get(QuickFix.Fields.UnderlyingPx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPx val) 
            { 
                return isSetUnderlyingPx();
            }
            
            public bool isSetUnderlyingPx() 
            { 
                return isSetField(Tags.UnderlyingPx);
            }
            public QuickFix.Fields.UnderlyingDirtyPrice underlyingDirtyPrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingDirtyPrice val = new QuickFix.Fields.UnderlyingDirtyPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                this.underlyingDirtyPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingDirtyPrice get(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingDirtyPrice val) 
            { 
                return isSetUnderlyingDirtyPrice();
            }
            
            public bool isSetUnderlyingDirtyPrice() 
            { 
                return isSetField(Tags.UnderlyingDirtyPrice);
            }
            public QuickFix.Fields.UnderlyingEndPrice underlyingEndPrice
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingEndPrice val = new QuickFix.Fields.UnderlyingEndPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                this.underlyingEndPrice = val;
            }
            
            public QuickFix.Fields.UnderlyingEndPrice get(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingEndPrice val) 
            { 
                return isSetUnderlyingEndPrice();
            }
            
            public bool isSetUnderlyingEndPrice() 
            { 
                return isSetField(Tags.UnderlyingEndPrice);
            }
            public QuickFix.Fields.UnderlyingStartValue underlyingStartValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingStartValue val = new QuickFix.Fields.UnderlyingStartValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                this.underlyingStartValue = val;
            }
            
            public QuickFix.Fields.UnderlyingStartValue get(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingStartValue val) 
            { 
                return isSetUnderlyingStartValue();
            }
            
            public bool isSetUnderlyingStartValue() 
            { 
                return isSetField(Tags.UnderlyingStartValue);
            }
            public QuickFix.Fields.UnderlyingCurrentValue underlyingCurrentValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCurrentValue val = new QuickFix.Fields.UnderlyingCurrentValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                this.underlyingCurrentValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCurrentValue get(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCurrentValue val) 
            { 
                return isSetUnderlyingCurrentValue();
            }
            
            public bool isSetUnderlyingCurrentValue() 
            { 
                return isSetField(Tags.UnderlyingCurrentValue);
            }
            public QuickFix.Fields.UnderlyingEndValue underlyingEndValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingEndValue val = new QuickFix.Fields.UnderlyingEndValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                this.underlyingEndValue = val;
            }
            
            public QuickFix.Fields.UnderlyingEndValue get(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingEndValue val) 
            { 
                return isSetUnderlyingEndValue();
            }
            
            public bool isSetUnderlyingEndValue() 
            { 
                return isSetField(Tags.UnderlyingEndValue);
            }
            public QuickFix.Fields.NoUnderlyingStips noUnderlyingStips
            { 
                get 
                {
                    QuickFix.Fields.NoUnderlyingStips val = new QuickFix.Fields.NoUnderlyingStips();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                this.noUnderlyingStips = val;
            }
            
            public QuickFix.Fields.NoUnderlyingStips get(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUnderlyingStips val) 
            { 
                return isSetNoUnderlyingStips();
            }
            
            public bool isSetNoUnderlyingStips() 
            { 
                return isSetField(Tags.NoUnderlyingStips);
            }
            public QuickFix.Fields.UnderlyingAllocationPercent underlyingAllocationPercent
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingAllocationPercent val = new QuickFix.Fields.UnderlyingAllocationPercent();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                this.underlyingAllocationPercent = val;
            }
            
            public QuickFix.Fields.UnderlyingAllocationPercent get(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingAllocationPercent val) 
            { 
                return isSetUnderlyingAllocationPercent();
            }
            
            public bool isSetUnderlyingAllocationPercent() 
            { 
                return isSetField(Tags.UnderlyingAllocationPercent);
            }
            public QuickFix.Fields.UnderlyingSettlementType underlyingSettlementType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSettlementType val = new QuickFix.Fields.UnderlyingSettlementType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                this.underlyingSettlementType = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlementType get(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSettlementType val) 
            { 
                return isSetUnderlyingSettlementType();
            }
            
            public bool isSetUnderlyingSettlementType() 
            { 
                return isSetField(Tags.UnderlyingSettlementType);
            }
            public QuickFix.Fields.UnderlyingCashAmount underlyingCashAmount
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCashAmount val = new QuickFix.Fields.UnderlyingCashAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                this.underlyingCashAmount = val;
            }
            
            public QuickFix.Fields.UnderlyingCashAmount get(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCashAmount val) 
            { 
                return isSetUnderlyingCashAmount();
            }
            
            public bool isSetUnderlyingCashAmount() 
            { 
                return isSetField(Tags.UnderlyingCashAmount);
            }
            public QuickFix.Fields.UnderlyingCashType underlyingCashType
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCashType val = new QuickFix.Fields.UnderlyingCashType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCashType val) 
            { 
                this.underlyingCashType = val;
            }
            
            public QuickFix.Fields.UnderlyingCashType get(QuickFix.Fields.UnderlyingCashType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCashType val) 
            { 
                return isSetUnderlyingCashType();
            }
            
            public bool isSetUnderlyingCashType() 
            { 
                return isSetField(Tags.UnderlyingCashType);
            }
            public QuickFix.Fields.UnderlyingUnitOfMeasure underlyingUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingUnitOfMeasure val = new QuickFix.Fields.UnderlyingUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                this.underlyingUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasure get(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasure val) 
            { 
                return isSetUnderlyingUnitOfMeasure();
            }
            
            public bool isSetUnderlyingUnitOfMeasure() 
            { 
                return isSetField(Tags.UnderlyingUnitOfMeasure);
            }
            public QuickFix.Fields.UnderlyingTimeUnit underlyingTimeUnit
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingTimeUnit val = new QuickFix.Fields.UnderlyingTimeUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                this.underlyingTimeUnit = val;
            }
            
            public QuickFix.Fields.UnderlyingTimeUnit get(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingTimeUnit val) 
            { 
                return isSetUnderlyingTimeUnit();
            }
            
            public bool isSetUnderlyingTimeUnit() 
            { 
                return isSetField(Tags.UnderlyingTimeUnit);
            }
            public QuickFix.Fields.UnderlyingCapValue underlyingCapValue
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingCapValue val = new QuickFix.Fields.UnderlyingCapValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                this.underlyingCapValue = val;
            }
            
            public QuickFix.Fields.UnderlyingCapValue get(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingCapValue val) 
            { 
                return isSetUnderlyingCapValue();
            }
            
            public bool isSetUnderlyingCapValue() 
            { 
                return isSetField(Tags.UnderlyingCapValue);
            }
            public QuickFix.Fields.NoUndlyInstrumentParties noUndlyInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoUndlyInstrumentParties val = new QuickFix.Fields.NoUndlyInstrumentParties();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                this.noUndlyInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoUndlyInstrumentParties get(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoUndlyInstrumentParties val) 
            { 
                return isSetNoUndlyInstrumentParties();
            }
            
            public bool isSetNoUndlyInstrumentParties() 
            { 
                return isSetField(Tags.NoUndlyInstrumentParties);
            }
            public QuickFix.Fields.UnderlyingSettlMethod underlyingSettlMethod
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingSettlMethod val = new QuickFix.Fields.UnderlyingSettlMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                this.underlyingSettlMethod = val;
            }
            
            public QuickFix.Fields.UnderlyingSettlMethod get(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingSettlMethod val) 
            { 
                return isSetUnderlyingSettlMethod();
            }
            
            public bool isSetUnderlyingSettlMethod() 
            { 
                return isSetField(Tags.UnderlyingSettlMethod);
            }
            public QuickFix.Fields.UnderlyingAdjustedQuantity underlyingAdjustedQuantity
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingAdjustedQuantity val = new QuickFix.Fields.UnderlyingAdjustedQuantity();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                this.underlyingAdjustedQuantity = val;
            }
            
            public QuickFix.Fields.UnderlyingAdjustedQuantity get(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingAdjustedQuantity val) 
            { 
                return isSetUnderlyingAdjustedQuantity();
            }
            
            public bool isSetUnderlyingAdjustedQuantity() 
            { 
                return isSetField(Tags.UnderlyingAdjustedQuantity);
            }
            public QuickFix.Fields.UnderlyingFXRate underlyingFXRate
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFXRate val = new QuickFix.Fields.UnderlyingFXRate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                this.underlyingFXRate = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRate get(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFXRate val) 
            { 
                return isSetUnderlyingFXRate();
            }
            
            public bool isSetUnderlyingFXRate() 
            { 
                return isSetField(Tags.UnderlyingFXRate);
            }
            public QuickFix.Fields.UnderlyingFXRateCalc underlyingFXRateCalc
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingFXRateCalc val = new QuickFix.Fields.UnderlyingFXRateCalc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                this.underlyingFXRateCalc = val;
            }
            
            public QuickFix.Fields.UnderlyingFXRateCalc get(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingFXRateCalc val) 
            { 
                return isSetUnderlyingFXRateCalc();
            }
            
            public bool isSetUnderlyingFXRateCalc() 
            { 
                return isSetField(Tags.UnderlyingFXRateCalc);
            }
            public QuickFix.Fields.UnderlyingMaturityTime underlyingMaturityTime
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingMaturityTime val = new QuickFix.Fields.UnderlyingMaturityTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                this.underlyingMaturityTime = val;
            }
            
            public QuickFix.Fields.UnderlyingMaturityTime get(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingMaturityTime val) 
            { 
                return isSetUnderlyingMaturityTime();
            }
            
            public bool isSetUnderlyingMaturityTime() 
            { 
                return isSetField(Tags.UnderlyingMaturityTime);
            }
            public QuickFix.Fields.UnderlyingPutOrCall underlyingPutOrCall
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                this.underlyingPutOrCall = val;
            }
            
            public QuickFix.Fields.UnderlyingPutOrCall get(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPutOrCall val) 
            { 
                return isSetUnderlyingPutOrCall();
            }
            
            public bool isSetUnderlyingPutOrCall() 
            { 
                return isSetField(Tags.UnderlyingPutOrCall);
            }
            public QuickFix.Fields.UnderlyingExerciseStyle underlyingExerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingExerciseStyle val = new QuickFix.Fields.UnderlyingExerciseStyle();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                this.underlyingExerciseStyle = val;
            }
            
            public QuickFix.Fields.UnderlyingExerciseStyle get(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingExerciseStyle val) 
            { 
                return isSetUnderlyingExerciseStyle();
            }
            
            public bool isSetUnderlyingExerciseStyle() 
            { 
                return isSetField(Tags.UnderlyingExerciseStyle);
            }
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty underlyingUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                this.underlyingUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingUnitOfMeasureQty get(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingUnitOfMeasureQty val) 
            { 
                return isSetUnderlyingUnitOfMeasureQty();
            }
            
            public bool isSetUnderlyingUnitOfMeasureQty() 
            { 
                return isSetField(Tags.UnderlyingUnitOfMeasureQty);
            }
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure underlyingPriceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceUnitOfMeasure val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                this.underlyingPriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasure get(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasure val) 
            { 
                return isSetUnderlyingPriceUnitOfMeasure();
            }
            
            public bool isSetUnderlyingPriceUnitOfMeasure() 
            { 
                return isSetField(Tags.UnderlyingPriceUnitOfMeasure);
            }
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty underlyingPriceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val = new QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                this.underlyingPriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty get(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.UnderlyingPriceUnitOfMeasureQty val) 
            { 
                return isSetUnderlyingPriceUnitOfMeasureQty();
            }
            
            public bool isSetUnderlyingPriceUnitOfMeasureQty() 
            { 
                return isSetField(Tags.UnderlyingPriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.DerivativeSymbol derivativeSymbol
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSymbol val = new QuickFix.Fields.DerivativeSymbol();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSymbol val) 
            { 
                this.derivativeSymbol = val;
            }
            
            public QuickFix.Fields.DerivativeSymbol get(QuickFix.Fields.DerivativeSymbol val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSymbol val) 
            { 
                return isSetDerivativeSymbol();
            }
            
            public bool isSetDerivativeSymbol() 
            { 
                return isSetField(Tags.DerivativeSymbol);
            }
            public QuickFix.Fields.DerivativeSymbolSfx derivativeSymbolSfx
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSymbolSfx val = new QuickFix.Fields.DerivativeSymbolSfx();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                this.derivativeSymbolSfx = val;
            }
            
            public QuickFix.Fields.DerivativeSymbolSfx get(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSymbolSfx val) 
            { 
                return isSetDerivativeSymbolSfx();
            }
            
            public bool isSetDerivativeSymbolSfx() 
            { 
                return isSetField(Tags.DerivativeSymbolSfx);
            }
            public QuickFix.Fields.DerivativeSecurityID derivativeSecurityID
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityID val = new QuickFix.Fields.DerivativeSecurityID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                this.derivativeSecurityID = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityID get(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityID val) 
            { 
                return isSetDerivativeSecurityID();
            }
            
            public bool isSetDerivativeSecurityID() 
            { 
                return isSetField(Tags.DerivativeSecurityID);
            }
            public QuickFix.Fields.DerivativeSecurityIDSource derivativeSecurityIDSource
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityIDSource val = new QuickFix.Fields.DerivativeSecurityIDSource();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                this.derivativeSecurityIDSource = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityIDSource get(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityIDSource val) 
            { 
                return isSetDerivativeSecurityIDSource();
            }
            
            public bool isSetDerivativeSecurityIDSource() 
            { 
                return isSetField(Tags.DerivativeSecurityIDSource);
            }
            public QuickFix.Fields.NoDerivativeSecurityAltID noDerivativeSecurityAltID
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeSecurityAltID val = new QuickFix.Fields.NoDerivativeSecurityAltID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                this.noDerivativeSecurityAltID = val;
            }
            
            public QuickFix.Fields.NoDerivativeSecurityAltID get(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDerivativeSecurityAltID val) 
            { 
                return isSetNoDerivativeSecurityAltID();
            }
            
            public bool isSetNoDerivativeSecurityAltID() 
            { 
                return isSetField(Tags.NoDerivativeSecurityAltID);
            }
            public QuickFix.Fields.DerivativeProduct derivativeProduct
            { 
                get 
                {
                    QuickFix.Fields.DerivativeProduct val = new QuickFix.Fields.DerivativeProduct();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeProduct val) 
            { 
                this.derivativeProduct = val;
            }
            
            public QuickFix.Fields.DerivativeProduct get(QuickFix.Fields.DerivativeProduct val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeProduct val) 
            { 
                return isSetDerivativeProduct();
            }
            
            public bool isSetDerivativeProduct() 
            { 
                return isSetField(Tags.DerivativeProduct);
            }
            public QuickFix.Fields.DerivativeProductComplex derivativeProductComplex
            { 
                get 
                {
                    QuickFix.Fields.DerivativeProductComplex val = new QuickFix.Fields.DerivativeProductComplex();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                this.derivativeProductComplex = val;
            }
            
            public QuickFix.Fields.DerivativeProductComplex get(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeProductComplex val) 
            { 
                return isSetDerivativeProductComplex();
            }
            
            public bool isSetDerivativeProductComplex() 
            { 
                return isSetField(Tags.DerivativeProductComplex);
            }
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator derivFlexProductEligibilityIndicator
            { 
                get 
                {
                    QuickFix.Fields.DerivFlexProductEligibilityIndicator val = new QuickFix.Fields.DerivFlexProductEligibilityIndicator();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                this.derivFlexProductEligibilityIndicator = val;
            }
            
            public QuickFix.Fields.DerivFlexProductEligibilityIndicator get(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivFlexProductEligibilityIndicator val) 
            { 
                return isSetDerivFlexProductEligibilityIndicator();
            }
            
            public bool isSetDerivFlexProductEligibilityIndicator() 
            { 
                return isSetField(Tags.DerivFlexProductEligibilityIndicator);
            }
            public QuickFix.Fields.DerivativeSecurityGroup derivativeSecurityGroup
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityGroup val = new QuickFix.Fields.DerivativeSecurityGroup();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                this.derivativeSecurityGroup = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityGroup get(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityGroup val) 
            { 
                return isSetDerivativeSecurityGroup();
            }
            
            public bool isSetDerivativeSecurityGroup() 
            { 
                return isSetField(Tags.DerivativeSecurityGroup);
            }
            public QuickFix.Fields.DerivativeCFICode derivativeCFICode
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCFICode val = new QuickFix.Fields.DerivativeCFICode();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeCFICode val) 
            { 
                this.derivativeCFICode = val;
            }
            
            public QuickFix.Fields.DerivativeCFICode get(QuickFix.Fields.DerivativeCFICode val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeCFICode val) 
            { 
                return isSetDerivativeCFICode();
            }
            
            public bool isSetDerivativeCFICode() 
            { 
                return isSetField(Tags.DerivativeCFICode);
            }
            public QuickFix.Fields.DerivativeSecurityType derivativeSecurityType
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityType val = new QuickFix.Fields.DerivativeSecurityType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                this.derivativeSecurityType = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityType get(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityType val) 
            { 
                return isSetDerivativeSecurityType();
            }
            
            public bool isSetDerivativeSecurityType() 
            { 
                return isSetField(Tags.DerivativeSecurityType);
            }
            public QuickFix.Fields.DerivativeSecuritySubType derivativeSecuritySubType
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecuritySubType val = new QuickFix.Fields.DerivativeSecuritySubType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                this.derivativeSecuritySubType = val;
            }
            
            public QuickFix.Fields.DerivativeSecuritySubType get(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecuritySubType val) 
            { 
                return isSetDerivativeSecuritySubType();
            }
            
            public bool isSetDerivativeSecuritySubType() 
            { 
                return isSetField(Tags.DerivativeSecuritySubType);
            }
            public QuickFix.Fields.DerivativeMaturityMonthYear derivativeMaturityMonthYear
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityMonthYear val = new QuickFix.Fields.DerivativeMaturityMonthYear();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                this.derivativeMaturityMonthYear = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityMonthYear get(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMaturityMonthYear val) 
            { 
                return isSetDerivativeMaturityMonthYear();
            }
            
            public bool isSetDerivativeMaturityMonthYear() 
            { 
                return isSetField(Tags.DerivativeMaturityMonthYear);
            }
            public QuickFix.Fields.DerivativeMaturityDate derivativeMaturityDate
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityDate val = new QuickFix.Fields.DerivativeMaturityDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                this.derivativeMaturityDate = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityDate get(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMaturityDate val) 
            { 
                return isSetDerivativeMaturityDate();
            }
            
            public bool isSetDerivativeMaturityDate() 
            { 
                return isSetField(Tags.DerivativeMaturityDate);
            }
            public QuickFix.Fields.DerivativeMaturityTime derivativeMaturityTime
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMaturityTime val = new QuickFix.Fields.DerivativeMaturityTime();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                this.derivativeMaturityTime = val;
            }
            
            public QuickFix.Fields.DerivativeMaturityTime get(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMaturityTime val) 
            { 
                return isSetDerivativeMaturityTime();
            }
            
            public bool isSetDerivativeMaturityTime() 
            { 
                return isSetField(Tags.DerivativeMaturityTime);
            }
            public QuickFix.Fields.DerivativeSettleOnOpenFlag derivativeSettleOnOpenFlag
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSettleOnOpenFlag val = new QuickFix.Fields.DerivativeSettleOnOpenFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                this.derivativeSettleOnOpenFlag = val;
            }
            
            public QuickFix.Fields.DerivativeSettleOnOpenFlag get(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSettleOnOpenFlag val) 
            { 
                return isSetDerivativeSettleOnOpenFlag();
            }
            
            public bool isSetDerivativeSettleOnOpenFlag() 
            { 
                return isSetField(Tags.DerivativeSettleOnOpenFlag);
            }
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod derivativeInstrmtAssignmentMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeInstrmtAssignmentMethod val = new QuickFix.Fields.DerivativeInstrmtAssignmentMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                this.derivativeInstrmtAssignmentMethod = val;
            }
            
            public QuickFix.Fields.DerivativeInstrmtAssignmentMethod get(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeInstrmtAssignmentMethod val) 
            { 
                return isSetDerivativeInstrmtAssignmentMethod();
            }
            
            public bool isSetDerivativeInstrmtAssignmentMethod() 
            { 
                return isSetField(Tags.DerivativeInstrmtAssignmentMethod);
            }
            public QuickFix.Fields.DerivativeSecurityStatus derivativeSecurityStatus
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityStatus val = new QuickFix.Fields.DerivativeSecurityStatus();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                this.derivativeSecurityStatus = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityStatus get(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityStatus val) 
            { 
                return isSetDerivativeSecurityStatus();
            }
            
            public bool isSetDerivativeSecurityStatus() 
            { 
                return isSetField(Tags.DerivativeSecurityStatus);
            }
            public QuickFix.Fields.DerivativeIssueDate derivativeIssueDate
            { 
                get 
                {
                    QuickFix.Fields.DerivativeIssueDate val = new QuickFix.Fields.DerivativeIssueDate();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                this.derivativeIssueDate = val;
            }
            
            public QuickFix.Fields.DerivativeIssueDate get(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeIssueDate val) 
            { 
                return isSetDerivativeIssueDate();
            }
            
            public bool isSetDerivativeIssueDate() 
            { 
                return isSetField(Tags.DerivativeIssueDate);
            }
            public QuickFix.Fields.DerivativeInstrRegistry derivativeInstrRegistry
            { 
                get 
                {
                    QuickFix.Fields.DerivativeInstrRegistry val = new QuickFix.Fields.DerivativeInstrRegistry();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                this.derivativeInstrRegistry = val;
            }
            
            public QuickFix.Fields.DerivativeInstrRegistry get(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeInstrRegistry val) 
            { 
                return isSetDerivativeInstrRegistry();
            }
            
            public bool isSetDerivativeInstrRegistry() 
            { 
                return isSetField(Tags.DerivativeInstrRegistry);
            }
            public QuickFix.Fields.DerivativeCountryOfIssue derivativeCountryOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCountryOfIssue val = new QuickFix.Fields.DerivativeCountryOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                this.derivativeCountryOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeCountryOfIssue get(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeCountryOfIssue val) 
            { 
                return isSetDerivativeCountryOfIssue();
            }
            
            public bool isSetDerivativeCountryOfIssue() 
            { 
                return isSetField(Tags.DerivativeCountryOfIssue);
            }
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue derivativeStateOrProvinceOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStateOrProvinceOfIssue val = new QuickFix.Fields.DerivativeStateOrProvinceOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                this.derivativeStateOrProvinceOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeStateOrProvinceOfIssue get(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStateOrProvinceOfIssue val) 
            { 
                return isSetDerivativeStateOrProvinceOfIssue();
            }
            
            public bool isSetDerivativeStateOrProvinceOfIssue() 
            { 
                return isSetField(Tags.DerivativeStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.DerivativeStrikePrice derivativeStrikePrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikePrice val = new QuickFix.Fields.DerivativeStrikePrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                this.derivativeStrikePrice = val;
            }
            
            public QuickFix.Fields.DerivativeStrikePrice get(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikePrice val) 
            { 
                return isSetDerivativeStrikePrice();
            }
            
            public bool isSetDerivativeStrikePrice() 
            { 
                return isSetField(Tags.DerivativeStrikePrice);
            }
            public QuickFix.Fields.DerivativeLocaleOfIssue derivativeLocaleOfIssue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeLocaleOfIssue val = new QuickFix.Fields.DerivativeLocaleOfIssue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                this.derivativeLocaleOfIssue = val;
            }
            
            public QuickFix.Fields.DerivativeLocaleOfIssue get(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeLocaleOfIssue val) 
            { 
                return isSetDerivativeLocaleOfIssue();
            }
            
            public bool isSetDerivativeLocaleOfIssue() 
            { 
                return isSetField(Tags.DerivativeLocaleOfIssue);
            }
            public QuickFix.Fields.DerivativeStrikeCurrency derivativeStrikeCurrency
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeCurrency val = new QuickFix.Fields.DerivativeStrikeCurrency();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                this.derivativeStrikeCurrency = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeCurrency get(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikeCurrency val) 
            { 
                return isSetDerivativeStrikeCurrency();
            }
            
            public bool isSetDerivativeStrikeCurrency() 
            { 
                return isSetField(Tags.DerivativeStrikeCurrency);
            }
            public QuickFix.Fields.DerivativeStrikeMultiplier derivativeStrikeMultiplier
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeMultiplier val = new QuickFix.Fields.DerivativeStrikeMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                this.derivativeStrikeMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeMultiplier get(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikeMultiplier val) 
            { 
                return isSetDerivativeStrikeMultiplier();
            }
            
            public bool isSetDerivativeStrikeMultiplier() 
            { 
                return isSetField(Tags.DerivativeStrikeMultiplier);
            }
            public QuickFix.Fields.DerivativeStrikeValue derivativeStrikeValue
            { 
                get 
                {
                    QuickFix.Fields.DerivativeStrikeValue val = new QuickFix.Fields.DerivativeStrikeValue();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                this.derivativeStrikeValue = val;
            }
            
            public QuickFix.Fields.DerivativeStrikeValue get(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeStrikeValue val) 
            { 
                return isSetDerivativeStrikeValue();
            }
            
            public bool isSetDerivativeStrikeValue() 
            { 
                return isSetField(Tags.DerivativeStrikeValue);
            }
            public QuickFix.Fields.DerivativeOptAttribute derivativeOptAttribute
            { 
                get 
                {
                    QuickFix.Fields.DerivativeOptAttribute val = new QuickFix.Fields.DerivativeOptAttribute();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                this.derivativeOptAttribute = val;
            }
            
            public QuickFix.Fields.DerivativeOptAttribute get(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeOptAttribute val) 
            { 
                return isSetDerivativeOptAttribute();
            }
            
            public bool isSetDerivativeOptAttribute() 
            { 
                return isSetField(Tags.DerivativeOptAttribute);
            }
            public QuickFix.Fields.DerivativeContractMultiplier derivativeContractMultiplier
            { 
                get 
                {
                    QuickFix.Fields.DerivativeContractMultiplier val = new QuickFix.Fields.DerivativeContractMultiplier();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                this.derivativeContractMultiplier = val;
            }
            
            public QuickFix.Fields.DerivativeContractMultiplier get(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeContractMultiplier val) 
            { 
                return isSetDerivativeContractMultiplier();
            }
            
            public bool isSetDerivativeContractMultiplier() 
            { 
                return isSetField(Tags.DerivativeContractMultiplier);
            }
            public QuickFix.Fields.DerivativeMinPriceIncrement derivativeMinPriceIncrement
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMinPriceIncrement val = new QuickFix.Fields.DerivativeMinPriceIncrement();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                this.derivativeMinPriceIncrement = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrement get(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMinPriceIncrement val) 
            { 
                return isSetDerivativeMinPriceIncrement();
            }
            
            public bool isSetDerivativeMinPriceIncrement() 
            { 
                return isSetField(Tags.DerivativeMinPriceIncrement);
            }
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount derivativeMinPriceIncrementAmount
            { 
                get 
                {
                    QuickFix.Fields.DerivativeMinPriceIncrementAmount val = new QuickFix.Fields.DerivativeMinPriceIncrementAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                this.derivativeMinPriceIncrementAmount = val;
            }
            
            public QuickFix.Fields.DerivativeMinPriceIncrementAmount get(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeMinPriceIncrementAmount val) 
            { 
                return isSetDerivativeMinPriceIncrementAmount();
            }
            
            public bool isSetDerivativeMinPriceIncrementAmount() 
            { 
                return isSetField(Tags.DerivativeMinPriceIncrementAmount);
            }
            public QuickFix.Fields.DerivativeUnitOfMeasure derivativeUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.DerivativeUnitOfMeasure val = new QuickFix.Fields.DerivativeUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                this.derivativeUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasure get(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeUnitOfMeasure val) 
            { 
                return isSetDerivativeUnitOfMeasure();
            }
            
            public bool isSetDerivativeUnitOfMeasure() 
            { 
                return isSetField(Tags.DerivativeUnitOfMeasure);
            }
            public QuickFix.Fields.DerivativeUnitOfMeasureQty derivativeUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.DerivativeUnitOfMeasureQty val = new QuickFix.Fields.DerivativeUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                this.derivativeUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativeUnitOfMeasureQty get(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeUnitOfMeasureQty val) 
            { 
                return isSetDerivativeUnitOfMeasureQty();
            }
            
            public bool isSetDerivativeUnitOfMeasureQty() 
            { 
                return isSetField(Tags.DerivativeUnitOfMeasureQty);
            }
            public QuickFix.Fields.DerivativePriceUnitOfMeasure derivativePriceUnitOfMeasure
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceUnitOfMeasure val = new QuickFix.Fields.DerivativePriceUnitOfMeasure();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                this.derivativePriceUnitOfMeasure = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasure get(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePriceUnitOfMeasure val) 
            { 
                return isSetDerivativePriceUnitOfMeasure();
            }
            
            public bool isSetDerivativePriceUnitOfMeasure() 
            { 
                return isSetField(Tags.DerivativePriceUnitOfMeasure);
            }
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty derivativePriceUnitOfMeasureQty
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceUnitOfMeasureQty val = new QuickFix.Fields.DerivativePriceUnitOfMeasureQty();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                this.derivativePriceUnitOfMeasureQty = val;
            }
            
            public QuickFix.Fields.DerivativePriceUnitOfMeasureQty get(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePriceUnitOfMeasureQty val) 
            { 
                return isSetDerivativePriceUnitOfMeasureQty();
            }
            
            public bool isSetDerivativePriceUnitOfMeasureQty() 
            { 
                return isSetField(Tags.DerivativePriceUnitOfMeasureQty);
            }
            public QuickFix.Fields.DerivativeExerciseStyle derivativeExerciseStyle
            { 
                get 
                {
                    QuickFix.Fields.DerivativeExerciseStyle val = new QuickFix.Fields.DerivativeExerciseStyle();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                this.derivativeExerciseStyle = val;
            }
            
            public QuickFix.Fields.DerivativeExerciseStyle get(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeExerciseStyle val) 
            { 
                return isSetDerivativeExerciseStyle();
            }
            
            public bool isSetDerivativeExerciseStyle() 
            { 
                return isSetField(Tags.DerivativeExerciseStyle);
            }
            public QuickFix.Fields.DerivativeOptPayAmount derivativeOptPayAmount
            { 
                get 
                {
                    QuickFix.Fields.DerivativeOptPayAmount val = new QuickFix.Fields.DerivativeOptPayAmount();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                this.derivativeOptPayAmount = val;
            }
            
            public QuickFix.Fields.DerivativeOptPayAmount get(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeOptPayAmount val) 
            { 
                return isSetDerivativeOptPayAmount();
            }
            
            public bool isSetDerivativeOptPayAmount() 
            { 
                return isSetField(Tags.DerivativeOptPayAmount);
            }
            public QuickFix.Fields.DerivativeTimeUnit derivativeTimeUnit
            { 
                get 
                {
                    QuickFix.Fields.DerivativeTimeUnit val = new QuickFix.Fields.DerivativeTimeUnit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                this.derivativeTimeUnit = val;
            }
            
            public QuickFix.Fields.DerivativeTimeUnit get(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeTimeUnit val) 
            { 
                return isSetDerivativeTimeUnit();
            }
            
            public bool isSetDerivativeTimeUnit() 
            { 
                return isSetField(Tags.DerivativeTimeUnit);
            }
            public QuickFix.Fields.DerivativeSecurityExchange derivativeSecurityExchange
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityExchange val = new QuickFix.Fields.DerivativeSecurityExchange();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                this.derivativeSecurityExchange = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityExchange get(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityExchange val) 
            { 
                return isSetDerivativeSecurityExchange();
            }
            
            public bool isSetDerivativeSecurityExchange() 
            { 
                return isSetField(Tags.DerivativeSecurityExchange);
            }
            public QuickFix.Fields.DerivativePositionLimit derivativePositionLimit
            { 
                get 
                {
                    QuickFix.Fields.DerivativePositionLimit val = new QuickFix.Fields.DerivativePositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                this.derivativePositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativePositionLimit get(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePositionLimit val) 
            { 
                return isSetDerivativePositionLimit();
            }
            
            public bool isSetDerivativePositionLimit() 
            { 
                return isSetField(Tags.DerivativePositionLimit);
            }
            public QuickFix.Fields.DerivativeNTPositionLimit derivativeNTPositionLimit
            { 
                get 
                {
                    QuickFix.Fields.DerivativeNTPositionLimit val = new QuickFix.Fields.DerivativeNTPositionLimit();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                this.derivativeNTPositionLimit = val;
            }
            
            public QuickFix.Fields.DerivativeNTPositionLimit get(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeNTPositionLimit val) 
            { 
                return isSetDerivativeNTPositionLimit();
            }
            
            public bool isSetDerivativeNTPositionLimit() 
            { 
                return isSetField(Tags.DerivativeNTPositionLimit);
            }
            public QuickFix.Fields.DerivativeIssuer derivativeIssuer
            { 
                get 
                {
                    QuickFix.Fields.DerivativeIssuer val = new QuickFix.Fields.DerivativeIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeIssuer val) 
            { 
                this.derivativeIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeIssuer get(QuickFix.Fields.DerivativeIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeIssuer val) 
            { 
                return isSetDerivativeIssuer();
            }
            
            public bool isSetDerivativeIssuer() 
            { 
                return isSetField(Tags.DerivativeIssuer);
            }
            public QuickFix.Fields.DerivativeEncodedIssuerLen derivativeEncodedIssuerLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedIssuerLen val = new QuickFix.Fields.DerivativeEncodedIssuerLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                this.derivativeEncodedIssuerLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuerLen get(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedIssuerLen val) 
            { 
                return isSetDerivativeEncodedIssuerLen();
            }
            
            public bool isSetDerivativeEncodedIssuerLen() 
            { 
                return isSetField(Tags.DerivativeEncodedIssuerLen);
            }
            public QuickFix.Fields.DerivativeEncodedIssuer derivativeEncodedIssuer
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedIssuer val = new QuickFix.Fields.DerivativeEncodedIssuer();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                this.derivativeEncodedIssuer = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedIssuer get(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedIssuer val) 
            { 
                return isSetDerivativeEncodedIssuer();
            }
            
            public bool isSetDerivativeEncodedIssuer() 
            { 
                return isSetField(Tags.DerivativeEncodedIssuer);
            }
            public QuickFix.Fields.DerivativeSecurityDesc derivativeSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityDesc val = new QuickFix.Fields.DerivativeSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                this.derivativeSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityDesc get(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityDesc val) 
            { 
                return isSetDerivativeSecurityDesc();
            }
            
            public bool isSetDerivativeSecurityDesc() 
            { 
                return isSetField(Tags.DerivativeSecurityDesc);
            }
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen derivativeEncodedSecurityDescLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedSecurityDescLen val = new QuickFix.Fields.DerivativeEncodedSecurityDescLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                this.derivativeEncodedSecurityDescLen = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDescLen get(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedSecurityDescLen val) 
            { 
                return isSetDerivativeEncodedSecurityDescLen();
            }
            
            public bool isSetDerivativeEncodedSecurityDescLen() 
            { 
                return isSetField(Tags.DerivativeEncodedSecurityDescLen);
            }
            public QuickFix.Fields.DerivativeEncodedSecurityDesc derivativeEncodedSecurityDesc
            { 
                get 
                {
                    QuickFix.Fields.DerivativeEncodedSecurityDesc val = new QuickFix.Fields.DerivativeEncodedSecurityDesc();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                this.derivativeEncodedSecurityDesc = val;
            }
            
            public QuickFix.Fields.DerivativeEncodedSecurityDesc get(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeEncodedSecurityDesc val) 
            { 
                return isSetDerivativeEncodedSecurityDesc();
            }
            
            public bool isSetDerivativeEncodedSecurityDesc() 
            { 
                return isSetField(Tags.DerivativeEncodedSecurityDesc);
            }
            public QuickFix.Fields.DerivativeContractSettlMonth derivativeContractSettlMonth
            { 
                get 
                {
                    QuickFix.Fields.DerivativeContractSettlMonth val = new QuickFix.Fields.DerivativeContractSettlMonth();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                this.derivativeContractSettlMonth = val;
            }
            
            public QuickFix.Fields.DerivativeContractSettlMonth get(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeContractSettlMonth val) 
            { 
                return isSetDerivativeContractSettlMonth();
            }
            
            public bool isSetDerivativeContractSettlMonth() 
            { 
                return isSetField(Tags.DerivativeContractSettlMonth);
            }
            public QuickFix.Fields.NoDerivativeEvents noDerivativeEvents
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeEvents val = new QuickFix.Fields.NoDerivativeEvents();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                this.noDerivativeEvents = val;
            }
            
            public QuickFix.Fields.NoDerivativeEvents get(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDerivativeEvents val) 
            { 
                return isSetNoDerivativeEvents();
            }
            
            public bool isSetNoDerivativeEvents() 
            { 
                return isSetField(Tags.NoDerivativeEvents);
            }
            public QuickFix.Fields.NoDerivativeInstrumentParties noDerivativeInstrumentParties
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeInstrumentParties val = new QuickFix.Fields.NoDerivativeInstrumentParties();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                this.noDerivativeInstrumentParties = val;
            }
            
            public QuickFix.Fields.NoDerivativeInstrumentParties get(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDerivativeInstrumentParties val) 
            { 
                return isSetNoDerivativeInstrumentParties();
            }
            
            public bool isSetNoDerivativeInstrumentParties() 
            { 
                return isSetField(Tags.NoDerivativeInstrumentParties);
            }
            public QuickFix.Fields.DerivativeSettlMethod derivativeSettlMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSettlMethod val = new QuickFix.Fields.DerivativeSettlMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                this.derivativeSettlMethod = val;
            }
            
            public QuickFix.Fields.DerivativeSettlMethod get(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSettlMethod val) 
            { 
                return isSetDerivativeSettlMethod();
            }
            
            public bool isSetDerivativeSettlMethod() 
            { 
                return isSetField(Tags.DerivativeSettlMethod);
            }
            public QuickFix.Fields.DerivativePriceQuoteMethod derivativePriceQuoteMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativePriceQuoteMethod val = new QuickFix.Fields.DerivativePriceQuoteMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                this.derivativePriceQuoteMethod = val;
            }
            
            public QuickFix.Fields.DerivativePriceQuoteMethod get(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePriceQuoteMethod val) 
            { 
                return isSetDerivativePriceQuoteMethod();
            }
            
            public bool isSetDerivativePriceQuoteMethod() 
            { 
                return isSetField(Tags.DerivativePriceQuoteMethod);
            }
            public QuickFix.Fields.DerivativeFuturesValuationMethod derivativeFuturesValuationMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeFuturesValuationMethod val = new QuickFix.Fields.DerivativeFuturesValuationMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                this.derivativeFuturesValuationMethod = val;
            }
            
            public QuickFix.Fields.DerivativeFuturesValuationMethod get(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeFuturesValuationMethod val) 
            { 
                return isSetDerivativeFuturesValuationMethod();
            }
            
            public bool isSetDerivativeFuturesValuationMethod() 
            { 
                return isSetField(Tags.DerivativeFuturesValuationMethod);
            }
            public QuickFix.Fields.DerivativeListMethod derivativeListMethod
            { 
                get 
                {
                    QuickFix.Fields.DerivativeListMethod val = new QuickFix.Fields.DerivativeListMethod();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeListMethod val) 
            { 
                this.derivativeListMethod = val;
            }
            
            public QuickFix.Fields.DerivativeListMethod get(QuickFix.Fields.DerivativeListMethod val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeListMethod val) 
            { 
                return isSetDerivativeListMethod();
            }
            
            public bool isSetDerivativeListMethod() 
            { 
                return isSetField(Tags.DerivativeListMethod);
            }
            public QuickFix.Fields.DerivativeCapPrice derivativeCapPrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeCapPrice val = new QuickFix.Fields.DerivativeCapPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                this.derivativeCapPrice = val;
            }
            
            public QuickFix.Fields.DerivativeCapPrice get(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeCapPrice val) 
            { 
                return isSetDerivativeCapPrice();
            }
            
            public bool isSetDerivativeCapPrice() 
            { 
                return isSetField(Tags.DerivativeCapPrice);
            }
            public QuickFix.Fields.DerivativeFloorPrice derivativeFloorPrice
            { 
                get 
                {
                    QuickFix.Fields.DerivativeFloorPrice val = new QuickFix.Fields.DerivativeFloorPrice();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                this.derivativeFloorPrice = val;
            }
            
            public QuickFix.Fields.DerivativeFloorPrice get(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeFloorPrice val) 
            { 
                return isSetDerivativeFloorPrice();
            }
            
            public bool isSetDerivativeFloorPrice() 
            { 
                return isSetField(Tags.DerivativeFloorPrice);
            }
            public QuickFix.Fields.DerivativePutOrCall derivativePutOrCall
            { 
                get 
                {
                    QuickFix.Fields.DerivativePutOrCall val = new QuickFix.Fields.DerivativePutOrCall();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                this.derivativePutOrCall = val;
            }
            
            public QuickFix.Fields.DerivativePutOrCall get(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativePutOrCall val) 
            { 
                return isSetDerivativePutOrCall();
            }
            
            public bool isSetDerivativePutOrCall() 
            { 
                return isSetField(Tags.DerivativePutOrCall);
            }
            public QuickFix.Fields.DerivativeSecurityXMLLen derivativeSecurityXMLLen
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXMLLen val = new QuickFix.Fields.DerivativeSecurityXMLLen();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                this.derivativeSecurityXMLLen = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLLen get(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityXMLLen val) 
            { 
                return isSetDerivativeSecurityXMLLen();
            }
            
            public bool isSetDerivativeSecurityXMLLen() 
            { 
                return isSetField(Tags.DerivativeSecurityXMLLen);
            }
            public QuickFix.Fields.DerivativeSecurityXML derivativeSecurityXML
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXML val = new QuickFix.Fields.DerivativeSecurityXML();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                this.derivativeSecurityXML = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXML get(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityXML val) 
            { 
                return isSetDerivativeSecurityXML();
            }
            
            public bool isSetDerivativeSecurityXML() 
            { 
                return isSetField(Tags.DerivativeSecurityXML);
            }
            public QuickFix.Fields.DerivativeSecurityXMLSchema derivativeSecurityXMLSchema
            { 
                get 
                {
                    QuickFix.Fields.DerivativeSecurityXMLSchema val = new QuickFix.Fields.DerivativeSecurityXMLSchema();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                this.derivativeSecurityXMLSchema = val;
            }
            
            public QuickFix.Fields.DerivativeSecurityXMLSchema get(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.DerivativeSecurityXMLSchema val) 
            { 
                return isSetDerivativeSecurityXMLSchema();
            }
            
            public bool isSetDerivativeSecurityXMLSchema() 
            { 
                return isSetField(Tags.DerivativeSecurityXMLSchema);
            }
            public QuickFix.Fields.NoDerivativeInstrAttrib noDerivativeInstrAttrib
            { 
                get 
                {
                    QuickFix.Fields.NoDerivativeInstrAttrib val = new QuickFix.Fields.NoDerivativeInstrAttrib();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                this.noDerivativeInstrAttrib = val;
            }
            
            public QuickFix.Fields.NoDerivativeInstrAttrib get(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoDerivativeInstrAttrib val) 
            { 
                return isSetNoDerivativeInstrAttrib();
            }
            
            public bool isSetNoDerivativeInstrAttrib() 
            { 
                return isSetField(Tags.NoDerivativeInstrAttrib);
            }
            public QuickFix.Fields.NoMarketSegments noMarketSegments
            { 
                get 
                {
                    QuickFix.Fields.NoMarketSegments val = new QuickFix.Fields.NoMarketSegments();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoMarketSegments val) 
            { 
                this.noMarketSegments = val;
            }
            
            public QuickFix.Fields.NoMarketSegments get(QuickFix.Fields.NoMarketSegments val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoMarketSegments val) 
            { 
                return isSetNoMarketSegments();
            }
            
            public bool isSetNoMarketSegments() 
            { 
                return isSetField(Tags.NoMarketSegments);
            }
            public QuickFix.Fields.TotNoRelatedSym totNoRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.TotNoRelatedSym val = new QuickFix.Fields.TotNoRelatedSym();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                this.totNoRelatedSym = val;
            }
            
            public QuickFix.Fields.TotNoRelatedSym get(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotNoRelatedSym val) 
            { 
                return isSetTotNoRelatedSym();
            }
            
            public bool isSetTotNoRelatedSym() 
            { 
                return isSetField(Tags.TotNoRelatedSym);
            }
            public QuickFix.Fields.LastFragment lastFragment
            { 
                get 
                {
                    QuickFix.Fields.LastFragment val = new QuickFix.Fields.LastFragment();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.LastFragment val) 
            { 
                this.lastFragment = val;
            }
            
            public QuickFix.Fields.LastFragment get(QuickFix.Fields.LastFragment val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.LastFragment val) 
            { 
                return isSetLastFragment();
            }
            
            public bool isSetLastFragment() 
            { 
                return isSetField(Tags.LastFragment);
            }
            public QuickFix.Fields.NoRelatedSym noRelatedSym
            { 
                get 
                {
                    QuickFix.Fields.NoRelatedSym val = new QuickFix.Fields.NoRelatedSym();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoRelatedSym val) 
            { 
                this.noRelatedSym = val;
            }
            
            public QuickFix.Fields.NoRelatedSym get(QuickFix.Fields.NoRelatedSym val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoRelatedSym val) 
            { 
                return isSetNoRelatedSym();
            }
            
            public bool isSetNoRelatedSym() 
            { 
                return isSetField(Tags.NoRelatedSym);
            }
            public QuickFix.Fields.ApplID applID
            { 
                get 
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplID val) 
            { 
                this.applID = val;
            }
            
            public QuickFix.Fields.ApplID get(QuickFix.Fields.ApplID val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplID val) 
            { 
                return isSetApplID();
            }
            
            public bool isSetApplID() 
            { 
                return isSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum applSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplSeqNum val) 
            { 
                this.applSeqNum = val;
            }
            
            public QuickFix.Fields.ApplSeqNum get(QuickFix.Fields.ApplSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplSeqNum val) 
            { 
                return isSetApplSeqNum();
            }
            
            public bool isSetApplSeqNum() 
            { 
                return isSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum applLastSeqNum
            { 
                get 
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                this.applLastSeqNum = val;
            }
            
            public QuickFix.Fields.ApplLastSeqNum get(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplLastSeqNum val) 
            { 
                return isSetApplLastSeqNum();
            }
            
            public bool isSetApplLastSeqNum() 
            { 
                return isSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag applResendFlag
            { 
                get 
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.ApplResendFlag val) 
            { 
                this.applResendFlag = val;
            }
            
            public QuickFix.Fields.ApplResendFlag get(QuickFix.Fields.ApplResendFlag val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.ApplResendFlag val) 
            { 
                return isSetApplResendFlag();
            }
            
            public bool isSetApplResendFlag() 
            { 
                return isSetField(Tags.ApplResendFlag);
            }
            public class NoUnderlyingSecurityAltID : Group
            {
                public NoUnderlyingSecurityAltID() 
                  :base( Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};
                            public QuickFix.Fields.UnderlyingSecurityAltID underlyingSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    this.underlyingSecurityAltID = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltID get(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityAltID val) 
                { 
                    return isSetUnderlyingSecurityAltID();
                }
                
                public bool isSetUnderlyingSecurityAltID() 
                { 
                    return isSetField(Tags.UnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingSecurityAltIDSource underlyingSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    this.underlyingSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.UnderlyingSecurityAltIDSource get(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) 
                { 
                    return isSetUnderlyingSecurityAltIDSource();
                }
                
                public bool isSetUnderlyingSecurityAltIDSource() 
                { 
                    return isSetField(Tags.UnderlyingSecurityAltIDSource);
                }
            
            }
            public class NoUnderlyingStips : Group
            {
                public NoUnderlyingStips() 
                  :base( Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};
                            public QuickFix.Fields.UnderlyingStipType underlyingStipType
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStipType val = new QuickFix.Fields.UnderlyingStipType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    this.underlyingStipType = val;
                }
                
                public QuickFix.Fields.UnderlyingStipType get(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStipType val) 
                { 
                    return isSetUnderlyingStipType();
                }
                
                public bool isSetUnderlyingStipType() 
                { 
                    return isSetField(Tags.UnderlyingStipType);
                }
                public QuickFix.Fields.UnderlyingStipValue underlyingStipValue
                { 
                    get 
                    {
                        QuickFix.Fields.UnderlyingStipValue val = new QuickFix.Fields.UnderlyingStipValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    this.underlyingStipValue = val;
                }
                
                public QuickFix.Fields.UnderlyingStipValue get(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnderlyingStipValue val) 
                { 
                    return isSetUnderlyingStipValue();
                }
                
                public bool isSetUnderlyingStipValue() 
                { 
                    return isSetField(Tags.UnderlyingStipValue);
                }
            
            }
            public class NoUndlyInstrumentParties : Group
            {
                public NoUndlyInstrumentParties() 
                  :base( Tags.NoUndlyInstrumentParties, Tags.UndlyInstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.UndlyInstrumentPartyID, Tags.UndlyInstrumentPartyIDSource, Tags.UndlyInstrumentPartyRole, Tags.NoUndlyInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.UndlyInstrumentPartyID undlyInstrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.UndlyInstrumentPartyID val = new QuickFix.Fields.UndlyInstrumentPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    this.undlyInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyID get(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UndlyInstrumentPartyID val) 
                { 
                    return isSetUndlyInstrumentPartyID();
                }
                
                public bool isSetUndlyInstrumentPartyID() 
                { 
                    return isSetField(Tags.UndlyInstrumentPartyID);
                }
                public QuickFix.Fields.UndlyInstrumentPartyIDSource undlyInstrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.UndlyInstrumentPartyIDSource val = new QuickFix.Fields.UndlyInstrumentPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    this.undlyInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyIDSource get(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UndlyInstrumentPartyIDSource val) 
                { 
                    return isSetUndlyInstrumentPartyIDSource();
                }
                
                public bool isSetUndlyInstrumentPartyIDSource() 
                { 
                    return isSetField(Tags.UndlyInstrumentPartyIDSource);
                }
                public QuickFix.Fields.UndlyInstrumentPartyRole undlyInstrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.UndlyInstrumentPartyRole val = new QuickFix.Fields.UndlyInstrumentPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    this.undlyInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.UndlyInstrumentPartyRole get(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UndlyInstrumentPartyRole val) 
                { 
                    return isSetUndlyInstrumentPartyRole();
                }
                
                public bool isSetUndlyInstrumentPartyRole() 
                { 
                    return isSetField(Tags.UndlyInstrumentPartyRole);
                }
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs noUndlyInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoUndlyInstrumentPartySubIDs val = new QuickFix.Fields.NoUndlyInstrumentPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    this.noUndlyInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoUndlyInstrumentPartySubIDs get(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoUndlyInstrumentPartySubIDs val) 
                { 
                    return isSetNoUndlyInstrumentPartySubIDs();
                }
                
                public bool isSetNoUndlyInstrumentPartySubIDs() 
                { 
                    return isSetField(Tags.NoUndlyInstrumentPartySubIDs);
                }
                            public class NoUndlyInstrumentPartySubIDs : Group
                {
                    public NoUndlyInstrumentPartySubIDs() 
                      :base( Tags.NoUndlyInstrumentPartySubIDs, Tags.UndlyInstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.UndlyInstrumentPartySubID, Tags.UndlyInstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.UndlyInstrumentPartySubID undlyInstrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.UndlyInstrumentPartySubID val = new QuickFix.Fields.UndlyInstrumentPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        this.undlyInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartySubID get(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UndlyInstrumentPartySubID val) 
                    { 
                        return isSetUndlyInstrumentPartySubID();
                    }
                    
                    public bool isSetUndlyInstrumentPartySubID() 
                    { 
                        return isSetField(Tags.UndlyInstrumentPartySubID);
                    }
                    public QuickFix.Fields.UndlyInstrumentPartySubIDType undlyInstrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.UndlyInstrumentPartySubIDType val = new QuickFix.Fields.UndlyInstrumentPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        this.undlyInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.UndlyInstrumentPartySubIDType get(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.UndlyInstrumentPartySubIDType val) 
                    { 
                        return isSetUndlyInstrumentPartySubIDType();
                    }
                    
                    public bool isSetUndlyInstrumentPartySubIDType() 
                    { 
                        return isSetField(Tags.UndlyInstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoDerivativeSecurityAltID : Group
            {
                public NoDerivativeSecurityAltID() 
                  :base( Tags.NoDerivativeSecurityAltID, Tags.DerivativeSecurityAltID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DerivativeSecurityAltID, Tags.DerivativeSecurityAltIDSource, 0};
                            public QuickFix.Fields.DerivativeSecurityAltID derivativeSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeSecurityAltID val = new QuickFix.Fields.DerivativeSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    this.derivativeSecurityAltID = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltID get(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeSecurityAltID val) 
                { 
                    return isSetDerivativeSecurityAltID();
                }
                
                public bool isSetDerivativeSecurityAltID() 
                { 
                    return isSetField(Tags.DerivativeSecurityAltID);
                }
                public QuickFix.Fields.DerivativeSecurityAltIDSource derivativeSecurityAltIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeSecurityAltIDSource val = new QuickFix.Fields.DerivativeSecurityAltIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    this.derivativeSecurityAltIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeSecurityAltIDSource get(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeSecurityAltIDSource val) 
                { 
                    return isSetDerivativeSecurityAltIDSource();
                }
                
                public bool isSetDerivativeSecurityAltIDSource() 
                { 
                    return isSetField(Tags.DerivativeSecurityAltIDSource);
                }
            
            }
            public class NoDerivativeEvents : Group
            {
                public NoDerivativeEvents() 
                  :base( Tags.NoDerivativeEvents, Tags.DerivativeEventType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DerivativeEventType, Tags.DerivativeEventDate, Tags.DerivativeEventTime, Tags.DerivativeEventPx, Tags.DerivativeEventText, 0};
                            public QuickFix.Fields.DerivativeEventType derivativeEventType
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventType val = new QuickFix.Fields.DerivativeEventType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventType val) 
                { 
                    this.derivativeEventType = val;
                }
                
                public QuickFix.Fields.DerivativeEventType get(QuickFix.Fields.DerivativeEventType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventType val) 
                { 
                    return isSetDerivativeEventType();
                }
                
                public bool isSetDerivativeEventType() 
                { 
                    return isSetField(Tags.DerivativeEventType);
                }
                public QuickFix.Fields.DerivativeEventDate derivativeEventDate
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventDate val = new QuickFix.Fields.DerivativeEventDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    this.derivativeEventDate = val;
                }
                
                public QuickFix.Fields.DerivativeEventDate get(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventDate val) 
                { 
                    return isSetDerivativeEventDate();
                }
                
                public bool isSetDerivativeEventDate() 
                { 
                    return isSetField(Tags.DerivativeEventDate);
                }
                public QuickFix.Fields.DerivativeEventTime derivativeEventTime
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventTime val = new QuickFix.Fields.DerivativeEventTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    this.derivativeEventTime = val;
                }
                
                public QuickFix.Fields.DerivativeEventTime get(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventTime val) 
                { 
                    return isSetDerivativeEventTime();
                }
                
                public bool isSetDerivativeEventTime() 
                { 
                    return isSetField(Tags.DerivativeEventTime);
                }
                public QuickFix.Fields.DerivativeEventPx derivativeEventPx
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventPx val = new QuickFix.Fields.DerivativeEventPx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    this.derivativeEventPx = val;
                }
                
                public QuickFix.Fields.DerivativeEventPx get(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventPx val) 
                { 
                    return isSetDerivativeEventPx();
                }
                
                public bool isSetDerivativeEventPx() 
                { 
                    return isSetField(Tags.DerivativeEventPx);
                }
                public QuickFix.Fields.DerivativeEventText derivativeEventText
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeEventText val = new QuickFix.Fields.DerivativeEventText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeEventText val) 
                { 
                    this.derivativeEventText = val;
                }
                
                public QuickFix.Fields.DerivativeEventText get(QuickFix.Fields.DerivativeEventText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeEventText val) 
                { 
                    return isSetDerivativeEventText();
                }
                
                public bool isSetDerivativeEventText() 
                { 
                    return isSetField(Tags.DerivativeEventText);
                }
            
            }
            public class NoDerivativeInstrumentParties : Group
            {
                public NoDerivativeInstrumentParties() 
                  :base( Tags.NoDerivativeInstrumentParties, Tags.DerivativeInstrumentPartyID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DerivativeInstrumentPartyID, Tags.DerivativeInstrumentPartyIDSource, Tags.DerivativeInstrumentPartyRole, Tags.NoDerivativeInstrumentPartySubIDs, 0};
                            public QuickFix.Fields.DerivativeInstrumentPartyID derivativeInstrumentPartyID
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyID val = new QuickFix.Fields.DerivativeInstrumentPartyID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    this.derivativeInstrumentPartyID = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyID get(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrumentPartyID val) 
                { 
                    return isSetDerivativeInstrumentPartyID();
                }
                
                public bool isSetDerivativeInstrumentPartyID() 
                { 
                    return isSetField(Tags.DerivativeInstrumentPartyID);
                }
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource derivativeInstrumentPartyIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyIDSource val = new QuickFix.Fields.DerivativeInstrumentPartyIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    this.derivativeInstrumentPartyIDSource = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyIDSource get(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrumentPartyIDSource val) 
                { 
                    return isSetDerivativeInstrumentPartyIDSource();
                }
                
                public bool isSetDerivativeInstrumentPartyIDSource() 
                { 
                    return isSetField(Tags.DerivativeInstrumentPartyIDSource);
                }
                public QuickFix.Fields.DerivativeInstrumentPartyRole derivativeInstrumentPartyRole
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrumentPartyRole val = new QuickFix.Fields.DerivativeInstrumentPartyRole();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    this.derivativeInstrumentPartyRole = val;
                }
                
                public QuickFix.Fields.DerivativeInstrumentPartyRole get(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrumentPartyRole val) 
                { 
                    return isSetDerivativeInstrumentPartyRole();
                }
                
                public bool isSetDerivativeInstrumentPartyRole() 
                { 
                    return isSetField(Tags.DerivativeInstrumentPartyRole);
                }
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs noDerivativeInstrumentPartySubIDs
                { 
                    get 
                    {
                        QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val = new QuickFix.Fields.NoDerivativeInstrumentPartySubIDs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    this.noDerivativeInstrumentPartySubIDs = val;
                }
                
                public QuickFix.Fields.NoDerivativeInstrumentPartySubIDs get(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoDerivativeInstrumentPartySubIDs val) 
                { 
                    return isSetNoDerivativeInstrumentPartySubIDs();
                }
                
                public bool isSetNoDerivativeInstrumentPartySubIDs() 
                { 
                    return isSetField(Tags.NoDerivativeInstrumentPartySubIDs);
                }
                            public class NoDerivativeInstrumentPartySubIDs : Group
                {
                    public NoDerivativeInstrumentPartySubIDs() 
                      :base( Tags.NoDerivativeInstrumentPartySubIDs, Tags.DerivativeInstrumentPartySubID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.DerivativeInstrumentPartySubID, Tags.DerivativeInstrumentPartySubIDType, 0};
                                    public QuickFix.Fields.DerivativeInstrumentPartySubID derivativeInstrumentPartySubID
                    { 
                        get 
                        {
                            QuickFix.Fields.DerivativeInstrumentPartySubID val = new QuickFix.Fields.DerivativeInstrumentPartySubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        this.derivativeInstrumentPartySubID = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubID get(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.DerivativeInstrumentPartySubID val) 
                    { 
                        return isSetDerivativeInstrumentPartySubID();
                    }
                    
                    public bool isSetDerivativeInstrumentPartySubID() 
                    { 
                        return isSetField(Tags.DerivativeInstrumentPartySubID);
                    }
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType derivativeInstrumentPartySubIDType
                    { 
                        get 
                        {
                            QuickFix.Fields.DerivativeInstrumentPartySubIDType val = new QuickFix.Fields.DerivativeInstrumentPartySubIDType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        this.derivativeInstrumentPartySubIDType = val;
                    }
                    
                    public QuickFix.Fields.DerivativeInstrumentPartySubIDType get(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.DerivativeInstrumentPartySubIDType val) 
                    { 
                        return isSetDerivativeInstrumentPartySubIDType();
                    }
                    
                    public bool isSetDerivativeInstrumentPartySubIDType() 
                    { 
                        return isSetField(Tags.DerivativeInstrumentPartySubIDType);
                    }
                
                }
            }
            public class NoDerivativeInstrAttrib : Group
            {
                public NoDerivativeInstrAttrib() 
                  :base( Tags.NoDerivativeInstrAttrib, Tags.DerivativeInstrAttribType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.DerivativeInstrAttribType, Tags.DerivativeInstrAttribValue, 0};
                            public QuickFix.Fields.DerivativeInstrAttribType derivativeInstrAttribType
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrAttribType val = new QuickFix.Fields.DerivativeInstrAttribType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    this.derivativeInstrAttribType = val;
                }
                
                public QuickFix.Fields.DerivativeInstrAttribType get(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrAttribType val) 
                { 
                    return isSetDerivativeInstrAttribType();
                }
                
                public bool isSetDerivativeInstrAttribType() 
                { 
                    return isSetField(Tags.DerivativeInstrAttribType);
                }
                public QuickFix.Fields.DerivativeInstrAttribValue derivativeInstrAttribValue
                { 
                    get 
                    {
                        QuickFix.Fields.DerivativeInstrAttribValue val = new QuickFix.Fields.DerivativeInstrAttribValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    this.derivativeInstrAttribValue = val;
                }
                
                public QuickFix.Fields.DerivativeInstrAttribValue get(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DerivativeInstrAttribValue val) 
                { 
                    return isSetDerivativeInstrAttribValue();
                }
                
                public bool isSetDerivativeInstrAttribValue() 
                { 
                    return isSetField(Tags.DerivativeInstrAttribValue);
                }
            
            }
            public class NoMarketSegments : Group
            {
                public NoMarketSegments() 
                  :base( Tags.NoMarketSegments, Tags.MarketID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.MarketID, Tags.MarketSegmentID, Tags.NoTickRules, Tags.NoLotTypeRules, Tags.PriceLimitType, Tags.LowLimitPrice, Tags.HighLimitPrice, Tags.TradingReferencePrice, Tags.ExpirationCycle, Tags.MinTradeVol, Tags.MaxTradeVol, Tags.MaxPriceVariation, Tags.ImpliedMarketIndicator, Tags.TradingCurrency, Tags.RoundLot, Tags.MultilegModel, Tags.MultilegPriceMethod, Tags.PriceType, Tags.NoTradingSessionRules, Tags.NoNestedInstrAttrib, Tags.NoStrikeRules, 0};
                            public QuickFix.Fields.MarketID marketID
                { 
                    get 
                    {
                        QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MarketID val) 
                { 
                    this.marketID = val;
                }
                
                public QuickFix.Fields.MarketID get(QuickFix.Fields.MarketID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MarketID val) 
                { 
                    return isSetMarketID();
                }
                
                public bool isSetMarketID() 
                { 
                    return isSetField(Tags.MarketID);
                }
                public QuickFix.Fields.MarketSegmentID marketSegmentID
                { 
                    get 
                    {
                        QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MarketSegmentID val) 
                { 
                    this.marketSegmentID = val;
                }
                
                public QuickFix.Fields.MarketSegmentID get(QuickFix.Fields.MarketSegmentID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MarketSegmentID val) 
                { 
                    return isSetMarketSegmentID();
                }
                
                public bool isSetMarketSegmentID() 
                { 
                    return isSetField(Tags.MarketSegmentID);
                }
                public QuickFix.Fields.NoTickRules noTickRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoTickRules val = new QuickFix.Fields.NoTickRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoTickRules val) 
                { 
                    this.noTickRules = val;
                }
                
                public QuickFix.Fields.NoTickRules get(QuickFix.Fields.NoTickRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoTickRules val) 
                { 
                    return isSetNoTickRules();
                }
                
                public bool isSetNoTickRules() 
                { 
                    return isSetField(Tags.NoTickRules);
                }
                public QuickFix.Fields.NoLotTypeRules noLotTypeRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoLotTypeRules val = new QuickFix.Fields.NoLotTypeRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    this.noLotTypeRules = val;
                }
                
                public QuickFix.Fields.NoLotTypeRules get(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoLotTypeRules val) 
                { 
                    return isSetNoLotTypeRules();
                }
                
                public bool isSetNoLotTypeRules() 
                { 
                    return isSetField(Tags.NoLotTypeRules);
                }
                public QuickFix.Fields.PriceLimitType priceLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.PriceLimitType val = new QuickFix.Fields.PriceLimitType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceLimitType val) 
                { 
                    this.priceLimitType = val;
                }
                
                public QuickFix.Fields.PriceLimitType get(QuickFix.Fields.PriceLimitType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceLimitType val) 
                { 
                    return isSetPriceLimitType();
                }
                
                public bool isSetPriceLimitType() 
                { 
                    return isSetField(Tags.PriceLimitType);
                }
                public QuickFix.Fields.LowLimitPrice lowLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.LowLimitPrice val = new QuickFix.Fields.LowLimitPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LowLimitPrice val) 
                { 
                    this.lowLimitPrice = val;
                }
                
                public QuickFix.Fields.LowLimitPrice get(QuickFix.Fields.LowLimitPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LowLimitPrice val) 
                { 
                    return isSetLowLimitPrice();
                }
                
                public bool isSetLowLimitPrice() 
                { 
                    return isSetField(Tags.LowLimitPrice);
                }
                public QuickFix.Fields.HighLimitPrice highLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.HighLimitPrice val = new QuickFix.Fields.HighLimitPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.HighLimitPrice val) 
                { 
                    this.highLimitPrice = val;
                }
                
                public QuickFix.Fields.HighLimitPrice get(QuickFix.Fields.HighLimitPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.HighLimitPrice val) 
                { 
                    return isSetHighLimitPrice();
                }
                
                public bool isSetHighLimitPrice() 
                { 
                    return isSetField(Tags.HighLimitPrice);
                }
                public QuickFix.Fields.TradingReferencePrice tradingReferencePrice
                { 
                    get 
                    {
                        QuickFix.Fields.TradingReferencePrice val = new QuickFix.Fields.TradingReferencePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    this.tradingReferencePrice = val;
                }
                
                public QuickFix.Fields.TradingReferencePrice get(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradingReferencePrice val) 
                { 
                    return isSetTradingReferencePrice();
                }
                
                public bool isSetTradingReferencePrice() 
                { 
                    return isSetField(Tags.TradingReferencePrice);
                }
                public QuickFix.Fields.ExpirationCycle expirationCycle
                { 
                    get 
                    {
                        QuickFix.Fields.ExpirationCycle val = new QuickFix.Fields.ExpirationCycle();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExpirationCycle val) 
                { 
                    this.expirationCycle = val;
                }
                
                public QuickFix.Fields.ExpirationCycle get(QuickFix.Fields.ExpirationCycle val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExpirationCycle val) 
                { 
                    return isSetExpirationCycle();
                }
                
                public bool isSetExpirationCycle() 
                { 
                    return isSetField(Tags.ExpirationCycle);
                }
                public QuickFix.Fields.MinTradeVol minTradeVol
                { 
                    get 
                    {
                        QuickFix.Fields.MinTradeVol val = new QuickFix.Fields.MinTradeVol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinTradeVol val) 
                { 
                    this.minTradeVol = val;
                }
                
                public QuickFix.Fields.MinTradeVol get(QuickFix.Fields.MinTradeVol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinTradeVol val) 
                { 
                    return isSetMinTradeVol();
                }
                
                public bool isSetMinTradeVol() 
                { 
                    return isSetField(Tags.MinTradeVol);
                }
                public QuickFix.Fields.MaxTradeVol maxTradeVol
                { 
                    get 
                    {
                        QuickFix.Fields.MaxTradeVol val = new QuickFix.Fields.MaxTradeVol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaxTradeVol val) 
                { 
                    this.maxTradeVol = val;
                }
                
                public QuickFix.Fields.MaxTradeVol get(QuickFix.Fields.MaxTradeVol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaxTradeVol val) 
                { 
                    return isSetMaxTradeVol();
                }
                
                public bool isSetMaxTradeVol() 
                { 
                    return isSetField(Tags.MaxTradeVol);
                }
                public QuickFix.Fields.MaxPriceVariation maxPriceVariation
                { 
                    get 
                    {
                        QuickFix.Fields.MaxPriceVariation val = new QuickFix.Fields.MaxPriceVariation();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    this.maxPriceVariation = val;
                }
                
                public QuickFix.Fields.MaxPriceVariation get(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaxPriceVariation val) 
                { 
                    return isSetMaxPriceVariation();
                }
                
                public bool isSetMaxPriceVariation() 
                { 
                    return isSetField(Tags.MaxPriceVariation);
                }
                public QuickFix.Fields.ImpliedMarketIndicator impliedMarketIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.ImpliedMarketIndicator val = new QuickFix.Fields.ImpliedMarketIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    this.impliedMarketIndicator = val;
                }
                
                public QuickFix.Fields.ImpliedMarketIndicator get(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ImpliedMarketIndicator val) 
                { 
                    return isSetImpliedMarketIndicator();
                }
                
                public bool isSetImpliedMarketIndicator() 
                { 
                    return isSetField(Tags.ImpliedMarketIndicator);
                }
                public QuickFix.Fields.TradingCurrency tradingCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.TradingCurrency val = new QuickFix.Fields.TradingCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TradingCurrency val) 
                { 
                    this.tradingCurrency = val;
                }
                
                public QuickFix.Fields.TradingCurrency get(QuickFix.Fields.TradingCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TradingCurrency val) 
                { 
                    return isSetTradingCurrency();
                }
                
                public bool isSetTradingCurrency() 
                { 
                    return isSetField(Tags.TradingCurrency);
                }
                public QuickFix.Fields.RoundLot roundLot
                { 
                    get 
                    {
                        QuickFix.Fields.RoundLot val = new QuickFix.Fields.RoundLot();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RoundLot val) 
                { 
                    this.roundLot = val;
                }
                
                public QuickFix.Fields.RoundLot get(QuickFix.Fields.RoundLot val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RoundLot val) 
                { 
                    return isSetRoundLot();
                }
                
                public bool isSetRoundLot() 
                { 
                    return isSetField(Tags.RoundLot);
                }
                public QuickFix.Fields.MultilegModel multilegModel
                { 
                    get 
                    {
                        QuickFix.Fields.MultilegModel val = new QuickFix.Fields.MultilegModel();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MultilegModel val) 
                { 
                    this.multilegModel = val;
                }
                
                public QuickFix.Fields.MultilegModel get(QuickFix.Fields.MultilegModel val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MultilegModel val) 
                { 
                    return isSetMultilegModel();
                }
                
                public bool isSetMultilegModel() 
                { 
                    return isSetField(Tags.MultilegModel);
                }
                public QuickFix.Fields.MultilegPriceMethod multilegPriceMethod
                { 
                    get 
                    {
                        QuickFix.Fields.MultilegPriceMethod val = new QuickFix.Fields.MultilegPriceMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    this.multilegPriceMethod = val;
                }
                
                public QuickFix.Fields.MultilegPriceMethod get(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MultilegPriceMethod val) 
                { 
                    return isSetMultilegPriceMethod();
                }
                
                public bool isSetMultilegPriceMethod() 
                { 
                    return isSetField(Tags.MultilegPriceMethod);
                }
                public QuickFix.Fields.PriceType priceType
                { 
                    get 
                    {
                        QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceType val) 
                { 
                    this.priceType = val;
                }
                
                public QuickFix.Fields.PriceType get(QuickFix.Fields.PriceType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceType val) 
                { 
                    return isSetPriceType();
                }
                
                public bool isSetPriceType() 
                { 
                    return isSetField(Tags.PriceType);
                }
                public QuickFix.Fields.NoTradingSessionRules noTradingSessionRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoTradingSessionRules val = new QuickFix.Fields.NoTradingSessionRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    this.noTradingSessionRules = val;
                }
                
                public QuickFix.Fields.NoTradingSessionRules get(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoTradingSessionRules val) 
                { 
                    return isSetNoTradingSessionRules();
                }
                
                public bool isSetNoTradingSessionRules() 
                { 
                    return isSetField(Tags.NoTradingSessionRules);
                }
                public QuickFix.Fields.NoNestedInstrAttrib noNestedInstrAttrib
                { 
                    get 
                    {
                        QuickFix.Fields.NoNestedInstrAttrib val = new QuickFix.Fields.NoNestedInstrAttrib();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    this.noNestedInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoNestedInstrAttrib get(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoNestedInstrAttrib val) 
                { 
                    return isSetNoNestedInstrAttrib();
                }
                
                public bool isSetNoNestedInstrAttrib() 
                { 
                    return isSetField(Tags.NoNestedInstrAttrib);
                }
                public QuickFix.Fields.NoStrikeRules noStrikeRules
                { 
                    get 
                    {
                        QuickFix.Fields.NoStrikeRules val = new QuickFix.Fields.NoStrikeRules();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoStrikeRules val) 
                { 
                    this.noStrikeRules = val;
                }
                
                public QuickFix.Fields.NoStrikeRules get(QuickFix.Fields.NoStrikeRules val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoStrikeRules val) 
                { 
                    return isSetNoStrikeRules();
                }
                
                public bool isSetNoStrikeRules() 
                { 
                    return isSetField(Tags.NoStrikeRules);
                }
                            public class NoTickRules : Group
                {
                    public NoTickRules() 
                      :base( Tags.NoTickRules, Tags.StartTickPriceRange, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.StartTickPriceRange, Tags.EndTickPriceRange, Tags.TickIncrement, Tags.TickRuleType, 0};
                                    public QuickFix.Fields.StartTickPriceRange startTickPriceRange
                    { 
                        get 
                        {
                            QuickFix.Fields.StartTickPriceRange val = new QuickFix.Fields.StartTickPriceRange();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        this.startTickPriceRange = val;
                    }
                    
                    public QuickFix.Fields.StartTickPriceRange get(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StartTickPriceRange val) 
                    { 
                        return isSetStartTickPriceRange();
                    }
                    
                    public bool isSetStartTickPriceRange() 
                    { 
                        return isSetField(Tags.StartTickPriceRange);
                    }
                    public QuickFix.Fields.EndTickPriceRange endTickPriceRange
                    { 
                        get 
                        {
                            QuickFix.Fields.EndTickPriceRange val = new QuickFix.Fields.EndTickPriceRange();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        this.endTickPriceRange = val;
                    }
                    
                    public QuickFix.Fields.EndTickPriceRange get(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EndTickPriceRange val) 
                    { 
                        return isSetEndTickPriceRange();
                    }
                    
                    public bool isSetEndTickPriceRange() 
                    { 
                        return isSetField(Tags.EndTickPriceRange);
                    }
                    public QuickFix.Fields.TickIncrement tickIncrement
                    { 
                        get 
                        {
                            QuickFix.Fields.TickIncrement val = new QuickFix.Fields.TickIncrement();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.TickIncrement val) 
                    { 
                        this.tickIncrement = val;
                    }
                    
                    public QuickFix.Fields.TickIncrement get(QuickFix.Fields.TickIncrement val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.TickIncrement val) 
                    { 
                        return isSetTickIncrement();
                    }
                    
                    public bool isSetTickIncrement() 
                    { 
                        return isSetField(Tags.TickIncrement);
                    }
                    public QuickFix.Fields.TickRuleType tickRuleType
                    { 
                        get 
                        {
                            QuickFix.Fields.TickRuleType val = new QuickFix.Fields.TickRuleType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.TickRuleType val) 
                    { 
                        this.tickRuleType = val;
                    }
                    
                    public QuickFix.Fields.TickRuleType get(QuickFix.Fields.TickRuleType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.TickRuleType val) 
                    { 
                        return isSetTickRuleType();
                    }
                    
                    public bool isSetTickRuleType() 
                    { 
                        return isSetField(Tags.TickRuleType);
                    }
                
                }
                public class NoLotTypeRules : Group
                {
                    public NoLotTypeRules() 
                      :base( Tags.NoLotTypeRules, Tags.LotType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.LotType, Tags.MinLotSize, 0};
                                    public QuickFix.Fields.LotType lotType
                    { 
                        get 
                        {
                            QuickFix.Fields.LotType val = new QuickFix.Fields.LotType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LotType val) 
                    { 
                        this.lotType = val;
                    }
                    
                    public QuickFix.Fields.LotType get(QuickFix.Fields.LotType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LotType val) 
                    { 
                        return isSetLotType();
                    }
                    
                    public bool isSetLotType() 
                    { 
                        return isSetField(Tags.LotType);
                    }
                    public QuickFix.Fields.MinLotSize minLotSize
                    { 
                        get 
                        {
                            QuickFix.Fields.MinLotSize val = new QuickFix.Fields.MinLotSize();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.MinLotSize val) 
                    { 
                        this.minLotSize = val;
                    }
                    
                    public QuickFix.Fields.MinLotSize get(QuickFix.Fields.MinLotSize val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.MinLotSize val) 
                    { 
                        return isSetMinLotSize();
                    }
                    
                    public bool isSetMinLotSize() 
                    { 
                        return isSetField(Tags.MinLotSize);
                    }
                
                }
                public class NoTradingSessionRules : Group
                {
                    public NoTradingSessionRules() 
                      :base( Tags.NoTradingSessionRules, Tags.TradingSessionID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.NoOrdTypeRules, Tags.NoTimeInForceRules, Tags.NoExecInstRules, Tags.NoMatchRules, Tags.NoMDFeedTypes, 0};
                                    public QuickFix.Fields.TradingSessionID tradingSessionID
                    { 
                        get 
                        {
                            QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.TradingSessionID val) 
                    { 
                        this.tradingSessionID = val;
                    }
                    
                    public QuickFix.Fields.TradingSessionID get(QuickFix.Fields.TradingSessionID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.TradingSessionID val) 
                    { 
                        return isSetTradingSessionID();
                    }
                    
                    public bool isSetTradingSessionID() 
                    { 
                        return isSetField(Tags.TradingSessionID);
                    }
                    public QuickFix.Fields.TradingSessionSubID tradingSessionSubID
                    { 
                        get 
                        {
                            QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.TradingSessionSubID val) 
                    { 
                        this.tradingSessionSubID = val;
                    }
                    
                    public QuickFix.Fields.TradingSessionSubID get(QuickFix.Fields.TradingSessionSubID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.TradingSessionSubID val) 
                    { 
                        return isSetTradingSessionSubID();
                    }
                    
                    public bool isSetTradingSessionSubID() 
                    { 
                        return isSetField(Tags.TradingSessionSubID);
                    }
                    public QuickFix.Fields.NoOrdTypeRules noOrdTypeRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoOrdTypeRules val = new QuickFix.Fields.NoOrdTypeRules();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        this.noOrdTypeRules = val;
                    }
                    
                    public QuickFix.Fields.NoOrdTypeRules get(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoOrdTypeRules val) 
                    { 
                        return isSetNoOrdTypeRules();
                    }
                    
                    public bool isSetNoOrdTypeRules() 
                    { 
                        return isSetField(Tags.NoOrdTypeRules);
                    }
                    public QuickFix.Fields.NoTimeInForceRules noTimeInForceRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoTimeInForceRules val = new QuickFix.Fields.NoTimeInForceRules();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        this.noTimeInForceRules = val;
                    }
                    
                    public QuickFix.Fields.NoTimeInForceRules get(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoTimeInForceRules val) 
                    { 
                        return isSetNoTimeInForceRules();
                    }
                    
                    public bool isSetNoTimeInForceRules() 
                    { 
                        return isSetField(Tags.NoTimeInForceRules);
                    }
                    public QuickFix.Fields.NoExecInstRules noExecInstRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoExecInstRules val = new QuickFix.Fields.NoExecInstRules();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        this.noExecInstRules = val;
                    }
                    
                    public QuickFix.Fields.NoExecInstRules get(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoExecInstRules val) 
                    { 
                        return isSetNoExecInstRules();
                    }
                    
                    public bool isSetNoExecInstRules() 
                    { 
                        return isSetField(Tags.NoExecInstRules);
                    }
                    public QuickFix.Fields.NoMatchRules noMatchRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoMatchRules val = new QuickFix.Fields.NoMatchRules();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoMatchRules val) 
                    { 
                        this.noMatchRules = val;
                    }
                    
                    public QuickFix.Fields.NoMatchRules get(QuickFix.Fields.NoMatchRules val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoMatchRules val) 
                    { 
                        return isSetNoMatchRules();
                    }
                    
                    public bool isSetNoMatchRules() 
                    { 
                        return isSetField(Tags.NoMatchRules);
                    }
                    public QuickFix.Fields.NoMDFeedTypes noMDFeedTypes
                    { 
                        get 
                        {
                            QuickFix.Fields.NoMDFeedTypes val = new QuickFix.Fields.NoMDFeedTypes();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        this.noMDFeedTypes = val;
                    }
                    
                    public QuickFix.Fields.NoMDFeedTypes get(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoMDFeedTypes val) 
                    { 
                        return isSetNoMDFeedTypes();
                    }
                    
                    public bool isSetNoMDFeedTypes() 
                    { 
                        return isSetField(Tags.NoMDFeedTypes);
                    }
                                    public class NoOrdTypeRules : Group
                    {
                        public NoOrdTypeRules() 
                          :base( Tags.NoOrdTypeRules, Tags.OrdType, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.OrdType, 0};
                                            public QuickFix.Fields.OrdType ordType
                        { 
                            get 
                            {
                                QuickFix.Fields.OrdType val = new QuickFix.Fields.OrdType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.OrdType val) 
                        { 
                            this.ordType = val;
                        }
                        
                        public QuickFix.Fields.OrdType get(QuickFix.Fields.OrdType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.OrdType val) 
                        { 
                            return isSetOrdType();
                        }
                        
                        public bool isSetOrdType() 
                        { 
                            return isSetField(Tags.OrdType);
                        }
                    
                    }
                    public class NoTimeInForceRules : Group
                    {
                        public NoTimeInForceRules() 
                          :base( Tags.NoTimeInForceRules, Tags.TimeInForce, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.TimeInForce, 0};
                                            public QuickFix.Fields.TimeInForce timeInForce
                        { 
                            get 
                            {
                                QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.TimeInForce val) 
                        { 
                            this.timeInForce = val;
                        }
                        
                        public QuickFix.Fields.TimeInForce get(QuickFix.Fields.TimeInForce val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.TimeInForce val) 
                        { 
                            return isSetTimeInForce();
                        }
                        
                        public bool isSetTimeInForce() 
                        { 
                            return isSetField(Tags.TimeInForce);
                        }
                    
                    }
                    public class NoExecInstRules : Group
                    {
                        public NoExecInstRules() 
                          :base( Tags.NoExecInstRules, Tags.ExecInstValue, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.ExecInstValue, 0};
                                            public QuickFix.Fields.ExecInstValue execInstValue
                        { 
                            get 
                            {
                                QuickFix.Fields.ExecInstValue val = new QuickFix.Fields.ExecInstValue();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.ExecInstValue val) 
                        { 
                            this.execInstValue = val;
                        }
                        
                        public QuickFix.Fields.ExecInstValue get(QuickFix.Fields.ExecInstValue val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.ExecInstValue val) 
                        { 
                            return isSetExecInstValue();
                        }
                        
                        public bool isSetExecInstValue() 
                        { 
                            return isSetField(Tags.ExecInstValue);
                        }
                    
                    }
                    public class NoMatchRules : Group
                    {
                        public NoMatchRules() 
                          :base( Tags.NoMatchRules, Tags.MatchAlgorithm, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.MatchAlgorithm, Tags.MatchType, 0};
                                            public QuickFix.Fields.MatchAlgorithm matchAlgorithm
                        { 
                            get 
                            {
                                QuickFix.Fields.MatchAlgorithm val = new QuickFix.Fields.MatchAlgorithm();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            this.matchAlgorithm = val;
                        }
                        
                        public QuickFix.Fields.MatchAlgorithm get(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MatchAlgorithm val) 
                        { 
                            return isSetMatchAlgorithm();
                        }
                        
                        public bool isSetMatchAlgorithm() 
                        { 
                            return isSetField(Tags.MatchAlgorithm);
                        }
                        public QuickFix.Fields.MatchType matchType
                        { 
                            get 
                            {
                                QuickFix.Fields.MatchType val = new QuickFix.Fields.MatchType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MatchType val) 
                        { 
                            this.matchType = val;
                        }
                        
                        public QuickFix.Fields.MatchType get(QuickFix.Fields.MatchType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MatchType val) 
                        { 
                            return isSetMatchType();
                        }
                        
                        public bool isSetMatchType() 
                        { 
                            return isSetField(Tags.MatchType);
                        }
                    
                    }
                    public class NoMDFeedTypes : Group
                    {
                        public NoMDFeedTypes() 
                          :base( Tags.NoMDFeedTypes, Tags.MDFeedType, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.MDFeedType, Tags.MarketDepth, Tags.MDBookType, 0};
                                            public QuickFix.Fields.MDFeedType mDFeedType
                        { 
                            get 
                            {
                                QuickFix.Fields.MDFeedType val = new QuickFix.Fields.MDFeedType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MDFeedType val) 
                        { 
                            this.mDFeedType = val;
                        }
                        
                        public QuickFix.Fields.MDFeedType get(QuickFix.Fields.MDFeedType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MDFeedType val) 
                        { 
                            return isSetMDFeedType();
                        }
                        
                        public bool isSetMDFeedType() 
                        { 
                            return isSetField(Tags.MDFeedType);
                        }
                        public QuickFix.Fields.MarketDepth marketDepth
                        { 
                            get 
                            {
                                QuickFix.Fields.MarketDepth val = new QuickFix.Fields.MarketDepth();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MarketDepth val) 
                        { 
                            this.marketDepth = val;
                        }
                        
                        public QuickFix.Fields.MarketDepth get(QuickFix.Fields.MarketDepth val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MarketDepth val) 
                        { 
                            return isSetMarketDepth();
                        }
                        
                        public bool isSetMarketDepth() 
                        { 
                            return isSetField(Tags.MarketDepth);
                        }
                        public QuickFix.Fields.MDBookType mDBookType
                        { 
                            get 
                            {
                                QuickFix.Fields.MDBookType val = new QuickFix.Fields.MDBookType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MDBookType val) 
                        { 
                            this.mDBookType = val;
                        }
                        
                        public QuickFix.Fields.MDBookType get(QuickFix.Fields.MDBookType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MDBookType val) 
                        { 
                            return isSetMDBookType();
                        }
                        
                        public bool isSetMDBookType() 
                        { 
                            return isSetField(Tags.MDBookType);
                        }
                    
                    }
                }
                public class NoNestedInstrAttrib : Group
                {
                    public NoNestedInstrAttrib() 
                      :base( Tags.NoNestedInstrAttrib, Tags.NestedInstrAttribType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.NestedInstrAttribType, Tags.NestedInstrAttribValue, 0};
                                    public QuickFix.Fields.NestedInstrAttribType nestedInstrAttribType
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedInstrAttribType val = new QuickFix.Fields.NestedInstrAttribType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        this.nestedInstrAttribType = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribType get(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedInstrAttribType val) 
                    { 
                        return isSetNestedInstrAttribType();
                    }
                    
                    public bool isSetNestedInstrAttribType() 
                    { 
                        return isSetField(Tags.NestedInstrAttribType);
                    }
                    public QuickFix.Fields.NestedInstrAttribValue nestedInstrAttribValue
                    { 
                        get 
                        {
                            QuickFix.Fields.NestedInstrAttribValue val = new QuickFix.Fields.NestedInstrAttribValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        this.nestedInstrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.NestedInstrAttribValue get(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NestedInstrAttribValue val) 
                    { 
                        return isSetNestedInstrAttribValue();
                    }
                    
                    public bool isSetNestedInstrAttribValue() 
                    { 
                        return isSetField(Tags.NestedInstrAttribValue);
                    }
                
                }
                public class NoStrikeRules : Group
                {
                    public NoStrikeRules() 
                      :base( Tags.NoStrikeRules, Tags.StrikeRuleID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.StrikeRuleID, Tags.StartStrikePxRange, Tags.EndStrikePxRange, Tags.StrikeIncrement, Tags.StrikeExerciseStyle, Tags.NoMaturityRules, 0};
                                    public QuickFix.Fields.StrikeRuleID strikeRuleID
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeRuleID val = new QuickFix.Fields.StrikeRuleID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        this.strikeRuleID = val;
                    }
                    
                    public QuickFix.Fields.StrikeRuleID get(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StrikeRuleID val) 
                    { 
                        return isSetStrikeRuleID();
                    }
                    
                    public bool isSetStrikeRuleID() 
                    { 
                        return isSetField(Tags.StrikeRuleID);
                    }
                    public QuickFix.Fields.StartStrikePxRange startStrikePxRange
                    { 
                        get 
                        {
                            QuickFix.Fields.StartStrikePxRange val = new QuickFix.Fields.StartStrikePxRange();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        this.startStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.StartStrikePxRange get(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StartStrikePxRange val) 
                    { 
                        return isSetStartStrikePxRange();
                    }
                    
                    public bool isSetStartStrikePxRange() 
                    { 
                        return isSetField(Tags.StartStrikePxRange);
                    }
                    public QuickFix.Fields.EndStrikePxRange endStrikePxRange
                    { 
                        get 
                        {
                            QuickFix.Fields.EndStrikePxRange val = new QuickFix.Fields.EndStrikePxRange();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        this.endStrikePxRange = val;
                    }
                    
                    public QuickFix.Fields.EndStrikePxRange get(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EndStrikePxRange val) 
                    { 
                        return isSetEndStrikePxRange();
                    }
                    
                    public bool isSetEndStrikePxRange() 
                    { 
                        return isSetField(Tags.EndStrikePxRange);
                    }
                    public QuickFix.Fields.StrikeIncrement strikeIncrement
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeIncrement val = new QuickFix.Fields.StrikeIncrement();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        this.strikeIncrement = val;
                    }
                    
                    public QuickFix.Fields.StrikeIncrement get(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StrikeIncrement val) 
                    { 
                        return isSetStrikeIncrement();
                    }
                    
                    public bool isSetStrikeIncrement() 
                    { 
                        return isSetField(Tags.StrikeIncrement);
                    }
                    public QuickFix.Fields.StrikeExerciseStyle strikeExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.StrikeExerciseStyle val = new QuickFix.Fields.StrikeExerciseStyle();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        this.strikeExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.StrikeExerciseStyle get(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.StrikeExerciseStyle val) 
                    { 
                        return isSetStrikeExerciseStyle();
                    }
                    
                    public bool isSetStrikeExerciseStyle() 
                    { 
                        return isSetField(Tags.StrikeExerciseStyle);
                    }
                    public QuickFix.Fields.NoMaturityRules noMaturityRules
                    { 
                        get 
                        {
                            QuickFix.Fields.NoMaturityRules val = new QuickFix.Fields.NoMaturityRules();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        this.noMaturityRules = val;
                    }
                    
                    public QuickFix.Fields.NoMaturityRules get(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoMaturityRules val) 
                    { 
                        return isSetNoMaturityRules();
                    }
                    
                    public bool isSetNoMaturityRules() 
                    { 
                        return isSetField(Tags.NoMaturityRules);
                    }
                                    public class NoMaturityRules : Group
                    {
                        public NoMaturityRules() 
                          :base( Tags.NoMaturityRules, Tags.MaturityRuleID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.MaturityRuleID, Tags.MaturityMonthYearFormat, Tags.MaturityMonthYearIncrementUnits, Tags.StartMaturityMonthYear, Tags.EndMaturityMonthYear, Tags.MaturityMonthYearIncrement, 0};
                                            public QuickFix.Fields.MaturityRuleID maturityRuleID
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityRuleID val = new QuickFix.Fields.MaturityRuleID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            this.maturityRuleID = val;
                        }
                        
                        public QuickFix.Fields.MaturityRuleID get(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MaturityRuleID val) 
                        { 
                            return isSetMaturityRuleID();
                        }
                        
                        public bool isSetMaturityRuleID() 
                        { 
                            return isSetField(Tags.MaturityRuleID);
                        }
                        public QuickFix.Fields.MaturityMonthYearFormat maturityMonthYearFormat
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityMonthYearFormat val = new QuickFix.Fields.MaturityMonthYearFormat();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            this.maturityMonthYearFormat = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearFormat get(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MaturityMonthYearFormat val) 
                        { 
                            return isSetMaturityMonthYearFormat();
                        }
                        
                        public bool isSetMaturityMonthYearFormat() 
                        { 
                            return isSetField(Tags.MaturityMonthYearFormat);
                        }
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits maturityMonthYearIncrementUnits
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityMonthYearIncrementUnits val = new QuickFix.Fields.MaturityMonthYearIncrementUnits();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            this.maturityMonthYearIncrementUnits = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrementUnits get(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MaturityMonthYearIncrementUnits val) 
                        { 
                            return isSetMaturityMonthYearIncrementUnits();
                        }
                        
                        public bool isSetMaturityMonthYearIncrementUnits() 
                        { 
                            return isSetField(Tags.MaturityMonthYearIncrementUnits);
                        }
                        public QuickFix.Fields.StartMaturityMonthYear startMaturityMonthYear
                        { 
                            get 
                            {
                                QuickFix.Fields.StartMaturityMonthYear val = new QuickFix.Fields.StartMaturityMonthYear();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            this.startMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.StartMaturityMonthYear get(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.StartMaturityMonthYear val) 
                        { 
                            return isSetStartMaturityMonthYear();
                        }
                        
                        public bool isSetStartMaturityMonthYear() 
                        { 
                            return isSetField(Tags.StartMaturityMonthYear);
                        }
                        public QuickFix.Fields.EndMaturityMonthYear endMaturityMonthYear
                        { 
                            get 
                            {
                                QuickFix.Fields.EndMaturityMonthYear val = new QuickFix.Fields.EndMaturityMonthYear();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            this.endMaturityMonthYear = val;
                        }
                        
                        public QuickFix.Fields.EndMaturityMonthYear get(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.EndMaturityMonthYear val) 
                        { 
                            return isSetEndMaturityMonthYear();
                        }
                        
                        public bool isSetEndMaturityMonthYear() 
                        { 
                            return isSetField(Tags.EndMaturityMonthYear);
                        }
                        public QuickFix.Fields.MaturityMonthYearIncrement maturityMonthYearIncrement
                        { 
                            get 
                            {
                                QuickFix.Fields.MaturityMonthYearIncrement val = new QuickFix.Fields.MaturityMonthYearIncrement();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            this.maturityMonthYearIncrement = val;
                        }
                        
                        public QuickFix.Fields.MaturityMonthYearIncrement get(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.MaturityMonthYearIncrement val) 
                        { 
                            return isSetMaturityMonthYearIncrement();
                        }
                        
                        public bool isSetMaturityMonthYearIncrement() 
                        { 
                            return isSetField(Tags.MaturityMonthYearIncrement);
                        }
                    
                    }
                }
            }
            public class NoRelatedSym : Group
            {
                public NoRelatedSym() 
                  :base( Tags.NoRelatedSym, Tags.ListUpdateAction, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.ListUpdateAction, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.SecurityIDSource, Tags.NoSecurityAltID, Tags.Product, Tags.CFICode, Tags.SecurityType, Tags.SecuritySubType, Tags.MaturityMonthYear, Tags.MaturityDate, Tags.CouponPaymentDate, Tags.IssueDate, Tags.RepoCollateralSecurityType, Tags.RepurchaseTerm, Tags.RepurchaseRate, Tags.Factor, Tags.CreditRating, Tags.InstrRegistry, Tags.CountryOfIssue, Tags.StateOrProvinceOfIssue, Tags.LocaleOfIssue, Tags.RedemptionDate, Tags.StrikePrice, Tags.StrikeCurrency, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.Pool, Tags.ContractSettlMonth, Tags.CPProgram, Tags.CPRegType, Tags.NoEvents, Tags.DatedDate, Tags.InterestAccrualDate, Tags.SecurityStatus, Tags.SettleOnOpenFlag, Tags.InstrmtAssignmentMethod, Tags.StrikeMultiplier, Tags.StrikeValue, Tags.MinPriceIncrement, Tags.PositionLimit, Tags.NTPositionLimit, Tags.NoInstrumentParties, Tags.UnitOfMeasure, Tags.TimeUnit, Tags.MaturityTime, Tags.SecurityGroup, Tags.MinPriceIncrementAmount, Tags.UnitOfMeasureQty, Tags.SecurityXMLLen, Tags.SecurityXML, Tags.SecurityXMLSchema, Tags.ProductComplex, Tags.PriceUnitOfMeasure, Tags.PriceUnitOfMeasureQty, Tags.SettlMethod, Tags.ExerciseStyle, Tags.OptPayAmount, Tags.PriceQuoteMethod, Tags.ListMethod, Tags.CapPrice, Tags.FloorPrice, Tags.PutOrCall, Tags.FlexibleIndicator, Tags.FlexProductEligibilityIndicator, Tags.FuturesValuationMethod, Tags.DeliveryForm, Tags.PctAtRisk, Tags.NoInstrAttrib, Tags.SecondaryPriceLimitType, Tags.SecondaryLowLimitPrice, Tags.SecondaryHighLimitPrice, Tags.SecondaryTradingReferencePrice, Tags.Currency, Tags.NoLegs, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, Tags.CorporateAction, 0};
                            public QuickFix.Fields.ListUpdateAction listUpdateAction
                { 
                    get 
                    {
                        QuickFix.Fields.ListUpdateAction val = new QuickFix.Fields.ListUpdateAction();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ListUpdateAction val) 
                { 
                    this.listUpdateAction = val;
                }
                
                public QuickFix.Fields.ListUpdateAction get(QuickFix.Fields.ListUpdateAction val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ListUpdateAction val) 
                { 
                    return isSetListUpdateAction();
                }
                
                public bool isSetListUpdateAction() 
                { 
                    return isSetField(Tags.ListUpdateAction);
                }
                public QuickFix.Fields.Symbol symbol
                { 
                    get 
                    {
                        QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Symbol val) 
                { 
                    this.symbol = val;
                }
                
                public QuickFix.Fields.Symbol get(QuickFix.Fields.Symbol val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Symbol val) 
                { 
                    return isSetSymbol();
                }
                
                public bool isSetSymbol() 
                { 
                    return isSetField(Tags.Symbol);
                }
                public QuickFix.Fields.SymbolSfx symbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SymbolSfx val) 
                { 
                    this.symbolSfx = val;
                }
                
                public QuickFix.Fields.SymbolSfx get(QuickFix.Fields.SymbolSfx val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SymbolSfx val) 
                { 
                    return isSetSymbolSfx();
                }
                
                public bool isSetSymbolSfx() 
                { 
                    return isSetField(Tags.SymbolSfx);
                }
                public QuickFix.Fields.SecurityID securityID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityID val) 
                { 
                    this.securityID = val;
                }
                
                public QuickFix.Fields.SecurityID get(QuickFix.Fields.SecurityID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityID val) 
                { 
                    return isSetSecurityID();
                }
                
                public bool isSetSecurityID() 
                { 
                    return isSetField(Tags.SecurityID);
                }
                public QuickFix.Fields.SecurityIDSource securityIDSource
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityIDSource val) 
                { 
                    this.securityIDSource = val;
                }
                
                public QuickFix.Fields.SecurityIDSource get(QuickFix.Fields.SecurityIDSource val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityIDSource val) 
                { 
                    return isSetSecurityIDSource();
                }
                
                public bool isSetSecurityIDSource() 
                { 
                    return isSetField(Tags.SecurityIDSource);
                }
                public QuickFix.Fields.NoSecurityAltID noSecurityAltID
                { 
                    get 
                    {
                        QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoSecurityAltID val) 
                { 
                    this.noSecurityAltID = val;
                }
                
                public QuickFix.Fields.NoSecurityAltID get(QuickFix.Fields.NoSecurityAltID val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoSecurityAltID val) 
                { 
                    return isSetNoSecurityAltID();
                }
                
                public bool isSetNoSecurityAltID() 
                { 
                    return isSetField(Tags.NoSecurityAltID);
                }
                public QuickFix.Fields.Product product
                { 
                    get 
                    {
                        QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Product val) 
                { 
                    this.product = val;
                }
                
                public QuickFix.Fields.Product get(QuickFix.Fields.Product val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Product val) 
                { 
                    return isSetProduct();
                }
                
                public bool isSetProduct() 
                { 
                    return isSetField(Tags.Product);
                }
                public QuickFix.Fields.CFICode cFICode
                { 
                    get 
                    {
                        QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CFICode val) 
                { 
                    this.cFICode = val;
                }
                
                public QuickFix.Fields.CFICode get(QuickFix.Fields.CFICode val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CFICode val) 
                { 
                    return isSetCFICode();
                }
                
                public bool isSetCFICode() 
                { 
                    return isSetField(Tags.CFICode);
                }
                public QuickFix.Fields.SecurityType securityType
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityType val) 
                { 
                    this.securityType = val;
                }
                
                public QuickFix.Fields.SecurityType get(QuickFix.Fields.SecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityType val) 
                { 
                    return isSetSecurityType();
                }
                
                public bool isSetSecurityType() 
                { 
                    return isSetField(Tags.SecurityType);
                }
                public QuickFix.Fields.SecuritySubType securitySubType
                { 
                    get 
                    {
                        QuickFix.Fields.SecuritySubType val = new QuickFix.Fields.SecuritySubType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecuritySubType val) 
                { 
                    this.securitySubType = val;
                }
                
                public QuickFix.Fields.SecuritySubType get(QuickFix.Fields.SecuritySubType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecuritySubType val) 
                { 
                    return isSetSecuritySubType();
                }
                
                public bool isSetSecuritySubType() 
                { 
                    return isSetField(Tags.SecuritySubType);
                }
                public QuickFix.Fields.MaturityMonthYear maturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    this.maturityMonthYear = val;
                }
                
                public QuickFix.Fields.MaturityMonthYear get(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    return isSetMaturityMonthYear();
                }
                
                public bool isSetMaturityMonthYear() 
                { 
                    return isSetField(Tags.MaturityMonthYear);
                }
                public QuickFix.Fields.MaturityDate maturityDate
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityDate val) 
                { 
                    this.maturityDate = val;
                }
                
                public QuickFix.Fields.MaturityDate get(QuickFix.Fields.MaturityDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityDate val) 
                { 
                    return isSetMaturityDate();
                }
                
                public bool isSetMaturityDate() 
                { 
                    return isSetField(Tags.MaturityDate);
                }
                public QuickFix.Fields.CouponPaymentDate couponPaymentDate
                { 
                    get 
                    {
                        QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CouponPaymentDate val) 
                { 
                    this.couponPaymentDate = val;
                }
                
                public QuickFix.Fields.CouponPaymentDate get(QuickFix.Fields.CouponPaymentDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CouponPaymentDate val) 
                { 
                    return isSetCouponPaymentDate();
                }
                
                public bool isSetCouponPaymentDate() 
                { 
                    return isSetField(Tags.CouponPaymentDate);
                }
                public QuickFix.Fields.IssueDate issueDate
                { 
                    get 
                    {
                        QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.IssueDate val) 
                { 
                    this.issueDate = val;
                }
                
                public QuickFix.Fields.IssueDate get(QuickFix.Fields.IssueDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.IssueDate val) 
                { 
                    return isSetIssueDate();
                }
                
                public bool isSetIssueDate() 
                { 
                    return isSetField(Tags.IssueDate);
                }
                public QuickFix.Fields.RepoCollateralSecurityType repoCollateralSecurityType
                { 
                    get 
                    {
                        QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RepoCollateralSecurityType val) 
                { 
                    this.repoCollateralSecurityType = val;
                }
                
                public QuickFix.Fields.RepoCollateralSecurityType get(QuickFix.Fields.RepoCollateralSecurityType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RepoCollateralSecurityType val) 
                { 
                    return isSetRepoCollateralSecurityType();
                }
                
                public bool isSetRepoCollateralSecurityType() 
                { 
                    return isSetField(Tags.RepoCollateralSecurityType);
                }
                public QuickFix.Fields.RepurchaseTerm repurchaseTerm
                { 
                    get 
                    {
                        QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RepurchaseTerm val) 
                { 
                    this.repurchaseTerm = val;
                }
                
                public QuickFix.Fields.RepurchaseTerm get(QuickFix.Fields.RepurchaseTerm val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RepurchaseTerm val) 
                { 
                    return isSetRepurchaseTerm();
                }
                
                public bool isSetRepurchaseTerm() 
                { 
                    return isSetField(Tags.RepurchaseTerm);
                }
                public QuickFix.Fields.RepurchaseRate repurchaseRate
                { 
                    get 
                    {
                        QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RepurchaseRate val) 
                { 
                    this.repurchaseRate = val;
                }
                
                public QuickFix.Fields.RepurchaseRate get(QuickFix.Fields.RepurchaseRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RepurchaseRate val) 
                { 
                    return isSetRepurchaseRate();
                }
                
                public bool isSetRepurchaseRate() 
                { 
                    return isSetField(Tags.RepurchaseRate);
                }
                public QuickFix.Fields.Factor factor
                { 
                    get 
                    {
                        QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Factor val) 
                { 
                    this.factor = val;
                }
                
                public QuickFix.Fields.Factor get(QuickFix.Fields.Factor val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Factor val) 
                { 
                    return isSetFactor();
                }
                
                public bool isSetFactor() 
                { 
                    return isSetField(Tags.Factor);
                }
                public QuickFix.Fields.CreditRating creditRating
                { 
                    get 
                    {
                        QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CreditRating val) 
                { 
                    this.creditRating = val;
                }
                
                public QuickFix.Fields.CreditRating get(QuickFix.Fields.CreditRating val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CreditRating val) 
                { 
                    return isSetCreditRating();
                }
                
                public bool isSetCreditRating() 
                { 
                    return isSetField(Tags.CreditRating);
                }
                public QuickFix.Fields.InstrRegistry instrRegistry
                { 
                    get 
                    {
                        QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrRegistry val) 
                { 
                    this.instrRegistry = val;
                }
                
                public QuickFix.Fields.InstrRegistry get(QuickFix.Fields.InstrRegistry val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrRegistry val) 
                { 
                    return isSetInstrRegistry();
                }
                
                public bool isSetInstrRegistry() 
                { 
                    return isSetField(Tags.InstrRegistry);
                }
                public QuickFix.Fields.CountryOfIssue countryOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CountryOfIssue val) 
                { 
                    this.countryOfIssue = val;
                }
                
                public QuickFix.Fields.CountryOfIssue get(QuickFix.Fields.CountryOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CountryOfIssue val) 
                { 
                    return isSetCountryOfIssue();
                }
                
                public bool isSetCountryOfIssue() 
                { 
                    return isSetField(Tags.CountryOfIssue);
                }
                public QuickFix.Fields.StateOrProvinceOfIssue stateOrProvinceOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StateOrProvinceOfIssue val) 
                { 
                    this.stateOrProvinceOfIssue = val;
                }
                
                public QuickFix.Fields.StateOrProvinceOfIssue get(QuickFix.Fields.StateOrProvinceOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StateOrProvinceOfIssue val) 
                { 
                    return isSetStateOrProvinceOfIssue();
                }
                
                public bool isSetStateOrProvinceOfIssue() 
                { 
                    return isSetField(Tags.StateOrProvinceOfIssue);
                }
                public QuickFix.Fields.LocaleOfIssue localeOfIssue
                { 
                    get 
                    {
                        QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.LocaleOfIssue val) 
                { 
                    this.localeOfIssue = val;
                }
                
                public QuickFix.Fields.LocaleOfIssue get(QuickFix.Fields.LocaleOfIssue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.LocaleOfIssue val) 
                { 
                    return isSetLocaleOfIssue();
                }
                
                public bool isSetLocaleOfIssue() 
                { 
                    return isSetField(Tags.LocaleOfIssue);
                }
                public QuickFix.Fields.RedemptionDate redemptionDate
                { 
                    get 
                    {
                        QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.RedemptionDate val) 
                { 
                    this.redemptionDate = val;
                }
                
                public QuickFix.Fields.RedemptionDate get(QuickFix.Fields.RedemptionDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.RedemptionDate val) 
                { 
                    return isSetRedemptionDate();
                }
                
                public bool isSetRedemptionDate() 
                { 
                    return isSetField(Tags.RedemptionDate);
                }
                public QuickFix.Fields.StrikePrice strikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikePrice val) 
                { 
                    this.strikePrice = val;
                }
                
                public QuickFix.Fields.StrikePrice get(QuickFix.Fields.StrikePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikePrice val) 
                { 
                    return isSetStrikePrice();
                }
                
                public bool isSetStrikePrice() 
                { 
                    return isSetField(Tags.StrikePrice);
                }
                public QuickFix.Fields.StrikeCurrency strikeCurrency
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeCurrency val = new QuickFix.Fields.StrikeCurrency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeCurrency val) 
                { 
                    this.strikeCurrency = val;
                }
                
                public QuickFix.Fields.StrikeCurrency get(QuickFix.Fields.StrikeCurrency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeCurrency val) 
                { 
                    return isSetStrikeCurrency();
                }
                
                public bool isSetStrikeCurrency() 
                { 
                    return isSetField(Tags.StrikeCurrency);
                }
                public QuickFix.Fields.OptAttribute optAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OptAttribute val) 
                { 
                    this.optAttribute = val;
                }
                
                public QuickFix.Fields.OptAttribute get(QuickFix.Fields.OptAttribute val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OptAttribute val) 
                { 
                    return isSetOptAttribute();
                }
                
                public bool isSetOptAttribute() 
                { 
                    return isSetField(Tags.OptAttribute);
                }
                public QuickFix.Fields.ContractMultiplier contractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContractMultiplier val) 
                { 
                    this.contractMultiplier = val;
                }
                
                public QuickFix.Fields.ContractMultiplier get(QuickFix.Fields.ContractMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContractMultiplier val) 
                { 
                    return isSetContractMultiplier();
                }
                
                public bool isSetContractMultiplier() 
                { 
                    return isSetField(Tags.ContractMultiplier);
                }
                public QuickFix.Fields.CouponRate couponRate
                { 
                    get 
                    {
                        QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CouponRate val) 
                { 
                    this.couponRate = val;
                }
                
                public QuickFix.Fields.CouponRate get(QuickFix.Fields.CouponRate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CouponRate val) 
                { 
                    return isSetCouponRate();
                }
                
                public bool isSetCouponRate() 
                { 
                    return isSetField(Tags.CouponRate);
                }
                public QuickFix.Fields.SecurityExchange securityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityExchange val) 
                { 
                    this.securityExchange = val;
                }
                
                public QuickFix.Fields.SecurityExchange get(QuickFix.Fields.SecurityExchange val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityExchange val) 
                { 
                    return isSetSecurityExchange();
                }
                
                public bool isSetSecurityExchange() 
                { 
                    return isSetField(Tags.SecurityExchange);
                }
                public QuickFix.Fields.Issuer issuer
                { 
                    get 
                    {
                        QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Issuer val) 
                { 
                    this.issuer = val;
                }
                
                public QuickFix.Fields.Issuer get(QuickFix.Fields.Issuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Issuer val) 
                { 
                    return isSetIssuer();
                }
                
                public bool isSetIssuer() 
                { 
                    return isSetField(Tags.Issuer);
                }
                public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    this.encodedIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedIssuerLen get(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    return isSetEncodedIssuerLen();
                }
                
                public bool isSetEncodedIssuerLen() 
                { 
                    return isSetField(Tags.EncodedIssuerLen);
                }
                public QuickFix.Fields.EncodedIssuer encodedIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedIssuer val) 
                { 
                    this.encodedIssuer = val;
                }
                
                public QuickFix.Fields.EncodedIssuer get(QuickFix.Fields.EncodedIssuer val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedIssuer val) 
                { 
                    return isSetEncodedIssuer();
                }
                
                public bool isSetEncodedIssuer() 
                { 
                    return isSetField(Tags.EncodedIssuer);
                }
                public QuickFix.Fields.SecurityDesc securityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityDesc val) 
                { 
                    this.securityDesc = val;
                }
                
                public QuickFix.Fields.SecurityDesc get(QuickFix.Fields.SecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityDesc val) 
                { 
                    return isSetSecurityDesc();
                }
                
                public bool isSetSecurityDesc() 
                { 
                    return isSetField(Tags.SecurityDesc);
                }
                public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    this.encodedSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDescLen get(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    return isSetEncodedSecurityDescLen();
                }
                
                public bool isSetEncodedSecurityDescLen() 
                { 
                    return isSetField(Tags.EncodedSecurityDescLen);
                }
                public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    this.encodedSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDesc get(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    return isSetEncodedSecurityDesc();
                }
                
                public bool isSetEncodedSecurityDesc() 
                { 
                    return isSetField(Tags.EncodedSecurityDesc);
                }
                public QuickFix.Fields.Pool pool
                { 
                    get 
                    {
                        QuickFix.Fields.Pool val = new QuickFix.Fields.Pool();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Pool val) 
                { 
                    this.pool = val;
                }
                
                public QuickFix.Fields.Pool get(QuickFix.Fields.Pool val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Pool val) 
                { 
                    return isSetPool();
                }
                
                public bool isSetPool() 
                { 
                    return isSetField(Tags.Pool);
                }
                public QuickFix.Fields.ContractSettlMonth contractSettlMonth
                { 
                    get 
                    {
                        QuickFix.Fields.ContractSettlMonth val = new QuickFix.Fields.ContractSettlMonth();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    this.contractSettlMonth = val;
                }
                
                public QuickFix.Fields.ContractSettlMonth get(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ContractSettlMonth val) 
                { 
                    return isSetContractSettlMonth();
                }
                
                public bool isSetContractSettlMonth() 
                { 
                    return isSetField(Tags.ContractSettlMonth);
                }
                public QuickFix.Fields.CPProgram cPProgram
                { 
                    get 
                    {
                        QuickFix.Fields.CPProgram val = new QuickFix.Fields.CPProgram();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CPProgram val) 
                { 
                    this.cPProgram = val;
                }
                
                public QuickFix.Fields.CPProgram get(QuickFix.Fields.CPProgram val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CPProgram val) 
                { 
                    return isSetCPProgram();
                }
                
                public bool isSetCPProgram() 
                { 
                    return isSetField(Tags.CPProgram);
                }
                public QuickFix.Fields.CPRegType cPRegType
                { 
                    get 
                    {
                        QuickFix.Fields.CPRegType val = new QuickFix.Fields.CPRegType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CPRegType val) 
                { 
                    this.cPRegType = val;
                }
                
                public QuickFix.Fields.CPRegType get(QuickFix.Fields.CPRegType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CPRegType val) 
                { 
                    return isSetCPRegType();
                }
                
                public bool isSetCPRegType() 
                { 
                    return isSetField(Tags.CPRegType);
                }
                public QuickFix.Fields.NoEvents noEvents
                { 
                    get 
                    {
                        QuickFix.Fields.NoEvents val = new QuickFix.Fields.NoEvents();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoEvents val) 
                { 
                    this.noEvents = val;
                }
                
                public QuickFix.Fields.NoEvents get(QuickFix.Fields.NoEvents val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoEvents val) 
                { 
                    return isSetNoEvents();
                }
                
                public bool isSetNoEvents() 
                { 
                    return isSetField(Tags.NoEvents);
                }
                public QuickFix.Fields.DatedDate datedDate
                { 
                    get 
                    {
                        QuickFix.Fields.DatedDate val = new QuickFix.Fields.DatedDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DatedDate val) 
                { 
                    this.datedDate = val;
                }
                
                public QuickFix.Fields.DatedDate get(QuickFix.Fields.DatedDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DatedDate val) 
                { 
                    return isSetDatedDate();
                }
                
                public bool isSetDatedDate() 
                { 
                    return isSetField(Tags.DatedDate);
                }
                public QuickFix.Fields.InterestAccrualDate interestAccrualDate
                { 
                    get 
                    {
                        QuickFix.Fields.InterestAccrualDate val = new QuickFix.Fields.InterestAccrualDate();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    this.interestAccrualDate = val;
                }
                
                public QuickFix.Fields.InterestAccrualDate get(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InterestAccrualDate val) 
                { 
                    return isSetInterestAccrualDate();
                }
                
                public bool isSetInterestAccrualDate() 
                { 
                    return isSetField(Tags.InterestAccrualDate);
                }
                public QuickFix.Fields.SecurityStatus securityStatus
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityStatus val = new QuickFix.Fields.SecurityStatus();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityStatus val) 
                { 
                    this.securityStatus = val;
                }
                
                public QuickFix.Fields.SecurityStatus get(QuickFix.Fields.SecurityStatus val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityStatus val) 
                { 
                    return isSetSecurityStatus();
                }
                
                public bool isSetSecurityStatus() 
                { 
                    return isSetField(Tags.SecurityStatus);
                }
                public QuickFix.Fields.SettleOnOpenFlag settleOnOpenFlag
                { 
                    get 
                    {
                        QuickFix.Fields.SettleOnOpenFlag val = new QuickFix.Fields.SettleOnOpenFlag();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    this.settleOnOpenFlag = val;
                }
                
                public QuickFix.Fields.SettleOnOpenFlag get(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettleOnOpenFlag val) 
                { 
                    return isSetSettleOnOpenFlag();
                }
                
                public bool isSetSettleOnOpenFlag() 
                { 
                    return isSetField(Tags.SettleOnOpenFlag);
                }
                public QuickFix.Fields.InstrmtAssignmentMethod instrmtAssignmentMethod
                { 
                    get 
                    {
                        QuickFix.Fields.InstrmtAssignmentMethod val = new QuickFix.Fields.InstrmtAssignmentMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    this.instrmtAssignmentMethod = val;
                }
                
                public QuickFix.Fields.InstrmtAssignmentMethod get(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.InstrmtAssignmentMethod val) 
                { 
                    return isSetInstrmtAssignmentMethod();
                }
                
                public bool isSetInstrmtAssignmentMethod() 
                { 
                    return isSetField(Tags.InstrmtAssignmentMethod);
                }
                public QuickFix.Fields.StrikeMultiplier strikeMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeMultiplier val = new QuickFix.Fields.StrikeMultiplier();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    this.strikeMultiplier = val;
                }
                
                public QuickFix.Fields.StrikeMultiplier get(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeMultiplier val) 
                { 
                    return isSetStrikeMultiplier();
                }
                
                public bool isSetStrikeMultiplier() 
                { 
                    return isSetField(Tags.StrikeMultiplier);
                }
                public QuickFix.Fields.StrikeValue strikeValue
                { 
                    get 
                    {
                        QuickFix.Fields.StrikeValue val = new QuickFix.Fields.StrikeValue();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.StrikeValue val) 
                { 
                    this.strikeValue = val;
                }
                
                public QuickFix.Fields.StrikeValue get(QuickFix.Fields.StrikeValue val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.StrikeValue val) 
                { 
                    return isSetStrikeValue();
                }
                
                public bool isSetStrikeValue() 
                { 
                    return isSetField(Tags.StrikeValue);
                }
                public QuickFix.Fields.MinPriceIncrement minPriceIncrement
                { 
                    get 
                    {
                        QuickFix.Fields.MinPriceIncrement val = new QuickFix.Fields.MinPriceIncrement();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    this.minPriceIncrement = val;
                }
                
                public QuickFix.Fields.MinPriceIncrement get(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinPriceIncrement val) 
                { 
                    return isSetMinPriceIncrement();
                }
                
                public bool isSetMinPriceIncrement() 
                { 
                    return isSetField(Tags.MinPriceIncrement);
                }
                public QuickFix.Fields.PositionLimit positionLimit
                { 
                    get 
                    {
                        QuickFix.Fields.PositionLimit val = new QuickFix.Fields.PositionLimit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PositionLimit val) 
                { 
                    this.positionLimit = val;
                }
                
                public QuickFix.Fields.PositionLimit get(QuickFix.Fields.PositionLimit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PositionLimit val) 
                { 
                    return isSetPositionLimit();
                }
                
                public bool isSetPositionLimit() 
                { 
                    return isSetField(Tags.PositionLimit);
                }
                public QuickFix.Fields.NTPositionLimit nTPositionLimit
                { 
                    get 
                    {
                        QuickFix.Fields.NTPositionLimit val = new QuickFix.Fields.NTPositionLimit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NTPositionLimit val) 
                { 
                    this.nTPositionLimit = val;
                }
                
                public QuickFix.Fields.NTPositionLimit get(QuickFix.Fields.NTPositionLimit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NTPositionLimit val) 
                { 
                    return isSetNTPositionLimit();
                }
                
                public bool isSetNTPositionLimit() 
                { 
                    return isSetField(Tags.NTPositionLimit);
                }
                public QuickFix.Fields.NoInstrumentParties noInstrumentParties
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrumentParties val = new QuickFix.Fields.NoInstrumentParties();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    this.noInstrumentParties = val;
                }
                
                public QuickFix.Fields.NoInstrumentParties get(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoInstrumentParties val) 
                { 
                    return isSetNoInstrumentParties();
                }
                
                public bool isSetNoInstrumentParties() 
                { 
                    return isSetField(Tags.NoInstrumentParties);
                }
                public QuickFix.Fields.UnitOfMeasure unitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.UnitOfMeasure val = new QuickFix.Fields.UnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    this.unitOfMeasure = val;
                }
                
                public QuickFix.Fields.UnitOfMeasure get(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnitOfMeasure val) 
                { 
                    return isSetUnitOfMeasure();
                }
                
                public bool isSetUnitOfMeasure() 
                { 
                    return isSetField(Tags.UnitOfMeasure);
                }
                public QuickFix.Fields.TimeUnit timeUnit
                { 
                    get 
                    {
                        QuickFix.Fields.TimeUnit val = new QuickFix.Fields.TimeUnit();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.TimeUnit val) 
                { 
                    this.timeUnit = val;
                }
                
                public QuickFix.Fields.TimeUnit get(QuickFix.Fields.TimeUnit val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.TimeUnit val) 
                { 
                    return isSetTimeUnit();
                }
                
                public bool isSetTimeUnit() 
                { 
                    return isSetField(Tags.TimeUnit);
                }
                public QuickFix.Fields.MaturityTime maturityTime
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityTime val = new QuickFix.Fields.MaturityTime();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MaturityTime val) 
                { 
                    this.maturityTime = val;
                }
                
                public QuickFix.Fields.MaturityTime get(QuickFix.Fields.MaturityTime val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MaturityTime val) 
                { 
                    return isSetMaturityTime();
                }
                
                public bool isSetMaturityTime() 
                { 
                    return isSetField(Tags.MaturityTime);
                }
                public QuickFix.Fields.SecurityGroup securityGroup
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityGroup val = new QuickFix.Fields.SecurityGroup();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityGroup val) 
                { 
                    this.securityGroup = val;
                }
                
                public QuickFix.Fields.SecurityGroup get(QuickFix.Fields.SecurityGroup val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityGroup val) 
                { 
                    return isSetSecurityGroup();
                }
                
                public bool isSetSecurityGroup() 
                { 
                    return isSetField(Tags.SecurityGroup);
                }
                public QuickFix.Fields.MinPriceIncrementAmount minPriceIncrementAmount
                { 
                    get 
                    {
                        QuickFix.Fields.MinPriceIncrementAmount val = new QuickFix.Fields.MinPriceIncrementAmount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    this.minPriceIncrementAmount = val;
                }
                
                public QuickFix.Fields.MinPriceIncrementAmount get(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.MinPriceIncrementAmount val) 
                { 
                    return isSetMinPriceIncrementAmount();
                }
                
                public bool isSetMinPriceIncrementAmount() 
                { 
                    return isSetField(Tags.MinPriceIncrementAmount);
                }
                public QuickFix.Fields.UnitOfMeasureQty unitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.UnitOfMeasureQty val = new QuickFix.Fields.UnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    this.unitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.UnitOfMeasureQty get(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.UnitOfMeasureQty val) 
                { 
                    return isSetUnitOfMeasureQty();
                }
                
                public bool isSetUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.UnitOfMeasureQty);
                }
                public QuickFix.Fields.SecurityXMLLen securityXMLLen
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXMLLen val = new QuickFix.Fields.SecurityXMLLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    this.securityXMLLen = val;
                }
                
                public QuickFix.Fields.SecurityXMLLen get(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXMLLen val) 
                { 
                    return isSetSecurityXMLLen();
                }
                
                public bool isSetSecurityXMLLen() 
                { 
                    return isSetField(Tags.SecurityXMLLen);
                }
                public QuickFix.Fields.SecurityXML securityXML
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXML val = new QuickFix.Fields.SecurityXML();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXML val) 
                { 
                    this.securityXML = val;
                }
                
                public QuickFix.Fields.SecurityXML get(QuickFix.Fields.SecurityXML val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXML val) 
                { 
                    return isSetSecurityXML();
                }
                
                public bool isSetSecurityXML() 
                { 
                    return isSetField(Tags.SecurityXML);
                }
                public QuickFix.Fields.SecurityXMLSchema securityXMLSchema
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityXMLSchema val = new QuickFix.Fields.SecurityXMLSchema();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    this.securityXMLSchema = val;
                }
                
                public QuickFix.Fields.SecurityXMLSchema get(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecurityXMLSchema val) 
                { 
                    return isSetSecurityXMLSchema();
                }
                
                public bool isSetSecurityXMLSchema() 
                { 
                    return isSetField(Tags.SecurityXMLSchema);
                }
                public QuickFix.Fields.ProductComplex productComplex
                { 
                    get 
                    {
                        QuickFix.Fields.ProductComplex val = new QuickFix.Fields.ProductComplex();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ProductComplex val) 
                { 
                    this.productComplex = val;
                }
                
                public QuickFix.Fields.ProductComplex get(QuickFix.Fields.ProductComplex val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ProductComplex val) 
                { 
                    return isSetProductComplex();
                }
                
                public bool isSetProductComplex() 
                { 
                    return isSetField(Tags.ProductComplex);
                }
                public QuickFix.Fields.PriceUnitOfMeasure priceUnitOfMeasure
                { 
                    get 
                    {
                        QuickFix.Fields.PriceUnitOfMeasure val = new QuickFix.Fields.PriceUnitOfMeasure();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    this.priceUnitOfMeasure = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasure get(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceUnitOfMeasure val) 
                { 
                    return isSetPriceUnitOfMeasure();
                }
                
                public bool isSetPriceUnitOfMeasure() 
                { 
                    return isSetField(Tags.PriceUnitOfMeasure);
                }
                public QuickFix.Fields.PriceUnitOfMeasureQty priceUnitOfMeasureQty
                { 
                    get 
                    {
                        QuickFix.Fields.PriceUnitOfMeasureQty val = new QuickFix.Fields.PriceUnitOfMeasureQty();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    this.priceUnitOfMeasureQty = val;
                }
                
                public QuickFix.Fields.PriceUnitOfMeasureQty get(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceUnitOfMeasureQty val) 
                { 
                    return isSetPriceUnitOfMeasureQty();
                }
                
                public bool isSetPriceUnitOfMeasureQty() 
                { 
                    return isSetField(Tags.PriceUnitOfMeasureQty);
                }
                public QuickFix.Fields.SettlMethod settlMethod
                { 
                    get 
                    {
                        QuickFix.Fields.SettlMethod val = new QuickFix.Fields.SettlMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SettlMethod val) 
                { 
                    this.settlMethod = val;
                }
                
                public QuickFix.Fields.SettlMethod get(QuickFix.Fields.SettlMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SettlMethod val) 
                { 
                    return isSetSettlMethod();
                }
                
                public bool isSetSettlMethod() 
                { 
                    return isSetField(Tags.SettlMethod);
                }
                public QuickFix.Fields.ExerciseStyle exerciseStyle
                { 
                    get 
                    {
                        QuickFix.Fields.ExerciseStyle val = new QuickFix.Fields.ExerciseStyle();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ExerciseStyle val) 
                { 
                    this.exerciseStyle = val;
                }
                
                public QuickFix.Fields.ExerciseStyle get(QuickFix.Fields.ExerciseStyle val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ExerciseStyle val) 
                { 
                    return isSetExerciseStyle();
                }
                
                public bool isSetExerciseStyle() 
                { 
                    return isSetField(Tags.ExerciseStyle);
                }
                public QuickFix.Fields.OptPayAmount optPayAmount
                { 
                    get 
                    {
                        QuickFix.Fields.OptPayAmount val = new QuickFix.Fields.OptPayAmount();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.OptPayAmount val) 
                { 
                    this.optPayAmount = val;
                }
                
                public QuickFix.Fields.OptPayAmount get(QuickFix.Fields.OptPayAmount val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.OptPayAmount val) 
                { 
                    return isSetOptPayAmount();
                }
                
                public bool isSetOptPayAmount() 
                { 
                    return isSetField(Tags.OptPayAmount);
                }
                public QuickFix.Fields.PriceQuoteMethod priceQuoteMethod
                { 
                    get 
                    {
                        QuickFix.Fields.PriceQuoteMethod val = new QuickFix.Fields.PriceQuoteMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    this.priceQuoteMethod = val;
                }
                
                public QuickFix.Fields.PriceQuoteMethod get(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PriceQuoteMethod val) 
                { 
                    return isSetPriceQuoteMethod();
                }
                
                public bool isSetPriceQuoteMethod() 
                { 
                    return isSetField(Tags.PriceQuoteMethod);
                }
                public QuickFix.Fields.ListMethod listMethod
                { 
                    get 
                    {
                        QuickFix.Fields.ListMethod val = new QuickFix.Fields.ListMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.ListMethod val) 
                { 
                    this.listMethod = val;
                }
                
                public QuickFix.Fields.ListMethod get(QuickFix.Fields.ListMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.ListMethod val) 
                { 
                    return isSetListMethod();
                }
                
                public bool isSetListMethod() 
                { 
                    return isSetField(Tags.ListMethod);
                }
                public QuickFix.Fields.CapPrice capPrice
                { 
                    get 
                    {
                        QuickFix.Fields.CapPrice val = new QuickFix.Fields.CapPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CapPrice val) 
                { 
                    this.capPrice = val;
                }
                
                public QuickFix.Fields.CapPrice get(QuickFix.Fields.CapPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CapPrice val) 
                { 
                    return isSetCapPrice();
                }
                
                public bool isSetCapPrice() 
                { 
                    return isSetField(Tags.CapPrice);
                }
                public QuickFix.Fields.FloorPrice floorPrice
                { 
                    get 
                    {
                        QuickFix.Fields.FloorPrice val = new QuickFix.Fields.FloorPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FloorPrice val) 
                { 
                    this.floorPrice = val;
                }
                
                public QuickFix.Fields.FloorPrice get(QuickFix.Fields.FloorPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FloorPrice val) 
                { 
                    return isSetFloorPrice();
                }
                
                public bool isSetFloorPrice() 
                { 
                    return isSetField(Tags.FloorPrice);
                }
                public QuickFix.Fields.PutOrCall putOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PutOrCall val) 
                { 
                    this.putOrCall = val;
                }
                
                public QuickFix.Fields.PutOrCall get(QuickFix.Fields.PutOrCall val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PutOrCall val) 
                { 
                    return isSetPutOrCall();
                }
                
                public bool isSetPutOrCall() 
                { 
                    return isSetField(Tags.PutOrCall);
                }
                public QuickFix.Fields.FlexibleIndicator flexibleIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.FlexibleIndicator val = new QuickFix.Fields.FlexibleIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    this.flexibleIndicator = val;
                }
                
                public QuickFix.Fields.FlexibleIndicator get(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FlexibleIndicator val) 
                { 
                    return isSetFlexibleIndicator();
                }
                
                public bool isSetFlexibleIndicator() 
                { 
                    return isSetField(Tags.FlexibleIndicator);
                }
                public QuickFix.Fields.FlexProductEligibilityIndicator flexProductEligibilityIndicator
                { 
                    get 
                    {
                        QuickFix.Fields.FlexProductEligibilityIndicator val = new QuickFix.Fields.FlexProductEligibilityIndicator();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    this.flexProductEligibilityIndicator = val;
                }
                
                public QuickFix.Fields.FlexProductEligibilityIndicator get(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FlexProductEligibilityIndicator val) 
                { 
                    return isSetFlexProductEligibilityIndicator();
                }
                
                public bool isSetFlexProductEligibilityIndicator() 
                { 
                    return isSetField(Tags.FlexProductEligibilityIndicator);
                }
                public QuickFix.Fields.FuturesValuationMethod futuresValuationMethod
                { 
                    get 
                    {
                        QuickFix.Fields.FuturesValuationMethod val = new QuickFix.Fields.FuturesValuationMethod();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    this.futuresValuationMethod = val;
                }
                
                public QuickFix.Fields.FuturesValuationMethod get(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.FuturesValuationMethod val) 
                { 
                    return isSetFuturesValuationMethod();
                }
                
                public bool isSetFuturesValuationMethod() 
                { 
                    return isSetField(Tags.FuturesValuationMethod);
                }
                public QuickFix.Fields.DeliveryForm deliveryForm
                { 
                    get 
                    {
                        QuickFix.Fields.DeliveryForm val = new QuickFix.Fields.DeliveryForm();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.DeliveryForm val) 
                { 
                    this.deliveryForm = val;
                }
                
                public QuickFix.Fields.DeliveryForm get(QuickFix.Fields.DeliveryForm val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.DeliveryForm val) 
                { 
                    return isSetDeliveryForm();
                }
                
                public bool isSetDeliveryForm() 
                { 
                    return isSetField(Tags.DeliveryForm);
                }
                public QuickFix.Fields.PctAtRisk pctAtRisk
                { 
                    get 
                    {
                        QuickFix.Fields.PctAtRisk val = new QuickFix.Fields.PctAtRisk();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.PctAtRisk val) 
                { 
                    this.pctAtRisk = val;
                }
                
                public QuickFix.Fields.PctAtRisk get(QuickFix.Fields.PctAtRisk val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.PctAtRisk val) 
                { 
                    return isSetPctAtRisk();
                }
                
                public bool isSetPctAtRisk() 
                { 
                    return isSetField(Tags.PctAtRisk);
                }
                public QuickFix.Fields.NoInstrAttrib noInstrAttrib
                { 
                    get 
                    {
                        QuickFix.Fields.NoInstrAttrib val = new QuickFix.Fields.NoInstrAttrib();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    this.noInstrAttrib = val;
                }
                
                public QuickFix.Fields.NoInstrAttrib get(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoInstrAttrib val) 
                { 
                    return isSetNoInstrAttrib();
                }
                
                public bool isSetNoInstrAttrib() 
                { 
                    return isSetField(Tags.NoInstrAttrib);
                }
                public QuickFix.Fields.SecondaryPriceLimitType secondaryPriceLimitType
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryPriceLimitType val = new QuickFix.Fields.SecondaryPriceLimitType();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    this.secondaryPriceLimitType = val;
                }
                
                public QuickFix.Fields.SecondaryPriceLimitType get(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryPriceLimitType val) 
                { 
                    return isSetSecondaryPriceLimitType();
                }
                
                public bool isSetSecondaryPriceLimitType() 
                { 
                    return isSetField(Tags.SecondaryPriceLimitType);
                }
                public QuickFix.Fields.SecondaryLowLimitPrice secondaryLowLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryLowLimitPrice val = new QuickFix.Fields.SecondaryLowLimitPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    this.secondaryLowLimitPrice = val;
                }
                
                public QuickFix.Fields.SecondaryLowLimitPrice get(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryLowLimitPrice val) 
                { 
                    return isSetSecondaryLowLimitPrice();
                }
                
                public bool isSetSecondaryLowLimitPrice() 
                { 
                    return isSetField(Tags.SecondaryLowLimitPrice);
                }
                public QuickFix.Fields.SecondaryHighLimitPrice secondaryHighLimitPrice
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryHighLimitPrice val = new QuickFix.Fields.SecondaryHighLimitPrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    this.secondaryHighLimitPrice = val;
                }
                
                public QuickFix.Fields.SecondaryHighLimitPrice get(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryHighLimitPrice val) 
                { 
                    return isSetSecondaryHighLimitPrice();
                }
                
                public bool isSetSecondaryHighLimitPrice() 
                { 
                    return isSetField(Tags.SecondaryHighLimitPrice);
                }
                public QuickFix.Fields.SecondaryTradingReferencePrice secondaryTradingReferencePrice
                { 
                    get 
                    {
                        QuickFix.Fields.SecondaryTradingReferencePrice val = new QuickFix.Fields.SecondaryTradingReferencePrice();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    this.secondaryTradingReferencePrice = val;
                }
                
                public QuickFix.Fields.SecondaryTradingReferencePrice get(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.SecondaryTradingReferencePrice val) 
                { 
                    return isSetSecondaryTradingReferencePrice();
                }
                
                public bool isSetSecondaryTradingReferencePrice() 
                { 
                    return isSetField(Tags.SecondaryTradingReferencePrice);
                }
                public QuickFix.Fields.Currency currency
                { 
                    get 
                    {
                        QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Currency val) 
                { 
                    this.currency = val;
                }
                
                public QuickFix.Fields.Currency get(QuickFix.Fields.Currency val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Currency val) 
                { 
                    return isSetCurrency();
                }
                
                public bool isSetCurrency() 
                { 
                    return isSetField(Tags.Currency);
                }
                public QuickFix.Fields.NoLegs noLegs
                { 
                    get 
                    {
                        QuickFix.Fields.NoLegs val = new QuickFix.Fields.NoLegs();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.NoLegs val) 
                { 
                    this.noLegs = val;
                }
                
                public QuickFix.Fields.NoLegs get(QuickFix.Fields.NoLegs val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.NoLegs val) 
                { 
                    return isSetNoLegs();
                }
                
                public bool isSetNoLegs() 
                { 
                    return isSetField(Tags.NoLegs);
                }
                public QuickFix.Fields.Text text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.Text val) 
                { 
                    this.text = val;
                }
                
                public QuickFix.Fields.Text get(QuickFix.Fields.Text val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.Text val) 
                { 
                    return isSetText();
                }
                
                public bool isSetText() 
                { 
                    return isSetField(Tags.Text);
                }
                public QuickFix.Fields.EncodedTextLen encodedTextLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    this.encodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return isSetEncodedTextLen();
                }
                
                public bool isSetEncodedTextLen() 
                { 
                    return isSetField(Tags.EncodedTextLen);
                }
                public QuickFix.Fields.EncodedText encodedText
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.EncodedText val) 
                { 
                    this.encodedText = val;
                }
                
                public QuickFix.Fields.EncodedText get(QuickFix.Fields.EncodedText val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.EncodedText val) 
                { 
                    return isSetEncodedText();
                }
                
                public bool isSetEncodedText() 
                { 
                    return isSetField(Tags.EncodedText);
                }
                public QuickFix.Fields.CorporateAction corporateAction
                { 
                    get 
                    {
                        QuickFix.Fields.CorporateAction val = new QuickFix.Fields.CorporateAction();
                        getField(val);
                        return val;
                    }
                    set { setField(value); }
                }
                
                public void set(QuickFix.Fields.CorporateAction val) 
                { 
                    this.corporateAction = val;
                }
                
                public QuickFix.Fields.CorporateAction get(QuickFix.Fields.CorporateAction val) 
                { 
                    getField(val);
                    return val;
                }
                
                public bool isSet(QuickFix.Fields.CorporateAction val) 
                { 
                    return isSetCorporateAction();
                }
                
                public bool isSetCorporateAction() 
                { 
                    return isSetField(Tags.CorporateAction);
                }
                            public class NoSecurityAltID : Group
                {
                    public NoSecurityAltID() 
                      :base( Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};
                                    public QuickFix.Fields.SecurityAltID securityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SecurityAltID val) 
                    { 
                        this.securityAltID = val;
                    }
                    
                    public QuickFix.Fields.SecurityAltID get(QuickFix.Fields.SecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SecurityAltID val) 
                    { 
                        return isSetSecurityAltID();
                    }
                    
                    public bool isSetSecurityAltID() 
                    { 
                        return isSetField(Tags.SecurityAltID);
                    }
                    public QuickFix.Fields.SecurityAltIDSource securityAltIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.SecurityAltIDSource val) 
                    { 
                        this.securityAltIDSource = val;
                    }
                    
                    public QuickFix.Fields.SecurityAltIDSource get(QuickFix.Fields.SecurityAltIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.SecurityAltIDSource val) 
                    { 
                        return isSetSecurityAltIDSource();
                    }
                    
                    public bool isSetSecurityAltIDSource() 
                    { 
                        return isSetField(Tags.SecurityAltIDSource);
                    }
                
                }
                public class NoEvents : Group
                {
                    public NoEvents() 
                      :base( Tags.NoEvents, Tags.EventType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, Tags.EventTime, 0};
                                    public QuickFix.Fields.EventType eventType
                    { 
                        get 
                        {
                            QuickFix.Fields.EventType val = new QuickFix.Fields.EventType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventType val) 
                    { 
                        this.eventType = val;
                    }
                    
                    public QuickFix.Fields.EventType get(QuickFix.Fields.EventType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventType val) 
                    { 
                        return isSetEventType();
                    }
                    
                    public bool isSetEventType() 
                    { 
                        return isSetField(Tags.EventType);
                    }
                    public QuickFix.Fields.EventDate eventDate
                    { 
                        get 
                        {
                            QuickFix.Fields.EventDate val = new QuickFix.Fields.EventDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventDate val) 
                    { 
                        this.eventDate = val;
                    }
                    
                    public QuickFix.Fields.EventDate get(QuickFix.Fields.EventDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventDate val) 
                    { 
                        return isSetEventDate();
                    }
                    
                    public bool isSetEventDate() 
                    { 
                        return isSetField(Tags.EventDate);
                    }
                    public QuickFix.Fields.EventPx eventPx
                    { 
                        get 
                        {
                            QuickFix.Fields.EventPx val = new QuickFix.Fields.EventPx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventPx val) 
                    { 
                        this.eventPx = val;
                    }
                    
                    public QuickFix.Fields.EventPx get(QuickFix.Fields.EventPx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventPx val) 
                    { 
                        return isSetEventPx();
                    }
                    
                    public bool isSetEventPx() 
                    { 
                        return isSetField(Tags.EventPx);
                    }
                    public QuickFix.Fields.EventText eventText
                    { 
                        get 
                        {
                            QuickFix.Fields.EventText val = new QuickFix.Fields.EventText();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventText val) 
                    { 
                        this.eventText = val;
                    }
                    
                    public QuickFix.Fields.EventText get(QuickFix.Fields.EventText val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventText val) 
                    { 
                        return isSetEventText();
                    }
                    
                    public bool isSetEventText() 
                    { 
                        return isSetField(Tags.EventText);
                    }
                    public QuickFix.Fields.EventTime eventTime
                    { 
                        get 
                        {
                            QuickFix.Fields.EventTime val = new QuickFix.Fields.EventTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EventTime val) 
                    { 
                        this.eventTime = val;
                    }
                    
                    public QuickFix.Fields.EventTime get(QuickFix.Fields.EventTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EventTime val) 
                    { 
                        return isSetEventTime();
                    }
                    
                    public bool isSetEventTime() 
                    { 
                        return isSetField(Tags.EventTime);
                    }
                
                }
                public class NoInstrumentParties : Group
                {
                    public NoInstrumentParties() 
                      :base( Tags.NoInstrumentParties, Tags.InstrumentPartyID, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrumentPartyID, Tags.InstrumentPartyIDSource, Tags.InstrumentPartyRole, Tags.NoInstrumentPartySubIDs, 0};
                                    public QuickFix.Fields.InstrumentPartyID instrumentPartyID
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyID val = new QuickFix.Fields.InstrumentPartyID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        this.instrumentPartyID = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyID get(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyID val) 
                    { 
                        return isSetInstrumentPartyID();
                    }
                    
                    public bool isSetInstrumentPartyID() 
                    { 
                        return isSetField(Tags.InstrumentPartyID);
                    }
                    public QuickFix.Fields.InstrumentPartyIDSource instrumentPartyIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyIDSource val = new QuickFix.Fields.InstrumentPartyIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        this.instrumentPartyIDSource = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyIDSource get(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyIDSource val) 
                    { 
                        return isSetInstrumentPartyIDSource();
                    }
                    
                    public bool isSetInstrumentPartyIDSource() 
                    { 
                        return isSetField(Tags.InstrumentPartyIDSource);
                    }
                    public QuickFix.Fields.InstrumentPartyRole instrumentPartyRole
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrumentPartyRole val = new QuickFix.Fields.InstrumentPartyRole();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        this.instrumentPartyRole = val;
                    }
                    
                    public QuickFix.Fields.InstrumentPartyRole get(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrumentPartyRole val) 
                    { 
                        return isSetInstrumentPartyRole();
                    }
                    
                    public bool isSetInstrumentPartyRole() 
                    { 
                        return isSetField(Tags.InstrumentPartyRole);
                    }
                    public QuickFix.Fields.NoInstrumentPartySubIDs noInstrumentPartySubIDs
                    { 
                        get 
                        {
                            QuickFix.Fields.NoInstrumentPartySubIDs val = new QuickFix.Fields.NoInstrumentPartySubIDs();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        this.noInstrumentPartySubIDs = val;
                    }
                    
                    public QuickFix.Fields.NoInstrumentPartySubIDs get(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoInstrumentPartySubIDs val) 
                    { 
                        return isSetNoInstrumentPartySubIDs();
                    }
                    
                    public bool isSetNoInstrumentPartySubIDs() 
                    { 
                        return isSetField(Tags.NoInstrumentPartySubIDs);
                    }
                                    public class NoInstrumentPartySubIDs : Group
                    {
                        public NoInstrumentPartySubIDs() 
                          :base( Tags.NoInstrumentPartySubIDs, Tags.InstrumentPartySubID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.InstrumentPartySubID, Tags.InstrumentPartySubIDType, 0};
                                            public QuickFix.Fields.InstrumentPartySubID instrumentPartySubID
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartySubID val = new QuickFix.Fields.InstrumentPartySubID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            this.instrumentPartySubID = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubID get(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.InstrumentPartySubID val) 
                        { 
                            return isSetInstrumentPartySubID();
                        }
                        
                        public bool isSetInstrumentPartySubID() 
                        { 
                            return isSetField(Tags.InstrumentPartySubID);
                        }
                        public QuickFix.Fields.InstrumentPartySubIDType instrumentPartySubIDType
                        { 
                            get 
                            {
                                QuickFix.Fields.InstrumentPartySubIDType val = new QuickFix.Fields.InstrumentPartySubIDType();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            this.instrumentPartySubIDType = val;
                        }
                        
                        public QuickFix.Fields.InstrumentPartySubIDType get(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.InstrumentPartySubIDType val) 
                        { 
                            return isSetInstrumentPartySubIDType();
                        }
                        
                        public bool isSetInstrumentPartySubIDType() 
                        { 
                            return isSetField(Tags.InstrumentPartySubIDType);
                        }
                    
                    }
                }
                public class NoInstrAttrib : Group
                {
                    public NoInstrAttrib() 
                      :base( Tags.NoInstrAttrib, Tags.InstrAttribType, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.InstrAttribType, Tags.InstrAttribValue, 0};
                                    public QuickFix.Fields.InstrAttribType instrAttribType
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrAttribType val = new QuickFix.Fields.InstrAttribType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrAttribType val) 
                    { 
                        this.instrAttribType = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribType get(QuickFix.Fields.InstrAttribType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrAttribType val) 
                    { 
                        return isSetInstrAttribType();
                    }
                    
                    public bool isSetInstrAttribType() 
                    { 
                        return isSetField(Tags.InstrAttribType);
                    }
                    public QuickFix.Fields.InstrAttribValue instrAttribValue
                    { 
                        get 
                        {
                            QuickFix.Fields.InstrAttribValue val = new QuickFix.Fields.InstrAttribValue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        this.instrAttribValue = val;
                    }
                    
                    public QuickFix.Fields.InstrAttribValue get(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.InstrAttribValue val) 
                    { 
                        return isSetInstrAttribValue();
                    }
                    
                    public bool isSetInstrAttribValue() 
                    { 
                        return isSetField(Tags.InstrAttribValue);
                    }
                
                }
                public class NoLegs : Group
                {
                    public NoLegs() 
                      :base( Tags.NoLegs, Tags.LegSymbol, fieldOrder)
                    {
                    }
                    public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, Tags.LegUnitOfMeasure, Tags.LegTimeUnit, Tags.LegOptionRatio, Tags.LegPrice, Tags.LegMaturityTime, Tags.LegPutOrCall, Tags.LegExerciseStyle, Tags.LegUnitOfMeasureQty, Tags.LegPriceUnitOfMeasure, Tags.LegPriceUnitOfMeasureQty, 0};
                                    public QuickFix.Fields.LegSymbol legSymbol
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSymbol val = new QuickFix.Fields.LegSymbol();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSymbol val) 
                    { 
                        this.legSymbol = val;
                    }
                    
                    public QuickFix.Fields.LegSymbol get(QuickFix.Fields.LegSymbol val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSymbol val) 
                    { 
                        return isSetLegSymbol();
                    }
                    
                    public bool isSetLegSymbol() 
                    { 
                        return isSetField(Tags.LegSymbol);
                    }
                    public QuickFix.Fields.LegSymbolSfx legSymbolSfx
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSymbolSfx val = new QuickFix.Fields.LegSymbolSfx();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        this.legSymbolSfx = val;
                    }
                    
                    public QuickFix.Fields.LegSymbolSfx get(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSymbolSfx val) 
                    { 
                        return isSetLegSymbolSfx();
                    }
                    
                    public bool isSetLegSymbolSfx() 
                    { 
                        return isSetField(Tags.LegSymbolSfx);
                    }
                    public QuickFix.Fields.LegSecurityID legSecurityID
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityID val = new QuickFix.Fields.LegSecurityID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityID val) 
                    { 
                        this.legSecurityID = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityID get(QuickFix.Fields.LegSecurityID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityID val) 
                    { 
                        return isSetLegSecurityID();
                    }
                    
                    public bool isSetLegSecurityID() 
                    { 
                        return isSetField(Tags.LegSecurityID);
                    }
                    public QuickFix.Fields.LegSecurityIDSource legSecurityIDSource
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityIDSource val = new QuickFix.Fields.LegSecurityIDSource();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        this.legSecurityIDSource = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityIDSource get(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityIDSource val) 
                    { 
                        return isSetLegSecurityIDSource();
                    }
                    
                    public bool isSetLegSecurityIDSource() 
                    { 
                        return isSetField(Tags.LegSecurityIDSource);
                    }
                    public QuickFix.Fields.NoLegSecurityAltID noLegSecurityAltID
                    { 
                        get 
                        {
                            QuickFix.Fields.NoLegSecurityAltID val = new QuickFix.Fields.NoLegSecurityAltID();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        this.noLegSecurityAltID = val;
                    }
                    
                    public QuickFix.Fields.NoLegSecurityAltID get(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.NoLegSecurityAltID val) 
                    { 
                        return isSetNoLegSecurityAltID();
                    }
                    
                    public bool isSetNoLegSecurityAltID() 
                    { 
                        return isSetField(Tags.NoLegSecurityAltID);
                    }
                    public QuickFix.Fields.LegProduct legProduct
                    { 
                        get 
                        {
                            QuickFix.Fields.LegProduct val = new QuickFix.Fields.LegProduct();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegProduct val) 
                    { 
                        this.legProduct = val;
                    }
                    
                    public QuickFix.Fields.LegProduct get(QuickFix.Fields.LegProduct val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegProduct val) 
                    { 
                        return isSetLegProduct();
                    }
                    
                    public bool isSetLegProduct() 
                    { 
                        return isSetField(Tags.LegProduct);
                    }
                    public QuickFix.Fields.LegCFICode legCFICode
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCFICode val = new QuickFix.Fields.LegCFICode();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCFICode val) 
                    { 
                        this.legCFICode = val;
                    }
                    
                    public QuickFix.Fields.LegCFICode get(QuickFix.Fields.LegCFICode val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCFICode val) 
                    { 
                        return isSetLegCFICode();
                    }
                    
                    public bool isSetLegCFICode() 
                    { 
                        return isSetField(Tags.LegCFICode);
                    }
                    public QuickFix.Fields.LegSecurityType legSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityType val = new QuickFix.Fields.LegSecurityType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityType val) 
                    { 
                        this.legSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityType get(QuickFix.Fields.LegSecurityType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityType val) 
                    { 
                        return isSetLegSecurityType();
                    }
                    
                    public bool isSetLegSecurityType() 
                    { 
                        return isSetField(Tags.LegSecurityType);
                    }
                    public QuickFix.Fields.LegSecuritySubType legSecuritySubType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecuritySubType val = new QuickFix.Fields.LegSecuritySubType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        this.legSecuritySubType = val;
                    }
                    
                    public QuickFix.Fields.LegSecuritySubType get(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecuritySubType val) 
                    { 
                        return isSetLegSecuritySubType();
                    }
                    
                    public bool isSetLegSecuritySubType() 
                    { 
                        return isSetField(Tags.LegSecuritySubType);
                    }
                    public QuickFix.Fields.LegMaturityMonthYear legMaturityMonthYear
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityMonthYear val = new QuickFix.Fields.LegMaturityMonthYear();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        this.legMaturityMonthYear = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityMonthYear get(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegMaturityMonthYear val) 
                    { 
                        return isSetLegMaturityMonthYear();
                    }
                    
                    public bool isSetLegMaturityMonthYear() 
                    { 
                        return isSetField(Tags.LegMaturityMonthYear);
                    }
                    public QuickFix.Fields.LegMaturityDate legMaturityDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityDate val = new QuickFix.Fields.LegMaturityDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        this.legMaturityDate = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityDate get(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegMaturityDate val) 
                    { 
                        return isSetLegMaturityDate();
                    }
                    
                    public bool isSetLegMaturityDate() 
                    { 
                        return isSetField(Tags.LegMaturityDate);
                    }
                    public QuickFix.Fields.LegCouponPaymentDate legCouponPaymentDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponPaymentDate val = new QuickFix.Fields.LegCouponPaymentDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        this.legCouponPaymentDate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponPaymentDate get(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCouponPaymentDate val) 
                    { 
                        return isSetLegCouponPaymentDate();
                    }
                    
                    public bool isSetLegCouponPaymentDate() 
                    { 
                        return isSetField(Tags.LegCouponPaymentDate);
                    }
                    public QuickFix.Fields.LegIssueDate legIssueDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssueDate val = new QuickFix.Fields.LegIssueDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegIssueDate val) 
                    { 
                        this.legIssueDate = val;
                    }
                    
                    public QuickFix.Fields.LegIssueDate get(QuickFix.Fields.LegIssueDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegIssueDate val) 
                    { 
                        return isSetLegIssueDate();
                    }
                    
                    public bool isSetLegIssueDate() 
                    { 
                        return isSetField(Tags.LegIssueDate);
                    }
                    public QuickFix.Fields.LegRepoCollateralSecurityType legRepoCollateralSecurityType
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepoCollateralSecurityType val = new QuickFix.Fields.LegRepoCollateralSecurityType();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        this.legRepoCollateralSecurityType = val;
                    }
                    
                    public QuickFix.Fields.LegRepoCollateralSecurityType get(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRepoCollateralSecurityType val) 
                    { 
                        return isSetLegRepoCollateralSecurityType();
                    }
                    
                    public bool isSetLegRepoCollateralSecurityType() 
                    { 
                        return isSetField(Tags.LegRepoCollateralSecurityType);
                    }
                    public QuickFix.Fields.LegRepurchaseTerm legRepurchaseTerm
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseTerm val = new QuickFix.Fields.LegRepurchaseTerm();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        this.legRepurchaseTerm = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseTerm get(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRepurchaseTerm val) 
                    { 
                        return isSetLegRepurchaseTerm();
                    }
                    
                    public bool isSetLegRepurchaseTerm() 
                    { 
                        return isSetField(Tags.LegRepurchaseTerm);
                    }
                    public QuickFix.Fields.LegRepurchaseRate legRepurchaseRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRepurchaseRate val = new QuickFix.Fields.LegRepurchaseRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        this.legRepurchaseRate = val;
                    }
                    
                    public QuickFix.Fields.LegRepurchaseRate get(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRepurchaseRate val) 
                    { 
                        return isSetLegRepurchaseRate();
                    }
                    
                    public bool isSetLegRepurchaseRate() 
                    { 
                        return isSetField(Tags.LegRepurchaseRate);
                    }
                    public QuickFix.Fields.LegFactor legFactor
                    { 
                        get 
                        {
                            QuickFix.Fields.LegFactor val = new QuickFix.Fields.LegFactor();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegFactor val) 
                    { 
                        this.legFactor = val;
                    }
                    
                    public QuickFix.Fields.LegFactor get(QuickFix.Fields.LegFactor val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegFactor val) 
                    { 
                        return isSetLegFactor();
                    }
                    
                    public bool isSetLegFactor() 
                    { 
                        return isSetField(Tags.LegFactor);
                    }
                    public QuickFix.Fields.LegCreditRating legCreditRating
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCreditRating val = new QuickFix.Fields.LegCreditRating();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCreditRating val) 
                    { 
                        this.legCreditRating = val;
                    }
                    
                    public QuickFix.Fields.LegCreditRating get(QuickFix.Fields.LegCreditRating val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCreditRating val) 
                    { 
                        return isSetLegCreditRating();
                    }
                    
                    public bool isSetLegCreditRating() 
                    { 
                        return isSetField(Tags.LegCreditRating);
                    }
                    public QuickFix.Fields.LegInstrRegistry legInstrRegistry
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInstrRegistry val = new QuickFix.Fields.LegInstrRegistry();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        this.legInstrRegistry = val;
                    }
                    
                    public QuickFix.Fields.LegInstrRegistry get(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegInstrRegistry val) 
                    { 
                        return isSetLegInstrRegistry();
                    }
                    
                    public bool isSetLegInstrRegistry() 
                    { 
                        return isSetField(Tags.LegInstrRegistry);
                    }
                    public QuickFix.Fields.LegCountryOfIssue legCountryOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCountryOfIssue val = new QuickFix.Fields.LegCountryOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        this.legCountryOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegCountryOfIssue get(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCountryOfIssue val) 
                    { 
                        return isSetLegCountryOfIssue();
                    }
                    
                    public bool isSetLegCountryOfIssue() 
                    { 
                        return isSetField(Tags.LegCountryOfIssue);
                    }
                    public QuickFix.Fields.LegStateOrProvinceOfIssue legStateOrProvinceOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStateOrProvinceOfIssue val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        this.legStateOrProvinceOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegStateOrProvinceOfIssue get(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) 
                    { 
                        return isSetLegStateOrProvinceOfIssue();
                    }
                    
                    public bool isSetLegStateOrProvinceOfIssue() 
                    { 
                        return isSetField(Tags.LegStateOrProvinceOfIssue);
                    }
                    public QuickFix.Fields.LegLocaleOfIssue legLocaleOfIssue
                    { 
                        get 
                        {
                            QuickFix.Fields.LegLocaleOfIssue val = new QuickFix.Fields.LegLocaleOfIssue();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        this.legLocaleOfIssue = val;
                    }
                    
                    public QuickFix.Fields.LegLocaleOfIssue get(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegLocaleOfIssue val) 
                    { 
                        return isSetLegLocaleOfIssue();
                    }
                    
                    public bool isSetLegLocaleOfIssue() 
                    { 
                        return isSetField(Tags.LegLocaleOfIssue);
                    }
                    public QuickFix.Fields.LegRedemptionDate legRedemptionDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRedemptionDate val = new QuickFix.Fields.LegRedemptionDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        this.legRedemptionDate = val;
                    }
                    
                    public QuickFix.Fields.LegRedemptionDate get(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRedemptionDate val) 
                    { 
                        return isSetLegRedemptionDate();
                    }
                    
                    public bool isSetLegRedemptionDate() 
                    { 
                        return isSetField(Tags.LegRedemptionDate);
                    }
                    public QuickFix.Fields.LegStrikePrice legStrikePrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikePrice val = new QuickFix.Fields.LegStrikePrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        this.legStrikePrice = val;
                    }
                    
                    public QuickFix.Fields.LegStrikePrice get(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStrikePrice val) 
                    { 
                        return isSetLegStrikePrice();
                    }
                    
                    public bool isSetLegStrikePrice() 
                    { 
                        return isSetField(Tags.LegStrikePrice);
                    }
                    public QuickFix.Fields.LegStrikeCurrency legStrikeCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegStrikeCurrency val = new QuickFix.Fields.LegStrikeCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        this.legStrikeCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegStrikeCurrency get(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegStrikeCurrency val) 
                    { 
                        return isSetLegStrikeCurrency();
                    }
                    
                    public bool isSetLegStrikeCurrency() 
                    { 
                        return isSetField(Tags.LegStrikeCurrency);
                    }
                    public QuickFix.Fields.LegOptAttribute legOptAttribute
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptAttribute val = new QuickFix.Fields.LegOptAttribute();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        this.legOptAttribute = val;
                    }
                    
                    public QuickFix.Fields.LegOptAttribute get(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegOptAttribute val) 
                    { 
                        return isSetLegOptAttribute();
                    }
                    
                    public bool isSetLegOptAttribute() 
                    { 
                        return isSetField(Tags.LegOptAttribute);
                    }
                    public QuickFix.Fields.LegContractMultiplier legContractMultiplier
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractMultiplier val = new QuickFix.Fields.LegContractMultiplier();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        this.legContractMultiplier = val;
                    }
                    
                    public QuickFix.Fields.LegContractMultiplier get(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegContractMultiplier val) 
                    { 
                        return isSetLegContractMultiplier();
                    }
                    
                    public bool isSetLegContractMultiplier() 
                    { 
                        return isSetField(Tags.LegContractMultiplier);
                    }
                    public QuickFix.Fields.LegCouponRate legCouponRate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCouponRate val = new QuickFix.Fields.LegCouponRate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCouponRate val) 
                    { 
                        this.legCouponRate = val;
                    }
                    
                    public QuickFix.Fields.LegCouponRate get(QuickFix.Fields.LegCouponRate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCouponRate val) 
                    { 
                        return isSetLegCouponRate();
                    }
                    
                    public bool isSetLegCouponRate() 
                    { 
                        return isSetField(Tags.LegCouponRate);
                    }
                    public QuickFix.Fields.LegSecurityExchange legSecurityExchange
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityExchange val = new QuickFix.Fields.LegSecurityExchange();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        this.legSecurityExchange = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityExchange get(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityExchange val) 
                    { 
                        return isSetLegSecurityExchange();
                    }
                    
                    public bool isSetLegSecurityExchange() 
                    { 
                        return isSetField(Tags.LegSecurityExchange);
                    }
                    public QuickFix.Fields.LegIssuer legIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.LegIssuer val = new QuickFix.Fields.LegIssuer();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegIssuer val) 
                    { 
                        this.legIssuer = val;
                    }
                    
                    public QuickFix.Fields.LegIssuer get(QuickFix.Fields.LegIssuer val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegIssuer val) 
                    { 
                        return isSetLegIssuer();
                    }
                    
                    public bool isSetLegIssuer() 
                    { 
                        return isSetField(Tags.LegIssuer);
                    }
                    public QuickFix.Fields.EncodedLegIssuerLen encodedLegIssuerLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuerLen val = new QuickFix.Fields.EncodedLegIssuerLen();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        this.encodedLegIssuerLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuerLen get(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegIssuerLen val) 
                    { 
                        return isSetEncodedLegIssuerLen();
                    }
                    
                    public bool isSetEncodedLegIssuerLen() 
                    { 
                        return isSetField(Tags.EncodedLegIssuerLen);
                    }
                    public QuickFix.Fields.EncodedLegIssuer encodedLegIssuer
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegIssuer val = new QuickFix.Fields.EncodedLegIssuer();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        this.encodedLegIssuer = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegIssuer get(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegIssuer val) 
                    { 
                        return isSetEncodedLegIssuer();
                    }
                    
                    public bool isSetEncodedLegIssuer() 
                    { 
                        return isSetField(Tags.EncodedLegIssuer);
                    }
                    public QuickFix.Fields.LegSecurityDesc legSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSecurityDesc val = new QuickFix.Fields.LegSecurityDesc();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        this.legSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.LegSecurityDesc get(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSecurityDesc val) 
                    { 
                        return isSetLegSecurityDesc();
                    }
                    
                    public bool isSetLegSecurityDesc() 
                    { 
                        return isSetField(Tags.LegSecurityDesc);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDescLen encodedLegSecurityDescLen
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDescLen val = new QuickFix.Fields.EncodedLegSecurityDescLen();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        this.encodedLegSecurityDescLen = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDescLen get(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegSecurityDescLen val) 
                    { 
                        return isSetEncodedLegSecurityDescLen();
                    }
                    
                    public bool isSetEncodedLegSecurityDescLen() 
                    { 
                        return isSetField(Tags.EncodedLegSecurityDescLen);
                    }
                    public QuickFix.Fields.EncodedLegSecurityDesc encodedLegSecurityDesc
                    { 
                        get 
                        {
                            QuickFix.Fields.EncodedLegSecurityDesc val = new QuickFix.Fields.EncodedLegSecurityDesc();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        this.encodedLegSecurityDesc = val;
                    }
                    
                    public QuickFix.Fields.EncodedLegSecurityDesc get(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.EncodedLegSecurityDesc val) 
                    { 
                        return isSetEncodedLegSecurityDesc();
                    }
                    
                    public bool isSetEncodedLegSecurityDesc() 
                    { 
                        return isSetField(Tags.EncodedLegSecurityDesc);
                    }
                    public QuickFix.Fields.LegRatioQty legRatioQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegRatioQty val = new QuickFix.Fields.LegRatioQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegRatioQty val) 
                    { 
                        this.legRatioQty = val;
                    }
                    
                    public QuickFix.Fields.LegRatioQty get(QuickFix.Fields.LegRatioQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegRatioQty val) 
                    { 
                        return isSetLegRatioQty();
                    }
                    
                    public bool isSetLegRatioQty() 
                    { 
                        return isSetField(Tags.LegRatioQty);
                    }
                    public QuickFix.Fields.LegSide legSide
                    { 
                        get 
                        {
                            QuickFix.Fields.LegSide val = new QuickFix.Fields.LegSide();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegSide val) 
                    { 
                        this.legSide = val;
                    }
                    
                    public QuickFix.Fields.LegSide get(QuickFix.Fields.LegSide val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegSide val) 
                    { 
                        return isSetLegSide();
                    }
                    
                    public bool isSetLegSide() 
                    { 
                        return isSetField(Tags.LegSide);
                    }
                    public QuickFix.Fields.LegCurrency legCurrency
                    { 
                        get 
                        {
                            QuickFix.Fields.LegCurrency val = new QuickFix.Fields.LegCurrency();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegCurrency val) 
                    { 
                        this.legCurrency = val;
                    }
                    
                    public QuickFix.Fields.LegCurrency get(QuickFix.Fields.LegCurrency val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegCurrency val) 
                    { 
                        return isSetLegCurrency();
                    }
                    
                    public bool isSetLegCurrency() 
                    { 
                        return isSetField(Tags.LegCurrency);
                    }
                    public QuickFix.Fields.LegPool legPool
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPool val = new QuickFix.Fields.LegPool();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPool val) 
                    { 
                        this.legPool = val;
                    }
                    
                    public QuickFix.Fields.LegPool get(QuickFix.Fields.LegPool val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPool val) 
                    { 
                        return isSetLegPool();
                    }
                    
                    public bool isSetLegPool() 
                    { 
                        return isSetField(Tags.LegPool);
                    }
                    public QuickFix.Fields.LegDatedDate legDatedDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegDatedDate val = new QuickFix.Fields.LegDatedDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegDatedDate val) 
                    { 
                        this.legDatedDate = val;
                    }
                    
                    public QuickFix.Fields.LegDatedDate get(QuickFix.Fields.LegDatedDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegDatedDate val) 
                    { 
                        return isSetLegDatedDate();
                    }
                    
                    public bool isSetLegDatedDate() 
                    { 
                        return isSetField(Tags.LegDatedDate);
                    }
                    public QuickFix.Fields.LegContractSettlMonth legContractSettlMonth
                    { 
                        get 
                        {
                            QuickFix.Fields.LegContractSettlMonth val = new QuickFix.Fields.LegContractSettlMonth();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        this.legContractSettlMonth = val;
                    }
                    
                    public QuickFix.Fields.LegContractSettlMonth get(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegContractSettlMonth val) 
                    { 
                        return isSetLegContractSettlMonth();
                    }
                    
                    public bool isSetLegContractSettlMonth() 
                    { 
                        return isSetField(Tags.LegContractSettlMonth);
                    }
                    public QuickFix.Fields.LegInterestAccrualDate legInterestAccrualDate
                    { 
                        get 
                        {
                            QuickFix.Fields.LegInterestAccrualDate val = new QuickFix.Fields.LegInterestAccrualDate();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        this.legInterestAccrualDate = val;
                    }
                    
                    public QuickFix.Fields.LegInterestAccrualDate get(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegInterestAccrualDate val) 
                    { 
                        return isSetLegInterestAccrualDate();
                    }
                    
                    public bool isSetLegInterestAccrualDate() 
                    { 
                        return isSetField(Tags.LegInterestAccrualDate);
                    }
                    public QuickFix.Fields.LegUnitOfMeasure legUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasure val = new QuickFix.Fields.LegUnitOfMeasure();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        this.legUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasure get(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegUnitOfMeasure val) 
                    { 
                        return isSetLegUnitOfMeasure();
                    }
                    
                    public bool isSetLegUnitOfMeasure() 
                    { 
                        return isSetField(Tags.LegUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegTimeUnit legTimeUnit
                    { 
                        get 
                        {
                            QuickFix.Fields.LegTimeUnit val = new QuickFix.Fields.LegTimeUnit();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        this.legTimeUnit = val;
                    }
                    
                    public QuickFix.Fields.LegTimeUnit get(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegTimeUnit val) 
                    { 
                        return isSetLegTimeUnit();
                    }
                    
                    public bool isSetLegTimeUnit() 
                    { 
                        return isSetField(Tags.LegTimeUnit);
                    }
                    public QuickFix.Fields.LegOptionRatio legOptionRatio
                    { 
                        get 
                        {
                            QuickFix.Fields.LegOptionRatio val = new QuickFix.Fields.LegOptionRatio();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        this.legOptionRatio = val;
                    }
                    
                    public QuickFix.Fields.LegOptionRatio get(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegOptionRatio val) 
                    { 
                        return isSetLegOptionRatio();
                    }
                    
                    public bool isSetLegOptionRatio() 
                    { 
                        return isSetField(Tags.LegOptionRatio);
                    }
                    public QuickFix.Fields.LegPrice legPrice
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPrice val = new QuickFix.Fields.LegPrice();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPrice val) 
                    { 
                        this.legPrice = val;
                    }
                    
                    public QuickFix.Fields.LegPrice get(QuickFix.Fields.LegPrice val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPrice val) 
                    { 
                        return isSetLegPrice();
                    }
                    
                    public bool isSetLegPrice() 
                    { 
                        return isSetField(Tags.LegPrice);
                    }
                    public QuickFix.Fields.LegMaturityTime legMaturityTime
                    { 
                        get 
                        {
                            QuickFix.Fields.LegMaturityTime val = new QuickFix.Fields.LegMaturityTime();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        this.legMaturityTime = val;
                    }
                    
                    public QuickFix.Fields.LegMaturityTime get(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegMaturityTime val) 
                    { 
                        return isSetLegMaturityTime();
                    }
                    
                    public bool isSetLegMaturityTime() 
                    { 
                        return isSetField(Tags.LegMaturityTime);
                    }
                    public QuickFix.Fields.LegPutOrCall legPutOrCall
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPutOrCall val = new QuickFix.Fields.LegPutOrCall();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        this.legPutOrCall = val;
                    }
                    
                    public QuickFix.Fields.LegPutOrCall get(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPutOrCall val) 
                    { 
                        return isSetLegPutOrCall();
                    }
                    
                    public bool isSetLegPutOrCall() 
                    { 
                        return isSetField(Tags.LegPutOrCall);
                    }
                    public QuickFix.Fields.LegExerciseStyle legExerciseStyle
                    { 
                        get 
                        {
                            QuickFix.Fields.LegExerciseStyle val = new QuickFix.Fields.LegExerciseStyle();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        this.legExerciseStyle = val;
                    }
                    
                    public QuickFix.Fields.LegExerciseStyle get(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegExerciseStyle val) 
                    { 
                        return isSetLegExerciseStyle();
                    }
                    
                    public bool isSetLegExerciseStyle() 
                    { 
                        return isSetField(Tags.LegExerciseStyle);
                    }
                    public QuickFix.Fields.LegUnitOfMeasureQty legUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegUnitOfMeasureQty val = new QuickFix.Fields.LegUnitOfMeasureQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        this.legUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegUnitOfMeasureQty get(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegUnitOfMeasureQty val) 
                    { 
                        return isSetLegUnitOfMeasureQty();
                    }
                    
                    public bool isSetLegUnitOfMeasureQty() 
                    { 
                        return isSetField(Tags.LegUnitOfMeasureQty);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasure legPriceUnitOfMeasure
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasure val = new QuickFix.Fields.LegPriceUnitOfMeasure();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        this.legPriceUnitOfMeasure = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasure get(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPriceUnitOfMeasure val) 
                    { 
                        return isSetLegPriceUnitOfMeasure();
                    }
                    
                    public bool isSetLegPriceUnitOfMeasure() 
                    { 
                        return isSetField(Tags.LegPriceUnitOfMeasure);
                    }
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty legPriceUnitOfMeasureQty
                    { 
                        get 
                        {
                            QuickFix.Fields.LegPriceUnitOfMeasureQty val = new QuickFix.Fields.LegPriceUnitOfMeasureQty();
                            getField(val);
                            return val;
                        }
                        set { setField(value); }
                    }
                    
                    public void set(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        this.legPriceUnitOfMeasureQty = val;
                    }
                    
                    public QuickFix.Fields.LegPriceUnitOfMeasureQty get(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        getField(val);
                        return val;
                    }
                    
                    public bool isSet(QuickFix.Fields.LegPriceUnitOfMeasureQty val) 
                    { 
                        return isSetLegPriceUnitOfMeasureQty();
                    }
                    
                    public bool isSetLegPriceUnitOfMeasureQty() 
                    { 
                        return isSetField(Tags.LegPriceUnitOfMeasureQty);
                    }
                                    public class NoLegSecurityAltID : Group
                    {
                        public NoLegSecurityAltID() 
                          :base( Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
                        {
                        }
                        public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};
                                            public QuickFix.Fields.LegSecurityAltID legSecurityAltID
                        { 
                            get 
                            {
                                QuickFix.Fields.LegSecurityAltID val = new QuickFix.Fields.LegSecurityAltID();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            this.legSecurityAltID = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltID get(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.LegSecurityAltID val) 
                        { 
                            return isSetLegSecurityAltID();
                        }
                        
                        public bool isSetLegSecurityAltID() 
                        { 
                            return isSetField(Tags.LegSecurityAltID);
                        }
                        public QuickFix.Fields.LegSecurityAltIDSource legSecurityAltIDSource
                        { 
                            get 
                            {
                                QuickFix.Fields.LegSecurityAltIDSource val = new QuickFix.Fields.LegSecurityAltIDSource();
                                getField(val);
                                return val;
                            }
                            set { setField(value); }
                        }
                        
                        public void set(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            this.legSecurityAltIDSource = val;
                        }
                        
                        public QuickFix.Fields.LegSecurityAltIDSource get(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            getField(val);
                            return val;
                        }
                        
                        public bool isSet(QuickFix.Fields.LegSecurityAltIDSource val) 
                        { 
                            return isSetLegSecurityAltIDSource();
                        }
                        
                        public bool isSetLegSecurityAltIDSource() 
                        { 
                            return isSetField(Tags.LegSecurityAltIDSource);
                        }
                    
                    }
                }
            }
        }
    }
}
