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
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace taghzia
{
    public partial class showaal : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public showaal()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= tag.db");
            loaddata();
        }
        public void loaddata()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqliteCommand("Select * From sick", con);
            dataGridView1.RowTemplate.Height = 30;
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(2),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(6),
                    read.GetValue(5),

                    });
                }
            }
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

        }

        private void showaal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            try
            {
                if (textBox1.Text == "") { loaddata(); }
                else
                {
                    dataGridView1.Rows.Clear();
                    con.Open();
                    cmd = new SqliteCommand("Select * From sick Where name Like $se", con);
                    dataGridView1.RowTemplate.Height = 30;
                    string k = "%" + textBox1.Text + "%";
                    cmd.Parameters.AddWithValue("$se", k);
                    using (SqliteDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            dataGridView1.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(2),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(6),
                    read.GetValue(5),


                    });
                        }
                    }
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("هل أنت متأكد من حذف بيانات هذه المريض ؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    dataGridView1.Rows.Clear();
                    qu = "DELETE FROM sick WHERE id=$ida";
                    cmd = new SqliteCommand(qu, con);
                    cmd.Parameters.AddWithValue("$ida", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    qu = "DELETE FROM chan WHERE id=$ida";
                    cmd = new SqliteCommand(qu, con);
                    cmd.Parameters.AddWithValue("$ida", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();


                    loaddata();
                }


            }
            if (e.ColumnIndex == 7)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                label1.Text = id.ToString();
                visitafromgad dada = new visitafromgad();
                dada.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportall();
        }

        private void exportall()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            string data = String.Empty;

            int i = 0;
            int j = 0;

            using (con)
            {
                con.Open();

                string stm = "SELECT * FROM sick";

                using (SqliteCommand cmd = new SqliteCommand(stm, con))
                {
                    using (SqliteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read()) // Reading Rows
                        {
                            for (j = 0; j <= rdr.FieldCount - 1; j++) // Looping throw colums
                            {
                                data = rdr.GetValue(j).ToString();
                                xlWorkSheet.Cells[i + 1, j + 1] = data;
                            }
                            i++;
                        }
                    }
                }
                con.Close();
            }
            String path1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            xlWorkBook.SaveAs(path1+"\\"+"3yada.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("تمت العملية بنجاح و الملف الان موجود على سطح المكتب");
            try {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string file = "\\3yada.xls";
                Process.Start(path+file);
            }
            catch (Exception ex) { MessageBox.Show("لا يمكن فتح الملف بشكل اوتوماتيكى من طرف البرنامج من فضلك قم بفتحه يدويا"); }
            
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
