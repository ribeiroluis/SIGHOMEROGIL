namespace SISHOMEROGIL
{
    partial class frmBuscaReceita
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
            this.dtgDadosReceitas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosReceitas
            // 
            this.dtgDadosReceitas.AllowUserToAddRows = false;
            this.dtgDadosReceitas.AllowUserToDeleteRows = false;
            this.dtgDadosReceitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosReceitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDadosReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosReceitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgDadosReceitas.Location = new System.Drawing.Point(0, 0);
            this.dtgDadosReceitas.Name = "dtgDadosReceitas";
            this.dtgDadosReceitas.ReadOnly = true;
            this.dtgDadosReceitas.Size = new System.Drawing.Size(621, 164);
            this.dtgDadosReceitas.TabIndex = 0;
            this.dtgDadosReceitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosReceitas_CellDoubleClick);
            // 
            // frmBuscaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 164);
            this.Controls.Add(this.dtgDadosReceitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscaReceita";
            this.Text = "frmBuscaReceita";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosReceitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgDadosReceitas;
    }
}