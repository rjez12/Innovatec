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
            this.tbContarEmpleados = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnNivel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpJerarquia.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btnNivel);
            this.groupBox1.Controls.Add(this.btnContar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.tbContarEmpleados);
            this.groupBox1.Controls.Add(this.tbEmpleados);
            this.groupBox1.Controls.Add(this.lblResultados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // tbContarEmpleados
            // 
            this.tbContarEmpleados.Location = new System.Drawing.Point(102, 87);
            this.tbContarEmpleados.Name = "tbContarEmpleados";
            this.tbContarEmpleados.Size = new System.Drawing.Size(100, 20);
            this.tbContarEmpleados.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(214, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(214, 46);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 6;
            this.btnContar.Text = "Contar Total";
            this.btnContar.UseVisualStyleBackColor = true;
            // 
            // btnNivel
            // 
            this.btnNivel.Location = new System.Drawing.Point(214, 90);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(75, 23);
            this.btnNivel.TabIndex = 7;
            this.btnNivel.Text = "Obtener";
            this.btnNivel.UseVisualStyleBackColor = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox tbContarEmpleados;
        private System.Windows.Forms.TextBox tbEmpleados;
    }
}

