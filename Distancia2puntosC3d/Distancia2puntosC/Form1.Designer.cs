namespace Distancia2puntosC
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
            this.label8 = new System.Windows.Forms.Label();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.TXTresultado = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXTy2 = new System.Windows.Forms.TextBox();
            this.TXTx2 = new System.Windows.Forms.TextBox();
            this.TXTy1 = new System.Windows.Forms.TextBox();
            this.TXTx1 = new System.Windows.Forms.TextBox();
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTz2 = new System.Windows.Forms.TextBox();
            this.TXTz1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(397, 27);
            this.label8.TabIndex = 42;
            this.label8.Text = "DISTANCIA ENTRE 2 PUNTOS";
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNlimpiar.Location = new System.Drawing.Point(35, 320);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(88, 33);
            this.BTNlimpiar.TabIndex = 41;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(26, 263);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(108, 21);
            this.Label7.TabIndex = 40;
            this.Label7.Text = "Resultado:";
            // 
            // TXTresultado
            // 
            this.TXTresultado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TXTresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTresultado.Location = new System.Drawing.Point(170, 265);
            this.TXTresultado.Name = "TXTresultado";
            this.TXTresultado.Size = new System.Drawing.Size(409, 24);
            this.TXTresultado.TabIndex = 39;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(322, 167);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(26, 16);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "Y2";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(322, 73);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(26, 16);
            this.Label6.TabIndex = 37;
            this.Label6.Text = "Y1";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(167, 167);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(25, 16);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "X2";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(167, 73);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(25, 16);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "X1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(26, 184);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 21);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Punto 2:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(26, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 21);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Punto 1:";
            // 
            // TXTy2
            // 
            this.TXTy2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TXTy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTy2.Location = new System.Drawing.Point(325, 186);
            this.TXTy2.Name = "TXTy2";
            this.TXTy2.Size = new System.Drawing.Size(100, 24);
            this.TXTy2.TabIndex = 32;
            // 
            // TXTx2
            // 
            this.TXTx2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TXTx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTx2.Location = new System.Drawing.Point(170, 186);
            this.TXTx2.Name = "TXTx2";
            this.TXTx2.Size = new System.Drawing.Size(100, 24);
            this.TXTx2.TabIndex = 31;
            // 
            // TXTy1
            // 
            this.TXTy1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TXTy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTy1.Location = new System.Drawing.Point(325, 92);
            this.TXTy1.Name = "TXTy1";
            this.TXTy1.Size = new System.Drawing.Size(100, 24);
            this.TXTy1.TabIndex = 30;
            // 
            // TXTx1
            // 
            this.TXTx1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TXTx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTx1.Location = new System.Drawing.Point(170, 92);
            this.TXTx1.Name = "TXTx1";
            this.TXTx1.Size = new System.Drawing.Size(100, 24);
            this.TXTx1.TabIndex = 29;
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcalcular.Location = new System.Drawing.Point(491, 320);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(88, 33);
            this.BTNcalcular.TabIndex = 28;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = true;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Z2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Z1";
            // 
            // TXTz2
            // 
            this.TXTz2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TXTz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTz2.Location = new System.Drawing.Point(479, 186);
            this.TXTz2.Name = "TXTz2";
            this.TXTz2.Size = new System.Drawing.Size(100, 24);
            this.TXTz2.TabIndex = 44;
            // 
            // TXTz1
            // 
            this.TXTz1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TXTz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTz1.Location = new System.Drawing.Point(479, 92);
            this.TXTz1.Name = "TXTz1";
            this.TXTz1.Size = new System.Drawing.Size(100, 24);
            this.TXTz1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 373);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXTz2);
            this.Controls.Add(this.TXTz1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TXTresultado);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TXTy2);
            this.Controls.Add(this.TXTx2);
            this.Controls.Add(this.TXTy1);
            this.Controls.Add(this.TXTx1);
            this.Controls.Add(this.BTNcalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button BTNlimpiar;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TXTresultado;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TXTy2;
        internal System.Windows.Forms.TextBox TXTx2;
        internal System.Windows.Forms.TextBox TXTy1;
        internal System.Windows.Forms.TextBox TXTx1;
        internal System.Windows.Forms.Button BTNcalcular;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox TXTz2;
        internal System.Windows.Forms.TextBox TXTz1;
    }
}

