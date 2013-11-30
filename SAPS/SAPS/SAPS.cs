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
    public partial class winSAPS : Form
    {
        private BaseSystem _baseSystem;

        public winSAPS()
        {
            _baseSystem = new BaseSystem();

            InitializeComponent();

            this.tabSystems.SelectedTab = tabLogin;
            this.tabSystems.Controls.Remove(tabHome);
            this.tabSystems.Controls.Remove(tabApplications);
            this.tabSystems.Controls.Remove(tabEvents);
            this.tabSystems.Controls.Remove(tabStatistics);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check database for user
            // send email
            // send password

            // retrieve name
            // retrieve user type

            // if successful
            User user = new User(textEmail.Text, textEmail.Text, UserType.All);
            this.tabSystems.Controls.Add(tabHome);
            this.tabSystems.SelectedTab = tabHome;
            this.tabSystems.Controls.Remove(tabLogin);
            this.tabSystems.Controls.Add(tabApplications);
            this.tabSystems.Controls.Add(tabEvents);
            this.tabSystems.Controls.Add(tabStatistics);

            // load database
            _baseSystem.Populate();

            this.textName.Text = User.Instance.Name;
            this.applicationList.DataSource = ApplicationSystem.Instance.Entries;

            foreach (DataGridViewColumn column in this.applicationList.Columns)
            {
                column.Width = this.applicationList.Width / 3;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.tabSystems.Controls.Add(tabLogin);
            this.tabSystems.SelectedTab = tabLogin;
            this.tabSystems.Controls.Remove(tabHome);       
            this.tabSystems.Controls.Remove(tabApplications);
            this.tabSystems.Controls.Remove(tabEvents);
            this.tabSystems.Controls.Remove(tabStatistics);

            // save database
            _baseSystem.Serialize();

            // Delete user
            User.Instance.Destroy();
        }

        private void applicationList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void applicationList_SelectionChanged(object sender, EventArgs e)
        {
            if(applicationList.SelectedRows.Count > 0 && applicationList.Rows.Contains(applicationList.SelectedRows[0]))
            {
                this.buttonEdit.Enabled = true;           
            }
            else
            {
                this.buttonEdit.Enabled = false;
            }
        }
    }
}
