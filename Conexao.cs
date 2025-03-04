﻿using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teacher_Manager
{
    internal class Conexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;
        //transaction

        public Conexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get
            {
                return this._stringConexao;
            }
            set
            {
                this._stringConexao = value;
            }
        }
        public SqlConnection ObjetoConexao
        {
            get
            {
                return this._conexao;
            }
            set
            {
                this._conexao = value;
            }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }
        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
