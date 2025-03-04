using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Data.SqlClient;

namespace Teacher_Manager
{
    public partial class frmCadAlunos : Form
    {
        public string operacao = "";

        public void limpaCampos()
        {
            txtCodigo.Clear();
            txtNomeAluno.Clear();
            txtRgAluno.Clear();
            txtCpfAluno.Clear();
            txtEmail.Clear();
            txtEndAluno.Clear();
            txtTelefone.Clear();
            txtNomeResp.Clear();
            txtRgResp.Clear();
            txtCpfResp.Clear();
            txtEndResp.Clear();
        }
        public frmCadAlunos()
        {
            InitializeComponent();
        }

        //Método para desabilitar os comandos até que o usuário defina o que deseja fazer
        public void AlteraBotoes(int op)
        {
            pAluno.Enabled = false;
            btCadastrar.Enabled = false;
            btConsulta.Enabled = false;
            btSalvar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;

            if (op == 1)
            {
                btCadastrar.Enabled = true;
                btConsulta.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 2)
            {
                pAluno.Enabled = true;
                btAlterar.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        /* Ao carregar o form, habilita apenas o necessário para que o usuário
        possa escolher */
        private void frmCadAlunos_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            //frmPrincipal f = new frmPrincipal();
            //f.ShowDialog();
            //f.Dispose();
            //this.Hide();
        }

        //private void frmCadAlunos_Close(object sender, EventArgs e)
        //{
        //    frmPrincipal f = new frmPrincipal();
        //    f.ShowDialog();
        //    f.Dispose();
        //    f.Hide();
        //    //this.Hide();
        //}
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.limpaCampos();
            this.AlteraBotoes(1);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.AlteraBotoes(2);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = txtNomeAluno.Text;
            aluno.RgAluno = txtRgAluno.Text;
            aluno.CpfAluno = txtCpfAluno.Text;
            aluno.TelAluno = txtTelefone.Text;
            aluno.Email = txtEmail.Text;
            aluno.EnderecoAluno = txtEndAluno.Text;
            aluno.ResponsavelAluno = txtNomeResp.Text;
            aluno.RgResponsavel = txtRgResp.Text;
            aluno.CpfResponsavel = txtCpfResp.Text;
            aluno.EnderecoResp = txtEndResp.Text;
            //cadastra os dados no banco de dados
            String strConexao = "Data Source=DESKTOP-LMPF1TS\\SQLEXPRESS;" +
                "Initial Catalog=TeacherManager;" +
                "User ID=sa;Password=*********;Encrypt=False";
            Conexao conexao = new Conexao(strConexao);
            DALAluno dal = new DALAluno(conexao);

            if (this.operacao == "cadastrar")
            {
                dal.Incluir(aluno);
                MessageBox.Show("Registro incluído com sucesso! O código do aluno é: " +
                    aluno.Codigo.ToString());
                this.limpaCampos();
            }
            else
            {
                //modifica os dados de um registro existente
                aluno.Codigo = Convert.ToInt32(txtCodigo.Text);
                //MessageBox.Show("Erro");
            }
        }
    }
}
