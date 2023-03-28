using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Tulpep.NotificationWindow;

namespace taghzia
{
    public partial class addnew : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public addnew()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= tag.db");
            getmax();
        }

        private void addnew_Load(object sender, EventArgs e)
        {

        }

        public void getmax()
        {
            try
            {
                con.Open();
                qu = "Select Max(id) From sick";
                cmd = new SqliteCommand(qu, con);
                string max = "0";
                using (SqliteDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {

                        max = read.GetString(0);


                    }
                    label6.Text = (Convert.ToDouble(max)).ToString();


                }
                con.Close();
            }
            catch (Exception ex)
            {
                label6.Text = "0";

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                qu = "INSERT INTO sick (name,age,date,comp,sex,phone) VALUES ($nam,$ag,$dat,$com,$se,$phn)";
                cmd = new SqliteCommand(qu, con);
                cmd.Parameters.AddWithValue("$nam", textBox1.Text);
                cmd.Parameters.AddWithValue("$ag", numericUpDown1.Value.ToString());
                cmd.Parameters.AddWithValue("$dat", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("$com", richTextBox1.Text);
                cmd.Parameters.AddWithValue("$se", comboBox1.Text);
                cmd.Parameters.AddWithValue("$phn", textBox2.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                numericUpDown1.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
                richTextBox1.Text = "";
                comboBox1.SelectedIndex = -1;
                textBox2.Text = "";

                PopupNotifier pop = new PopupNotifier();
                pop.TitleText = "إعلام";
                pop.ContentText = "تمت إضافة المريض بنجاح";
                pop.Popup();
                getmax();
                if (MessageBox.Show("تمت اضافة المريض بنجاح هل تريد إظهار الحساب الخاص به الان؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    visita vis = new visita();
                    vis.ShowDialog();
                    
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }


}
