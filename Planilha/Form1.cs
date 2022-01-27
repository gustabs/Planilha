using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.cadastroDataSet.Pessoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pessoaBindingSource.MovePrevious();
        }

        private void proximo_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.MoveNext();
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.RemoveCurrent();
        }

        private void novoCad_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.AddNew();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            pessoaBindingSource.EndEdit();
            pessoaTableAdapter.Update(cadastroDataSet);
        }
    }
}
