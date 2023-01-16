
namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lb_segment = new System.Windows.Forms.Label();
            this.lb_a = new System.Windows.Forms.Label();
            this.lb_b = new System.Windows.Forms.Label();
            this.lf_border = new System.Windows.Forms.TextBox();
            this.rh_border = new System.Windows.Forms.TextBox();
            this.lb_tabs = new System.Windows.Forms.Label();
            this.number_tab_points = new System.Windows.Forms.TextBox();
            this.lb_max = new System.Windows.Forms.Label();
            this.lb_miin = new System.Windows.Forms.Label();
            this.max_fun = new System.Windows.Forms.TextBox();
            this.min_fun = new System.Windows.Forms.TextBox();
            this.calculation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblLtPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rB_simpz_lfun = new System.Windows.Forms.RadioButton();
            this.rb_parametric_fun = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.const_a = new System.Windows.Forms.TextBox();
            this.label_par_d = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_reticle = new System.Windows.Forms.CheckBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tbLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_tab_gr = new System.Windows.Forms.TableLayoutPanel();
            this.bt_vubr_toch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataSet = new System.Data.DataSet();
            this.dataTable_fun = new System.Data.DataTable();
            this.dataColumn_x = new System.Data.DataColumn();
            this.dataColumn_y = new System.Data.DataColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tblLtPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tbLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel_tab_gr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_fun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_segment
            // 
            this.lb_segment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_segment.AutoSize = true;
            this.lb_segment.Location = new System.Drawing.Point(3, 28);
            this.lb_segment.Name = "lb_segment";
            this.lb_segment.Size = new System.Drawing.Size(240, 13);
            this.lb_segment.TabIndex = 0;
            this.lb_segment.Text = "Введіть межі зміни аргументу [a,b]";
            // 
            // lb_a
            // 
            this.lb_a.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_a.AutoSize = true;
            this.lb_a.Location = new System.Drawing.Point(17, 19);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(19, 13);
            this.lb_a.TabIndex = 1;
            this.lb_a.Text = "a=";
            // 
            // lb_b
            // 
            this.lb_b.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_b.AutoSize = true;
            this.lb_b.Location = new System.Drawing.Point(136, 19);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(19, 13);
            this.lb_b.TabIndex = 2;
            this.lb_b.Text = "b=";
            // 
            // lf_border
            // 
            this.lf_border.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lf_border.Location = new System.Drawing.Point(42, 16);
            this.lf_border.Name = "lf_border";
            this.lf_border.Size = new System.Drawing.Size(76, 20);
            this.lf_border.TabIndex = 3;
            this.lf_border.Click += new System.EventHandler(this.setActiveTextBox);
            this.lf_border.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPres);
            // 
            // rh_border
            // 
            this.rh_border.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rh_border.Location = new System.Drawing.Point(161, 16);
            this.rh_border.Name = "rh_border";
            this.rh_border.Size = new System.Drawing.Size(76, 20);
            this.rh_border.TabIndex = 4;
            this.rh_border.Click += new System.EventHandler(this.setActiveTextBox);
            this.rh_border.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPres);
            // 
            // lb_tabs
            // 
            this.lb_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tabs.AutoSize = true;
            this.lb_tabs.Location = new System.Drawing.Point(3, 113);
            this.lb_tabs.Name = "lb_tabs";
            this.lb_tabs.Size = new System.Drawing.Size(240, 13);
            this.lb_tabs.TabIndex = 5;
            this.lb_tabs.Text = "Введіть кількість точок табулювання";
            // 
            // number_tab_points
            // 
            this.number_tab_points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.number_tab_points.Location = new System.Drawing.Point(3, 136);
            this.number_tab_points.Name = "number_tab_points";
            this.number_tab_points.Size = new System.Drawing.Size(240, 20);
            this.number_tab_points.TabIndex = 6;
            this.number_tab_points.Click += new System.EventHandler(this.setActiveTextBox);
            this.number_tab_points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumPointTextBoxKeyPres);
            // 
            // lb_max
            // 
            this.lb_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_max.AutoSize = true;
            this.lb_max.Location = new System.Drawing.Point(3, 336);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(240, 13);
            this.lb_max.TabIndex = 9;
            this.lb_max.Text = "Максимум функції на проміжку:";
            // 
            // lb_miin
            // 
            this.lb_miin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_miin.AutoSize = true;
            this.lb_miin.Location = new System.Drawing.Point(3, 398);
            this.lb_miin.Name = "lb_miin";
            this.lb_miin.Size = new System.Drawing.Size(240, 13);
            this.lb_miin.TabIndex = 10;
            this.lb_miin.Text = "Мінімум функції на прміжку:";
            // 
            // max_fun
            // 
            this.max_fun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.max_fun.Location = new System.Drawing.Point(3, 363);
            this.max_fun.Name = "max_fun";
            this.max_fun.Size = new System.Drawing.Size(240, 20);
            this.max_fun.TabIndex = 11;
            // 
            // min_fun
            // 
            this.min_fun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.min_fun.Location = new System.Drawing.Point(3, 428);
            this.min_fun.Name = "min_fun";
            this.min_fun.Size = new System.Drawing.Size(240, 20);
            this.min_fun.TabIndex = 12;
            // 
            // calculation
            // 
            this.calculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calculation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.calculation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calculation.Location = new System.Drawing.Point(3, 280);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(240, 41);
            this.calculation.TabIndex = 13;
            this.calculation.Text = "Побудувати графік";
            this.calculation.UseVisualStyleBackColor = false;
            this.calculation.Click += new System.EventHandler(this.Сalculation);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(237, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Format = "F2";
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Format = "F2";
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(252, 3);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DarkOrange;
            series1.Legend = "Legend1";
            series1.Name = "(x+2)^(2/3)-(x-2)^(2/3)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.MediumSeaGreen;
            series2.Legend = "Legend1";
            series2.Name = "X(t)=d/(cos(t))^3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Gold;
            series3.Legend = "Legend1";
            series3.Name = "Y(t)=d*(tg(t))^3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.DarkBlue;
            series4.Legend = "Legend1";
            series4.Name = "Y(X)";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "X(Y)";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(337, 450);
            this.chart.TabIndex = 0;
            this.chart.Text = "\'\'";
            // 
            // tblLtPanel1
            // 
            this.tblLtPanel1.ColumnCount = 1;
            this.tblLtPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLtPanel1.Controls.Add(this.lb_segment, 0, 1);
            this.tblLtPanel1.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblLtPanel1.Controls.Add(this.lb_tabs, 0, 3);
            this.tblLtPanel1.Controls.Add(this.number_tab_points, 0, 4);
            this.tblLtPanel1.Controls.Add(this.rB_simpz_lfun, 0, 6);
            this.tblLtPanel1.Controls.Add(this.rb_parametric_fun, 0, 7);
            this.tblLtPanel1.Controls.Add(this.max_fun, 0, 11);
            this.tblLtPanel1.Controls.Add(this.lb_max, 0, 10);
            this.tblLtPanel1.Controls.Add(this.calculation, 0, 9);
            this.tblLtPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tblLtPanel1.Controls.Add(this.lb_miin, 0, 12);
            this.tblLtPanel1.Controls.Add(this.min_fun, 0, 13);
            this.tblLtPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tblLtPanel1.Controls.Add(this.cb_reticle, 0, 5);
            this.tblLtPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLtPanel1.Location = new System.Drawing.Point(0, 0);
            this.tblLtPanel1.Name = "tblLtPanel1";
            this.tblLtPanel1.RowCount = 14;
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.654845F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.3097F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.788259F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.780533F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.822989F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.822989F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.164703F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31432F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.23356F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.23356F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.23356F));
            this.tblLtPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.23356F));
            this.tblLtPanel1.Size = new System.Drawing.Size(246, 456);
            this.tblLtPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.26584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.35801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.59247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78369F));
            this.tableLayoutPanel1.Controls.Add(this.lf_border, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_b, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rh_border, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_a, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 52);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // rB_simpz_lfun
            // 
            this.rB_simpz_lfun.AutoSize = true;
            this.rB_simpz_lfun.Location = new System.Drawing.Point(3, 196);
            this.rB_simpz_lfun.Name = "rB_simpz_lfun";
            this.rB_simpz_lfun.Size = new System.Drawing.Size(138, 17);
            this.rB_simpz_lfun.TabIndex = 14;
            this.rB_simpz_lfun.TabStop = true;
            this.rB_simpz_lfun.Text = "(x+2)^(2/3)−(x−2)^(2/3).";
            this.rB_simpz_lfun.UseVisualStyleBackColor = true;
            // 
            // rb_parametric_fun
            // 
            this.rb_parametric_fun.AutoSize = true;
            this.rb_parametric_fun.Location = new System.Drawing.Point(3, 221);
            this.rb_parametric_fun.Name = "rb_parametric_fun";
            this.rb_parametric_fun.Size = new System.Drawing.Size(180, 17);
            this.rb_parametric_fun.TabIndex = 15;
            this.rb_parametric_fun.TabStop = true;
            this.rb_parametric_fun.Text = "Параметрично задана функція";
            this.rb_parametric_fun.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.const_a, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_par_d, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 246);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 25);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // const_a
            // 
            this.const_a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.const_a.Location = new System.Drawing.Point(123, 3);
            this.const_a.Name = "const_a";
            this.const_a.Size = new System.Drawing.Size(114, 20);
            this.const_a.TabIndex = 4;
            this.const_a.Click += new System.EventHandler(this.setActiveTextBox);
            this.const_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPres);
            // 
            // label_par_d
            // 
            this.label_par_d.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_par_d.AutoSize = true;
            this.label_par_d.Location = new System.Drawing.Point(47, 6);
            this.label_par_d.Name = "label_par_d";
            this.label_par_d.Size = new System.Drawing.Size(70, 13);
            this.label_par_d.TabIndex = 5;
            this.label_par_d.Text = "Значення d=";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 20);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 16);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // cb_reticle
            // 
            this.cb_reticle.AllowDrop = true;
            this.cb_reticle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_reticle.AutoSize = true;
            this.cb_reticle.Location = new System.Drawing.Point(3, 168);
            this.cb_reticle.Name = "cb_reticle";
            this.cb_reticle.Size = new System.Drawing.Size(240, 17);
            this.cb_reticle.TabIndex = 18;
            this.cb_reticle.Text = "Вимкнути сітку на графіку";
            this.cb_reticle.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer.Panel1.Controls.Add(this.tblLtPanel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tbLayoutPanel2);
            this.splitContainer.Size = new System.Drawing.Size(842, 456);
            this.splitContainer.SplitterDistance = 246;
            this.splitContainer.TabIndex = 15;
            // 
            // tbLayoutPanel2
            // 
            this.tbLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbLayoutPanel2.ColumnCount = 2;
            this.tbLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.09559F));
            this.tbLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.90441F));
            this.tbLayoutPanel2.Controls.Add(this.chart, 1, 0);
            this.tbLayoutPanel2.Controls.Add(this.tableLayoutPanel_tab_gr, 0, 0);
            this.tbLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutPanel2.Name = "tbLayoutPanel2";
            this.tbLayoutPanel2.RowCount = 1;
            this.tbLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPanel2.Size = new System.Drawing.Size(592, 456);
            this.tbLayoutPanel2.TabIndex = 16;
            // 
            // tableLayoutPanel_tab_gr
            // 
            this.tableLayoutPanel_tab_gr.ColumnCount = 1;
            this.tableLayoutPanel_tab_gr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_tab_gr.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel_tab_gr.Controls.Add(this.bt_vubr_toch, 0, 1);
            this.tableLayoutPanel_tab_gr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_tab_gr.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_tab_gr.Name = "tableLayoutPanel_tab_gr";
            this.tableLayoutPanel_tab_gr.RowCount = 2;
            this.tableLayoutPanel_tab_gr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.82143F));
            this.tableLayoutPanel_tab_gr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17857F));
            this.tableLayoutPanel_tab_gr.Size = new System.Drawing.Size(243, 450);
            this.tableLayoutPanel_tab_gr.TabIndex = 19;
            // 
            // bt_vubr_toch
            // 
            this.bt_vubr_toch.BackColor = System.Drawing.Color.Silver;
            this.bt_vubr_toch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_vubr_toch.Location = new System.Drawing.Point(3, 407);
            this.bt_vubr_toch.Name = "bt_vubr_toch";
            this.bt_vubr_toch.Size = new System.Drawing.Size(237, 40);
            this.bt_vubr_toch.TabIndex = 1;
            this.bt_vubr_toch.Text = "Побудувати графік по точках";
            this.bt_vubr_toch.UseVisualStyleBackColor = false;
            this.bt_vubr_toch.Click += new System.EventHandler(this.bt_vubr_toch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.xy";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable_fun});
            // 
            // dataTable_fun
            // 
            this.dataTable_fun.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_x,
            this.dataColumn_y});
            this.dataTable_fun.TableName = "Table_func";
            // 
            // dataColumn_x
            // 
            this.dataColumn_x.Caption = "x";
            this.dataColumn_x.ColumnName = "x";
            this.dataColumn_x.DataType = typeof(double);
            // 
            // dataColumn_y
            // 
            this.dataColumn_y.ColumnName = "y";
            this.dataColumn_y.DataType = typeof(double);
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Table_func";
            this.bindingSource.DataSource = this.dataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(842, 456);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.Text = "Графік функцій. Пасічняк";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tblLtPanel1.ResumeLayout(false);
            this.tblLtPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tbLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel_tab_gr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_fun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_segment;
        private System.Windows.Forms.Label lb_a;
        private System.Windows.Forms.Label lb_b;
        private System.Windows.Forms.TextBox lf_border;
        private System.Windows.Forms.TextBox rh_border;
        private System.Windows.Forms.Label lb_tabs;
        private System.Windows.Forms.TextBox number_tab_points;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Label lb_miin;
        private System.Windows.Forms.TextBox max_fun;
        private System.Windows.Forms.TextBox min_fun;
        private System.Windows.Forms.Button calculation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tblLtPanel1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tbLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rB_simpz_lfun;
        private System.Windows.Forms.RadioButton rb_parametric_fun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox const_a;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_reticle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_tab_gr;
        private System.Windows.Forms.Button bt_vubr_toch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dataTable_fun;
        private System.Data.DataColumn dataColumn_x;
        private System.Data.DataColumn dataColumn_y;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label label_par_d;
    }
}

