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
    public partial class Search : Form
    {
        private Dictionary<string, string> _searchTerms = new Dictionary<string, string>();
        private FormStorage<bool> _storage;

        public Search(Dictionary<string, string> searchTerms, System.Type type, FormStorage<bool> storage)
        {
            _searchTerms = searchTerms;
            _storage = storage;

            InitializeComponent();

            List<string> list = type.GetProperties().Select(p => p.Name).ToList();
            if(type == typeof(EventEntry))
            {
                list.Remove("EventStart");
                list.Remove("EventEnd");
                list.Remove("Status");
            }
            this.comboCriteria.DataSource = type.GetProperties().Select(p => p.Name).ToList();
            BindingSource source = new BindingSource(_searchTerms, null);
            source.RemoveAt(0);
            this.listSearchTerms.DataSource = source;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!_searchTerms.ContainsKey(comboCriteria.SelectedText))
            {
                _searchTerms.Add(comboCriteria.SelectedItem.ToString(), textCriteria.Text);
                this.listSearchTerms.DataSource = new BindingSource(_searchTerms, null);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            _searchTerms.Remove(listSearchTerms.SelectedItem.ToString());
            this.listSearchTerms.DataSource = new BindingSource(_searchTerms, null);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _storage.Value = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _storage.Value = false;
            this.Close();
        }

        private void listSearchTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSearchTerms.SelectedItem != null)
            {
                buttonRemove.Enabled = true;
            }
            else
            {
                buttonRemove.Enabled = false;
            }
        }
    }
}
