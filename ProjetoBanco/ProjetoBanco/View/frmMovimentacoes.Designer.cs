namespace ProjetoBanco.View
{
    partial class frmMovimentacoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelMovimentacoes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovaMovimentacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMovimentacoes
            // 
            this.labelMovimentacoes.AutoSize = true;
            this.labelMovimentacoes.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMovimentacoes.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelMovimentacoes.Location = new System.Drawing.Point(167, 33);
            this.labelMovimentacoes.Name = "labelMovimentacoes";
            this.labelMovimentacoes.Size = new System.Drawing.Size(322, 54);
            this.labelMovimentacoes.TabIndex = 1;
            this.labelMovimentacoes.Text = "Movimentações";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Tipo,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(44, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(593, 303);
            this.dataGridView1.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 75;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 275;
            // 
            // btnNovaMovimentacao
            // 
            this.btnNovaMovimentacao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNovaMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovaMovimentacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovaMovimentacao.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnNovaMovimentacao.Location = new System.Drawing.Point(44, 438);
            this.btnNovaMovimentacao.Name = "btnNovaMovimentacao";
            this.btnNovaMovimentacao.Size = new System.Drawing.Size(593, 47);
            this.btnNovaMovimentacao.TabIndex = 5;
            this.btnNovaMovimentacao.Text = "Nova movimentação";
            this.btnNovaMovimentacao.UseVisualStyleBackColor = false;
            this.btnNovaMovimentacao.Click += new System.EventHandler(this.btnNovaMovimentacao_Click);
            // 
            // frmMovimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(659, 522);
            this.Controls.Add(this.btnNovaMovimentacao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelMovimentacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovimentacoes";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMovimentacoes;
        private DataGridView dataGridView1;
        private Button btnNovaMovimentacao;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Valor;
    }
}