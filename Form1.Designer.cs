namespace SimulacroExamenParcial
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
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.comboBoxTaller = new System.Windows.Forms.ComboBox();
            this.buttonInscribir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taller";
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(122, 32);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(620, 24);
            this.comboBoxAlumno.TabIndex = 2;
            // 
            // comboBoxTaller
            // 
            this.comboBoxTaller.FormattingEnabled = true;
            this.comboBoxTaller.Location = new System.Drawing.Point(122, 93);
            this.comboBoxTaller.Name = "comboBoxTaller";
            this.comboBoxTaller.Size = new System.Drawing.Size(620, 24);
            this.comboBoxTaller.TabIndex = 3;
            // 
            // buttonInscribir
            // 
            this.buttonInscribir.Location = new System.Drawing.Point(363, 142);
            this.buttonInscribir.Name = "buttonInscribir";
            this.buttonInscribir.Size = new System.Drawing.Size(131, 38);
            this.buttonInscribir.TabIndex = 4;
            this.buttonInscribir.Text = "Inscribir";
            this.buttonInscribir.UseVisualStyleBackColor = true;
            this.buttonInscribir.Click += new System.EventHandler(this.buttonInscribir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 127);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(122, 416);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(187, 38);
            this.buttonMostrar.TabIndex = 6;
            this.buttonMostrar.Text = "Mostar reporte";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(576, 416);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(176, 38);
            this.buttonOrdenar.TabIndex = 7;
            this.buttonOrdenar.Text = "Ordenar por taller";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(342, 487);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(176, 38);
            this.buttonTotal.TabIndex = 8;
            this.buttonTotal.Text = "Total de estudiantes";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 550);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonInscribir);
            this.Controls.Add(this.comboBoxTaller);
            this.Controls.Add(this.comboBoxAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.ComboBox comboBoxTaller;
        private System.Windows.Forms.Button buttonInscribir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonTotal;
    }
}

