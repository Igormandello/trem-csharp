﻿namespace Trens
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
            this.posXMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.posYMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarPontoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirCidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCidadeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxCidades = new System.Windows.Forms.ToolStripComboBox();
            this.btnExcluirCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarCidadesMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCaminho = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCusto = new System.Windows.Forms.RadioButton();
            this.rbTempo = new System.Windows.Forms.RadioButton();
            this.rbDist = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).BeginInit();
            this.pnlCaminhos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesMenu,
            this.carregarCidadesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cidadesMenu
            // 
            this.cidadesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirCidadeMenu,
            this.excluirCidadeMenu,
            this.salvarCidadesMenu,
            this.carregarCidadesToolStripMenuItem});
            this.cidadesMenu.Name = "cidadesMenu";
            this.cidadesMenu.Size = new System.Drawing.Size(61, 20);
            this.cidadesMenu.Text = "Cidades";
            this.cidadesMenu.Visible = false;
            // 
            // incluirCidadeMenu
            // 
            this.incluirCidadeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posXMenu,
            this.posYMenu,
            this.toolStripSeparator1,
            this.mostrarPontoMenu,
            this.incluirCidadeToolStripMenuItem});
            this.incluirCidadeMenu.Name = "incluirCidadeMenu";
            this.incluirCidadeMenu.Size = new System.Drawing.Size(164, 22);
            this.incluirCidadeMenu.Text = "Incluir";
            this.incluirCidadeMenu.Click += new System.EventHandler(this.incluirCidade);
            // 
            // posXMenu
            // 
            this.posXMenu.Name = "posXMenu";
            this.posXMenu.Size = new System.Drawing.Size(181, 22);
            this.posXMenu.Text = "Posição X: 0.000";
            // 
            // posYMenu
            // 
            this.posYMenu.Name = "posYMenu";
            this.posYMenu.Size = new System.Drawing.Size(181, 22);
            this.posYMenu.Text = "Posição Y: 0.000";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // mostrarPontoMenu
            // 
            this.mostrarPontoMenu.Name = "mostrarPontoMenu";
            this.mostrarPontoMenu.Size = new System.Drawing.Size(181, 22);
            this.mostrarPontoMenu.Text = "Mostrar Ponto Atual";
            this.mostrarPontoMenu.Click += new System.EventHandler(this.alternarPonto);
            // 
            // incluirCidadeToolStripMenuItem
            // 
            this.incluirCidadeToolStripMenuItem.Name = "incluirCidadeToolStripMenuItem";
            this.incluirCidadeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.incluirCidadeToolStripMenuItem.Text = "Incluir Cidade";
            this.incluirCidadeToolStripMenuItem.Click += new System.EventHandler(this.incluirCidade);
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
            // salvarCidadesMenu
            // 
            this.salvarCidadesMenu.Name = "salvarCidadesMenu";
            this.salvarCidadesMenu.Size = new System.Drawing.Size(164, 22);
            this.salvarCidadesMenu.Text = "Salvar Cidades";
            this.salvarCidadesMenu.Click += new System.EventHandler(this.salvarCidades);
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
            this.mapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapa_MouseClick);
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
            this.cbxCidade2.Location = new System.Drawing.Point(152, 62);
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
            this.label2.Location = new System.Drawing.Point(149, 46);
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
            this.btnInserirCaminho.Location = new System.Drawing.Point(152, 117);
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
            this.btnSalvarCaminhos.Click += new System.EventHandler(this.salvarCaminhos);
            // 
            // btnCarregarCaminhos
            // 
            this.btnCarregarCaminhos.Location = new System.Drawing.Point(152, 174);
            this.btnCarregarCaminhos.Name = "btnCarregarCaminhos";
            this.btnCarregarCaminhos.Size = new System.Drawing.Size(120, 33);
            this.btnCarregarCaminhos.TabIndex = 10;
            this.btnCarregarCaminhos.Text = "Carregar Caminhos";
            this.btnCarregarCaminhos.UseVisualStyleBackColor = true;
            this.btnCarregarCaminhos.Click += new System.EventHandler(this.carregarCaminhos);
            // 
            // pnlCaminhos
            // 
            this.pnlCaminhos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCaminhos.Controls.Add(this.label4);
            this.pnlCaminhos.Controls.Add(this.btnCancelar);
            this.pnlCaminhos.Controls.Add(this.lbCaminho);
            this.pnlCaminhos.Controls.Add(this.groupBox1);
            this.pnlCaminhos.Controls.Add(this.btnBuscar);
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
            this.pnlCaminhos.Size = new System.Drawing.Size(287, 486);
            this.pnlCaminhos.TabIndex = 11;
            this.pnlCaminhos.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 82);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar Busca";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCaminho
            // 
            this.lbCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCaminho.FormattingEnabled = true;
            this.lbCaminho.IntegralHeight = false;
            this.lbCaminho.Location = new System.Drawing.Point(152, 271);
            this.lbCaminho.Name = "lbCaminho";
            this.lbCaminho.Size = new System.Drawing.Size(120, 206);
            this.lbCaminho.TabIndex = 12;
            this.lbCaminho.SelectedIndexChanged += new System.EventHandler(this.lbCaminho_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCusto);
            this.groupBox1.Controls.Add(this.rbTempo);
            this.groupBox1.Controls.Add(this.rbDist);
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 88);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetro de Busca";
            // 
            // rbCusto
            // 
            this.rbCusto.AutoSize = true;
            this.rbCusto.Location = new System.Drawing.Point(6, 65);
            this.rbCusto.Name = "rbCusto";
            this.rbCusto.Size = new System.Drawing.Size(52, 17);
            this.rbCusto.TabIndex = 2;
            this.rbCusto.Text = "Custo";
            this.rbCusto.UseVisualStyleBackColor = true;
            // 
            // rbTempo
            // 
            this.rbTempo.AutoSize = true;
            this.rbTempo.Location = new System.Drawing.Point(6, 42);
            this.rbTempo.Name = "rbTempo";
            this.rbTempo.Size = new System.Drawing.Size(58, 17);
            this.rbTempo.TabIndex = 1;
            this.rbTempo.Text = "Tempo";
            this.rbTempo.UseVisualStyleBackColor = true;
            // 
            // rbDist
            // 
            this.rbDist.AutoSize = true;
            this.rbDist.Checked = true;
            this.rbDist.Location = new System.Drawing.Point(6, 19);
            this.rbDist.Name = "rbDist";
            this.rbDist.Size = new System.Drawing.Size(69, 17);
            this.rbDist.TabIndex = 0;
            this.rbDist.TabStop = true;
            this.rbDist.Text = "Distância";
            this.rbDist.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 213);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(260, 33);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar Caminho";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.buscarCaminho);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Caminho (Clique para localizar)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 525);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCaminhos);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Trens Espanha/Portugal";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).EndInit();
            this.pnlCaminhos.ResumeLayout(false);
            this.pnlCaminhos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStripMenuItem salvarCidadesMenu;
        private System.Windows.Forms.ToolStripMenuItem posYMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mostrarPontoMenu;
        private System.Windows.Forms.ToolStripMenuItem incluirCidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posXMenu;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lbCaminho;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCusto;
        private System.Windows.Forms.RadioButton rbTempo;
        private System.Windows.Forms.RadioButton rbDist;
        private System.Windows.Forms.Label label4;
    }
}

