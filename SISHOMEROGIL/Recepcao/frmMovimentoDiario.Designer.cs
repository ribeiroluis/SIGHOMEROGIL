namespace SISHOMEROGIL.Recepcao
{
    partial class frmMovimentoDiario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txDia = new System.Windows.Forms.ComboBox();
            this.txMedico = new System.Windows.Forms.ComboBox();
            this.mEDICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimentoDiario = new SISHOMEROGIL.BancoDados.MovimentoDiario();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mEDICOSTableAdapter = new SISHOMEROGIL.BancoDados.MovimentoDiarioTableAdapters.MEDICOSTableAdapter();
            this.PainelMovimento = new System.Windows.Forms.GroupBox();
            this.DtgDadosConsultas = new System.Windows.Forms.DataGridView();
            this.txIdvaga = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txProntuario = new System.Windows.Forms.TextBox();
            this.txHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPronturario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentoDiario)).BeginInit();
            this.PainelMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDadosConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.txDia);
            this.groupBox1.Controls.Add(this.txMedico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médico";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Image = global::SISHOMEROGIL.Properties.Resources.clear;
            this.btnLimpar.Location = new System.Drawing.Point(519, 38);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(42, 37);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
            this.btnConfirmar.Location = new System.Drawing.Point(459, 38);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(42, 37);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txDia
            // 
            this.txDia.FormattingEnabled = true;
            this.txDia.Location = new System.Drawing.Point(310, 45);
            this.txDia.Name = "txDia";
            this.txDia.Size = new System.Drawing.Size(117, 25);
            this.txDia.TabIndex = 2;
            this.txDia.SelectedIndexChanged += new System.EventHandler(this.txDia_SelectedIndexChanged);
            // 
            // txMedico
            // 
            this.txMedico.DataSource = this.mEDICOSBindingSource;
            this.txMedico.DisplayMember = "NOME";
            this.txMedico.FormattingEnabled = true;
            this.txMedico.Location = new System.Drawing.Point(10, 45);
            this.txMedico.Name = "txMedico";
            this.txMedico.Size = new System.Drawing.Size(294, 25);
            this.txMedico.TabIndex = 1;
            this.txMedico.ValueMember = "IDMEDICO";
            this.txMedico.TextChanged += new System.EventHandler(this.txMedico_TextChanged);
            // 
            // mEDICOSBindingSource
            // 
            this.mEDICOSBindingSource.DataMember = "MEDICOS";
            this.mEDICOSBindingSource.DataSource = this.movimentoDiario;
            // 
            // movimentoDiario
            // 
            this.movimentoDiario.DataSetName = "MovimentoDiario";
            this.movimentoDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médico";
            // 
            // mEDICOSTableAdapter
            // 
            this.mEDICOSTableAdapter.ClearBeforeFill = true;
            // 
            // PainelMovimento
            // 
            this.PainelMovimento.Controls.Add(this.DtgDadosConsultas);
            this.PainelMovimento.Controls.Add(this.txIdvaga);
            this.PainelMovimento.Controls.Add(this.btnInserir);
            this.PainelMovimento.Controls.Add(this.txNome);
            this.PainelMovimento.Controls.Add(this.txProntuario);
            this.PainelMovimento.Controls.Add(this.txHora);
            this.PainelMovimento.Controls.Add(this.label4);
            this.PainelMovimento.Controls.Add(this.lbPronturario);
            this.PainelMovimento.Controls.Add(this.label5);
            this.PainelMovimento.Controls.Add(this.label3);
            this.PainelMovimento.Enabled = false;
            this.PainelMovimento.Location = new System.Drawing.Point(12, 113);
            this.PainelMovimento.Name = "PainelMovimento";
            this.PainelMovimento.Size = new System.Drawing.Size(668, 341);
            this.PainelMovimento.TabIndex = 1;
            this.PainelMovimento.TabStop = false;
            this.PainelMovimento.Text = "Movimento Diário";
            // 
            // DtgDadosConsultas
            // 
            this.DtgDadosConsultas.AllowUserToAddRows = false;
            this.DtgDadosConsultas.AllowUserToDeleteRows = false;
            this.DtgDadosConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgDadosConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDadosConsultas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgDadosConsultas.Location = new System.Drawing.Point(3, 86);
            this.DtgDadosConsultas.Name = "DtgDadosConsultas";
            this.DtgDadosConsultas.ReadOnly = true;
            this.DtgDadosConsultas.Size = new System.Drawing.Size(662, 252);
            this.DtgDadosConsultas.TabIndex = 18;
            this.DtgDadosConsultas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDadosConsultas_CellContentDoubleClick);
            // 
            // txIdvaga
            // 
            this.txIdvaga.Enabled = false;
            this.txIdvaga.Location = new System.Drawing.Point(10, 55);
            this.txIdvaga.Name = "txIdvaga";
            this.txIdvaga.Size = new System.Drawing.Size(41, 25);
            this.txIdvaga.TabIndex = 17;
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Image = global::SISHOMEROGIL.Properties.Resources._1356042729_1;
            this.btnInserir.Location = new System.Drawing.Point(616, 55);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(32, 23);
            this.btnInserir.TabIndex = 16;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(246, 55);
            this.txNome.Name = "txNome";
            this.txNome.ReadOnly = true;
            this.txNome.Size = new System.Drawing.Size(364, 25);
            this.txNome.TabIndex = 1;
            this.txNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNome_KeyDown);
            // 
            // txProntuario
            // 
            this.txProntuario.Location = new System.Drawing.Point(137, 55);
            this.txProntuario.Name = "txProntuario";
            this.txProntuario.Size = new System.Drawing.Size(103, 25);
            this.txProntuario.TabIndex = 1;
            this.txProntuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txProntuario_KeyDown);
            // 
            // txHora
            // 
            this.txHora.BackColor = System.Drawing.SystemColors.Info;
            this.txHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHora.Location = new System.Drawing.Point(57, 55);
            this.txHora.Name = "txHora";
            this.txHora.ReadOnly = true;
            this.txHora.Size = new System.Drawing.Size(74, 25);
            this.txHora.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome Paciente";
            // 
            // lbPronturario
            // 
            this.lbPronturario.AutoSize = true;
            this.lbPronturario.Location = new System.Drawing.Point(134, 34);
            this.lbPronturario.Name = "lbPronturario";
            this.lbPronturario.Size = new System.Drawing.Size(69, 17);
            this.lbPronturario.TabIndex = 0;
            this.lbPronturario.Text = "Prontuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            // 
            // frmMovimentoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 466);
            this.Controls.Add(this.PainelMovimento);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentoDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "INSERIR MOVIENTO";
            this.Load += new System.EventHandler(this.frmMovimentoDiario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentoDiario)).EndInit();
            this.PainelMovimento.ResumeLayout(false);
            this.PainelMovimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDadosConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txMedico;
        private System.Windows.Forms.Label label1;
        private BancoDados.MovimentoDiario movimentoDiario;
        private System.Windows.Forms.BindingSource mEDICOSBindingSource;
        private BancoDados.MovimentoDiarioTableAdapters.MEDICOSTableAdapter mEDICOSTableAdapter;
        private System.Windows.Forms.ComboBox txDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox PainelMovimento;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txProntuario;
        private System.Windows.Forms.TextBox txHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPronturario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txIdvaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DtgDadosConsultas;
    }
}