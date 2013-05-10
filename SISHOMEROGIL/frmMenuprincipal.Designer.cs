namespace SISHOMEROGIL
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SubMenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuAcolhimento = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuConsultaEspecializada = new System.Windows.Forms.ToolStripMenuItem();
            this.examesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuFarmacia = new System.Windows.Forms.ToolStripMenuItem();
            this.dispensarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GerenciarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RelatorioEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuGerencia = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRecepcao = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbToolStrip
            // 
            this.lbToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToolStrip.Name = "lbToolStrip";
            this.lbToolStrip.Size = new System.Drawing.Size(72, 17);
            this.lbToolStrip.Text = "lbToolStrip";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuArquivo,
            this.SubMenuAcolhimento,
            this.SubMenuConsultaEspecializada,
            this.SubMenuFarmacia,
            this.SubMenuGerencia,
            this.SubMenuRecepcao,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SubMenuArquivo
            // 
            this.SubMenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarUsuarioToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.SubMenuArquivo.Name = "SubMenuArquivo";
            this.SubMenuArquivo.Size = new System.Drawing.Size(65, 21);
            this.SubMenuArquivo.Text = "Arquivo";
            // 
            // alterarUsuarioToolStripMenuItem
            // 
            this.alterarUsuarioToolStripMenuItem.Name = "alterarUsuarioToolStripMenuItem";
            this.alterarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.alterarUsuarioToolStripMenuItem.Text = "Alterar usuario";
            this.alterarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.alterarUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // SubMenuAcolhimento
            // 
            this.SubMenuAcolhimento.Enabled = false;
            this.SubMenuAcolhimento.Name = "SubMenuAcolhimento";
            this.SubMenuAcolhimento.Size = new System.Drawing.Size(92, 21);
            this.SubMenuAcolhimento.Text = "Acolhimento";
            this.SubMenuAcolhimento.Click += new System.EventHandler(this.SubMenuAcolhimento_Click);
            // 
            // SubMenuConsultaEspecializada
            // 
            this.SubMenuConsultaEspecializada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.SubMenuConsultaEspecializada.Enabled = false;
            this.SubMenuConsultaEspecializada.Name = "SubMenuConsultaEspecializada";
            this.SubMenuConsultaEspecializada.Size = new System.Drawing.Size(164, 21);
            this.SubMenuConsultaEspecializada.Text = "Consultas Especializadas";
            // 
            // examesToolStripMenuItem
            // 
            this.examesToolStripMenuItem.Name = "examesToolStripMenuItem";
            this.examesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.examesToolStripMenuItem.Text = "Exames";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // SubMenuFarmacia
            // 
            this.SubMenuFarmacia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispensarToolStripMenuItem,
            this.gerenciarMedicamentoToolStripMenuItem});
            this.SubMenuFarmacia.Enabled = false;
            this.SubMenuFarmacia.Name = "SubMenuFarmacia";
            this.SubMenuFarmacia.Size = new System.Drawing.Size(72, 21);
            this.SubMenuFarmacia.Text = "Farmacia";
            // 
            // dispensarToolStripMenuItem
            // 
            this.dispensarToolStripMenuItem.Name = "dispensarToolStripMenuItem";
            this.dispensarToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.dispensarToolStripMenuItem.Text = "Dispensar Medicamentos";
            this.dispensarToolStripMenuItem.Click += new System.EventHandler(this.dispensarToolStripMenuItem_Click);
            // 
            // gerenciarMedicamentoToolStripMenuItem
            // 
            this.gerenciarMedicamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GerenciarEstoqueToolStripMenuItem,
            this.RelatorioEstoqueToolStripMenuItem});
            this.gerenciarMedicamentoToolStripMenuItem.Enabled = false;
            this.gerenciarMedicamentoToolStripMenuItem.Name = "gerenciarMedicamentoToolStripMenuItem";
            this.gerenciarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.gerenciarMedicamentoToolStripMenuItem.Text = "Gerenciar Medicamentos";
            // 
            // GerenciarEstoqueToolStripMenuItem
            // 
            this.GerenciarEstoqueToolStripMenuItem.Name = "GerenciarEstoqueToolStripMenuItem";
            this.GerenciarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.GerenciarEstoqueToolStripMenuItem.Text = "Gerenciar Estoque";
            this.GerenciarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.GerenciarEstoqueToolStripMenuItem_Click);
            // 
            // RelatorioEstoqueToolStripMenuItem
            // 
            this.RelatorioEstoqueToolStripMenuItem.Name = "RelatorioEstoqueToolStripMenuItem";
            this.RelatorioEstoqueToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.RelatorioEstoqueToolStripMenuItem.Text = "Relatorio de Estoque";
            // 
            // SubMenuGerencia
            // 
            this.SubMenuGerencia.Enabled = false;
            this.SubMenuGerencia.Name = "SubMenuGerencia";
            this.SubMenuGerencia.Size = new System.Drawing.Size(71, 21);
            this.SubMenuGerencia.Text = "Gerência";
            // 
            // SubMenuRecepcao
            // 
            this.SubMenuRecepcao.Enabled = false;
            this.SubMenuRecepcao.Name = "SubMenuRecepcao";
            this.SubMenuRecepcao.Size = new System.Drawing.Size(77, 21);
            this.SubMenuRecepcao.Text = "Recepção";
            this.SubMenuRecepcao.Click += new System.EventHandler(this.SubMenuRecepcao_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarUsuáriosToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // gerenciarUsuáriosToolStripMenuItem
            // 
            this.gerenciarUsuáriosToolStripMenuItem.Name = "gerenciarUsuáriosToolStripMenuItem";
            this.gerenciarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar Usuários";
            this.gerenciarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUsuáriosToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMenuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbToolStrip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SubMenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem SubMenuConsultaEspecializada;
        private System.Windows.Forms.ToolStripMenuItem SubMenuFarmacia;
        private System.Windows.Forms.ToolStripMenuItem SubMenuGerencia;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRecepcao;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubMenuAcolhimento;
        private System.Windows.Forms.ToolStripMenuItem examesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispensarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GerenciarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RelatorioEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem;
    }
}