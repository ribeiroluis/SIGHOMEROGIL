namespace SISHOMEROGIL.Recepcao
{
    partial class frmSenhasAcolhimento
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
            this.gpEnderecos = new System.Windows.Forms.GroupBox();
            this.linkConsultaCEP = new System.Windows.Forms.LinkLabel();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.GpTipo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAcolhimento = new System.Windows.Forms.Button();
            this.btnAcolhimentoPrioridade = new System.Windows.Forms.Button();
            this.GPMarcacao = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarcacaoNormal = new System.Windows.Forms.Button();
            this.btnMarcacaoPrioridade = new System.Windows.Forms.Button();
            this.gpEnderecos.SuspendLayout();
            this.GpTipo.SuspendLayout();
            this.GPMarcacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEnderecos
            // 
            this.gpEnderecos.Controls.Add(this.linkConsultaCEP);
            this.gpEnderecos.Controls.Add(this.lbBairro);
            this.gpEnderecos.Controls.Add(this.txLogradouro);
            this.gpEnderecos.Location = new System.Drawing.Point(12, 12);
            this.gpEnderecos.Name = "gpEnderecos";
            this.gpEnderecos.Size = new System.Drawing.Size(781, 112);
            this.gpEnderecos.TabIndex = 0;
            this.gpEnderecos.TabStop = false;
            this.gpEnderecos.Text = "Endereço do Paciente para o acolhimento";
            // 
            // linkConsultaCEP
            // 
            this.linkConsultaCEP.AutoSize = true;
            this.linkConsultaCEP.Location = new System.Drawing.Point(694, 84);
            this.linkConsultaCEP.Name = "linkConsultaCEP";
            this.linkConsultaCEP.Size = new System.Drawing.Size(83, 17);
            this.linkConsultaCEP.TabIndex = 2;
            this.linkConsultaCEP.TabStop = true;
            this.linkConsultaCEP.Text = "Conultar CEP";
            this.linkConsultaCEP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConsultaCEP_LinkClicked);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(12, 71);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 17);
            this.lbBairro.TabIndex = 1;
            this.lbBairro.Text = "Bairro: -";
            // 
            // txLogradouro
            // 
            this.txLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txLogradouro.Location = new System.Drawing.Point(15, 43);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.Size = new System.Drawing.Size(744, 25);
            this.txLogradouro.TabIndex = 0;
            this.txLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txLogradouro_KeyDown);
            // 
            // GpTipo
            // 
            this.GpTipo.Controls.Add(this.label3);
            this.GpTipo.Controls.Add(this.label1);
            this.GpTipo.Controls.Add(this.BtnAcolhimento);
            this.GpTipo.Controls.Add(this.btnAcolhimentoPrioridade);
            this.GpTipo.Location = new System.Drawing.Point(163, 146);
            this.GpTipo.Name = "GpTipo";
            this.GpTipo.Size = new System.Drawing.Size(539, 100);
            this.GpTipo.TabIndex = 1;
            this.GpTipo.TabStop = false;
            this.GpTipo.Text = "Acolhimento";
            this.GpTipo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(452, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prioridade";
            // 
            // BtnAcolhimento
            // 
            this.BtnAcolhimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcolhimento.Location = new System.Drawing.Point(252, 33);
            this.BtnAcolhimento.Name = "BtnAcolhimento";
            this.BtnAcolhimento.Size = new System.Drawing.Size(127, 49);
            this.BtnAcolhimento.TabIndex = 0;
            this.BtnAcolhimento.Text = "Não";
            this.BtnAcolhimento.UseVisualStyleBackColor = true;
            this.BtnAcolhimento.Click += new System.EventHandler(this.BtnAcolhimento_Click);
            // 
            // btnAcolhimentoPrioridade
            // 
            this.btnAcolhimentoPrioridade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcolhimentoPrioridade.Location = new System.Drawing.Point(119, 33);
            this.btnAcolhimentoPrioridade.Name = "btnAcolhimentoPrioridade";
            this.btnAcolhimentoPrioridade.Size = new System.Drawing.Size(127, 49);
            this.btnAcolhimentoPrioridade.TabIndex = 0;
            this.btnAcolhimentoPrioridade.Text = "Sim";
            this.btnAcolhimentoPrioridade.UseVisualStyleBackColor = true;
            this.btnAcolhimentoPrioridade.Click += new System.EventHandler(this.btnAcolhimentoPrioridade_Click);
            // 
            // GPMarcacao
            // 
            this.GPMarcacao.Controls.Add(this.label4);
            this.GPMarcacao.Controls.Add(this.label2);
            this.GPMarcacao.Controls.Add(this.btnMarcacaoNormal);
            this.GPMarcacao.Controls.Add(this.btnMarcacaoPrioridade);
            this.GPMarcacao.Location = new System.Drawing.Point(163, 269);
            this.GPMarcacao.Name = "GPMarcacao";
            this.GPMarcacao.Size = new System.Drawing.Size(539, 100);
            this.GPMarcacao.TabIndex = 2;
            this.GPMarcacao.TabStop = false;
            this.GPMarcacao.Text = "Marcação de consultas";
            this.GPMarcacao.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(452, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prioridade";
            // 
            // btnMarcacaoNormal
            // 
            this.btnMarcacaoNormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcacaoNormal.Location = new System.Drawing.Point(252, 33);
            this.btnMarcacaoNormal.Name = "btnMarcacaoNormal";
            this.btnMarcacaoNormal.Size = new System.Drawing.Size(127, 49);
            this.btnMarcacaoNormal.TabIndex = 0;
            this.btnMarcacaoNormal.Text = "Não";
            this.btnMarcacaoNormal.UseVisualStyleBackColor = true;
            this.btnMarcacaoNormal.Click += new System.EventHandler(this.btnMarcacaoNormal_Click);
            // 
            // btnMarcacaoPrioridade
            // 
            this.btnMarcacaoPrioridade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcacaoPrioridade.Location = new System.Drawing.Point(119, 33);
            this.btnMarcacaoPrioridade.Name = "btnMarcacaoPrioridade";
            this.btnMarcacaoPrioridade.Size = new System.Drawing.Size(127, 49);
            this.btnMarcacaoPrioridade.TabIndex = 0;
            this.btnMarcacaoPrioridade.Text = "Sim";
            this.btnMarcacaoPrioridade.UseVisualStyleBackColor = true;
            this.btnMarcacaoPrioridade.Click += new System.EventHandler(this.btnMarcacaoPrioridade_Click);
            // 
            // frmSenhasAcolhimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 435);
            this.Controls.Add(this.GPMarcacao);
            this.Controls.Add(this.GpTipo);
            this.Controls.Add(this.gpEnderecos);
            this.Name = "frmSenhasAcolhimento";
            this.Text = "frmSenhasAcolhimento";
            this.Load += new System.EventHandler(this.frmSenhasAcolhimento_Load);
            this.gpEnderecos.ResumeLayout(false);
            this.gpEnderecos.PerformLayout();
            this.GpTipo.ResumeLayout(false);
            this.GpTipo.PerformLayout();
            this.GPMarcacao.ResumeLayout(false);
            this.GPMarcacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEnderecos;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.LinkLabel linkConsultaCEP;
        private System.Windows.Forms.GroupBox GpTipo;
        private System.Windows.Forms.Button BtnAcolhimento;
        private System.Windows.Forms.Button btnAcolhimentoPrioridade;
        private System.Windows.Forms.GroupBox GPMarcacao;
        private System.Windows.Forms.Button btnMarcacaoNormal;
        private System.Windows.Forms.Button btnMarcacaoPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}