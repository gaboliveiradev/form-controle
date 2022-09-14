using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControle.View.Modules.Principal
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
            dgv_produto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            dgv_produto.RowCount = 0;

            ofd_arquivo.FileName = "";
            ofd_arquivo.ShowDialog();
            StreamReader arq = File.OpenText(ofd_arquivo.FileName);
            string linha;

            while((linha = arq.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string ean = dados[0];
                string nome = dados[1];
                string valor_compra = dados[2];
                string valor_venda = dados[3];
                string estoque = dados[4];

                dgv_produto.Rows.Add(false, ean, nome, valor_compra, valor_venda, estoque);
            }
        }

        private void btn_marcar_desmarcar_Click(object sender, EventArgs e)
        {
            if(btn_marcar_desmarcar.Text == "Marcar Todos")
            {
                foreach(DataGridViewRow l in dgv_produto.Rows)
                    l.Cells[0].Value = true;

                btn_marcar_desmarcar.Text = "Desmarcar Todos";
            } else
            {
                foreach (DataGridViewRow l in dgv_produto.Rows)
                    l.Cells[0].Value = false;

                btn_marcar_desmarcar.Text = "Marcar Todos";
            }
        }

        private void dgv_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_produto.CurrentRow.Cells[0].Value = (Convert.ToBoolean(dgv_produto.CurrentRow.Cells[0].Value) == false) ? true : false;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            for (int i = dgv_produto.RowCount - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dgv_produto.CurrentRow.Cells[0].Value) == true)
                {
                    dgv_produto.Rows.Remove(dgv_produto.Rows[i]);
                }
            }
        }

        private void btn_aplicar_percentual_Click(object sender, EventArgs e)
        {
            if(Convert.ToBoolean(dgv_produto.CurrentRow.Cells[0].Value) == true) {
                double percentual = Convert.ToDouble(dgv_produto.CurrentRow.Cells[4].Value) * double.Parse(txt_percentual.Text.ToString());
                double valor_atual = double.Parse(dgv_produto.CurrentRow.Cells[4].Value.ToString());
                double valor_final = valor_atual + percentual;

                Console.WriteLine($"Percentual: {percentual} | Valor Atual: {valor_atual} | Valor Final: {valor_final}");

                dgv_produto.CurrentRow.Cells[4].Value = valor_final.ToString();
            }
        }
    }
}
