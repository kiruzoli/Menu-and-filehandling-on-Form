﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formelement
{
    public partial class Search : Form
    {
        public string szoveg;
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            szoveg = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
