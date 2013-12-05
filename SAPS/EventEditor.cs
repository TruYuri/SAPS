﻿using System;
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
    public partial class EventEditor : Form
    {
        private EventEntry _entry;
        private EventStatus _eventMode; // used to perform different behavior
        private EventStatus _status;

        public EventStatus Status
        {
            get
            {
                return _status;
            }
        }

        public EventEntry Entry
        {
            get
            {
                return _entry;
            }
        }

        public EventEditor(EventEntry entry, EventStatus eventMode)
        {
            _entry = entry;
            _eventMode = eventMode;

            InitializeComponent();

            if(eventMode == EventStatus.Create)
            {
                this.Text += " - Create Event";
            }
            else
            {
                this.Text += " - Modify Event";

                buttonRemove.Enabled = true;
                textEventName.Text = _entry.eventName;
                timeStart.Value = _entry.eventActivationTime;
                timeEnd.Value = _entry.eventDeactivationTime;
                textDescription.Text = _entry.description;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if(timeStart.Value > timeEnd.Value)
            {
                MessageBox.Show("Error! End Time before start time.");
                return;
            }
            else if(_eventMode == EventStatus.Create)
            {
                _status = EventStatus.Create;
            }
            else
            {
                _status = EventStatus.Modify;
            }

            _entry.eventName = textEventName.Text;
            _entry.eventActivationTime = timeStart.Value;
            _entry.eventDeactivationTime = timeEnd.Value;
            _entry.description = textDescription.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _status = EventStatus.Cancel;
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            _status = EventStatus.Remove;
            this.Close();
        }
    }
}