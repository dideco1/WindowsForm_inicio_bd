namespace _211071.Views
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_renda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_venda = new System.Windows.Forms.CheckBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pic_cliente = new System.Windows.Forms.PictureBox();
            this.cbo_produto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_qntd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_estoque = new System.Windows.Forms.TextBox();
            this.pic_produto = new System.Windows.Forms.PictureBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.dgv_produto = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.msk_nasc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(69, 8);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(448, 21);
            this.cbo_cliente.TabIndex = 1;
            this.cbo_cliente.SelectedIndexChanged += new System.EventHandler(this.cbo_cliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(69, 38);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(354, 20);
            this.txt_cidade.TabIndex = 3;
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(429, 38);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(88, 20);
            this.txt_uf.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "CPF:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(249, 74);
            this.msk_cpf.Mask = "000.000.000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 20);
            this.msk_cpf.TabIndex = 44;
            // 
            // txt_renda
            // 
            this.txt_renda.Location = new System.Drawing.Point(416, 75);
            this.txt_renda.Name = "txt_renda";
            this.txt_renda.Size = new System.Drawing.Size(101, 20);
            this.txt_renda.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Renda:";
            // 
            // chk_venda
            // 
            this.chk_venda.AutoSize = true;
            this.chk_venda.Location = new System.Drawing.Point(69, 113);
            this.chk_venda.Name = "chk_venda";
            this.chk_venda.Size = new System.Drawing.Size(115, 17);
            this.chk_venda.TabIndex = 49;
            this.chk_venda.Text = "Bloqueia a venda?";
            this.chk_venda.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(429, 109);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(88, 46);
            this.btn_confirmar.TabIndex = 50;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pic_cliente
            // 
            this.pic_cliente.Location = new System.Drawing.Point(523, 8);
            this.pic_cliente.Name = "pic_cliente";
            this.pic_cliente.Size = new System.Drawing.Size(146, 147);
            this.pic_cliente.TabIndex = 51;
            this.pic_cliente.TabStop = false;
            // 
            // cbo_produto
            // 
            this.cbo_produto.FormattingEnabled = true;
            this.cbo_produto.Location = new System.Drawing.Point(69, 200);
            this.cbo_produto.Name = "cbo_produto";
            this.cbo_produto.Size = new System.Drawing.Size(448, 21);
            this.cbo_produto.TabIndex = 53;
            this.cbo_produto.SelectedIndexChanged += new System.EventHandler(this.cbo_produto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Produto:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(69, 227);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(448, 20);
            this.txt_marca.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Marca:";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(89, 253);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(428, 20);
            this.txt_categoria.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Categoria:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 59;
            this.label9.Text = "Quantidade:";
            // 
            // txt_qntd
            // 
            this.txt_qntd.Location = new System.Drawing.Point(101, 279);
            this.txt_qntd.Name = "txt_qntd";
            this.txt_qntd.Size = new System.Drawing.Size(94, 20);
            this.txt_qntd.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 61;
            this.label10.Text = "Preço:";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(259, 281);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(91, 20);
            this.txt_preco.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Estoque:";
            // 
            // txt_estoque
            // 
            this.txt_estoque.Location = new System.Drawing.Point(440, 279);
            this.txt_estoque.Name = "txt_estoque";
            this.txt_estoque.Size = new System.Drawing.Size(77, 20);
            this.txt_estoque.TabIndex = 62;
            // 
            // pic_produto
            // 
            this.pic_produto.Location = new System.Drawing.Point(523, 200);
            this.pic_produto.Name = "pic_produto";
            this.pic_produto.Size = new System.Drawing.Size(146, 144);
            this.pic_produto.TabIndex = 64;
            this.pic_produto.TabStop = false;
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(440, 301);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(77, 43);
            this.btn_remover.TabIndex = 65;
            this.btn_remover.Text = "Remover produto";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(357, 301);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(77, 43);
            this.btn_inserir.TabIndex = 66;
            this.btn_inserir.Text = "Inserir Produto";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // dgv_produto
            // 
            this.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produto.Location = new System.Drawing.Point(5, 350);
            this.dgv_produto.Name = "dgv_produto";
            this.dgv_produto.Size = new System.Drawing.Size(664, 150);
            this.dgv_produto.TabIndex = 67;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(440, 506);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 64);
            this.btn_cancelar.TabIndex = 69;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(554, 506);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(110, 64);
            this.btn_fechar.TabIndex = 70;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(324, 506);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(110, 64);
            this.btn_gravar.TabIndex = 71;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 527);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(65, 527);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(40, 20);
            this.lbl_total.TabIndex = 73;
            this.lbl_total.Text = "0,00";
            // 
            // msk_nasc
            // 
            this.msk_nasc.Location = new System.Drawing.Point(94, 75);
            this.msk_nasc.Mask = "00/00/0000";
            this.msk_nasc.Name = "msk_nasc";
            this.msk_nasc.Size = new System.Drawing.Size(100, 20);
            this.msk_nasc.TabIndex = 74;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 582);
            this.Controls.Add(this.msk_nasc);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dgv_produto);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.pic_produto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_estoque);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_qntd);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic_cliente);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.chk_venda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_renda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_cliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.TextBox txt_renda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_venda;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.PictureBox pic_cliente;
        private System.Windows.Forms.ComboBox cbo_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_qntd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_estoque;
        private System.Windows.Forms.PictureBox pic_produto;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.DataGridView dgv_produto;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.MaskedTextBox msk_nasc;
    }
}