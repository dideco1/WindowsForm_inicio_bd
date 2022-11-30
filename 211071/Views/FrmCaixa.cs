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
    public partial class FrmCaixa : Form
    {
        double totalVenda, pago, troco, dinheiro, cartao, cheque, pix, boleto;

        private void txt_boleto_TextChanged(object sender, EventArgs e)
        {
            calculartroco();
        }

        private void txt_pix_TextChanged(object sender, EventArgs e)
        {
            calculartroco();
        }

        private void txt_cartao_TextChanged(object sender, EventArgs e)
        {
            calculartroco();
        }

        private void txt_cheque_TextChanged(object sender, EventArgs e)
        {
            calculartroco();
        }

        private void txt_dinheiro_TextChanged(object sender, EventArgs e)
        {
            calculartroco();
        }

        public void calculartroco()
        {
            if (txt_dinheiro.Text == "") dinheiro = 0;
            else dinheiro = double.Parse(txt_dinheiro.Text);

            if (txt_cheque.Text == "") cheque = 0;
            else cheque = double.Parse(txt_cheque.Text);

            if (txt_pix.Text == "") pix = 0;
            else pix = double.Parse(txt_pix.Text);

            if (txt_cartao.Text == "") cartao = 0;
            else cartao = double.Parse(txt_cartao.Text);

            if (txt_boleto.Text == "") boleto = 0;
            else boleto = double.Parse(txt_boleto.Text);

            pago = dinheiro + cartao + cheque + pix + boleto;
            troco = pago - totalVenda;
            txt_troco.Text = troco.ToString("C");

            if (troco < 0) txt_troco.ForeColor = Color.Red;
            else txt_troco.ForeColor = Color.Blue;
        }
        public FrmCaixa(int idVendaCab, int idCliente, double total, string nome)
        {
            InitializeComponent();

            txt_id.Text = idCliente.ToString();
            txt_cliente.Text = nome;
            txt_valor.Text = total.ToString("C");
            txt_venda.Text = idVendaCab.ToString();
            totalVenda = total;

            calculartroco();
        }

        private void btn_pagamento_Click(object sender, EventArgs e)
        {
            if (troco < 0)
            {
                MessageBox.Show("Valor pago menor que o valor da venda", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            caixa c = new caixa()
            {
                idVendaCab = int.Parse(txt_venda.Text),
                dinheiro = dinheiro,
                cartao = cartao,
                cheque = cheque,
                boleto = boleto,
                pix = pix
            };
            c.incluir();
            Close();
        }
    }
}
