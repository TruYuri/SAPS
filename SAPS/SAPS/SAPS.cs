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
            UserType type = UserType.All;
            string name = textName.Text;

            // if successful
            User user = new User(textName.Text, name, type);
            this.tabSystems.Controls.Add(tabHome);
            this.tabSystems.SelectedTab = tabHome;
            this.tabSystems.Controls.Remove(tabLogin);
            this.tabSystems.Controls.Add(tabApplications);
            this.tabSystems.Controls.Add(tabEvents);
            this.tabSystems.Controls.Add(tabStatistics);

            // load database
            _baseSystem.Populate();

            // load applications and events to lists

            // calculate basic stats
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
    }
}
