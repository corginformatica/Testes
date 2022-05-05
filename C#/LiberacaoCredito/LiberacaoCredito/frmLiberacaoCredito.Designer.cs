
namespace LiberacaoCredito
{
    partial class frmLiberacaoCredito
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
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cmbTipoCredito = new System.Windows.Forms.ComboBox();
            this.dtDataPrimeiroVencimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.lblResultadoValorJuros = new System.Windows.Forms.Label();
            this.lblResultadoValorTotalComJuros = new System.Windows.Forms.Label();
            this.lblResultadoStatusCredito = new System.Windows.Forms.Label();
            this.lblValorJuros = new System.Windows.Forms.Label();
            this.lblValorTotalComJuros = new System.Windows.Forms.Label();
            this.lblStatusCredito = new System.Windows.Forms.Label();
            this.txtQuantidadeParcela = new System.Windows.Forms.TextBox();
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            this.pnlDados.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtValorCredito);
            this.pnlDados.Controls.Add(this.txtQuantidadeParcela);
            this.pnlDados.Controls.Add(this.lblMsg);
            this.pnlDados.Controls.Add(this.cmbTipoCredito);
            this.pnlDados.Controls.Add(this.dtDataPrimeiroVencimento);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Location = new System.Drawing.Point(29, 42);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(499, 148);
            this.pnlDados.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(23, 122);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(58, 13);
            this.lblMsg.TabIndex = 11;
            this.lblMsg.Text = "Atenção:";
            // 
            // cmbTipoCredito
            // 
            this.cmbTipoCredito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoCredito.FormattingEnabled = true;
            this.cmbTipoCredito.Location = new System.Drawing.Point(179, 36);
            this.cmbTipoCredito.Name = "cmbTipoCredito";
            this.cmbTipoCredito.Size = new System.Drawing.Size(300, 21);
            this.cmbTipoCredito.TabIndex = 10;
            // 
            // dtDataPrimeiroVencimento
            // 
            this.dtDataPrimeiroVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPrimeiroVencimento.Location = new System.Drawing.Point(179, 90);
            this.dtDataPrimeiroVencimento.Name = "dtDataPrimeiroVencimento";
            this.dtDataPrimeiroVencimento.Size = new System.Drawing.Size(120, 20);
            this.dtDataPrimeiroVencimento.TabIndex = 7;
            this.dtDataPrimeiroVencimento.ValueChanged += new System.EventHandler(this.dtDataPrimeiroVencimento_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data do primeiro vencimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de parcelas mensais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de crédito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do crédito:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(194, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(292, 196);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 2;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // pnlResultados
            // 
            this.pnlResultados.Controls.Add(this.lblResultadoValorJuros);
            this.pnlResultados.Controls.Add(this.lblResultadoValorTotalComJuros);
            this.pnlResultados.Controls.Add(this.lblResultadoStatusCredito);
            this.pnlResultados.Controls.Add(this.lblValorJuros);
            this.pnlResultados.Controls.Add(this.lblValorTotalComJuros);
            this.pnlResultados.Controls.Add(this.lblStatusCredito);
            this.pnlResultados.Location = new System.Drawing.Point(29, 235);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(499, 100);
            this.pnlResultados.TabIndex = 3;
            // 
            // lblResultadoValorJuros
            // 
            this.lblResultadoValorJuros.AutoSize = true;
            this.lblResultadoValorJuros.Location = new System.Drawing.Point(135, 77);
            this.lblResultadoValorJuros.Name = "lblResultadoValorJuros";
            this.lblResultadoValorJuros.Size = new System.Drawing.Size(114, 13);
            this.lblResultadoValorJuros.TabIndex = 5;
            this.lblResultadoValorJuros.Text = "lblResultadoValorJuros";
            // 
            // lblResultadoValorTotalComJuros
            // 
            this.lblResultadoValorTotalComJuros.AutoSize = true;
            this.lblResultadoValorTotalComJuros.Location = new System.Drawing.Point(135, 49);
            this.lblResultadoValorTotalComJuros.Name = "lblResultadoValorTotalComJuros";
            this.lblResultadoValorTotalComJuros.Size = new System.Drawing.Size(159, 13);
            this.lblResultadoValorTotalComJuros.TabIndex = 4;
            this.lblResultadoValorTotalComJuros.Text = "lblResultadoValorTotalComJuros";
            // 
            // lblResultadoStatusCredito
            // 
            this.lblResultadoStatusCredito.AutoSize = true;
            this.lblResultadoStatusCredito.Location = new System.Drawing.Point(135, 21);
            this.lblResultadoStatusCredito.Name = "lblResultadoStatusCredito";
            this.lblResultadoStatusCredito.Size = new System.Drawing.Size(128, 13);
            this.lblResultadoStatusCredito.TabIndex = 3;
            this.lblResultadoStatusCredito.Text = "lblResultadoStatusCredito";
            // 
            // lblValorJuros
            // 
            this.lblValorJuros.AutoSize = true;
            this.lblValorJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorJuros.Location = new System.Drawing.Point(3, 77);
            this.lblValorJuros.Name = "lblValorJuros";
            this.lblValorJuros.Size = new System.Drawing.Size(89, 13);
            this.lblValorJuros.TabIndex = 2;
            this.lblValorJuros.Text = "Valor do juros:";
            // 
            // lblValorTotalComJuros
            // 
            this.lblValorTotalComJuros.AutoSize = true;
            this.lblValorTotalComJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalComJuros.Location = new System.Drawing.Point(3, 49);
            this.lblValorTotalComJuros.Name = "lblValorTotalComJuros";
            this.lblValorTotalComJuros.Size = new System.Drawing.Size(127, 13);
            this.lblValorTotalComJuros.TabIndex = 1;
            this.lblValorTotalComJuros.Text = "Valor total com juros:";
            // 
            // lblStatusCredito
            // 
            this.lblStatusCredito.AutoSize = true;
            this.lblStatusCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCredito.Location = new System.Drawing.Point(3, 21);
            this.lblStatusCredito.Name = "lblStatusCredito";
            this.lblStatusCredito.Size = new System.Drawing.Size(108, 13);
            this.lblStatusCredito.TabIndex = 0;
            this.lblStatusCredito.Text = "Status do crédito:";
            // 
            // txtQuantidadeParcela
            // 
            this.txtQuantidadeParcela.Location = new System.Drawing.Point(179, 62);
            this.txtQuantidadeParcela.MaxLength = 2;
            this.txtQuantidadeParcela.Name = "txtQuantidadeParcela";
            this.txtQuantidadeParcela.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantidadeParcela.Size = new System.Drawing.Size(24, 20);
            this.txtQuantidadeParcela.TabIndex = 12;
            this.txtQuantidadeParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeParcela_KeyPress);
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(179, 12);
            this.txtValorCredito.MaxLength = 10;
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorCredito.Size = new System.Drawing.Size(100, 20);
            this.txtValorCredito.TabIndex = 13;
            this.txtValorCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCredito_KeyPress);
            // 
            // frmLiberacaoCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 373);
            this.Controls.Add(this.pnlResultados);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnlDados);
            this.Name = "frmLiberacaoCredito";
            this.Text = "Liberação de Crédito";
            this.Load += new System.EventHandler(this.frmLiberacaoCredito_Load);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnlResultados.ResumeLayout(false);
            this.pnlResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.DateTimePicker dtDataPrimeiroVencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Label lblResultadoValorJuros;
        private System.Windows.Forms.Label lblResultadoValorTotalComJuros;
        private System.Windows.Forms.Label lblResultadoStatusCredito;
        private System.Windows.Forms.Label lblValorJuros;
        private System.Windows.Forms.Label lblValorTotalComJuros;
        private System.Windows.Forms.Label lblStatusCredito;
        private System.Windows.Forms.ComboBox cmbTipoCredito;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtValorCredito;
        private System.Windows.Forms.TextBox txtQuantidadeParcela;
    }
}

