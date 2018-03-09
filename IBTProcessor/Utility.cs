using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.ServiceProcess;

namespace IBTProcessor
{
    class Utility
    {
        public static Boolean ISMSMQInstalled()
        {
            Boolean ISMSMQInstalled = false;
            //check If MSMQ is running 
            List<ServiceController> services = ServiceController.GetServices().ToList();
            ServiceController msQue = services.Find(o => o.ServiceName == "MSMQ");
            if (msQue != null)
            {
                if (msQue.Status == ServiceControllerStatus.Running)
                {
                    ISMSMQInstalled= true;
                }
            }
            return ISMSMQInstalled;
        }
    }
}
