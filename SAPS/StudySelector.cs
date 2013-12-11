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
    public partial class StudySelector : Form
    {
        private FormStorage<string> _storage;

        public StudySelector(FormStorage<string> s)
        {
            _storage = s;

            InitializeComponent();

            this.listMajors.DataSource = CollegeData.Majors.Keys.ToList();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            _storage.Value = listMajors.SelectedItem.ToString();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
