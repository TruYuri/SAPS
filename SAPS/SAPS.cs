using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace SAPS
{
    public partial class SAPS : Form
    {
        private static SAPS _instance;
        private BaseSystem _baseSystem;
        private Chart _printingChart;

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

            this.textEmail.Text = "admin@saps.edu";
            this.textPassword.Text = "admin";

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool log = _baseSystem.Login(this.textEmail.Text, this.textPassword.Text, labelName, labelNameError, labelPasswordError);

            if(log)
            {
                this.tabSystems.Controls.Add(tabHome);
                this.tabSystems.SelectedTab = tabHome;
                this.tabSystems.Controls.Remove(tabLogin);
                this.tabSystems.Controls.Add(tabApplications);
                this.tabSystems.Controls.Add(tabEvents);
                this.tabSystems.Controls.Add(tabStatistics);
                this.buttonResetApplications.Enabled = false;
                this.buttonResetEvents.Enabled = false;

                this.applicationList.DataSource = ApplicationSystem.Instance.Entries;
                this.eventList.DataSource = EventSystem.Instance.Events;

                this.comboCollegeType.DataSource = StatisticsSystem.ChartTypes;
                this.comboACTType.DataSource = new List<string>(StatisticsSystem.ChartTypes);
                this.comboCustomType.DataSource = new List<string>(StatisticsSystem.ChartTypes);
                this.comboCollegeColor.DataSource = Enum.GetValues(typeof(KnownColor));
                this.comboACTColor.DataSource = Enum.GetValues(typeof(KnownColor));
                this.comboCustomColor.DataSource = Enum.GetValues(typeof(KnownColor));
                List<string> statisticsSelectionList = typeof(DatabaseEntry).GetProperties().Select(p => p.Name).ToList();
                statisticsSelectionList.Remove("Name");
                statisticsSelectionList.Remove("Major");
                statisticsSelectionList.Remove("Date");
                statisticsSelectionList.Remove("Zip");
                statisticsSelectionList.Remove("StreetAddress");
                statisticsSelectionList.Remove("Comments");
                statisticsSelectionList.Remove("SocialSecurity");
                statisticsSelectionList.Remove("Phone");
                statisticsSelectionList.Remove("Date");
                statisticsSelectionList.Remove("Date");
                this.comboXAxis.DataSource = statisticsSelectionList;
                this.comboYAxis.DataSource = new List<String>(statisticsSelectionList);
                this.saveStatisticDialog.Filter = "Bitmap Image (.bmp)|*.bmp|"
                                             + "Windows Enhanced Metafile Image (.emf)|*.emf|"
                                             + "Windows Enhanced Metafile Dual Image (.emf-dual)|*.emf-dual|"
                                             + "Windows Enhanced Metafile Plus Image (.emf+)|*.emf+|"
                                             + "Gif Image (.gif)|*.gif|"
                                             + "JPEG Image (.jpeg)|*.jpeg|"
                                             + "Portable Network Graphic (.png)|*.png|"
                                             + "Tiff Image (.tiff)|*.tiff";

                this.UpdateApplicationList();
                this.UpdateEventList();
                this.UpdateCharts();
            }
            else
            {
                // display login error
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // fake download bar
            buttonUpdate.Visible = false;
            progressBarFake.Visible = true;
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(10);
                progressBarFake.PerformStep();
            }
            MessageBox.Show("Database Updated!");
            progressBarFake.Visible = false;
            buttonUpdate.Visible = true;
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

        private void buttonSearchApplications_Click(object sender, EventArgs e)
        {
            BindingList<DatabaseEntry> list = ApplicationSystem.Instance.Search();
            this.applicationList.DataSource = list;

            if (!list.Equals(ApplicationSystem.Instance.Entries))
            {
                buttonResetApplications.Enabled = true;
            }
        }

        private void buttonResetApplications_Click(object sender, EventArgs e)
        {
            this.buttonResetApplications.Enabled = false;
            this.applicationList.DataSource = ApplicationSystem.Instance.Entries;
            UpdateEventList();
        }

        public void UpdateEventList()
        {
            BindingList<EventEntry> source = (BindingList<EventEntry>)(this.eventList.DataSource);
            this.eventList.DataSource = typeof(BindingList<EventEntry>);
            this.eventList.DataSource = source;

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
                this.buttonModifyEvent.Enabled = true;
                this.buttonPrintEvent.Enabled = true;
            }
            else
            {
                this.buttonModifyEvent.Enabled = false;
                this.buttonPrintEvent.Enabled = false;
            }
        }

        private void buttonPrintEvent_Click(object sender, EventArgs e)
        {
            EventSystem.Instance.PrintEvent(this.eventList.SelectedRows[0].DataBoundItem as EventEntry);
        }

        private void buttonSearchEvents_Click(object sender, EventArgs e)
        {
            BindingList<EventEntry> list = EventSystem.Instance.Search();
            this.eventList.DataSource = list;
            UpdateEventList();

            if (!list.Equals(EventSystem.Instance.Events))
            {
                this.buttonResetEvents.Enabled = true;
            }
        }

        private void buttonResetEvents_Click(object sender, EventArgs e)
        {
            this.buttonResetEvents.Enabled = false;
            this.eventList.DataSource = EventSystem.Instance.Events;
            UpdateEventList();
        }

        public void UpdateCharts()
        {
            StatisticsSystem.Instance.GenerateDefaultCharts(this.chartCollege, this.chartACT, this.chartCustom);
            StatisticsSystem.Instance.UpdateCustomChart(this.chartCustom, this.comboXAxis.SelectedItem.ToString(), this.comboYAxis.SelectedItem.ToString());
        }

        private void comboCollegeChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.ChangeChartType(this.chartCollege, this.comboCollegeType.SelectedItem.ToString());
        }

        private void comboCollegeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.ChangeChartColor(this.chartCollege, this.comboCollegeColor.SelectedItem.ToString());
        }

        private void buttonSaveCollege_Click(object sender, EventArgs e)
        {
            SaveChart(chartCollege);
        }

        private void buttonPrintCollege_Click(object sender, EventArgs e)
        {
            PrintChart(chartCollege);
        }

        private void comboACTType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.ChangeChartType(this.chartACT, this.comboACTType.SelectedItem.ToString());
        }

        private void comboACTColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.ChangeChartColor(this.chartACT, this.comboACTColor.SelectedItem.ToString());
        }

        private void buttonSaveACT_Click(object sender, EventArgs e)
        {
            SaveChart(chartACT);
        }

        private void buttonPrintACT_Click(object sender, EventArgs e)
        {
            PrintChart(chartACT);
        }

        private void comboCustomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.ChangeChartType(this.chartCustom, this.comboCustomType.SelectedItem.ToString());
        }

        private void comboCustomColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.ChangeChartColor(this.chartCustom, this.comboCustomColor.SelectedItem.ToString());
        }

        private void comboXAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.UpdateCustomChart(this.chartCustom, this.comboXAxis.SelectedItem.ToString(), this.comboYAxis.SelectedItem.ToString());
        }

        private void comboYAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticsSystem.Instance.UpdateCustomChart(this.chartCustom, this.comboXAxis.SelectedItem.ToString(), this.comboYAxis.SelectedItem.ToString());
        }

        private void buttonSaveCustom_Click(object sender, EventArgs e)
        {
            SaveChart(chartCustom);
        }

        private void buttonPrintCustom_Click(object sender, EventArgs e)
        {
            PrintChart(chartCustom);
        }

        private void SaveChart(Chart chart)
        {
            if(saveStatisticDialog.ShowDialog() == DialogResult.OK)
            {
                StatisticsSystem.Instance.SaveChart(chart, saveStatisticDialog.FileName, Path.GetExtension(saveStatisticDialog.FileName));
            }
        }

        private void PrintChart(Chart chart)
        {
            printStatisticDialog = new PrintDialog();
            printStatisticDialog.Document = printStatistic;
            _printingChart = chart;

            if (printStatisticDialog.ShowDialog() == DialogResult.OK)
            {
                printStatistic.Print();
            }
        }

        private void printStatistic_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            _printingChart.Printing.PrintPaint(e.Graphics, _printingChart.ClientRectangle);
        }
    }
}