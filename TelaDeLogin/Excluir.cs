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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt64(maskedTextBox1.Text), "Pessoa");
            MessageBox.Show(result);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
