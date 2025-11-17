namespace Innovatec
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpJerarquia = new System.Windows.Forms.TabPage();
            this.tbpRutas = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.tbEmpleados = new System.Windows.Forms.TextBox();
            this.tbNivel = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnNivel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbJefe = new System.Windows.Forms.TextBox();
            this.tbNuevoEmpleado = new System.Windows.Forms.TextBox();
            this.tbNuevoCargo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.tvMostrar = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.numDistancia = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarRuta = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblResultadosRuta = new System.Windows.Forms.Label();
            this.cbConexiones = new System.Windows.Forms.ComboBox();
            this.btnConexiones = new System.Windows.Forms.Button();
            this.btnConexo = new System.Windows.Forms.Button();
            this.lblResultadoJerarquia = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpJerarquia.SuspendLayout();
            this.tbpRutas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistancia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpJerarquia);
            this.tabControl1.Controls.Add(this.tbpRutas);
            this.tabControl1.Location = new System.Drawing.Point(22, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpJerarquia
            // 
            this.tbpJerarquia.Controls.Add(this.lblResultadoJerarquia);
            this.tbpJerarquia.Controls.Add(this.tvMostrar);
            this.tbpJerarquia.Controls.Add(this.groupBox3);
            this.tbpJerarquia.Controls.Add(this.groupBox1);
            this.tbpJerarquia.Location = new System.Drawing.Point(4, 22);
            this.tbpJerarquia.Name = "tbpJerarquia";
            this.tbpJerarquia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpJerarquia.Size = new System.Drawing.Size(630, 338);
            this.tbpJerarquia.TabIndex = 0;
            this.tbpJerarquia.Text = "Jerarquía";
            this.tbpJerarquia.UseVisualStyleBackColor = true;
            // 
            // tbpRutas
            // 
            this.tbpRutas.Controls.Add(this.groupBox5);
            this.tbpRutas.Controls.Add(this.groupBox4);
            this.tbpRutas.Controls.Add(this.groupBox2);
            this.tbpRutas.Location = new System.Drawing.Point(4, 22);
            this.tbpRutas.Name = "tbpRutas";
            this.tbpRutas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRutas.Size = new System.Drawing.Size(630, 338);
            this.tbpRutas.TabIndex = 1;
            this.tbpRutas.Text = "Rutas";
            this.tbpRutas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.btnNivel);
            this.groupBox1.Controls.Add(this.btnContar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbNivel);
            this.groupBox1.Controls.Add(this.tbEmpleados);
            this.groupBox1.Controls.Add(this.lblResultados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(308, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obtener Nivel de:";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(6, 134);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(0, 13);
            this.lblResultados.TabIndex = 2;
            // 
            // tbEmpleados
            // 
            this.tbEmpleados.Location = new System.Drawing.Point(102, 27);
            this.tbEmpleados.Name = "tbEmpleados";
            this.tbEmpleados.Size = new System.Drawing.Size(100, 20);
            this.tbEmpleados.TabIndex = 3;
            // 
            // tbNivel
            // 
            this.tbNivel.Location = new System.Drawing.Point(102, 87);
            this.tbNivel.Name = "tbNivel";
            this.tbNivel.Size = new System.Drawing.Size(100, 20);
            this.tbNivel.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(214, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(214, 46);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 6;
            this.btnContar.Text = "Contar Total";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnNivel
            // 
            this.btnNivel.Location = new System.Drawing.Point(214, 90);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(75, 23);
            this.btnNivel.TabIndex = 7;
            this.btnNivel.Text = "Obtener";
            this.btnNivel.UseVisualStyleBackColor = true;
            this.btnNivel.Click += new System.EventHandler(this.btnNivel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarRuta);
            this.groupBox2.Controls.Add(this.numDistancia);
            this.groupBox2.Controls.Add(this.tbDestino);
            this.groupBox2.Controls.Add(this.tbOrigen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(23, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 152);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Ruta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.tbNuevoCargo);
            this.groupBox3.Controls.Add(this.tbNuevoEmpleado);
            this.groupBox3.Controls.Add(this.tbJefe);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(7, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 149);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del Jefe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cargo Empleado:";
            // 
            // tbJefe
            // 
            this.tbJefe.Location = new System.Drawing.Point(97, 24);
            this.tbJefe.Name = "tbJefe";
            this.tbJefe.Size = new System.Drawing.Size(150, 20);
            this.tbJefe.TabIndex = 3;
            // 
            // tbNuevoEmpleado
            // 
            this.tbNuevoEmpleado.Location = new System.Drawing.Point(97, 57);
            this.tbNuevoEmpleado.Name = "tbNuevoEmpleado";
            this.tbNuevoEmpleado.Size = new System.Drawing.Size(150, 20);
            this.tbNuevoEmpleado.TabIndex = 4;
            // 
            // tbNuevoCargo
            // 
            this.tbNuevoCargo.Location = new System.Drawing.Point(97, 86);
            this.tbNuevoCargo.Name = "tbNuevoCargo";
            this.tbNuevoCargo.Size = new System.Drawing.Size(150, 20);
            this.tbNuevoCargo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(59, 112);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Empleado";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(72, 113);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(155, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar Recorrido";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // tvMostrar
            // 
            this.tvMostrar.Location = new System.Drawing.Point(308, 173);
            this.tvMostrar.Name = "tvMostrar";
            this.tvMostrar.Size = new System.Drawing.Size(296, 129);
            this.tvMostrar.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Edificio Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Edificio Destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Distancia (m):";
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(90, 23);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(100, 20);
            this.tbOrigen.TabIndex = 3;
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(90, 56);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(100, 20);
            this.tbDestino.TabIndex = 4;
            // 
            // numDistancia
            // 
            this.numDistancia.Location = new System.Drawing.Point(90, 88);
            this.numDistancia.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numDistancia.Name = "numDistancia";
            this.numDistancia.Size = new System.Drawing.Size(120, 20);
            this.numDistancia.TabIndex = 5;
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Location = new System.Drawing.Point(48, 114);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Size = new System.Drawing.Size(142, 23);
            this.btnAgregarRuta.TabIndex = 6;
            this.btnAgregarRuta.Text = "Agregar Ruta";
            this.btnAgregarRuta.UseVisualStyleBackColor = true;
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalcular);
            this.groupBox4.Controls.Add(this.cbDestino);
            this.groupBox4.Controls.Add(this.cbOrigen);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(390, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 144);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calcular Ruta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Desde:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hasta:";
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(53, 19);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbOrigen.TabIndex = 2;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(53, 48);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 21);
            this.cbDestino.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(29, 83);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Ruta";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblRuta);
            this.groupBox5.Controls.Add(this.lblResultadosRuta);
            this.groupBox5.Controls.Add(this.btnConexo);
            this.groupBox5.Controls.Add(this.btnConexiones);
            this.groupBox5.Controls.Add(this.cbConexiones);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(23, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(576, 140);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Analisis de Red";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Conexiones de:";
            // 
            // lblResultadosRuta
            // 
            this.lblResultadosRuta.AutoSize = true;
            this.lblResultadosRuta.Location = new System.Drawing.Point(240, 28);
            this.lblResultadosRuta.Name = "lblResultadosRuta";
            this.lblResultadosRuta.Size = new System.Drawing.Size(0, 13);
            this.lblResultadosRuta.TabIndex = 3;
            // 
            // cbConexiones
            // 
            this.cbConexiones.FormattingEnabled = true;
            this.cbConexiones.Location = new System.Drawing.Point(94, 20);
            this.cbConexiones.Name = "cbConexiones";
            this.cbConexiones.Size = new System.Drawing.Size(121, 21);
            this.cbConexiones.TabIndex = 1;
            // 
            // btnConexiones
            // 
            this.btnConexiones.Location = new System.Drawing.Point(38, 48);
            this.btnConexiones.Name = "btnConexiones";
            this.btnConexiones.Size = new System.Drawing.Size(152, 23);
            this.btnConexiones.TabIndex = 2;
            this.btnConexiones.Text = "Mostrar Conexiones";
            this.btnConexiones.UseVisualStyleBackColor = true;
            this.btnConexiones.Click += new System.EventHandler(this.btnConexiones_Click);
            // 
            // btnConexo
            // 
            this.btnConexo.Location = new System.Drawing.Point(38, 77);
            this.btnConexo.Name = "btnConexo";
            this.btnConexo.Size = new System.Drawing.Size(152, 23);
            this.btnConexo.TabIndex = 3;
            this.btnConexo.Text = "¿Es Conexo el Parque?";
            this.btnConexo.UseVisualStyleBackColor = true;
            this.btnConexo.Click += new System.EventHandler(this.btnConexo_Click);
            // 
            // lblResultadoJerarquia
            // 
            this.lblResultadoJerarquia.Location = new System.Drawing.Point(9, 184);
            this.lblResultadoJerarquia.Name = "lblResultadoJerarquia";
            this.lblResultadoJerarquia.Size = new System.Drawing.Size(280, 118);
            this.lblResultadoJerarquia.TabIndex = 3;
            // 
            // lblRuta
            // 
            this.lblRuta.Location = new System.Drawing.Point(233, 20);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(332, 106);
            this.lblRuta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbpJerarquia.ResumeLayout(false);
            this.tbpRutas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistancia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpJerarquia;
        private System.Windows.Forms.TabPage tbpRutas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbNivel;
        private System.Windows.Forms.TextBox tbEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNuevoCargo;
        private System.Windows.Forms.TextBox tbNuevoEmpleado;
        private System.Windows.Forms.TextBox tbJefe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView tvMostrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregarRuta;
        private System.Windows.Forms.NumericUpDown numDistancia;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResultadosRuta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbConexiones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConexo;
        private System.Windows.Forms.Button btnConexiones;
        private System.Windows.Forms.Label lblResultadoJerarquia;
        private System.Windows.Forms.Label lblRuta;
    }
}

