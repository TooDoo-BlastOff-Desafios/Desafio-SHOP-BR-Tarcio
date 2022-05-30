namespace SHOP_BR
{
    partial class Loja
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
            this.btnCadastrarLoja = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaLojas = new System.Windows.Forms.TextBox();
            this.txtIdDeleteLoja = new System.Windows.Forms.TextBox();
            this.BuscarLoja = new System.Windows.Forms.Button();
            this.DeletarLoja = new System.Windows.Forms.Button();
            this.AtualizarLoja = new System.Windows.Forms.Button();
            this.txtEmailAtualizar = new System.Windows.Forms.TextBox();
            this.txtTelefoneAtualizar = new System.Windows.Forms.TextBox();
            this.txtNomeAtualizar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPesquisado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListarLojaProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IdLoja = new System.Windows.Forms.TextBox();
            this.IdProduto = new System.Windows.Forms.TextBox();
            this.Inserir_Loja_Produto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEnderecoAtualizar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Listar = new System.Windows.Forms.Button();
            this.VoltarMenu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarLoja
            // 
            this.btnCadastrarLoja.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarLoja.Location = new System.Drawing.Point(170, 317);
            this.btnCadastrarLoja.Name = "btnCadastrarLoja";
            this.btnCadastrarLoja.Size = new System.Drawing.Size(161, 40);
            this.btnCadastrarLoja.TabIndex = 19;
            this.btnCadastrarLoja.Text = "CADASTRAR";
            this.btnCadastrarLoja.UseVisualStyleBackColor = true;
            this.btnCadastrarLoja.Click += new System.EventHandler(this.btnCadastrarLoja_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(37, 284);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(426, 27);
            this.txtEndereco.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(37, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(426, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(37, 172);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(426, 27);
            this.txtTelefone.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(186, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "ENDEREÇO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(218, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-MAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(192, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "TELEFONE";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(37, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(426, 27);
            this.txtNome.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOME";
            // 
            // ListaLojas
            // 
            this.ListaLojas.Location = new System.Drawing.Point(510, 112);
            this.ListaLojas.Multiline = true;
            this.ListaLojas.Name = "ListaLojas";
            this.ListaLojas.Size = new System.Drawing.Size(480, 218);
            this.ListaLojas.TabIndex = 20;
            // 
            // txtIdDeleteLoja
            // 
            this.txtIdDeleteLoja.Location = new System.Drawing.Point(510, 395);
            this.txtIdDeleteLoja.Name = "txtIdDeleteLoja";
            this.txtIdDeleteLoja.Size = new System.Drawing.Size(375, 27);
            this.txtIdDeleteLoja.TabIndex = 21;
            // 
            // BuscarLoja
            // 
            this.BuscarLoja.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuscarLoja.Location = new System.Drawing.Point(891, 356);
            this.BuscarLoja.Name = "BuscarLoja";
            this.BuscarLoja.Size = new System.Drawing.Size(97, 33);
            this.BuscarLoja.TabIndex = 22;
            this.BuscarLoja.Text = "Buscar";
            this.BuscarLoja.UseVisualStyleBackColor = true;
            this.BuscarLoja.Click += new System.EventHandler(this.BuscarLoja_Click);
            // 
            // DeletarLoja
            // 
            this.DeletarLoja.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletarLoja.Location = new System.Drawing.Point(891, 395);
            this.DeletarLoja.Name = "DeletarLoja";
            this.DeletarLoja.Size = new System.Drawing.Size(97, 33);
            this.DeletarLoja.TabIndex = 23;
            this.DeletarLoja.Text = "Deletar";
            this.DeletarLoja.UseVisualStyleBackColor = true;
            this.DeletarLoja.Click += new System.EventHandler(this.DeletarLoja_Click);
            // 
            // AtualizarLoja
            // 
            this.AtualizarLoja.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AtualizarLoja.Location = new System.Drawing.Point(752, 696);
            this.AtualizarLoja.Name = "AtualizarLoja";
            this.AtualizarLoja.Size = new System.Drawing.Size(166, 42);
            this.AtualizarLoja.TabIndex = 32;
            this.AtualizarLoja.Text = "Atualizar";
            this.AtualizarLoja.UseVisualStyleBackColor = true;
            this.AtualizarLoja.Click += new System.EventHandler(this.AtualizarLoja_Click);
            // 
            // txtEmailAtualizar
            // 
            this.txtEmailAtualizar.Location = new System.Drawing.Point(724, 623);
            this.txtEmailAtualizar.Name = "txtEmailAtualizar";
            this.txtEmailAtualizar.Size = new System.Drawing.Size(215, 27);
            this.txtEmailAtualizar.TabIndex = 31;
            // 
            // txtTelefoneAtualizar
            // 
            this.txtTelefoneAtualizar.Location = new System.Drawing.Point(724, 590);
            this.txtTelefoneAtualizar.Name = "txtTelefoneAtualizar";
            this.txtTelefoneAtualizar.Size = new System.Drawing.Size(215, 27);
            this.txtTelefoneAtualizar.TabIndex = 30;
            // 
            // txtNomeAtualizar
            // 
            this.txtNomeAtualizar.Location = new System.Drawing.Point(724, 547);
            this.txtNomeAtualizar.Name = "txtNomeAtualizar";
            this.txtNomeAtualizar.Size = new System.Drawing.Size(215, 27);
            this.txtNomeAtualizar.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(577, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "ENDEREÇO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(583, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "E-MAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(583, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "TELEFONE";
            // 
            // txtIdPesquisado
            // 
            this.txtIdPesquisado.Location = new System.Drawing.Point(724, 497);
            this.txtIdPesquisado.Name = "txtIdPesquisado";
            this.txtIdPesquisado.Size = new System.Drawing.Size(215, 27);
            this.txtIdPesquisado.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(583, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "NOME";
            // 
            // ListarLojaProduto
            // 
            this.ListarLojaProduto.Location = new System.Drawing.Point(28, 404);
            this.ListarLojaProduto.Multiline = true;
            this.ListarLojaProduto.Name = "ListarLojaProduto";
            this.ListarLojaProduto.Size = new System.Drawing.Size(426, 183);
            this.ListarLojaProduto.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(191, 652);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Insira Produtos na loja";
            // 
            // IdLoja
            // 
            this.IdLoja.Location = new System.Drawing.Point(172, 678);
            this.IdLoja.Name = "IdLoja";
            this.IdLoja.Size = new System.Drawing.Size(288, 27);
            this.IdLoja.TabIndex = 35;
            // 
            // IdProduto
            // 
            this.IdProduto.Location = new System.Drawing.Point(172, 711);
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.Size = new System.Drawing.Size(288, 27);
            this.IdProduto.TabIndex = 36;
            // 
            // Inserir_Loja_Produto
            // 
            this.Inserir_Loja_Produto.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Inserir_Loja_Produto.Location = new System.Drawing.Point(228, 755);
            this.Inserir_Loja_Produto.Name = "Inserir_Loja_Produto";
            this.Inserir_Loja_Produto.Size = new System.Drawing.Size(166, 42);
            this.Inserir_Loja_Produto.TabIndex = 37;
            this.Inserir_Loja_Produto.Text = "Inserir";
            this.Inserir_Loja_Produto.UseVisualStyleBackColor = true;
            this.Inserir_Loja_Produto.Click += new System.EventHandler(this.Inserir_Loja_Produto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(28, 679);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Loja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(28, 712);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 39;
            this.label11.Text = "Produto";
            // 
            // txtEnderecoAtualizar
            // 
            this.txtEnderecoAtualizar.Location = new System.Drawing.Point(724, 656);
            this.txtEnderecoAtualizar.Name = "txtEnderecoAtualizar";
            this.txtEnderecoAtualizar.Size = new System.Drawing.Size(215, 27);
            this.txtEnderecoAtualizar.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(645, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 23);
            this.label13.TabIndex = 43;
            this.label13.Text = "ID da Loja que deseja alterar";
            // 
            // Listar
            // 
            this.Listar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Listar.Location = new System.Drawing.Point(288, 593);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(166, 42);
            this.Listar.TabIndex = 44;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // VoltarMenu
            // 
            this.VoltarMenu.Location = new System.Drawing.Point(37, 26);
            this.VoltarMenu.Name = "VoltarMenu";
            this.VoltarMenu.Size = new System.Drawing.Size(94, 29);
            this.VoltarMenu.TabIndex = 45;
            this.VoltarMenu.Text = "MENU";
            this.VoltarMenu.UseVisualStyleBackColor = true;
            this.VoltarMenu.Click += new System.EventHandler(this.VoltarMenu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(529, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 23);
            this.label12.TabIndex = 46;
            this.label12.Text = "ID da Loja que deseja deletar";
            // 
            // Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 973);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.VoltarMenu);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEnderecoAtualizar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Inserir_Loja_Produto);
            this.Controls.Add(this.IdProduto);
            this.Controls.Add(this.IdLoja);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ListarLojaProduto);
            this.Controls.Add(this.AtualizarLoja);
            this.Controls.Add(this.txtEmailAtualizar);
            this.Controls.Add(this.txtTelefoneAtualizar);
            this.Controls.Add(this.txtNomeAtualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdPesquisado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeletarLoja);
            this.Controls.Add(this.BuscarLoja);
            this.Controls.Add(this.txtIdDeleteLoja);
            this.Controls.Add(this.ListaLojas);
            this.Controls.Add(this.btnCadastrarLoja);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1020, 1020);
            this.MinimumSize = new System.Drawing.Size(1020, 1020);
            this.Name = "Loja";
            this.Text = "Cadastro Loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCadastrarLoja;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNome;
        private Label label1;
        private TextBox ListaLojas;
        private TextBox txtIdDeleteLoja;
        private Button BuscarLoja;
        private Button DeletarLoja;
        private Button AtualizarLoja;
        private TextBox txtEmailAtualizar;
        private TextBox txtTelefoneAtualizar;
        private TextBox txtNomeAtualizar;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox txtIdPesquisado;
        private Label label8;
        private TextBox ListarLojaProduto;
        private Label label9;
        private TextBox IdLoja;
        private TextBox IdProduto;
        private Button Inserir_Loja_Produto;
        private Label label10;
        private Label label11;
        private TextBox txtEnderecoAtualizar;
        private Label label13;
        private Button Listar;
        private Button VoltarMenu;
        private Label label12;
    }
}