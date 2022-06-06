namespace ProjetoBanco.View
{
    partial class frmLogin
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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(13, 59);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(203, 23);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(42, 189);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(141, 42);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(13, 140);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(203, 23);
            this.textBoxSenha.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(58, 19);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(116, 37);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(67, 100);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(94, 37);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumOrchid;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(42, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(227, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxUsuario;
        private Button buttonLogin;
        private TextBox textBoxSenha;
        private Label labelUsuario;
        private Label labelSenha;
        private Button button1;
    }
}