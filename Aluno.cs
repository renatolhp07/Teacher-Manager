using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Adicionando class Aluno e seus respectivos construtores
namespace Teacher_Manager
{
    public class Aluno
    {
        public Aluno() 
        {
            this.Codigo = 0;
            this.Nome = "";
            this.RgAluno = "";
            this.CpfAluno = "";
            this.Email = "";
            this.TelAluno = "";
            this.EnderecoAluno = "";
            this.ResponsavelAluno = "";
            this.RgResponsavel = "";
            this.CpfResponsavel = "";
            this.EnderecoResp = "";
        }

        public Aluno(int idAluno, String nomeAluno, String rgAluno, 
            String cpfAluno, String email, String enderecoAluno, String respAluno, 
            String rgResp, String cpfResp, String enderecoResp, String telAluno)
        {
            this.Codigo = idAluno;
            this.Nome = nomeAluno;
            this.RgAluno = rgAluno;
            this.CpfAluno = cpfAluno;
            this.TelAluno = telAluno;
            this.Email = email;
            this.EnderecoAluno = enderecoAluno;
            this.ResponsavelAluno = respAluno;
            this.RgResponsavel = rgResp;
            this.CpfResponsavel = cpfResp;
            this.EnderecoResp = enderecoResp;
        }

        private int id_aluno;
        public int Codigo
        {
            get 
            { 
                return this.id_aluno; 
            }
            set
            {
                this.id_aluno = value;
            }
        }
           
        private string nome_aluno;
        public string Nome
        {
            get
            {
                return this.nome_aluno;
            }
            set
            {
                this.nome_aluno = value;
            }
        }

        private string rg_aluno;
        public string RgAluno
        {
            get
            {
                return this.rg_aluno;
            }
            set
            {
                this.rg_aluno = value;
            }
        }

        private string cpf_aluno;
        public string CpfAluno
        {
            get
            {
                return this.cpf_aluno;
            }
            set
            {
                this.cpf_aluno = value;
            }
        }

        private string email_aluno;
        public string Email
        {
            get
            {
                return this.email_aluno;
            }
            set
            {
                this.email_aluno = value;
            }
        }

        private string endereco_aluno;
        public string EnderecoAluno
        {
            get
            {
                return this.endereco_aluno;
            }
            set
            {
                this.endereco_aluno = value;
            }
        }

        private string responsavel_aluno;
        public string ResponsavelAluno
        {
            get
            {
                return this.responsavel_aluno;
            }
            set
            {
                this.responsavel_aluno = value;
            }
        }

        private string rg_responsavel;
        public string RgResponsavel
        {
            get
            {
                return this.rg_responsavel;
            }
            set
            {
                this.rg_responsavel = value;
            }
        }

        private string cpf_responsavel;
        public string CpfResponsavel
        {
            get
            {
                return this.cpf_responsavel;
            }
            set
            {
                this.cpf_responsavel = value;
            }
        }

        private string endereco_resp;
        public string EnderecoResp
        {
            get
            {
                return this.endereco_resp;
            }
            set
            {
                this.endereco_resp = value;
            }
        }

        private string tel_aluno;
        public string TelAluno
        {
            get
            {
                return this.tel_aluno;
            }
            set
            {
                this.tel_aluno = value;
            }
        }
    }
}
