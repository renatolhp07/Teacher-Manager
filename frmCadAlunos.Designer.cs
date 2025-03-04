namespace Teacher_Manager
{
    partial class frmCadAlunos
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
            pAluno = new Panel();
            txtEmail = new TextBox();
            label11 = new Label();
            txtRgAluno = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label10 = new Label();
            txtNomeResp = new TextBox();
            label9 = new Label();
            txtEndResp = new TextBox();
            label6 = new Label();
            txtCpfResp = new TextBox();
            label7 = new Label();
            txtRgResp = new TextBox();
            label8 = new Label();
            txtEndAluno = new TextBox();
            label5 = new Label();
            txtCpfAluno = new TextBox();
            label4 = new Label();
            txtNomeAluno = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            pControles = new Panel();
            btSalvar = new Button();
            btAlterar = new Button();
            btCancelar = new Button();
            btExcluir = new Button();
            btConsulta = new Button();
            btCadastrar = new Button();
            pAluno.SuspendLayout();
            pControles.SuspendLayout();
            SuspendLayout();
            // 
            // pAluno
            // 
            pAluno.Controls.Add(txtEmail);
            pAluno.Controls.Add(label11);
            pAluno.Controls.Add(txtRgAluno);
            pAluno.Controls.Add(label3);
            pAluno.Controls.Add(txtTelefone);
            pAluno.Controls.Add(label10);
            pAluno.Controls.Add(txtNomeResp);
            pAluno.Controls.Add(label9);
            pAluno.Controls.Add(txtEndResp);
            pAluno.Controls.Add(label6);
            pAluno.Controls.Add(txtCpfResp);
            pAluno.Controls.Add(label7);
            pAluno.Controls.Add(txtRgResp);
            pAluno.Controls.Add(label8);
            pAluno.Controls.Add(txtEndAluno);
            pAluno.Controls.Add(label5);
            pAluno.Controls.Add(txtCpfAluno);
            pAluno.Controls.Add(label4);
            pAluno.Controls.Add(txtNomeAluno);
            pAluno.Controls.Add(label2);
            pAluno.Controls.Add(txtCodigo);
            pAluno.Controls.Add(label1);
            pAluno.Location = new Point(14, 12);
            pAluno.Name = "pAluno";
            pAluno.Size = new Size(756, 328);
            pAluno.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(346, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(386, 27);
            txtEmail.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(346, 57);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 23;
            label11.Text = "E-mail Aluno";
            // 
            // txtRgAluno
            // 
            txtRgAluno.Location = new Point(576, 27);
            txtRgAluno.Name = "txtRgAluno";
            txtRgAluno.Size = new Size(159, 27);
            txtRgAluno.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 4);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 21;
            label3.Text = "RG Aluno";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(183, 80);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 27);
            txtTelefone.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(183, 57);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 19;
            label10.Text = "Telefone Aluno";
            // 
            // txtNomeResp
            // 
            txtNomeResp.Location = new Point(18, 186);
            txtNomeResp.Name = "txtNomeResp";
            txtNomeResp.Size = new Size(717, 27);
            txtNomeResp.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 163);
            label9.Name = "label9";
            label9.Size = new Size(353, 20);
            label9.TabIndex = 17;
            label9.Text = "Nome do Responsável (para aluno menor de idade)";
            // 
            // txtEndResp
            // 
            txtEndResp.Location = new Point(18, 292);
            txtEndResp.Name = "txtEndResp";
            txtEndResp.Size = new Size(717, 27);
            txtEndResp.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 269);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 15;
            label6.Text = "Endereço Responsável";
            // 
            // txtCpfResp
            // 
            txtCpfResp.Location = new Point(255, 239);
            txtCpfResp.Name = "txtCpfResp";
            txtCpfResp.Size = new Size(480, 27);
            txtCpfResp.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 216);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 13;
            label7.Text = "CPF Responsável";
            // 
            // txtRgResp
            // 
            txtRgResp.Location = new Point(18, 239);
            txtRgResp.Name = "txtRgResp";
            txtRgResp.Size = new Size(212, 27);
            txtRgResp.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 216);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 11;
            label8.Text = "RG Responsável";
            // 
            // txtEndAluno
            // 
            txtEndAluno.Location = new Point(18, 133);
            txtEndAluno.Name = "txtEndAluno";
            txtEndAluno.Size = new Size(717, 27);
            txtEndAluno.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 110);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 8;
            label5.Text = "Endereço do Aluno";
            // 
            // txtCpfAluno
            // 
            txtCpfAluno.Location = new Point(18, 80);
            txtCpfAluno.Name = "txtCpfAluno";
            txtCpfAluno.Size = new Size(154, 27);
            txtCpfAluno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 57);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "CPF Aluno";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(133, 27);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(437, 27);
            txtNomeAluno.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 4);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome do Aluno";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(18, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(94, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 4);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // pControles
            // 
            pControles.Controls.Add(btSalvar);
            pControles.Controls.Add(btAlterar);
            pControles.Controls.Add(btCancelar);
            pControles.Controls.Add(btExcluir);
            pControles.Controls.Add(btConsulta);
            pControles.Controls.Add(btCadastrar);
            pControles.Location = new Point(14, 346);
            pControles.Name = "pControles";
            pControles.Size = new Size(756, 67);
            pControles.TabIndex = 1;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(263, 10);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(112, 41);
            btSalvar.TabIndex = 14;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(384, 10);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(112, 41);
            btAlterar.TabIndex = 15;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            btCancelar.Location = new Point(620, 10);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(112, 41);
            btCancelar.TabIndex = 17;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(502, 10);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 41);
            btExcluir.TabIndex = 16;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btConsulta
            // 
            btConsulta.Location = new Point(143, 10);
            btConsulta.Name = "btConsulta";
            btConsulta.Size = new Size(112, 41);
            btConsulta.TabIndex = 13;
            btConsulta.Text = "Consultar";
            btConsulta.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(21, 10);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(112, 41);
            btCadastrar.TabIndex = 12;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // frmCadAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(782, 414);
            Controls.Add(pControles);
            Controls.Add(pAluno);
            Name = "frmCadAlunos";
            Text = "-";
            Load += frmCadAlunos_Load;
            pAluno.ResumeLayout(false);
            pAluno.PerformLayout();
            pControles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pAluno;
        private Panel pControles;
        private TextBox txtNomeAluno;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtEndAluno;
        private Label label5;
        private TextBox txtCpfAluno;
        private Label label4;
        private TextBox txtTelefone;
        private Label label10;
        private TextBox txtNomeResp;
        private Label label9;
        private TextBox txtEndResp;
        private Label label6;
        private TextBox txtCpfResp;
        private Label label7;
        private TextBox txtRgResp;
        private Label label8;
        private Button btCancelar;
        private Button btExcluir;
        private Button btConsulta;
        private Button btCadastrar;
        private Button btAlterar;
        private Button btSalvar;
        private TextBox txtEmail;
        private Label label11;
        private TextBox txtRgAluno;
        private Label label3;
    }
}