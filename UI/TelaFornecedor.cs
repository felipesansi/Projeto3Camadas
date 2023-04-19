using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camadas
{
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }

        Fornecedor forn;

        private void CarregaTabela()
        {
            forn=new Fornecedor();
            dgv_Dados.DataSource = forn.Pesquisar(); 
        }
        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
            CarregaTabela();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Cnpj = mtxt_Cnpj.Text;
            forn.Email = txt_Email.Text;
            forn.Telefone = mtxt_Telefone.Text;
            forn.Razao = txt_RSocial.Text;
            MessageBox.Show(forn.Gravar() ? "Salvo com sucesso!" : "Não foi possivel salvar");
            CarregaTabela();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id = int.Parse(txt_ID.Text);
            forn.Cnpj = mtxt_Cnpj.Text;
            forn.Email = txt_Email.Text;
            forn.Telefone = mtxt_Telefone.Text;
            forn.Razao = txt_RSocial.Text;
            MessageBox.Show(forn.Atualizar() ? "Atualizado com sucesso!" : "Não foi possivel atualizar");
            CarregaTabela();
            
        }


        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id = int.Parse(txt_ID.Text);
            if (forn.Excluir())
            {
                MessageBox.Show("Excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }
            CarregaTabela();
        }
    }
}
