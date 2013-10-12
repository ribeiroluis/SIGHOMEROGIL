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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.linkConsultaCEP = new System.Windows.Forms.LinkLabel();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.GpTipo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GpTipo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.linkConsultaCEP);
            this.groupBox1.Controls.Add(this.lbBairro);
            this.groupBox1.Controls.Add(this.txLogradouro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço do Paciente para o acolhimento";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(697, 104);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "button1";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.GpTipo.Controls.Add(this.button2);
            this.GpTipo.Controls.Add(this.button1);
            this.GpTipo.Location = new System.Drawing.Point(220, 172);
            this.GpTipo.Name = "GpTipo";
            this.GpTipo.Size = new System.Drawing.Size(383, 100);
            this.GpTipo.TabIndex = 1;
            this.GpTipo.TabStop = false;
            this.GpTipo.Text = "Acolhimento";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sim";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(224, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sim";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(220, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marcação de consultas";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(224, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 0;
            this.button3.Text = "Sim";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(68, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 49);
            this.button4.TabIndex = 0;
            this.button4.Text = "Sim";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmSenhasAcolhimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GpTipo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSenhasAcolhimento";
            this.Text = "frmSenhasAcolhimento";
            this.Load += new System.EventHandler(this.frmSenhasAcolhimento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GpTipo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.LinkLabel linkConsultaCEP;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox GpTipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}