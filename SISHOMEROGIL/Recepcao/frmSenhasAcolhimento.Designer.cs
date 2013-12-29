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
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.cbComplemento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txCEP = new System.Windows.Forms.MaskedTextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.GpTipo = new System.Windows.Forms.GroupBox();
            this.lbAcolhimento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAcolhimento = new System.Windows.Forms.Button();
            this.btnAcolhimentoPrioridade = new System.Windows.Forms.Button();
            this.GPMarcacao = new System.Windows.Forms.GroupBox();
            this.lbMarcacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarcacaoNormal = new System.Windows.Forms.Button();
            this.btnMarcacaoPrioridade = new System.Windows.Forms.Button();
            this.lbMedico = new System.Windows.Forms.Label();
            this.lbEnfermeiro = new System.Windows.Forms.Label();
            this.lbACS = new System.Windows.Forms.Label();
            this.PnProfissionais = new System.Windows.Forms.Panel();
            this.gpEnderecos.SuspendLayout();
            this.GpTipo.SuspendLayout();
            this.GPMarcacao.SuspendLayout();
            this.PnProfissionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEnderecos
            // 
            this.gpEnderecos.Controls.Add(this.cbNumero);
            this.gpEnderecos.Controls.Add(this.lbComplemento);
            this.gpEnderecos.Controls.Add(this.cbComplemento);
            this.gpEnderecos.Controls.Add(this.label5);
            this.gpEnderecos.Controls.Add(this.label4);
            this.gpEnderecos.Controls.Add(this.label3);
            this.gpEnderecos.Controls.Add(this.txCEP);
            this.gpEnderecos.Controls.Add(this.lbBairro);
            this.gpEnderecos.Controls.Add(this.btnLimpar);
            this.gpEnderecos.Controls.Add(this.txLogradouro);
            this.gpEnderecos.Location = new System.Drawing.Point(12, 12);
            this.gpEnderecos.Name = "gpEnderecos";
            this.gpEnderecos.Size = new System.Drawing.Size(875, 150);
            this.gpEnderecos.TabIndex = 0;
            this.gpEnderecos.TabStop = false;
            this.gpEnderecos.Text = "Endereço do Paciente para o acolhimento";
            // 
            // cbNumero
            // 
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Location = new System.Drawing.Point(632, 63);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(95, 25);
            this.cbNumero.TabIndex = 10;
            this.cbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNumero_KeyDown);
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(730, 42);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(46, 17);
            this.lbComplemento.TabIndex = 9;
            this.lbComplemento.Text = "Comp:";
            this.lbComplemento.Visible = false;
            // 
            // cbComplemento
            // 
            this.cbComplemento.FormattingEnabled = true;
            this.cbComplemento.Location = new System.Drawing.Point(733, 62);
            this.cbComplemento.Name = "cbComplemento";
            this.cbComplemento.Size = new System.Drawing.Size(125, 25);
            this.cbComplemento.TabIndex = 8;
            this.cbComplemento.Visible = false;
            this.cbComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbComplemento_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nº:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "CEP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logradouro:";
            // 
            // txCEP
            // 
            this.txCEP.Location = new System.Drawing.Point(10, 62);
            this.txCEP.Mask = "00000-999";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(81, 25);
            this.txCEP.TabIndex = 3;
            this.txCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCEP_KeyDown);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(7, 106);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 17);
            this.lbBairro.TabIndex = 1;
            this.lbBairro.Text = "Bairro: -";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SISHOMEROGIL.Properties.Resources.clear16x16;
            this.btnLimpar.Location = new System.Drawing.Point(693, 94);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(34, 29);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txLogradouro
            // 
            this.txLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txLogradouro.Location = new System.Drawing.Point(106, 62);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.Size = new System.Drawing.Size(520, 25);
            this.txLogradouro.TabIndex = 0;
            this.txLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txLogradouro_KeyDown);
            // 
            // GpTipo
            // 
            this.GpTipo.Controls.Add(this.lbAcolhimento);
            this.GpTipo.Controls.Add(this.label1);
            this.GpTipo.Controls.Add(this.BtnAcolhimento);
            this.GpTipo.Controls.Add(this.btnAcolhimentoPrioridade);
            this.GpTipo.Location = new System.Drawing.Point(301, 168);
            this.GpTipo.Name = "GpTipo";
            this.GpTipo.Size = new System.Drawing.Size(586, 100);
            this.GpTipo.TabIndex = 1;
            this.GpTipo.TabStop = false;
            this.GpTipo.Text = "Acolhimento";
            this.GpTipo.Visible = false;
            // 
            // lbAcolhimento
            // 
            this.lbAcolhimento.AutoSize = true;
            this.lbAcolhimento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcolhimento.ForeColor = System.Drawing.Color.Coral;
            this.lbAcolhimento.Location = new System.Drawing.Point(395, 50);
            this.lbAcolhimento.Name = "lbAcolhimento";
            this.lbAcolhimento.Size = new System.Drawing.Size(32, 25);
            this.lbAcolhimento.TabIndex = 4;
            this.lbAcolhimento.Text = "00";
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
            this.GPMarcacao.Controls.Add(this.lbMarcacao);
            this.GPMarcacao.Controls.Add(this.label2);
            this.GPMarcacao.Controls.Add(this.btnMarcacaoNormal);
            this.GPMarcacao.Controls.Add(this.btnMarcacaoPrioridade);
            this.GPMarcacao.Location = new System.Drawing.Point(301, 274);
            this.GPMarcacao.Name = "GPMarcacao";
            this.GPMarcacao.Size = new System.Drawing.Size(586, 100);
            this.GPMarcacao.TabIndex = 2;
            this.GPMarcacao.TabStop = false;
            this.GPMarcacao.Text = "Marcação de consultas";
            this.GPMarcacao.Visible = false;
            // 
            // lbMarcacao
            // 
            this.lbMarcacao.AutoSize = true;
            this.lbMarcacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcacao.ForeColor = System.Drawing.Color.Coral;
            this.lbMarcacao.Location = new System.Drawing.Point(395, 57);
            this.lbMarcacao.Name = "lbMarcacao";
            this.lbMarcacao.Size = new System.Drawing.Size(32, 25);
            this.lbMarcacao.TabIndex = 5;
            this.lbMarcacao.Text = "00";
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
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(13, 33);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(64, 17);
            this.lbMedico.TabIndex = 4;
            this.lbMedico.Text = "Médico: -";
            // 
            // lbEnfermeiro
            // 
            this.lbEnfermeiro.AutoSize = true;
            this.lbEnfermeiro.Location = new System.Drawing.Point(13, 83);
            this.lbEnfermeiro.Name = "lbEnfermeiro";
            this.lbEnfermeiro.Size = new System.Drawing.Size(84, 17);
            this.lbEnfermeiro.TabIndex = 5;
            this.lbEnfermeiro.Text = "Enfermeiro: -";
            // 
            // lbACS
            // 
            this.lbACS.AutoSize = true;
            this.lbACS.Location = new System.Drawing.Point(13, 129);
            this.lbACS.Name = "lbACS";
            this.lbACS.Size = new System.Drawing.Size(43, 17);
            this.lbACS.TabIndex = 6;
            this.lbACS.Text = "ACS: -";
            // 
            // PnProfissionais
            // 
            this.PnProfissionais.Controls.Add(this.lbEnfermeiro);
            this.PnProfissionais.Controls.Add(this.lbACS);
            this.PnProfissionais.Controls.Add(this.lbMedico);
            this.PnProfissionais.Location = new System.Drawing.Point(12, 168);
            this.PnProfissionais.Name = "PnProfissionais";
            this.PnProfissionais.Size = new System.Drawing.Size(283, 206);
            this.PnProfissionais.TabIndex = 7;
            this.PnProfissionais.Visible = false;
            // 
            // frmSenhasAcolhimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 394);
            this.Controls.Add(this.PnProfissionais);
            this.Controls.Add(this.GPMarcacao);
            this.Controls.Add(this.GpTipo);
            this.Controls.Add(this.gpEnderecos);
            this.KeyPreview = true;
            this.Name = "frmSenhasAcolhimento";
            this.Text = "frmSenhasAcolhimento";
            this.Load += new System.EventHandler(this.frmSenhasAcolhimento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSenhasAcolhimento_KeyDown);
            this.gpEnderecos.ResumeLayout(false);
            this.gpEnderecos.PerformLayout();
            this.GpTipo.ResumeLayout(false);
            this.GpTipo.PerformLayout();
            this.GPMarcacao.ResumeLayout(false);
            this.GPMarcacao.PerformLayout();
            this.PnProfissionais.ResumeLayout(false);
            this.PnProfissionais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEnderecos;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.GroupBox GpTipo;
        private System.Windows.Forms.Button BtnAcolhimento;
        private System.Windows.Forms.Button btnAcolhimentoPrioridade;
        private System.Windows.Forms.GroupBox GPMarcacao;
        private System.Windows.Forms.Button btnMarcacaoNormal;
        private System.Windows.Forms.Button btnMarcacaoPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAcolhimento;
        private System.Windows.Forms.Label lbMarcacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.Label lbEnfermeiro;
        private System.Windows.Forms.MaskedTextBox txCEP;
        private System.Windows.Forms.Label lbACS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PnProfissionais;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.ComboBox cbComplemento;
        private System.Windows.Forms.ComboBox cbNumero;
    }
}