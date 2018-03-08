using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.Xml.Linq;

namespace IBTProcessor
{
    public partial class IBTProcessor : ServiceBase
    {
        public IBTProcessor()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ReadMessage();
        }

        protected override void OnStop()
        {
        }

        private void ReadMessage()
        {
            // Get Message from Queue
            MessageQueue IBTQueue;

            if(MessageQueue.Exists(@".\Private$\IBTQueue"))
            {
                IBTQueue = new MessageQueue(@".\Private$\IBTQueue");
            }
            else
            {

                //Read from local file
                //Load xml
                IBTTermSheet objIBTTermSheet =  XMLconvertor.convertXMLtoIBTTermSheet();
                IPartner objPArtnerA = new PartnerB();
                objPArtnerA.ProcessIBTMessage(objIBTTermSheet);
                //log Queue is empty
                return;
            }

            //XML Formatting
            IBTQueue.Formatter = new XmlMessageFormatter(new Type[]{typeof(String)});

            try
            {
                // Receive and format the message. 
                Message IBTMessage = IBTQueue.Receive();
                IBTTermSheet IBTTermSheet = (IBTTermSheet)IBTMessage.Body;

                
            }

            catch (MessageQueueException)
            {
                // Handle Message Queuing exceptions.
            }

            // Handle invalid serialization format.
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            // Catch other exceptions as necessary.

            return;
        }

        internal void TestStartupAndStop(string[] args)
        {
            this.OnStart(args);
            Console.ReadLine();
            this.OnStop();
        }
    }
}
