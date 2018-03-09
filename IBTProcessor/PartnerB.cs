using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Configuration;

namespace IBTProcessor
{
    class PartnerB : IPartner
    {
        public Boolean ProcessIBTMessage(IBTTermSheet objIBTTermSheet)
        {
            Boolean eventMatched = false;

            foreach (var evt in objIBTTermSheet.Events)
            {
                //Get this from config
                //Event List to be maintained in config, as of now PartnerB is interested in EventType 1
                if (evt.EventType == "1")
                {
                    eventMatched = true;
                    break;
                }
            }

            if (eventMatched)
            {
                //Get Instrument object
                var objInstrument = objIBTTermSheet.Instrument.First();

                //Get ISIN Code
                var ISIN = (from instrmentID in objInstrument.InstrumentIds
                            where instrmentID.IdSchemeCode == "I-"
                            select instrmentID.IdValue).First();

                //Get Current Time Stamp
                var currentTimeStamp = DateTime.Now.ToString("hh:mm:ss tt");

                InstrumentNotification objInstrumentNotification = new InstrumentNotification();
                objInstrumentNotification.ISIN = ISIN;
                objInstrumentNotification.CurrentTimeStamp = currentTimeStamp;

                //Genrate XML
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(objInstrumentNotification.GetType());
                serializer.Serialize(stringwriter, objInstrumentNotification);
                XMLgenerator.SaveXML(ConfigurationSettings.AppSettings["PartnerBTarget"], stringwriter.ToString());
            }
            //If event is attached Save XML to file location
            return true;
        }
    }

  
    public class InstrumentNotification
    {
        public string CurrentTimeStamp { get; set; }
        public string ISIN { get; set; }
    }
}
