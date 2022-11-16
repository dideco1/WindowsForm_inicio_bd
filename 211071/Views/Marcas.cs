using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211071.Model;

namespace _211071.Views
{
    public partial class Marcas : Form
    {
        marcas m;
        public Marcas()
        {
            InitializeComponent();
        }
        void LimparControles()
        {
            txt_id.Clear();
            txt_marca.Clear();
            txt_pesquisa.Clear();
        }
        void CarregarGrid(String pesquisa)
        {
            m = new marcas()
            {
                marca = pesquisa
            };
            dgv_marcas.DataSource = m.Consultar();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid(txt_pesquisa.Text);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txt_marca.Text == String.Empty) return;

            m = new marcas()
            {
                marca = txt_marca.Text,
            };

            m.Incluir();

            LimparControles();
            CarregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == String.Empty) return;

            m = new marcas()
            {
                id = int.Parse(txt_id.Text),
                marca = txt_marca.Text,
            };
            m.Alterar();

            LimparControles();
            CarregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparControles();
            CarregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "") return;

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new marcas()
                {
                    id = int.Parse(txt_id.Text)
                };
                m.Excluir();

                LimparControles();
                CarregarGrid("");
            }
        }
    }
}
