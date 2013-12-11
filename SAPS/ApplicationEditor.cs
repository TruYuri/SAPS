using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.timeSubmission.Value = _entry.SubmissionDate;
            this.textFirstName.Text = _entry.FirstName;
            this.textMiddleName.Text = _entry.MiddleName;
            this.textLastName.Text = _entry.LastName;
            this.comboBoxGender.SelectedIndex = this.comboBoxGender.FindString(_entry.Gender.ToString());
            this.timeDOB.Value = _entry.DateOfBirth;
            this.textSocial.Text = _entry.SocialSecurity;
            this.textAddress.Text = _entry.StreetAddress;
            this.textCity.Text = _entry.City;
            this.textState.Text = _entry.State;
            this.textZip.Text = _entry.Zip;
            this.textPhone.Text = _entry.Phone;
            this.textGPA.Text = _entry.GPA.ToString();
            this.textScore.Text = _entry.ACTSAT.ToString();
            this.textRank.Text = _entry.ClassRank.ToString();
            foreach (string major in _entry.Majors)
            {
                _tempMajors.Add(major);
            }
            this.listMajors.DataSource = _tempMajors;
            foreach (string minor in _entry.Minors)
            {
                _tempMinors.Add(minor);
            }
            this.listMinors.DataSource = _tempMinors;
            this.listVotes.DataSource = new BindingSource(_entry.votes, null);
            this.textDescriptionComments.Text = _entry.Comments;

            if (_storage.Value == ApplicationStatus.Print)
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
            FormStorage<string> storage = new FormStorage<string>(string.Empty);
            StudySelector selector = new StudySelector(storage);
            selector.ShowDialog();

            if (storage.Value != string.Empty)
            {
                _tempMajors.Add(storage.Value);
            }
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
            FormStorage<string> storage = new FormStorage<string>(string.Empty);
            StudySelector selector = new StudySelector(storage);
            selector.ShowDialog();

            if (storage.Value != string.Empty)
            {
                _tempMinors.Add(storage.Value);
            }
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
            _storage.Value = ApplicationStatus.Modify;

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
                    _storage.Value = ApplicationStatus.Approve;
                }
                if (vote == Vote.Reject)
                {
                    _storage.Value = ApplicationStatus.Reject;
                }

                Gender gender;
                Enum.TryParse<Gender>(comboBoxGender.SelectedValue.ToString(), out gender);
                _entry.Gender = gender;
                _entry.FirstName = this.textFirstName.Text;
                _entry.MiddleName = this.textMiddleName.Text;
                _entry.LastName = this.textLastName.Text;
                _entry.DateOfBirth = this.timeDOB.Value;
                _entry.SocialSecurity = this.textSocial.Text;
                _entry.StreetAddress = this.textAddress.Text;
                _entry.City = this.textCity.Text;
                _entry.State = this.textState.Text;
                _entry.Zip = this.textZip.Text;
                _entry.Phone = this.textPhone.Text;
                _entry.GPA = float.Parse(this.textGPA.Text);
                _entry.ACTSAT = int.Parse(this.textScore.Text);
                _entry.ClassRank = int.Parse(this.textRank.Text.Remove(2));
                _entry.Majors = _tempMajors;
                _entry.Minors = _tempMinors;
                _entry.Comments = this.textDescriptionComments.Text;

                this.Close();
            } 
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Flag application for removal?", "Remove Application", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                _storage.Value = ApplicationStatus.Remove;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _storage.Value = ApplicationStatus.Cancel;
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

            printApplicationDialog = new PrintDialog();
            printApplicationDialog.Document = printApplication;

            if (printApplicationDialog.ShowDialog() == DialogResult.OK)
            {
                printApplication.Print();
            }

            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
