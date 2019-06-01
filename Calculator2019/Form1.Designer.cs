namespace Calculator2019
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
            this.result = new System.Windows.Forms.TextBox();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnNPonto = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMutiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnLbKg = new System.Windows.Forms.Button();
            this.btnKgLb = new System.Windows.Forms.Button();
            this.btnMiKm = new System.Windows.Forms.Button();
            this.btnKmMi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.equation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Window;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(244, 34);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(300, 80);
            this.result.TabIndex = 1;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // btnN7
            // 
            this.btnN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(42, 185);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(121, 62);
            this.btnN7.TabIndex = 2;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = true;
            this.btnN7.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN4
            // 
            this.btnN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(42, 253);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(121, 62);
            this.btnN4.TabIndex = 3;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = true;
            this.btnN4.Click += new System.EventHandler(this.button_Click);
            // 
            // btnCe
            // 
            this.btnCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCe.Location = new System.Drawing.Point(42, 117);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(121, 62);
            this.btnCe.TabIndex = 5;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnN1
            // 
            this.btnN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(42, 321);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(121, 62);
            this.btnN1.TabIndex = 4;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = true;
            this.btnN1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN0
            // 
            this.btnN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(169, 389);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(121, 62);
            this.btnN0.TabIndex = 9;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = true;
            this.btnN0.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN2
            // 
            this.btnN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(169, 321);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(121, 62);
            this.btnN2.TabIndex = 8;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = true;
            this.btnN2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN5
            // 
            this.btnN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(169, 253);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(121, 62);
            this.btnN5.TabIndex = 7;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = true;
            this.btnN5.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN8
            // 
            this.btnN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(169, 185);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(121, 62);
            this.btnN8.TabIndex = 6;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = true;
            this.btnN8.Click += new System.EventHandler(this.button_Click);
            // 
            // btnNPonto
            // 
            this.btnNPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNPonto.Location = new System.Drawing.Point(42, 389);
            this.btnNPonto.Name = "btnNPonto";
            this.btnNPonto.Size = new System.Drawing.Size(121, 62);
            this.btnNPonto.TabIndex = 13;
            this.btnNPonto.Text = ".";
            this.btnNPonto.UseVisualStyleBackColor = true;
            this.btnNPonto.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN3
            // 
            this.btnN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(296, 321);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(121, 62);
            this.btnN3.TabIndex = 12;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = true;
            this.btnN3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN6
            // 
            this.btnN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(296, 253);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(121, 62);
            this.btnN6.TabIndex = 11;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = true;
            this.btnN6.Click += new System.EventHandler(this.button_Click);
            // 
            // btnN9
            // 
            this.btnN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(296, 185);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(121, 62);
            this.btnN9.TabIndex = 10;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = true;
            this.btnN9.Click += new System.EventHandler(this.button_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.Location = new System.Drawing.Point(423, 253);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(121, 62);
            this.btnAdicao.TabIndex = 17;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.operator_click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(423, 185);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(121, 62);
            this.btnSubtracao.TabIndex = 16;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.operator_click);
            // 
            // btnMutiplicacao
            // 
            this.btnMutiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMutiplicacao.Location = new System.Drawing.Point(423, 117);
            this.btnMutiplicacao.Name = "btnMutiplicacao";
            this.btnMutiplicacao.Size = new System.Drawing.Size(121, 62);
            this.btnMutiplicacao.TabIndex = 15;
            this.btnMutiplicacao.Text = "*";
            this.btnMutiplicacao.UseVisualStyleBackColor = true;
            this.btnMutiplicacao.Click += new System.EventHandler(this.operator_click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(296, 117);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(121, 62);
            this.btnDivisao.TabIndex = 14;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.operator_click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(423, 321);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(121, 130);
            this.btnIgual.TabIndex = 21;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(169, 117);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(121, 62);
            this.btnC.TabIndex = 19;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(296, 389);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(121, 62);
            this.btn00.TabIndex = 18;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.button_Click);
            // 
            // btnLbKg
            // 
            this.btnLbKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLbKg.Location = new System.Drawing.Point(550, 389);
            this.btnLbKg.Name = "btnLbKg";
            this.btnLbKg.Size = new System.Drawing.Size(142, 62);
            this.btnLbKg.TabIndex = 25;
            this.btnLbKg.Text = "Lb > Kg";
            this.btnLbKg.UseVisualStyleBackColor = true;
            this.btnLbKg.Click += new System.EventHandler(this.BtnLbKg_Click);
            // 
            // btnKgLb
            // 
            this.btnKgLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKgLb.Location = new System.Drawing.Point(550, 321);
            this.btnKgLb.Name = "btnKgLb";
            this.btnKgLb.Size = new System.Drawing.Size(142, 62);
            this.btnKgLb.TabIndex = 24;
            this.btnKgLb.Text = "Kg > Lb";
            this.btnKgLb.UseVisualStyleBackColor = true;
            this.btnKgLb.Click += new System.EventHandler(this.BtnKgLb_Click);
            // 
            // btnMiKm
            // 
            this.btnMiKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiKm.Location = new System.Drawing.Point(550, 253);
            this.btnMiKm.Name = "btnMiKm";
            this.btnMiKm.Size = new System.Drawing.Size(142, 62);
            this.btnMiKm.TabIndex = 23;
            this.btnMiKm.Text = "Mi > Km";
            this.btnMiKm.UseVisualStyleBackColor = true;
            this.btnMiKm.Click += new System.EventHandler(this.BtnMiKm_Click);
            // 
            // btnKmMi
            // 
            this.btnKmMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKmMi.Location = new System.Drawing.Point(550, 185);
            this.btnKmMi.Name = "btnKmMi";
            this.btnKmMi.Size = new System.Drawing.Size(142, 62);
            this.btnKmMi.TabIndex = 22;
            this.btnKmMi.Text = "Km > Mi";
            this.btnKmMi.UseVisualStyleBackColor = true;
            this.btnKmMi.Click += new System.EventHandler(this.BtnKmMi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculator2019.Properties.Resources.depositphotos_39673043_stock_illustration_vector_sketch_illustration_calculator;
            this.pictureBox1.Location = new System.Drawing.Point(550, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.equation.Location = new System.Drawing.Point(44, 34);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(201, 80);
            this.equation.TabIndex = 27;
            this.equation.Click += new System.EventHandler(this.Equation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(736, 485);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLbKg);
            this.Controls.Add(this.btnKgLb);
            this.Controls.Add(this.btnMiKm);
            this.Controls.Add(this.btnKmMi);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMutiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnNPonto);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Calculator 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnNPonto;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMutiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnLbKg;
        private System.Windows.Forms.Button btnKgLb;
        private System.Windows.Forms.Button btnMiKm;
        private System.Windows.Forms.Button btnKmMi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label equation;
    }
}

