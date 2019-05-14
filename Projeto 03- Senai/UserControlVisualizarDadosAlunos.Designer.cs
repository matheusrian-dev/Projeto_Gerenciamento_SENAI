namespace Projeto_03__Senai
{
    partial class UserControlVisualizarDadosAlunos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFiltrarRA = new System.Windows.Forms.TextBox();
            this.btnFiltrarRA = new System.Windows.Forms.Button();
            this.btnFiltrarDataMatricula = new System.Windows.Forms.Button();
            this.btnFiltrarTurma = new System.Windows.Forms.Button();
            this.txtFiltrarTurma = new System.Windows.Forms.TextBox();
            this.dtpFiltrarDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarArquivo = new System.Windows.Forms.Button();
            this.btnFiltrarAlunosEmpresa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnIrParaBuscaAvancada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskFiltrarAlunosNaEmpresa = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtFiltrarRA
            // 
            this.txtFiltrarRA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarRA.Location = new System.Drawing.Point(372, 23);
            this.txtFiltrarRA.Name = "txtFiltrarRA";
            this.txtFiltrarRA.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarRA.TabIndex = 1;
            this.txtFiltrarRA.Enter += new System.EventHandler(this.txtBuscaRA_Enter);
            this.txtFiltrarRA.Leave += new System.EventHandler(this.txtBuscaRA_Leave);
            // 
            // btnFiltrarRA
            // 
            this.btnFiltrarRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarRA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarRA.Location = new System.Drawing.Point(543, 8);
            this.btnFiltrarRA.Name = "btnFiltrarRA";
            this.btnFiltrarRA.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarRA.TabIndex = 2;
            this.btnFiltrarRA.Text = "Filtrar por RA";
            this.btnFiltrarRA.UseVisualStyleBackColor = false;
            this.btnFiltrarRA.Click += new System.EventHandler(this.btnBuscarRA_Click);
            // 
            // btnFiltrarDataMatricula
            // 
            this.btnFiltrarDataMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarDataMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarDataMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarDataMatricula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarDataMatricula.Location = new System.Drawing.Point(543, 67);
            this.btnFiltrarDataMatricula.Name = "btnFiltrarDataMatricula";
            this.btnFiltrarDataMatricula.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarDataMatricula.TabIndex = 4;
            this.btnFiltrarDataMatricula.Text = "Filtrar por Data de Matrícula";
            this.btnFiltrarDataMatricula.UseVisualStyleBackColor = false;
            this.btnFiltrarDataMatricula.Click += new System.EventHandler(this.btnFiltrarDataMatricula_Click);
            // 
            // btnFiltrarTurma
            // 
            this.btnFiltrarTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarTurma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarTurma.Location = new System.Drawing.Point(543, 126);
            this.btnFiltrarTurma.Name = "btnFiltrarTurma";
            this.btnFiltrarTurma.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarTurma.TabIndex = 6;
            this.btnFiltrarTurma.Text = "Filtrar por Turma";
            this.btnFiltrarTurma.UseVisualStyleBackColor = false;
            this.btnFiltrarTurma.Click += new System.EventHandler(this.btnFiltrarTurma_Click);
            // 
            // txtFiltrarTurma
            // 
            this.txtFiltrarTurma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarTurma.Location = new System.Drawing.Point(372, 141);
            this.txtFiltrarTurma.Name = "txtFiltrarTurma";
            this.txtFiltrarTurma.Size = new System.Drawing.Size(165, 22);
            this.txtFiltrarTurma.TabIndex = 5;
            this.txtFiltrarTurma.Enter += new System.EventHandler(this.txtBuscarTurma_Enter);
            this.txtFiltrarTurma.Leave += new System.EventHandler(this.txtBuscarTurma_Leave);
            // 
            // dtpFiltrarDataMatricula
            // 
            this.dtpFiltrarDataMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltrarDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltrarDataMatricula.Location = new System.Drawing.Point(372, 80);
            this.dtpFiltrarDataMatricula.Name = "dtpFiltrarDataMatricula";
            this.dtpFiltrarDataMatricula.Size = new System.Drawing.Size(165, 22);
            this.dtpFiltrarDataMatricula.TabIndex = 7;
            // 
            // btnBuscarArquivo
            // 
            this.btnBuscarArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArquivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarArquivo.Location = new System.Drawing.Point(227, 15);
            this.btnBuscarArquivo.Name = "btnBuscarArquivo";
            this.btnBuscarArquivo.Size = new System.Drawing.Size(135, 36);
            this.btnBuscarArquivo.TabIndex = 8;
            this.btnBuscarArquivo.Text = "Buscar Arquivo Excel ";
            this.btnBuscarArquivo.UseVisualStyleBackColor = false;
            this.btnBuscarArquivo.Click += new System.EventHandler(this.btnBuscarArquivo_Click);
            // 
            // btnFiltrarAlunosEmpresa
            // 
            this.btnFiltrarAlunosEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrarAlunosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarAlunosEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarAlunosEmpresa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrarAlunosEmpresa.Location = new System.Drawing.Point(543, 185);
            this.btnFiltrarAlunosEmpresa.Name = "btnFiltrarAlunosEmpresa";
            this.btnFiltrarAlunosEmpresa.Size = new System.Drawing.Size(84, 53);
            this.btnFiltrarAlunosEmpresa.TabIndex = 9;
            this.btnFiltrarAlunosEmpresa.Text = "Filtrar Alunos na Empresa";
            this.btnFiltrarAlunosEmpresa.UseVisualStyleBackColor = false;
            this.btnFiltrarAlunosEmpresa.Click += new System.EventHandler(this.btnFiltrarAlunosEmpresa_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnIrParaBuscaAvancada
            // 
            this.btnIrParaBuscaAvancada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIrParaBuscaAvancada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrParaBuscaAvancada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaBuscaAvancada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIrParaBuscaAvancada.Location = new System.Drawing.Point(372, 241);
            this.btnIrParaBuscaAvancada.Name = "btnIrParaBuscaAvancada";
            this.btnIrParaBuscaAvancada.Size = new System.Drawing.Size(255, 53);
            this.btnIrParaBuscaAvancada.TabIndex = 12;
            this.btnIrParaBuscaAvancada.Text = "Ir para a Tela de Busca Avançada e Criação de Relatórios";
            this.btnIrParaBuscaAvancada.UseVisualStyleBackColor = false;
            this.btnIrParaBuscaAvancada.Click += new System.EventHandler(this.btnIrParaBuscaAvancada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tabelas do Arquivo:";
            // 
            // mskFiltrarAlunosNaEmpresa
            // 
            this.mskFiltrarAlunosNaEmpresa.Location = new System.Drawing.Point(372, 202);
            this.mskFiltrarAlunosNaEmpresa.Mask = "999,999,999/99999-99";
            this.mskFiltrarAlunosNaEmpresa.Name = "mskFiltrarAlunosNaEmpresa";
            this.mskFiltrarAlunosNaEmpresa.Size = new System.Drawing.Size(165, 20);
            this.mskFiltrarAlunosNaEmpresa.TabIndex = 14;
            // 
            // UserControlVisualizarDadosAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.mskFiltrarAlunosNaEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIrParaBuscaAvancada);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFiltrarAlunosEmpresa);
            this.Controls.Add(this.btnBuscarArquivo);
            this.Controls.Add(this.dtpFiltrarDataMatricula);
            this.Controls.Add(this.btnFiltrarTurma);
            this.Controls.Add(this.txtFiltrarTurma);
            this.Controls.Add(this.btnFiltrarDataMatricula);
            this.Controls.Add(this.btnFiltrarRA);
            this.Controls.Add(this.txtFiltrarRA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlVisualizarDadosAlunos";
            this.Size = new System.Drawing.Size(640, 304);
            this.Load += new System.EventHandler(this.UserControlVisualizarDadosAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFiltrarRA;
        private System.Windows.Forms.Button btnFiltrarRA;
        private System.Windows.Forms.Button btnFiltrarDataMatricula;
        private System.Windows.Forms.Button btnFiltrarTurma;
        private System.Windows.Forms.TextBox txtFiltrarTurma;
        private System.Windows.Forms.DateTimePicker dtpFiltrarDataMatricula;
        private System.Windows.Forms.Button btnBuscarArquivo;
        private System.Windows.Forms.Button btnFiltrarAlunosEmpresa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnIrParaBuscaAvancada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskFiltrarAlunosNaEmpresa;
    }
}
