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
            this.txtBuscaRA = new System.Windows.Forms.TextBox();
            this.btnBuscarRA = new System.Windows.Forms.Button();
            this.btnBuscarDataMatricula = new System.Windows.Forms.Button();
            this.btnBuscarTurma = new System.Windows.Forms.Button();
            this.txtBuscarTurma = new System.Windows.Forms.TextBox();
            this.dtpBuscarDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.btnTodosAlunos = new System.Windows.Forms.Button();
            this.btnBuscarAlunosEmpresa = new System.Windows.Forms.Button();
            this.txtBuscarAlunosNaEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBuscaRA
            // 
            this.txtBuscaRA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaRA.Location = new System.Drawing.Point(382, 20);
            this.txtBuscaRA.Name = "txtBuscaRA";
            this.txtBuscaRA.Size = new System.Drawing.Size(165, 22);
            this.txtBuscaRA.TabIndex = 1;
            this.txtBuscaRA.Enter += new System.EventHandler(this.txtBuscaRA_Enter);
            this.txtBuscaRA.Leave += new System.EventHandler(this.txtBuscaRA_Leave);
            // 
            // btnBuscarRA
            // 
            this.btnBuscarRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarRA.Location = new System.Drawing.Point(553, 5);
            this.btnBuscarRA.Name = "btnBuscarRA";
            this.btnBuscarRA.Size = new System.Drawing.Size(84, 53);
            this.btnBuscarRA.TabIndex = 2;
            this.btnBuscarRA.Text = "Buscar por RA";
            this.btnBuscarRA.UseVisualStyleBackColor = false;
            this.btnBuscarRA.Click += new System.EventHandler(this.btnBuscarRA_Click);
            // 
            // btnBuscarDataMatricula
            // 
            this.btnBuscarDataMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarDataMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDataMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDataMatricula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarDataMatricula.Location = new System.Drawing.Point(553, 64);
            this.btnBuscarDataMatricula.Name = "btnBuscarDataMatricula";
            this.btnBuscarDataMatricula.Size = new System.Drawing.Size(84, 53);
            this.btnBuscarDataMatricula.TabIndex = 4;
            this.btnBuscarDataMatricula.Text = "Buscar por Data de Matrícula";
            this.btnBuscarDataMatricula.UseVisualStyleBackColor = false;
            // 
            // btnBuscarTurma
            // 
            this.btnBuscarTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTurma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarTurma.Location = new System.Drawing.Point(553, 123);
            this.btnBuscarTurma.Name = "btnBuscarTurma";
            this.btnBuscarTurma.Size = new System.Drawing.Size(84, 53);
            this.btnBuscarTurma.TabIndex = 6;
            this.btnBuscarTurma.Text = "Buscar por Turma";
            this.btnBuscarTurma.UseVisualStyleBackColor = false;
            // 
            // txtBuscarTurma
            // 
            this.txtBuscarTurma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarTurma.Location = new System.Drawing.Point(382, 138);
            this.txtBuscarTurma.Name = "txtBuscarTurma";
            this.txtBuscarTurma.Size = new System.Drawing.Size(165, 22);
            this.txtBuscarTurma.TabIndex = 5;
            this.txtBuscarTurma.Enter += new System.EventHandler(this.txtBuscarTurma_Enter);
            this.txtBuscarTurma.Leave += new System.EventHandler(this.txtBuscarTurma_Leave);
            // 
            // dtpBuscarDataMatricula
            // 
            this.dtpBuscarDataMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBuscarDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarDataMatricula.Location = new System.Drawing.Point(382, 77);
            this.dtpBuscarDataMatricula.Name = "dtpBuscarDataMatricula";
            this.dtpBuscarDataMatricula.Size = new System.Drawing.Size(165, 22);
            this.dtpBuscarDataMatricula.TabIndex = 7;
            // 
            // btnTodosAlunos
            // 
            this.btnTodosAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTodosAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosAlunos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTodosAlunos.Location = new System.Drawing.Point(553, 241);
            this.btnTodosAlunos.Name = "btnTodosAlunos";
            this.btnTodosAlunos.Size = new System.Drawing.Size(84, 53);
            this.btnTodosAlunos.TabIndex = 8;
            this.btnTodosAlunos.Text = "Buscar Todos os Alunos";
            this.btnTodosAlunos.UseVisualStyleBackColor = false;
            // 
            // btnBuscarAlunosEmpresa
            // 
            this.btnBuscarAlunosEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarAlunosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlunosEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAlunosEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarAlunosEmpresa.Location = new System.Drawing.Point(553, 182);
            this.btnBuscarAlunosEmpresa.Name = "btnBuscarAlunosEmpresa";
            this.btnBuscarAlunosEmpresa.Size = new System.Drawing.Size(84, 53);
            this.btnBuscarAlunosEmpresa.TabIndex = 9;
            this.btnBuscarAlunosEmpresa.Text = "Buscar Alunos na Empresa";
            this.btnBuscarAlunosEmpresa.UseVisualStyleBackColor = false;
            // 
            // txtBuscarAlunosNaEmpresa
            // 
            this.txtBuscarAlunosNaEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAlunosNaEmpresa.Location = new System.Drawing.Point(382, 197);
            this.txtBuscarAlunosNaEmpresa.Name = "txtBuscarAlunosNaEmpresa";
            this.txtBuscarAlunosNaEmpresa.Size = new System.Drawing.Size(165, 22);
            this.txtBuscarAlunosNaEmpresa.TabIndex = 10;
            this.txtBuscarAlunosNaEmpresa.Enter += new System.EventHandler(this.txtBuscarAlunosNaEmpresa_Enter);
            this.txtBuscarAlunosNaEmpresa.Leave += new System.EventHandler(this.txtBuscarAlunosNaEmpresa_Leave);
            // 
            // UserControlVisualizarDadosAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txtBuscarAlunosNaEmpresa);
            this.Controls.Add(this.btnBuscarAlunosEmpresa);
            this.Controls.Add(this.btnTodosAlunos);
            this.Controls.Add(this.dtpBuscarDataMatricula);
            this.Controls.Add(this.btnBuscarTurma);
            this.Controls.Add(this.txtBuscarTurma);
            this.Controls.Add(this.btnBuscarDataMatricula);
            this.Controls.Add(this.btnBuscarRA);
            this.Controls.Add(this.txtBuscaRA);
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
        private System.Windows.Forms.TextBox txtBuscaRA;
        private System.Windows.Forms.Button btnBuscarRA;
        private System.Windows.Forms.Button btnBuscarDataMatricula;
        private System.Windows.Forms.Button btnBuscarTurma;
        private System.Windows.Forms.TextBox txtBuscarTurma;
        private System.Windows.Forms.DateTimePicker dtpBuscarDataMatricula;
        private System.Windows.Forms.Button btnTodosAlunos;
        private System.Windows.Forms.Button btnBuscarAlunosEmpresa;
        private System.Windows.Forms.TextBox txtBuscarAlunosNaEmpresa;
    }
}
