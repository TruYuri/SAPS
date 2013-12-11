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
        private BindingList<string> _searchList;
        private FormStorage<bool> _storage;

        public Search(Dictionary<string, string> searchTerms, System.Type type, FormStorage<bool> storage)
        {
            _searchTerms = searchTerms;
            _storage = storage;
            _searchList = new BindingList<string>();

            InitializeComponent();

            List<string> list = type.GetProperties().Select(p => p.Name).ToList();

            this.comboCriteria.DataSource = type.GetProperties().Select(p => p.Name).ToList();
            this.listSearchTerms.DataSource = _searchList;
            this.buttonRemove.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!_searchTerms.Keys.ToList().Contains(textCriteria.Text))
            {
                _searchTerms.Add(textCriteria.Text, comboCriteria.SelectedItem.ToString());
                _searchList.Add("[" + textCriteria.Text + ", " + comboCriteria.SelectedItem.ToString() + "]");

                if (_searchList.Count == 1)
                {
                    listSearchTerms.SelectedIndex = 0;
                    buttonRemove.Enabled = true;
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string key = listSearchTerms.SelectedItem.ToString();
            key = key.Remove(0, 1);
            int comma = key.IndexOf(",");
            key = key.Remove(comma, key.Length - comma);
            _searchTerms.Remove(key);
            
            _searchList.Remove(listSearchTerms.SelectedItem.ToString());
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
