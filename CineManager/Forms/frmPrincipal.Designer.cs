namespace CineManager
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCinemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeSessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeFilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarGêneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeGênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atoresDiretoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarAtorDiretorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAtoresDiretoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.cinemaToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.atoresDiretoresToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.cToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCinemaToolStripMenuItem,
            this.listaDeCinemasToolStripMenuItem,
            this.sessõesToolStripMenuItem,
            this.salasToolStripMenuItem});
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cinemaToolStripMenuItem.Text = "Cinemas";
            // 
            // adicionarCinemaToolStripMenuItem
            // 
            this.adicionarCinemaToolStripMenuItem.Name = "adicionarCinemaToolStripMenuItem";
            this.adicionarCinemaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.adicionarCinemaToolStripMenuItem.Text = "Adicionar Cinema";
            this.adicionarCinemaToolStripMenuItem.Click += new System.EventHandler(this.adicionarCinemaToolStripMenuItem_Click);
            // 
            // listaDeCinemasToolStripMenuItem
            // 
            this.listaDeCinemasToolStripMenuItem.Name = "listaDeCinemasToolStripMenuItem";
            this.listaDeCinemasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listaDeCinemasToolStripMenuItem.Text = "Lista de Cinemas";
            this.listaDeCinemasToolStripMenuItem.Click += new System.EventHandler(this.listaDeCinemasToolStripMenuItem_Click);
            // 
            // sessõesToolStripMenuItem
            // 
            this.sessõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaSessãoToolStripMenuItem,
            this.listaDeSessõesToolStripMenuItem});
            this.sessõesToolStripMenuItem.Name = "sessõesToolStripMenuItem";
            this.sessõesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sessõesToolStripMenuItem.Text = "Sessões";
            // 
            // novaSessãoToolStripMenuItem
            // 
            this.novaSessãoToolStripMenuItem.Name = "novaSessãoToolStripMenuItem";
            this.novaSessãoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.novaSessãoToolStripMenuItem.Text = "Nova Sessão";
            this.novaSessãoToolStripMenuItem.Click += new System.EventHandler(this.novaSessãoToolStripMenuItem_Click);
            // 
            // listaDeSessõesToolStripMenuItem
            // 
            this.listaDeSessõesToolStripMenuItem.Name = "listaDeSessõesToolStripMenuItem";
            this.listaDeSessõesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listaDeSessõesToolStripMenuItem.Text = "Lista de Sessões";
            this.listaDeSessõesToolStripMenuItem.Click += new System.EventHandler(this.listaDeSessõesToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaSalaToolStripMenuItem,
            this.listaDeSalasToolStripMenuItem});
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salasToolStripMenuItem.Text = "Salas";
            // 
            // novaSalaToolStripMenuItem
            // 
            this.novaSalaToolStripMenuItem.Name = "novaSalaToolStripMenuItem";
            this.novaSalaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.novaSalaToolStripMenuItem.Text = "Nova Sala";
            this.novaSalaToolStripMenuItem.Click += new System.EventHandler(this.novaSalaToolStripMenuItem_Click);
            // 
            // listaDeSalasToolStripMenuItem
            // 
            this.listaDeSalasToolStripMenuItem.Name = "listaDeSalasToolStripMenuItem";
            this.listaDeSalasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listaDeSalasToolStripMenuItem.Text = "Lista de Salas";
            this.listaDeSalasToolStripMenuItem.Click += new System.EventHandler(this.listaDeSalasToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarFilmeToolStripMenuItem,
            this.listaDeFilmesToolStripMenuItem,
            this.generosToolStripMenuItem});
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filmesToolStripMenuItem.Text = "Filmes";
            // 
            // adicionarFilmeToolStripMenuItem
            // 
            this.adicionarFilmeToolStripMenuItem.Name = "adicionarFilmeToolStripMenuItem";
            this.adicionarFilmeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.adicionarFilmeToolStripMenuItem.Text = "Adicionar Filme";
            this.adicionarFilmeToolStripMenuItem.Click += new System.EventHandler(this.adicionarFilmeToolStripMenuItem_Click);
            // 
            // listaDeFilmesToolStripMenuItem
            // 
            this.listaDeFilmesToolStripMenuItem.Name = "listaDeFilmesToolStripMenuItem";
            this.listaDeFilmesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.listaDeFilmesToolStripMenuItem.Text = "Lista de Filmes";
            this.listaDeFilmesToolStripMenuItem.Click += new System.EventHandler(this.listaDeFilmesToolStripMenuItem_Click);
            // 
            // generosToolStripMenuItem
            // 
            this.generosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarGêneroToolStripMenuItem,
            this.listaDeGênerosToolStripMenuItem});
            this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            this.generosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generosToolStripMenuItem.Text = "Generos";
            // 
            // adicionarGêneroToolStripMenuItem
            // 
            this.adicionarGêneroToolStripMenuItem.Name = "adicionarGêneroToolStripMenuItem";
            this.adicionarGêneroToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.adicionarGêneroToolStripMenuItem.Text = "Adicionar Gênero";
            // 
            // listaDeGênerosToolStripMenuItem
            // 
            this.listaDeGênerosToolStripMenuItem.Name = "listaDeGênerosToolStripMenuItem";
            this.listaDeGênerosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listaDeGênerosToolStripMenuItem.Text = "Lista de Gêneros";
            this.listaDeGênerosToolStripMenuItem.Click += new System.EventHandler(this.listaDeGênerosToolStripMenuItem_Click);
            // 
            // atoresDiretoresToolStripMenuItem
            // 
            this.atoresDiretoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarAtorDiretorToolStripMenuItem,
            this.listaDeAtoresDiretoresToolStripMenuItem});
            this.atoresDiretoresToolStripMenuItem.Name = "atoresDiretoresToolStripMenuItem";
            this.atoresDiretoresToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.atoresDiretoresToolStripMenuItem.Text = "Atores/Diretores";
            // 
            // adicionarAtorDiretorToolStripMenuItem
            // 
            this.adicionarAtorDiretorToolStripMenuItem.Name = "adicionarAtorDiretorToolStripMenuItem";
            this.adicionarAtorDiretorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.adicionarAtorDiretorToolStripMenuItem.Text = "Adicionar Ator/Diretor";
            this.adicionarAtorDiretorToolStripMenuItem.Click += new System.EventHandler(this.adicionarAtorDiretorToolStripMenuItem_Click);
            // 
            // listaDeAtoresDiretoresToolStripMenuItem
            // 
            this.listaDeAtoresDiretoresToolStripMenuItem.Name = "listaDeAtoresDiretoresToolStripMenuItem";
            this.listaDeAtoresDiretoresToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.listaDeAtoresDiretoresToolStripMenuItem.Text = "Lista de Atores/Diretores";
            this.listaDeAtoresDiretoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeAtoresDiretoresToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 617);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cine Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarCinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCinemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeFilmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarGêneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeGênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atoresDiretoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarAtorDiretorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAtoresDiretoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSessõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSalasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

