namespace SISHOMEROGIL
{
    partial class frmNomesUsuarios
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
            this.dtgDadosNomes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosNomes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosNomes
            // 
            this.dtgDadosNomes.AllowUserToAddRows = false;
            this.dtgDadosNomes.AllowUserToDeleteRows = false;
            this.dtgDadosNomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDadosNomes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDadosNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosNomes.Location = new System.Drawing.Point(12, 12);
            this.dtgDadosNomes.Name = "dtgDadosNomes";
            this.dtgDadosNomes.ReadOnly = true;
            this.dtgDadosNomes.Size = new System.Drawing.Size(786, 187);
            this.dtgDadosNomes.TabIndex = 0;
            this.dtgDadosNomes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDadosNomes_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar novo...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNomesUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 242);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgDadosNomes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNomesUsuarios";
            this.Text = "Homero Gil - Busca nome usuário";
            this.Load += new System.EventHandler(this.frmNomesUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosNomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosNomes;
        private System.Windows.Forms.Button button1;
    }
}