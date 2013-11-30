using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SAPS
{
    class EventEntry
    {
        public string EventName;
        public DateTime SubmissionTime;
        public string Description;
        public string EventCreator;
        public DateTime EventActivationTime;
        public DateTime EventDeactivationTime;
    }

    class EventTracker
    {
        private static EventTracker _instance;
        private List<EventEntry> _events;

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

            _events = new List<EventEntry>();
        }

        public string Serialize(JavaScriptSerializer serializer)
        {
            return serializer.Serialize(_events);
        }

        public void Populate(JavaScriptSerializer serializer, string json)
        {
            serializer.Deserialize<List<EventEntry>>(json);

            EventEntry event1 = new EventEntry();
            event1.EventName = "Birthday";
            event1.SubmissionTime = new DateTime(1992, 12, 12);
            event1.Description = "21st Birthday";
            event1.EventCreator = "Sherri";
            event1.EventActivationTime = new DateTime(1992, 12, 12, 0, 0, 0);
            event1.EventDeactivationTime = new DateTime(1992, 12, 13, 0, 0, 0);
            _events.Add(event1);
        }
    }
}
