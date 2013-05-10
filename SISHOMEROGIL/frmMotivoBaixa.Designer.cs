namespace SISHOMEROGIL
{
    partial class frmMotivoBaixa
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
            this.TexMotivoBaixa = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TexMotivoBaixa
            // 
            this.TexMotivoBaixa.Location = new System.Drawing.Point(40, 92);
            this.TexMotivoBaixa.Name = "TexMotivoBaixa";
            this.TexMotivoBaixa.Size = new System.Drawing.Size(609, 293);
            this.TexMotivoBaixa.TabIndex = 0;
            this.TexMotivoBaixa.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
            this.btnOK.Location = new System.Drawing.Point(507, 391);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(142, 38);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Confirmar";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORME O MOTIVO DA BAIXA E CLIQUE EM CONFIRMAR";
            // 
            // frmMotivoBaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 438);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.TexMotivoBaixa);
            this.MaximizeBox = true;
            this.Name = "frmMotivoBaixa";
            this.Text = "SIS HOMERO GIL - MOTIVO DA BAIXA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TexMotivoBaixa;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}