﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//Importando a classe de dados

namespace TelaDeLogin
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] CPF;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] uf;
        public int i;
        public int contador;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;database=EmpresaTI17T;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão com o banco de dados
                MessageBox.Show("Conectado");
            }catch(Exception erro) 
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }
        }//Fim do construtor

        //Métodos de inserção
        public string Inserir(long CPF, string nome, string telefone, string cidade, string UF, string nomeTabela)
        {
            string inserir = $"Insert into {nomeTabela}(CPF, nome, telefone, cidade, UF) values('{CPF}','{nome}','{telefone}','{cidade}','{UF}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }//Fim da inserir

        //Método de Consulta
        public void PreencherVetor()
        {
            string query = "Select * from Pessoa";

            //Instanciar
            this.CPF      = new long[100];
            this.nome     = new string[100];
            this.telefone = new string[100];
            this.cidade   = new string[100];
            this.uf       = new string[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);

            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                CPF[i] = Convert.ToInt64(leitura["CPF"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                cidade[i] = leitura["cidade"] + "";
                uf[i] = leitura["UF"] + "";
                i++;
                contador++;
            }//Fim do while

            //Encerrando a comunicaxão
            leitura.Close();
        }//Fim do método

        public int QuatidadeDados()
        {
            return contador;
        }//Fim do método

        public string Atualizar(long CPF, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where CPF = '{CPF}'";
            MySqlCommand sql = new MySqlCommand (query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//Fim do método

        public string Excluir(long CPF, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where CPF = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluido";
            return resultado;
        }//Fim do método

    }//Fim da classe
}//Fim do projeto
