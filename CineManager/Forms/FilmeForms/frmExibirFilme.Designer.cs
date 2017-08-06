namespace CineManager.Forms
{
    partial class frmExibirFilme
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
            this.tboTituloPT = new System.Windows.Forms.TextBox();
            this.tboGenero = new System.Windows.Forms.TextBox();
            this.tboDuracao = new System.Windows.Forms.TextBox();
            this.tboOrigem = new System.Windows.Forms.TextBox();
            this.tboDiretor = new System.Windows.Forms.TextBox();
            this.tboClassificacao = new System.Windows.Forms.TextBox();
            this.tboTitulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tboBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tboTituloPT
            // 
            this.tboTituloPT.Location = new System.Drawing.Point(195, 155);
            this.tboTituloPT.Name = "tboTituloPT";
            this.tboTituloPT.Size = new System.Drawing.Size(200, 20);
            this.tboTituloPT.TabIndex = 30;
            // 
            // tboGenero
            // 
            this.tboGenero.Location = new System.Drawing.Point(195, 188);
            this.tboGenero.Name = "tboGenero";
            this.tboGenero.Size = new System.Drawing.Size(200, 20);
            this.tboGenero.TabIndex = 29;
            // 
            // tboDuracao
            // 
            this.tboDuracao.Location = new System.Drawing.Point(195, 223);
            this.tboDuracao.Name = "tboDuracao";
            this.tboDuracao.Size = new System.Drawing.Size(200, 20);
            this.tboDuracao.TabIndex = 28;
            // 
            // tboOrigem
            // 
            this.tboOrigem.Location = new System.Drawing.Point(195, 252);
            this.tboOrigem.Name = "tboOrigem";
            this.tboOrigem.Size = new System.Drawing.Size(200, 20);
            this.tboOrigem.TabIndex = 27;
            // 
            // tboDiretor
            // 
            this.tboDiretor.Location = new System.Drawing.Point(195, 285);
            this.tboDiretor.Name = "tboDiretor";
            this.tboDiretor.Size = new System.Drawing.Size(200, 20);
            this.tboDiretor.TabIndex = 26;
            // 
            // tboClassificacao
            // 
            this.tboClassificacao.Location = new System.Drawing.Point(195, 314);
            this.tboClassificacao.Name = "tboClassificacao";
            this.tboClassificacao.Size = new System.Drawing.Size(200, 20);
            this.tboClassificacao.TabIndex = 25;
            // 
            // tboTitulo
            // 
            this.tboTitulo.Location = new System.Drawing.Point(195, 127);
            this.tboTitulo.Name = "tboTitulo";
            this.tboTitulo.Size = new System.Drawing.Size(200, 20);
            this.tboTitulo.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Classificação Etária:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Diretor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "País de Origem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Duração:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gênero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Título em Portugês:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Título Original:";
            // 
            // pbImagem
            // 
            this.pbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagem.Location = new System.Drawing.Point(195, 361);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(200, 206);
            this.pbImagem.TabIndex = 16;
            this.pbImagem.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Busca por ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tboBusca
            // 
            this.tboBusca.Location = new System.Drawing.Point(195, 49);
            this.tboBusca.Name = "tboBusca";
            this.tboBusca.Size = new System.Drawing.Size(113, 20);
            this.tboBusca.TabIndex = 33;
            // 
            // frmExibirFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 620);
            this.Controls.Add(this.tboBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboTituloPT);
            this.Controls.Add(this.tboGenero);
            this.Controls.Add(this.tboDuracao);
            this.Controls.Add(this.tboOrigem);
            this.Controls.Add(this.tboDiretor);
            this.Controls.Add(this.tboClassificacao);
            this.Controls.Add(this.tboTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagem);
            this.Name = "frmExibirFilme";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboTituloPT;
        private System.Windows.Forms.TextBox tboGenero;
        private System.Windows.Forms.TextBox tboDuracao;
        private System.Windows.Forms.TextBox tboOrigem;
        private System.Windows.Forms.TextBox tboDiretor;
        private System.Windows.Forms.TextBox tboClassificacao;
        private System.Windows.Forms.TextBox tboTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tboBusca;
    }
}