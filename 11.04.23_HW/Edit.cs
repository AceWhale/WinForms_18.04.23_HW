﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._04._23_HW
{
    public partial class Edit : Form
    {
        public Form1 mainform;
        public Edit()
        {
            InitializeComponent();
        }
        public void Start()
        {
            textBox1.Text = mainform.a76_p;
            textBox2.Text = mainform.a80_p;
            textBox3.Text = mainform.a92_p;
            textBox4.Text = mainform.a98_p;
            textBox5.Text = mainform.hotdog;
            textBox6.Text = mainform.humberger;
            textBox7.Text = mainform.potato;
            textBox8.Text = mainform.cocacola;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            mainform.a76_p = textBox1.Text;
            mainform.a80_p = textBox2.Text;
            mainform.a92_p = textBox3.Text;
            mainform.a98_p = textBox4.Text;
            mainform.hotdog = textBox5.Text; ;
            mainform.humberger = textBox6.Text; ;
            mainform.potato = textBox7.Text; ;
            mainform.cocacola = textBox8.Text; ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
