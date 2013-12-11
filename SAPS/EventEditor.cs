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
            _eventMode = storage.Value;
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
                textEventName.Text = _entry.EventName;
                timeStart.Value = _entry.EventActivationTime;
                timeEnd.Value = _entry.EventDeactivationTime;
                textDescription.Text = _entry.Description;
            }

            if (_storage.Value == EventStatus.Print)
            {
                this.buttonAccept.Visible = false;
                this.buttonCancel.Visible = false;
                this.buttonRemove.Visible = false;
                this.Shown += new EventHandler(Print);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if(timeStart.Value > timeEnd.Value)
            {
                MessageBox.Show("Error! End Time before start time.", "Error", MessageBoxButtons.OK);
                return;
            }
            else if(_eventMode == EventStatus.Create)
            {
                _storage.Value = EventStatus.Create;
            }
            else
            {
                _storage.Value = EventStatus.Modify;
            }

            _entry.EventName = textEventName.Text;
            _entry.EventActivationTime = timeStart.Value;
            _entry.EventDeactivationTime = timeEnd.Value;
            _entry.Description = textDescription.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _storage.Value = EventStatus.Cancel;
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Remove event? This affects all users.", "Remove Event", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                _storage.Value = EventStatus.Remove;
                this.Close();
            }
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

            printEventDialog = new PrintDialog();
            printEventDialog.Document = printEvent;

            if (printEventDialog.ShowDialog() == DialogResult.OK)
            {
                printEvent.Print();
            }

            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}