namespace WareData.Interfaz
{
    partial class Activacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activacion));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDias_Restantes = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdExaminar = new System.Windows.Forms.Button();
            this.txtRutaLicencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdSalir);
            this.groupBox4.Location = new System.Drawing.Point(358, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 59);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(18, 19);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(78, 28);
            this.cmdSalir.TabIndex = 23;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDias_Restantes);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 59);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periodo de Prueba";
            // 
            // lblDias_Restantes
            // 
            this.lblDias_Restantes.AutoSize = true;
            this.lblDias_Restantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias_Restantes.ForeColor = System.Drawing.Color.Red;
            this.lblDias_Restantes.Location = new System.Drawing.Point(157, 29);
            this.lblDias_Restantes.Name = "lblDias_Restantes";
            this.lblDias_Restantes.Size = new System.Drawing.Size(38, 13);
            this.lblDias_Restantes.TabIndex = 8;
            this.lblDias_Restantes.Text = "[dias]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "Dias restantes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdExaminar);
            this.groupBox1.Controls.Add(this.txtRutaLicencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdAceptar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 138);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de registro";
            // 
            // cmdExaminar
            // 
            this.cmdExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExaminar.Location = new System.Drawing.Point(379, 60);
            this.cmdExaminar.Name = "cmdExaminar";
            this.cmdExaminar.Size = new System.Drawing.Size(71, 23);
            this.cmdExaminar.TabIndex = 25;
            this.cmdExaminar.Text = "Examinar";
            this.cmdExaminar.UseVisualStyleBackColor = true;
            this.cmdExaminar.Click += new System.EventHandler(this.cmdExaminar_Click);
            // 
            // txtRutaLicencia
            // 
            this.txtRutaLicencia.Enabled = false;
            this.txtRutaLicencia.Location = new System.Drawing.Point(75, 61);
            this.txtRutaLicencia.Name = "txtRutaLicencia";
            this.txtRutaLicencia.Size = new System.Drawing.Size(298, 20);
            this.txtRutaLicencia.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Arhivo:";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAceptar.Location = new System.Drawing.Point(160, 98);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(106, 28);
            this.cmdAceptar.TabIndex = 22;
            this.cmdAceptar.Text = "Registrar Producto";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seleccione archivo de licencia";
            // 
            // Activacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(481, 213);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Activacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activacion";
            this.Load += new System.EventHandler(this.Activacion_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDias_Restantes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdExaminar;
        private System.Windows.Forms.TextBox txtRutaLicencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Label label5;
    }
}