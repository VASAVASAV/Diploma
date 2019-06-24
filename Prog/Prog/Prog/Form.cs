using System;
using System.Collections.Generic;
using System.IO;
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
        private Button button5;
        private Button button4;
        private TabPage tabPage7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Button button6;
        private Label label7;
        private TextBox textBox8;
        private TabPage tabPage8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private CheckBox checkBox2;
        private Button button7;
        private Button button8;

        Func<double, double> gt = x => Math.Exp(-1 * Math.Pow(Math.Log(x), 2));
        //Func<double, double> gt = x => Math.Exp(-1*Math.Pow(x-10,2)/18) / (3*Math.Sqrt(2 * Math.PI));
        //Func<double, double> gt = x => (x >= 0 && x < 1) ? (Math.Exp(x-1)) : ((x >= 1 && x < 4) ? (Math.Exp(x - 4)):(0));
        //Func<double, double> gt = x => Math.Exp(-1 * Math.Pow(Math.Log(x), 2)) + 0.65*Math.Exp(-1 * Math.Pow(Math.Log(x) -5, 2));
        //Func<double, double> gt = x => Math.Exp(-1 * Math.Pow(Math.Log(x), 2)) + 0.75* Math.Exp(-1 * (Math.Pow(Math.Log(x+3), 2)-1));
        //Func<double, double> gt = x => Math.Exp(-1 * Math.Pow(Math.Log(x), 2)) + 0.75 * Math.Exp(-1 * (Math.Pow(Math.Log(x + 3), 2) - 1));

        public MyProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
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
            this.tabPage1.Controls.Add(this.checkBox2);
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(675, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Діаграма Найквіста";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(440, 6);
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
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
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
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(574, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 36);
            this.button8.TabIndex = 16;
            this.button8.Text = "Квазіоптимальність";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(574, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 50);
            this.button7.TabIndex = 15;
            this.button7.Text = "Розв\'язати (додатковий метод)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(855, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 50);
            this.button6.TabIndex = 14;
            this.button6.Text = "Розв\'язати (додатковий метод)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ліва межа";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(483, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(85, 20);
            this.textBox8.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(161, 565);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 46);
            this.button5.TabIndex = 11;
            this.button5.Text = "Записати опір у файл";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 565);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "Зчитати опір з файлу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Крок";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(483, 59);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(85, 20);
            this.textBox7.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Права межа";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(483, 7);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 20);
            this.textBox5.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(322, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(74, 91);
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
            this.button3.Location = new System.Drawing.Point(654, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Розв\'язати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Location = new System.Drawing.Point(321, 104);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(661, 511);
            this.tabControl3.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chart1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(653, 485);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "ΖReal";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(4, 7);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.MarkerSize = 3;
            series10.Name = "Series3";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
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
            this.tabPage6.Size = new System.Drawing.Size(653, 485);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "ZIm";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(5, 6);
            this.chart2.Name = "chart2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Series2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.MarkerSize = 3;
            series12.Name = "Series3";
            this.chart2.Series.Add(series11);
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(642, 495);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.chart3);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(653, 485);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Діаграма Найквіста";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea7.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(4, 3);
            this.chart3.Name = "chart3";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.Legend = "Legend1";
            series14.Name = "Series2";
            this.chart3.Series.Add(series13);
            this.chart3.Series.Add(series14);
            this.chart3.Size = new System.Drawing.Size(646, 501);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chart4);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(653, 485);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Zall";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chart4
            // 
            chartArea8.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart4.Legends.Add(legend8);
            this.chart4.Location = new System.Drawing.Point(4, 4);
            this.chart4.Name = "chart4";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            series15.YValuesPerPoint = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series16.Legend = "Legend1";
            series16.MarkerSize = 3;
            series16.Name = "Series2";
            this.chart4.Series.Add(series15);
            this.chart4.Series.Add(series16);
            this.chart4.Size = new System.Drawing.Size(649, 478);
            this.chart4.TabIndex = 0;
            this.chart4.Text = "chart4";
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
            this.dataGridView3.Size = new System.Drawing.Size(309, 556);
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
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
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
                ZIm.Add(Win(Target));
                ZIm[i] = ZIm[i] + result * sigm * ZIm[i];
            }
            dataGridView3.Rows.Clear();
            for (i = 0; i < Omega.Count; i++)
            {
                dataGridView3.Rows.Add((i+1),Omega[i],ZReal[i],ZIm[i]);
            }
                textBox2.Text += "Done" + Environment.NewLine;

            chart3.Series[0].Points.Clear();
            for (i = 0; i < ZReal.Count; i++)
            {
                chart3.Series[1].Points.AddXY(ZReal[i],ZIm[i]);
            }
            ///////
            if (checkBox2.Checked)
            {
                double temp1, temp2;
                for (double l = 0.01; l < 0.1; l += 0.005)
                {
                    Magic = (y) => ((z) => (gt(z) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp1 = (Win(Target));
                    Magic = (y) => ((z) => ((z * y * gt(z)) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp2 = (Win(Target));
                    chart3.Series[0].Points.AddXY(temp1, temp2);
                }
                for (double l = 0.1; l < 1; l += 0.05)
                {
                    Magic = (y) => ((z) => (gt(z) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp1 = (Win(Target));
                    Magic = (y) => ((z) => ((z * y * gt(z)) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp2 = (Win(Target));
                    chart3.Series[0].Points.AddXY(temp1, temp2);
                }
                for (double l = 1; l < 10; l += 0.5)
                {
                    Magic = (y) => ((z) => (gt(z) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp1 = (Win(Target));
                    Magic = (y) => ((z) => ((z * y * gt(z)) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp2 = (Win(Target));
                    chart3.Series[0].Points.AddXY(temp1, temp2);
                }
                for (double l = 10; l < 100; l += 5)
                {
                    Magic = (y) => ((z) => (gt(z) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp1 = (Win(Target));
                    Magic = (y) => ((z) => ((z * y * gt(z)) / (1 + z * z * y * y)));
                    Target = Magic(l);
                    temp2 = (Win(Target));
                    chart3.Series[0].Points.AddXY(temp1, temp2);
                }
            }
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


            double lambda = 16;
            List<double> NeighErCheb = new List<double>();
            List<double> NeighErQuadratic = new List<double>();
            List<double> ExactErCheb = new List<double>();
            List<double> ExactERQuadratic = new List<double>();
            List<double> NeighErRel = new List<double>();
            List<double> ExactErRel = new List<double>();


            List<double> NeighErCheb2 = new List<double>();
            List<double> NeighErQuadratic2 = new List<double>();
            List<double> ExactErCheb2 = new List<double>();
            List<double> ExactERQuadratic2 = new List<double>();
            List<double> NeighErRel2 = new List<double>();
            List<double> ExactErRel2 = new List<double>();

            double[,] g;
            double[,] g2;
            double[,] gb;
            double[,] gb2;

            double temp1,temp2;
            double[,] RightSide;
            
            double Lim, leftLim;
            try
            {
                leftLim = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                leftLim = 0;
            }
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
            double Norm;
            while (lambda>0.0000000000001)
            {
                for (i = 0; i < ZReal.Count; i++)
                {
                    for (j = 0; j < ZReal.Count; j++)
                    {
                        a1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        a2[i, j] = (Math.PI * Gamma[i]) / (2 *  (Omega[i] + Omega[j]));
                        ab1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        ab2[i, j] = (Math.PI * Gamma[i]) / (2 *(Omega[i] + Omega[j]));
                    }
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    a1[i, i] = (Math.PI / (4 * Omega[i])) + lambda;
                    a2[i, i] = (Math.PI / (4 * Omega[i])) + lambda;
                    ab1[i, i] = (Math.PI / (4 * Omega[i])) + 2 * lambda;
                    ab2[i, i] = (Math.PI / (4 * Omega[i])) + 2 * lambda;
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
                    RightSide[i, 0] =  Gamma[i] * ZIm[i];
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
                double MaxDifferenceNeigbRel = 0;
                double MaxDifferenceExactRel = 0;
                double Sum1=0, Sum2=0;
                chart1.ChartAreas[0].AxisX.Minimum = leftLim;
                chart2.ChartAreas[0].AxisX.Minimum = leftLim;
                Norm = 0;
                for (double tau = leftLim; tau < Lim; tau += step)
                {
                    if (Norm < Math.Abs(gt(tau)))
                    {
                        Norm = Math.Abs(gt(tau));
                    }
                }
                for (double tau = leftLim; tau < Lim; tau += step)
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
                    ///////
                    if (gt(tau)!=0 && MaxDifferenceExactRel < Math.Abs((temp1 - gt(tau)))/Norm)
                    {
                        MaxDifferenceExactRel = Math.Abs((temp1 - gt(tau))) / Norm;
                    }
                    ///////
                    Sum1 += Math.Pow(temp1 - temp2,2);
                    Sum2 += Math.Pow(temp1 - gt(tau),2);

                    //chart1.Series[1].Points.AddXY(tau, temp1);
                    ///////
                }
                NeighErCheb.Add(MaxDifferenceNeigb);
                NeighErQuadratic.Add(Math.Sqrt(Sum1 / (Lim*20)));
                ExactErCheb.Add(MaxDifferenceExact);
                ExactERQuadratic.Add(Math.Sqrt(Sum2 / (Lim * 20)));
                ExactErRel.Add(MaxDifferenceExactRel);
                ///////////////////////////////
                MaxDifferenceExactRel = 0;
                MaxDifferenceNeigb = 0;
                MaxDifferenceExact = 0;
                Sum1 = 0; Sum2 = 0;
                for (double tau = leftLim; tau < Lim; tau += step)
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
                    /////
                    if(gt(tau) != 0 && MaxDifferenceExactRel < Math.Abs((temp1 - gt(tau))) / Norm)
                    {
                        MaxDifferenceExactRel = Math.Abs((temp1 - gt(tau))) / Norm;
                    }                    /////
                    Sum1 += Math.Pow(temp1 - temp2, 2);
                    Sum2 += Math.Pow(temp1 - gt(tau), 2);

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
                    if (MaxDifferenceNeigb < Math.Abs(temp1 - temp2))
                    {
                        MaxDifferenceNeigb = Math.Abs(temp1 - temp2);
                    }
                    if (MaxDifferenceExact < Math.Abs(temp1 - gt(tau)))
                    {
                        MaxDifferenceExact = Math.Abs(temp1 - gt(tau));
                    }
                    Sum1 += Math.Pow(temp1 - temp2, 2);
                    Sum2 += Math.Pow(temp1 - gt(tau), 2);
                    ///chart2.Series[1].Points.AddXY(tau, temp1);
                }
                NeighErCheb2.Add(MaxDifferenceNeigb);
                NeighErQuadratic2.Add(Math.Sqrt(Sum1 / (Lim * 20)));
                ExactErCheb2.Add(MaxDifferenceExact);
                ExactERQuadratic2.Add(Math.Sqrt(Sum2 / (Lim * 20)));
                ExactErRel2.Add(MaxDifferenceExactRel);
                ///////////////////////
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
            int MinVal = ExactERQuadratic.FindIndex(x=>x== ExactERQuadratic.Min());
            int MinVal2 = ExactERQuadratic2.FindIndex(x => x == ExactERQuadratic2.Min());
            Console.WriteLine(MinVal + "   " + MinVal2);

            lambda = Math.Pow(2,-1*MinVal);
            double lambda2 = Math.Pow(2, -1 * MinVal2);
            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    a1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    a2[i, j] = (Math.PI * Gamma[i]) / (2 *  (Omega[i] + Omega[j]));
                    ab1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    ab2[i, j] = (Math.PI * Gamma[i]) / (2 *  (Omega[i] + Omega[j]));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                a1[i, i] += lambda;
                a2[i, i] += lambda;
                ab1[i, i]+=2 * lambda2;
                ab2[i, i]+=2 * lambda2;
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
                RightSide[i, 0] =Gamma[i] * ZIm[i];
            }
            g2 = Matrixes.Solve(a2, RightSide);
            gb2 = Matrixes.Solve(ab2, RightSide);

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);
            Norm = 0;
            for (double tau = leftLim; tau < Lim; tau += step)
            {
                if (Norm < Math.Abs(gt(tau)))
                {
                    Norm = Math.Abs(gt(tau));
                }
            }
            for (double tau = leftLim; tau < Lim; tau += step)
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

           textBox2.Text+=("Похибки для оптимального λ(Real)=" + lambda + ":" + Environment.NewLine);
           textBox2.Text+=("  Макс для сусідів =" + NeighErCheb[MinVal] + Environment.NewLine);
           textBox2.Text+=("  Квадратична для сусідів =" + NeighErQuadratic[MinVal] + Environment.NewLine);
           textBox2.Text+=("  Макс для точного =" + ExactErCheb[MinVal] + Environment.NewLine);
           textBox2.Text+=("  Квадратична для точного =" + ExactERQuadratic[MinVal] + Environment.NewLine);
            textBox2.Text += ("Відносна для точного =" + ExactErRel[MinVal] + Environment.NewLine);

            textBox2.Text += ("Похибки для оптимального λ(Im)=" + lambda2 + ":" + Environment.NewLine);
           textBox2.Text += ("  Макс для сусідів =" + NeighErCheb2[MinVal2] + Environment.NewLine);
           textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic2[MinVal2] + Environment.NewLine);
           textBox2.Text += ("  Макс для точного =" + ExactErCheb2[MinVal2] + Environment.NewLine);
           textBox2.Text += ("  Квадратична для точного =" + ExactERQuadratic2[MinVal2] + Environment.NewLine);
            textBox2.Text += ("Відносна для точного =" + ExactErRel2[MinVal2] + Environment.NewLine);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog savingFileDialog = new SaveFileDialog();
            savingFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savingFileDialog.FilterIndex = 2;
            savingFileDialog.RestoreDirectory = true;
            savingFileDialog.RestoreDirectory = true;
            if (savingFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter FileToWrite = new System.IO.StreamWriter(savingFileDialog.FileName, true))
                {
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        FileToWrite.WriteLine("" + dataGridView3.Rows[i].Cells[1].Value + "\t" + dataGridView3.Rows[i].Cells[2].Value + "\t" + dataGridView3.Rows[i].Cells[3].Value);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog();

            OpeningDialog.InitialDirectory = Application.StartupPath.ToString();
            OpeningDialog.Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat";
            OpeningDialog.FilterIndex = 1;
            OpeningDialog.RestoreDirectory = true;

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                ZReal.Clear();
                ZIm.Clear();
                dataGridView3.Rows.Clear();
                //this.ProgressBar.Step = 100;
                //this.ProgressBar.PerformStep();
                //this.ProgressBar.Value = 50;
                List<double> temp = new List<double>();
                string[] FileLikeStrings = File.ReadAllLines(OpeningDialog.FileName);
                char[] separators = new char[] { ' ', '\t', '\n' };
                for (int i = 0; i < FileLikeStrings.Length; i++)
                {
                    Tools.RemoveComments(ref FileLikeStrings[i]);
                    string[] valuesInLine = FileLikeStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < 3; j++)
                    {
                        double x;
                        try
                        {
                            x = Convert.ToDouble(valuesInLine[j]);
                        }
                        catch
                        {
                            try
                            {
                                valuesInLine[j] = valuesInLine[j].Replace(".", ",");
                                x = Convert.ToDouble(valuesInLine[j]);
                            }
                            catch
                            {
                                textBox2.Text += "Theres mistake in string #" + i + Environment.NewLine;
                                continue;
                            }
                        }
                        temp.Add(x);
                    }
                    if (temp.Count < 3)
                    {
                        continue;
                    }
                    Omega.Add(temp[0]);
                    ZReal.Add(temp[1]);
                    ZIm.Add(temp[2]);
                    dataGridView3.Rows.Add((dataGridView3.Rows.Count + 1), temp[0], temp[1], temp[2]);
                    temp.Clear();
                }

            }
            //this.ProgressBar.Value = 1;
        }

        private void button6_Click(object sender, EventArgs e)
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
                for (i = 0; i < ZReal.Count; i++)
                {
                    Gamma.Add(Math.Pow(Math.Sqrt(ZReal[i] * ZReal[i] + ZIm[i] * ZIm[i]), -2));
                }
            }

            double[,] a = new double[2*ZReal.Count, 2 * ZReal.Count];
            double[,] ab = new double[2 * ZReal.Count, 2 * ZReal.Count];


            double BestLam = 1;
            double lambda = 1;
            List<double> NeighErCheb = new List<double>();
            List<double> NeighErQuadratic = new List<double>();
            List<double> ExactErCheb = new List<double>();
            List<double> ExactERQuadratic = new List<double>();
            List<double> ExactErRel = new List<double>();

            double[,] g;
            double[,] gb;

            double temp1, temp2;
            double[,] RightSide;

            double Lim, leftLim;
            try
            {
                leftLim = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                leftLim = 0;
            }
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
            while (lambda > 0.0000000000001)
            {
                for (i = 0; i < ZReal.Count; i++)
                {
                    for (j = 0; j < ZReal.Count; j++)
                    {
                        a[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        ab[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    }
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    for (j = ZReal.Count; j < 2*ZReal.Count; j++)
                    {
                        if (ZReal.Count-i == j)
                            continue;
                        a[i, j] = Math.Log(Omega[i]/ Omega[j- ZReal.Count]) * ((Omega[j- ZReal.Count] * Gamma[i]) / (2 * (Omega[i]* Omega[i] - Omega[j- ZReal.Count] * Omega[j - ZReal.Count])));
                        ab[i, j] = Math.Log(Omega[i] / Omega[j- ZReal.Count]) * ((Omega[j- ZReal.Count] * Gamma[i]) / (2 * (Omega[i] * Omega[i] - Omega[j- ZReal.Count] * Omega[j - ZReal.Count])));
                    }
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    a[i, ZReal.Count+i] = Gamma[i] / (2*Omega[i]);
                }
                //////
                for (i = ZReal.Count; i < 2*ZReal.Count; i++)
                {
                    for (j = 0; j < ZReal.Count; j++)
                    {
                        if (i-ZReal.Count == j)
                            continue;
                        a[i, j] = Math.Log(Omega[i- ZReal.Count] / Omega[j]) * ((Omega[i- ZReal.Count] * Gamma[i- ZReal.Count]) / (2 * (Omega[i- ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                        ab[i, j] = Math.Log(Omega[i- ZReal.Count] / Omega[j]) * ((Omega[i- ZReal.Count] * Gamma[i- ZReal.Count]) / (2 * (Omega[i- ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                    }
                }
                for (i = ZReal.Count; i < 2 * ZReal.Count; i++)
                {
                    for (j = ZReal.Count; j < 2 * ZReal.Count; j++)
                    {
                        a[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2 *(Omega[i - ZReal.Count] + Omega[j - ZReal.Count]));
                        ab[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2  * (Omega[i - ZReal.Count] + Omega[j - ZReal.Count]));
                    }
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    a[i + ZReal.Count,i] = Gamma[i] / (2*Omega[i]);
                }
                //////
                for (i = 0; i < 2*ZReal.Count; i++)
                {
                    a[i, i] +=lambda;
                    ab[i, i]+= 2 * lambda;
                }
                //////
                RightSide = new double[2*ZReal.Count, 1];
                for (i = 0; i < ZReal.Count; i++)
                {
                    RightSide[i, 0] = Gamma[i] * ZReal[i];
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    RightSide[i+ ZReal.Count, 0] = Gamma[i] * ZIm[i];
                }
                g = Matrixes.Solve(a, RightSide);
                gb = Matrixes.Solve(ab, RightSide);

                chart4.Series[0].Points.Clear();
                chart4.Series[1].Points.Clear();
                //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);

                double MaxDifferenceNeigb = 0;
                double MaxDifferenceExact = 0;
                double MaxDifferenceExactRel = 0;
                double Sum1 = 0, Sum2 = 0;
                for (double tau = leftLim; tau < Lim; tau += step)
                {
                    //chart1.Series[0].Points.AddXY(tau, gt(tau));
                    //chart2.Series[0].Points.AddXY(tau, gt(tau));
                    temp1 = 0;
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        temp1 += g[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                    }
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        temp1 += (g[i+ ZReal.Count, 0]*Omega[i]*tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                    }
                    temp2 = 0;
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        temp2 += gb[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                    }
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        temp2 += (gb[i + ZReal.Count, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                    }
                    if (MaxDifferenceNeigb < Math.Abs(temp1 - temp2))
                    {
                        MaxDifferenceNeigb = Math.Abs(temp1 - temp2);
                    }
                    if (MaxDifferenceExact < Math.Abs(temp1 - gt(tau)))
                    {
                        MaxDifferenceExact = Math.Abs(temp1 - gt(tau));
                    }
                    if (gt(tau) != 0 && MaxDifferenceExactRel < Math.Abs((temp1 - gt(tau))) / gt(tau))
                    {
                        MaxDifferenceExactRel = Math.Abs((temp1 - gt(tau))) / gt(tau);
                    }
                    Sum1 += Math.Pow(temp1 - temp2, 2);
                    Sum2 += Math.Pow(temp1 - gt(tau), 2);

                    //chart1.Series[1].Points.AddXY(tau, temp1);
                    ///////
                }
                NeighErCheb.Add(MaxDifferenceNeigb);
                NeighErQuadratic.Add(Math.Sqrt(Sum1 / (Lim * 20)));
                ExactErCheb.Add(MaxDifferenceExact);
                ExactERQuadratic.Add(Math.Sqrt(Sum2 / (Lim * 20)));
                ExactErRel.Add(MaxDifferenceExactRel);
                ///////////////////////////////
                MaxDifferenceNeigb = 0;
                MaxDifferenceExact = 0;
                Sum1 = 0; Sum2 = 0;
                ///////////////////////
                if (checkBox1.Checked)
                {
                    textBox2.Text += ("Похибки для λ=" + lambda + ":" + Environment.NewLine);
                    textBox2.Text += ("  Макс для сусідів =" + NeighErCheb[NeighErCheb.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic[NeighErQuadratic.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Макс для точного =" + ExactErCheb[ExactErCheb.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Квадратична для точного =" + ExactERQuadratic[ExactERQuadratic.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Відносна дя точного =" + ExactErRel[ExactERQuadratic.Count - 1] + Environment.NewLine);
                }
                lambda /= 2;
            }
            int MinVal = NeighErCheb.FindIndex(x => x == NeighErCheb.Min());
            Console.WriteLine(MinVal + "   ");

            lambda = Math.Pow(2, -1 * MinVal);

            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    a[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    ab[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = ZReal.Count; j < 2 * ZReal.Count; j++)
                {
                    if (ZReal.Count - i == j)
                        continue;
                    a[i, j] = Math.Log(Omega[i] / Omega[j - ZReal.Count]) * ((Omega[j - ZReal.Count] * Gamma[i]) / (2 * (Omega[i] * Omega[i] - Omega[j - ZReal.Count] * Omega[j - ZReal.Count])));
                    ab[i, j] = Math.Log(Omega[i] / Omega[j - ZReal.Count]) * ((Omega[j - ZReal.Count] * Gamma[i]) / (2 * (Omega[i] * Omega[i] - Omega[j - ZReal.Count] * Omega[j - ZReal.Count])));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                a[i, ZReal.Count + i] = Gamma[i] / (2 * Omega[i]);
            }
            //////
            for (i = ZReal.Count; i < 2 * ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    if (i - ZReal.Count == j)
                        continue;
                    a[i, j] = Math.Log(Omega[i - ZReal.Count] / Omega[j]) * ((Omega[i - ZReal.Count] * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                    ab[i, j] = Math.Log(Omega[i - ZReal.Count] / Omega[j]) * ((Omega[i - ZReal.Count] * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                }
            }
            for (i = ZReal.Count; i < 2 * ZReal.Count; i++)
            {
                for (j = ZReal.Count; j < 2 * ZReal.Count; j++)
                {
                    a[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2 * (Omega[i- ZReal.Count] + Omega[j - ZReal.Count]));
                    ab[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] + Omega[j - ZReal.Count]));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                a[i + ZReal.Count, i] = Gamma[i] / (2 * Omega[i]);
            }
            //////
            for (i = 0; i < 2 * ZReal.Count; i++)
            {
                a[i, i] += lambda;
                ab[i, i] += 2 * lambda;
            }
            //////
            RightSide = new double[2*ZReal.Count, 1];
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i, 0] = Gamma[i] * ZReal[i];
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i + ZReal.Count, 0] =  Gamma[i] * ZIm[i];
            }
            g = Matrixes.Solve(a, RightSide);
            gb = Matrixes.Solve(ab, RightSide);

            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();
            //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);

            chart4.ChartAreas[0].AxisX.Minimum = leftLim;
            for (double tau = leftLim; tau < Lim; tau += step)
            {
                chart4.Series[0].Points.AddXY(tau, gt(tau));
                temp1 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp1 += g[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp1 += (g[i + ZReal.Count, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                temp2 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp2 += gb[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp2 += (gb[i + ZReal.Count, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                chart4.Series[1].Points.AddXY(tau, temp1);
                ///////

            }

            textBox2.Text += ("Похибки для оптимального λ(Real)=" + lambda + ":" + Environment.NewLine);
            textBox2.Text += ("  Макс для сусідів =" + NeighErCheb[MinVal] + Environment.NewLine);
            textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic[MinVal] + Environment.NewLine);
            textBox2.Text += ("  Макс для точного =" + ExactErCheb[MinVal] + Environment.NewLine);
            textBox2.Text += ("  Квалратична для точного =" + ExactERQuadratic[MinVal] + Environment.NewLine);
            textBox2.Text += ("  Відносна дя точного =" + ExactErRel[MinVal] + Environment.NewLine);
        }

        private void button7_Click(object sender, EventArgs e)
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
                for (i = 0; i < ZReal.Count; i++)
                {
                    Gamma.Add(Math.Pow(Math.Sqrt(ZReal[i] * ZReal[i] + ZIm[i] * ZIm[i]), -2));
                }
            }

            double[,] a = new double[2 * ZReal.Count, 2 * ZReal.Count];
            double[,] ab = new double[2 * ZReal.Count, 2 * ZReal.Count];


            double BestLam = 1;
            double lambda1 = 1;
            double lambda2 = 2;
            List<List<double>> NeighErCheb = new List<List<double>>();
            List<List<double>> NeighErQuadratic = new List<List<double>>();
            List<List<double>> ExactErCheb = new List<List<double>>();
            List<List<double>> ExactERQuadratic = new List<List<double>>();
            List<List<double>> ExactErRel = new List<List<double>>();

            double[,] g;
            double[,] gb;

            double temp1, temp2;
            double[,] RightSide;

            double Lim, leftLim;
            try
            {
                leftLim = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                leftLim = 0;
            }
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
            double Norm = 0;
            while (lambda1 > 0.0000000000001)
            {
                while (lambda2 > 0.0000000000001)
                {
                    NeighErCheb.Add(new List<double>());
                    NeighErQuadratic.Add(new List<double>());
                    ExactErCheb.Add(new List<double>());
                    ExactERQuadratic.Add(new List<double>());
                    ExactErRel.Add(new List<double>());
                    ////////
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        for (j = 0; j < ZReal.Count; j++)
                        {
                            a[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                            ab[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        }
                    }
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        for (j = ZReal.Count; j < 2 * ZReal.Count; j++)
                        {
                            if (ZReal.Count - i == j)
                                continue;
                            a[i, j] = Math.Log(Omega[i] / Omega[j - ZReal.Count]) * ((Omega[j - ZReal.Count] * Gamma[i]) / (2 * (Omega[i] * Omega[i] - Omega[j - ZReal.Count] * Omega[j - ZReal.Count])));
                            ab[i, j] = Math.Log(Omega[i] / Omega[j - ZReal.Count]) * ((Omega[j - ZReal.Count] * Gamma[i]) / (2 * (Omega[i] * Omega[i] - Omega[j - ZReal.Count] * Omega[j - ZReal.Count])));
                        }
                    }
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        a[i, ZReal.Count + i] = Gamma[i] / (2 * Omega[i]);
                    }
                    //////
                    for (i = ZReal.Count; i < 2 * ZReal.Count; i++)
                    {
                        for (j = 0; j < ZReal.Count; j++)
                        {
                            if (i - ZReal.Count == j)
                                continue;
                            a[i, j] = Math.Log(Omega[i - ZReal.Count] / Omega[j]) * ((Omega[i - ZReal.Count] * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                            ab[i, j] = Math.Log(Omega[i - ZReal.Count] / Omega[j]) * ((Omega[i - ZReal.Count] * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                        }
                    }
                    for (i = ZReal.Count; i < 2 * ZReal.Count; i++)
                    {
                        for (j = ZReal.Count; j < 2 * ZReal.Count; j++)
                        {
                            a[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] + Omega[j - ZReal.Count]));
                            ab[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2  * (Omega[i - ZReal.Count] + Omega[j - ZReal.Count]));
                        }
                    }
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        a[i + ZReal.Count, i] = Gamma[i] / (2 * Omega[i]);
                    }
                    //////
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        a[i, i] += lambda1;
                        ab[i, i] += 2 * lambda1;
                    }
                    for (i = ZReal.Count; i < 2*ZReal.Count; i++)
                    {
                        a[i, i] += lambda2;
                        ab[i, i] += 2 * lambda2;
                    }
                    //////
                    RightSide = new double[2 * ZReal.Count, 1];
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        RightSide[i, 0] = Gamma[i] * ZReal[i];
                    }
                    for (i = 0; i < ZReal.Count; i++)
                    {
                        RightSide[i + ZReal.Count, 0] = Gamma[i] * ZIm[i];
                    }
                    g = Matrixes.Solve(a, RightSide);
                    gb = Matrixes.Solve(ab, RightSide);

                    chart4.Series[0].Points.Clear();
                    chart4.Series[1].Points.Clear();
                    //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);

                    double MaxDifferenceNeigb = 0;
                    double MaxDifferenceExact = 0;
                    double MaxDifferenceExactRel = 0;
                    double Sum1 = 0, Sum2 = 0;
                    Norm = 0;
                    for (double tau = leftLim; tau < Lim; tau += step)
                    {
                        if (Norm < Math.Abs(gt(tau)))
                        {
                            Norm = Math.Abs(gt(tau));
                        }
                    }
                    for (double tau = leftLim; tau < Lim; tau += step)
                    {
                        //chart1.Series[0].Points.AddXY(tau, gt(tau));
                        //chart2.Series[0].Points.AddXY(tau, gt(tau));
                        temp1 = 0;
                        for (i = 0; i < ZReal.Count; i++)
                        {
                            temp1 += g[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                        }
                        for (i = 0; i < ZReal.Count; i++)
                        {
                            temp1 += (g[i + ZReal.Count, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                        }
                        temp2 = 0;
                        for (i = 0; i < ZReal.Count; i++)
                        {
                            temp2 += gb[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                        }
                        for (i = 0; i < ZReal.Count; i++)
                        {
                            temp2 += (gb[i + ZReal.Count, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                        }
                        if (MaxDifferenceNeigb < Math.Abs(temp1 - temp2))
                        {
                            MaxDifferenceNeigb = Math.Abs(temp1 - temp2);
                        }
                        if (MaxDifferenceExact < Math.Abs(temp1 - gt(tau)))
                        {
                            MaxDifferenceExact = Math.Abs(temp1 - gt(tau));
                        }
                        if (gt(tau) != 0 && MaxDifferenceExactRel < Math.Abs((temp1 - gt(tau))) / Norm)
                        {
                            MaxDifferenceExactRel = Math.Abs((temp1 - gt(tau))) / Norm;
                        }
                        Sum1 += Math.Pow(temp1 - temp2, 2);
                        Sum2 += Math.Pow(temp1 - gt(tau), 2);

                        //chart1.Series[1].Points.AddXY(tau, temp1);
                        ///////
                    }
                    NeighErCheb[NeighErCheb.Count-1].Add(MaxDifferenceNeigb);
                    NeighErQuadratic[NeighErCheb.Count - 1].Add(Math.Sqrt(Sum1 / (Lim * 20)));
                    ExactErCheb[NeighErCheb.Count - 1].Add(MaxDifferenceExact);
                    ExactERQuadratic[NeighErCheb.Count - 1].Add(Math.Sqrt(Sum2 / (Lim * 20)));
                    ExactErRel[NeighErCheb.Count - 1].Add(MaxDifferenceExactRel);
                    ///////////////////////////////
                    MaxDifferenceNeigb = 0;
                    MaxDifferenceExact = 0;
                    Sum1 = 0; Sum2 = 0;
                    ///////////////////////
                    if (checkBox1.Checked)
                    {
                        textBox2.Text += ("Похибки для λ1=" + lambda1 + ", λ2= "+lambda2+":" + Environment.NewLine);
                        textBox2.Text += ("  Макс для сусідів =" + NeighErCheb[NeighErCheb.Count - 1] + Environment.NewLine);
                        textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic[NeighErQuadratic.Count - 1] + Environment.NewLine);
                        textBox2.Text += ("  Макс для точного =" + ExactErCheb[ExactErCheb.Count - 1] + Environment.NewLine);
                        textBox2.Text += ("  Квадратична для точного =" + ExactERQuadratic[ExactERQuadratic.Count - 1] + Environment.NewLine);
                        textBox2.Text += ("  Відносна дя точного =" + ExactErRel[ExactERQuadratic.Count - 1] + Environment.NewLine);
                    }
                    lambda2 /= 2;
                }
                lambda1 /= 2;
            }
            var lol = FinMinVals(ExactErCheb);
            int MinVal1 = Convert.ToInt32(lol.Item1), MinVal2 = Convert.ToInt32(lol.Item2);
            Console.WriteLine(MinVal1 + "   " + MinVal2);

            lambda1 = Math.Pow(2, -1 * MinVal1);
            lambda2 = Math.Pow(2, -1 * MinVal2);

            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    a[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    ab[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = ZReal.Count; j < 2 * ZReal.Count; j++)
                {
                    if (ZReal.Count - i == j)
                        continue;
                    a[i, j] = Math.Log(Omega[i] / Omega[j - ZReal.Count]) * ((Omega[j - ZReal.Count] * Gamma[i]) / (2 * (Omega[i] * Omega[i] - Omega[j - ZReal.Count] * Omega[j - ZReal.Count])));
                    ab[i, j] = Math.Log(Omega[i] / Omega[j - ZReal.Count]) * ((Omega[j - ZReal.Count] * Gamma[i]) / (2 * (Omega[i] * Omega[i] - Omega[j - ZReal.Count] * Omega[j - ZReal.Count])));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                a[i, ZReal.Count + i] = Gamma[i] / (2 * Omega[i]);
            }
            //////
            for (i = ZReal.Count; i < 2 * ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    if (i - ZReal.Count == j)
                        continue;
                    a[i, j] = Math.Log(Omega[i - ZReal.Count] / Omega[j]) * ((Omega[i - ZReal.Count] * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                    ab[i, j] = Math.Log(Omega[i - ZReal.Count] / Omega[j]) * ((Omega[i - ZReal.Count] * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] * Omega[i - ZReal.Count] - Omega[j] * Omega[j])));
                }
            }
            for (i = ZReal.Count; i < 2 * ZReal.Count; i++)
            {
                for (j = ZReal.Count; j < 2 * ZReal.Count; j++)
                {
                    a[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] + Omega[j - ZReal.Count]));
                    ab[i, j] = (Math.PI * Gamma[i - ZReal.Count]) / (2 * (Omega[i - ZReal.Count] + Omega[j - ZReal.Count]));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                a[i + ZReal.Count, i] = Gamma[i] / (2 * Omega[i]);
            }
            //////
            for (i = 0; i < ZReal.Count; i++)
            {
                a[i, i] += lambda1;
                ab[i, i] += 2 * lambda1;
            }
            for (i = ZReal.Count; i < 2*ZReal.Count; i++)
            {
                a[i, i] += lambda2;
                ab[i, i] += 2 * lambda2;
            }
            //////
            RightSide = new double[2 * ZReal.Count, 1];
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i, 0] = Gamma[i] * ZReal[i];
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                RightSide[i + ZReal.Count, 0] = Gamma[i] * ZIm[i];
            }
            g = Matrixes.Solve(a, RightSide);
            gb = Matrixes.Solve(ab, RightSide);

            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();
            //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);

            chart4.ChartAreas[0].AxisX.Minimum = leftLim;
            for (double tau = leftLim; tau < Lim; tau += step)
            {
                chart4.Series[0].Points.AddXY(tau, gt(tau));
                temp1 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp1 += g[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp1 += (g[i + ZReal.Count, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                temp2 = 0;
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp2 += gb[i, 0] / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    temp2 += (gb[i + ZReal.Count, 0] * Omega[i] * tau) / (1 + Omega[i] * Omega[i] * tau * tau);
                }
                chart4.Series[1].Points.AddXY(tau, temp1);
                ///////

            }

            textBox2.Text += ("Похибки для оптимального λ1=" + lambda1 + ",λ2="+lambda2+":"+ Environment.NewLine);
            textBox2.Text += ("  Макс для сусідів =" + NeighErCheb[MinVal1][MinVal2] + Environment.NewLine);
            textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic[MinVal1][MinVal2] + Environment.NewLine);
            textBox2.Text += ("  Макс для точного =" + ExactErCheb[MinVal1][MinVal2] + Environment.NewLine);
            textBox2.Text += ("  Квалратична для точного =" + ExactERQuadratic[MinVal1][MinVal2] + Environment.NewLine);
            textBox2.Text += ("  Відносна дя точного =" + ExactErRel[MinVal1][MinVal2] + Environment.NewLine);
        }

        Tuple<double, double> FinMinVals(List<List<double>> Target)
        {
            double Min = double.MaxValue;
            double mini=0, minj=0;
            int i, j;
            for (i=0; i < Target.Count; i++)
            {
                for (j=0; j < Target[i].Count;j++)
                {
                    if (Target[i][j] < Min)
                    {
                        Min = Target[i][j];
                        mini = i;
                        minj = j;
                    }
                }
            }
            return new Tuple<double, double>(mini, minj);
        }

        private void button8_Click(object sender, EventArgs e)
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
                for (i = 0; i < ZReal.Count; i++)
                {
                    Gamma.Add(Math.Pow(Math.Sqrt(ZReal[i] * ZReal[i] + ZIm[i] * ZIm[i]), -2));
                }
            }

            double[,] a1 = new double[ZReal.Count, ZReal.Count];
            double[,] a2 = new double[ZReal.Count, ZReal.Count];
            double[,] ab1 = new double[ZReal.Count, ZReal.Count];
            double[,] ab2 = new double[ZReal.Count, ZReal.Count];


            double lambda = 16;
            List<double> NeighErCheb = new List<double>();
            List<double> NeighErQuadratic = new List<double>();
            List<double> ExactErCheb = new List<double>();
            List<double> ExactERQuadratic = new List<double>();
            List<double> NeighErRel = new List<double>();
            List<double> ExactErRel = new List<double>();


            List<double> NeighErCheb2 = new List<double>();
            List<double> NeighErQuadratic2 = new List<double>();
            List<double> ExactErCheb2 = new List<double>();
            List<double> ExactERQuadratic2 = new List<double>();
            List<double> NeighErRel2 = new List<double>();
            List<double> ExactErRel2 = new List<double>();

            double[,] g;
            double[,] g2;
            double[,] gb;
            double[,] gb2;

            double temp1, temp2;
            double[,] RightSide;

            double Lim, leftLim;
            try
            {
                leftLim = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                leftLim = 0;
            }
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
            double Norm;
            while (lambda > 0.0000000000001)
            {
                for (i = 0; i < ZReal.Count; i++)
                {
                    for (j = 0; j < ZReal.Count; j++)
                    {
                        a1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        a2[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        ab1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                        ab2[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    }
                }
                for (i = 0; i < ZReal.Count; i++)
                {
                    a1[i, i] = (Math.PI / (4 * Omega[i])) + lambda;
                    a2[i, i] = (Math.PI / (4 * Omega[i])) + lambda;
                    ab1[i, i] = (Math.PI / (4 * Omega[i])) + 2 * lambda;
                    ab2[i, i] = (Math.PI / (4 * Omega[i])) + 2 * lambda;
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
                    RightSide[i, 0] = Gamma[i] * ZIm[i];
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
                double MaxDifferenceNeigbRel = 0;
                double MaxDifferenceExactRel = 0;
                double Sum1 = 0, Sum2 = 0;
                chart1.ChartAreas[0].AxisX.Minimum = leftLim;
                chart2.ChartAreas[0].AxisX.Minimum = leftLim;
                Norm = 0;
                for (double tau = leftLim; tau < Lim; tau += step)
                {
                    if (Norm < Math.Abs(gt(tau)))
                    {
                        Norm = Math.Abs(gt(tau));
                    }
                }
                for (double tau = leftLim; tau < Lim; tau += step)
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
                    ///////
                    if (gt(tau) != 0 && MaxDifferenceExactRel < Math.Abs((temp1 - gt(tau))) / Norm)
                    {
                        MaxDifferenceExactRel = Math.Abs((temp1 - gt(tau))) / Norm;
                    }
                    ///////
                    Sum1 += Math.Pow(temp1 - temp2, 2);
                    Sum2 += Math.Pow(temp1 - gt(tau), 2);

                    //chart1.Series[1].Points.AddXY(tau, temp1);
                    ///////
                }
                NeighErCheb.Add(MaxDifferenceNeigb);
                NeighErQuadratic.Add(Math.Sqrt(Sum1 / (Lim * 20)));
                ExactErCheb.Add(MaxDifferenceExact);
                ExactERQuadratic.Add(Math.Sqrt(Sum2 / (Lim * 20)));
                ExactErRel.Add(MaxDifferenceExactRel);
                ///////////////////////////////
                MaxDifferenceExactRel = 0;
                MaxDifferenceNeigb = 0;
                MaxDifferenceExact = 0;
                Sum1 = 0; Sum2 = 0;
                for (double tau = leftLim; tau < Lim; tau += step)
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
                    /////
                    if (gt(tau) != 0 && MaxDifferenceExactRel < Math.Abs((temp1 - gt(tau))) / Norm)
                    {
                        MaxDifferenceExactRel = Math.Abs((temp1 - gt(tau))) / Norm;
                    }                    /////
                    Sum1 += Math.Pow(temp1 - temp2, 2);
                    Sum2 += Math.Pow(temp1 - gt(tau), 2);

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
                    if (MaxDifferenceNeigb < Math.Abs(temp1 - temp2))
                    {
                        MaxDifferenceNeigb = Math.Abs(temp1 - temp2);
                    }
                    if (MaxDifferenceExact < Math.Abs(temp1 - gt(tau)))
                    {
                        MaxDifferenceExact = Math.Abs(temp1 - gt(tau));
                    }
                    Sum1 += Math.Pow(temp1 - temp2, 2);
                    Sum2 += Math.Pow(temp1 - gt(tau), 2);
                    ///chart2.Series[1].Points.AddXY(tau, temp1);
                }
                NeighErCheb2.Add(MaxDifferenceNeigb);
                NeighErQuadratic2.Add(Math.Sqrt(Sum1 / (Lim * 20)));
                ExactErCheb2.Add(MaxDifferenceExact);
                ExactERQuadratic2.Add(Math.Sqrt(Sum2 / (Lim * 20)));
                ExactErRel2.Add(MaxDifferenceExactRel);
                ///////////////////////
                if (checkBox1.Checked)
                {
                    textBox2.Text += ("Похибки для λ=" + lambda + ":" + Environment.NewLine);
                    textBox2.Text += ("  Макс для сусідів =" + NeighErCheb[NeighErCheb.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic[NeighErQuadratic.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Макс для точного =" + ExactErCheb[ExactErCheb.Count - 1] + Environment.NewLine);
                    textBox2.Text += ("  Квадратична для точного =" + ExactERQuadratic[ExactERQuadratic.Count - 1] + Environment.NewLine);
                }
                lambda /= 2;
            }
            int MinVal=-1;
            int MinVal2=-1;
            for (i = 3; i < NeighErCheb.Count; i++)
            {
                if (NeighErCheb[i] > NeighErCheb[i - 1])
                {
                    MinVal = i;
                    break;
                }
            }
            for (i =3; i < NeighErCheb2.Count;i++)
            {
                if (NeighErCheb2[i] > NeighErCheb2[i - 1])
                {
                    MinVal2 = i;
                    break;
                }
            }
            if (MinVal == -1)
            {
                MinVal = NeighErCheb.Count-1;
            }
            if (MinVal2 == -1)
            {
                MinVal2 = NeighErCheb.Count-1;
            }
            Console.WriteLine(MinVal + "   " + MinVal2);

            lambda = Math.Pow(2, -1 * MinVal);
            double lambda2 = Math.Pow(2, -1 * MinVal2);

            for (i = 0; i < ZReal.Count; i++)
            {
                for (j = 0; j < ZReal.Count; j++)
                {
                    a1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    a2[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    ab1[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                    ab2[i, j] = (Math.PI * Gamma[i]) / (2 * (Omega[i] + Omega[j]));
                }
            }
            for (i = 0; i < ZReal.Count; i++)
            {
                a1[i, i] = (Math.PI / (4 * Omega[i])) + lambda;
                a2[i, i] = (Math.PI / (4 * Omega[i])) + lambda2;
                ab1[i, i] = (Math.PI / (4 * Omega[i])) + 2 * lambda;
                ab2[i, i] = (Math.PI / (4 * Omega[i])) + 2 * lambda2;
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
                RightSide[i, 0] = Gamma[i] * ZIm[i];
            }
            g2 = Matrixes.Solve(a2, RightSide);
            gb2 = Matrixes.Solve(ab2, RightSide);

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            //Func<Func<double, double>, double> Win = Integrate(0, UpperBorder, step);
            Norm = 0;
            for (double tau = leftLim; tau < Lim; tau += step)
            {
                if (Norm < Math.Abs(gt(tau)))
                {
                    Norm = Math.Abs(gt(tau));
                }
            }
            for (double tau = leftLim; tau < Lim; tau += step)
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

            textBox2.Text += ("Похибки для оптимального λ(Real)=" + lambda + ":" + Environment.NewLine);
            textBox2.Text += ("  Макс для сусідів =" + NeighErCheb[MinVal] + Environment.NewLine);
            textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic[MinVal] + Environment.NewLine);
            textBox2.Text += ("  Макс для точного =" + ExactErCheb[MinVal] + Environment.NewLine);
            textBox2.Text += ("  Квадратична для точного =" + ExactERQuadratic[MinVal] + Environment.NewLine);
            textBox2.Text += ("Відносна для точного =" + ExactErRel[MinVal] + Environment.NewLine);

            textBox2.Text += ("Похибки для оптимального λ(Im)=" + lambda2 + ":" + Environment.NewLine);
            textBox2.Text += ("  Макс для сусідів =" + NeighErCheb2[MinVal2] + Environment.NewLine);
            textBox2.Text += ("  Квадратична для сусідів =" + NeighErQuadratic2[MinVal2] + Environment.NewLine);
            textBox2.Text += ("  Макс для точного =" + ExactErCheb2[MinVal2] + Environment.NewLine);
            textBox2.Text += ("  Квадратична для точного =" + ExactERQuadratic2[MinVal2] + Environment.NewLine);
            textBox2.Text += ("Відносна для точного =" + ExactErRel2[MinVal2] + Environment.NewLine);
        }
    }

}
