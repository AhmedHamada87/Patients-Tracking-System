using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Tulpep.NotificationWindow;

namespace taghzia
{
    public partial class editvisitagad : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public editvisitagad()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= tag.db");
            var opa = Application.OpenForms["visitafromgad"] as visitafromgad;
            label3.Text = opa.label6.Text;
            label10.Text = opa.label7.Text;
            loadet();
            loadvisi();
        }
        private void loadvisi()
        {
            con.Open();
            qu = "SELECT * FROM chan WHERE vistid=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label10.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    string s = read.GetString(1);
                    DateTime dt =
                        DateTime.ParseExact(s, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                    dateTimePicker1.Value = dt;
                    richTextBox1.Text = read.GetString(3);
                    textBox2.Text = read.GetString(4);
                    textBox3.Text = read.GetString(5);
                    textBox4.Text = read.GetString(6);
                    textBox5.Text = read.GetString(7);
                }

            }
            con.Close();
        }

        private void loadet()
        {
            con.Open();
            qu = "SELECT * FROM sick WHERE id=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label3.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    textBox1.Text = read.GetString(1);
                }

            }
            con.Close();
        }

        private void editvisitagad_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            qu = "UPDATE chan SET date=$dat,meds=$med,weight=$wei,libids=$lib,water=$wat,calo=$cal WHERE vistid=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label10.Text);
            cmd.Parameters.AddWithValue("$dat", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"));
            cmd.Parameters.AddWithValue("$med", richTextBox1.Text);
            cmd.Parameters.AddWithValue("$wei", textBox2.Text);
            cmd.Parameters.AddWithValue("$lib", textBox3.Text);
            cmd.Parameters.AddWithValue("$wat", textBox4.Text);
            cmd.Parameters.AddWithValue("$cal", textBox5.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            var apol = Application.OpenForms["visitafromgad"] as visitafromgad;
            apol.loadvisita();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
