using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class LanchoneteFAM : Form
    {
        private List<Produto> _listaDeProdutos = new List<Produto>();
        public List<Produto> _ListaDeProdutos
        {
            get
            {
                if (_listaDeProdutos.Count < 1)
                {
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "Croissant", CodigoProduto = 1, Valor = 3 });
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "Coca Cola", CodigoProduto = 2, Valor = 2.52 });
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "Coxinha", CodigoProduto = 3, Valor = 3 });
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "Empada de Frango", CodigoProduto = 4, Valor = 3 });
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "Fanta Laranja", CodigoProduto = 5, Valor = 2.5 });
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "X-Salada", CodigoProduto = 6, Valor = 10 });
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "Folhado de Queijo", CodigoProduto = 7, Valor = 5.5 });
                    _listaDeProdutos.Add(new Produto() { NomeProduto = "X-Calabresa", CodigoProduto = 8, Valor = 10 });
                }
                return _listaDeProdutos;
            }
            set { _listaDeProdutos = value; }
        }
        public LanchoneteFAM()
        {
            InitializeComponent();

            foreach (Produto produto in _ListaDeProdutos)
            {
                cb_produtos.Items.Add(produto);
            }

            this.cb_produtos.DisplayMember = "NomeProduto";
            lbl_total.Text = $"Valor total do pedido: R$ 00.00";
        }
        private void btg_confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_itensPedido.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show($"Selecione ao menos 1 produto para finalizar o pedido.");
            }
            else
            {
                Random random = new Random();
                MessageBox.Show($"Pedido gerado com sucesso.\nNome do Cliente: {txt_nomeCLiente.Text}\n CPF do Cliente: {txt_cpf.Text} \nCódigo do pedido: {random.Next()}\nValor do pedido: R$ {lbl_total.Text}");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            dgv_itensPedido.Rows.Clear();
            txt_cpf.Text = string.Empty;
            txt_nomeCLiente.Text = string.Empty;
            txt_qtd.Text = string.Empty;
            lbl_total.Text = $"Valor total do pedido: R$ 00.00";
            MessageBox.Show($"Pedido cancelado com sucesso.");
        }
        private void btg_inserirProduto_Click(object sender, EventArgs e)
        {
            if (cb_produtos.SelectedItem == null)
            {
                MessageBox.Show($"Selecione ao menos 1 produto para seguir com o pedido.");
                return;
            }

            if (String.IsNullOrEmpty(txt_qtd.Text))
            {
                MessageBox.Show($"Você deve inserir uma quatidade.");
                return;
            }

            double total = 0.00;
            Produto produto = (Produto)cb_produtos.SelectedItem;

            int.TryParse(txt_qtd.Text, out int qtd);
            bool possui = false;

            foreach (DataGridViewRow row in dgv_itensPedido.Rows)
            {
                if (produto.NomeProduto.Equals(row.Cells["Produto"].Value))
                {
                    possui = true;
                }

                if (possui)
                {
                    int.TryParse(row.Cells["Quantidade"].Value.ToString(), out int qtdLinha);

                    row.Cells["Quantidade"].Value = qtdLinha + qtd;
                    break;
                }
                else
                {
                    dgv_itensPedido.Rows.Add(produto.CodigoProduto, produto.NomeProduto, produto.Valor, qtd);
                    break;
                }
            }

            foreach (DataGridViewRow row in dgv_itensPedido.Rows)
            {
                if (row.Cells["Valor"].Value == null)
                    continue;

                double.TryParse(row.Cells["Valor"].Value.ToString(), out double valor);
                int.TryParse(row.Cells["Quantidade"].Value.ToString(), out int qty);

                total += valor * qty;
            }

            cb_produtos.Text = string.Empty;
            txt_qtd.Text = string.Empty;
            lbl_total.Text = $"Valor total do pedido: R$ {total.ToString()}";
        }
    }
}
