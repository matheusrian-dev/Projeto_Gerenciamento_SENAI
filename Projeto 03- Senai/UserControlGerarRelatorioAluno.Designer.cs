namespace Projeto_03__Senai
{
    partial class UserControlGerarRelatorioAluno
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
            this.dtpGerarDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnGerarTurma = new System.Windows.Forms.Button();
            this.txtGerarTurma = new System.Windows.Forms.TextBox();
            this.btnGerarDataMatricula = new System.Windows.Forms.Button();
            this.btnGerarRA = new System.Windows.Forms.Button();
            this.txtGerarRA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(18, 18);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(348, 269);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtpGerarDataMatricula
            // 
            this.dtpGerarDataMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGerarDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGerarDataMatricula.Location = new System.Drawing.Point(373, 139);
            this.dtpGerarDataMatricula.Name = "dtpGerarDataMatricula";
            this.dtpGerarDataMatricula.Size = new System.Drawing.Size(165, 22);
            this.dtpGerarDataMatricula.TabIndex = 13;
            // 
            // btnGerarTurma
            // 
            this.btnGerarTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTurma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarTurma.Location = new System.Drawing.Point(544, 185);
            this.btnGerarTurma.Name = "btnGerarTurma";
            this.btnGerarTurma.Size = new System.Drawing.Size(84, 53);
            this.btnGerarTurma.TabIndex = 12;
            this.btnGerarTurma.Text = "Gerar por Turma";
            this.btnGerarTurma.UseVisualStyleBackColor = false;
            this.btnGerarTurma.Click += new System.EventHandler(this.btnGerarTurma_Click);
            // 
            // txtGerarTurma
            // 
            this.txtGerarTurma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerarTurma.Location = new System.Drawing.Point(373, 200);
            this.txtGerarTurma.Name = "txtGerarTurma";
            this.txtGerarTurma.Size = new System.Drawing.Size(165, 22);
            this.txtGerarTurma.TabIndex = 11;
            this.txtGerarTurma.Enter += new System.EventHandler(this.txtGerarTurma_Enter);
            this.txtGerarTurma.Leave += new System.EventHandler(this.txtGerarTurma_Leave);
            // 
            // btnGerarDataMatricula
            // 
            this.btnGerarDataMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarDataMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDataMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDataMatricula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarDataMatricula.Location = new System.Drawing.Point(544, 126);
            this.btnGerarDataMatricula.Name = "btnGerarDataMatricula";
            this.btnGerarDataMatricula.Size = new System.Drawing.Size(84, 53);
            this.btnGerarDataMatricula.TabIndex = 10;
            this.btnGerarDataMatricula.Text = "Gerar por Data de Matrícula";
            this.btnGerarDataMatricula.UseVisualStyleBackColor = false;
            // 
            // btnGerarRA
            // 
            this.btnGerarRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarRA.Location = new System.Drawing.Point(544, 67);
            this.btnGerarRA.Name = "btnGerarRA";
            this.btnGerarRA.Size = new System.Drawing.Size(84, 53);
            this.btnGerarRA.TabIndex = 9;
            this.btnGerarRA.Text = "Gerar por RA";
            this.btnGerarRA.UseVisualStyleBackColor = false;
            // 
            // txtGerarRA
            // 
            this.txtGerarRA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerarRA.Location = new System.Drawing.Point(373, 82);
            this.txtGerarRA.Name = "txtGerarRA";
            this.txtGerarRA.Size = new System.Drawing.Size(165, 22);
            this.txtGerarRA.TabIndex = 8;
            this.txtGerarRA.Enter += new System.EventHandler(this.txtGerarRA_Enter);
            this.txtGerarRA.Leave += new System.EventHandler(this.txtGerarRA_Leave);
            // 
            // UserControlGerarRelatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.dtpGerarDataMatricula);
            this.Controls.Add(this.btnGerarTurma);
            this.Controls.Add(this.txtGerarTurma);
            this.Controls.Add(this.btnGerarDataMatricula);
            this.Controls.Add(this.btnGerarRA);
            this.Controls.Add(this.txtGerarRA);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UserControlGerarRelatorioAluno";
            this.Size = new System.Drawing.Size(640, 304);
            this.Load += new System.EventHandler(this.UserControlGerarRelatorioAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpGerarDataMatricula;
        private System.Windows.Forms.Button btnGerarTurma;
        private System.Windows.Forms.TextBox txtGerarTurma;
        private System.Windows.Forms.Button btnGerarDataMatricula;
        private System.Windows.Forms.Button btnGerarRA;
        private System.Windows.Forms.TextBox txtGerarRA;
    }
}
