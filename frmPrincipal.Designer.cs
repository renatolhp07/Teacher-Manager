
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
            btContato = new Button();
            SuspendLayout();
            // 
            // btContato
            // 
            btContato.Location = new Point(96, 368);
            btContato.Name = "btContato";
            btContato.Size = new Size(94, 29);
            btContato.TabIndex = 0;
            btContato.Text = "Contato";
            btContato.UseVisualStyleBackColor = true;
            btContato.Click += this.btContato_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(btContato);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento de Aulas";
            Load += this.frmPrincipal_Load;
            ResumeLayout(false);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Button btContato;
    }
}
