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
            this.caminhosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarCidadesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.mapa = new System.Windows.Forms.PictureBox();
            this.carregarCidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarCaminhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesMenu,
            this.caminhosMenu,
            this.carregarCidadesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
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
            this.excluirCidadeMenu.Name = "excluirCidadeMenu";
            this.excluirCidadeMenu.Size = new System.Drawing.Size(164, 22);
            this.excluirCidadeMenu.Text = "Excluir";
            this.excluirCidadeMenu.Click += new System.EventHandler(this.excluirCidade);
            // 
            // caminhosMenu
            // 
            this.caminhosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.carregarCaminhosToolStripMenuItem});
            this.caminhosMenu.Name = "caminhosMenu";
            this.caminhosMenu.Size = new System.Drawing.Size(73, 20);
            this.caminhosMenu.Text = "Caminhos";
            this.caminhosMenu.Visible = false;
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
            // 
            // carregarCidadesToolStripMenuItem
            // 
            this.carregarCidadesToolStripMenuItem.Name = "carregarCidadesToolStripMenuItem";
            this.carregarCidadesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.carregarCidadesToolStripMenuItem.Text = "Carregar Cidades";
            this.carregarCidadesToolStripMenuItem.Click += new System.EventHandler(this.carregarCidades);
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.incluirToolStripMenuItem.Text = "Incluir";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // carregarCaminhosToolStripMenuItem
            // 
            this.carregarCaminhosToolStripMenuItem.Name = "carregarCaminhosToolStripMenuItem";
            this.carregarCaminhosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.carregarCaminhosToolStripMenuItem.Text = "Carregar Caminhos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 525);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cidadesMenu;
        private System.Windows.Forms.ToolStripMenuItem caminhosMenu;
        private System.Windows.Forms.ToolStripMenuItem incluirCidadeMenu;
        private System.Windows.Forms.ToolStripMenuItem excluirCidadeMenu;
        private System.Windows.Forms.ToolStripMenuItem carregarCidadesMenu;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.PictureBox mapa;
        private System.Windows.Forms.ToolStripMenuItem carregarCidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarCaminhosToolStripMenuItem;
    }
}

