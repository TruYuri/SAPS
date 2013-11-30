using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SAPS
{
    [DataContract]
    class EventEntry
    {
        [DataMember] public string EventName;
        [DataMember] public DateTime SubmissionTime;
        [DataMember] public string Description;
        [DataMember] public string EventCreator;
        [DataMember] public DateTime EventActivationTime;
        [DataMember] public DateTime EventDeactivationTime;
    }

    class EventTracker
    {
        private static EventTracker _instance;

        public EventTracker Instance
        {
            get
            {
                return _instance;
            }
        }

        public EventTracker()
        {
            _instance = this;
        }
    }
}
