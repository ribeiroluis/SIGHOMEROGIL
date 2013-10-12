namespace SISHOMEROGIL.PACS
{
    partial class frmMicroareas
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
            this.GbArea = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarArea = new System.Windows.Forms.Button();
            this.tbEnfemreiro = new System.Windows.Forms.ComboBox();
            this.viewEnfermeirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetACS = new SISHOMEROGIL.BancoDados.DataSetACS();
            this.tbArea = new System.Windows.Forms.ComboBox();
            this.tBAREABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GbMicroarea = new System.Windows.Forms.GroupBox();
            this.btnSalvarMicroarea = new System.Windows.Forms.Button();
            this.cbAcs = new System.Windows.Forms.ComboBox();
            this.viewAcsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbMicroarea = new System.Windows.Forms.ComboBox();
            this.GbEndereco = new System.Windows.Forms.GroupBox();
            this.txCep = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimparEndereco = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.btnSalvarEndereco = new System.Windows.Forms.Button();
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.GbNumeros = new System.Windows.Forms.GroupBox();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.btnIncluirNumero = new System.Windows.Forms.Button();
            this.txComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_AREATableAdapter = new SISHOMEROGIL.BancoDados.DataSetACSTableAdapters.TB_AREATableAdapter();
            this.viewEnfermeirosTableAdapter = new SISHOMEROGIL.BancoDados.DataSetACSTableAdapters.ViewEnfermeirosTableAdapter();
            this.viewAcsTableAdapter = new SISHOMEROGIL.BancoDados.DataSetACSTableAdapters.ViewAcsTableAdapter();
            this.GbArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnfermeirosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetACS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAREABindingSource)).BeginInit();
            this.GbMicroarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAcsBindingSource)).BeginInit();
            this.GbEndereco.SuspendLayout();
            this.GbNumeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // GbArea
            // 
            this.GbArea.Controls.Add(this.btnLimpar);
            this.GbArea.Controls.Add(this.label1);
            this.GbArea.Controls.Add(this.btnConfirmarArea);
            this.GbArea.Controls.Add(this.tbEnfemreiro);
            this.GbArea.Controls.Add(this.tbArea);
            this.GbArea.Location = new System.Drawing.Point(12, 12);
            this.GbArea.Name = "GbArea";
            this.GbArea.Size = new System.Drawing.Size(668, 69);
            this.GbArea.TabIndex = 0;
            this.GbArea.TabStop = false;
            this.GbArea.Text = "Area";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SISHOMEROGIL.Properties.Resources.clear;
            this.btnLimpar.Location = new System.Drawing.Point(609, 16);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(41, 38);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enfermeiro";
            // 
            // btnConfirmarArea
            // 
            this.btnConfirmarArea.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
            this.btnConfirmarArea.Location = new System.Drawing.Point(517, 16);
            this.btnConfirmarArea.Name = "btnConfirmarArea";
            this.btnConfirmarArea.Size = new System.Drawing.Size(41, 38);
            this.btnConfirmarArea.TabIndex = 2;
            this.btnConfirmarArea.UseVisualStyleBackColor = true;
            this.btnConfirmarArea.Click += new System.EventHandler(this.btnConfirmarArea_Click);
            // 
            // tbEnfemreiro
            // 
            this.tbEnfemreiro.DataSource = this.viewEnfermeirosBindingSource;
            this.tbEnfemreiro.DisplayMember = "NOME";
            this.tbEnfemreiro.FormattingEnabled = true;
            this.tbEnfemreiro.Location = new System.Drawing.Point(201, 24);
            this.tbEnfemreiro.Name = "tbEnfemreiro";
            this.tbEnfemreiro.Size = new System.Drawing.Size(295, 25);
            this.tbEnfemreiro.TabIndex = 0;
            this.tbEnfemreiro.ValueMember = "IDFUNCIONARIO";
            this.tbEnfemreiro.SelectedIndexChanged += new System.EventHandler(this.tbEnfemreiro_SelectedIndexChanged);
            // 
            // viewEnfermeirosBindingSource
            // 
            this.viewEnfermeirosBindingSource.DataMember = "ViewEnfermeiros";
            this.viewEnfermeirosBindingSource.DataSource = this.dataSetACS;
            // 
            // dataSetACS
            // 
            this.dataSetACS.DataSetName = "DataSetACS";
            this.dataSetACS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbArea
            // 
            this.tbArea.DataSource = this.tBAREABindingSource;
            this.tbArea.DisplayMember = "IDAREA_AREA";
            this.tbArea.FormattingEnabled = true;
            this.tbArea.Location = new System.Drawing.Point(6, 24);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(97, 25);
            this.tbArea.TabIndex = 0;
            this.tbArea.ValueMember = "IDENFERMEIRO_FUNCIONARIO";
            this.tbArea.TextChanged += new System.EventHandler(this.tbArea_TextChanged);
            // 
            // tBAREABindingSource
            // 
            this.tBAREABindingSource.DataMember = "TB_AREA";
            this.tBAREABindingSource.DataSource = this.dataSetACS;
            // 
            // GbMicroarea
            // 
            this.GbMicroarea.Controls.Add(this.btnSalvarMicroarea);
            this.GbMicroarea.Controls.Add(this.cbAcs);
            this.GbMicroarea.Controls.Add(this.label2);
            this.GbMicroarea.Controls.Add(this.tbMicroarea);
            this.GbMicroarea.Location = new System.Drawing.Point(12, 87);
            this.GbMicroarea.Name = "GbMicroarea";
            this.GbMicroarea.Size = new System.Drawing.Size(668, 69);
            this.GbMicroarea.TabIndex = 1;
            this.GbMicroarea.TabStop = false;
            this.GbMicroarea.Text = "Microarea";
            this.GbMicroarea.Visible = false;
            // 
            // btnSalvarMicroarea
            // 
            this.btnSalvarMicroarea.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
            this.btnSalvarMicroarea.Location = new System.Drawing.Point(517, 16);
            this.btnSalvarMicroarea.Name = "btnSalvarMicroarea";
            this.btnSalvarMicroarea.Size = new System.Drawing.Size(41, 38);
            this.btnSalvarMicroarea.TabIndex = 2;
            this.btnSalvarMicroarea.UseVisualStyleBackColor = true;
            this.btnSalvarMicroarea.Click += new System.EventHandler(this.btnSalvarMicroarea_Click);
            // 
            // cbAcs
            // 
            this.cbAcs.DataSource = this.viewAcsBindingSource;
            this.cbAcs.DisplayMember = "NOME";
            this.cbAcs.FormattingEnabled = true;
            this.cbAcs.Location = new System.Drawing.Point(160, 24);
            this.cbAcs.Name = "cbAcs";
            this.cbAcs.Size = new System.Drawing.Size(336, 25);
            this.cbAcs.TabIndex = 3;
            this.cbAcs.ValueMember = "IDFUNCIONARIO";
            // 
            // viewAcsBindingSource
            // 
            this.viewAcsBindingSource.DataMember = "ViewAcs";
            this.viewAcsBindingSource.DataSource = this.dataSetACS;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ACS";
            // 
            // tbMicroarea
            // 
            this.tbMicroarea.DisplayMember = "ID_AREA";
            this.tbMicroarea.FormattingEnabled = true;
            this.tbMicroarea.Location = new System.Drawing.Point(6, 24);
            this.tbMicroarea.Name = "tbMicroarea";
            this.tbMicroarea.Size = new System.Drawing.Size(97, 25);
            this.tbMicroarea.TabIndex = 0;
            this.tbMicroarea.ValueMember = "ID_ENFERMEIRO";
            this.tbMicroarea.TextChanged += new System.EventHandler(this.tbMicroarea_TextChanged);
            // 
            // GbEndereco
            // 
            this.GbEndereco.Controls.Add(this.txCep);
            this.GbEndereco.Controls.Add(this.label6);
            this.GbEndereco.Controls.Add(this.btnLimparEndereco);
            this.GbEndereco.Controls.Add(this.label3);
            this.GbEndereco.Controls.Add(this.txBairro);
            this.GbEndereco.Controls.Add(this.btnSalvarEndereco);
            this.GbEndereco.Controls.Add(this.txLogradouro);
            this.GbEndereco.Location = new System.Drawing.Point(12, 162);
            this.GbEndereco.Name = "GbEndereco";
            this.GbEndereco.Size = new System.Drawing.Size(662, 150);
            this.GbEndereco.TabIndex = 2;
            this.GbEndereco.TabStop = false;
            this.GbEndereco.Text = "Endereço";
            this.GbEndereco.Visible = false;
            // 
            // txCep
            // 
            this.txCep.Location = new System.Drawing.Point(39, 88);
            this.txCep.Mask = "00000-999";
            this.txCep.Name = "txCep";
            this.txCep.Size = new System.Drawing.Size(75, 25);
            this.txCep.TabIndex = 9;
            this.txCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCep_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "CEP";
            // 
            // btnLimparEndereco
            // 
            this.btnLimparEndereco.Image = global::SISHOMEROGIL.Properties.Resources.clear;
            this.btnLimparEndereco.Location = new System.Drawing.Point(609, 32);
            this.btnLimparEndereco.Name = "btnLimparEndereco";
            this.btnLimparEndereco.Size = new System.Drawing.Size(41, 38);
            this.btnLimparEndereco.TabIndex = 6;
            this.btnLimparEndereco.UseVisualStyleBackColor = true;
            this.btnLimparEndereco.Click += new System.EventHandler(this.btnLimparEndereco_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bairro";
            // 
            // txBairro
            // 
            this.txBairro.BackColor = System.Drawing.Color.White;
            this.txBairro.Location = new System.Drawing.Point(55, 55);
            this.txBairro.Name = "txBairro";
            this.txBairro.ReadOnly = true;
            this.txBairro.Size = new System.Drawing.Size(441, 25);
            this.txBairro.TabIndex = 4;
            // 
            // btnSalvarEndereco
            // 
            this.btnSalvarEndereco.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
            this.btnSalvarEndereco.Location = new System.Drawing.Point(517, 32);
            this.btnSalvarEndereco.Name = "btnSalvarEndereco";
            this.btnSalvarEndereco.Size = new System.Drawing.Size(41, 38);
            this.btnSalvarEndereco.TabIndex = 3;
            this.btnSalvarEndereco.UseVisualStyleBackColor = true;
            this.btnSalvarEndereco.Click += new System.EventHandler(this.btnSalvarEndereco_Click);
            // 
            // txLogradouro
            // 
            this.txLogradouro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txLogradouro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txLogradouro.Location = new System.Drawing.Point(9, 24);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.Size = new System.Drawing.Size(487, 25);
            this.txLogradouro.TabIndex = 0;
            this.txLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txLogradouro_KeyDown);
            // 
            // GbNumeros
            // 
            this.GbNumeros.Controls.Add(this.dtgDados);
            this.GbNumeros.Controls.Add(this.btnIncluirNumero);
            this.GbNumeros.Controls.Add(this.txComplemento);
            this.GbNumeros.Controls.Add(this.label5);
            this.GbNumeros.Controls.Add(this.txNumero);
            this.GbNumeros.Controls.Add(this.label4);
            this.GbNumeros.Location = new System.Drawing.Point(12, 318);
            this.GbNumeros.Name = "GbNumeros";
            this.GbNumeros.Size = new System.Drawing.Size(662, 184);
            this.GbNumeros.TabIndex = 3;
            this.GbNumeros.TabStop = false;
            this.GbNumeros.Text = "Numeros";
            this.GbNumeros.Visible = false;
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(9, 55);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.Size = new System.Drawing.Size(641, 123);
            this.dtgDados.TabIndex = 5;
            this.dtgDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDados_CellMouseDoubleClick);
            // 
            // btnIncluirNumero
            // 
            this.btnIncluirNumero.Image = global::SISHOMEROGIL.Properties.Resources._1356042729_1;
            this.btnIncluirNumero.Location = new System.Drawing.Point(201, 24);
            this.btnIncluirNumero.Name = "btnIncluirNumero";
            this.btnIncluirNumero.Size = new System.Drawing.Size(32, 25);
            this.btnIncluirNumero.TabIndex = 4;
            this.btnIncluirNumero.UseVisualStyleBackColor = true;
            this.btnIncluirNumero.Click += new System.EventHandler(this.btnIncluirNumero_Click);
            // 
            // txComplemento
            // 
            this.txComplemento.Location = new System.Drawing.Point(144, 24);
            this.txComplemento.Name = "txComplemento";
            this.txComplemento.Size = new System.Drawing.Size(51, 25);
            this.txComplemento.TabIndex = 3;
            this.txComplemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txComplemento_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comp:";
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(36, 24);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(51, 25);
            this.txNumero.TabIndex = 1;
            this.txNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txNumero_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nº";
            // 
            // tB_AREATableAdapter
            // 
            this.tB_AREATableAdapter.ClearBeforeFill = true;
            // 
            // viewEnfermeirosTableAdapter
            // 
            this.viewEnfermeirosTableAdapter.ClearBeforeFill = true;
            // 
            // viewAcsTableAdapter
            // 
            this.viewAcsTableAdapter.ClearBeforeFill = true;
            // 
            // frmMicroareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 514);
            this.Controls.Add(this.GbNumeros);
            this.Controls.Add(this.GbEndereco);
            this.Controls.Add(this.GbMicroarea);
            this.Controls.Add(this.GbArea);
            this.Name = "frmMicroareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMicroareas";
            this.Load += new System.EventHandler(this.frmMicroareas_Load);
            this.GbArea.ResumeLayout(false);
            this.GbArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewEnfermeirosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetACS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAREABindingSource)).EndInit();
            this.GbMicroarea.ResumeLayout(false);
            this.GbMicroarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAcsBindingSource)).EndInit();
            this.GbEndereco.ResumeLayout(false);
            this.GbEndereco.PerformLayout();
            this.GbNumeros.ResumeLayout(false);
            this.GbNumeros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbArea;
        private System.Windows.Forms.ComboBox tbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tbEnfemreiro;
        private System.Windows.Forms.Button btnConfirmarArea;
        private System.Windows.Forms.GroupBox GbMicroarea;
        private System.Windows.Forms.ComboBox tbMicroarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarMicroarea;
        private System.Windows.Forms.ComboBox cbAcs;
        private System.Windows.Forms.GroupBox GbEndereco;
        private System.Windows.Forms.Button btnSalvarEndereco;
        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox GbNumeros;
        private System.Windows.Forms.Button btnIncluirNumero;
        private System.Windows.Forms.TextBox txComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button btnLimparEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txCep;
        private BancoDados.DataSetACS dataSetACS;
        private System.Windows.Forms.BindingSource tBAREABindingSource;
        private BancoDados.DataSetACSTableAdapters.TB_AREATableAdapter tB_AREATableAdapter;
        private System.Windows.Forms.BindingSource viewEnfermeirosBindingSource;
        private BancoDados.DataSetACSTableAdapters.ViewEnfermeirosTableAdapter viewEnfermeirosTableAdapter;
        private System.Windows.Forms.BindingSource viewAcsBindingSource;
        private BancoDados.DataSetACSTableAdapters.ViewAcsTableAdapter viewAcsTableAdapter;
    }
}