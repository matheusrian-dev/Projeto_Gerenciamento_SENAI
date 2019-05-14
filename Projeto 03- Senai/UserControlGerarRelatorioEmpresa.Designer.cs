namespace Projeto_03__Senai
{
    partial class UserControlGerarRelatorioEmpresa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGerarPorCNPJ = new System.Windows.Forms.Button();
            this.btnGerarTodasEmpresas = new System.Windows.Forms.Button();
            this.mskGerarPorCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(22, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(599, 209);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnGerarPorCNPJ
            // 
            this.btnGerarPorCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarPorCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarPorCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarPorCNPJ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarPorCNPJ.Location = new System.Drawing.Point(185, 247);
            this.btnGerarPorCNPJ.Name = "btnGerarPorCNPJ";
            this.btnGerarPorCNPJ.Size = new System.Drawing.Size(84, 52);
            this.btnGerarPorCNPJ.TabIndex = 14;
            this.btnGerarPorCNPJ.Text = "Gerar por CNPJ";
            this.btnGerarPorCNPJ.UseVisualStyleBackColor = false;
            // 
            // btnGerarTodasEmpresas
            // 
            this.btnGerarTodasEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarTodasEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTodasEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTodasEmpresas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarTodasEmpresas.Location = new System.Drawing.Point(508, 247);
            this.btnGerarTodasEmpresas.Name = "btnGerarTodasEmpresas";
            this.btnGerarTodasEmpresas.Size = new System.Drawing.Size(113, 53);
            this.btnGerarTodasEmpresas.TabIndex = 15;
            this.btnGerarTodasEmpresas.Text = "Gerar Relatório de Todas as Empresas";
            this.btnGerarTodasEmpresas.UseVisualStyleBackColor = false;
            // 
            // mskGerarPorCNPJ
            // 
            this.mskGerarPorCNPJ.Location = new System.Drawing.Point(22, 264);
            this.mskGerarPorCNPJ.Mask = "999,999,999/99999-99";
            this.mskGerarPorCNPJ.Name = "mskGerarPorCNPJ";
            this.mskGerarPorCNPJ.Size = new System.Drawing.Size(157, 20);
            this.mskGerarPorCNPJ.TabIndex = 16;
            // 
            // UserControlGerarRelatorioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.mskGerarPorCNPJ);
            this.Controls.Add(this.btnGerarTodasEmpresas);
            this.Controls.Add(this.btnGerarPorCNPJ);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UserControlGerarRelatorioEmpresa";
            this.Size = new System.Drawing.Size(640, 304);
            this.Load += new System.EventHandler(this.UserControlGerarRelatorioEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGerarPorCNPJ;
        private System.Windows.Forms.Button btnGerarTodasEmpresas;
        private System.Windows.Forms.MaskedTextBox mskGerarPorCNPJ;
    }
}
