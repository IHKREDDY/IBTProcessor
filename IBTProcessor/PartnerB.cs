using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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
                if (evt.EventType == "1")
                {
                    eventMatched = true;
                    break;
                }
            }

            if (eventMatched)
            {
                var objInstrument = objIBTTermSheet.Instrument.First();

                var ISIN = (from instrmentID in objInstrument.InstrumentIds
                            where instrmentID.IdSchemeCode == "I-"
                            select instrmentID.IdValue).First();

                var currentTimeStamp = DateTime.Now.ToString("hh:mm:ss tt");

                PartnerBData objPartnerBData = new PartnerBData();
                objPartnerBData.ISIN = ISIN;
                objPartnerBData.CurrentTimeStamp = currentTimeStamp;

                //Genrate XML
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(objPartnerBData.GetType());
                serializer.Serialize(stringwriter, objPartnerBData);
                XMLgenerator.SaveXML("../../parnetB.XML",stringwriter.ToString());
            }
            //If event is attached Save XML to file location
            return true;
        }
    }

    public class PartnerBData
    {
        public string CurrentTimeStamp { get; set; }
        public string ISIN { get; set; }
    }
}
