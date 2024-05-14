using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BO;
using WindowsFormsApp1.Objetos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region + Privados
        private ClientesBO bo = null;
        #endregion - Privados

        #region + Construtores

        public Form1()
        {
            InitializeComponent();

            bo = new ClientesBO();
        }

        #endregion - Construtores


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IList<Cliente> colecao = null;
            var pesquisa = txtPesquisa.Text.ToLower();
            var tipo = Objetos.Enumeracoes.TipoPesquisa.Codigo.ToShort();

            if (rdbCodigo.Checked) tipo = Objetos.Enumeracoes.TipoPesquisa.Codigo.ToShort();
            else if (rdbCidade.Checked) tipo = Objetos.Enumeracoes.TipoPesquisa.Cidade.ToShort();
            else if (rdbCliente.Checked) tipo = Objetos.Enumeracoes.TipoPesquisa.Cliente.ToShort();
            else if (rdbVendedor.Checked) tipo = Objetos.Enumeracoes.TipoPesquisa.Vendedor.ToShort();
      
            switch (tipo)
            {
                case 0: colecao = bo.BuscaPor(Objetos.Enumeracoes.TipoPesquisa.Codigo, pesquisa); break;
                case 1: colecao = bo.BuscaPor(Objetos.Enumeracoes.TipoPesquisa.Cidade, pesquisa); break;
                case 2: colecao = bo.BuscaPor(Objetos.Enumeracoes.TipoPesquisa.Cliente, pesquisa); break;
                case 3: colecao = bo.BuscaPor(Objetos.Enumeracoes.TipoPesquisa.Vendedor, pesquisa); break;
            }

            lblTotal.Text = colecao.Count.ToString();

            //GridView
            if (tabControlPrincipal.SelectedTab == tabPageGridView)
            {
                dgvClientes.DataSource = colecao.ToList();
            }
            //ListView
            else
            {
                PreencheListView_Manual(colecao.ToList());
            }
        }

        private void PreencheListView_Manual(List<Cliente> clientes)
        {
            listViewClientes.Columns.Clear();
            listViewClientes.Items.Clear();

            listViewClientes.Columns.Add("Código", 50);
            listViewClientes.Columns.Add("Nome", 200);
            listViewClientes.Columns.Add("Cidade", 130);
            listViewClientes.Columns.Add("UF", 50);
            listViewClientes.Columns.Add("Telefone", 100);
            listViewClientes.Columns.Add("E-mail", 200);
            listViewClientes.Columns.Add("Vendedor", 150);

            foreach (var c in clientes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = c.Codigo.ToString();
                item.SubItems.Add(c.Nome);
                item.SubItems.Add(c.Cidade);
                item.SubItems.Add(c.UF);
                item.SubItems.Add(c.Telefone);
                item.SubItems.Add(c.Email);
                item.SubItems.Add(c.Vendedor);
                listViewClientes.Items.Add(item);
            }
        }
    }
}
