namespace ProjetoBanco.View
{
    partial class frmInvesimentos
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
            this.labelInvestimentos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorInvestido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoInvestimento = new System.Windows.Forms.Button();
            this.btnExcluirInvestimento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInvestimentos
            // 
            this.labelInvestimentos.AutoSize = true;
            this.labelInvestimentos.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInvestimentos.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelInvestimentos.Location = new System.Drawing.Point(185, 32);
            this.labelInvestimentos.Name = "labelInvestimentos";
            this.labelInvestimentos.Size = new System.Drawing.Size(290, 54);
            this.labelInvestimentos.TabIndex = 1;
            this.labelInvestimentos.Text = "Investimentos";
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
            this.ValorInvestido});
            this.dataGridView1.Location = new System.Drawing.Point(44, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(594, 303);
            this.dataGridView1.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 200;
            // 
            // ValorInvestido
            // 
            this.ValorInvestido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValorInvestido.DataPropertyName = "valorinvestido";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.ValorInvestido.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorInvestido.HeaderText = "Valor investido";
            this.ValorInvestido.Name = "ValorInvestido";
            this.ValorInvestido.ReadOnly = true;
            this.ValorInvestido.Width = 350;
            // 
            // btnNovoInvestimento
            // 
            this.btnNovoInvestimento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNovoInvestimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoInvestimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoInvestimento.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnNovoInvestimento.Location = new System.Drawing.Point(44, 442);
            this.btnNovoInvestimento.Name = "btnNovoInvestimento";
            this.btnNovoInvestimento.Size = new System.Drawing.Size(287, 47);
            this.btnNovoInvestimento.TabIndex = 5;
            this.btnNovoInvestimento.Text = "Novo";
            this.btnNovoInvestimento.UseVisualStyleBackColor = false;
            this.btnNovoInvestimento.Click += new System.EventHandler(this.btnNovoInvestimento_Click);
            // 
            // btnExcluirInvestimento
            // 
            this.btnExcluirInvestimento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExcluirInvestimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirInvestimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirInvestimento.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirInvestimento.Location = new System.Drawing.Point(353, 442);
            this.btnExcluirInvestimento.Name = "btnExcluirInvestimento";
            this.btnExcluirInvestimento.Size = new System.Drawing.Size(285, 47);
            this.btnExcluirInvestimento.TabIndex = 7;
            this.btnExcluirInvestimento.Text = "Excluir";
            this.btnExcluirInvestimento.UseVisualStyleBackColor = false;
            this.btnExcluirInvestimento.Click += new System.EventHandler(this.btnExcluirInvestimento_Click);
            // 
            // frmInvesimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(659, 522);
            this.Controls.Add(this.btnExcluirInvestimento);
            this.Controls.Add(this.btnNovoInvestimento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelInvestimentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInvesimentos";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInvestimentos;
        private DataGridView dataGridView1;
        private Button btnNovoInvestimento;
        private Button btnExcluirInvestimento;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn ValorInvestido;
    }
}