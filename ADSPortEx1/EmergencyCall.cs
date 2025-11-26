using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1
{

    //EmergencyCall class implementation for use with 
    // EmergencyQueue structure

    //Do not delete the current function definitions, just replace the exceptions with the required functionality...

    //See material from 'C# Classes' in week 2 to 
    // aid with implementation...

    class EmergencyCall : IComparable
    {
        private string EmergencyType;
        private string CallerName;
        private int SeverityLevel;

        public EmergencyCall(string CallerName, string EmergencyType, int SeverityLevel)
        {
            CallerName = CallerName;
            EmergencyType = EmergencyType;
            SeverityLevel = 0;
        }

        public string CallerName
        {
            get { return CallerName;  }
            set { CallerName = value; }
        }

        public string EmergencyType
        {
            get { return EmergencyType; }
            set { EmergencyType = value; }
        }

        public int SeverityLevel
        {
            get { return SeverityLevel; }
            set { SeverityLevel = value; }
        }

        public int CompareTo(object obj)
        {
            EmergencyCall other = (EmergencyCall)obj;
            return SeverityLevel.CompareTo(other.SeverityLevel);
        }


    }// End of class...
}
