namespace SISHOMEROGIL
{
    partial class frmEstoqueFarmacia
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDadosItensEstoque = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txIDMedicamento = new System.Windows.Forms.TextBox();
            this.txQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateValidade = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txEstoqueAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txCodigoMedicamento = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItensEstoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgDadosItensEstoque);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens";
            // 
            // dtgDadosItensEstoque
            // 
            this.dtgDadosItensEstoque.AllowUserToAddRows = false;
            this.dtgDadosItensEstoque.AllowUserToDeleteRows = false;
            this.dtgDadosItensEstoque.AllowUserToOrderColumns = true;
            this.dtgDadosItensEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDadosItensEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosItensEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDadosItensEstoque.Location = new System.Drawing.Point(3, 21);
            this.dtgDadosItensEstoque.Name = "dtgDadosItensEstoque";
            this.dtgDadosItensEstoque.ReadOnly = true;
            this.dtgDadosItensEstoque.Size = new System.Drawing.Size(787, 279);
            this.dtgDadosItensEstoque.TabIndex = 0;
            this.dtgDadosItensEstoque.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDadosItensEstoque_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txIDMedicamento);
            this.groupBox1.Controls.Add(this.txQuantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateValidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txEstoqueAtual);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txDescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txCodigoMedicamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEDICAMENTO";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::SISHOMEROGIL.Properties.Resources.cancelar;
            this.btnExcluir.Location = new System.Drawing.Point(440, 99);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(25, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantidade:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::SISHOMEROGIL.Properties.Resources._1356042729_1;
            this.btnIncluir.Location = new System.Drawing.Point(393, 99);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(25, 23);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SISHOMEROGIL.Properties.Resources.clear16x16;
            this.btnLimpar.Location = new System.Drawing.Point(748, 37);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(25, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // txIDMedicamento
            // 
            this.txIDMedicamento.Location = new System.Drawing.Point(9, 37);
            this.txIDMedicamento.Name = "txIDMedicamento";
            this.txIDMedicamento.ReadOnly = true;
            this.txIDMedicamento.Size = new System.Drawing.Size(35, 25);
            this.txIDMedicamento.TabIndex = 9;
            // 
            // txQuantidade
            // 
            this.txQuantidade.Enabled = false;
            this.txQuantidade.Location = new System.Drawing.Point(273, 99);
            this.txQuantidade.Name = "txQuantidade";
            this.txQuantidade.Size = new System.Drawing.Size(100, 25);
            this.txQuantidade.TabIndex = 8;
            this.txQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txQuantidade_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Validade:";
            // 
            // dateValidade
            // 
            this.dateValidade.Enabled = false;
            this.dateValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateValidade.Location = new System.Drawing.Point(136, 99);
            this.dateValidade.Name = "dateValidade";
            this.dateValidade.Size = new System.Drawing.Size(114, 25);
            this.dateValidade.TabIndex = 6;
            this.dateValidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateValidade_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estoque atual:";
            // 
            // txEstoqueAtual
            // 
            this.txEstoqueAtual.Location = new System.Drawing.Point(9, 99);
            this.txEstoqueAtual.Name = "txEstoqueAtual";
            this.txEstoqueAtual.ReadOnly = true;
            this.txEstoqueAtual.Size = new System.Drawing.Size(100, 25);
            this.txEstoqueAtual.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // txDescricao
            // 
            this.txDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txDescricao.Location = new System.Drawing.Point(178, 37);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.ReadOnly = true;
            this.txDescricao.Size = new System.Drawing.Size(551, 25);
            this.txDescricao.TabIndex = 2;
            this.txDescricao.TextChanged += new System.EventHandler(this.txDescricao_TextChanged);
            this.txDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txDescricao_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txCodigoMedicamento
            // 
            this.txCodigoMedicamento.Location = new System.Drawing.Point(62, 37);
            this.txCodigoMedicamento.Name = "txCodigoMedicamento";
            this.txCodigoMedicamento.Size = new System.Drawing.Size(100, 25);
            this.txCodigoMedicamento.TabIndex = 0;
            this.txCodigoMedicamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodigoMedicamento_KeyDown);
            // 
            // frmEstoqueFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstoqueFarmacia";
            this.Text = "SISHOMERO GIL - Gerenciar Estoque Farmácia";
            this.Load += new System.EventHandler(this.frmEstoqueFarmacia_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosItensEstoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodigoMedicamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateValidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txEstoqueAtual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgDadosItensEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txIDMedicamento;
        private System.Windows.Forms.TextBox txQuantidade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluir;
    }
}