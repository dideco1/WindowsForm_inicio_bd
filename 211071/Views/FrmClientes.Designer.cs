namespace _211071.Views
{
    partial class FrmClientes
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
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_venda = new System.Windows.Forms.CheckBox();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.cbo_cidades = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_renda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_data_nasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.ofd_arquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_pesquisa.Location = new System.Drawing.Point(388, 340);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(87, 58);
            this.btn_pesquisa.TabIndex = 29;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(15, 404);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(460, 150);
            this.dgv_clientes.TabIndex = 28;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(15, 366);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(367, 20);
            this.txt_pesquisa.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Digite o nome do cliente para pesquisa:";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_fechar.Location = new System.Drawing.Point(388, 258);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(87, 58);
            this.btn_fechar.TabIndex = 25;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_excluir.Location = new System.Drawing.Point(295, 258);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(87, 58);
            this.btn_excluir.TabIndex = 24;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_cancelar.Location = new System.Drawing.Point(202, 258);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 58);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_alterar.Location = new System.Drawing.Point(109, 258);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(87, 58);
            this.btn_alterar.TabIndex = 22;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.Location = new System.Drawing.Point(15, 258);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(87, 58);
            this.btn_incluir.TabIndex = 21;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(15, 98);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(333, 20);
            this.txt_nome.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(13, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // chk_venda
            // 
            this.chk_venda.AutoSize = true;
            this.chk_venda.Location = new System.Drawing.Point(140, 33);
            this.chk_venda.Name = "chk_venda";
            this.chk_venda.Size = new System.Drawing.Size(115, 17);
            this.chk_venda.TabIndex = 30;
            this.chk_venda.Text = "Bloqueia a venda?";
            this.chk_venda.UseVisualStyleBackColor = true;
            // 
            // pic_foto
            // 
            this.pic_foto.Location = new System.Drawing.Point(352, 12);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(146, 154);
            this.pic_foto.TabIndex = 31;
            this.pic_foto.TabStop = false;
            this.pic_foto.Click += new System.EventHandler(this.pic_foto_Click);
            // 
            // cbo_cidades
            // 
            this.cbo_cidades.FormattingEnabled = true;
            this.cbo_cidades.Location = new System.Drawing.Point(15, 154);
            this.cbo_cidades.Name = "cbo_cidades";
            this.cbo_cidades.Size = new System.Drawing.Size(166, 21);
            this.cbo_cidades.TabIndex = 32;
            this.cbo_cidades.SelectedIndexChanged += new System.EventHandler(this.cbo_cidades_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cidade:";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(187, 155);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(100, 20);
            this.txt_uf.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "UF:";
            // 
            // txt_renda
            // 
            this.txt_renda.Location = new System.Drawing.Point(352, 194);
            this.txt_renda.Name = "txt_renda";
            this.txt_renda.Size = new System.Drawing.Size(100, 20);
            this.txt_renda.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Renda:";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(15, 215);
            this.msk_cpf.Mask = "000.000.000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 20);
            this.msk_cpf.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "CPF:";
            // 
            // dtp_data_nasc
            // 
            this.dtp_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data_nasc.Location = new System.Drawing.Point(140, 215);
            this.dtp_data_nasc.Name = "dtp_data_nasc";
            this.dtp_data_nasc.Size = new System.Drawing.Size(200, 20);
            this.dtp_data_nasc.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Data de Nascimento";
            // 
            // ofd_arquivo
            // 
            this.ofd_arquivo.FileName = "ofd_arquivo";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_data_nasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.txt_renda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_cidades);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.chk_venda);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_venda;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.ComboBox cbo_cidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_renda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_data_nasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
    }
}