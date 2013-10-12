namespace SISHOMEROGIL.Administrador
{
    partial class frmGerenciaUsuarios
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
            this.uBSHOMEROGILDataSet = new SISHOMEROGIL.UBSHOMEROGILDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txIdusuarios = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.tIPOACESSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOACESSOTableAdapter = new SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters.TIPOACESSOTableAdapter();
            this.txMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.sETORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.sETORTableAdapter = new SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters.SETORTableAdapter();
            this.cbAcesso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.txConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAcessoSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.viewAcessoSistemaTableAdapter = new SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters.ViewAcessoSistemaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uBSHOMEROGILDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOACESSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAcessoSistemaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uBSHOMEROGILDataSet
            // 
            this.uBSHOMEROGILDataSet.DataSetName = "UBSHOMEROGILDataSet";
            this.uBSHOMEROGILDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // txIdusuarios
            // 
            this.txIdusuarios.Location = new System.Drawing.Point(41, 14);
            this.txIdusuarios.Name = "txIdusuarios";
            this.txIdusuarios.ReadOnly = true;
            this.txIdusuarios.Size = new System.Drawing.Size(47, 25);
            this.txIdusuarios.TabIndex = 3;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(164, 14);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(291, 25);
            this.txNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // cbDescricao
            // 
            this.cbDescricao.DataSource = this.tIPOACESSOBindingSource;
            this.cbDescricao.DisplayMember = "DESCRICAO";
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(85, 54);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(121, 25);
            this.cbDescricao.TabIndex = 7;
            this.cbDescricao.ValueMember = "IDFORMAACESSO";
            // 
            // tIPOACESSOBindingSource
            // 
            this.tIPOACESSOBindingSource.DataMember = "TIPOACESSO";
            this.tIPOACESSOBindingSource.DataSource = this.uBSHOMEROGILDataSet;
            // 
            // tIPOACESSOTableAdapter
            // 
            this.tIPOACESSOTableAdapter.ClearBeforeFill = true;
            // 
            // txMatricula
            // 
            this.txMatricula.Location = new System.Drawing.Point(541, 14);
            this.txMatricula.Name = "txMatricula";
            this.txMatricula.Size = new System.Drawing.Size(130, 25);
            this.txMatricula.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matrícula:";
            // 
            // cbSetor
            // 
            this.cbSetor.DataSource = this.sETORBindingSource;
            this.cbSetor.DisplayMember = "NOME";
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(296, 54);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(121, 25);
            this.cbSetor.TabIndex = 11;
            this.cbSetor.ValueMember = "IDSETOR";
            // 
            // sETORBindingSource
            // 
            this.sETORBindingSource.DataMember = "SETOR";
            this.sETORBindingSource.DataSource = this.uBSHOMEROGILDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Setor:";
            // 
            // sETORTableAdapter
            // 
            this.sETORTableAdapter.ClearBeforeFill = true;
            // 
            // cbAcesso
            // 
            this.cbAcesso.DataSource = this.tIPOACESSOBindingSource;
            this.cbAcesso.DisplayMember = "ACESSOTOTAL";
            this.cbAcesso.FormattingEnabled = true;
            this.cbAcesso.Location = new System.Drawing.Point(548, 54);
            this.cbAcesso.Name = "cbAcesso";
            this.cbAcesso.Size = new System.Drawing.Size(121, 25);
            this.cbAcesso.TabIndex = 13;
            this.cbAcesso.ValueMember = "IDFORMAACESSO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Acesso Total:";
            // 
            // txLogin
            // 
            this.txLogin.Location = new System.Drawing.Point(65, 99);
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(141, 25);
            this.txLogin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Login:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Senha:";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(286, 99);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(131, 25);
            this.txSenha.TabIndex = 17;
            // 
            // txConfirmarSenha
            // 
            this.txConfirmarSenha.Location = new System.Drawing.Point(552, 99);
            this.txConfirmarSenha.Name = "txConfirmarSenha";
            this.txConfirmarSenha.PasswordChar = '*';
            this.txConfirmarSenha.Size = new System.Drawing.Size(119, 25);
            this.txConfirmarSenha.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Confirmar senha:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(742, 38);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 36);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Incluir";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.matDataGridViewTextBoxColumn,
            this.descDataGridViewTextBoxColumn,
            this.acessoDataGridViewCheckBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewAcessoSistemaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(855, 292);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matDataGridViewTextBoxColumn
            // 
            this.matDataGridViewTextBoxColumn.DataPropertyName = "Mat";
            this.matDataGridViewTextBoxColumn.HeaderText = "Mat";
            this.matDataGridViewTextBoxColumn.Name = "matDataGridViewTextBoxColumn";
            this.matDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            this.descDataGridViewTextBoxColumn.HeaderText = "Desc";
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acessoDataGridViewCheckBoxColumn
            // 
            this.acessoDataGridViewCheckBoxColumn.DataPropertyName = "Acesso";
            this.acessoDataGridViewCheckBoxColumn.HeaderText = "Acesso";
            this.acessoDataGridViewCheckBoxColumn.Name = "acessoDataGridViewCheckBoxColumn";
            this.acessoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "Setor";
            this.setorDataGridViewTextBoxColumn.HeaderText = "Setor";
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            this.setorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewAcessoSistemaBindingSource
            // 
            this.viewAcessoSistemaBindingSource.DataMember = "ViewAcessoSistema";
            this.viewAcessoSistemaBindingSource.DataSource = this.uBSHOMEROGILDataSet;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SISHOMEROGIL.Properties.Resources.clear;
            this.btnLimpar.Location = new System.Drawing.Point(742, 83);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 36);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // viewAcessoSistemaTableAdapter
            // 
            this.viewAcessoSistemaTableAdapter.ClearBeforeFill = true;
            // 
            // frmGerenciaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 422);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txConfirmarSenha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbAcesso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txIdusuarios);
            this.Controls.Add(this.label1);
            this.Name = "frmGerenciaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGerenciaUsuarios";
            this.Load += new System.EventHandler(this.frmGerenciaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uBSHOMEROGILDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOACESSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAcessoSistemaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txIdusuarios;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDescricao;
        private UBSHOMEROGILDataSet uBSHOMEROGILDataSet;
        private System.Windows.Forms.BindingSource tIPOACESSOBindingSource;
        private SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters.TIPOACESSOTableAdapter tIPOACESSOTableAdapter;
        private System.Windows.Forms.TextBox txMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource sETORBindingSource;
        private SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters.SETORTableAdapter sETORTableAdapter;
        private System.Windows.Forms.ComboBox cbAcesso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.TextBox txConfirmarSenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.BindingSource viewAcessoSistemaBindingSource;
        private SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters.ViewAcessoSistemaTableAdapter viewAcessoSistemaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acessoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
    }
}