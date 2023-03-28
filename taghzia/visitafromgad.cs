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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Microsoft.Data.Sqlite;
using Tulpep.NotificationWindow;

namespace taghzia
{
    public partial class visitafromgad : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public visitafromgad()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= tag.db");
            var ca = Application.OpenForms["showaal"] as showaal;
            label6.Text = ca.label1.Text;

            loaddet();
            loadvisita();
        }
        public void drawcart()
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[3].Value);

            }
            /*chart1.Series["Series1"].Points.AddXY("20", "50");
            chart1.Series["Series1"].Points.AddXY("30", "60");*/





        }
        public void loadvisita()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqliteCommand("Select * From chan WHERE id==$id", con);
            dataGridView1.RowTemplate.Height = 30;
            cmd.Parameters.AddWithValue("$id", label6.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(5),
                    read.GetValue(6),
                    read.GetValue(7),


                    });
                }
                drawcart();
            }
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

        }

        private void loaddet()
        {
            con.Open();
            qu = "SELECT * FROM sick WHERE id=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label6.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {

                    textBox1.Text = read.GetString(1);
                    numericUpDown1.Value = read.GetDecimal(2);
                    string s = read.GetString(3);

                    DateTime dt =
                        DateTime.ParseExact(s, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);


                    dateTimePicker1.Value = dt;
                    richTextBox1.Text = read.GetString(4);
                    comboBox1.Text = read.GetString(5);
                    textBox2.Text = read.GetString(6);
                }

            }
            con.Close();
        }

        private void visitafromgad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qu = "UPDATE sick SET name=$nam,age=$ag,date=$dat,comp=$com,sex=$se,phone=$phn WHERE id=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label6.Text);
            cmd.Parameters.AddWithValue("$nam", textBox1.Text);
            cmd.Parameters.AddWithValue("$ag", numericUpDown1.Value.ToString());
            cmd.Parameters.AddWithValue("$dat", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"));
            cmd.Parameters.AddWithValue("$com", richTextBox1.Text);
            cmd.Parameters.AddWithValue("$se", comboBox1.Text);
            cmd.Parameters.AddWithValue("$phn", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            PopupNotifier pop = new PopupNotifier();
            pop.TitleText = "إعلام";
            pop.ContentText = "تمت تعديل بيانات المريض بنجاح";
            pop.Popup();


            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vistaaddgad vida = new vistaaddgad();
            vida.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("هل أنت متأكد من حذف بيانات هذه الزيارة ؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    dataGridView1.Rows.Clear();
                    qu = "DELETE FROM chan WHERE vistid=$ida";
                    cmd = new SqliteCommand(qu, con);
                    cmd.Parameters.AddWithValue("$ida", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadvisita();
                }


            }
            if (e.ColumnIndex == 7)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                label7.Text = id.ToString();
                editvisitagad edi = new editvisitagad();
                edi.ShowDialog();

            }
        }
    }
}
