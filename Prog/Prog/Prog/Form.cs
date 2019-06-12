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
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox4;
        private TextBox textBox6;
        private Label label5;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox7;

        //Func<double, double> gt = x => Math.Exp(-1 * Math.Pow(Math.Log(x), 2));
        Func<double, double> gt = x => (x >= 0 && x < 1) ? (Math.Exp(x-1)) : (0);
        //Func<double, double> gt = x => Math.Exp(-1 * Math.Pow(Math.Log(x), 2)) + 0.65*Math.Exp(-1 * Math.Pow(Math.Log(x) -5, 2));

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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(993, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
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
            this.tabPage1.Size = new System.Drawing.Size(985, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ввід ω";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(502, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 58);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Зашумлення";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(109, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Відносна похибка";
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
            this.button1.Location = new System.Drawing.Point(809, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 59);
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
            this.tabControl2.Size = new System.Drawing.Size(975, 563);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(967, 537);
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
            this.dataGridView1.Size = new System.Drawing.Size(247, 524);
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
            this.tabPage4.Size = new System.Drawing.Size(967, 537);
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
            this.dataGridView2.Size = new System.Drawing.Size(246, 525);
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
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Знаходження рішення";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Права межа";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(504, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(322, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(74, 69);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "γ=";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "|Z(ω)|^-2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(783, 7);
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
            this.tabControl3.Size = new System.Drawing.Size(661, 533);
            this.tabControl3.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chart1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(653, 507);
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
            this.chart1.Size = new System.Drawing.Size(643, 494);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chart2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(653, 507);
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
            this.chart2.Size = new System.Drawing.Size(642, 495);
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
            this.dataGridView3.Size = new System.Drawing.Size(309, 609);
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
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(1012, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 644);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Додатково ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 592);
            this.textBox2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Крок";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(504, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 8;
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1296, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MyProg";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
            ///////
            double sigm;
            try
            {
                sigm = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                sigm = 0;
            }
            //////////
            Func<double, double> Target;
            double UpperBorder = 1000;
            double step = 0.01;
            Func<double, double, double> Carry = (x, y) => (gt(x)/(1+y*y*x*x));
            Func< double, Func<double, double>> Magic = (y) => ((z) => (gt(z) / (1 + z * z  * y * y)));
            Func< double, double, double, Func<Func<double,double>,double>> Integrate = (BoB,UpB, st) => ((InF)=>(Tools.CountIntegral(InF, BoB,UpB,st)));
            Func<Func<double, double>, double> Win = Integrate(0,UpperBorder,step);
            ZReal.Clear();
            ZIm.Clear();
            double temp = 0;
            for (i = 0; i < Omega.Count; i++)
            {
                point:
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                double y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                double s = x * x + y * y;
                if ((s == 0) || (s > 1))
                {
                    goto point;
                }
                double result = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                Target = Magic(Omega[i]);
                ZReal.Add(Win(Target));
                temp += result * result;
                ZReal[i] = ZReal[i] + result * (ZReal[i] * sigm);
            }
            temp = Math.Sqrt(temp);
             Magic = (y) => ((z) => ((z*y*gt(z)) / (1 + z * z * y * y)));
            for (i = 0; i < Omega.Count; i++)
            {
                point2  :
                Random a = new Random();
                Random b = new Random();
                Random c = new Random();
                double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                double y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
                double s = x * x + y * y;
                if ((s == 0) || (s > 1))
                {
                    goto point2;
                }
                double result = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
                Target = Magic(Omega[i]);
                ZIm.Add(-1*Win(Target));
                ZIm[i] = ZIm[i] + result * sigm * ZIm[i];
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
            if (radioButton1.Checked)
            {
                for (i = 0; i < ZReal.Count; i++)
                {
                    Gamma.Add(1);
                }
            }
            else
            {
                for(i = 0; i < ZReal.Count; i++)
                {
                    Gamma.Add(Math.Pow(Math.Sqrt(ZReal[i]* ZReal[i] + ZIm[i]*ZIm[i]),-2));
                }
            }

            double[,] a1 = new double[ZReal.Count, ZReal.Count];
            double[,] a2 = new double[ZReal.Count, ZReal.Count];
            double[,] ab1 = new double[ZReal.Count, ZReal.Count];
            double[,] ab2 = new double[ZReal.Count, ZReal.Count];


            double BestLam = 1;
            double lambda = 1;
            List<double> NeighErCheb = new List<double>();
            List<double> NeighErQuadratic = new List<double>();
            List<double> ExactErCheb = new List<double>();
            List<double> ExactERQuadratic = new List<double>();

            double[,] g;
            double[,] g2;
            double[,] gb;
            double[,] gb2;

            double temp1,temp2;
            double[,] RightSide;
            double Lim;
                try
            {
                Lim = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                Lim = 100;
            }
            /////
            double step;
            try
            {
                step = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                step = 0.05;
            }
            /////
            while (lambda>0.0000000000001)
            {
                for (i = 0; i < ZReal.Count; i++)
                {
                    for (j = 0; j < ZReal.Count; j++)
                    {
                        a1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        a2[i, j] = (Math.PI * Gamma[i]) / (2 * Omega[i] * Omega[j] * (Omega[i] + Omega[j]));
                        ab1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        ab2[i, j] = (Math.PI * Gamma[i]) / (2 * Omega[i] * Omega[j] * (Omega[i] + Omega[j]));
                    }
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    a1[i, i] += lambda;
                    a2[i, i] += lambda;
                    ab1[i, i] += 2*lambda;
                    ab2[i, i] += 2*lambda;
                }
                RightSide = new double[ZReal.Count, 1];
                for (i = 0; i < ZReal.Count; i++)
                {
                    RightSide[i, 0] = Gamma[i] * ZReal[i];
                }

                g = Matrixes.Solve(a1, RightSide);
                gb = Matrixes.Solve(ab1, RightSide);
                for (i = 0; i < ZReal.Count; i++)
                {
                    RightSide[i, 0] = -1 * Gamma[i] * ZIm[i];
                }
                g2 = Matrixes.Solve(a2, RightSide);
                gb2 = Matrixes.Solve(ab2, RightSide);


                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart2.Series[0].Points.Clear();
                chart2.Series[1].Points.Clear();
                //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);

                double MaxDifferenceNeigb = 0;
                double MaxDifferenceExact = 0;
                double Sum1=0, Sum2=0;
                for (double tau = 0; tau < Lim; tau += step)
                {
                    //chart1.Series[0].Points.AddXY(tau, gt(tau));
                    //chart2.Series[0].Points.AddXY(tau, gt(tau));
                    temp1 = 0;
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        temp1 += g[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                    }
                    temp2 = 0;
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        temp2 += gb[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                    }
                    if (MaxDifferenceNeigb < Math.Abs(temp1 - temp2))
                    {
                        MaxDifferenceNeigb = Math.Abs(temp1 - temp2);
                    }
                    if (MaxDifferenceExact < Math.Abs(temp1 - gt(tau)))
                    {
                        MaxDifferenceExact = Math.Abs(temp1 - gt(tau));
                    }
                    Sum1 += Math.Pow(temp1 - temp2,2);
                    Sum2 += Math.Pow(temp1 - gt(tau),2);

                    //chart1.Series[1].Points.AddXY(tau, temp1);
                    ///////

                   temp1 = 0;
                   for (i = 0; i < ZReal.Count; i++)
                   {
                       temp1 += (g2[i, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                   }
                   temp2 = 0;
                   for (i = 0; i < ZReal.Count; i++)
                   {
                       temp2 += (gb2[i, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                   }
                   chart2.Series[1].Points.AddXY(tau, temp1);
                }
                NeighErCheb.Add(MaxDifferenceNeigb);
                NeighErQuadratic.Add(Math.Sqrt(Sum1 / (Lim*20)));
                ExactErCheb.Add(MaxDifferenceExact);
                ExactERQuadratic.Add(Math.Sqrt(Sum2 / (Lim * 20)));
                if (checkBox1.Checked)
                {
                    textBox2.Text += ("Похибки для λ="+lambda+":"+Environment.NewLine);
                    textBox2.Text+=("  Макс для сусідів =" + NeighErCheb[NeighErCheb.Count-1] + Environment.NewLine);
                    textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic[NeighErQuadratic.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Макс для точного =" + ExactErCheb[ExactErCheb.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Квадратична для точного =" + ExactERQuadratic[ExactERQuadratic.Count - 1] + Environment.NewLine);
                }
                lambda /= 2;
            }
            int MinVal = NeighErCheb.FindIndex(x=>x==NeighErCheb.Min());
            Console.WriteLine();

            lambda = Math.Pow(2,-1*MinVal);

            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    a1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    a2[i, j] = (Math.PI * Gamma[i]) / (2 * Omega[i] * Omega[j] * (Omega[i] + Omega[j]));
                    ab1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    ab2[i, j] = (Math.PI * Gamma[i]) / (2 * Omega[i] * Omega[j] * (Omega[i] + Omega[j]));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                a1[i, i] += lambda;
                a2[i, i] += lambda;
                ab1[i, i] += 2 * lambda;
                ab2[i, i] += 2 * lambda;
            }
            RightSide = new double[ZReal.Count, 1];
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i, 0] = Gamma[i] * ZReal[i];
            }

            g = Matrixes.Solve(a1, RightSide);
            gb = Matrixes.Solve(ab1, RightSide);
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i, 0] = -1 * Gamma[i] * ZIm[i];
            }
            g2 = Matrixes.Solve(a2, RightSide);
            gb2 = Matrixes.Solve(ab2, RightSide);

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);


            for (double tau = 0; tau < Lim; tau += step)
            {
                chart1.Series[0].Points.AddXY(tau, gt(tau));
                chart2.Series[0].Points.AddXY(tau, gt(tau));
                temp1 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp1 += g[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                temp2 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp2 += gb[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                chart1.Series[1].Points.AddXY(tau, temp1);
                ///////

                temp1 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp1 += (g2[i, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                temp2 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp2 += (gb2[i, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                chart2.Series[1].Points.AddXY(tau, temp1);
            }

           textBox2.Text+=("Похибки для оптимального λ=" + lambda + ":" + Environment.NewLine);
           textBox2.Text+=("  Макс для сусідів =" + NeighErCheb[MinVal] + Environment.NewLine);
           textBox2.Text+=("  Квадратична для сусідів =" + NeighErQuadratic[MinVal] + Environment.NewLine);
           textBox2.Text+=("  Макс для точного =" + ExactErCheb[MinVal] + Environment.NewLine);
           textBox2.Text+=("  Квалратична для точного =" + ExactERQuadratic[MinVal] + Environment.NewLine);
        }
    }
}
