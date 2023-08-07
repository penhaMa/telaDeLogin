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
    public partial class Botoes : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exu;
        DAO consu;
        public Botoes()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exu = new Excluir();
            consu = new DAO();
        }//Fim do Construtor

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//Cadastar

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();

        }//Consultar

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//Atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            exu.ShowDialog();
        }//Excluir

    }//Fim da classe
}//Fim do projeto
