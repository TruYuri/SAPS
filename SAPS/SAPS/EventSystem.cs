using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPS
{
 
    class EventSystem
    {
        private static EventSystem _instance;
        private List<EventEntry> _events;
        private Dictionary<Thread, EventEntry> _eventEditors;

        public static EventSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public List<EventEntry> Events
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
            _events = new List<EventEntry>();
        }

        public void StartEventThread(EventEntry entry)
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

            if (!exists)
            {
                Thread thread = new Thread(() => EventThread(entry));
                _eventEditors.Add(thread, entry);
                thread.Start();
            }
        }

        public void EventThread(EventEntry entry)
        {
            Application.Run(new EventEditor(entry));
        }
    }
}
