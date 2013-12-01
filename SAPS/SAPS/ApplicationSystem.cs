using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SAPS
{
    class ApplicationSystem
    {
        private static ApplicationSystem _instance;
        private List<DatabaseEntry> _availableEntries;
        private Dictionary<Thread, DatabaseEntry> _applicationEditors;

        public List<DatabaseEntry> Entries
        {
            get
            {
                return _availableEntries;
            }
            set
            {
                _availableEntries = value;
            }
        }

        public static ApplicationSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public ApplicationSystem()
        {
            _instance = this;

            _applicationEditors = new Dictionary<Thread, DatabaseEntry>();
            _availableEntries = new List<DatabaseEntry>();
        }

        public void StartApplicationThread(DatabaseEntry entry)
        {
            bool exists = false;
            foreach (KeyValuePair<Thread, DatabaseEntry> pair in _applicationEditors)
            {
                if (pair.Value.Equals(entry))
                {
                    if (pair.Key.IsAlive)
                    {
                        exists = true;
                    }
                    else
                    {
                        _applicationEditors.Remove(pair.Key);
                    }
                    break;
                }
            }

            if (!exists)
            {
                Thread thread = new Thread(() => ApplicationThread(entry));
                _applicationEditors.Add(thread, entry);
                thread.Start();
            }
        }

        public void ApplicationThread(DatabaseEntry entry)
        {
            Application.Run(new ApplicationEditor(entry));
        }
    }
}
