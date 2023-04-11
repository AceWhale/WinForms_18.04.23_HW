using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _11._04._23_HW
{
    public partial class Form1 : Form
    {
        Patrol patrol;
        Cafe cafe;
        Edit edit;
        public string a76;
        public string a76_p;
        public string a80;
        public string a80_p;
        public string a92;
        public string a92_p;
        public string a95;
        public string a95_p;
        public string a98;
        public string a98_p;
        public string hotdog;
        public string humberger;
        public string cocacola;
        public string potato;
        public Form1()
        {
            InitializeComponent();
            a76 = "А-76";
            a76_p = "33,23";
            a80 = "А-80";
            a80_p = "35,55";
            a92 = "А-92";
            a92_p = "46,12";
            a95 = "А-95";
            a95_p = "46,96";
            a98 = "А-98";
            a98_p = "49,60";
            hotdog = "3213";
            humberger = "120";
            cocacola = "40";
            potato = "55";
            string[] items = { a76, a80, a92, a95, a98 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (patrol == null)
            {
                patrol = new Patrol();
                patrol.mainform = this;
            }
            string[] items = { a76, a80, a92, a95, a98 };
            patrol.Items =items;
            patrol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cafe == null)
            {
                cafe = new Cafe();
                cafe.mainform = this;
            }
            cafe.Start();
            cafe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (edit == null)
            {
                edit = new Edit();
                edit.mainform = this;
            }
            edit.Start();
            edit.Show();
        }
    }
}
