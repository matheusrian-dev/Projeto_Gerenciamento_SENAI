namespace Projeto_03__Senai
{
    partial class FormRelatorioEncaminhar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioEncaminhar));
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
            this.txtFiltrarPorIdade = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorIdade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mskFiltrarCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.txtFiltrarPorGenero.Location = new System.Drawing.Point(510, 312);
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
            // 
            // btnFiltrarPorGenero
            // 
            this.btnFiltrarPorGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarPorGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarPorGenero.Location = new System.Drawing.Point(681, 297);
            this.btnFiltrarPorGenero.Name = "btnFiltrarPorGenero";
            this.btnFiltrarPorGenero.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarPorGenero.TabIndex = 60;
            this.btnFiltrarPorGenero.Text = "Filtrar Alunos por Gênero";
            this.btnFiltrarPorGenero.UseVisualStyleBackColor = false;
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
            this.txtFiltrarTurma.Location = new System.Drawing.Point(510, 194);
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
            this.btnFiltrarTurma.Location = new System.Drawing.Point(681, 179);
            this.btnFiltrarTurma.Name = "btnFiltrarTurma";
            this.btnFiltrarTurma.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarTurma.TabIndex = 59;
            this.btnFiltrarTurma.Text = "Filtrar por Turma";
            this.btnFiltrarTurma.UseVisualStyleBackColor = false;
            // 
            // txtFiltrarPorIdade
            // 
            this.txtFiltrarPorIdade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPorIdade.Location = new System.Drawing.Point(510, 135);
            this.txtFiltrarPorIdade.Name = "txtFiltrarPorIdade";
            this.txtFiltrarPorIdade.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarPorIdade.TabIndex = 63;
            // 
            // btnFiltrarPorIdade
            // 
            this.btnFiltrarPorIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarPorIdade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorIdade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarPorIdade.Location = new System.Drawing.Point(681, 120);
            this.btnFiltrarPorIdade.Name = "btnFiltrarPorIdade";
            this.btnFiltrarPorIdade.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarPorIdade.TabIndex = 62;
            this.btnFiltrarPorIdade.Text = "Filtrar Alunos por Idade ";
            this.btnFiltrarPorIdade.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(681, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 53);
            this.button1.TabIndex = 64;
            this.button1.Text = "Filtrar Alunos por Empresa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mskFiltrarCNPJ
            // 
            this.mskFiltrarCNPJ.Location = new System.Drawing.Point(510, 256);
            this.mskFiltrarCNPJ.Mask = "999,999,999/99999-99";
            this.mskFiltrarCNPJ.Name = "mskFiltrarCNPJ";
            this.mskFiltrarCNPJ.Size = new System.Drawing.Size(164, 20);
            this.mskFiltrarCNPJ.TabIndex = 84;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(510, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 53);
            this.button2.TabIndex = 85;
            this.button2.Text = "Gerar Relatório Completo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(647, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 53);
            this.button3.TabIndex = 86;
            this.button3.Text = "Gerar Relatório Parcial";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormRelatorioEncaminhar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(793, 443);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mskFiltrarCNPJ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFiltrarPorIdade);
            this.Controls.Add(this.btnFiltrarPorIdade);
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
        private System.Windows.Forms.TextBox txtFiltrarPorIdade;
        private System.Windows.Forms.Button btnFiltrarPorIdade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskFiltrarCNPJ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}