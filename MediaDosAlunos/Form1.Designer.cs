namespace MediaDosAlunos
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
            this.nota1 = new System.Windows.Forms.TextBox();
            this.nota4 = new System.Windows.Forms.TextBox();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maiorN = new System.Windows.Forms.TextBox();
            this.menorN = new System.Windows.Forms.TextBox();
            this.media = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(90, 39);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(100, 20);
            this.nota1.TabIndex = 0;
            this.nota1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nota4
            // 
            this.nota4.Location = new System.Drawing.Point(91, 124);
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(100, 20);
            this.nota4.TabIndex = 1;
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(91, 98);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(100, 20);
            this.nota3.TabIndex = 2;
            this.nota3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(90, 68);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(100, 20);
            this.nota2.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(197, 39);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(198, 68);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 5;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(198, 97);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "digite a nota1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "digite a nota2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "digite a nota3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "digite a nota4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "maior N:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "menor N:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "media:";
            // 
            // maiorN
            // 
            this.maiorN.Location = new System.Drawing.Point(91, 162);
            this.maiorN.Name = "maiorN";
            this.maiorN.Size = new System.Drawing.Size(100, 20);
            this.maiorN.TabIndex = 14;
            // 
            // menorN
            // 
            this.menorN.Location = new System.Drawing.Point(91, 190);
            this.menorN.Name = "menorN";
            this.menorN.Size = new System.Drawing.Size(100, 20);
            this.menorN.TabIndex = 15;
            // 
            // media
            // 
            this.media.Location = new System.Drawing.Point(90, 220);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(100, 20);
            this.media.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 264);
            this.label8.MaximumSize = new System.Drawing.Size(200, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Copy: Oséias-Dario";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.media);
            this.Controls.Add(this.menorN);
            this.Controls.Add(this.maiorN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.nota1);
            this.Name = "Form1";
            this.Text = "Calcular Media";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.TextBox nota4;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maiorN;
        private System.Windows.Forms.TextBox menorN;
        private System.Windows.Forms.TextBox media;
        private System.Windows.Forms.Label label8;
    }
}

