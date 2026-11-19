namespace s14
{
    partial class Ejercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResultado = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnLimpiar = new Button();
            btnMenor = new Button();
            btnMayor = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(190, 47);
            label1.TabIndex = 0;
            label1.Text = "Mini calculadora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 90);
            label2.Name = "label2";
            label2.Size = new Size(86, 36);
            label2.TabIndex = 1;
            label2.Text = "Número 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 12F);
            label3.Location = new Point(54, 141);
            label3.Name = "label3";
            label3.Size = new Size(89, 36);
            label3.TabIndex = 2;
            label3.Text = "Número 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Javanese Text", 12F);
            label4.Location = new Point(54, 245);
            label4.Name = "label4";
            label4.Size = new Size(91, 36);
            label4.TabIndex = 3;
            label4.Text = "Resultado:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(146, 95);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(74, 23);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(146, 146);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(74, 23);
            txtNum2.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(146, 250);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(74, 23);
            txtResultado.TabIndex = 6;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(54, 180);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(29, 23);
            btnSuma.TabIndex = 7;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(98, 180);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(29, 23);
            btnResta.TabIndex = 8;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click_1;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(146, 180);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(29, 23);
            btnMultiplicacion.TabIndex = 9;
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(191, 180);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(29, 23);
            btnDivision.TabIndex = 10;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(146, 217);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(74, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMenor
            // 
            btnMenor.Location = new Point(98, 215);
            btnMenor.Name = "btnMenor";
            btnMenor.Size = new Size(29, 23);
            btnMenor.TabIndex = 12;
            btnMenor.Text = "<";
            btnMenor.UseVisualStyleBackColor = true;
            btnMenor.Click += btnMenor_Click;
            // 
            // btnMayor
            // 
            btnMayor.Location = new Point(54, 215);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(29, 23);
            btnMayor.TabIndex = 13;
            btnMayor.Text = ">";
            btnMayor.UseVisualStyleBackColor = true;
            btnMayor.Click += btnMayor_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(89, 288);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 367);
            Controls.Add(btnSalir);
            Controls.Add(btnMayor);
            Controls.Add(btnMenor);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ejercicio1";
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnLimpiar;
        private Button btnMenor;
        private Button btnMayor;
        private Button btnSalir;
    }
}
