namespace ProjetoBanco.View
{
    partial class frmUsuarios
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
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuarios.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelUsuarios.Location = new System.Drawing.Point(233, 24);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(185, 54);
            this.labelUsuarios.TabIndex = 1;
            this.labelUsuarios.Text = "Usuários";
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
            this.login});
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
            this.codigo.Width = 150;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 400;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoUsuario.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnNovoUsuario.Location = new System.Drawing.Point(44, 442);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(187, 47);
            this.btnNovoUsuario.TabIndex = 5;
            this.btnNovoUsuario.Text = "Novo";
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAlterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarUsuario.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnAlterarUsuario.Location = new System.Drawing.Point(256, 442);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(187, 47);
            this.btnAlterarUsuario.TabIndex = 6;
            this.btnAlterarUsuario.Text = "Alterar";
            this.btnAlterarUsuario.UseVisualStyleBackColor = false;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(467, 442);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(171, 47);
            this.btnExcluirUsuario.TabIndex = 7;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(659, 522);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUsuarios;
        private DataGridView dataGridView1;
        private Button btnNovoUsuario;
        private Button btnAlterarUsuario;
        private Button btnExcluirUsuario;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn login;
    }
}