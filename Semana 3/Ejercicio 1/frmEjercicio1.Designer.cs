namespace Ejercicio_1___S3
{
    partial class frmEjercicio1
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
            this.txtMontoRetiro = new System.Windows.Forms.TextBox();
            this.txtSaldoDisponible = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el monto a retirar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el saldo disponible de su tarjeta:";
            // 
            // txtMontoRetiro
            // 
            this.txtMontoRetiro.Location = new System.Drawing.Point(241, 43);
            this.txtMontoRetiro.Name = "txtMontoRetiro";
            this.txtMontoRetiro.Size = new System.Drawing.Size(160, 20);
            this.txtMontoRetiro.TabIndex = 2;
            // 
            // txtSaldoDisponible
            // 
            this.txtSaldoDisponible.Location = new System.Drawing.Point(241, 83);
            this.txtSaldoDisponible.Name = "txtSaldoDisponible";
            this.txtSaldoDisponible.Size = new System.Drawing.Size(160, 20);
            this.txtSaldoDisponible.TabIndex = 3;
            // 
            // txtCondicion
            // 
            this.txtCondicion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCondicion.Location = new System.Drawing.Point(156, 165);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.ReadOnly = true;
            this.txtCondicion.Size = new System.Drawing.Size(245, 20);
            this.txtCondicion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(271, 126);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(52, 21);
            this.btnEvaluar.TabIndex = 6;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(324, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(52, 21);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 246);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.txtSaldoDisponible);
            this.Controls.Add(this.txtMontoRetiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEjercicio1";
            this.Text = "Fundamentos de Algoritmos - Semana 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoRetiro;
        private System.Windows.Forms.TextBox txtSaldoDisponible;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

