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
            this.txtGerarPorCNPJ = new System.Windows.Forms.TextBox();
            this.btnGerarTodasEmpresas = new System.Windows.Forms.Button();
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
            this.btnGerarPorCNPJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarPorCNPJ.Location = new System.Drawing.Point(192, 248);
            this.btnGerarPorCNPJ.Name = "btnGerarPorCNPJ";
            this.btnGerarPorCNPJ.Size = new System.Drawing.Size(84, 52);
            this.btnGerarPorCNPJ.TabIndex = 14;
            this.btnGerarPorCNPJ.Text = "Gerar por CNPJ";
            this.btnGerarPorCNPJ.UseVisualStyleBackColor = false;
            // 
            // txtGerarPorCNPJ
            // 
            this.txtGerarPorCNPJ.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerarPorCNPJ.Location = new System.Drawing.Point(21, 263);
            this.txtGerarPorCNPJ.Name = "txtGerarPorCNPJ";
            this.txtGerarPorCNPJ.Size = new System.Drawing.Size(165, 22);
            this.txtGerarPorCNPJ.TabIndex = 13;
            this.txtGerarPorCNPJ.Enter += new System.EventHandler(this.txtGerarPorCNPJ_Enter);
            this.txtGerarPorCNPJ.Leave += new System.EventHandler(this.txtGerarPorCNPJ_Leave);
            // 
            // btnGerarTodasEmpresas
            // 
            this.btnGerarTodasEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarTodasEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTodasEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTodasEmpresas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarTodasEmpresas.Location = new System.Drawing.Point(537, 247);
            this.btnGerarTodasEmpresas.Name = "btnGerarTodasEmpresas";
            this.btnGerarTodasEmpresas.Size = new System.Drawing.Size(84, 53);
            this.btnGerarTodasEmpresas.TabIndex = 15;
            this.btnGerarTodasEmpresas.Text = "Gerar por Turma";
            this.btnGerarTodasEmpresas.UseVisualStyleBackColor = false;
            // 
            // UserControlGerarRelatorioEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnGerarTodasEmpresas);
            this.Controls.Add(this.btnGerarPorCNPJ);
            this.Controls.Add(this.txtGerarPorCNPJ);
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
        private System.Windows.Forms.TextBox txtGerarPorCNPJ;
        private System.Windows.Forms.Button btnGerarTodasEmpresas;
    }
}
