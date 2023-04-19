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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela;
        private void Abrir_janela(Form fh)
        {
            tela = fh;
            tela.TopLevel =false;
            tela.FormBorderStyle = FormBorderStyle.None;
            tela.Dock = DockStyle.Fill;
            pnl_Tela.Controls.Add(tela);
            tela.Show();
        }

        private void btn_Fornecedor_Click(object sender, EventArgs e)
        {

            Abrir_janela(new TelaFornecedor());
            

        }
    }
}
