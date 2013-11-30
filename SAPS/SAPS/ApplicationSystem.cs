using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    class ApplicationSystem
    {
        private static ApplicationSystem _instance;
        private List<DatabaseEntry> _availableEntries;
        private List<string> _entryNames;
        

        public List<DatabaseEntry> Entries
        {
            get
            {
                return _availableEntries;
            }
            set
            {
                _availableEntries = value;

                if(_availableEntries != null)
                {
                    _entryNames.Clear();

                    foreach(DatabaseEntry entry in _availableEntries)
                    {
                        _entryNames.Add(entry.lastName + ", " + entry.firstName + " " + entry.middleName);
                    }
                }
            }
        }

        public List<string> EntryNames
        {
            get
            {
                return _entryNames;
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

            _availableEntries = new List<DatabaseEntry>();
            _entryNames = new List<string>();
        }

        public void Update()
        {

        }
    }
}
