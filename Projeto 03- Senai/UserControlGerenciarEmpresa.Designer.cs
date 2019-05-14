namespace Projeto_03__Senai
{
    partial class UserControlGerenciarEmpresa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.mskTelefoneEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResponsavelEmpresa = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(181, 41);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(375, 22);
            this.txtNomeEmpresa.TabIndex = 3;
            this.txtNomeEmpresa.Enter += new System.EventHandler(this.txtNomeEmpresa_Enter);
            this.txtNomeEmpresa.Leave += new System.EventHandler(this.txtNomeEmpresa_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmpresa.Location = new System.Drawing.Point(181, 98);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(375, 22);
            this.txtEmailEmpresa.TabIndex = 6;
            this.txtEmailEmpresa.Enter += new System.EventHandler(this.txtEmailEmpresa_Enter);
            this.txtEmailEmpresa.Leave += new System.EventHandler(this.txtEmailEmpresa_Leave);
            // 
            // mskTelefoneEmpresa
            // 
            this.mskTelefoneEmpresa.Location = new System.Drawing.Point(434, 69);
            this.mskTelefoneEmpresa.Mask = "(99) 00000-0000";
            this.mskTelefoneEmpresa.Name = "mskTelefoneEmpresa";
            this.mskTelefoneEmpresa.Size = new System.Drawing.Size(122, 20);
            this.mskTelefoneEmpresa.TabIndex = 7;
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Location = new System.Drawing.Point(181, 69);
            this.mskCNPJ.Mask = "999,999,999/99999-99";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(157, 20);
            this.mskCNPJ.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço";
            // 
            // txtEnderecoEmpresa
            // 
            this.txtEnderecoEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoEmpresa.Location = new System.Drawing.Point(181, 128);
            this.txtEnderecoEmpresa.Name = "txtEnderecoEmpresa";
            this.txtEnderecoEmpresa.Size = new System.Drawing.Size(375, 22);
            this.txtEnderecoEmpresa.TabIndex = 12;
            this.txtEnderecoEmpresa.Enter += new System.EventHandler(this.txtEnderecoEmpresa_Enter);
            this.txtEnderecoEmpresa.Leave += new System.EventHandler(this.txtEnderecoEmpresa_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Razão Social";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(181, 160);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(375, 22);
            this.txtRazaoSocial.TabIndex = 14;
            this.txtRazaoSocial.Enter += new System.EventHandler(this.txtRazaoSocial_Enter);
            this.txtRazaoSocial.Leave += new System.EventHandler(this.txtRazaoSocial_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Responsável";
            // 
            // txtResponsavelEmpresa
            // 
            this.txtResponsavelEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavelEmpresa.Location = new System.Drawing.Point(181, 191);
            this.txtResponsavelEmpresa.Name = "txtResponsavelEmpresa";
            this.txtResponsavelEmpresa.Size = new System.Drawing.Size(375, 22);
            this.txtResponsavelEmpresa.TabIndex = 16;
            this.txtResponsavelEmpresa.Enter += new System.EventHandler(this.txtResponsavelEmpresa_Enter);
            this.txtResponsavelEmpresa.Leave += new System.EventHandler(this.txtResponsavelEmpresa_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(372, 241);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 46);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 220);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Empresa";
            // 
            // btnShowEditar
            // 
            this.btnShowEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShowEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowEditar.Location = new System.Drawing.Point(501, 241);
            this.btnShowEditar.Name = "btnShowEditar";
            this.btnShowEditar.Size = new System.Drawing.Size(123, 46);
            this.btnShowEditar.TabIndex = 19;
            this.btnShowEditar.Text = "Editar Cadastro";
            this.btnShowEditar.UseVisualStyleBackColor = false;
            this.btnShowEditar.Click += new System.EventHandler(this.btnShowEditar_Click);
            // 
            // UserControlGerenciarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnShowEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtResponsavelEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEnderecoEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCNPJ);
            this.Controls.Add(this.mskTelefoneEmpresa);
            this.Controls.Add(this.txtEmailEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlGerenciarEmpresa";
            this.Size = new System.Drawing.Size(640, 304);
            this.Load += new System.EventHandler(this.UserControlGerenciarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.MaskedTextBox mskTelefoneEmpresa;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResponsavelEmpresa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowEditar;
    }
}
