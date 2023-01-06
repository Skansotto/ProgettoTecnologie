using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMBet
{
    public class Flags
    {
        bool flagEnd;

        public Flags() 
        { flagEnd=false; }

        public bool getFlagEnd()
        { return flagEnd; }

        public void setFlagEnd(bool newFlag)
        {
            this.flagEnd = newFlag;
        }

    }
}
