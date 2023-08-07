using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            InitializeComponent();
            atu = new DAO();
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "nome",nome.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "telefone", telefone.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "cidade", cidade.Text);
            atu.Atualizar(Convert.ToInt64(cpf.Text), "Pessoa", "uf", uf.Text);
            MessageBox.Show("Dados Atualizados com Sucesso");
        }//Fim do método atualizar

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//CPF

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//NOME

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//TELEFONE

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//CIDADE

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//UF
    }//Fim da classe
}//Fim do projeto
