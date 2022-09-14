namespace FormControle.View.Modules.Principal
{
    partial class frm_principal
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
            this.dgv_produto = new System.Windows.Forms.DataGridView();
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_marcar_desmarcar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_aplicar_percentual = new System.Windows.Forms.Button();
            this.ofd_arquivo = new System.Windows.Forms.OpenFileDialog();
            this.cln_checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clm_ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_valor_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_valor_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_percentual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_produto
            // 
            this.dgv_produto.AllowUserToAddRows = false;
            this.dgv_produto.AllowUserToOrderColumns = true;
            this.dgv_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_checkbox,
            this.clm_ean,
            this.cln_nome,
            this.cln_valor_compra,
            this.cln_valor_venda,
            this.cln_estoque});
            this.dgv_produto.Location = new System.Drawing.Point(12, 12);
            this.dgv_produto.Name = "dgv_produto";
            this.dgv_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produto.Size = new System.Drawing.Size(1056, 545);
            this.dgv_produto.TabIndex = 0;
            this.dgv_produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produto_CellClick);
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(12, 567);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(135, 36);
            this.btn_importar.TabIndex = 1;
            this.btn_importar.Text = "Importar Arquivo";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_marcar_desmarcar
            // 
            this.btn_marcar_desmarcar.Location = new System.Drawing.Point(153, 567);
            this.btn_marcar_desmarcar.Name = "btn_marcar_desmarcar";
            this.btn_marcar_desmarcar.Size = new System.Drawing.Size(135, 36);
            this.btn_marcar_desmarcar.TabIndex = 2;
            this.btn_marcar_desmarcar.Text = "Marcar Todos";
            this.btn_marcar_desmarcar.UseVisualStyleBackColor = true;
            this.btn_marcar_desmarcar.Click += new System.EventHandler(this.btn_marcar_desmarcar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(294, 567);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(135, 36);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_aplicar_percentual
            // 
            this.btn_aplicar_percentual.Location = new System.Drawing.Point(933, 567);
            this.btn_aplicar_percentual.Name = "btn_aplicar_percentual";
            this.btn_aplicar_percentual.Size = new System.Drawing.Size(135, 36);
            this.btn_aplicar_percentual.TabIndex = 5;
            this.btn_aplicar_percentual.Text = "Aplicar";
            this.btn_aplicar_percentual.UseVisualStyleBackColor = true;
            this.btn_aplicar_percentual.Click += new System.EventHandler(this.btn_aplicar_percentual_Click);
            // 
            // cln_checkbox
            // 
            this.cln_checkbox.HeaderText = "";
            this.cln_checkbox.Name = "cln_checkbox";
            // 
            // clm_ean
            // 
            this.clm_ean.HeaderText = "EAN";
            this.clm_ean.Name = "clm_ean";
            // 
            // cln_nome
            // 
            this.cln_nome.HeaderText = "NOME";
            this.cln_nome.Name = "cln_nome";
            // 
            // cln_valor_compra
            // 
            this.cln_valor_compra.HeaderText = "VALOR COMPRA";
            this.cln_valor_compra.Name = "cln_valor_compra";
            // 
            // cln_valor_venda
            // 
            this.cln_valor_venda.HeaderText = "VALOR_VENDA";
            this.cln_valor_venda.Name = "cln_valor_venda";
            // 
            // cln_estoque
            // 
            this.cln_estoque.HeaderText = "ESTOQUE";
            this.cln_estoque.Name = "cln_estoque";
            // 
            // txt_percentual
            // 
            this.txt_percentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_percentual.Location = new System.Drawing.Point(792, 568);
            this.txt_percentual.Name = "txt_percentual";
            this.txt_percentual.Size = new System.Drawing.Size(135, 33);
            this.txt_percentual.TabIndex = 6;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.txt_percentual);
            this.Controls.Add(this.btn_aplicar_percentual);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_marcar_desmarcar);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.dgv_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_produto;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_marcar_desmarcar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_aplicar_percentual;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cln_checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ean;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_valor_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_valor_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_estoque;
        private System.Windows.Forms.TextBox txt_percentual;
    }
}