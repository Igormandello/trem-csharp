namespace Trens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cidadesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirCidadeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCidadeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCidades = new System.Windows.Forms.ToolStripComboBox();
            this.btnExcluirCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarCidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarCidadesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.mapa = new System.Windows.Forms.PictureBox();
            this.cbxCidade1 = new System.Windows.Forms.ComboBox();
            this.cbxCidade2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluirCaminho = new System.Windows.Forms.Button();
            this.btnInserirCaminho = new System.Windows.Forms.Button();
            this.btnSalvarCaminhos = new System.Windows.Forms.Button();
            this.btnCarregarCaminhos = new System.Windows.Forms.Button();
            this.pnlCaminhos = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).BeginInit();
            this.pnlCaminhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesMenu,
            this.carregarCidadesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cidadesMenu
            // 
            this.cidadesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirCidadeMenu,
            this.excluirCidadeMenu,
            this.carregarCidadesToolStripMenuItem});
            this.cidadesMenu.Name = "cidadesMenu";
            this.cidadesMenu.Size = new System.Drawing.Size(61, 20);
            this.cidadesMenu.Text = "Cidades";
            this.cidadesMenu.Visible = false;
            // 
            // incluirCidadeMenu
            // 
            this.incluirCidadeMenu.Name = "incluirCidadeMenu";
            this.incluirCidadeMenu.Size = new System.Drawing.Size(164, 22);
            this.incluirCidadeMenu.Text = "Incluir";
            this.incluirCidadeMenu.Click += new System.EventHandler(this.incluirCidade);
            // 
            // excluirCidadeMenu
            // 
            this.excluirCidadeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbxCidades,
            this.btnExcluirCidade});
            this.excluirCidadeMenu.Name = "excluirCidadeMenu";
            this.excluirCidadeMenu.Size = new System.Drawing.Size(164, 22);
            this.excluirCidadeMenu.Text = "Excluir";
            // 
            // cbxCidades
            // 
            this.cbxCidades.CausesValidation = false;
            this.cbxCidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidades.Name = "cbxCidades";
            this.cbxCidades.Size = new System.Drawing.Size(121, 23);
            // 
            // btnExcluirCidade
            // 
            this.btnExcluirCidade.Name = "btnExcluirCidade";
            this.btnExcluirCidade.Size = new System.Drawing.Size(181, 22);
            this.btnExcluirCidade.Text = "Excluir";
            this.btnExcluirCidade.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnExcluirCidade.Click += new System.EventHandler(this.excluirCidade);
            // 
            // carregarCidadesToolStripMenuItem
            // 
            this.carregarCidadesToolStripMenuItem.Name = "carregarCidadesToolStripMenuItem";
            this.carregarCidadesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.carregarCidadesToolStripMenuItem.Text = "Carregar Cidades";
            this.carregarCidadesToolStripMenuItem.Click += new System.EventHandler(this.carregarCidades);
            // 
            // carregarCidadesMenu
            // 
            this.carregarCidadesMenu.Name = "carregarCidadesMenu";
            this.carregarCidadesMenu.Size = new System.Drawing.Size(109, 20);
            this.carregarCidadesMenu.Text = "Carregar Cidades";
            this.carregarCidadesMenu.Click += new System.EventHandler(this.carregarCidades);
            // 
            // mapa
            // 
            this.mapa.Image = ((System.Drawing.Image)(resources.GetObject("mapa.Image")));
            this.mapa.Location = new System.Drawing.Point(12, 27);
            this.mapa.Name = "mapa";
            this.mapa.Size = new System.Drawing.Size(606, 486);
            this.mapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapa.TabIndex = 1;
            this.mapa.TabStop = false;
            this.mapa.Paint += new System.Windows.Forms.PaintEventHandler(this.mapa_Paint);
            // 
            // cbxCidade1
            // 
            this.cbxCidade1.FormattingEnabled = true;
            this.cbxCidade1.Location = new System.Drawing.Point(12, 62);
            this.cbxCidade1.Margin = new System.Windows.Forms.Padding(15, 65, 3, 3);
            this.cbxCidade1.Name = "cbxCidade1";
            this.cbxCidade1.Size = new System.Drawing.Size(120, 21);
            this.cbxCidade1.TabIndex = 2;
            // 
            // cbxCidade2
            // 
            this.cbxCidade2.FormattingEnabled = true;
            this.cbxCidade2.Location = new System.Drawing.Point(145, 62);
            this.cbxCidade2.Margin = new System.Windows.Forms.Padding(10, 65, 15, 3);
            this.cbxCidade2.Name = "cbxCidade2";
            this.cbxCidade2.Size = new System.Drawing.Size(120, 21);
            this.cbxCidade2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cidade Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cidade Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminhos";
            // 
            // btnExcluirCaminho
            // 
            this.btnExcluirCaminho.Location = new System.Drawing.Point(12, 117);
            this.btnExcluirCaminho.Name = "btnExcluirCaminho";
            this.btnExcluirCaminho.Size = new System.Drawing.Size(120, 51);
            this.btnExcluirCaminho.TabIndex = 7;
            this.btnExcluirCaminho.Text = "Excluir";
            this.btnExcluirCaminho.UseVisualStyleBackColor = true;
            this.btnExcluirCaminho.Click += new System.EventHandler(this.excluirCaminho);
            // 
            // btnInserirCaminho
            // 
            this.btnInserirCaminho.Location = new System.Drawing.Point(145, 117);
            this.btnInserirCaminho.Name = "btnInserirCaminho";
            this.btnInserirCaminho.Size = new System.Drawing.Size(120, 51);
            this.btnInserirCaminho.TabIndex = 8;
            this.btnInserirCaminho.Text = "Inserir";
            this.btnInserirCaminho.UseVisualStyleBackColor = true;
            this.btnInserirCaminho.Click += new System.EventHandler(this.inserirCaminho);
            // 
            // btnSalvarCaminhos
            // 
            this.btnSalvarCaminhos.Location = new System.Drawing.Point(12, 174);
            this.btnSalvarCaminhos.Name = "btnSalvarCaminhos";
            this.btnSalvarCaminhos.Size = new System.Drawing.Size(120, 33);
            this.btnSalvarCaminhos.TabIndex = 9;
            this.btnSalvarCaminhos.Text = "Salvar Caminhos";
            this.btnSalvarCaminhos.UseVisualStyleBackColor = true;
            // 
            // btnCarregarCaminhos
            // 
            this.btnCarregarCaminhos.Location = new System.Drawing.Point(145, 174);
            this.btnCarregarCaminhos.Name = "btnCarregarCaminhos";
            this.btnCarregarCaminhos.Size = new System.Drawing.Size(120, 33);
            this.btnCarregarCaminhos.TabIndex = 10;
            this.btnCarregarCaminhos.Text = "Carregar Caminhos";
            this.btnCarregarCaminhos.UseVisualStyleBackColor = true;
            this.btnCarregarCaminhos.Click += new System.EventHandler(this.carregarCaminhos);
            // 
            // pnlCaminhos
            // 
            this.pnlCaminhos.Controls.Add(this.btnCarregarCaminhos);
            this.pnlCaminhos.Controls.Add(this.label3);
            this.pnlCaminhos.Controls.Add(this.btnSalvarCaminhos);
            this.pnlCaminhos.Controls.Add(this.cbxCidade1);
            this.pnlCaminhos.Controls.Add(this.btnExcluirCaminho);
            this.pnlCaminhos.Controls.Add(this.btnInserirCaminho);
            this.pnlCaminhos.Controls.Add(this.label1);
            this.pnlCaminhos.Controls.Add(this.label2);
            this.pnlCaminhos.Controls.Add(this.cbxCidade2);
            this.pnlCaminhos.Location = new System.Drawing.Point(624, 27);
            this.pnlCaminhos.Name = "pnlCaminhos";
            this.pnlCaminhos.Size = new System.Drawing.Size(277, 226);
            this.pnlCaminhos.TabIndex = 11;
            this.pnlCaminhos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 525);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCaminhos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).EndInit();
            this.pnlCaminhos.ResumeLayout(false);
            this.pnlCaminhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cidadesMenu;
        private System.Windows.Forms.ToolStripMenuItem incluirCidadeMenu;
        private System.Windows.Forms.ToolStripMenuItem excluirCidadeMenu;
        private System.Windows.Forms.ToolStripMenuItem carregarCidadesMenu;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.PictureBox mapa;
        private System.Windows.Forms.ToolStripMenuItem carregarCidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbxCidades;
        private System.Windows.Forms.ToolStripMenuItem btnExcluirCidade;
        private System.Windows.Forms.ComboBox cbxCidade1;
        private System.Windows.Forms.ComboBox cbxCidade2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluirCaminho;
        private System.Windows.Forms.Button btnInserirCaminho;
        private System.Windows.Forms.Button btnSalvarCaminhos;
        private System.Windows.Forms.Button btnCarregarCaminhos;
        private System.Windows.Forms.Panel pnlCaminhos;
    }
}

