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
    public partial class EventEditor : Form
    {
        private EventEntry _entry;
        private EventStatus _eventMode; // used to perform different behavior
        private FormStorage<EventStatus> _storage;

        public EventEntry Entry
        {
            get
            {
                return _entry;
            }
        }

        public EventEditor(EventEntry entry, FormStorage<EventStatus> storage)
        {
            _entry = entry;
            _eventMode = storage.Status;
            _storage = storage;

            InitializeComponent();

            if(_eventMode == EventStatus.Create)
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
                MessageBox.Show("Error! End Time before start time.", "Time Error", MessageBoxButtons.OK);
                return;
            }
            else if(_eventMode == EventStatus.Create)
            {
                _storage.Status = EventStatus.Create;
            }
            else
            {
                _storage.Status = EventStatus.Modify;
            }

            _entry.eventName = textEventName.Text;
            _entry.eventActivationTime = timeStart.Value;
            _entry.eventDeactivationTime = timeEnd.Value;
            _entry.description = textDescription.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _storage.Status = EventStatus.Cancel;
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove event? This affects all users.", "Remove Event", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                _storage.Status = EventStatus.Remove;
                this.Close();
            }
        }
    }
}