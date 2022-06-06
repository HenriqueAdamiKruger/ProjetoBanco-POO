namespace ProjetoBanco.View
{
    partial class frmNovaMovimentacao
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
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelTipoMovimentacao = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonGravar
            // 
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGravar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGravar.ForeColor = System.Drawing.Color.DarkViolet;
            this.buttonGravar.Location = new System.Drawing.Point(12, 126);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(85, 32);
            this.buttonGravar.TabIndex = 4;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.ForeColor = System.Drawing.Color.DarkViolet;
            this.buttonCancelar.Location = new System.Drawing.Point(145, 126);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(85, 32);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSenha.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelSenha.Location = new System.Drawing.Point(94, 59);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(50, 21);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(12, 83);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(218, 23);
            this.textBoxValor.TabIndex = 3;
            // 
            // labelTipoMovimentacao
            // 
            this.labelTipoMovimentacao.AutoSize = true;
            this.labelTipoMovimentacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipoMovimentacao.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelTipoMovimentacao.Location = new System.Drawing.Point(32, 9);
            this.labelTipoMovimentacao.Name = "labelTipoMovimentacao";
            this.labelTipoMovimentacao.Size = new System.Drawing.Size(186, 21);
            this.labelTipoMovimentacao.TabIndex = 6;
            this.labelTipoMovimentacao.Text = "Tipo de movimentacao";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // frmNovaMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 177);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTipoMovimentacao);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmNovaMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova movimentação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonGravar;
        private Button buttonCancelar;
        private Label labelSenha;
        private TextBox textBoxValor;
        private Label labelTipoMovimentacao;
        private ComboBox comboBox1;
    }
}