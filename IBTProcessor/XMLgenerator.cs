using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IBTProcessor
{
    public class XMLgenerator
    {
        public static void SaveXML(string filePath,string XML)
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, XML);
            }
               
        }
    }
}
