namespace TP5SIM
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMediaLectura = new System.Windows.Forms.MaskedTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBConsulta = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAConsulta = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nrcProbabilidadNo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbSimular = new System.Windows.Forms.GroupBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nrcConsulta = new System.Windows.Forms.NumericUpDown();
            this.nrcDevolverLibro = new System.Windows.Forms.NumericUpDown();
            this.nrcPedirLibro = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtFilaHasta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroSimulaciones = new System.Windows.Forms.Label();
            this.txtNumeroSimulaciones = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMediaClientes = new System.Windows.Forms.MaskedTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.k1 = new System.Windows.Forms.MaskedTextBox();
            this.k2 = new System.Windows.Forms.MaskedTextBox();
            this.k3 = new System.Windows.Forms.MaskedTextBox();
            this.gbPrincipal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrcProbabilidadNo)).BeginInit();
            this.gbSimular.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrcConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrcDevolverLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrcPedirLibro)).BeginInit();
            this.gbDatosGenerales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.groupBox6);
            this.gbPrincipal.Controls.Add(this.groupBox2);
            this.gbPrincipal.Controls.Add(this.groupBox5);
            this.gbPrincipal.Controls.Add(this.groupBox4);
            this.gbPrincipal.Controls.Add(this.gbSimular);
            this.gbPrincipal.Controls.Add(this.groupBox3);
            this.gbPrincipal.Controls.Add(this.gbDatosGenerales);
            this.gbPrincipal.Controls.Add(this.groupBox1);
            this.gbPrincipal.Location = new System.Drawing.Point(4, 4);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(805, 457);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Simulación - Linea de Espera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtMediaLectura);
            this.groupBox2.Location = new System.Drawing.Point(587, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 87);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fin de Lectura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Media (exp) μ:";
            // 
            // TxtMediaLectura
            // 
            this.TxtMediaLectura.Location = new System.Drawing.Point(110, 42);
            this.TxtMediaLectura.Mask = "9999999";
            this.TxtMediaLectura.Name = "TxtMediaLectura";
            this.TxtMediaLectura.Size = new System.Drawing.Size(57, 20);
            this.TxtMediaLectura.TabIndex = 4;
            this.TxtMediaLectura.Text = "6";
            this.TxtMediaLectura.ValidatingType = typeof(int);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtBConsulta);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtAConsulta);
            this.groupBox5.Location = new System.Drawing.Point(587, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(212, 124);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fin Atención Consulta";
            // 
            // txtBConsulta
            // 
            this.txtBConsulta.Location = new System.Drawing.Point(74, 71);
            this.txtBConsulta.Mask = "9999999";
            this.txtBConsulta.Name = "txtBConsulta";
            this.txtBConsulta.Size = new System.Drawing.Size(57, 20);
            this.txtBConsulta.TabIndex = 10;
            this.txtBConsulta.Text = "5";
            this.txtBConsulta.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "b:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "a:";
            // 
            // txtAConsulta
            // 
            this.txtAConsulta.Location = new System.Drawing.Point(74, 41);
            this.txtAConsulta.Mask = "9999999";
            this.txtAConsulta.Name = "txtAConsulta";
            this.txtAConsulta.Size = new System.Drawing.Size(57, 20);
            this.txtAConsulta.TabIndex = 9;
            this.txtAConsulta.Text = "2";
            this.txtAConsulta.ValidatingType = typeof(int);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nrcProbabilidadNo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(274, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 124);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lectura en la Biblioteca";
            // 
            // nrcProbabilidadNo
            // 
            this.nrcProbabilidadNo.DecimalPlaces = 2;
            this.nrcProbabilidadNo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nrcProbabilidadNo.Location = new System.Drawing.Point(101, 89);
            this.nrcProbabilidadNo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrcProbabilidadNo.Name = "nrcProbabilidadNo";
            this.nrcProbabilidadNo.Size = new System.Drawing.Size(77, 20);
            this.nrcProbabilidadNo.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "se vaya luego de pedir un libro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ingrese la probabilidad de que un cliente";
            // 
            // gbSimular
            // 
            this.gbSimular.Controls.Add(this.btnSimular);
            this.gbSimular.Location = new System.Drawing.Point(8, 298);
            this.gbSimular.Name = "gbSimular";
            this.gbSimular.Size = new System.Drawing.Size(260, 100);
            this.gbSimular.TabIndex = 21;
            this.gbSimular.TabStop = false;
            this.gbSimular.Text = "Simular";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(81, 39);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(96, 34);
            this.btnSimular.TabIndex = 11;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nrcConsulta);
            this.groupBox3.Controls.Add(this.nrcDevolverLibro);
            this.groupBox3.Controls.Add(this.nrcPedirLibro);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(277, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 177);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Atención";
            // 
            // nrcConsulta
            // 
            this.nrcConsulta.DecimalPlaces = 2;
            this.nrcConsulta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nrcConsulta.Location = new System.Drawing.Point(163, 124);
            this.nrcConsulta.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrcConsulta.Name = "nrcConsulta";
            this.nrcConsulta.Size = new System.Drawing.Size(77, 20);
            this.nrcConsulta.TabIndex = 7;
            // 
            // nrcDevolverLibro
            // 
            this.nrcDevolverLibro.DecimalPlaces = 2;
            this.nrcDevolverLibro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nrcDevolverLibro.Location = new System.Drawing.Point(163, 95);
            this.nrcDevolverLibro.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrcDevolverLibro.Name = "nrcDevolverLibro";
            this.nrcDevolverLibro.Size = new System.Drawing.Size(77, 20);
            this.nrcDevolverLibro.TabIndex = 6;
            // 
            // nrcPedirLibro
            // 
            this.nrcPedirLibro.DecimalPlaces = 2;
            this.nrcPedirLibro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nrcPedirLibro.Location = new System.Drawing.Point(163, 63);
            this.nrcPedirLibro.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nrcPedirLibro.Name = "nrcPedirLibro";
            this.nrcPedirLibro.Size = new System.Drawing.Size(77, 20);
            this.nrcPedirLibro.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Devolver Libro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pedir Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese las probabilidades para cada tipo de atención:";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.txtFilaHasta);
            this.gbDatosGenerales.Controls.Add(this.label1);
            this.gbDatosGenerales.Controls.Add(this.lblNumeroSimulaciones);
            this.gbDatosGenerales.Controls.Add(this.txtNumeroSimulaciones);
            this.gbDatosGenerales.Location = new System.Drawing.Point(8, 35);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(263, 232);
            this.gbDatosGenerales.TabIndex = 18;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // txtFilaHasta
            // 
            this.txtFilaHasta.Location = new System.Drawing.Point(29, 151);
            this.txtFilaHasta.Mask = "9999999";
            this.txtFilaHasta.Name = "txtFilaHasta";
            this.txtFilaHasta.Size = new System.Drawing.Size(57, 20);
            this.txtFilaHasta.TabIndex = 2;
            this.txtFilaHasta.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ingrese hasta qué fila desea visualizar:";
            // 
            // lblNumeroSimulaciones
            // 
            this.lblNumeroSimulaciones.AutoSize = true;
            this.lblNumeroSimulaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSimulaciones.Location = new System.Drawing.Point(6, 43);
            this.lblNumeroSimulaciones.Name = "lblNumeroSimulaciones";
            this.lblNumeroSimulaciones.Size = new System.Drawing.Size(231, 17);
            this.lblNumeroSimulaciones.TabIndex = 16;
            this.lblNumeroSimulaciones.Text = "Ingrese el número de simulaciones:";
            // 
            // txtNumeroSimulaciones
            // 
            this.txtNumeroSimulaciones.Location = new System.Drawing.Point(29, 67);
            this.txtNumeroSimulaciones.Mask = "9999999";
            this.txtNumeroSimulaciones.Name = "txtNumeroSimulaciones";
            this.txtNumeroSimulaciones.Size = new System.Drawing.Size(57, 20);
            this.txtNumeroSimulaciones.TabIndex = 1;
            this.txtNumeroSimulaciones.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMediaClientes);
            this.groupBox1.Location = new System.Drawing.Point(299, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 87);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llegada Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Media (exp) μ:";
            // 
            // TxtMediaClientes
            // 
            this.TxtMediaClientes.Location = new System.Drawing.Point(110, 42);
            this.TxtMediaClientes.Mask = "9999999";
            this.TxtMediaClientes.Name = "TxtMediaClientes";
            this.TxtMediaClientes.Size = new System.Drawing.Size(57, 20);
            this.TxtMediaClientes.TabIndex = 3;
            this.TxtMediaClientes.TabStop = false;
            this.TxtMediaClientes.Text = "4";
            this.TxtMediaClientes.ValidatingType = typeof(int);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.k3);
            this.groupBox6.Controls.Add(this.k2);
            this.groupBox6.Controls.Add(this.k1);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(557, 268);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 168);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Atención";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = ">300 paginas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "200/300 paginas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "100/200 paginas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Ingrese la variable k";
            // 
            // k1
            // 
            this.k1.Location = new System.Drawing.Point(163, 60);
            this.k1.Mask = "9999999";
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(57, 20);
            this.k1.TabIndex = 19;
            this.k1.Text = "100";
            this.k1.ValidatingType = typeof(int);
            // 
            // k2
            // 
            this.k2.Location = new System.Drawing.Point(163, 92);
            this.k2.Mask = "9999999";
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(57, 20);
            this.k2.TabIndex = 20;
            this.k2.Text = "90";
            this.k2.ValidatingType = typeof(int);
            // 
            // k3
            // 
            this.k3.Location = new System.Drawing.Point(163, 124);
            this.k3.Mask = "9999999";
            this.k3.Name = "k3";
            this.k3.Size = new System.Drawing.Size(57, 20);
            this.k3.TabIndex = 21;
            this.k3.Text = "70";
            this.k3.ValidatingType = typeof(int);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 473);
            this.Controls.Add(this.gbPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Práctico 4 - Simulacion";
            this.gbPrincipal.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrcProbabilidadNo)).EndInit();
            this.gbSimular.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrcConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrcDevolverLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrcPedirLibro)).EndInit();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.Label lblNumeroSimulaciones;
        private System.Windows.Forms.MaskedTextBox txtNumeroSimulaciones;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.MaskedTextBox txtFilaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.GroupBox gbSimular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtMediaClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtMediaLectura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox txtBConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtAConsulta;
        private System.Windows.Forms.NumericUpDown nrcProbabilidadNo;
        private System.Windows.Forms.NumericUpDown nrcConsulta;
        private System.Windows.Forms.NumericUpDown nrcDevolverLibro;
        private System.Windows.Forms.NumericUpDown nrcPedirLibro;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MaskedTextBox k3;
        private System.Windows.Forms.MaskedTextBox k2;
        private System.Windows.Forms.MaskedTextBox k1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

