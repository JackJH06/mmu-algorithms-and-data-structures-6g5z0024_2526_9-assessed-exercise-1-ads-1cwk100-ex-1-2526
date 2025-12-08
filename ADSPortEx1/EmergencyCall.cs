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
        private string emergencyType;
        private string callerName;
        private int severityLevel;

        public EmergencyCall(string callerName, string emergencyType, int severityLevel)
        {
            this.callerName = CallerName;
            EmergencyType = EmergencyType;
            SeverityLevel = 0;
        }

        public string CallerName
        {
            get { return callerName; }
            set { callerName = value; }
        }

        public string EmergencyType
        {
            get { return emergencyType; }
            set { emergencyType = value; }
        }

        public int SeverityLevel
        {
            get { return severityLevel; }
            set { severityLevel = value; }
        }

        public int CompareTo(object obj)
        {
            EmergencyCall other = (EmergencyCall)obj;
            return SeverityLevel.CompareTo(other.SeverityLevel);
        }

        public override string ToString()
        {
            return "name" + CallerName + "type" + EmergencyType + "level" + SeverityLevel;
        }



    }// End of class...
}
