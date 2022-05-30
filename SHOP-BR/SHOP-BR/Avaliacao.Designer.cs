namespace SHOP_BR
{
    partial class Avaliacao
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
            this.visualizarAvaliacoes = new System.Windows.Forms.Button();
            this.exibirAvaliacao = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtcod_cliente = new System.Windows.Forms.TextBox();
            this.txtcodProduto = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnviarAvaliacao = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtcodProdutoDeleteAvaliacao = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricaoAtualizar = new System.Windows.Forms.TextBox();
            this.txtNotaAtualizar = new System.Windows.Forms.TextBox();
            this.txtCodProdutoParaAtualizar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VoltarMenu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodClienteParaAtualizar = new System.Windows.Forms.TextBox();
            this.txtcodClienteDeleteAvaliacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visualizarAvaliacoes
            // 
            this.visualizarAvaliacoes.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualizarAvaliacoes.Location = new System.Drawing.Point(842, 404);
            this.visualizarAvaliacoes.Name = "visualizarAvaliacoes";
            this.visualizarAvaliacoes.Size = new System.Drawing.Size(141, 46);
            this.visualizarAvaliacoes.TabIndex = 24;
            this.visualizarAvaliacoes.Text = "AVALIAÇÕES";
            this.visualizarAvaliacoes.UseVisualStyleBackColor = true;
            this.visualizarAvaliacoes.Click += new System.EventHandler(this.visualizarAvaliacoes_Click);
            // 
            // exibirAvaliacao
            // 
            this.exibirAvaliacao.Location = new System.Drawing.Point(557, 76);
            this.exibirAvaliacao.Multiline = true;
            this.exibirAvaliacao.Name = "exibirAvaliacao";
            this.exibirAvaliacao.Size = new System.Drawing.Size(437, 293);
            this.exibirAvaliacao.TabIndex = 23;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(205, 202);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(313, 27);
            this.txtNota.TabIndex = 35;
            // 
            // txtcod_cliente
            // 
            this.txtcod_cliente.Location = new System.Drawing.Point(205, 153);
            this.txtcod_cliente.Name = "txtcod_cliente";
            this.txtcod_cliente.Size = new System.Drawing.Size(313, 27);
            this.txtcod_cliente.TabIndex = 34;
            // 
            // txtcodProduto
            // 
            this.txtcodProduto.Location = new System.Drawing.Point(205, 102);
            this.txtcodProduto.Name = "txtcodProduto";
            this.txtcodProduto.Size = new System.Drawing.Size(313, 27);
            this.txtcodProduto.TabIndex = 33;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(205, 250);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(313, 126);
            this.txtDescricao.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "COD_CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "COD_PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "NOTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // EnviarAvaliacao
            // 
            this.EnviarAvaliacao.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnviarAvaliacao.Location = new System.Drawing.Point(284, 395);
            this.EnviarAvaliacao.Name = "EnviarAvaliacao";
            this.EnviarAvaliacao.Size = new System.Drawing.Size(144, 64);
            this.EnviarAvaliacao.TabIndex = 41;
            this.EnviarAvaliacao.Text = "ENVIAR";
            this.EnviarAvaliacao.UseVisualStyleBackColor = true;
            this.EnviarAvaliacao.Click += new System.EventHandler(this.EnviarAvaliacao_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(859, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 36);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtcodProdutoDeleteAvaliacao
            // 
            this.txtcodProdutoDeleteAvaliacao.Location = new System.Drawing.Point(526, 494);
            this.txtcodProdutoDeleteAvaliacao.Name = "txtcodProdutoDeleteAvaliacao";
            this.txtcodProdutoDeleteAvaliacao.Size = new System.Drawing.Size(313, 27);
            this.txtcodProdutoDeleteAvaliacao.TabIndex = 43;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.Location = new System.Drawing.Point(709, 890);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(144, 64);
            this.btnAtualizar.TabIndex = 53;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(444, 745);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 52;
            this.label5.Text = "DESCRIÇÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(444, 697);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "NOTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(444, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "COD_PRODUTO";
            // 
            // txtDescricaoAtualizar
            // 
            this.txtDescricaoAtualizar.Location = new System.Drawing.Point(630, 745);
            this.txtDescricaoAtualizar.Multiline = true;
            this.txtDescricaoAtualizar.Name = "txtDescricaoAtualizar";
            this.txtDescricaoAtualizar.Size = new System.Drawing.Size(313, 126);
            this.txtDescricaoAtualizar.TabIndex = 48;
            // 
            // txtNotaAtualizar
            // 
            this.txtNotaAtualizar.Location = new System.Drawing.Point(630, 697);
            this.txtNotaAtualizar.Name = "txtNotaAtualizar";
            this.txtNotaAtualizar.Size = new System.Drawing.Size(313, 27);
            this.txtNotaAtualizar.TabIndex = 47;
            // 
            // txtCodProdutoParaAtualizar
            // 
            this.txtCodProdutoParaAtualizar.Location = new System.Drawing.Point(630, 617);
            this.txtCodProdutoParaAtualizar.Name = "txtCodProdutoParaAtualizar";
            this.txtCodProdutoParaAtualizar.Size = new System.Drawing.Size(313, 27);
            this.txtCodProdutoParaAtualizar.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(347, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "COD_PRODUTO";
            // 
            // VoltarMenu
            // 
            this.VoltarMenu.Location = new System.Drawing.Point(31, 21);
            this.VoltarMenu.Name = "VoltarMenu";
            this.VoltarMenu.Size = new System.Drawing.Size(94, 29);
            this.VoltarMenu.TabIndex = 56;
            this.VoltarMenu.Text = "MENU";
            this.VoltarMenu.UseVisualStyleBackColor = true;
            this.VoltarMenu.Click += new System.EventHandler(this.VoltarMenu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(444, 660);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 23);
            this.label10.TabIndex = 58;
            this.label10.Text = "COD_CLIENTE";
            // 
            // txtCodClienteParaAtualizar
            // 
            this.txtCodClienteParaAtualizar.Location = new System.Drawing.Point(630, 660);
            this.txtCodClienteParaAtualizar.Name = "txtCodClienteParaAtualizar";
            this.txtCodClienteParaAtualizar.Size = new System.Drawing.Size(313, 27);
            this.txtCodClienteParaAtualizar.TabIndex = 57;
            // 
            // txtcodClienteDeleteAvaliacao
            // 
            this.txtcodClienteDeleteAvaliacao.Location = new System.Drawing.Point(526, 543);
            this.txtcodClienteDeleteAvaliacao.Name = "txtcodClienteDeleteAvaliacao";
            this.txtcodClienteDeleteAvaliacao.Size = new System.Drawing.Size(313, 27);
            this.txtcodClienteDeleteAvaliacao.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(360, 543);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 23);
            this.label11.TabIndex = 60;
            this.label11.Text = "COD_CLIENTE";
            // 
            // Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 977);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcodClienteDeleteAvaliacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodClienteParaAtualizar);
            this.Controls.Add(this.VoltarMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescricaoAtualizar);
            this.Controls.Add(this.txtNotaAtualizar);
            this.Controls.Add(this.txtCodProdutoParaAtualizar);
            this.Controls.Add(this.txtcodProdutoDeleteAvaliacao);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.EnviarAvaliacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtcod_cliente);
            this.Controls.Add(this.txtcodProduto);
            this.Controls.Add(this.visualizarAvaliacoes);
            this.Controls.Add(this.exibirAvaliacao);
            this.MaximumSize = new System.Drawing.Size(1024, 1024);
            this.MinimumSize = new System.Drawing.Size(1024, 1024);
            this.Name = "Avaliacao";
            this.Text = "Avaliacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button visualizarAvaliacoes;
        private TextBox exibirAvaliacao;
        private TextBox txtNota;
        private TextBox txtcod_cliente;
        private TextBox txtcodProduto;
        private TextBox txtDescricao;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button EnviarAvaliacao;
        private Button btnDelete;
        private TextBox txtcodProdutoDeleteAvaliacao;
        private Button btnAtualizar;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDescricaoAtualizar;
        private TextBox txtNotaAtualizar;
        private TextBox txtCodProdutoParaAtualizar;
        private Label label4;
        private Button VoltarMenu;
        private Label label10;
        private TextBox txtCodClienteParaAtualizar;
        private TextBox txtcodClienteDeleteAvaliacao;
        private Label label11;
    }
}