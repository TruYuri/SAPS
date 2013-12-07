using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.ComponentModel;
using System.Windows.Forms;

namespace SAPS
{
    public class EventEntry
    {
        public string eventName;
        public string description;
        public DateTime eventActivationTime;
        public DateTime eventDeactivationTime;
        public DateTime submissionTime;
        [ScriptIgnore] public EventStage stage;

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

        [ScriptIgnore] public string Status
        {
            get
            {
                return stage.ToString();
            }
        }
    }

    class Tracker
    {
        public System.Threading.Timer timer;
        public EventEntry entry;

        public Tracker(EventEntry e)
        {
            entry = e;
        }
    }

    class EventTracker
    {
        private static EventTracker _instance;
        private BindingList<EventEntry> _events;
        private List<System.Threading.Timer> _timers;
        private static TimeSpan span = new TimeSpan(0, 0, 5);

        private delegate void TimeDelegate();

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
            _timers = new List<System.Threading.Timer>();
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
            event1.eventActivationTime = new DateTime(2013, 12, 7, 2, 8, 0);
            event1.eventDeactivationTime = new DateTime(2013, 12, 7, 2, 9, 0);
            _events.Add(event1);

            UpdateEventTracker();

            EventSystem.Instance.Events = _events;
        }

        public void UpdateEventTracker()
        {
            // clear any existing trackers
            foreach (System.Threading.Timer timer in _timers)
            {
                timer.Dispose();
            }

            // add event start if the event hasn't started
            // check if events are ongoing, notify, and add end event to tracker if it is
            Tracker tracker;
            for (int i = 0; i < _events.Count; i++)
            {
                if (_events[i].eventActivationTime <= DateTime.Now) // event started before load
                {
                    if (_events[i].eventDeactivationTime >= DateTime.Now) // time between start and end
                    {
                        MessageBox.Show(_events[i].eventName + " is ongoing!", "Ongoing Event", MessageBoxButtons.OK);
                        _events[i].stage = EventStage.Ongoing;

                        tracker = new Tracker(_events[i]);
                        tracker.timer = new System.Threading.Timer(new TimerCallback(TriggerEvent), tracker, _events[i].eventDeactivationTime.Subtract(DateTime.Now), span);

                        _timers.Add(tracker.timer);
                    }
                    else // after event end
                    {
                        _events[i].stage = EventStage.Ended;
                    }
                }
                else // event hasn't started yet
                {
                    _events[i].stage = EventStage.NotYetStarted;

                    tracker = new Tracker(_events[i]);
                    tracker.timer = new System.Threading.Timer(new TimerCallback(TriggerEvent), tracker, _events[i].eventActivationTime.Subtract(DateTime.Now), span);

                    _timers.Add(tracker.timer);
                }
            }
        }

        private void TriggerEvent(object source)
        {
            Tracker tracker = source as Tracker;
            if (tracker.entry.stage == EventStage.NotYetStarted)
            {
                MessageBox.Show(tracker.entry.eventName + " has started!", "Event Started", MessageBoxButtons.OK);
                tracker.timer.Dispose(); // delete tracker
                _timers.Remove(tracker.timer); // remove

                tracker.timer = new System.Threading.Timer(new TimerCallback(TriggerEvent), tracker, tracker.entry.eventDeactivationTime.Subtract(DateTime.Now), span);
                tracker.entry.stage = EventStage.Ongoing;
                _timers.Add(tracker.timer); // add new
            }
            else if (tracker.entry.stage == EventStage.Ongoing)
            {
                MessageBox.Show(tracker.entry.eventName + " has ended!", "Event Ended", MessageBoxButtons.OK);
                tracker.entry.stage = EventStage.Ended;
                tracker.timer.Dispose(); // delete tracker
                _timers.Remove(tracker.timer); // remove
            }
            SAPS.Instance.Invoke(new TimeDelegate(SAPS.Instance.UpdateEventList));
        }
    }
}