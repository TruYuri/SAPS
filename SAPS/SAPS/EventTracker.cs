using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

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

        List<EventEntry> _events;

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

        public void Serialize(DataContractJsonSerializer serializer, MemoryStream stream)
        {
            serializer.WriteObject(stream, _events);
        }

        public void Populate(DataContractJsonSerializer serializer, MemoryStream stream)
        {
            _events = serializer.ReadObject(stream) as List<EventEntry>;
        }
    }
}
