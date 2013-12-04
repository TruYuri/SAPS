using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum ApplicationStatus { }
namespace SAPS
{
    public partial class ApplicationEditor : Form
    {
        private DatabaseEntry _entry;
        private ApplicationStatus _status;

        public DatabaseEntry Entry
        {
            get
            {
                return _entry;
            }
        }

        public ApplicationStatus Status
        {
            get
            {
                return _status;
            }
        }

        public ApplicationEditor(DatabaseEntry entry)
        {
            _entry = entry;

            InitializeComponent();
        }
    }
}
