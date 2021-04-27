using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posto_WinForms
{
    public partial class Form1 : Form
    {
        float precoGasolina;
        float precoEtanol;
        float faturamentoDia;
        int idVendas;
        public Form1()
        {
            InitializeComponent();
            precoGasolina = 0;
            precoEtanol = 0;
            faturamentoDia = 0;
            idVendas = 0;
            //cbProduto.Enabled = false;
            //tbQuantidade.Enabled = false;
            //btConcluir.Enabled = false;
            gbVendas.Enabled = false;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (!tbPrecoGasolina.Enabled &&
                !tbPrecoEtanol.Enabled)
            {
                tbPrecoGasolina.Enabled = true;
                tbPrecoEtanol.Enabled = true;
                btModificar.Text = "OK";
                gbVendas.Enabled = false;
            }
            else
            {
                tbPrecoGasolina.Enabled = false;
                tbPrecoEtanol.Enabled = false;
                btModificar.Text = "Modificar";
                precoGasolina = float.Parse(tbPrecoGasolina.Text);
                precoEtanol = float.Parse(tbPrecoEtanol.Text);
                gbVendas.Enabled = true;
            }
        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            if(tbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Digite a quantidade vendida!");
            }
            else
            {
                //pega a quantidade em litros de combustível
                float quantidade = float.Parse(tbQuantidade.Text);
                tbQuantidade.Text = "";

                //preciso saber o valor do combustível selecionado
                float precoCombustivelSelecionado = 0;
                if (cbProduto.Text.Equals("Gasolina"))
                {
                    precoCombustivelSelecionado = precoGasolina;
                }
                else if (cbProduto.Text.Equals("Etanol"))
                {
                    precoCombustivelSelecionado = precoEtanol;
                }
                //calcular o total da venda atual
                float totalVenda = quantidade * precoCombustivelSelecionado;

                //adiciona o valor total da venda atual ao faturamento total do dia
                faturamentoDia += totalVenda;
                lbFaturamento.Text = $"Total faturado no dia: R$ {faturamentoDia.ToString("N2")}";
                MessageBox.Show("Venda realizada com sucesso!");

                //adiciona a venda dentro do histórico da ListView lvVendas
                ListViewItem item = new ListViewItem(idVendas.ToString());
                item.SubItems.Add(cbProduto.Text);
                item.SubItems.Add(quantidade.ToString());
                item.SubItems.Add(precoCombustivelSelecionado.ToString("N2"));
                item.SubItems.Add(totalVenda.ToString("N2"));
                lvVendas.Items.Add(item);
                idVendas++;
            }
        }
    }
}
