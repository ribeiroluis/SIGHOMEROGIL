namespace SISHOMEROGIL.Recepcao
{
    partial class frmSenhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenhas));
            this.pnAcolhimento = new System.Windows.Forms.GroupBox();
            this.btnMarcacao = new System.Windows.Forms.Button();
            this.btnMulherCrianca = new System.Windows.Forms.Button();
            this.btnAdulto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbClinica = new System.Windows.Forms.Label();
            this.lbGinceco = new System.Windows.Forms.Label();
            this.lbMarc = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.pnAcolhimento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAcolhimento
            // 
            this.pnAcolhimento.Controls.Add(this.lbMarc);
            this.pnAcolhimento.Controls.Add(this.lbGinceco);
            this.pnAcolhimento.Controls.Add(this.lbClinica);
            this.pnAcolhimento.Controls.Add(this.btnMarcacao);
            this.pnAcolhimento.Controls.Add(this.btnMulherCrianca);
            this.pnAcolhimento.Controls.Add(this.btnAdulto);
            this.pnAcolhimento.Location = new System.Drawing.Point(39, 13);
            this.pnAcolhimento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnAcolhimento.Name = "pnAcolhimento";
            this.pnAcolhimento.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnAcolhimento.Size = new System.Drawing.Size(536, 226);
            this.pnAcolhimento.TabIndex = 0;
            this.pnAcolhimento.TabStop = false;
            this.pnAcolhimento.Text = "Acolhimento - Marcação de Consulta";
            // 
            // btnMarcacao
            // 
            this.btnMarcacao.Location = new System.Drawing.Point(27, 150);
            this.btnMarcacao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMarcacao.Name = "btnMarcacao";
            this.btnMarcacao.Size = new System.Drawing.Size(467, 52);
            this.btnMarcacao.TabIndex = 0;
            this.btnMarcacao.Text = "Marcação de Consulta";
            this.btnMarcacao.UseVisualStyleBackColor = true;
            this.btnMarcacao.Click += new System.EventHandler(this.btnMarcacao_Click);
            // 
            // btnMulherCrianca
            // 
            this.btnMulherCrianca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMulherCrianca.Location = new System.Drawing.Point(27, 91);
            this.btnMulherCrianca.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMulherCrianca.MaximumSize = new System.Drawing.Size(467, 52);
            this.btnMulherCrianca.MinimumSize = new System.Drawing.Size(467, 52);
            this.btnMulherCrianca.Name = "btnMulherCrianca";
            this.btnMulherCrianca.Size = new System.Drawing.Size(467, 52);
            this.btnMulherCrianca.TabIndex = 0;
            this.btnMulherCrianca.Text = "Ginecologia / Pediatria";
            this.btnMulherCrianca.UseVisualStyleBackColor = true;
            this.btnMulherCrianca.Click += new System.EventHandler(this.btnMulherCrianca_Click);
            // 
            // btnAdulto
            // 
            this.btnAdulto.Location = new System.Drawing.Point(27, 31);
            this.btnAdulto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdulto.Name = "btnAdulto";
            this.btnAdulto.Size = new System.Drawing.Size(467, 52);
            this.btnAdulto.TabIndex = 0;
            this.btnAdulto.Text = "Clinica Médica";
            this.btnAdulto.UseVisualStyleBackColor = true;
            this.btnAdulto.Click += new System.EventHandler(this.btnAdulto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNao);
            this.groupBox2.Controls.Add(this.btnSim);
            this.groupBox2.Location = new System.Drawing.Point(89, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(417, 162);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prioridade";
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(262, 61);
            this.btnNao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(124, 52);
            this.btnNao.TabIndex = 0;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(64, 61);
            this.btnSim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(124, 52);
            this.btnSim.TabIndex = 0;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(581, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 14);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbClinica
            // 
            this.lbClinica.AutoSize = true;
            this.lbClinica.BackColor = System.Drawing.Color.Transparent;
            this.lbClinica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbClinica.ForeColor = System.Drawing.Color.Red;
            this.lbClinica.Location = new System.Drawing.Point(415, 46);
            this.lbClinica.Name = "lbClinica";
            this.lbClinica.Size = new System.Drawing.Size(68, 24);
            this.lbClinica.TabIndex = 1;
            this.lbClinica.Text = "Clinica";
            // 
            // lbGinceco
            // 
            this.lbGinceco.AutoSize = true;
            this.lbGinceco.BackColor = System.Drawing.Color.Transparent;
            this.lbGinceco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGinceco.ForeColor = System.Drawing.Color.Red;
            this.lbGinceco.Location = new System.Drawing.Point(415, 106);
            this.lbGinceco.Name = "lbGinceco";
            this.lbGinceco.Size = new System.Drawing.Size(73, 24);
            this.lbGinceco.TabIndex = 1;
            this.lbGinceco.Text = "Gineco";
            // 
            // lbMarc
            // 
            this.lbMarc.AutoSize = true;
            this.lbMarc.BackColor = System.Drawing.Color.Transparent;
            this.lbMarc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMarc.ForeColor = System.Drawing.Color.Red;
            this.lbMarc.Location = new System.Drawing.Point(415, 161);
            this.lbMarc.Name = "lbMarc";
            this.lbMarc.Size = new System.Drawing.Size(73, 24);
            this.lbMarc.TabIndex = 1;
            this.lbMarc.Text = "Marcac";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbtotal.ForeColor = System.Drawing.Color.Red;
            this.lbtotal.Location = new System.Drawing.Point(39, 248);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(73, 24);
            this.lbtotal.TabIndex = 1;
            this.lbtotal.Text = "Marcac";
            // 
            // frmSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 281);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pnAcolhimento);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSenhas";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIG Homero Gil - Senhas";
            this.Load += new System.EventHandler(this.frmSenhas_Load);
            this.pnAcolhimento.ResumeLayout(false);
            this.pnAcolhimento.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pnAcolhimento;
        private System.Windows.Forms.Button btnMulherCrianca;
        private System.Windows.Forms.Button btnAdulto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnMarcacao;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbMarc;
        private System.Windows.Forms.Label lbGinceco;
        private System.Windows.Forms.Label lbClinica;
        private System.Windows.Forms.Label lbtotal;
    }
}