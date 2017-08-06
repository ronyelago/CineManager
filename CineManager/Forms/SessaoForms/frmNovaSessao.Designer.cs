namespace CineManager.Forms.SessaoForms
{
    partial class frmNovaSessao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboFilme = new System.Windows.Forms.TextBox();
            this.tboCinema = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnCinema = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mtbHoraInicial = new System.Windows.Forms.MaskedTextBox();
            this.mtbHoraFinal = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data:";
            // 
            // tboFilme
            // 
            this.tboFilme.Location = new System.Drawing.Point(95, 76);
            this.tboFilme.Name = "tboFilme";
            this.tboFilme.ReadOnly = true;
            this.tboFilme.Size = new System.Drawing.Size(260, 20);
            this.tboFilme.TabIndex = 9;
            // 
            // tboCinema
            // 
            this.tboCinema.Location = new System.Drawing.Point(95, 50);
            this.tboCinema.Name = "tboCinema";
            this.tboCinema.ReadOnly = true;
            this.tboCinema.Size = new System.Drawing.Size(260, 20);
            this.tboCinema.TabIndex = 10;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(95, 24);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(341, 20);
            this.dtpData.TabIndex = 1;
            // 
            // btnCinema
            // 
            this.btnCinema.Location = new System.Drawing.Point(361, 50);
            this.btnCinema.Name = "btnCinema";
            this.btnCinema.Size = new System.Drawing.Size(75, 21);
            this.btnCinema.TabIndex = 2;
            this.btnCinema.Text = "Selecionar";
            this.btnCinema.UseVisualStyleBackColor = true;
            this.btnCinema.Click += new System.EventHandler(this.btnCinema_Click);
            // 
            // btnFilme
            // 
            this.btnFilme.Location = new System.Drawing.Point(361, 76);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(75, 21);
            this.btnFilme.TabIndex = 3;
            this.btnFilme.Text = "Selecionar";
            this.btnFilme.UseVisualStyleBackColor = true;
            this.btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(272, 195);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(164, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mtbHoraInicial
            // 
            this.mtbHoraInicial.Location = new System.Drawing.Point(95, 128);
            this.mtbHoraInicial.Mask = "00:00";
            this.mtbHoraInicial.Name = "mtbHoraInicial";
            this.mtbHoraInicial.Size = new System.Drawing.Size(59, 20);
            this.mtbHoraInicial.TabIndex = 5;
            this.mtbHoraInicial.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraFinal
            // 
            this.mtbHoraFinal.Location = new System.Drawing.Point(95, 154);
            this.mtbHoraFinal.Mask = "00:00";
            this.mtbHoraFinal.Name = "mtbHoraFinal";
            this.mtbHoraFinal.Size = new System.Drawing.Size(59, 20);
            this.mtbHoraFinal.TabIndex = 6;
            this.mtbHoraFinal.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sala:";
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(95, 102);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(164, 21);
            this.cboSala.TabIndex = 4;
            // 
            // frmNovaSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 238);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbHoraFinal);
            this.Controls.Add(this.mtbHoraInicial);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFilme);
            this.Controls.Add(this.btnCinema);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.tboCinema);
            this.Controls.Add(this.tboFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNovaSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Sessão - CineManager";
            this.Load += new System.EventHandler(this.frmNovaSessao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tboFilme;
        public System.Windows.Forms.TextBox tboCinema;
        public System.Windows.Forms.DateTimePicker dtpData;
        public System.Windows.Forms.Button btnCinema;
        public System.Windows.Forms.Button btnFilme;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.MaskedTextBox mtbHoraInicial;
        public System.Windows.Forms.MaskedTextBox mtbHoraFinal;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboSala;
    }
}