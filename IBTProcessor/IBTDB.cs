using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTProcessor
{
    class IBTDB : IPartner
    {
        public Boolean ProcessIBTMessage(IBTTermSheet objIBTTermSheet)
        {
            string eventType= "";

            foreach (var evt in objIBTTermSheet.Events)
            {
                eventType = evt.EventType;
                break;
            }

           //Get Current Time Stamp
           var currentTimeStamp = DateTime.Now.ToString("hh:mm:ss tt");

          //Insert into DB
           DataAccessLayer.InsertIBTData("insertIBTData", eventType, currentTimeStamp);

           return true;
        }
    }
}
