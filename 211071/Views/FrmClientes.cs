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
    public partial class FrmClientes : Form
    {
        cidades ci;
        cliente cl;
        
        public FrmClientes()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            txt_id.Clear();
            txt_nome.Clear();
            txt_pesquisa.Clear();
            txt_renda.Clear();
            txt_uf.Clear();
            dtp_data_nasc.Value = DateTime.Now;
            pic_foto.ImageLocation = "";
            chk_venda.Checked = false;
        }
        void CarregarGrid(string pesquisa)
        {
            cl = new cliente()
            {
                nome = pesquisa
            };
            dgv_clientes.DataSource = cl.consultar();

        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ci = new cidades();
            cbo_cidades.DataSource = ci.consultar();
            cbo_cidades.DisplayMember = "nome";
            cbo_cidades.ValueMember = "id";

            limpaControles();
            CarregarGrid("");

            dgv_clientes.Columns["id_cidade"].Visible = false;
            dgv_clientes.Columns["foto"].Visible = false;
        }

        private void cbo_cidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_cidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cbo_cidades.SelectedItem;
                txt_uf.Text = reg["uf"].ToString();
            }
        }

        private void pic_foto_Click(object sender, EventArgs e)
        {
            ofd_arquivo.InitialDirectory = "D:/fotos/clientes/";
            ofd_arquivo.FileName = "";
            ofd_arquivo.ShowDialog();
            pic_foto.ImageLocation = ofd_arquivo.FileName;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "") return;

            cl = new cliente()
            {
                nome = txt_nome.Text,
                id_cidade = (int)cbo_cidades.SelectedValue,
                data_nasc = dtp_data_nasc.Value,
                renda = double.Parse(txt_renda.Text),
                cpf = msk_cpf.Text,
                foto = pic_foto.ImageLocation,
                venda = chk_venda.Checked
            };
            cl.incluir();

            limpaControles();
            CarregarGrid("");
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_clientes.RowCount > 0)
            {
                txt_id.Text = dgv_clientes.CurrentRow.Cells["id"].Value.ToString();
                txt_nome.Text = dgv_clientes.CurrentRow.Cells["nome"].Value.ToString();
                cbo_cidades.Text = dgv_clientes.CurrentRow.Cells["cidade"].Value.ToString();
                txt_uf.Text = dgv_clientes.CurrentRow.Cells["uf"].Value.ToString();
                chk_venda.Checked = (bool)dgv_clientes.CurrentRow.Cells["venda"].Value;
                msk_cpf.Text = dgv_clientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtp_data_nasc.Text = dgv_clientes.CurrentRow.Cells["data_nasc"].Value.ToString();
                txt_renda.Text = dgv_clientes.CurrentRow.Cells["renda"].Value.ToString();
                pic_foto.ImageLocation = dgv_clientes.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "") return;

            cl = new cliente()
            {
                id = int.Parse(txt_id.Text),
                nome = txt_nome.Text,
                id_cidade = (int)cbo_cidades.SelectedValue,
                data_nasc = dtp_data_nasc.Value,
                renda = double.Parse(txt_renda.Text),
                cpf = msk_cpf.Text,
                foto = pic_foto.ImageLocation,
                venda = chk_venda.Checked
            };
            cl.alterar();
            limpaControles();
            CarregarGrid("");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "") return;

            if (MessageBox.Show("Deseja excluir o cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new cliente()
                {
                    id = int.Parse(txt_id.Text)
                };
                cl.excluir();
                limpaControles();
                CarregarGrid("");
            }    
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            CarregarGrid("");
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            CarregarGrid(txt_pesquisa.Text);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
