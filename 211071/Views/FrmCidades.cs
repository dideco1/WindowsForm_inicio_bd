using _211071.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211071.Views
{
    public partial class FrmCidades : Form
    {
        cidades c;
        public FrmCidades()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            txt_cidade.Clear();
            txt_id.Clear();
            txt_pesquisa.Clear();
            txt_uf.Clear();
        }
        void CarregarGrid(string pesquisa)
        {
            c = new cidades()
            {
                nome = pesquisa
            };
            dgv_cidades.DataSource = c.consultar();

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            CarregarGrid("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "") return;
            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new cidades()
                {
                    id = int.Parse(txt_id.Text)
                };
                c.excluir();

                limpaControles();
                CarregarGrid("");
            }

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txt_cidade.Text == string.Empty) return;
            c = new cidades()
            {
                nome = txt_cidade.Text,
                uf = txt_uf.Text
            };
            c.incluir();

            limpaControles();
            CarregarGrid("");
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            CarregarGrid(txt_pesquisa.Text);
        }
    }
}
