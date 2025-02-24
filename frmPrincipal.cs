namespace Teacher_Manager
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btContato_Click(object sender, EventArgs e)
        {
            frmCadAlunos f = new frmCadAlunos();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
