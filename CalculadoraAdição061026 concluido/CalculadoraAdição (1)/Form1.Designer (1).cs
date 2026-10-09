namespace CalculadoraAdição
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_titulo = new System.Windows.Forms.Button();
            this.Lbl_Numero1 = new System.Windows.Forms.Label();
            this.Lbl_Numero2 = new System.Windows.Forms.Label();
            this.Btn_Soma = new System.Windows.Forms.Button();
            this.Btn_Multiplicação = new System.Windows.Forms.Button();
            this.Btn_Divisão = new System.Windows.Forms.Button();
            this.Btn_Subtração = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.BackColor = System.Drawing.Color.Cyan;
            this.Lbl_titulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(22, 21);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(318, 45);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "Calculadora";
            this.Lbl_titulo.UseVisualStyleBackColor = false;
            // 
            // Lbl_Numero1
            // 
            this.Lbl_Numero1.AutoSize = true;
            this.Lbl_Numero1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero1.Location = new System.Drawing.Point(352, 72);
            this.Lbl_Numero1.Name = "Lbl_Numero1";
            this.Lbl_Numero1.Size = new System.Drawing.Size(97, 19);
            this.Lbl_Numero1.TabIndex = 2;
            this.Lbl_Numero1.Text = "Primeiro  n°";
            this.Lbl_Numero1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Numero2
            // 
            this.Lbl_Numero2.AutoSize = true;
            this.Lbl_Numero2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero2.Location = new System.Drawing.Point(352, 119);
            this.Lbl_Numero2.Name = "Lbl_Numero2";
            this.Lbl_Numero2.Size = new System.Drawing.Size(99, 19);
            this.Lbl_Numero2.TabIndex = 3;
            this.Lbl_Numero2.Text = "Segundo n°";
            // 
            // Btn_Soma
            // 
            this.Btn_Soma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Soma.ForeColor = System.Drawing.Color.Black;
            this.Btn_Soma.Location = new System.Drawing.Point(356, 221);
            this.Btn_Soma.Name = "Btn_Soma";
            this.Btn_Soma.Size = new System.Drawing.Size(127, 33);
            this.Btn_Soma.TabIndex = 4;
            this.Btn_Soma.Text = "Soma";
            this.Btn_Soma.UseVisualStyleBackColor = true;
            this.Btn_Soma.Click += new System.EventHandler(this.Btn_Soma_Click);
            // 
            // Btn_Multiplicação
            // 
            this.Btn_Multiplicação.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiplicação.ForeColor = System.Drawing.Color.Black;
            this.Btn_Multiplicação.Location = new System.Drawing.Point(356, 411);
            this.Btn_Multiplicação.Name = "Btn_Multiplicação";
            this.Btn_Multiplicação.Size = new System.Drawing.Size(141, 50);
            this.Btn_Multiplicação.TabIndex = 5;
            this.Btn_Multiplicação.Text = "Multiplicação";
            this.Btn_Multiplicação.UseVisualStyleBackColor = true;
            this.Btn_Multiplicação.Click += new System.EventHandler(this.Btn_Multiplicação_Click);
            // 
            // Btn_Divisão
            // 
            this.Btn_Divisão.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Divisão.ForeColor = System.Drawing.Color.Black;
            this.Btn_Divisão.Location = new System.Drawing.Point(356, 278);
            this.Btn_Divisão.Name = "Btn_Divisão";
            this.Btn_Divisão.Size = new System.Drawing.Size(127, 38);
            this.Btn_Divisão.TabIndex = 6;
            this.Btn_Divisão.Text = "Divisão";
            this.Btn_Divisão.UseVisualStyleBackColor = true;
            this.Btn_Divisão.Click += new System.EventHandler(this.Btn_Divisão_Click);
            // 
            // Btn_Subtração
            // 
            this.Btn_Subtração.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Subtração.ForeColor = System.Drawing.Color.Black;
            this.Btn_Subtração.Location = new System.Drawing.Point(356, 342);
            this.Btn_Subtração.Name = "Btn_Subtração";
            this.Btn_Subtração.Size = new System.Drawing.Size(127, 37);
            this.Btn_Subtração.TabIndex = 7;
            this.Btn_Subtração.Text = "Subtração";
            this.Btn_Subtração.UseVisualStyleBackColor = true;
            this.Btn_Subtração.Click += new System.EventHandler(this.Btn_Subtração_Click);
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(457, 73);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 8;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(457, 120);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 9;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Limpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Limpar.Location = new System.Drawing.Point(541, 412);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(167, 50);
            this.Btn_Limpar.TabIndex = 10;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Image = global::CalculadoraAdição.Properties.Resources.calculadora;
            this.pictureBox1.Location = new System.Drawing.Point(22, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CalculadoraAdição.Properties.Resources.images;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(541, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 220);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 504);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Btn_Subtração);
            this.Controls.Add(this.Btn_Divisão);
            this.Controls.Add(this.Btn_Multiplicação);
            this.Controls.Add(this.Btn_Soma);
            this.Controls.Add(this.Lbl_Numero2);
            this.Controls.Add(this.Lbl_Numero1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "Form1";
            this.Text = "Calculadora Adição";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Numero1;
        private System.Windows.Forms.Label Lbl_Numero2;
        private System.Windows.Forms.Button Btn_Soma;
        private System.Windows.Forms.Button Btn_Multiplicação;
        private System.Windows.Forms.Button Btn_Divisão;
        private System.Windows.Forms.Button Btn_Subtração;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

