using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTProcessor
{
    interface IPartner
    {
       Boolean ProcessIBTMessage(IBTTermSheet objIBTTermSheet);
    }
}
