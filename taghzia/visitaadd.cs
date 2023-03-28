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
    public partial class visitaadd : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public visitaadd()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= tag.db");
            var bdm = Application.OpenForms["visita"] as visita;
            label3.Text = bdm.label6.Text;
            loaddet();
        }

        private void loaddet()
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                qu = "INSERT INTO chan (date,id,meds,weight,libids,water,calo) " +
                    "VALUES ($dat,$id,$med,$wei,$lib,$wat,$cal)";
                cmd = new SqliteCommand(qu, con);
                cmd.Parameters.AddWithValue("$dat", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("$id", label3.Text);
                cmd.Parameters.AddWithValue("$med", richTextBox1.Text);
                cmd.Parameters.AddWithValue("$wei", textBox2.Text);
                cmd.Parameters.AddWithValue("$lib", textBox3.Text);
                cmd.Parameters.AddWithValue("$wat", textBox4.Text);
                cmd.Parameters.AddWithValue("$cal", textBox5.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                PopupNotifier pop = new PopupNotifier();
                pop.TitleText = "إعلام";
                pop.ContentText = "تمت إضافة الزيارة بنجاح";
                pop.Popup();

                var apo = Application.OpenForms["visita"] as visita;
                apo.loadvisita();
                Close();
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void visitaadd_Load(object sender, EventArgs e)
        {

        }
    }
}
