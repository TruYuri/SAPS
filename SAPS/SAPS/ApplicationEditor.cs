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
    public partial class ApplicationEditor : Form
    {
        private DatabaseEntry _entry;

        public ApplicationEditor(DatabaseEntry entry)
        {
            _entry = entry;

            InitializeComponent();
        }
    }
}