namespace _211071.Views
{
    partial class FrmCaixa
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_venda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dinheiro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cheque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_boleto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_pagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(80, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(186, 9);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(305, 20);
            this.txt_cliente.TabIndex = 3;
            // 
            // txt_venda
            // 
            this.txt_venda.Location = new System.Drawing.Point(80, 35);
            this.txt_venda.Name = "txt_venda";
            this.txt_venda.Size = new System.Drawing.Size(100, 20);
            this.txt_venda.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Venda:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(273, 35);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            // 
            // txt_dinheiro
            // 
            this.txt_dinheiro.Location = new System.Drawing.Point(209, 97);
            this.txt_dinheiro.Name = "txt_dinheiro";
            this.txt_dinheiro.Size = new System.Drawing.Size(232, 20);
            this.txt_dinheiro.TabIndex = 9;
            this.txt_dinheiro.TextChanged += new System.EventHandler(this.txt_dinheiro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dinheiro:";
            // 
            // txt_cheque
            // 
            this.txt_cheque.Location = new System.Drawing.Point(209, 123);
            this.txt_cheque.Name = "txt_cheque";
            this.txt_cheque.Size = new System.Drawing.Size(232, 20);
            this.txt_cheque.TabIndex = 11;
            this.txt_cheque.TextChanged += new System.EventHandler(this.txt_cheque_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cheque:";
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(209, 149);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(232, 20);
            this.txt_cartao.TabIndex = 13;
            this.txt_cartao.TextChanged += new System.EventHandler(this.txt_cartao_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cartão:";
            // 
            // txt_pix
            // 
            this.txt_pix.Location = new System.Drawing.Point(209, 175);
            this.txt_pix.Name = "txt_pix";
            this.txt_pix.Size = new System.Drawing.Size(232, 20);
            this.txt_pix.TabIndex = 15;
            this.txt_pix.TextChanged += new System.EventHandler(this.txt_pix_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pix:";
            // 
            // txt_boleto
            // 
            this.txt_boleto.Location = new System.Drawing.Point(209, 201);
            this.txt_boleto.Name = "txt_boleto";
            this.txt_boleto.Size = new System.Drawing.Size(232, 20);
            this.txt_boleto.TabIndex = 17;
            this.txt_boleto.TextChanged += new System.EventHandler(this.txt_boleto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Boleto:";
            // 
            // txt_troco
            // 
            this.txt_troco.Location = new System.Drawing.Point(209, 297);
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.Size = new System.Drawing.Size(232, 20);
            this.txt_troco.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Troco:";
            // 
            // btn_pagamento
            // 
            this.btn_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagamento.Location = new System.Drawing.Point(198, 359);
            this.btn_pagamento.Name = "btn_pagamento";
            this.btn_pagamento.Size = new System.Drawing.Size(145, 79);
            this.btn_pagamento.TabIndex = 20;
            this.btn_pagamento.Text = "Realizar Pagamento";
            this.btn_pagamento.UseVisualStyleBackColor = true;
            this.btn_pagamento.Click += new System.EventHandler(this.btn_pagamento_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btn_pagamento);
            this.Controls.Add(this.txt_troco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_boleto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_pix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cartao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cheque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dinheiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_venda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_venda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dinheiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cheque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_boleto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_pagamento;
    }
}