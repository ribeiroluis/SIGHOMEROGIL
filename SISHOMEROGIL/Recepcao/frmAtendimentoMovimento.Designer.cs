namespace SISHOMEROGIL.Recepcao
{
    partial class frmAtendimentoMovimento
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
            this.txNomeMedico = new System.Windows.Forms.ComboBox();
            this.Controles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NPrioridade = new System.Windows.Forms.NumericUpDown();
            this.btnInserirDesistencia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNomeDesistencia = new System.Windows.Forms.TextBox();
            this.txProntuarioDesistencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txIdvaga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txProntuario = new System.Windows.Forms.TextBox();
            this.lbPronturario = new System.Windows.Forms.Label();
            this.txHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.painelMovimento = new System.Windows.Forms.GroupBox();
            this.DtgDadosConsultas = new System.Windows.Forms.DataGridView();
            this.pnRelogio = new System.Windows.Forms.Panel();
            this.lbRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgDesistencias = new System.Windows.Forms.DataGridView();
            this.timerDesistencias = new System.Windows.Forms.Timer(this.components);
            this.lkFaltosos = new System.Windows.Forms.LinkLabel();
            this.Controles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPrioridade)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.painelMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDadosConsultas)).BeginInit();
            this.pnRelogio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDesistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // txNomeMedico
            // 
            this.txNomeMedico.DisplayMember = "IDMEDICO";
            this.txNomeMedico.FormattingEnabled = true;
            this.txNomeMedico.Location = new System.Drawing.Point(12, 24);
            this.txNomeMedico.Name = "txNomeMedico";
            this.txNomeMedico.Size = new System.Drawing.Size(340, 25);
            this.txNomeMedico.TabIndex = 1;
            this.txNomeMedico.ValueMember = "IDMEDICO";
            this.txNomeMedico.SelectedIndexChanged += new System.EventHandler(this.txNomeMedico_SelectedIndexChanged);
            // 
            // Controles
            // 
            this.Controles.Controls.Add(this.tabPage1);
            this.Controles.Controls.Add(this.tabPage2);
            this.Controles.Enabled = false;
            this.Controles.Location = new System.Drawing.Point(12, 55);
            this.Controles.Name = "Controles";
            this.Controles.SelectedIndex = 0;
            this.Controles.Size = new System.Drawing.Size(675, 96);
            this.Controles.TabIndex = 1;
            this.Controles.SelectedIndexChanged += new System.EventHandler(this.Controles_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NPrioridade);
            this.tabPage1.Controls.Add(this.btnInserirDesistencia);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txNomeDesistencia);
            this.tabPage1.Controls.Add(this.txProntuarioDesistencia);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 66);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Desistencia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NPrioridade
            // 
            this.NPrioridade.Location = new System.Drawing.Point(462, 33);
            this.NPrioridade.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NPrioridade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NPrioridade.Name = "NPrioridade";
            this.NPrioridade.ReadOnly = true;
            this.NPrioridade.Size = new System.Drawing.Size(66, 25);
            this.NPrioridade.TabIndex = 31;
            this.NPrioridade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NPrioridade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NPrioridade_KeyDown);
            // 
            // btnInserirDesistencia
            // 
            this.btnInserirDesistencia.Enabled = false;
            this.btnInserirDesistencia.Image = global::SISHOMEROGIL.Properties.Resources._1356042729_1;
            this.btnInserirDesistencia.Location = new System.Drawing.Point(564, 33);
            this.btnInserirDesistencia.Name = "btnInserirDesistencia";
            this.btnInserirDesistencia.Size = new System.Drawing.Size(32, 23);
            this.btnInserirDesistencia.TabIndex = 30;
            this.btnInserirDesistencia.UseVisualStyleBackColor = true;
            this.btnInserirDesistencia.Click += new System.EventHandler(this.btnInserirDesistencia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Prioridade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome Paciente";
            // 
            // txNomeDesistencia
            // 
            this.txNomeDesistencia.Location = new System.Drawing.Point(93, 33);
            this.txNomeDesistencia.Name = "txNomeDesistencia";
            this.txNomeDesistencia.ReadOnly = true;
            this.txNomeDesistencia.Size = new System.Drawing.Size(356, 25);
            this.txNomeDesistencia.TabIndex = 28;
            this.txNomeDesistencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNomeDesistencia_KeyDown);
            // 
            // txProntuarioDesistencia
            // 
            this.txProntuarioDesistencia.Location = new System.Drawing.Point(11, 33);
            this.txProntuarioDesistencia.Name = "txProntuarioDesistencia";
            this.txProntuarioDesistencia.Size = new System.Drawing.Size(76, 25);
            this.txProntuarioDesistencia.TabIndex = 29;
            this.txProntuarioDesistencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txProntuarioDesistencia_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Prontuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInserir);
            this.tabPage2.Controls.Add(this.txIdvaga);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txNome);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txProntuario);
            this.tabPage2.Controls.Add(this.lbPronturario);
            this.tabPage2.Controls.Add(this.txHora);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 66);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agudo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Image = global::SISHOMEROGIL.Properties.Resources._1356042729_1;
            this.btnInserir.Location = new System.Drawing.Point(585, 35);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(32, 23);
            this.btnInserir.TabIndex = 25;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txIdvaga
            // 
            this.txIdvaga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txIdvaga.Location = new System.Drawing.Point(6, 35);
            this.txIdvaga.Name = "txIdvaga";
            this.txIdvaga.ReadOnly = true;
            this.txIdvaga.Size = new System.Drawing.Size(41, 25);
            this.txIdvaga.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome Paciente";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(206, 35);
            this.txNome.Name = "txNome";
            this.txNome.ReadOnly = true;
            this.txNome.Size = new System.Drawing.Size(356, 25);
            this.txNome.TabIndex = 22;
            this.txNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNome_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // txProntuario
            // 
            this.txProntuario.Location = new System.Drawing.Point(124, 35);
            this.txProntuario.Name = "txProntuario";
            this.txProntuario.Size = new System.Drawing.Size(76, 25);
            this.txProntuario.TabIndex = 23;
            this.txProntuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txProntuario_KeyDown);
            // 
            // lbPronturario
            // 
            this.lbPronturario.AutoSize = true;
            this.lbPronturario.Location = new System.Drawing.Point(121, 15);
            this.lbPronturario.Name = "lbPronturario";
            this.lbPronturario.Size = new System.Drawing.Size(69, 17);
            this.lbPronturario.TabIndex = 19;
            this.lbPronturario.Text = "Prontuario";
            // 
            // txHora
            // 
            this.txHora.BackColor = System.Drawing.SystemColors.Info;
            this.txHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHora.Location = new System.Drawing.Point(53, 35);
            this.txHora.Name = "txHora";
            this.txHora.ReadOnly = true;
            this.txHora.Size = new System.Drawing.Size(65, 25);
            this.txHora.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hora";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Image = global::SISHOMEROGIL.Properties.Resources.clear;
            this.btnLimpar.Location = new System.Drawing.Point(358, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(42, 37);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medico:";
            // 
            // painelMovimento
            // 
            this.painelMovimento.Controls.Add(this.DtgDadosConsultas);
            this.painelMovimento.Location = new System.Drawing.Point(15, 157);
            this.painelMovimento.Name = "painelMovimento";
            this.painelMovimento.Size = new System.Drawing.Size(675, 296);
            this.painelMovimento.TabIndex = 6;
            this.painelMovimento.TabStop = false;
            this.painelMovimento.Text = "Movimento: ";
            // 
            // DtgDadosConsultas
            // 
            this.DtgDadosConsultas.AllowUserToAddRows = false;
            this.DtgDadosConsultas.AllowUserToDeleteRows = false;
            this.DtgDadosConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgDadosConsultas.BackgroundColor = System.Drawing.Color.White;
            this.DtgDadosConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDadosConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgDadosConsultas.Location = new System.Drawing.Point(3, 21);
            this.DtgDadosConsultas.Name = "DtgDadosConsultas";
            this.DtgDadosConsultas.ReadOnly = true;
            this.DtgDadosConsultas.Size = new System.Drawing.Size(669, 272);
            this.DtgDadosConsultas.TabIndex = 0;
            this.DtgDadosConsultas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgDadosConsultas_CellMouseDoubleClick);
            // 
            // pnRelogio
            // 
            this.pnRelogio.BackColor = System.Drawing.Color.White;
            this.pnRelogio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnRelogio.Controls.Add(this.lbRelogio);
            this.pnRelogio.Location = new System.Drawing.Point(509, 12);
            this.pnRelogio.Name = "pnRelogio";
            this.pnRelogio.Size = new System.Drawing.Size(174, 45);
            this.pnRelogio.TabIndex = 7;
            // 
            // lbRelogio
            // 
            this.lbRelogio.AutoSize = true;
            this.lbRelogio.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelogio.ForeColor = System.Drawing.Color.Red;
            this.lbRelogio.Location = new System.Drawing.Point(22, 3);
            this.lbRelogio.Name = "lbRelogio";
            this.lbRelogio.Size = new System.Drawing.Size(129, 38);
            this.lbRelogio.TabIndex = 0;
            this.lbRelogio.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgDesistencias);
            this.groupBox1.Location = new System.Drawing.Point(15, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desistencias:";
            // 
            // dtgDesistencias
            // 
            this.dtgDesistencias.AllowUserToAddRows = false;
            this.dtgDesistencias.AllowUserToDeleteRows = false;
            this.dtgDesistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDesistencias.BackgroundColor = System.Drawing.Color.White;
            this.dtgDesistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDesistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDesistencias.Location = new System.Drawing.Point(3, 21);
            this.dtgDesistencias.Name = "dtgDesistencias";
            this.dtgDesistencias.ReadOnly = true;
            this.dtgDesistencias.Size = new System.Drawing.Size(669, 143);
            this.dtgDesistencias.TabIndex = 0;
            this.dtgDesistencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDesistencias_CellDoubleClick);
            // 
            // timerDesistencias
            // 
            this.timerDesistencias.Tick += new System.EventHandler(this.timerDesistencias_Tick);
            // 
            // lkFaltosos
            // 
            this.lkFaltosos.AutoSize = true;
            this.lkFaltosos.Location = new System.Drawing.Point(406, 17);
            this.lkFaltosos.Name = "lkFaltosos";
            this.lkFaltosos.Size = new System.Drawing.Size(56, 17);
            this.lkFaltosos.TabIndex = 9;
            this.lkFaltosos.TabStop = true;
            this.lkFaltosos.Text = "Faltosos";
            this.lkFaltosos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkFaltosos_LinkClicked);
            // 
            // frmAtendimentoMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 666);
            this.Controls.Add(this.lkFaltosos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnRelogio);
            this.Controls.Add(this.painelMovimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNomeMedico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.Controles);
            this.Name = "frmAtendimentoMovimento";
            this.Text = "frmAtendimentoMovimento";
            this.Load += new System.EventHandler(this.frmAtendimentoMovimento_Load);
            this.Controles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPrioridade)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.painelMovimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDadosConsultas)).EndInit();
            this.pnRelogio.ResumeLayout(false);
            this.pnRelogio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDesistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txNomeMedico;
        private System.Windows.Forms.TabControl Controles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txIdvaga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txProntuario;
        private System.Windows.Forms.Label lbPronturario;
        private System.Windows.Forms.TextBox txHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NPrioridade;
        private System.Windows.Forms.Button btnInserirDesistencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNomeDesistencia;
        private System.Windows.Forms.TextBox txProntuarioDesistencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox painelMovimento;
        private System.Windows.Forms.Panel pnRelogio;
        private System.Windows.Forms.Label lbRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DtgDadosConsultas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDesistencias;
        private System.Windows.Forms.Timer timerDesistencias;
        private System.Windows.Forms.LinkLabel lkFaltosos;
    }
}