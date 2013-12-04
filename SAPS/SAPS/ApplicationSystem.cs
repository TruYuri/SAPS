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
            ApplicationEditor editor = new ApplicationEditor(entry);
            Application.Run(new ApplicationEditor(entry));
            _applicationEditors.Remove(Thread.CurrentThread);
            SAPS.Instance.Invoke(new ApplicationDelegate(UpdateApplications), new object[] { editor.Entry, editor.Status });
        }

        private void UpdateApplications(DatabaseEntry entry, ApplicationStatus status)
        {
            switch(status)
            {
            }

            SAPS.Instance.UpdateApplicationList();
        }
    }
}
