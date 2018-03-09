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
using System.Configuration;
using System.Xml;

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
            int interval;
            
            //Change the value of interval, based on frequency of messages
            if(Int32.TryParse(ConfigurationSettings.AppSettings["IBTInterval"],out interval))
            {
                IBTTimer.Interval = interval;
            }
            IBTTimer.Enabled = true;
        }

        protected override void OnStop()
        {
            IBTTimer.Enabled = false;
        }

        private void IBTTimer_Tick(object sender, EventArgs e)
        {
            SendMessage();
            ReadMessage();
        }

        private void SendMessage()
        {
            //sending Sample IBT.xml to MSMQ for testing
            try
            {
                if (Utility.ISMSMQInstalled())
                {
                    MessageQueue IBTQueue;
                    Message IBTMessage;
                    string queuePath = ConfigurationSettings.AppSettings["IBTQueuePath"];
                    if (MessageQueue.Exists(queuePath))
                    {
                        IBTQueue = new MessageQueue(queuePath);

                        XmlDocument xmlDoc = new XmlDocument();

                        IBTMessage = new System.Messaging.Message("IBT Message");

                        xmlDoc.Load(ConfigurationSettings.AppSettings["IBTSourceFile"]);

                        IBTMessage.Body = xmlDoc;
                        IBTQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
                        IBTQueue.Send(IBTMessage);

                        // Hold thread.
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10.0));
                    }
                }
            }
            catch (MessageQueueException)
            {
                // Handle Message Queuing exceptions.
            }
            catch (InvalidOperationException)
            {
                // Handle invalid serialization format.
            }
            catch (Exception)
            {
                // Catch other exceptions as necessary.
            }
        }

        private void ReadMessage()
        {
            try
            {
                Boolean readFromSampleFile = false;

                if(Utility.ISMSMQInstalled())
                {
                    MessageQueue IBTQueue;
                    Message IBTMessage;
                    string queuePath = ConfigurationSettings.AppSettings["IBTQueuePath"];
                    if (MessageQueue.Exists(queuePath))
                    {
                        IBTQueue = new MessageQueue(queuePath);
                        //XML Formatting
                        IBTQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
                        IBTMessage = IBTQueue.Receive();
                        IBTTermSheet objIBTTermSheet = XMLconvertor.convertXMLtoIBTTermSheet(IBTMessage.Body.ToString(), true);
                        //Process Messages as per partner requirement
                        IPartner objPartner = new PartnerA();
                        objPartner.ProcessIBTMessage(objIBTTermSheet);

                        objPartner = new PartnerB();
                        objPartner.ProcessIBTMessage(objIBTTermSheet);

                        //Insert to DB
                        objPartner = new IBTDB();
                        //objPartner.ProcessIBTMessage(objIBTTermSheet);
                    }
                    else
                    {
                        //Queue not Exists
                        readFromSampleFile = true;
                    }
                }
                else
                {
                    // Not installed
                    readFromSampleFile = true;
                }

                if (readFromSampleFile)
                {
                    //Read from local file
                    IBTTermSheet objIBTTermSheet = XMLconvertor.convertXMLtoIBTTermSheet("", true);

                    IPartner objPartner = new PartnerA();
                    objPartner.ProcessIBTMessage(objIBTTermSheet);

                    objPartner = new PartnerB();
                    objPartner.ProcessIBTMessage(objIBTTermSheet);

                    //Insert to DB
                    objPartner = new IBTDB();
                   // objPartner.ProcessIBTMessage(objIBTTermSheet);
                }
            }

            catch (MessageQueueException)
            {
                // Handle Message Queuing exceptions.
            }
            catch (InvalidOperationException)
            {
                // Handle invalid serialization format.
            }
            catch (Exception)
            {
                // Catch other exceptions as necessary.
            }
            return;
        }


        //Test Method for debugging
        internal void TestStartupAndStop(string[] args)
        {
            //To Test functionality, without installing the service
            this.OnStart(args);
            SendMessage();
            ReadMessage();
            Console.ReadLine();
            this.OnStop();
        }
    }
}
