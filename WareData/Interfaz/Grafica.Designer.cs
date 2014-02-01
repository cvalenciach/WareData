namespace WareData.Interfaz
{
    partial class Grafica
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafica));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtDeLas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtALas = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblHoraInicial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.optPersonalizado = new System.Windows.Forms.RadioButton();
            this.optTodo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optMinutos = new System.Windows.Forms.RadioButton();
            this.optHoras = new System.Windows.Forms.RadioButton();
            this.cmdGraficar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridGrafica1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GraficaDatSup = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmdSalirGrafica = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GraficaDatFondo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGrafica1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDatSup)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDatFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Info>>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 571);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 51);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.tabControl1);
            this.groupBox13.Location = new System.Drawing.Point(12, 12);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(316, 548);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Muestra de Mediciones";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(304, 516);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cmdGraficar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuracion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDeLas);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtALas);
            this.groupBox6.Location = new System.Drawing.Point(35, 188);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 86);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Personalizado";
            // 
            // txtDeLas
            // 
            this.txtDeLas.Enabled = false;
            this.txtDeLas.Location = new System.Drawing.Point(78, 19);
            this.txtDeLas.Name = "txtDeLas";
            this.txtDeLas.Size = new System.Drawing.Size(100, 20);
            this.txtDeLas.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "De hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "A hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(92, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "HH:mm:ss";
            // 
            // txtALas
            // 
            this.txtALas.Enabled = false;
            this.txtALas.Location = new System.Drawing.Point(78, 45);
            this.txtALas.Name = "txtALas";
            this.txtALas.Size = new System.Drawing.Size(100, 20);
            this.txtALas.TabIndex = 31;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblHoraFinal);
            this.groupBox5.Controls.Add(this.lblHoraInicial);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(35, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 93);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tiempo Absoluto:";
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFinal.ForeColor = System.Drawing.Color.Gray;
            this.lblHoraFinal.Location = new System.Drawing.Point(80, 51);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(74, 15);
            this.lblHoraFinal.TabIndex = 31;
            this.lblHoraFinal.Text = "Hora final:";
            // 
            // lblHoraInicial
            // 
            this.lblHoraInicial.AutoSize = true;
            this.lblHoraInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicial.ForeColor = System.Drawing.Color.Gray;
            this.lblHoraInicial.Location = new System.Drawing.Point(78, 21);
            this.lblHoraInicial.Name = "lblHoraInicial";
            this.lblHoraInicial.Size = new System.Drawing.Size(85, 15);
            this.lblHoraInicial.TabIndex = 30;
            this.lblHoraInicial.Text = "Hora Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hora Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hora Inicial:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.optPersonalizado);
            this.groupBox4.Controls.Add(this.optTodo);
            this.groupBox4.Location = new System.Drawing.Point(35, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 68);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Muestra";
            // 
            // optPersonalizado
            // 
            this.optPersonalizado.AutoSize = true;
            this.optPersonalizado.Location = new System.Drawing.Point(80, 40);
            this.optPersonalizado.Name = "optPersonalizado";
            this.optPersonalizado.Size = new System.Drawing.Size(91, 17);
            this.optPersonalizado.TabIndex = 34;
            this.optPersonalizado.TabStop = true;
            this.optPersonalizado.Text = "Personalizado";
            this.optPersonalizado.UseVisualStyleBackColor = true;
            this.optPersonalizado.CheckedChanged += new System.EventHandler(this.optPersonalizado_CheckedChanged);
            // 
            // optTodo
            // 
            this.optTodo.AutoSize = true;
            this.optTodo.Location = new System.Drawing.Point(80, 16);
            this.optTodo.Name = "optTodo";
            this.optTodo.Size = new System.Drawing.Size(50, 17);
            this.optTodo.TabIndex = 33;
            this.optTodo.TabStop = true;
            this.optTodo.Text = "Todo";
            this.optTodo.UseVisualStyleBackColor = true;
            this.optTodo.CheckedChanged += new System.EventHandler(this.optTodo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optMinutos);
            this.groupBox2.Controls.Add(this.optHoras);
            this.groupBox2.Location = new System.Drawing.Point(35, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escala";
            // 
            // optMinutos
            // 
            this.optMinutos.AutoSize = true;
            this.optMinutos.Location = new System.Drawing.Point(51, 47);
            this.optMinutos.Name = "optMinutos";
            this.optMinutos.Size = new System.Drawing.Size(62, 17);
            this.optMinutos.TabIndex = 1;
            this.optMinutos.TabStop = true;
            this.optMinutos.Text = "Minutos";
            this.optMinutos.UseVisualStyleBackColor = true;
            this.optMinutos.CheckedChanged += new System.EventHandler(this.optMinutos_CheckedChanged);
            // 
            // optHoras
            // 
            this.optHoras.AutoSize = true;
            this.optHoras.Location = new System.Drawing.Point(51, 23);
            this.optHoras.Name = "optHoras";
            this.optHoras.Size = new System.Drawing.Size(53, 17);
            this.optHoras.TabIndex = 0;
            this.optHoras.TabStop = true;
            this.optHoras.Text = "Horas";
            this.optHoras.UseVisualStyleBackColor = true;
            this.optHoras.CheckedChanged += new System.EventHandler(this.optHoras_CheckedChanged);
            // 
            // cmdGraficar
            // 
            this.cmdGraficar.Location = new System.Drawing.Point(35, 452);
            this.cmdGraficar.Name = "cmdGraficar";
            this.cmdGraficar.Size = new System.Drawing.Size(229, 23);
            this.cmdGraficar.TabIndex = 7;
            this.cmdGraficar.Text = "Graficar";
            this.cmdGraficar.UseVisualStyleBackColor = true;
            this.cmdGraficar.Click += new System.EventHandler(this.cmdGraficar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridGrafica1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matriz de Mediciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridGrafica1
            // 
            this.GridGrafica1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGrafica1.Location = new System.Drawing.Point(6, 13);
            this.GridGrafica1.Name = "GridGrafica1";
            this.GridGrafica1.ReadOnly = true;
            this.GridGrafica1.Size = new System.Drawing.Size(281, 471);
            this.GridGrafica1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GraficaDatSup);
            this.groupBox1.Location = new System.Drawing.Point(335, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUPERFICIE";
            // 
            // GraficaDatSup
            // 
            chartArea1.Name = "Dias";
            this.GraficaDatSup.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaDatSup.Legends.Add(legend1);
            this.GraficaDatSup.Location = new System.Drawing.Point(15, 23);
            this.GraficaDatSup.Name = "GraficaDatSup";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 3;
            series1.ChartArea = "Dias";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Dias";
            series2.ChartArea = "Dias";
            series2.Legend = "Legend1";
            series2.Name = "Horas";
            this.GraficaDatSup.Series.Add(series1);
            this.GraficaDatSup.Series.Add(series2);
            this.GraficaDatSup.Size = new System.Drawing.Size(748, 237);
            this.GraficaDatSup.TabIndex = 3;
            this.GraficaDatSup.Text = "chart1";
            // 
            // cmdSalirGrafica
            // 
            this.cmdSalirGrafica.Location = new System.Drawing.Point(1007, 628);
            this.cmdSalirGrafica.Name = "cmdSalirGrafica";
            this.cmdSalirGrafica.Size = new System.Drawing.Size(105, 23);
            this.cmdSalirGrafica.TabIndex = 4;
            this.cmdSalirGrafica.Text = "Salir";
            this.cmdSalirGrafica.UseVisualStyleBackColor = true;
            this.cmdSalirGrafica.Click += new System.EventHandler(this.cmdSalirGrafica_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GraficaDatFondo);
            this.groupBox3.Location = new System.Drawing.Point(335, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 269);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SUBTERRANEO";
            // 
            // GraficaDatFondo
            // 
            chartArea2.Name = "Dias";
            this.GraficaDatFondo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficaDatFondo.Legends.Add(legend2);
            this.GraficaDatFondo.Location = new System.Drawing.Point(15, 23);
            this.GraficaDatFondo.Name = "GraficaDatFondo";
            series3.BorderColor = System.Drawing.Color.Red;
            series3.BorderWidth = 3;
            series3.ChartArea = "Dias";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Green;
            series3.Legend = "Legend1";
            series3.Name = "Dias";
            series4.ChartArea = "Dias";
            series4.Legend = "Legend1";
            series4.Name = "Horas";
            this.GraficaDatFondo.Series.Add(series3);
            this.GraficaDatFondo.Series.Add(series4);
            this.GraficaDatFondo.Size = new System.Drawing.Size(748, 237);
            this.GraficaDatFondo.TabIndex = 4;
            this.GraficaDatFondo.Text = "chart1";
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1118, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdSalirGrafica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridGrafica1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDatSup)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraficaDatFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaDatSup;
        private System.Windows.Forms.DataGridView GridGrafica1;
        private System.Windows.Forms.Button cmdSalirGrafica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optMinutos;
        private System.Windows.Forms.RadioButton optHoras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdGraficar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtALas;
        private System.Windows.Forms.TextBox txtDeLas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblHoraInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaDatFondo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton optPersonalizado;
        private System.Windows.Forms.RadioButton optTodo;
    }
}