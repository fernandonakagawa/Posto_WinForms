
namespace Posto_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.tbPrecoEtanol = new System.Windows.Forms.TextBox();
            this.tbPrecoGasolina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVendas = new System.Windows.Forms.GroupBox();
            this.lbFaturamento = new System.Windows.Forms.Label();
            this.lvVendas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btConcluir = new System.Windows.Forms.Button();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.gbVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btModificar);
            this.groupBox1.Controls.Add(this.tbPrecoEtanol);
            this.groupBox1.Controls.Add(this.tbPrecoGasolina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(487, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preços";
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(65, 77);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 4;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // tbPrecoEtanol
            // 
            this.tbPrecoEtanol.Enabled = false;
            this.tbPrecoEtanol.Location = new System.Drawing.Point(65, 48);
            this.tbPrecoEtanol.MaxLength = 8;
            this.tbPrecoEtanol.Name = "tbPrecoEtanol";
            this.tbPrecoEtanol.Size = new System.Drawing.Size(100, 23);
            this.tbPrecoEtanol.TabIndex = 3;
            // 
            // tbPrecoGasolina
            // 
            this.tbPrecoGasolina.Enabled = false;
            this.tbPrecoGasolina.Location = new System.Drawing.Point(65, 20);
            this.tbPrecoGasolina.MaxLength = 8;
            this.tbPrecoGasolina.Name = "tbPrecoGasolina";
            this.tbPrecoGasolina.Size = new System.Drawing.Size(100, 23);
            this.tbPrecoGasolina.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etanol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gasolina";
            // 
            // gbVendas
            // 
            this.gbVendas.Controls.Add(this.lbFaturamento);
            this.gbVendas.Controls.Add(this.lvVendas);
            this.gbVendas.Controls.Add(this.btConcluir);
            this.gbVendas.Controls.Add(this.tbQuantidade);
            this.gbVendas.Controls.Add(this.label4);
            this.gbVendas.Controls.Add(this.label3);
            this.gbVendas.Controls.Add(this.cbProduto);
            this.gbVendas.Location = new System.Drawing.Point(13, 13);
            this.gbVendas.Name = "gbVendas";
            this.gbVendas.Size = new System.Drawing.Size(468, 342);
            this.gbVendas.TabIndex = 1;
            this.gbVendas.TabStop = false;
            this.gbVendas.Text = "Vendas";
            // 
            // lbFaturamento
            // 
            this.lbFaturamento.AutoSize = true;
            this.lbFaturamento.Location = new System.Drawing.Point(17, 314);
            this.lbFaturamento.Name = "lbFaturamento";
            this.lbFaturamento.Size = new System.Drawing.Size(159, 15);
            this.lbFaturamento.TabIndex = 8;
            this.lbFaturamento.Text = "Total faturado no dia: R$ 0,00";
            // 
            // lvVendas
            // 
            this.lvVendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvVendas.HideSelection = false;
            this.lvVendas.Location = new System.Drawing.Point(17, 114);
            this.lvVendas.Name = "lvVendas";
            this.lvVendas.Size = new System.Drawing.Size(433, 183);
            this.lvVendas.TabIndex = 7;
            this.lvVendas.UseCompatibleStateImageBehavior = false;
            this.lvVendas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Produto";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço por Litro";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 100;
            // 
            // btConcluir
            // 
            this.btConcluir.Location = new System.Drawing.Point(328, 50);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(122, 49);
            this.btConcluir.TabIndex = 5;
            this.btConcluir.Text = "Concluir Venda";
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(200, 64);
            this.tbQuantidade.MaxLength = 8;
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 23);
            this.tbQuantidade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto:";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol"});
            this.cbProduto.Location = new System.Drawing.Point(17, 64);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 23);
            this.cbProduto.TabIndex = 0;
            this.cbProduto.Text = "Gasolina";
            // 
            // Id
            // 
            this.Id.Text = "id";
            this.Id.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 367);
            this.Controls.Add(this.gbVendas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbVendas.ResumeLayout(false);
            this.gbVendas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox tbPrecoEtanol;
        private System.Windows.Forms.TextBox tbPrecoGasolina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVendas;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.ListView lvVendas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbFaturamento;
        private System.Windows.Forms.ColumnHeader Id;
    }
}

