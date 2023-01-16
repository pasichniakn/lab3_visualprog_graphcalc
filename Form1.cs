using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace lab3
{
    public partial class Form1 : Form
    {
        private TextBox ActiveTextBox;
       //BinaryFormatter binaryFormatter = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();
        }

        void Sitka()
        {
            if (cb_reticle.Checked == true)
            {
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
            if (cb_reticle.Checked == false)
            {
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
        }

        void Clear_ch()
        {
            this.chart.Series[0].Points.Clear();
            this.chart.Series[1].Points.Clear();
            this.chart.Series[2].Points.Clear();
            this.chart.Series[3].Points.Clear();
            this.chart.Series[4].Points.Clear();
        }
        void Axis() {
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].CursorX.AutoScroll = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart.ChartAreas[0].CursorY.AutoScroll = true;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            chart.ChartAreas[0].AxisX.Title = "X";
            chart.ChartAreas[0].AxisY.Title = "Y";

            chart.ChartAreas[0].AxisX.LineWidth = 2;
            chart.ChartAreas[0].AxisY.LineWidth = 2;

            chart.ChartAreas[0].Position.Auto = false;
            chart.ChartAreas[0].Position.X = 5;

            chart.ChartAreas[0].Position.Y = 40;
            chart.ChartAreas[0].Position.Width = 85;
            chart.ChartAreas[0].Position.Height = 85;

            chart.ChartAreas[0].AxisX.Crossing = 0;
            chart.ChartAreas[0].AxisY.Crossing = 0;

            chart.ChartAreas[0].AxisY.ArrowStyle = AxisArrowStyle.Lines;
            chart.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Lines;
        }

        public double[] Fun_X(double a, double b, int k)
        {
            double h = ((b - a) / (k - 1));
            double[] X_val = new double[k];


            X_val[0] = a;
            X_val[k - 1] = b;

            for (int i = 0; i <= k - 2; i++)
            {
                X_val[i + 1] = X_val[i] + h;
            }
            return X_val;
        }

        public double[] Fun_Y(double a, double b, int k, double[] X_val)
        {
            double[] Y_val = new double[k];

            for (int i = 0; i <= k - 1; i++)
            {
                Y_val[i] = Math.Pow(Math.Pow((X_val[i] + 2), 2), 1.0 / 3.0) - Math.Pow(Math.Pow((X_val[i] - 2), 2), 1.0 / 3.0);
            }
            return  Y_val;
        }

            public double[] ParamrtrFun_X(double[] X_val, int k, double cnst_a)
        {
            double[] X_t_val = new double[k];
            double[] Y_t_val = new double[k];
            for(int i = 0; i<k; i++)
            {

                //X_t_val[i] = cnst_a / Math.Pow(Math.Cos(X_val[i]), 3);
                X_t_val[i] = X_val[i]* X_val[i]/(cnst_a- X_val[i] * X_val[i]) ;
            }
            return X_t_val;
        }

        public double[] ParamrtrFun_Y(double[] X_val, int k, double cnst_a)
        {
            double[] X_t_val = new double[k];
            double[] Y_t_val = new double[k];
            for (int i = 0; i < k; i++)
            {
                // Y_t_val[i] = cnst_a * Math.Pow(Math.Tan(X_val[i]), 3);
                Y_t_val[i] = X_val[i]/(X_val[i]* X_val[i] - 1);
                if(Y_t_val[i]==1 )
                {
                    Y_t_val[i] = 1.1;
                }
                if (Y_t_val[i] == -1)
                {
                    Y_t_val[i] = -1.1;
                }
            }
            return Y_t_val;
        }

        public string Formatv(double x)
        {
            return String.Format("{0:f4}", x);
        }

        void Sort_arr(double[] arr1, double[] arr2)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                for (int i = 0; i < arr1.Length -j- 1; i++)
                {
                    if (arr1[i] > arr1[i + 1])
                    {
                        double tem = arr1[i];
                        arr1[i] = arr1[i + 1];
                        arr1[i + 1] = tem;

                        double temp = arr2[i];
                        arr2[i] = arr2[i + 1];
                        arr2[i + 1] = temp;

                    }
                }
            }
        }

        public int MyIndexOF(double[]arr,double val)
        {
            for(int i=0; i < arr.Length; i++)
            {
                string a = Formatv(arr[i]);
                arr[i] = Convert.ToDouble(a);
                if (arr[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Druc_fun(double[] X, double[] Y, int k, int index)
        {
            Axis();
            Sitka();
            for (int i = index; i < k; i++)
            {
                this.chart.Series[0].Points.AddXY(X[i], Y[i]);
                Console.WriteLine($"{X[i]}");
            }
        }

        public void Druc_paramet(double[]t, double[] X, double[] Y, int k, int index)
        {
            Axis();
            Sitka();
            for (int i = index; i < k; i++)
            {
                this.chart.Series[1].Points.AddXY(t[i], X[i]);
                this.chart.Series[2].Points.AddXY(t[i], Y[i]);
                this.chart.Series[3].Points.AddXY(X[i], Y[i]);
                this.chart.Series[4].Points.AddXY(Y[i], X[i]);
            }
        }

        private void setActiveTextBox(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                this.ActiveTextBox = (TextBox)sender;
            }
        }
        private void TextBoxKeyPres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

        }
        private void NumPointTextBoxKeyPres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void Сalculation (object sender, EventArgs e)
        {
            double a, b, cnst_a;
            int k;
            double  maxf, minf, maxfx, minfx;
            if (
                double.TryParse(lf_border.Text, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out a) &&
                double.TryParse(rh_border.Text, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out b) &&
              
                int.TryParse(number_tab_points.Text, out k) 
                )
            {
                if (a < b)
                {
                    Clear_ch();

                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                    double[] X_val = Fun_X(a, b, k);

                    Sitka();
                    Axis();

                    if (rB_simpz_lfun.Checked == true)
                    {
                        var column1 = new DataGridViewColumn();
                        column1.HeaderText = "Значення Х"; 
                        column1.CellTemplate = new DataGridViewTextBoxCell();

                        var column2 = new DataGridViewColumn();
                        column2.HeaderText = "Значення У";
                        column2.CellTemplate = new DataGridViewTextBoxCell();

                        dataGridView1.Columns.Add(column1);
                        dataGridView1.Columns.Add(column2);

                        double[] Y_val = Fun_Y(a, b, k, X_val);

                        for (int i = 0; i < k; i++)
                        {
                            dataGridView1.Rows.Add(Formatv(X_val[i]), Formatv( Y_val[i]));
                        }
                        Druc_fun(X_val, Y_val, k, 0);
                        maxf = minf = Y_val[0];

                        for (int i = 1; i < k; i++)
                        {
                            if (Y_val[i] > maxf)
                            {
                                maxf = Y_val[i];
                            }
                            if (Y_val[i] < minf)
                            {
                                minf = Y_val[i];
                            }
                        }

                        max_fun.Text = String.Format("{0:f4}", maxf);
                        min_fun.Text = String.Format("{0:f4}", minf);
                        
                    }

                    if ((rb_parametric_fun.Checked == true) &&
                        double.TryParse(const_a.Text, out cnst_a))
                    {
                        double[] X_t_val = new double[k];
                        double[] Y_t_val = new double[k];
                        double[] X_t_val1 = new double[k];
                        double[] Y_t_val1 = new double[k];

                        var column1 = new DataGridViewColumn();
                        column1.HeaderText = "Значення t"; 
                        column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                        var column2 = new DataGridViewColumn();
                        column2.HeaderText = "Значення X(t)"; 
                        column2.CellTemplate = new DataGridViewTextBoxCell(); 
                        var column3 = new DataGridViewColumn();
                        column3.HeaderText = "Значення Y(t)"; 
                        column3.CellTemplate = new DataGridViewTextBoxCell();

                        var column4 = new DataGridViewColumn();
                        column4.HeaderText = "Відсортоване  X(t)";
                        column4.CellTemplate = new DataGridViewTextBoxCell();
                        var column5 = new DataGridViewColumn();
                        column5.HeaderText = "Відсортоване по х значення Y(t)";
                        column5.CellTemplate = new DataGridViewTextBoxCell();
                       
                        dataGridView1.Columns.Add(column1);
                        dataGridView1.Columns.Add(column2);
                        dataGridView1.Columns.Add(column3);
                        dataGridView1.Columns.Add(column4);
                        dataGridView1.Columns.Add(column5);
                        
                        for (int i = 0; i < k; i++)
                        {
                            X_t_val[i] = ParamrtrFun_X(X_val, k, cnst_a)[i];
                            Y_t_val[i] = ParamrtrFun_Y(X_val, k, cnst_a)[i];
                            this.chart.Series[1].Points.AddXY(X_val[i], X_t_val[i]);
                            this.chart.Series[2].Points.AddXY(X_val[i], Y_t_val[i]);
                            this.chart.Series[3].Points.AddXY(X_t_val[i], Y_t_val[i]);
                            this.chart.Series[4].Points.AddXY(Y_t_val[i], X_t_val[i]);
                        }

                        double[] cop_x1 = ParamrtrFun_X(X_val, k, cnst_a);
                        double[] cop_y1 = ParamrtrFun_Y(X_val, k, cnst_a);
                        
                        Sort_arr(cop_x1, cop_y1);//double[] sortY_X 
                        
                        for (int i = 0; i < k; i++)
                        {
                            dataGridView1.Rows.Add(Formatv(X_val[i]), Formatv(X_t_val[i]), Formatv(Y_t_val[i]), Formatv(cop_x1[i]), Formatv(cop_y1[i]));
                        }
                        
                        maxf = minf = Y_t_val[0];
                        maxfx = minfx = X_t_val[0];

                        for (int i = 1; i < k; i++)
                        {
                            if (Y_t_val[i] > maxf)
                            {
                                maxf = Y_t_val[i];

                            }
                            if (Y_t_val[i] < minf)
                            {
                                minf = Y_t_val[i];
                            }
                            if (X_t_val[i] > maxfx)
                            {
                                maxfx = X_t_val[i];

                            }
                            if (X_t_val[i] < minfx)
                            {
                                minfx = X_t_val[i];
                            }
                            
                        }
                        max_fun.Text = String.Format("{0:f4}", maxf) + "; " + String.Format("{0:f4}", maxfx);
                        min_fun.Text = String.Format("{0:f4}", minf) + "; " + String.Format("{0:f4}", minfx);

                    }
                   
                }

                else
                {
                    max_fun.Text = "Некоректно введені межі";
                }
                
            }
        }

        //побудова графіка по вибраних точках по вибраним точках
        private void bt_vubr_toch_Click(object sender, EventArgs e)
        {
            Clear_ch();
            Sitka();
            Axis();
            
            double x, y, t;
           
            if (rB_simpz_lfun.Checked == true)
            {
                for(int i= dataGridView1.SelectedRows.Count - 1; i > 0; i--)
                {
                    x = Convert.ToDouble( dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                    y = Convert.ToDouble(dataGridView1.SelectedRows[i].Cells[1].Value.ToString());
                    this.chart.Series[0].Points.AddXY(x, y);
                }
            }
            if (rb_parametric_fun.Checked == true)
            {
                for (int i = dataGridView1.SelectedRows.Count - 1; i > 0; i--)
                {
                    t = Convert.ToDouble(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                    x = Convert.ToDouble(dataGridView1.SelectedRows[i].Cells[1].Value.ToString());
                    y = Convert.ToDouble(dataGridView1.SelectedRows[i].Cells[2].Value.ToString());
                    this.chart.Series[1].Points.AddXY(t, x);
                    this.chart.Series[2].Points.AddXY(t, y);
                    this.chart.Series[3].Points.AddXY(x, y);
                    this.chart.Series[4].Points.AddXY(y, x);
                }
            }
        }


        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "(*.txt)|*.txt";
            openFileDialog.ShowDialog();

        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Clear_ch();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            List<string> txt = new List<string>();
            using (StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
            {
                txt = reader.ReadToEnd().Split(new[] { '\n' }).ToList();
            }
            for(int i = 0; i < txt.Count; i++)
            {
                List<double> arr = txt[i].Trim().Replace("\r", "").Split(' ').Select(Convert.ToDouble).ToList();
                if (arr.Count == 2)
                {
                    rB_simpz_lfun.Checked = true;
                    rb_parametric_fun.Checked = false;

                    dataGridView1.ColumnCount = 2;
                    dataGridView1.Columns[0].HeaderText = "Значення Х";
                    dataGridView1.Columns[1].HeaderText = "Значення Y";

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[1].ReadOnly = true;

                    dataGridView1.Rows[i].Cells[0].Value = arr[0];
                    dataGridView1.Rows[i].Cells[1].Value = arr[1];
                    
                    this.chart.Series[4].Points.AddXY(arr[0], arr[1]);

                    
                }
                if (arr.Count > 3)
                {
                    rB_simpz_lfun.Checked = false;
                    rb_parametric_fun.Checked = true;

                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].HeaderText = "Значення t";
                    dataGridView1.Columns[1].HeaderText = "Значення X";
                    dataGridView1.Columns[2].HeaderText = "Значення Y";

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[1].ReadOnly = true;
                    dataGridView1.Rows[i].Cells[2].ReadOnly = true;

                    dataGridView1.Rows[i].Cells[0].Value = arr[0];
                    dataGridView1.Rows[i].Cells[1].Value = arr[1];
                    dataGridView1.Rows[i].Cells[2].Value = arr[2];

                    this.chart.Series[1].Points.AddXY(arr[0], arr[1]);
                    this.chart.Series[2].Points.AddXY(arr[0], arr[2]);
                    this.chart.Series[3].Points.AddXY(arr[1], arr[2]);
                    this.chart.Series[4].Points.AddXY(arr[2], arr[1]);
                }
            }
            
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
            for(int i =0; i< dataGridView1.Rows.Count - 1; i++)
            {
                for(int j=0; j<dataGridView1.Rows[i].Cells.Count; j++)
                {
                    writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString().Replace('.', '.')+" ");
                }
                if (i < dataGridView1.Rows.Count - 2)
                {
                    writer.Write("\n");
                }
               
            }
            writer.Close();
        }
        
    }
}
