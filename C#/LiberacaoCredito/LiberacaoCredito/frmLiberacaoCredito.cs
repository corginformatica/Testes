using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberacaoCredito
{
    public partial class frmLiberacaoCredito : Form
    {
        DataTable dt_TipoCredito;
        string msg = "";

        private void frmLiberacaoCredito_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            CarregaTipoCredito();

            dtDataPrimeiroVencimento.MinDate = DateTime.Today.AddDays(15);
            dtDataPrimeiroVencimento.MaxDate = DateTime.Today.AddDays(40);
        }
        public frmLiberacaoCredito()
        {
            InitializeComponent();
            pnlResultados.Enabled = false;
            pnlResultados.Visible = false; 
        }

        private void CarregaTipoCredito()
        {
            dt_TipoCredito = new DataTable();
            dt_TipoCredito.Columns.Add("Id", typeof(int));
            dt_TipoCredito.Columns.Add("Nome", typeof(string));
            dt_TipoCredito.Columns.Add("Taxa", typeof(float));
            dt_TipoCredito.Columns.Add("Periodo", typeof(string));
            dt_TipoCredito.Columns.Add("TipoPessoa", typeof(string));

            dt_TipoCredito.Rows.Add(0, "- Selecione -", 0, "","");
            dt_TipoCredito.Rows.Add(1, "Crédito Direto - Taxa de 2 % ao mês", 2, "mes", "PF");
            dt_TipoCredito.Rows.Add(2, "Crédito Consignado - Taxa de 1 % ao mês", 1, "mes", "PF");
            dt_TipoCredito.Rows.Add(3, "Crédito Pessoa Jurídica - Taxa de 5% ao mês", 5, "mes", "PJ");
            dt_TipoCredito.Rows.Add(4, "Crédito Pessoa Física - Taxa de 3% ao mês", 3, "mes", "PF");
            dt_TipoCredito.Rows.Add(5, "Crédito Imobiliário - Taxa de 9% ao ano", 9, "ano", "PF");

            DataTable tabela = dt_TipoCredito;

            cmbTipoCredito.DataSource = tabela;
            cmbTipoCredito.DisplayMember = "Nome";
            cmbTipoCredito.ValueMember = "Id";

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            int Id = 0;
            string Nome = "";
            float Taxa = 0;
            string Periodo = "";
            string TipoPessoa = "";

            if(txtValorCredito.Text == "") 
            {
                lblMsg.Text = "Atenção: Informe o valor do crédito!";
                txtValorCredito.Focus();
                return;
            }

            if (float.Parse(txtValorCredito.Text) > 1000000) 
            {
                msg += "O valor máximo permitido para qualquer tipo de emprestimo excedeu R$ 1.000.000,00 \r\n";
            }
            
            float Valor = float.Parse(txtValorCredito.Text);

            int id_tipoCredito = int.Parse(cmbTipoCredito.SelectedValue.ToString());
            if (id_tipoCredito == 0) 
            {
                lblMsg.Text = "Atenção: Informe o Tipo de Crédito !";
                cmbTipoCredito.Focus();
                return;
            }

            if (txtQuantidadeParcela.Text == "")
            {
                lblMsg.Text = "Atenção: Informe a quantidade das parcelas";
                txtQuantidadeParcela.Focus();
                return;
            }

            if (int.Parse(txtQuantidadeParcela.Text) < 5 || int.Parse(txtQuantidadeParcela.Text) > 72)
            {
                msg += "A quantidade de parcelas mínima é de 5x e a máximas é de 72x \r\n";
            }

            int Parcela = int.Parse(txtQuantidadeParcela.Text);

            DataRow[] oDataRow = dt_TipoCredito.Select("Id = " + id_tipoCredito);
            foreach (DataRow dr in oDataRow)
            {
                //usei 3 sintaxes diferentes para obter os valores
                Id = int.Parse(dr[0].ToString());
                Nome = dr[1].ToString();
                Taxa = float.Parse(dr[2].ToString());
                Periodo = dr[3].ToString();
                TipoPessoa = dr[4].ToString();
            }

            if (TipoPessoa == "PJ") 
            { 
               if (Valor < 15000)
               {
                    msg += "Atenção: O valor mínimo para crédito de pessoa jurídica é de R$ 15.000,00\r\n";
                }
            }

            if (msg == "")

            {

                if (Periodo == "ano")
                {
                    Taxa = Taxa / 12;
                }

                double c = Valor;
                double i = (1 + (Taxa / 100));
                double n = Parcela;
                double j = Math.Pow(i, n);
                double m = c * j;

                lblResultadoStatusCredito.Text = "Aprovado";
                lblResultadoValorTotalComJuros.Text = m.ToString("###,###,###.##");
                lblResultadoValorJuros.Text = (m - c).ToString("###,###,###.##");
            }
            else
            {
                lblResultadoStatusCredito.Text = "Recusado\r\n" + msg;
                lblResultadoValorTotalComJuros.Text = "";
                lblResultadoValorJuros.Text = "";
                msg = "";
            }

            pnlResultados.Enabled = true;
            pnlResultados.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorCredito.Text = "";
            cmbTipoCredito.SelectedIndex = 0;
            txtQuantidadeParcela.Text = "";

            pnlResultados.Enabled = false;
            pnlResultados.Visible = false;
        }

        private void txtValorCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) 
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidadeParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void dtDataPrimeiroVencimento_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
