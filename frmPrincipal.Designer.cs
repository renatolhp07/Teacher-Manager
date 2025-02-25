
namespace Teacher_Manager
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btContato = new Button();
            btnCadTeacher = new Button();
            btnAgenda = new Button();
            SuspendLayout();
            // 
            // btContato
            // 
            btContato.Image = (Image)resources.GetObject("btContato.Image");
            btContato.Location = new Point(27, 21);
            btContato.Name = "btContato";
            btContato.Size = new Size(179, 134);
            btContato.TabIndex = 0;
            btContato.Text = "Cadastrar Aluno";
            btContato.TextAlign = ContentAlignment.BottomCenter;
            btContato.UseMnemonic = false;
            btContato.UseVisualStyleBackColor = true;
            btContato.Click += btContato_Click;
            // 
            // btnCadTeacher
            // 
            btnCadTeacher.BackgroundImage = (Image)resources.GetObject("btnCadTeacher.BackgroundImage");
            btnCadTeacher.BackgroundImageLayout = ImageLayout.Center;
            btnCadTeacher.ForeColor = SystemColors.ControlText;
            btnCadTeacher.Location = new Point(232, 21);
            btnCadTeacher.Name = "btnCadTeacher";
            btnCadTeacher.Size = new Size(179, 134);
            btnCadTeacher.TabIndex = 1;
            btnCadTeacher.Text = "Cadastrar Professor";
            btnCadTeacher.TextAlign = ContentAlignment.BottomCenter;
            btnCadTeacher.UseMnemonic = false;
            btnCadTeacher.UseVisualStyleBackColor = true;
            btnCadTeacher.Click += btnCadTeacher_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.BackgroundImage = (Image)resources.GetObject("btnAgenda.BackgroundImage");
            btnAgenda.BackgroundImageLayout = ImageLayout.Center;
            btnAgenda.Location = new Point(436, 21);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(179, 134);
            btnAgenda.TabIndex = 2;
            btnAgenda.Text = "Agendar Aula";
            btnAgenda.TextAlign = ContentAlignment.BottomCenter;
            btnAgenda.UseMnemonic = false;
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 181);
            Controls.Add(btnAgenda);
            Controls.Add(btnCadTeacher);
            Controls.Add(btContato);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento de Aulas";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Button btContato;
        private Button btnCadTeacher;
        private Button btnAgenda;
    }
}
