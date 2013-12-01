using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum EventStatus { Remove, Modify, Create, Cancel };

namespace SAPS
{
    public partial class EventEditor : Form
    {
        private EventEntry _entry;
        private EventMode _eventMode; // used to perform different behavior
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

        public EventEditor(EventEntry entry, EventMode eventMode)
        {
            _entry = entry;
            _eventMode = eventMode;

            InitializeComponent();

            timeStart.Format = DateTimePickerFormat.Custom;
            timeStart.CustomFormat = "MM : dd : yyyy : hh : mm : ss";
            timeEnd.Format = DateTimePickerFormat.Custom;
            timeEnd.CustomFormat = "MM : dd : yyyy : hh : mm : ss"; 

            if(eventMode == EventMode.Modify)
            {
                buttonRemove.Visible = true;
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
            else if(_eventMode == EventMode.Create)
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