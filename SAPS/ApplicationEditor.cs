using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
            this.comboVote.DataSource = Enum.GetValues(typeof(Vote));
            this.comboVote.SelectedIndex = this.comboVote.FindString(Vote.Undecided.ToString());

            this.timeSubmission.Value = _entry.submissionDate;
            this.textFirstName.Text = _entry.firstName;
            this.textMiddleName.Text = _entry.middleName;
            this.textLastName.Text = _entry.lastName;
            this.comboBoxGender.SelectedIndex = this.comboBoxGender.FindString(_entry.gender.ToString());
            this.timeDOB.Value = _entry.dateOfBirth;
            this.textGPA.Text = _entry.GPA.ToString();
            this.listMajors.DataSource = _entry.majors;
            this.listMinors.DataSource = _entry.minors;
            this.listVotes.DataSource = new BindingSource(_entry.votes, null);
            this.textDescriptionComments.Text = _entry.comments;
        }

        // Gender gender;
        // Enum.TryParse<Gender>(comboBoxGender.SelectedValue.ToString(), out gender);  // for later
    }
}
