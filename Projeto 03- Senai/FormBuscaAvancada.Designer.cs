namespace Projeto_03__Senai
{
    partial class FormBuscaAvancada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaAvancada));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscarArquivo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnFiltrarAlunosEmpresa = new System.Windows.Forms.Button();
            this.dtpFiltrarDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarTurma = new System.Windows.Forms.Button();
            this.txtFiltrarTurma = new System.Windows.Forms.TextBox();
            this.btnFiltrarDataMatricula = new System.Windows.Forms.Button();
            this.btnFiltrarRA = new System.Windows.Forms.Button();
            this.txtFiltrarRA = new System.Windows.Forms.TextBox();
            this.txtFiltrarPorIdade = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorIdade = new System.Windows.Forms.Button();
            this.txtFiltrarPorGenero = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorGenero = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskFiltrarAlunosNaEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(840, 38);
            this.panel1.TabIndex = 38;
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
            this.btnMinimizar.Location = new System.Drawing.Point(768, 7);
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
            this.btnFechar.Location = new System.Drawing.Point(804, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 25);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 348);
            this.dataGridView1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tabelas do Arquivo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBuscarArquivo
            // 
            this.btnBuscarArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArquivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarArquivo.Location = new System.Drawing.Point(209, 18);
            this.btnBuscarArquivo.Name = "btnBuscarArquivo";
            this.btnBuscarArquivo.Size = new System.Drawing.Size(135, 36);
            this.btnBuscarArquivo.TabIndex = 40;
            this.btnBuscarArquivo.Text = "Buscar Arquivo Excel ";
            this.btnBuscarArquivo.UseVisualStyleBackColor = false;
            this.btnBuscarArquivo.Click += new System.EventHandler(this.btnBuscarArquivo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarRelatorio);
            this.groupBox1.Controls.Add(this.btnBuscarArquivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 419);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(350, 18);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(135, 36);
            this.btnGerarRelatorio.TabIndex = 44;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnFiltrarAlunosEmpresa
            // 
            this.btnFiltrarAlunosEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarAlunosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarAlunosEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarAlunosEmpresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarAlunosEmpresa.Location = new System.Drawing.Point(204, 210);
            this.btnFiltrarAlunosEmpresa.Name = "btnFiltrarAlunosEmpresa";
            this.btnFiltrarAlunosEmpresa.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarAlunosEmpresa.TabIndex = 50;
            this.btnFiltrarAlunosEmpresa.Text = "Filtrar Alunos na Empresa";
            this.btnFiltrarAlunosEmpresa.UseVisualStyleBackColor = false;
            this.btnFiltrarAlunosEmpresa.Click += new System.EventHandler(this.btnFiltrarAlunosEmpresa_Click);
            // 
            // dtpFiltrarDataMatricula
            // 
            this.dtpFiltrarDataMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltrarDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltrarDataMatricula.Location = new System.Drawing.Point(33, 105);
            this.dtpFiltrarDataMatricula.Name = "dtpFiltrarDataMatricula";
            this.dtpFiltrarDataMatricula.Size = new System.Drawing.Size(165, 22);
            this.dtpFiltrarDataMatricula.TabIndex = 49;
            // 
            // btnFiltrarTurma
            // 
            this.btnFiltrarTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTurma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarTurma.Location = new System.Drawing.Point(204, 151);
            this.btnFiltrarTurma.Name = "btnFiltrarTurma";
            this.btnFiltrarTurma.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarTurma.TabIndex = 48;
            this.btnFiltrarTurma.Text = "Filtrar por Turma";
            this.btnFiltrarTurma.UseVisualStyleBackColor = false;
            this.btnFiltrarTurma.Click += new System.EventHandler(this.btnFiltrarTurma_Click);
            // 
            // txtFiltrarTurma
            // 
            this.txtFiltrarTurma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarTurma.Location = new System.Drawing.Point(33, 166);
            this.txtFiltrarTurma.Name = "txtFiltrarTurma";
            this.txtFiltrarTurma.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarTurma.TabIndex = 47;
            this.txtFiltrarTurma.Enter += new System.EventHandler(this.txtFiltrarTurma_Enter);
            this.txtFiltrarTurma.Leave += new System.EventHandler(this.txtFiltrarTurma_Leave);
            // 
            // btnFiltrarDataMatricula
            // 
            this.btnFiltrarDataMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarDataMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarDataMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarDataMatricula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarDataMatricula.Location = new System.Drawing.Point(204, 92);
            this.btnFiltrarDataMatricula.Name = "btnFiltrarDataMatricula";
            this.btnFiltrarDataMatricula.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarDataMatricula.TabIndex = 46;
            this.btnFiltrarDataMatricula.Text = "Filtrar por Data de Matrícula";
            this.btnFiltrarDataMatricula.UseVisualStyleBackColor = false;
            this.btnFiltrarDataMatricula.Click += new System.EventHandler(this.btnFiltrarDataMatricula_Click);
            // 
            // btnFiltrarRA
            // 
            this.btnFiltrarRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarRA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarRA.Location = new System.Drawing.Point(204, 33);
            this.btnFiltrarRA.Name = "btnFiltrarRA";
            this.btnFiltrarRA.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarRA.TabIndex = 45;
            this.btnFiltrarRA.Text = "Filtrar por RA";
            this.btnFiltrarRA.UseVisualStyleBackColor = false;
            this.btnFiltrarRA.Click += new System.EventHandler(this.btnFiltrarRA_Click);
            // 
            // txtFiltrarRA
            // 
            this.txtFiltrarRA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarRA.Location = new System.Drawing.Point(33, 48);
            this.txtFiltrarRA.Name = "txtFiltrarRA";
            this.txtFiltrarRA.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarRA.TabIndex = 44;
            this.txtFiltrarRA.Enter += new System.EventHandler(this.txtFiltrarRA_Enter);
            this.txtFiltrarRA.Leave += new System.EventHandler(this.txtFiltrarRA_Leave);
            // 
            // txtFiltrarPorIdade
            // 
            this.txtFiltrarPorIdade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPorIdade.Location = new System.Drawing.Point(33, 284);
            this.txtFiltrarPorIdade.Name = "txtFiltrarPorIdade";
            this.txtFiltrarPorIdade.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarPorIdade.TabIndex = 53;
            this.txtFiltrarPorIdade.Enter += new System.EventHandler(this.txtFiltrarPorIdade_Enter);
            this.txtFiltrarPorIdade.Leave += new System.EventHandler(this.txtFiltrarPorIdade_Leave);
            // 
            // btnFiltrarPorIdade
            // 
            this.btnFiltrarPorIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarPorIdade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorIdade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarPorIdade.Location = new System.Drawing.Point(204, 269);
            this.btnFiltrarPorIdade.Name = "btnFiltrarPorIdade";
            this.btnFiltrarPorIdade.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarPorIdade.TabIndex = 52;
            this.btnFiltrarPorIdade.Text = "Filtrar Alunos por Idade ";
            this.btnFiltrarPorIdade.UseVisualStyleBackColor = false;
            this.btnFiltrarPorIdade.Click += new System.EventHandler(this.btnFiltrarPorIdade_Click);
            // 
            // txtFiltrarPorGenero
            // 
            this.txtFiltrarPorGenero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPorGenero.Location = new System.Drawing.Point(33, 343);
            this.txtFiltrarPorGenero.Name = "txtFiltrarPorGenero";
            this.txtFiltrarPorGenero.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarPorGenero.TabIndex = 55;
            this.txtFiltrarPorGenero.Enter += new System.EventHandler(this.txtFiltrarPorGenero_Enter);
            this.txtFiltrarPorGenero.Leave += new System.EventHandler(this.txtFiltrarPorGenero_Leave);
            // 
            // btnFiltrarPorGenero
            // 
            this.btnFiltrarPorGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarPorGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarPorGenero.Location = new System.Drawing.Point(204, 328);
            this.btnFiltrarPorGenero.Name = "btnFiltrarPorGenero";
            this.btnFiltrarPorGenero.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarPorGenero.TabIndex = 54;
            this.btnFiltrarPorGenero.Text = "Filtrar Alunos por Gênero";
            this.btnFiltrarPorGenero.UseVisualStyleBackColor = false;
            this.btnFiltrarPorGenero.Click += new System.EventHandler(this.btnFiltrarPorGenero_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskFiltrarAlunosNaEmpresa);
            this.groupBox2.Controls.Add(this.txtFiltrarPorGenero);
            this.groupBox2.Controls.Add(this.btnFiltrarRA);
            this.groupBox2.Controls.Add(this.btnFiltrarPorGenero);
            this.groupBox2.Controls.Add(this.txtFiltrarRA);
            this.groupBox2.Controls.Add(this.txtFiltrarPorIdade);
            this.groupBox2.Controls.Add(this.btnFiltrarDataMatricula);
            this.groupBox2.Controls.Add(this.btnFiltrarPorIdade);
            this.groupBox2.Controls.Add(this.txtFiltrarTurma);
            this.groupBox2.Controls.Add(this.btnFiltrarTurma);
            this.groupBox2.Controls.Add(this.btnFiltrarAlunosEmpresa);
            this.groupBox2.Controls.Add(this.dtpFiltrarDataMatricula);
            this.groupBox2.Location = new System.Drawing.Point(513, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 419);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // mskFiltrarAlunosNaEmpresa
            // 
            this.mskFiltrarAlunosNaEmpresa.Location = new System.Drawing.Point(33, 227);
            this.mskFiltrarAlunosNaEmpresa.Mask = "999,999,999/99999-99";
            this.mskFiltrarAlunosNaEmpresa.Name = "mskFiltrarAlunosNaEmpresa";
            this.mskFiltrarAlunosNaEmpresa.Size = new System.Drawing.Size(165, 20);
            this.mskFiltrarAlunosNaEmpresa.TabIndex = 56;
            // 
            // FormBuscaAvancada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(840, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscaAvancada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRelatorioAluno";
            this.Load += new System.EventHandler(this.FormBuscaAvancada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscarArquivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Button btnFiltrarAlunosEmpresa;
        private System.Windows.Forms.DateTimePicker dtpFiltrarDataMatricula;
        private System.Windows.Forms.Button btnFiltrarTurma;
        private System.Windows.Forms.TextBox txtFiltrarTurma;
        private System.Windows.Forms.Button btnFiltrarDataMatricula;
        private System.Windows.Forms.Button btnFiltrarRA;
        private System.Windows.Forms.TextBox txtFiltrarRA;
        private System.Windows.Forms.TextBox txtFiltrarPorIdade;
        private System.Windows.Forms.Button btnFiltrarPorIdade;
        private System.Windows.Forms.TextBox txtFiltrarPorGenero;
        private System.Windows.Forms.Button btnFiltrarPorGenero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskFiltrarAlunosNaEmpresa;
    }
}