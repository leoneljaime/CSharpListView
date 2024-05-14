namespace WindowsFormsApp1
{
    partial class Form1
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
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCidade = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbVendedor = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageGridView = new System.Windows.Forms.TabPage();
            this.tabPageListView = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.cCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cVendedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTopo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageGridView.SuspendLayout();
            this.tabPageListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(533, 26);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdbCodigo.TabIndex = 0;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Tag = "0";
            this.rdbCodigo.Text = "Código";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // pnlTopo
            // 
            this.pnlTopo.Controls.Add(this.btnBuscar);
            this.pnlTopo.Controls.Add(this.label2);
            this.pnlTopo.Controls.Add(this.txtPesquisa);
            this.pnlTopo.Controls.Add(this.rdbVendedor);
            this.pnlTopo.Controls.Add(this.rdbCliente);
            this.pnlTopo.Controls.Add(this.rdbCidade);
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Controls.Add(this.rdbCodigo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(993, 60);
            this.pnlTopo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carteira  de Clientes";
            // 
            // rdbCidade
            // 
            this.rdbCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCidade.AutoSize = true;
            this.rdbCidade.Location = new System.Drawing.Point(597, 26);
            this.rdbCidade.Name = "rdbCidade";
            this.rdbCidade.Size = new System.Drawing.Size(58, 17);
            this.rdbCidade.TabIndex = 1;
            this.rdbCidade.TabStop = true;
            this.rdbCidade.Tag = "1";
            this.rdbCidade.Text = "Cidade";
            this.rdbCidade.UseVisualStyleBackColor = true;
            // 
            // rdbCliente
            // 
            this.rdbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(661, 26);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(57, 17);
            this.rdbCliente.TabIndex = 2;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Tag = "2";
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            // 
            // rdbVendedor
            // 
            this.rdbVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbVendedor.AutoSize = true;
            this.rdbVendedor.Location = new System.Drawing.Point(724, 26);
            this.rdbVendedor.Name = "rdbVendedor";
            this.rdbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rdbVendedor.TabIndex = 3;
            this.rdbVendedor.TabStop = true;
            this.rdbVendedor.Tag = "3";
            this.rdbVendedor.Text = "Vendedor";
            this.rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Location = new System.Drawing.Point(801, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisa";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(907, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.lblTotal);
            this.pnlRodape.Controls.Add(this.label3);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 381);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(993, 50);
            this.pnlRodape.TabIndex = 2;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tabControlPrincipal);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 60);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(993, 321);
            this.pnlConteudo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total de Clientes:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(149, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0";
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageGridView);
            this.tabControlPrincipal.Controls.Add(this.tabPageListView);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(993, 321);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabPageGridView
            // 
            this.tabPageGridView.Controls.Add(this.dgvClientes);
            this.tabPageGridView.Location = new System.Drawing.Point(4, 22);
            this.tabPageGridView.Name = "tabPageGridView";
            this.tabPageGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGridView.Size = new System.Drawing.Size(985, 295);
            this.tabPageGridView.TabIndex = 0;
            this.tabPageGridView.Text = "GridView";
            this.tabPageGridView.UseVisualStyleBackColor = true;
            // 
            // tabPageListView
            // 
            this.tabPageListView.Controls.Add(this.listViewClientes);
            this.tabPageListView.Location = new System.Drawing.Point(4, 22);
            this.tabPageListView.Name = "tabPageListView";
            this.tabPageListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListView.Size = new System.Drawing.Size(985, 295);
            this.tabPageListView.TabIndex = 1;
            this.tabPageListView.Text = "ListView";
            this.tabPageListView.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Cidade,
            this.UF,
            this.Telefone,
            this.Email,
            this.Vendedor});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(979, 289);
            this.dgvClientes.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Vendedor
            // 
            this.Vendedor.DataPropertyName = "Vendedor";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            this.Vendedor.Width = 130;
            // 
            // listViewClientes
            // 
            this.listViewClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCodigo,
            this.cNome,
            this.cCidade,
            this.cUF,
            this.cTelefone,
            this.cEmail,
            this.cVendedor});
            this.listViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(3, 3);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(979, 289);
            this.listViewClientes.TabIndex = 0;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.View = System.Windows.Forms.View.Details;
            // 
            // cCodigo
            // 
            this.cCodigo.Text = "Código";
            this.cCodigo.Width = 97;
            // 
            // cNome
            // 
            this.cNome.Text = "Nome";
            this.cNome.Width = 226;
            // 
            // cCidade
            // 
            this.cCidade.Text = "Cidade";
            this.cCidade.Width = 124;
            // 
            // cUF
            // 
            this.cUF.Text = "UF";
            // 
            // cTelefone
            // 
            this.cTelefone.Text = "Telefone";
            this.cTelefone.Width = 79;
            // 
            // cEmail
            // 
            this.cEmail.Text = "Email";
            this.cEmail.Width = 161;
            // 
            // cVendedor
            // 
            this.cVendedor.Text = "Vendedor";
            this.cVendedor.Width = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 431);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlTopo);
            this.Name = "Form1";
            this.Text = "Carteira de Clientes";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.pnlConteudo.ResumeLayout(false);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageGridView.ResumeLayout(false);
            this.tabPageListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbVendedor;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageGridView;
        private System.Windows.Forms.TabPage tabPageListView;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.ListView listViewClientes;
        private System.Windows.Forms.ColumnHeader cCodigo;
        private System.Windows.Forms.ColumnHeader cNome;
        private System.Windows.Forms.ColumnHeader cCidade;
        private System.Windows.Forms.ColumnHeader cUF;
        private System.Windows.Forms.ColumnHeader cTelefone;
        private System.Windows.Forms.ColumnHeader cEmail;
        private System.Windows.Forms.ColumnHeader cVendedor;
    }
}

