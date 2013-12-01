﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAPS
{
    public partial class SAPS : Form
    {
        private static SAPS _instance;
        private BaseSystem _baseSystem;

        public delegate void EventDelegate(EventStatus status, EventEntry entry);

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
                    column.Width = this.applicationList.Width / 3;
                }


                UpdateEventList(EventStatus.Cancel, null);
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

        private void applicationList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplicationSystem.Instance.StartApplicationThread(this.applicationList.SelectedRows[0].DataBoundItem as DatabaseEntry);
        }

        private void buttonModifyApplication_Click(object sender, EventArgs e)
        {
            ApplicationSystem.Instance.StartApplicationThread(this.applicationList.SelectedRows[0].DataBoundItem as DatabaseEntry);
        }

        private void applicationList_SelectionChanged(object sender, EventArgs e)
        {
            if(applicationList.SelectedRows.Count > 0 && applicationList.Rows.Contains(applicationList.SelectedRows[0]))
            {
                this.buttonModifyApplication.Enabled = true;           
            }
            else
            {
                this.buttonModifyApplication.Enabled = false;
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

        public void UpdateEventList(EventStatus status, EventEntry entry)
        {
            switch(status)
            {
                case EventStatus.Remove:
                    EventSystem.Instance.Events.Remove(entry);
                    break;
                case EventStatus.Create:
                    EventSystem.Instance.Events.Add(entry);
                    break;
            }

            this.eventList.DataSource = typeof(BindingList<EventEntry>);
            this.eventList.DataSource = EventSystem.Instance.Events;

            foreach(DataGridViewColumn column in this.eventList.Columns)
            {
                column.Width = this.applicationList.Width / 3;
            }
        }
    }
}