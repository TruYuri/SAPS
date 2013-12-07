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
        private BindingList<string> _tempMajors;
        private BindingList<string> _tempMinors;

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
            _tempMajors = new BindingList<string>();
            _tempMinors = new BindingList<string>();

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
            this.textPhone.Text = _entry.phone;
            this.textGPA.Text = _entry.GPA.ToString();
            this.textScore.Text = _entry.actSAT.ToString();
            this.textRank.Text = _entry.classRank.ToString();
            foreach (string major in _entry.majors)
            {
                _tempMajors.Add(major);
            }
            this.listMajors.DataSource = _tempMajors;
            foreach (string minor in _entry.minors)
            {
                _tempMinors.Add(minor);
            }
            this.listMinors.DataSource = _tempMinors;
            this.listVotes.DataSource = new BindingSource(_entry.votes, null);
            this.textDescriptionComments.Text = _entry.comments;

            if (_storage.Status == ApplicationStatus.Print)
            {
                buttonAddMajor.Visible = false;
                buttonRemoveMajor.Visible = false;
                buttonAddMinor.Visible = false;
                buttonRemoveMinor.Visible = false;
                buttonCancel.Visible = false;
                buttonRemove.Visible = false;
                buttonSubmit.Visible = false;
                comboVote.Visible = false;
                this.Shown += new EventHandler(Print);
            }
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
            _tempMajors.Remove(listMajors.SelectedItem.ToString());
        }

        private void listMajors_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listMajors.SelectedValue == null)
            {
                buttonRemoveMajor.Enabled = false;
            }
            else
            {
                buttonRemoveMajor.Enabled = false;
            }
        }

        private void listMinors_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listMinors.SelectedValue == null)
            {
                buttonRemoveMinor.Enabled = false;
            }
            else
            {
                buttonRemoveMinor.Enabled = false;
            }
        }

        private void buttonAddMinor_Click(object sender, EventArgs e)
        {
            // popup
        }

        private void buttonRemoveMinor_Click(object sender, EventArgs e)
        {
            _tempMinors.Remove(listMinors.SelectedItem.ToString());
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Vote vote;
            Enum.TryParse<Vote>(comboVote.SelectedValue.ToString(), out vote);
            DialogResult result = DialogResult.OK;
            _storage.Status = ApplicationStatus.Modify;

            if (listMajors.Items.Count == 0)
            {
                MessageBox.Show("Error! Must have a major.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (vote == Vote.Approve)
            {
                result = MessageBox.Show("Confirm application approval.", "Approve Application", MessageBoxButtons.OKCancel);
            }
            else if (vote == Vote.Reject)
            {
                result = MessageBox.Show("Confirm application rejection.", "Reject Application", MessageBoxButtons.OKCancel);
            }

            if (result == DialogResult.OK)
            {
                if(vote == Vote.Approve)
                {
                    _storage.Status = ApplicationStatus.Approve;
                    _entry.votes.Add(User.Instance.Name, vote);
                }
                if (vote == Vote.Reject)
                {
                    _storage.Status = ApplicationStatus.Reject;
                    _entry.votes.Add(User.Instance.Name, vote);
                }

                Gender gender;
                Enum.TryParse<Gender>(comboBoxGender.SelectedValue.ToString(), out gender);
                _entry.gender = gender;
                _entry.firstName = this.textFirstName.Text;
                _entry.middleName = this.textMiddleName.Text;
                _entry.lastName = this.textLastName.Text;
                _entry.dateOfBirth = this.timeDOB.Value;
                _entry.socialSecurity = this.textSocial.Text;
                _entry.streetAddress = this.textAddress.Text;
                _entry.city = this.textCity.Text;
                _entry.state = this.textState.Text;
                _entry.zip = this.textZip.Text;
                _entry.phone = this.textPhone.Text;
                _entry.GPA = float.Parse(this.textGPA.Text);
                _entry.actSAT = int.Parse(this.textScore.Text);
                _entry.classRank = int.Parse(this.textRank.Text.Remove(2));
                _entry.majors = _tempMajors;
                _entry.minors = _tempMinors;
                _entry.comments = this.textDescriptionComments.Text;

                this.Close();
            } 
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

        /* microsoft form printing */
        private Bitmap memoryImage;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private void Print(object sender, EventArgs e)
        {
            Application.DoEvents();

            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);

            printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
