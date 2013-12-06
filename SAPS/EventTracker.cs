using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.ComponentModel;

namespace SAPS
{
    public class EventEntry
    {
        public string eventName;
        public string description;
        public DateTime eventActivationTime;
        public DateTime eventDeactivationTime;
        public DateTime submissionTime;

        [ScriptIgnore] public string EventName
        {
            get
            {
                return eventName;
            }
        }

        [ScriptIgnore] public string EventStart
        {
            get
            {
                return eventActivationTime.ToString();
            }
        }

        [ScriptIgnore] public string EventEnd
        {
            get
            {
                return eventDeactivationTime.ToString();
            }
        }
    }

    class EventTracker
    {
        private static EventTracker _instance;
        private BindingList<EventEntry> _events;

        public static EventTracker Instance
        {
            get
            {
                return _instance;
            }
        }

        public EventTracker()
        {
            _instance = this;

            _events = new BindingList<EventEntry>();
        }

        public string Serialize(JavaScriptSerializer serializer)
        {
            return serializer.Serialize(_events);
        }

        public void Populate(JavaScriptSerializer serializer, string json)
        {
            _events = serializer.Deserialize<BindingList<EventEntry>>(json);

            if(_events == null)
            {
                _events = new BindingList<EventEntry>();
            }

            EventEntry event1 = new EventEntry();
            event1.eventName = "Birthday";
            event1.submissionTime = new DateTime(1992, 12, 12);
            event1.description = "21st Birthday";
            event1.eventActivationTime = new DateTime(1992, 12, 12, 0, 0, 0);
            event1.eventDeactivationTime = new DateTime(1992, 12, 13, 0, 0, 0);
            _events.Add(event1);

            EventSystem.Instance.Events = _events;

            // check if events are ongoing, and notify
        }
    }
}
