namespace WindowsFormsApp1
{
    partial class LanchoneteFAM
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_pedido = new System.Windows.Forms.TabPage();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dgv_itensPedido = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.cb_produtos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btg_confirmar = new System.Windows.Forms.Button();
            this.btg_inserirProduto = new System.Windows.Forms.Button();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.tb_nomeCliente = new System.Windows.Forms.Label();
            this.txt_nomeCLiente = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tb_pedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itensPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_pedido);
            this.tabControl1.Location = new System.Drawing.Point(-4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 676);
            this.tabControl1.TabIndex = 1;
            // 
            // tb_pedido
            // 
            this.tb_pedido.BackColor = System.Drawing.Color.Cornsilk;
            this.tb_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tb_pedido.Controls.Add(this.lbl_total);
            this.tb_pedido.Controls.Add(this.dgv_itensPedido);
            this.tb_pedido.Controls.Add(this.lbl_produtos);
            this.tb_pedido.Controls.Add(this.lbl_quantidade);
            this.tb_pedido.Controls.Add(this.txt_qtd);
            this.tb_pedido.Controls.Add(this.cb_produtos);
            this.tb_pedido.Controls.Add(this.pictureBox1);
            this.tb_pedido.Controls.Add(this.btn_cancelar);
            this.tb_pedido.Controls.Add(this.btg_confirmar);
            this.tb_pedido.Controls.Add(this.btg_inserirProduto);
            this.tb_pedido.Controls.Add(this.txt_cpf);
            this.tb_pedido.Controls.Add(this.lbl_cpf);
            this.tb_pedido.Controls.Add(this.tb_nomeCliente);
            this.tb_pedido.Controls.Add(this.txt_nomeCLiente);
            this.tb_pedido.Location = new System.Drawing.Point(4, 22);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Padding = new System.Windows.Forms.Padding(3);
            this.tb_pedido.Size = new System.Drawing.Size(827, 650);
            this.tb_pedido.TabIndex = 0;
            this.tb_pedido.Text = "Pedido";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(628, 549);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(154, 13);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "Valor total do pedido: R$ 00.00";
            // 
            // dgv_itensPedido
            // 
            this.dgv_itensPedido.AllowUserToDeleteRows = false;
            this.dgv_itensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.Produto,
            this.Valor,
            this.Quantidade});
            this.dgv_itensPedido.Location = new System.Drawing.Point(184, 314);
            this.dgv_itensPedido.Name = "dgv_itensPedido";
            this.dgv_itensPedido.ReadOnly = true;
            this.dgv_itensPedido.Size = new System.Drawing.Size(438, 248);
            this.dgv_itensPedido.TabIndex = 16;
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.HeaderText = "Código do Produto";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.Location = new System.Drawing.Point(236, 253);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(52, 13);
            this.lbl_produtos.TabIndex = 15;
            this.lbl_produtos.Text = "Produtos:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(426, 253);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(65, 13);
            this.lbl_quantidade.TabIndex = 14;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(494, 250);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(32, 20);
            this.txt_qtd.TabIndex = 13;
            // 
            // cb_produtos
            // 
            this.cb_produtos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_produtos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_produtos.FormattingEnabled = true;
            this.cb_produtos.Location = new System.Drawing.Point(294, 250);
            this.cb_produtos.Name = "cb_produtos";
            this.cb_produtos.Size = new System.Drawing.Size(121, 21);
            this.cb_produtos.Sorted = true;
            this.cb_produtos.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cb_produtos, "dsad");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Lanchonete_FAM_2;
            this.pictureBox1.Location = new System.Drawing.Point(141, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Orange;
            this.btn_cancelar.Location = new System.Drawing.Point(410, 569);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(116, 23);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar Pedido";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btg_confirmar
            // 
            this.btg_confirmar.BackColor = System.Drawing.Color.Orange;
            this.btg_confirmar.Location = new System.Drawing.Point(283, 569);
            this.btg_confirmar.Name = "btg_confirmar";
            this.btg_confirmar.Size = new System.Drawing.Size(118, 23);
            this.btg_confirmar.TabIndex = 9;
            this.btg_confirmar.Text = "Finalizar Pedido";
            this.btg_confirmar.UseVisualStyleBackColor = false;
            this.btg_confirmar.Click += new System.EventHandler(this.btg_confirmar_Click);
            // 
            // btg_inserirProduto
            // 
            this.btg_inserirProduto.Location = new System.Drawing.Point(346, 286);
            this.btg_inserirProduto.Name = "btg_inserirProduto";
            this.btg_inserirProduto.Size = new System.Drawing.Size(111, 23);
            this.btg_inserirProduto.TabIndex = 6;
            this.btg_inserirProduto.Text = "Inserir Produto";
            this.btg_inserirProduto.UseVisualStyleBackColor = true;
            this.btg_inserirProduto.Click += new System.EventHandler(this.btg_inserirProduto_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(294, 207);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(163, 20);
            this.txt_cpf.TabIndex = 3;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(203, 207);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpf.TabIndex = 2;
            this.lbl_cpf.Text = "CPF:";
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.AutoSize = true;
            this.tb_nomeCliente.Location = new System.Drawing.Point(200, 181);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(88, 13);
            this.tb_nomeCliente.TabIndex = 1;
            this.tb_nomeCliente.Text = "Nome do Cliente:";
            // 
            // txt_nomeCLiente
            // 
            this.txt_nomeCLiente.Location = new System.Drawing.Point(294, 178);
            this.txt_nomeCLiente.Name = "txt_nomeCLiente";
            this.txt_nomeCLiente.Size = new System.Drawing.Size(282, 20);
            this.txt_nomeCLiente.TabIndex = 0;
            // 
            // LanchoneteFAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "LanchoneteFAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lanchonete FAM";
            this.tabControl1.ResumeLayout(false);
            this.tb_pedido.ResumeLayout(false);
            this.tb_pedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itensPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_pedido;
        private System.Windows.Forms.Label tb_nomeCliente;
        private System.Windows.Forms.TextBox txt_nomeCLiente;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btg_inserirProduto;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btg_confirmar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_produtos;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_produtos;
        private System.Windows.Forms.DataGridView dgv_itensPedido;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}

