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

        private void btnCadTeacher_Click(object sender, EventArgs e)
        {
            frmCadTeacher f = new frmCadTeacher();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda f = new frmAgenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmAgenda f = new frmAgenda();
            f.ShowDialog();
            f.Dispose();
        }
    }
    
}
