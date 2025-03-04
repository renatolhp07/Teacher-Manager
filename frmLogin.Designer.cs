namespace Teacher_Manager
{
    partial class frmLogin
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
            btnLogar = new Button();
            lblUser = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblSenha = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(47, 124);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(81, 29);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(38, 30);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(59, 20);
            lblUser.TabIndex = 1;
            lblUser.Text = "Usuário";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(103, 27);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(103, 70);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(38, 73);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(147, 124);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 178);
            Controls.Add(btnCancel);
            Controls.Add(txtPass);
            Controls.Add(lblSenha);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(btnLogar);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private Label lblUser;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblSenha;
        private Button btnCancel;
    }
}