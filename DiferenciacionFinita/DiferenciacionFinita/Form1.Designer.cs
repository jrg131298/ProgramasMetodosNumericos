namespace DiferenciacionFinita
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.TipoD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.A4 = new System.Windows.Forms.TextBox();
            this.A3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Derivada = new System.Windows.Forms.ComboBox();
            this.Xi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipoD
            // 
            this.TipoD.FormattingEnabled = true;
            this.TipoD.Location = new System.Drawing.Point(497, 126);
            this.TipoD.Name = "TipoD";
            this.TipoD.Size = new System.Drawing.Size(164, 28);
            this.TipoD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "x^4 +";
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(184, 49);
            this.A4.Multiline = true;
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(53, 43);
            this.A4.TabIndex = 3;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(294, 50);
            this.A3.Multiline = true;
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(53, 43);
            this.A3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "x^3 +";
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(404, 50);
            this.A2.Multiline = true;
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(53, 43);
            this.A2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "x^2 +";
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(514, 49);
            this.A1.Multiline = true;
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(53, 43);
            this.A1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "x +";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(608, 50);
            this.C.Multiline = true;
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(53, 43);
            this.C.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de diferenciacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Error:";
            // 
            // Error
            // 
            this.Error.FormattingEnabled = true;
            this.Error.Location = new System.Drawing.Point(497, 161);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(164, 28);
            this.Error.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Derivada:";
            // 
            // Derivada
            // 
            this.Derivada.FormattingEnabled = true;
            this.Derivada.Location = new System.Drawing.Point(497, 195);
            this.Derivada.Name = "Derivada";
            this.Derivada.Size = new System.Drawing.Size(164, 28);
            this.Derivada.TabIndex = 14;
            // 
            // Xi
            // 
            this.Xi.Location = new System.Drawing.Point(125, 126);
            this.Xi.Multiline = true;
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(53, 43);
            this.Xi.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valor de Xi:";
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(125, 175);
            this.H.Multiline = true;
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(53, 43);
            this.H.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Valor de h:";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(29, 255);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(25, 20);
            this.Resultado.TabIndex = 20;
            this.Resultado.Text = "R:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.H);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Xi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Derivada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.C);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoD);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TipoD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox A4;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Error;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Derivada;
        private System.Windows.Forms.TextBox Xi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button button2;
    }
}

