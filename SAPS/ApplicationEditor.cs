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
        private FormStorage<ApplicationStatus> _storage;

        public DatabaseEntry Entry
        {
            get
            {
                return _entry;
            }
        }

        public ApplicationEditor(DatabaseEntry entry, FormStorage<ApplicationStatus> storage)
        {
            _entry = entry;
            _storage = storage;

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
            this.textSocial.Text = _entry.socialSecurity;
            this.textAddress.Text = _entry.streetAddress;
            this.textCity.Text = _entry.city;
            this.textState.Text = _entry.state;
            this.textZip.Text = _entry.zip;
            this.textGPA.Text = _entry.GPA.ToString();
            this.textScore.Text = _entry.actSAT.ToString();
            this.textRank.Text = _entry.classRank.ToString();
            this.listMajors.DataSource = _entry.majors;
            this.listMinors.DataSource = _entry.minors;
            this.listVotes.DataSource = new BindingSource(_entry.votes, null);
            this.textDescriptionComments.Text = _entry.comments;
        }

        private void textGPA_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                float.Parse(this.textGPA.Text);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void textScore_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int.Parse(this.textScore.Text);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void buttonAddMajor_Click(object sender, EventArgs e)
        {
            // popup
        }

        private void buttonRemoveMajor_Click(object sender, EventArgs e)
        {
            if (listMajors.SelectedValue != null)
            {
                _entry.majors.Remove(listMajors.SelectedItem.ToString());
            }
        }   

        private void buttonAddMinor_Click(object sender, EventArgs e)
        {
            // popup
        }

        private void buttonRemoveMinor_Click(object sender, EventArgs e)
        {
            if (listMinors.SelectedValue != null)
            {
                _entry.minors.Remove(listMinors.SelectedItem.ToString());
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Flag application for removal?", "Remove Application", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                _storage.Status = ApplicationStatus.Remove;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _storage.Status = ApplicationStatus.Cancel;
            this.Close();
        }

        // Gender gender;
        // Enum.TryParse<Gender>(comboBoxGender.SelectedValue.ToString(), out gender);  // for later
    }
}
