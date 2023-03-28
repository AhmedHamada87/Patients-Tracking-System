
namespace taghzia
{
    partial class visitafromgad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visitafromgad));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(914, 332);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(366, 300);
            this.chart1.TabIndex = 41;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 40);
            this.label7.TabIndex = 40;
            this.label7.Text = "بيان تفصيلى للمريض";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 40);
            this.label6.TabIndex = 39;
            this.label6.Text = "بيان تفصيلى للمريض";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1027, 659);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 54);
            this.button2.TabIndex = 38;
            this.button2.Text = "إضافة زيارة جديدة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::taghzia.Properties.Resources.download__6_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(36, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 228);
            this.panel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 31;
            this.button1.Text = "الغاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 284);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تاريخ الزيارات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dat,
            this.meds,
            this.weight,
            this.lib,
            this.water,
            this.calo,
            this.edit,
            this.del});
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(849, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "معرف الزيارة";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dat
            // 
            this.dat.HeaderText = "تاريخ الزيارة";
            this.dat.Name = "dat";
            this.dat.ReadOnly = true;
            // 
            // meds
            // 
            this.meds.HeaderText = "الادوية";
            this.meds.Name = "meds";
            this.meds.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.HeaderText = "الوزن";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // lib
            // 
            this.lib.HeaderText = "الدهون";
            this.lib.Name = "lib";
            this.lib.ReadOnly = true;
            // 
            // water
            // 
            this.water.HeaderText = "ماء";
            this.water.Name = "water";
            this.water.ReadOnly = true;
            // 
            // calo
            // 
            this.calo.HeaderText = "السعرات الحرارية";
            this.calo.Name = "calo";
            this.calo.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "تعديل";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "تعديل";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // del
            // 
            this.del.HeaderText = "حذف";
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Text = "حذف";
            this.del.UseColumnTextForButtonValue = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(181, 648);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 54);
            this.button3.TabIndex = 29;
            this.button3.Text = "حفظ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(315, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(570, 106);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(721, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 36);
            this.label5.TabIndex = 34;
            this.label5.Text = "الأمراض المصاحبة";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(776, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 43);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(945, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "تاريخ التسجيل";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1094, 131);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 43);
            this.numericUpDown1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1185, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 36);
            this.label3.TabIndex = 28;
            this.label3.Text = "السن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1185, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "الاسم";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(732, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(427, 43);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1060, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "بيان تفصيلى للمريض";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.comboBox1.Location = new System.Drawing.Point(500, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 44);
            this.comboBox1.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 36);
            this.label9.TabIndex = 42;
            this.label9.Text = "الجنس";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(648, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 36);
            this.label8.TabIndex = 45;
            this.label8.Text = "رقم الهاتف";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(334, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(301, 43);
            this.textBox2.TabIndex = 44;
            // 
            // visitafromgad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 749);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "visitafromgad";
            this.Text = "بيان تفصيلى للمريض";
            this.Load += new System.EventHandler(this.visitafromgad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn meds;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn lib;
        private System.Windows.Forms.DataGridViewTextBoxColumn water;
        private System.Windows.Forms.DataGridViewTextBoxColumn calo;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
    }
}