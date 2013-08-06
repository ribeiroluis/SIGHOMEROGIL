namespace SISHOMEROGIL
{
    partial class frmBuscaCEP
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
            this.txLogradouro = new System.Windows.Forms.TextBox();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txLogradouro
            // 
            this.txLogradouro.Location = new System.Drawing.Point(12, 29);
            this.txLogradouro.Name = "txLogradouro";
            this.txLogradouro.Size = new System.Drawing.Size(689, 25);
            this.txLogradouro.TabIndex = 0;
            this.txLogradouro.TextChanged += new System.EventHandler(this.txLogradouro_TextChanged);
            this.txLogradouro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txLogradouro_KeyDown);
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDados.Location = new System.Drawing.Point(0, 60);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.Size = new System.Drawing.Size(756, 406);
            this.dtgDados.TabIndex = 1;
            this.dtgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellDoubleClick);
            this.dtgDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDados_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o logradouro:";
            // 
            // frmBuscaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.txLogradouro);
            this.Name = "frmBuscaCEP";
            this.Text = "frmBuscaCEP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txLogradouro;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Label label1;
    }
}