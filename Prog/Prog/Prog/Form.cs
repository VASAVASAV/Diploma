using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog
{
    class MyProg : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox textBox1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private TabPage tabPage4;
        private DataGridView dataGridView2;
        private TabPage tabPage2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private DataGridView dataGridView3;
        private Button button1;
        private Label label3;
        private TextBox textBox4;
        private Button button2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox1;
        private bool ResSet = false;
        private bool OmSet = false;
        List<double> Omega = new List<double>();
        List<double> ZReal = new List<double>();
        private TabControl tabControl3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button3;
        List<double> ZIm = new List<double>();

        public MyProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввід ω";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Верхня межа інтегрування";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(334, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = " Змоделювати опір";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Функція g(τ)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(334, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кількість спостережень";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 49);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(797, 398);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 372);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Ручне введення";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер спостереження";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Значення";
            this.Column4.Name = "Column4";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 372);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Моделювання";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = " Згенерувати ω";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 363);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер спостереження";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значення ω";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Знаходження рішення";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(701, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "Розв\'язати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(321, 82);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(579, 439);
            this.tabControl3.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chart1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(571, 413);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "ΖReal";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 7);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerSize = 3;
            series2.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(561, 400);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chart2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(571, 413);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "ZIm";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(5, 6);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerSize = 3;
            series4.Name = "Series3";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(561, 400);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column5,
            this.Column6});
            this.dataGridView3.Location = new System.Drawing.Point(6, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(309, 514);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер спостереження";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Значення ω";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ZReal";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ZIm";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(933, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 555);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 525);
            this.textBox2.TabIndex = 2;
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1180, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MyProg";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num;
            try
            {
                num = Convert.ToInt32(textBox1.Text);
                if (num < 1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBox2.Text += "Невірний ввід"+Environment.NewLine;
                return;
            }
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < num; i++)
            {
                dataGridView1.Rows.Add((i+1),"");
                dataGridView2.Rows.Add((i + 1), "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Num;
            try
            {
                Num = Convert.ToInt32(textBox1.Text);
                if (Num < 1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBox2.Text += "Невірний ввід" + Environment.NewLine;
                return;
            }
            if (Num % 4 != 0)
            {
                textBox2.Text += "Для цього методу необхідна кратність чотирьом" + Environment.NewLine;
                return;
            }
            Num /= 4;
            double Min, Max;
            Min = 0.01;
            Max = 0.1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < Num; j++)
                {
                    dataGridView2.Rows[i * Num + j].Cells[1].Value = ""+(Min+j*(Max-Min)/Num);
                }
                Max *= 10;
                Min *= 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x=>1),0,50,1)-50);
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => x/2), 0, 10, 1));
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => x / 2), 0, 10, 0.1));
            Console.WriteLine();
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => Math.Exp(-1*(x*x))), -100, 100, 1));
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => Math.Exp(-1 * (x * x))), -100, 100, 0.1));
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => Math.Exp(-1 * (x * x))), -100, 100, 0.01));
            Console.WriteLine();
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => Math.Sin(x)), 0, Math.PI, 1));
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => Math.Sin(x)), 0, Math.PI, 0.1));
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => Math.Sin(x)), 0, Math.PI, 0.01));
            Console.WriteLine(Tools.CountIntegral(new Func<double, double>(x => Math.Sin(x)), 0, Math.PI, 0.001));*/
            try
            {
                Convert.ToInt32(textBox1.Text);
                if ((string)dataGridView1.Rows[0].Cells[1].Value == "" && (string)dataGridView2.Rows[0].Cells[1].Value == "")
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBox2.Text += "Спочатку введіть ω" + Environment.NewLine;
                return;
            }
            int i, j, k;
            Omega.Clear();
            if ((string)dataGridView1.Rows[0].Cells[1].Value == "")
            {
                try
                {
                    for (i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        Omega.Add(Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value));
                    }
                }
                catch
                {
                    textBox2.Text += "Спочатку введіть ω (2) " + Environment.NewLine;
                    return;
                }
            }
            else
            {
                try
                {
                    for (i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        Omega.Add(Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value));
                    }
                }
                catch
                {
                    textBox2.Text += "Спочатку введіть ω (1) " + Environment.NewLine;
                    return;
                }
            }
            Func<double, double> Target;
            double UpperBorder = 1000;
            double step = 0.01;
            Func<double, double> gt = x=>Math.Exp(-1*Math.Pow(Math.Log(x),2));
            Func<double, double, double> Carry = (x, y) => (gt(x)/(1+y*y*x*x));
            Func< double, Func<double, double>> Magic = (y) => ((z) => (gt(z) / (1 + z * z  * y * y)));
            Func< double, double, double, Func<Func<double,double>,double>> Integrate = (BoB,UpB, st) => ((InF)=>(Tools.CountIntegral(InF, BoB,UpB,st)));
            Func<Func<double, double>, double> Win = Integrate(0,UpperBorder,step);
            ZReal.Clear();
            ZIm.Clear();
            for (i = 0; i < Omega.Count; i++)
            {
                Target = Magic(Omega[i]);
                ZReal.Add(Win(Target));
            }
             Magic = (y) => ((z) => ((z*y*gt(z)) / (1 + z * z * y * y)));
            for (i = 0; i < Omega.Count; i++)
            {
                Target = Magic(Omega[i]);
                ZIm.Add(-1*Win(Target));
            }
            dataGridView3.Rows.Clear();
            for (i = 0; i < Omega.Count; i++)
            {
                dataGridView3.Rows.Add((i+1),Omega[i],ZReal[i],ZIm[i]);
            }
                textBox2.Text += "Done" + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ZReal.Count == 0)
            {
                textBox2.Text += "Спочатку змоделюйте опір" + Environment.NewLine;
                return;
            }
            int i, j, k;
            List<double> Gamma = new List<double>();
            for (i = 0; i < ZReal.Count; i++)
            {
                Gamma.Add(1);
            }
            double[,] a1 = new double[ZReal.Count, ZReal.Count];
            double[,] a2 = new double[ZReal.Count, ZReal.Count];
            
            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    a1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    a2[i, j] = (Math.PI * Gamma[i]) / (2 * Omega[i] * Omega[j] * (Omega[i] + Omega[j]));
                }
            }
            double lambda = 0.0001;
            for (i = 0; i < ZReal.Count; i++)
            {
                a1[i, i] += lambda;
                a2[i, i] += lambda;
            }
            double[,] RightSide = new double[ZReal.Count, 1];
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i, 0] = Gamma[i] * ZReal[i];
            }
            double[,] g = Matrixes.Solve(a1,RightSide);
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i, 0] = -1*Gamma[i] * ZIm[i];
            }
            double[,] g2 = Matrixes.Solve(a2, RightSide);
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            Func<double, double> gt = x => Math.Exp(-1 * Math.Pow(Math.Log(x), 2));
            //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);
            double temp;
            for (double tau = 0; tau < 80; tau+=0.05)
            {
                chart1.Series[0].Points.AddXY(tau,gt(tau));
                chart2.Series[0].Points.AddXY(tau, gt(tau));
                temp = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp += g[i,0] / (1+Omega[i]*Omega[i]*tau*tau);
                }
                chart1.Series[1].Points.AddXY(tau, temp);
                ///////
                
                temp = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp += (g2[i, 0]*Omega[i]*tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                chart2.Series[1].Points.AddXY(tau, temp);
            }
        }
    }
}
