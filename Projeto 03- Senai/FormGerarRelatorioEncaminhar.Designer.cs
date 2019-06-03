namespace Projeto_03__Senai
{
    partial class FormGerarRelatorioEncaminhar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerarRelatorioEncaminhar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFiltrarPorGenero = new System.Windows.Forms.TextBox();
            this.btnFiltrarRA = new System.Windows.Forms.Button();
            this.btnFiltrarPorGenero = new System.Windows.Forms.Button();
            this.txtFiltrarRA = new System.Windows.Forms.TextBox();
            this.txtFiltrarTurma = new System.Windows.Forms.TextBox();
            this.btnFiltrarTurma = new System.Windows.Forms.Button();
            this.btnFiltrarPorEmpresa = new System.Windows.Forms.Button();
            this.mskFiltrarCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnGerarRelatorioCompleto = new System.Windows.Forms.Button();
            this.btnGerarRelatorioParcial = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 38);
            this.panel1.TabIndex = 39;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(719, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 25);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "SENAI - Sistema FIEMG";
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(755, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 25);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 355);
            this.dataGridView1.TabIndex = 40;
            // 
            // txtFiltrarPorGenero
            // 
            this.txtFiltrarPorGenero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPorGenero.Location = new System.Drawing.Point(510, 253);
            this.txtFiltrarPorGenero.Name = "txtFiltrarPorGenero";
            this.txtFiltrarPorGenero.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarPorGenero.TabIndex = 61;
            // 
            // btnFiltrarRA
            // 
            this.btnFiltrarRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarRA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarRA.Location = new System.Drawing.Point(681, 61);
            this.btnFiltrarRA.Name = "btnFiltrarRA";
            this.btnFiltrarRA.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarRA.TabIndex = 57;
            this.btnFiltrarRA.Text = "Filtrar por RA";
            this.btnFiltrarRA.UseVisualStyleBackColor = false;
            this.btnFiltrarRA.Click += new System.EventHandler(this.btnFiltrarRA_Click);
            // 
            // btnFiltrarPorGenero
            // 
            this.btnFiltrarPorGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarPorGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarPorGenero.Location = new System.Drawing.Point(681, 238);
            this.btnFiltrarPorGenero.Name = "btnFiltrarPorGenero";
            this.btnFiltrarPorGenero.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarPorGenero.TabIndex = 60;
            this.btnFiltrarPorGenero.Text = "Filtrar Alunos por Gênero";
            this.btnFiltrarPorGenero.UseVisualStyleBackColor = false;
            this.btnFiltrarPorGenero.Click += new System.EventHandler(this.btnFiltrarPorGenero_Click);
            // 
            // txtFiltrarRA
            // 
            this.txtFiltrarRA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarRA.Location = new System.Drawing.Point(510, 76);
            this.txtFiltrarRA.Name = "txtFiltrarRA";
            this.txtFiltrarRA.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarRA.TabIndex = 56;
            // 
            // txtFiltrarTurma
            // 
            this.txtFiltrarTurma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarTurma.Location = new System.Drawing.Point(510, 135);
            this.txtFiltrarTurma.Name = "txtFiltrarTurma";
            this.txtFiltrarTurma.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarTurma.TabIndex = 58;
            // 
            // btnFiltrarTurma
            // 
            this.btnFiltrarTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTurma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarTurma.Location = new System.Drawing.Point(681, 120);
            this.btnFiltrarTurma.Name = "btnFiltrarTurma";
            this.btnFiltrarTurma.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarTurma.TabIndex = 59;
            this.btnFiltrarTurma.Text = "Filtrar por Turma";
            this.btnFiltrarTurma.UseVisualStyleBackColor = false;
            this.btnFiltrarTurma.Click += new System.EventHandler(this.btnFiltrarTurma_Click);
            // 
            // btnFiltrarPorEmpresa
            // 
            this.btnFiltrarPorEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarPorEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorEmpresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarPorEmpresa.Location = new System.Drawing.Point(681, 179);
            this.btnFiltrarPorEmpresa.Name = "btnFiltrarPorEmpresa";
            this.btnFiltrarPorEmpresa.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarPorEmpresa.TabIndex = 64;
            this.btnFiltrarPorEmpresa.Text = "Filtrar Alunos por Empresa";
            this.btnFiltrarPorEmpresa.UseVisualStyleBackColor = false;
            this.btnFiltrarPorEmpresa.Click += new System.EventHandler(this.btnFiltrarPorEmpresa_Click);
            // 
            // mskFiltrarCNPJ
            // 
            this.mskFiltrarCNPJ.Location = new System.Drawing.Point(510, 197);
            this.mskFiltrarCNPJ.Mask = "999,999,999/99999-99";
            this.mskFiltrarCNPJ.Name = "mskFiltrarCNPJ";
            this.mskFiltrarCNPJ.Size = new System.Drawing.Size(164, 20);
            this.mskFiltrarCNPJ.TabIndex = 84;
            // 
            // btnGerarRelatorioCompleto
            // 
            this.btnGerarRelatorioCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarRelatorioCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorioCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorioCompleto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarRelatorioCompleto.Location = new System.Drawing.Point(510, 365);
            this.btnGerarRelatorioCompleto.Name = "btnGerarRelatorioCompleto";
            this.btnGerarRelatorioCompleto.Size = new System.Drawing.Size(131, 53);
            this.btnGerarRelatorioCompleto.TabIndex = 85;
            this.btnGerarRelatorioCompleto.Text = "Gerar Relatório Completo";
            this.btnGerarRelatorioCompleto.UseVisualStyleBackColor = false;
            this.btnGerarRelatorioCompleto.Click += new System.EventHandler(this.btnGerarRelatorioCompleto_Click);
            // 
            // btnGerarRelatorioParcial
            // 
            this.btnGerarRelatorioParcial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarRelatorioParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorioParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorioParcial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarRelatorioParcial.Location = new System.Drawing.Point(647, 365);
            this.btnGerarRelatorioParcial.Name = "btnGerarRelatorioParcial";
            this.btnGerarRelatorioParcial.Size = new System.Drawing.Size(131, 53);
            this.btnGerarRelatorioParcial.TabIndex = 86;
            this.btnGerarRelatorioParcial.Text = "Gerar Relatório Parcial";
            this.btnGerarRelatorioParcial.UseVisualStyleBackColor = false;
            this.btnGerarRelatorioParcial.Click += new System.EventHandler(this.btnGerarRelatorioParcial_Click);
            // 
            // FormRelatorioEncaminhar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(793, 443);
            this.Controls.Add(this.btnGerarRelatorioParcial);
            this.Controls.Add(this.btnGerarRelatorioCompleto);
            this.Controls.Add(this.mskFiltrarCNPJ);
            this.Controls.Add(this.btnFiltrarPorEmpresa);
            this.Controls.Add(this.txtFiltrarPorGenero);
            this.Controls.Add(this.btnFiltrarRA);
            this.Controls.Add(this.btnFiltrarPorGenero);
            this.Controls.Add(this.txtFiltrarRA);
            this.Controls.Add(this.txtFiltrarTurma);
            this.Controls.Add(this.btnFiltrarTurma);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioEncaminhar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelatorioEncaminhar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFiltrarPorGenero;
        private System.Windows.Forms.Button btnFiltrarRA;
        private System.Windows.Forms.Button btnFiltrarPorGenero;
        private System.Windows.Forms.TextBox txtFiltrarRA;
        private System.Windows.Forms.TextBox txtFiltrarTurma;
        private System.Windows.Forms.Button btnFiltrarTurma;
        private System.Windows.Forms.Button btnFiltrarPorEmpresa;
        private System.Windows.Forms.MaskedTextBox mskFiltrarCNPJ;
        private System.Windows.Forms.Button btnGerarRelatorioCompleto;
        private System.Windows.Forms.Button btnGerarRelatorioParcial;
    }
}