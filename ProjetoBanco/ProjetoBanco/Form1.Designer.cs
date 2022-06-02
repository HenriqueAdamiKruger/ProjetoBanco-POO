namespace ProjetoBanco
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInvestimentos = new System.Windows.Forms.Button();
            this.btnMovimentacoes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.BlueViolet;
            this.panelPrincipal.Controls.Add(this.btnSair);
            this.panelPrincipal.Controls.Add(this.btnInvestimentos);
            this.panelPrincipal.Controls.Add(this.btnMovimentacoes);
            this.panelPrincipal.Controls.Add(this.btnUsuarios);
            this.panelPrincipal.Controls.Add(this.btnHome);
            this.panelPrincipal.Controls.Add(this.panelLogo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(209, 561);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Indigo;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(12, 520);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(182, 29);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseCompatibleTextRendering = true;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInvestimentos
            // 
            this.btnInvestimentos.BackColor = System.Drawing.Color.Indigo;
            this.btnInvestimentos.FlatAppearance.BorderSize = 0;
            this.btnInvestimentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnInvestimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnInvestimentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvestimentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInvestimentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInvestimentos.Location = new System.Drawing.Point(12, 347);
            this.btnInvestimentos.Name = "btnInvestimentos";
            this.btnInvestimentos.Size = new System.Drawing.Size(182, 63);
            this.btnInvestimentos.TabIndex = 4;
            this.btnInvestimentos.Text = "Investimentos";
            this.btnInvestimentos.UseCompatibleTextRendering = true;
            this.btnInvestimentos.UseVisualStyleBackColor = false;
            this.btnInvestimentos.Click += new System.EventHandler(this.btnInvestimentos_Click);
            // 
            // btnMovimentacoes
            // 
            this.btnMovimentacoes.BackColor = System.Drawing.Color.Indigo;
            this.btnMovimentacoes.FlatAppearance.BorderSize = 0;
            this.btnMovimentacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnMovimentacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnMovimentacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovimentacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMovimentacoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovimentacoes.Location = new System.Drawing.Point(12, 278);
            this.btnMovimentacoes.Name = "btnMovimentacoes";
            this.btnMovimentacoes.Size = new System.Drawing.Size(182, 63);
            this.btnMovimentacoes.TabIndex = 3;
            this.btnMovimentacoes.Text = "Movimentações";
            this.btnMovimentacoes.UseCompatibleTextRendering = true;
            this.btnMovimentacoes.UseVisualStyleBackColor = false;
            this.btnMovimentacoes.Click += new System.EventHandler(this.btnMovimentacoes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Indigo;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 209);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(182, 63);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseCompatibleTextRendering = true;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Indigo;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(12, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 63);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseCompatibleTextRendering = true;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(209, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.labelSaldo);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.labelNomeUsuario);
            this.panelForm.Controls.Add(this.labelHome);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelForm.Location = new System.Drawing.Point(209, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(675, 561);
            this.panelForm.TabIndex = 1;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaldo.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelSaldo.Location = new System.Drawing.Point(234, 437);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(0, 81);
            this.labelSaldo.TabIndex = 3;
            this.labelSaldo.Leave += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(117, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seu saldo bancário é de:";
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeUsuario.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelNomeUsuario.Location = new System.Drawing.Point(206, 140);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(0, 106);
            this.labelNomeUsuario.TabIndex = 1;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHome.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelHome.Location = new System.Drawing.Point(38, 51);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(610, 81);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Bem vindo ao banco";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.panelPrincipal.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelPrincipal;
        private Button btnHome;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnInvestimentos;
        private Button btnMovimentacoes;
        private Button btnUsuarios;
        private Button btnSair;
        private Panel panelForm;
        private Label labelHome;
        private Label labelNomeUsuario;
        private Label label1;
        private Label labelSaldo;
    }
}