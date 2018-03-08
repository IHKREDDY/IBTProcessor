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
                if(evt.EventType=="1")
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
                messageBody.Append("ProductNameFull - " + objInstrument.ProductNameFull);
                messageBody.Append(Environment.NewLine);
                messageBody.Append("IBTTypeCode - " + objInstrument.IBTTypeCode);
                messageBody.Append(Environment.NewLine);

                var ISIN = (from instrmentID in objInstrument.InstrumentIds
                           where instrmentID.IdSchemeCode == "I-"
                           select instrmentID.IdValue).First();
                messageBody.Append("ISIN  - " + ISIN);
                messageBody.Append(Environment.NewLine);
            }

            //If event is attached , send SMTP email
            SMTP.SendEmail("admin@vontobel.com", "user@bankabc.com", "IBT Term Sheet", messageBody.ToString());

            return true;
        }
    }
}
