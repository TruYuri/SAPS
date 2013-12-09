using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SAPS
{
    public partial class SAPS : Form
    {
        #region Core
        private static SAPS _instance;
        private BaseSystem _baseSystem;

        public static SAPS Instance
        {
            get
            {
                return _instance;
            }
        }

        public SAPS()
        {
            _instance = this;
            _baseSystem = new BaseSystem();

            InitializeComponent();

            this.tabSystems.SelectedTab = tabLogin;
            this.tabSystems.Controls.Remove(tabHome);
            this.tabSystems.Controls.Remove(tabApplications);
            this.tabSystems.Controls.Remove(tabEvents);
            this.tabSystems.Controls.Remove(tabStatistics);
        }

        private void SAPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationSystem.Instance.CloseEditors();
            EventSystem.Instance.CloseEditors();
        }
        #endregion

        #region Log In/Home
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool log = _baseSystem.Login(this.textEmail.Text, this.textPassword.Text);

            if(log)
            {
                this.tabSystems.Controls.Add(tabHome);
                this.tabSystems.SelectedTab = tabHome;
                this.tabSystems.Controls.Remove(tabLogin);
                this.tabSystems.Controls.Add(tabApplications);
                this.tabSystems.Controls.Add(tabEvents);
                this.tabSystems.Controls.Add(tabStatistics);

                this.applicationList.DataSource = ApplicationSystem.Instance.Entries;

                foreach(DataGridViewColumn column in this.applicationList.Columns)
                {
                    column.Width = this.applicationList.Width / applicationList.Columns.Count;
                }

                this.comboCollegeType.DataSource = Enum.GetValues(typeof(SeriesChartType));
                // this.comboCollegeType.SelectedIndex = this.comboCollegeType.FindString(SeriesChartType.Bar.ToString());
                this.comboACTType.DataSource = Enum.GetValues(typeof(SeriesChartType));
                // this.comboACTType.SelectedIndex = this.comboACTType.FindString(SeriesChartType.Column.ToString());

                this.UpdateApplicationList();
                this.UpdateEventList();
                this.UpdateCharts();
            }
            else
            {
                // display login error
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

            _baseSystem.Logout();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Applications
        public void UpdateApplicationList()
        {
            this.applicationList.DataSource = typeof(BindingList<DatabaseEntry>);
            this.applicationList.DataSource = ApplicationSystem.Instance.Entries;

            foreach (DataGridViewColumn column in this.applicationList.Columns)
            {
                column.Width = this.applicationList.Width / this.applicationList.Columns.Count;
            }
        }

        private void applicationList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplicationSystem.Instance.ModifyApplication(this.applicationList.SelectedRows[0].DataBoundItem as DatabaseEntry);
        }

        private void buttonModifyApplication_Click(object sender, EventArgs e)
        {
            ApplicationSystem.Instance.ModifyApplication(this.applicationList.SelectedRows[0].DataBoundItem as DatabaseEntry);
        }

        private void applicationList_SelectionChanged(object sender, EventArgs e)
        {
            if(applicationList.SelectedRows.Count > 0 && applicationList.SelectedRows[0] != null)
            {
                buttonModifyApplication.Enabled = true;
                buttonPrintApplication.Enabled = true;
            }
            else
            {
                buttonModifyApplication.Enabled = false;
                buttonPrintApplication.Enabled = false;
            }
        }

        private void buttonPrintApplication_Click(object sender, EventArgs e)
        {
            ApplicationSystem.Instance.PrintApplication(this.applicationList.SelectedRows[0].DataBoundItem as DatabaseEntry);
        }
        #endregion

        #region Events
        public void UpdateEventList()
        {
            this.eventList.DataSource = typeof(BindingList<EventEntry>);
            this.eventList.DataSource = EventSystem.Instance.Events;

            foreach (DataGridViewColumn column in this.eventList.Columns)
            {
                column.Width = this.eventList.Width / this.eventList.Columns.Count;
            }
        }

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            EventSystem.Instance.CreateEvent();
        }

        private void eventList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EventSystem.Instance.ModifyEvent(this.eventList.SelectedRows[0].DataBoundItem as EventEntry);
        }

        private void buttonModifyEvent_Click(object sender, EventArgs e)
        {
            EventSystem.Instance.ModifyEvent(this.eventList.SelectedRows[0].DataBoundItem as EventEntry);
        }

        private void eventList_SelectionChanged(object sender, EventArgs e)
        {
            if(eventList.SelectedRows.Count > 0 && eventList.SelectedRows[0] != null)
            {
                buttonModifyEvent.Enabled = true;
                buttonPrintEvent.Enabled = true;
            }
            else
            {
                buttonModifyEvent.Enabled = false;
                buttonPrintEvent.Enabled = false;
            }
        }

        private void buttonPrintEvent_Click(object sender, EventArgs e)
        {
            EventSystem.Instance.PrintEvent(this.eventList.SelectedRows[0].DataBoundItem as EventEntry);
        }
        #endregion

        #region Statistics
        public void UpdateCharts()
        {
            StatisticsSystem.Instance.GenerateDefaultCharts(this.chartCollege, this.chartACT);
        }

        private void comboCollegeChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change chart type
            StatisticsSystem.Instance.ChangeChartType(this.chartCollege, this.comboCollegeType.SelectedItem.ToString());
        }

        private void comboACTType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.ChangeChartType(this.chartACT, this.comboACTType.SelectedItem.ToString());
        }

        private void buttonPrintACT_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrintCollege_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrintCustom_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveCollege_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveACT_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveCustom_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}