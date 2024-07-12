namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boxResultado = new System.Windows.Forms.TextBox();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.boxOp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxResultado
            // 
            this.boxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.boxResultado.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.boxResultado.Location = new System.Drawing.Point(16, 66);
            this.boxResultado.Margin = new System.Windows.Forms.Padding(4);
            this.boxResultado.Name = "boxResultado";
            this.boxResultado.ReadOnly = true;
            this.boxResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boxResultado.Size = new System.Drawing.Size(369, 64);
            this.boxResultado.TabIndex = 1;
            this.boxResultado.Text = "0";
            this.boxResultado.TextChanged += new System.EventHandler(this.boxResultado_TextChanged);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSqrt.Location = new System.Drawing.Point(15, 145);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(84, 61);
            this.btnSqrt.TabIndex = 43;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnErase.Location = new System.Drawing.Point(111, 145);
            this.btnErase.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(84, 61);
            this.btnErase.TabIndex = 42;
            this.btnErase.Text = "AC";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnClear.Location = new System.Drawing.Point(206, 145);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 61);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMult.Location = new System.Drawing.Point(300, 470);
            this.btnMult.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(84, 61);
            this.btnMult.TabIndex = 40;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(111, 470);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(84, 61);
            this.btnDecimal.TabIndex = 39;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRes.Location = new System.Drawing.Point(206, 470);
            this.btnRes.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(84, 61);
            this.btnRes.TabIndex = 38;
            this.btnRes.Text = "=";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDiv.Location = new System.Drawing.Point(300, 389);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(84, 61);
            this.btnDiv.TabIndex = 37;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSub2.Location = new System.Drawing.Point(300, 308);
            this.btnSub2.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(84, 61);
            this.btnSub2.TabIndex = 36;
            this.btnSub2.Text = "-";
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSub.Location = new System.Drawing.Point(300, 226);
            this.btnSub.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(84, 61);
            this.btnSub.TabIndex = 35;
            this.btnSub.Text = "+";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnZero.Location = new System.Drawing.Point(15, 470);
            this.btnZero.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(84, 61);
            this.btnZero.TabIndex = 34;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNove
            // 
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnNove.Location = new System.Drawing.Point(206, 389);
            this.btnNove.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(84, 61);
            this.btnNove.TabIndex = 33;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnOito
            // 
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnOito.Location = new System.Drawing.Point(111, 389);
            this.btnOito.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(84, 61);
            this.btnOito.TabIndex = 32;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnSete
            // 
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSete.Location = new System.Drawing.Point(15, 389);
            this.btnSete.Margin = new System.Windows.Forms.Padding(4);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(84, 61);
            this.btnSete.TabIndex = 31;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnSeis.Location = new System.Drawing.Point(206, 308);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(84, 61);
            this.btnSeis.TabIndex = 30;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnCinco.Location = new System.Drawing.Point(111, 308);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(84, 61);
            this.btnCinco.TabIndex = 29;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnQuatro.Location = new System.Drawing.Point(15, 308);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(84, 61);
            this.btnQuatro.TabIndex = 28;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnTres.Location = new System.Drawing.Point(206, 226);
            this.btnTres.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(84, 61);
            this.btnTres.TabIndex = 27;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnDois.Location = new System.Drawing.Point(111, 226);
            this.btnDois.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(84, 61);
            this.btnDois.TabIndex = 26;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.btnUm.Location = new System.Drawing.Point(15, 226);
            this.btnUm.Margin = new System.Windows.Forms.Padding(4);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(84, 61);
            this.btnUm.TabIndex = 25;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // boxOp
            // 
            this.boxOp.BackColor = System.Drawing.SystemColors.Window;
            this.boxOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.boxOp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.boxOp.Location = new System.Drawing.Point(16, 15);
            this.boxOp.Margin = new System.Windows.Forms.Padding(4);
            this.boxOp.Name = "boxOp";
            this.boxOp.ReadOnly = true;
            this.boxOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxOp.Size = new System.Drawing.Size(369, 55);
            this.boxOp.TabIndex = 44;
            this.boxOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 545);
            this.Controls.Add(this.boxOp);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub2);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.boxResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxResultado;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.TextBox boxOp;
    }
}

