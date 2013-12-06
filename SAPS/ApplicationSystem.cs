using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

namespace SAPS
{
    public class ApplicationSystem
    {
        private static ApplicationSystem _instance;
        private BindingList<DatabaseEntry> _availableEntries;
        private Dictionary<Thread, DatabaseEntry> _applicationEditors;

        public delegate void ApplicationDelegate(DatabaseEntry entry, ApplicationStatus status);

        public static ApplicationSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public BindingList<DatabaseEntry> Entries
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

        public ApplicationSystem()
        {
            _instance = this;

            _applicationEditors = new Dictionary<Thread, DatabaseEntry>();
            _availableEntries = new BindingList<DatabaseEntry>();
        }

        public void ModifyApplication(DatabaseEntry entry)
        {
            StartApplicationThread(entry);
        }

        private void StartApplicationThread(DatabaseEntry entry)
        {
            if(!_applicationEditors.ContainsValue(entry))
            {
                Thread thread = new Thread(() => ApplicationThread(entry));
                _applicationEditors.Add(thread, entry);
                thread.Start();
            }
        }

        public void ApplicationThread(DatabaseEntry entry)
        {
            FormStorage<ApplicationStatus> storage = new FormStorage<ApplicationStatus>(ApplicationStatus.Cancel);
            ApplicationEditor editor = new ApplicationEditor(entry, storage);
            Application.Run(new ApplicationEditor(entry, storage));
            _applicationEditors.Remove(Thread.CurrentThread);
            SAPS.Instance.Invoke(new ApplicationDelegate(UpdateApplications), new object[] { editor.Entry, storage.Status });
        }

        private void UpdateApplications(DatabaseEntry entry, ApplicationStatus status)
        {
            switch(status)
            {
                case ApplicationStatus.Cancel:
                    break;
                case ApplicationStatus.Remove:
                    _availableEntries.Remove(entry);
                    Database.Instance.Remove(entry);
                    break;
                case ApplicationStatus.Modify:
                    break;
                case ApplicationStatus.Approve:
                    // lots of shit here
                    break;
                case ApplicationStatus.Reject:
                    // remove from available and full database
                    // sent to server for archive
                    break;
            }

            SAPS.Instance.UpdateApplicationList();
        }

        public void CloseEditors()
        {
            foreach (KeyValuePair<Thread, DatabaseEntry> pair in _applicationEditors)
            {
                pair.Key.Abort();
            }
        }
    }
}
