using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WareData.Interfaz
{
    public partial class Grafica : Form
    {
        //VARIABLES PUBLICAS
        DateTime HoraInicio = new DateTime();
        DateTime HoraFin = new DateTime();
        private double difMin, difHrs;
        private int tipo_escala = 0;

        public Grafica()
        {
            InitializeComponent();
        }
        private void Grafica_Load(object sender, EventArgs e)
        {
            GridGrafica1.DataSource = WareData.dt;
            ExtraeMinutos();
            lblHoraInicial.Text = HoraInicio.ToString("HH:mm:ss");
            lblHoraFinal.Text = HoraFin.ToString("HH:mm:ss");
            //GraficarSup(1);
        }

        //FUNCIONES DE PRESENTACION        
        private void ExtraeMinutos()
        {            
            try
            {
                int tamano = WareData.dt.Rows.Count;
                HoraInicio = Convert.ToDateTime(WareData.dt.Rows[0][1].ToString());
                HoraFin = Convert.ToDateTime(WareData.dt.Rows[tamano - 2][1].ToString());
                difMin = (HoraFin - HoraInicio).TotalMinutes;
                difHrs = (HoraFin - HoraInicio).TotalHours;
            }
            catch (Exception ex)
            {

            }
        }        

        private void GraficaNueva()
        {/*
            // Number of data points
            //////int numOfPoints = int.Parse(5);

            // Generate rundom data
            RandomData(chart1.Series["Default"], 5);// numOfPoints);

            // Make Pareto Chart
            if (chart1.Series.Count > 1)
                chart1.Series.RemoveAt(1);
            MakeParetoChart(chart1, "Default", "Pareto");

            // Set chart types for output data
            chart1.Series["Pareto"].ChartType = SeriesChartType.Line;

            // Set Color of line Pareto chart
            chart1.Series["Pareto"].Color = Color.FromArgb(252, 180, 65);

            // set the markers for each point of the Pareto Line
            chart1.Series["Pareto"].IsValueShownAsLabel = true;
            chart1.Series["Pareto"].MarkerColor = Color.Red;
            chart1.Series["Pareto"].MarkerStyle = MarkerStyle.Circle;
            chart1.Series["Pareto"].MarkerBorderColor = Color.MidnightBlue;
            chart1.Series["Pareto"].MarkerSize = 8;
            chart1.Series["Pareto"].LabelFormat = "0.#";  // format with one decimal and leading zero
            */
        }
        private void RandomData(Series series, int numOfPoints)
        {
            Random rand = new Random();

            // Generate random Y values
            series.Points.Clear();
            for (int point = 0; point < numOfPoints; point++)
            {
                series.Points.AddY(rand.Next(250) + 1);
            }
        }
        void MakeParetoChart(Chart chart, string srcSeriesName, string destSeriesName)
        {

            // get name of the ChartAre of the source series
            string strChartArea = chart.Series[srcSeriesName].ChartArea;

            // ensure the source series is a column chart type
            chart.Series[srcSeriesName].ChartType = SeriesChartType.Column;

            // sort the data in the series to be by values in descending order
            chart.DataManipulator.Sort(PointSortOrder.Descending, srcSeriesName);

            // find the total of all points in the source series
            double total = 0.0;
            foreach (DataPoint pt in chart.Series[srcSeriesName].Points)
                total += pt.YValues[0];

            // set the max value on the primary axis to total
            chart.ChartAreas[strChartArea].AxisY.Maximum = total;

            // create the destination series and add it to the chart
            Series destSeries = new Series(destSeriesName);
            chart.Series.Add(destSeries);

            // ensure the destination series is a Line or Spline chart type
            destSeries.ChartType = SeriesChartType.Line;

            destSeries.BorderWidth = 3;

            // assign the series to the same chart area as the column chart
            destSeries.ChartArea = chart.Series[srcSeriesName].ChartArea;

            // assign this series to use the secondary axis and set it maximum to be 100%
            destSeries.YAxisType = AxisType.Secondary;
            chart.ChartAreas[strChartArea].AxisY2.Maximum = 100;

            // locale specific percentage format with no decimals
            chart.ChartAreas[strChartArea].AxisY2.LabelStyle.Format = "P0";

            // turn off the end point values of the primary X axis
            chart.ChartAreas[strChartArea].AxisX.LabelStyle.IsEndLabelVisible = false;

            // for each point in the source series find % of total and assign to series
            double percentage = 0.0;

            foreach (DataPoint pt in chart.Series[srcSeriesName].Points)
            {
                percentage += (pt.YValues[0] / total * 100.0);
                destSeries.Points.Add(Math.Round(percentage, 2));
            }
        }



        private void optHoras_CheckedChanged(object sender, EventArgs e)
        {
            if (optHoras.Checked == true)
            {
                tipo_escala = 1;
            }
        }
        private void optMinutos_CheckedChanged(object sender, EventArgs e)
        {
            if (optMinutos.Checked == true)
            {
                tipo_escala = 2;
            }
        }

        private void cmdGraficar_Click(object sender, EventArgs e)
        {
            if (tipo_escala != 0)
            {
                GraficarSup(tipo_escala);
                GraficarFondo(tipo_escala);
                //GraficaNueva();
            }
            else
            {
                MessageBox.Show("Seleccione la Unidad de Medida");
            }
        }

        private void GraficarSup(int UnidadTiempo)
        {
            GraficaDatSup.Series.Clear();
            #region MINUTOS
            if (UnidadTiempo == 1)//Hrs
            {
                //PROMEDIO TODOS LOS REGISTROS DE LA TABLA DE MEDICIONES
                //Y SACO MEDIA PARA 8 HORAS
                int ren = WareData.dt.Rows.Count;
                double promedio = Convert.ToDouble(ren) / difHrs;
                int totalsaltos = Convert.ToInt32(promedio);
                int col_inicial = 0, col_final = 0;
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)))
                    {
                        col_inicial = i; break;
                    }
                }
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(txtALas.Text) <= (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString())))
                    {
                        col_final = i; break;
                    }
                }


                //ESTABLEZCO MIS INTERVALOS DE MIS DOS EJES
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Minimum = 1;
                //this.GraficaMonitor.ChartAreas["Dias"].AxisX.Maximum = 31;
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Maximum = totalsaltos;// 24;
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Interval = 1;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Minimum = 0;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Maximum = 30;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Interval = 5;

                this.GraficaDatSup.ChartAreas["Dias"].BorderColor = Color.Black;
                this.GraficaDatSup.ChartAreas["Dias"].BorderWidth = 4;

                GraficaDatSup.Series.Add("Horas");
                GraficaDatSup.Series["Horas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                GraficaDatSup.Series["Horas"].BorderColor = Color.Green;
                GraficaDatSup.Series["Horas"].BorderWidth = 5;

                for (int i = col_inicial; i <= col_final; i++)
                {
                    //if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)) && (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) <= Convert.ToDateTime(txtALas.Text)))
                    //{
                        this.GraficaDatSup.Series["Horas"].Points.AddXY(i + 1, Convert.ToDouble(WareData.dt.Rows[i][3].ToString()));
                    //}
                }
                GraficaDatSup.Invalidate();
            }
            #endregion
            #region HRS
            if (UnidadTiempo == 2)//Hrs
            {
                //PROMEDIO TODOS LOS REGISTROS DE LA TABLA DE MEDICIONES
                //Y SACO MEDIA PARA 8 HORAS
                int ren = WareData.dt.Rows.Count;
                double promedio = Convert.ToDouble(ren) / difHrs;
                int totalsaltos = Convert.ToInt32(promedio);
                int col_inicial = 0, col_final = 0;
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)))
                    {
                        col_inicial = i; break;
                    }
                }
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(txtALas.Text) <= (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString())))
                    {
                        col_final = i; break;
                    }
                }
                double difMinEscala = 0.0;
                difMinEscala = (Convert.ToDateTime(txtALas.Text) - Convert.ToDateTime(txtDeLas.Text)).TotalMinutes;
                if (difMinEscala > 30)
                {

                }



                //ESTABLEZCO MIS INTERVALOS DE MIS DOS EJES
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Minimum = 1;
                //this.GraficaMonitor.ChartAreas["Dias"].AxisX.Maximum = 31;
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Maximum = col_final - col_inicial;// Convert.ToInt32(difMinEscala);// 24;
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Interval = 1;
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.TitleFont = new Font("Microsoft Tai Le", 7, FontStyle.Regular);
                    //.LabelStyle.Font.Size = new System.Drawing.Font("Microsoft Tai Le", 7F, System.Drawing.FontStyle.Regular);
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Minimum = -5;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Maximum = 25;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Interval = 2.5;

                this.GraficaDatSup.ChartAreas["Dias"].BorderColor = Color.Black;
                this.GraficaDatSup.ChartAreas["Dias"].BorderWidth = 1;

                GraficaDatSup.Series.Add("Presion");
                GraficaDatSup.Series["Presion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                GraficaDatSup.Series["Presion"].BorderColor = Color.Green;
                GraficaDatSup.Series["Presion"].BorderWidth = 4;

                GraficaDatSup.Series.Add("Temp");
                GraficaDatSup.Series["Temp"].YAxisType = AxisType.Secondary;
                //ESTABLEZCO MIS INTERVALOS DE MI OTRO EJE Y                
                this.GraficaDatSup.ChartAreas["Dias"].AxisY2.Minimum = -20;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY2.Maximum = 25;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY2.Interval = 5;
                ///////////////////////////////////////////
                GraficaDatSup.Series["Temp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                GraficaDatSup.Series["Temp"].BorderColor = Color.Red;
                GraficaDatSup.Series["Temp"].BorderWidth = 4;

                int j = 1;
                string aux = "";
                for (int i = col_inicial; i <= col_final; i++)
                {
                    //if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)) && (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) <= Convert.ToDateTime(txtALas.Text)))
                    //{
                    aux = WareData.dt.Rows[i][3].ToString();
                    this.GraficaDatSup.Series["Presion"].Points.AddXY(j, WareData.dt.Rows[i][5].ToString());
                    this.GraficaDatSup.Series["Temp"].Points.AddXY(j, WareData.dt.Rows[i][6].ToString());
                    j++;
                    //}
                }

                GraficaDatSup.Invalidate();
            }
            #endregion
        }
        private void GraficarFondo(int UnidadTiempo)
        {
            GraficaDatFondo.Series.Clear();
            #region MINUTOS
            if (UnidadTiempo == 1)//Hrs
            {
                //PROMEDIO TODOS LOS REGISTROS DE LA TABLA DE MEDICIONES
                //Y SACO MEDIA PARA 8 HORAS
                int ren = WareData.dt.Rows.Count;
                double promedio = Convert.ToDouble(ren) / difHrs;
                int totalsaltos = Convert.ToInt32(promedio);
                int col_inicial = 0, col_final = 0;
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)))
                    {
                        col_inicial = i; break;
                    }
                }
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(txtALas.Text) <= (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString())))
                    {
                        col_final = i; break;
                    }
                }


                //ESTABLEZCO MIS INTERVALOS DE MIS DOS EJES
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Minimum = 1;
                //this.GraficaMonitor.ChartAreas["Dias"].AxisX.Maximum = 31;
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Maximum = totalsaltos;// 24;
                this.GraficaDatSup.ChartAreas["Dias"].AxisX.Interval = 1;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Minimum = 0;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Maximum = 30;
                this.GraficaDatSup.ChartAreas["Dias"].AxisY.Interval = 5;

                this.GraficaDatSup.ChartAreas["Dias"].BorderColor = Color.Black;
                this.GraficaDatSup.ChartAreas["Dias"].BorderWidth = 4;

                GraficaDatSup.Series.Add("Horas");
                GraficaDatSup.Series["Horas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                GraficaDatSup.Series["Horas"].BorderColor = Color.Green;
                GraficaDatSup.Series["Horas"].BorderWidth = 5;

                for (int i = col_inicial; i <= col_final; i++)
                {
                    //if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)) && (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) <= Convert.ToDateTime(txtALas.Text)))
                    //{
                    this.GraficaDatSup.Series["Horas"].Points.AddXY(i + 1, Convert.ToDouble(WareData.dt.Rows[i][3].ToString()));
                    //}
                }
                GraficaDatSup.Invalidate();
            }
            #endregion
            #region HRS
            if (UnidadTiempo == 2)//Hrs
            {
                //PROMEDIO TODOS LOS REGISTROS DE LA TABLA DE MEDICIONES
                //Y SACO MEDIA PARA 8 HORAS
                int ren = WareData.dt.Rows.Count;
                double promedio = Convert.ToDouble(ren) / difHrs;
                int totalsaltos = Convert.ToInt32(promedio);
                int col_inicial = 0, col_final = 0;
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)))
                    {
                        col_inicial = i; break;
                    }
                }
                for (int i = 0; i <= WareData.dt.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(txtALas.Text) <= (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString())))
                    {
                        col_final = i; break;
                    }
                }
                double difMinEscala = 0.0;
                difMinEscala = (Convert.ToDateTime(txtALas.Text) - Convert.ToDateTime(txtDeLas.Text)).TotalMinutes;



                //ESTABLEZCO MIS INTERVALOS DE MIS DOS EJES
                this.GraficaDatFondo.ChartAreas["Dias"].AxisX.Minimum = 1;
                //this.GraficaMonitor.ChartAreas["Dias"].AxisX.Maximum = 31;
                this.GraficaDatFondo.ChartAreas["Dias"].AxisX.Maximum = col_final - col_inicial;// Convert.ToInt32(difMinEscala);// 24;
                this.GraficaDatFondo.ChartAreas["Dias"].AxisX.Interval = 1;
                this.GraficaDatFondo.ChartAreas["Dias"].AxisY.Minimum = -5;
                this.GraficaDatFondo.ChartAreas["Dias"].AxisY.Maximum = 25;
                this.GraficaDatFondo.ChartAreas["Dias"].AxisY.Interval = 2.5;

                this.GraficaDatFondo.ChartAreas["Dias"].BorderColor = Color.Black;
                this.GraficaDatFondo.ChartAreas["Dias"].BorderWidth = 1;

                GraficaDatFondo.Series.Add("Presion");
                GraficaDatFondo.Series["Presion"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                GraficaDatFondo.Series["Presion"].BorderColor = Color.Green;
                GraficaDatFondo.Series["Presion"].BorderWidth = 4;

                GraficaDatFondo.Series.Add("Temp");
                GraficaDatFondo.Series["Temp"].YAxisType = AxisType.Secondary;
                //ESTABLEZCO MIS INTERVALOS DE MI OTRO EJE Y                
                this.GraficaDatFondo.ChartAreas["Dias"].AxisY2.Minimum = -20;
                this.GraficaDatFondo.ChartAreas["Dias"].AxisY2.Maximum = 25;
                this.GraficaDatFondo.ChartAreas["Dias"].AxisY2.Interval = 5;
                ///////////////////////////////////////////
                GraficaDatFondo.Series["Temp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                GraficaDatFondo.Series["Temp"].BorderColor = Color.Red;
                GraficaDatFondo.Series["Temp"].BorderWidth = 4;

                int j = 1;
                string aux = "";
                for (int i = col_inicial; i <= col_final; i++)
                {
                    //if ((Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) >= Convert.ToDateTime(txtDeLas.Text)) && (Convert.ToDateTime(WareData.dt.Rows[i][1].ToString()) <= Convert.ToDateTime(txtALas.Text)))
                    //{
                    aux = WareData.dt.Rows[i][3].ToString();
                    this.GraficaDatFondo.Series["Presion"].Points.AddXY(j, WareData.dt.Rows[i][3].ToString());
                    this.GraficaDatFondo.Series["Temp"].Points.AddXY(j, WareData.dt.Rows[i][4].ToString());
                    j++;
                    //}
                }

                GraficaDatFondo.Invalidate();
            }
            #endregion
        }
        private void optTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (optTodo.Checked == true)
            {
                txtDeLas.Enabled = false;
                txtALas.Enabled = false;
            }
        }
        private void optPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (optPersonalizado.Checked == true)
            {
                txtDeLas.Enabled = true;
                txtALas.Enabled = true;
            }
        }

        private void cmdSalirGrafica_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
