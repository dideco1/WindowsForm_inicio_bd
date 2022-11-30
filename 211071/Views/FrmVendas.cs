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
using MySql.Data.MySqlClient;

namespace _211071.Views
{
    public partial class FrmVendas : Form
    {
        double total;
        cliente c;
        produto p;
        VendaCab vc;
        VendaDet vd;
        public FrmVendas()
        {
            InitializeComponent();
        }
        void limpaProduto()
        {
            cbo_produto.SelectedIndex = -1;
            txt_estoque.Clear();
            txt_preco.Clear();
            txt_qntd.Clear();
            txt_marca.Clear();
            txt_categoria.Clear();
            pic_produto.ImageLocation = "";
        }
        public void atualizaEstoque (double qntd)
        {
            try
            {
                Banco.conexao.Open();
                Banco.comando = new MySqlCommand("UPDATE produtos SET estoque = estoque - @qntd WHERE id = @id", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@qntd", qntd);
                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.ExecuteNonQuery();
                Banco.conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            c = new cliente();
            cbo_cliente.DataSource = c.consultar();
            cbo_cliente.DisplayMember = "nome";
            cbo_cliente.ValueMember = "id";

            p = new produto();
            cbo_produto.DataSource = p.consultar();
            cbo_produto.DisplayMember = "descricao";
            cbo_produto.ValueMember = "id";

            btn_cancelar.PerformClick();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dgv_produto.RowCount = 0;
            cbo_cliente.SelectedIndex = -1;
            txt_cidade.Clear();
            txt_uf.Clear();
            txt_renda.Clear();
            msk_cpf.Clear();
            msk_nasc.Clear();
            chk_venda.Checked = false;
            pic_cliente.ImageLocation = "";
            total = 0;
            lbl_total.Text = total.ToString();
            limpaProduto();
        }

        private void cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_cliente.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cbo_cliente.SelectedItem;
                txt_cidade.Text = reg["CIDADE"].ToString();
                txt_uf.Text = reg["UF"].ToString();
                txt_renda.Text = reg["RENDA"].ToString();
                msk_cpf.Text = reg["CPF"].ToString();
                msk_nasc.Text = reg["DATANASC"].ToString();
                pic_cliente.ImageLocation = reg["FOTO"].ToString();
                chk_venda.Checked = (bool)reg["VENDA"];
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (cbo_cliente.SelectedIndex != -1)
            {
                if (chk_venda.Checked)
                {
                    MessageBox.Show("Cliente bloqueado para venda", "vendas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_cancelar.PerformClick();
                    return;
                }

            }
        }

        private void cbo_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView reg = (DataRowView)cbo_produto.SelectedItem;
            txt_estoque.Text = reg["estoque"].ToString();
            txt_preco.Text = reg["ValorVenda"].ToString();
            txt_marca.Text = reg["marca"].ToString();
            txt_categoria.Text = reg["categoria"].ToString();
            pic_produto.ImageLocation = reg["foto"].ToString();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(txt_qntd.Text);
            double estoque = double.Parse(txt_estoque.Text);

            if (quantidade > estoque)
            {
                MessageBox.Show("Estoque insuficiente", "vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_qntd.SelectAll();
                return;
            }
            dgv_produto.Rows.Add(cbo_cliente.SelectedValue, cbo_produto.Text, txt_qntd.Text, txt_preco.Text);
            double preco = double.Parse(txt_preco.Text);
            total += quantidade * preco;
            lbl_total.Text = total.ToString("C");
            limpaProduto();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (dgv_produto.RowCount > 0)
            {
                double quantidade = double.Parse(dgv_produto.CurrentRow.Cells[2].Value.ToString());
                double preco = double.Parse(dgv_produto.CurrentRow.Cells[3].Value.ToString());

                total -= quantidade * preco;
                lbl_total.Text = total.ToString("C");

                dgv_produto.Rows.RemoveAt(dgv_produto.CurrentRow.Index);
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            vc = new VendaCab()
            {
                idCliente = (int)cbo_cliente.SelectedValue,
                data = DateTime.Now,
                total = total
            };
            int idVenda = vc.incluir();
            foreach (DataGridViewRow linha in dgv_produto.Rows)
            {
                vd = new VendaDet()
                {
                    idVendaCab = idVenda,
                    idProduto = Convert.ToInt32(linha.Cells[0].Value),
                    qntd = Convert.ToDouble(linha.Cells[2].Value),
                    valorUnitario = Convert.ToDouble(linha.Cells[3].Value)
                };
                vd.incluir();

                p = new produto()
                {
                    id = (int)linha.Cells[0].Value
                };
                atualizaEstoque(Convert.ToDouble(linha.Cells[2].Value));
            }
            btn_cancelar.PerformClick();
        }
    }
}
