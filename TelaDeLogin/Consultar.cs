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
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();//Nomear os títulos das colunas  
            AdicionarDados();//Preenchendo o dataGridView1
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";
        }//Fim do método consultar

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Deletar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Redimensionar Linhas

            dataGridView1.ColumnCount = 5;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AdicionarDados()
        {
            consul.PreencherVetor();//Preencher os vetores
            for (int i = 0; i < consul.QuatidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.CPF[i], consul.nome[i], consul.telefone[i], consul.cidade[i], consul.uf[i]);
            }//Adicionando dados no dataGridView1
        }//Fim do método

    }//Fim da classe
}//Fim do Projeto
