using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace SAPS
{
    public class EventSystem
    { 
        private static EventSystem _instance;
        private BindingList<EventEntry> _events;
        private Dictionary<Thread, EventEntry> _eventEditors;

        private delegate void EventDelegate(EventEntry entry, EventStatus status);

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
            StartEventThread(new EventEntry(), EventStatus.Create);
        }

        public void ModifyEvent(EventEntry entry)
        {
            StartEventThread(entry, EventStatus.Modify);
        }

        public void PrintEvent(EventEntry entry)
        {
            StartEventThread(entry, EventStatus.Print);
        }

        private void StartEventThread(EventEntry entry, EventStatus eventMode)
        {
            if(!_eventEditors.ContainsValue(entry) || eventMode == EventStatus.Print)
            {
                Thread thread = new Thread(() => EventThread(entry, eventMode));
                _eventEditors.Add(thread, entry);
                thread.Start();
            }
        }

        public void EventThread(EventEntry entry, EventStatus eventMode)
        {
            FormStorage<EventStatus> storage = new FormStorage<EventStatus>(eventMode);
            EventEditor editor = new EventEditor(entry, storage);
            Application.Run(editor);
            _eventEditors.Remove(Thread.CurrentThread);
            SAPS.Instance.Invoke(new EventDelegate(UpdateEvents), new object[] { editor.Entry, storage.Status });
        }

        private void UpdateEvents(EventEntry entry, EventStatus status)
        {
            switch (status)
            {
                case EventStatus.Cancel:
                    break;
                case EventStatus.Remove:
                    EventSystem.Instance.Events.Remove(entry);
                    break;
                case EventStatus.Modify:
                    break;
                case EventStatus.Create:
                    EventSystem.Instance.Events.Add(entry);
                    break;
            }

            EventTracker.Instance.UpdateEventTracker();
            SAPS.Instance.UpdateEventList();
        }

        public void CloseEditors()
        {
            foreach (KeyValuePair<Thread, EventEntry> pair in _eventEditors)
            {
                pair.Key.Abort();
            }
        }
    }
}