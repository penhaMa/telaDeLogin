using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaDeLogin
{
    public partial class Cadastrar : Form
    {
        DAO conectar;
        public Cadastrar()
        {
            InitializeComponent();
            conectar= new DAO();
        }//Fim do construtor

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = conectar.Inserir(Convert.ToInt64(cpf.Text), nome.Text, telefone.Text,
                                 cidade.Text, uf.Text, "pessoa");
                MessageBox.Show(result);
            }catch(Exception erro) 
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch
        }//Fim do botão inserir

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do CPF

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//Fim da cidade

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim da UF

    }//Fim da classe
}//Fim do projeto
