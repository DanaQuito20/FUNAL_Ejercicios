namespace Ejercicio_2___S3
{
    partial class frmEjercicio2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnEnfriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monitoreo de temperatura";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(302, 56);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(174, 20);
            this.txtTemperatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la temperatura actual en grados Celsius ( °):";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(302, 97);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(77, 20);
            this.btnEvaluar.TabIndex = 3;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultados:";
            // 
            // txtResultados
            // 
            this.txtResultados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResultados.Location = new System.Drawing.Point(194, 164);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(282, 20);
            this.txtResultados.TabIndex = 5;
            // 
            // btnEnfriar
            // 
            this.btnEnfriar.Location = new System.Drawing.Point(397, 97);
            this.btnEnfriar.Name = "btnEnfriar";
            this.btnEnfriar.Size = new System.Drawing.Size(79, 20);
            this.btnEnfriar.TabIndex = 6;
            this.btnEnfriar.Text = "Enfriar";
            this.btnEnfriar.UseVisualStyleBackColor = true;
            this.btnEnfriar.Visible = false;
            this.btnEnfriar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 267);
            this.Controls.Add(this.btnEnfriar);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label3);
            this.Name = "frmEjercicio2";
            this.Text = "Fundamentos de Algoritmos - Semana 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btnEnfriar;
    }
}

