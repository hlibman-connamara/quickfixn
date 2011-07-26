using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43 
    {
        public class SecurityTypes : Message
        {
            public SecurityTypes() : base()
            {
                this.Header.setField(new QuickFix.Fields.MsgType("w"));
            }

            public SecurityTypes(
                    QuickFix.Fields.SecurityReqID aSecurityReqID,
                    QuickFix.Fields.SecurityResponseID aSecurityResponseID,
                    QuickFix.Fields.SecurityResponseType aSecurityResponseType
                ) : this()
            {
                this.securityReqID = aSecurityReqID;
                this.securityResponseID = aSecurityResponseID;
                this.securityResponseType = aSecurityResponseType;
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
            public QuickFix.Fields.SecurityResponseType securityResponseType
            { 
                get 
                {
                    QuickFix.Fields.SecurityResponseType val = new QuickFix.Fields.SecurityResponseType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SecurityResponseType val) 
            { 
                this.securityResponseType = val;
            }
            
            public QuickFix.Fields.SecurityResponseType get(QuickFix.Fields.SecurityResponseType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SecurityResponseType val) 
            { 
                return isSetSecurityResponseType();
            }
            
            public bool isSetSecurityResponseType() 
            { 
                return isSetField(Tags.SecurityResponseType);
            }
            public QuickFix.Fields.TotalNumSecurityTypes totalNumSecurityTypes
            { 
                get 
                {
                    QuickFix.Fields.TotalNumSecurityTypes val = new QuickFix.Fields.TotalNumSecurityTypes();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.TotalNumSecurityTypes val) 
            { 
                this.totalNumSecurityTypes = val;
            }
            
            public QuickFix.Fields.TotalNumSecurityTypes get(QuickFix.Fields.TotalNumSecurityTypes val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.TotalNumSecurityTypes val) 
            { 
                return isSetTotalNumSecurityTypes();
            }
            
            public bool isSetTotalNumSecurityTypes() 
            { 
                return isSetField(Tags.TotalNumSecurityTypes);
            }
            public QuickFix.Fields.NoSecurityTypes noSecurityTypes
            { 
                get 
                {
                    QuickFix.Fields.NoSecurityTypes val = new QuickFix.Fields.NoSecurityTypes();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.NoSecurityTypes val) 
            { 
                this.noSecurityTypes = val;
            }
            
            public QuickFix.Fields.NoSecurityTypes get(QuickFix.Fields.NoSecurityTypes val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.NoSecurityTypes val) 
            { 
                return isSetNoSecurityTypes();
            }
            
            public bool isSetNoSecurityTypes() 
            { 
                return isSetField(Tags.NoSecurityTypes);
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
            public QuickFix.Fields.SubscriptionRequestType subscriptionRequestType
            { 
                get 
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    getField(val);
                    return val;
                }
                set { setField(value); }
            }
            
            public void set(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                this.subscriptionRequestType = val;
            }
            
            public QuickFix.Fields.SubscriptionRequestType get(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                getField(val);
                return val;
            }
            
            public bool isSet(QuickFix.Fields.SubscriptionRequestType val) 
            { 
                return isSetSubscriptionRequestType();
            }
            
            public bool isSetSubscriptionRequestType() 
            { 
                return isSetField(Tags.SubscriptionRequestType);
            }
            public class NoSecurityTypes : Group
            {
                public NoSecurityTypes() 
                  :base( Tags.NoSecurityTypes, Tags.SecurityType, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.SecurityType, Tags.Product, Tags.CFICode, 0};
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
            
            }
        }
    }
}
