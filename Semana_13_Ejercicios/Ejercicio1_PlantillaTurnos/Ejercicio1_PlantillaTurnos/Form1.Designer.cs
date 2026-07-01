namespace Ejercicio1_PlantillaTurnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbM3 = new System.Windows.Forms.TextBox();
            this.txbM2 = new System.Windows.Forms.TextBox();
            this.txbM1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbT2 = new System.Windows.Forms.TextBox();
            this.txbT1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTurnoMayor = new System.Windows.Forms.Label();
            this.Resultados = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpia = new System.Windows.Forms.Button();
            this.btnDatosPrueba = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 1. Planilla por turnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1319, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese los sueldos de los trabajadores por turno. El programa calcula el gasto t" +
    "otal, identifica el turno más costoso y ordena los sueldos\r\nde menor a mayor usa" +
    "ndo burbuja.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbM3);
            this.groupBox1.Controls.Add(this.txbM2);
            this.groupBox1.Controls.Add(this.txbM1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turno mañana";
            // 
            // txbM3
            // 
            this.txbM3.Location = new System.Drawing.Point(184, 172);
            this.txbM3.Name = "txbM3";
            this.txbM3.Size = new System.Drawing.Size(217, 44);
            this.txbM3.TabIndex = 7;
            // 
            // txbM2
            // 
            this.txbM2.Location = new System.Drawing.Point(184, 111);
            this.txbM2.Name = "txbM2";
            this.txbM2.Size = new System.Drawing.Size(217, 44);
            this.txbM2.TabIndex = 6;
            // 
            // txbM1
            // 
            this.txbM1.Location = new System.Drawing.Point(184, 48);
            this.txbM1.Name = "txbM1";
            this.txbM1.Size = new System.Drawing.Size(217, 44);
            this.txbM1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo 2: S/.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sueldo 3: S/.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo 1: S/.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbT2);
            this.groupBox2.Controls.Add(this.txbT1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(504, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 256);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno tarde";
            // 
            // txbT2
            // 
            this.txbT2.Location = new System.Drawing.Point(189, 111);
            this.txbT2.Name = "txbT2";
            this.txbT2.Size = new System.Drawing.Size(217, 44);
            this.txbT2.TabIndex = 7;
            // 
            // txbT1
            // 
            this.txbT1.Location = new System.Drawing.Point(189, 48);
            this.txbT1.Name = "txbT1";
            this.txbT1.Size = new System.Drawing.Size(217, 44);
            this.txbT1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sueldo 2: S/.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sueldo 1: S/.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbN2);
            this.groupBox3.Controls.Add(this.txbN1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(974, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 256);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turno noche";
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(192, 111);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(217, 44);
            this.txbN2.TabIndex = 7;
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(192, 48);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(217, 44);
            this.txbN1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sueldo 2: S/.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sueldo 1: S/.";
            // 
            // lblTurnoMayor
            // 
            this.lblTurnoMayor.AutoSize = true;
            this.lblTurnoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoMayor.Location = new System.Drawing.Point(969, 431);
            this.lblTurnoMayor.Name = "lblTurnoMayor";
            this.lblTurnoMayor.Size = new System.Drawing.Size(296, 29);
            this.lblTurnoMayor.TabIndex = 6;
            this.lblTurnoMayor.Text = "Turno con mayor gasto:-";
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultados.Location = new System.Drawing.Point(31, 509);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(144, 29);
            this.Resultados.TabIndex = 7;
            this.Resultados.Text = "Resultados";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.Location = new System.Drawing.Point(444, 439);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(0, 25);
            this.btnLimpiar.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(36, 415);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(307, 63);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calculo y ordenar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpia
            // 
            this.btnLimpia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpia.Location = new System.Drawing.Point(372, 415);
            this.btnLimpia.Name = "btnLimpia";
            this.btnLimpia.Size = new System.Drawing.Size(245, 63);
            this.btnLimpia.TabIndex = 11;
            this.btnLimpia.Text = "Limpiar";
            this.btnLimpia.UseVisualStyleBackColor = false;
            this.btnLimpia.Click += new System.EventHandler(this.btnLimpia_Click);
            // 
            // btnDatosPrueba
            // 
            this.btnDatosPrueba.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDatosPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosPrueba.Location = new System.Drawing.Point(644, 415);
            this.btnDatosPrueba.Name = "btnDatosPrueba";
            this.btnDatosPrueba.Size = new System.Drawing.Size(283, 63);
            this.btnDatosPrueba.TabIndex = 12;
            this.btnDatosPrueba.Text = "Datos de prueba";
            this.btnDatosPrueba.UseVisualStyleBackColor = false;
            this.btnDatosPrueba.Click += new System.EventHandler(this.btnDatosPrueba_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 25;
            this.lstResultados.Location = new System.Drawing.Point(36, 554);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(1365, 379);
            this.lstResultados.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 984);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnDatosPrueba);
            this.Controls.Add(this.btnLimpia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.lblTurnoMayor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTurnoMayor;
        private System.Windows.Forms.Label Resultados;
        private System.Windows.Forms.Label btnLimpiar;
        private System.Windows.Forms.TextBox txbM3;
        private System.Windows.Forms.TextBox txbM2;
        private System.Windows.Forms.TextBox txbM1;
        private System.Windows.Forms.TextBox txbT2;
        private System.Windows.Forms.TextBox txbT1;
        private System.Windows.Forms.TextBox txbN2;
        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpia;
        private System.Windows.Forms.Button btnDatosPrueba;
        private System.Windows.Forms.ListBox lstResultados;
    }
}

