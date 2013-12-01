using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

public enum EventMode { Create, Modify };

namespace SAPS
{
    public class EventSystem
    { 
        private static EventSystem _instance;
        private BindingList<EventEntry> _events;
        private Dictionary<Thread, EventEntry> _eventEditors;

        public delegate void EventDelegate(EventStatus status, EventEntry entry);

        public static EventSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public BindingList<EventEntry> Events
        {
            get
            {
                return _events;
            }
            set
            {
                _events = value;
            }
        }

        public EventSystem()
        {
            _instance = this;
            _eventEditors = new Dictionary<Thread, EventEntry>();
            _events = new BindingList<EventEntry>();
        }

        public void CreateEvent()
        {
            StartEventThread(new EventEntry(), EventMode.Create);
        }

        public void ModifyEvent(EventEntry entry)
        {
            StartEventThread(entry, EventMode.Modify);
        }

        private void StartEventThread(EventEntry entry, EventMode eventMode)
        {
            bool exists = false;
            foreach (KeyValuePair<Thread, EventEntry> pair in _eventEditors)
            {
                if (pair.Value.Equals(entry))
                {
                    if (pair.Key.IsAlive)
                    {
                        exists = true;
                    }
                    else
                    {
                        _eventEditors.Remove(pair.Key);
                    }
                    break;
                }
            }

            if(!exists)
            {
                Thread thread = new Thread(() => EventThread(entry, eventMode));
                _eventEditors.Add(thread, entry);
                thread.Start();
            }
        }

        public void EventThread(EventEntry entry, EventMode eventMode)
        {
            EventEditor editor = new EventEditor(entry, eventMode);
            Application.Run(editor);
            SAPS.Instance.Invoke(new EventDelegate(this.UpdateEvents), new object[] { editor.Status, editor.Entry });
        }

        private void UpdateEvents(EventStatus status, EventEntry entry)
        {
            switch (status)
            {
                case EventStatus.Remove:
                    EventSystem.Instance.Events.Remove(entry);
                    break;
                case EventStatus.Create:
                    EventSystem.Instance.Events.Add(entry);
                    break;
            }

            SAPS.Instance.UpdateEventList();
        }
    }
}
