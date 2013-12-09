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

        private delegate void ApplicationDelegate(DatabaseEntry entry, ApplicationStatus status);

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
            StartApplicationThread(entry, ApplicationStatus.Modify);
        }

        public void PrintApplication(DatabaseEntry entry)
        {
            StartApplicationThread(entry, ApplicationStatus.Print);
        }

        private void StartApplicationThread(DatabaseEntry entry, ApplicationStatus status)
        {
            if(!_applicationEditors.ContainsValue(entry) || status == ApplicationStatus.Print)
            {
                Thread thread = new Thread(() => ApplicationThread(entry, status));
                _applicationEditors.Add(thread, entry);
                thread.Start();
            }
        }

        public void ApplicationThread(DatabaseEntry entry, ApplicationStatus status)
        {
            FormStorage<ApplicationStatus> storage = new FormStorage<ApplicationStatus>(status);
            ApplicationEditor editor = new ApplicationEditor(entry, storage);
            Application.Run(new ApplicationEditor(entry, storage));
            _applicationEditors.Remove(Thread.CurrentThread);
            SAPS.Instance.Invoke(new ApplicationDelegate(UpdateApplications), new object[] { editor.Entry, storage.Status });
        }

        private void UpdateApplications(DatabaseEntry entry, ApplicationStatus status)
        {
            switch(status)
            {
                case ApplicationStatus.Remove:
                    _availableEntries.Remove(entry);
                    Database.Instance.Remove(entry);
                    break;
                case ApplicationStatus.Approve:
                    // remove from available
                    _availableEntries.Remove(entry);

                    if (entry.studentType == StudentType.Undergraduate)
                    {
                        if (entry.stage == Stage.Lower)
                        {
                            entry.stage = Stage.Higher;
                        }
                        else if(entry.stage == Stage.Higher)
                        {
                            entry.stage = Stage.Approved;
                            // Database.Instance.Remove(entry);
                        }
                    }
                    else
                    {
                        int approve = entry.votes.Values.Count(e => e == Vote.Approve);
                        if (entry.stage == Stage.Lower && approve > CollegeData.CommitteeMembers / 2)
                        {
                            entry.stage = Stage.Higher;
                        }
                        else if (entry.stage == Stage.Higher)
                        {
                            entry.stage = Stage.Approved;
                            // Database.Instance.Remove(entry);
                        }
                    }
                    break;
                case ApplicationStatus.Reject:
                    // remove from available
                    _availableEntries.Remove(entry);
                    
                    int reject = entry.votes.Values.Count(e => e == Vote.Reject);
                    if(entry.studentType == StudentType.Undergraduate)
                    {
                        entry.stage = Stage.Rejected;
                        // Database.Instance.Remove(entry);
                    }
                    else
                    {
                        if (reject > CollegeData.CommitteeMembers / 2 || entry.stage == Stage.Higher)
                        {
                            entry.stage = Stage.Rejected;
                            // Database.Instance.Remove(entry);
                        }
                    }
                    break;
            }

            SAPS.Instance.UpdateApplicationList();
            SAPS.Instance.UpdateCharts();
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
