using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taghzia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StatrForm));
            t.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            t.Abort();
        }
        public void StatrForm()
        {
            Application.Run(new splashscreen());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من الإغلاق؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              System.Windows.Forms.Application.ExitThread();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addnew adn = new addnew();
            adn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showaal sho = new showaal();
            sho.ShowDialog();
        }
    }
}
