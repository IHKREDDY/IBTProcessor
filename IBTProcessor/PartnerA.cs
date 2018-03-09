using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTProcessor
{
    public class PartnerA:IPartner
    {
        public  Boolean ProcessIBTMessage(IBTTermSheet objIBTTermSheet)
        {

         Boolean eventMatched = false;
         StringBuilder messageBody = new StringBuilder();


          foreach(var evt in  objIBTTermSheet.Events)
          {
                //Get this from config
                //Event List to be maintained in config, as of now PartnerB is interested in EventType 1

                if (evt.EventType=="1")
                {
                    messageBody.Append("EventType - " + evt.EventType);
                    messageBody.Append(Environment.NewLine);
                    eventMatched = true;
                    break;
                }
          }

          if(eventMatched)
          {
                var objInstrument = objIBTTermSheet.Instrument.First();
                //Get ProductNameFull
                messageBody.Append("ProductNameFull - " + objInstrument.ProductNameFull);
                messageBody.Append(Environment.NewLine);
                //Get IBT Type Code
                messageBody.Append("IBTTypeCode - " + objInstrument.IBTTypeCode);
                messageBody.Append(Environment.NewLine);
                //Get ISIN
                var ISIN = (from instrmentID in objInstrument.InstrumentIds
                           where instrmentID.IdSchemeCode == "I-"
                           select instrmentID.IdValue).First();
                messageBody.Append("ISIN  - " + ISIN);
                messageBody.Append(Environment.NewLine);
            }

            //send SMTP email
           // SMTP.SendEmail("admin@vontobel.com", "user@bankabc.com", "IBT Term Sheet", messageBody.ToString());

            return true;
        }
    }
}
