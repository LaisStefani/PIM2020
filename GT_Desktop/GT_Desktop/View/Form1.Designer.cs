namespace GT_Desktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblIdent = new System.Windows.Forms.Label();
            this.txtSenha = new Guna.UI.WinForms.GunaTextBox();
            this.GunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.btnLogin = new Guna.UI.WinForms.GunaGradientButton();
            this.txtLogin = new Guna.UI.WinForms.GunaTextBox();
            this.GunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaControlBox3);
            this.gunaPanel1.Controls.Add(this.gunaControlBox1);
            this.gunaPanel1.Controls.Add(this.lblBemVindo);
            this.gunaPanel1.Controls.Add(this.lblIdent);
            this.gunaPanel1.Controls.Add(this.txtSenha);
            this.gunaPanel1.Controls.Add(this.GunaLabel9);
            this.gunaPanel1.Controls.Add(this.btnLogin);
            this.gunaPanel1.Controls.Add(this.txtLogin);
            this.gunaPanel1.Controls.Add(this.GunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(800, 529);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 32);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(800, 497);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.Black;
            this.lblBemVindo.Location = new System.Drawing.Point(268, 75);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(265, 39);
            this.lblBemVindo.TabIndex = 134;
            this.lblBemVindo.Text = "Seja bem-vindo";
            // 
            // lblIdent
            // 
            this.lblIdent.BackColor = System.Drawing.Color.Transparent;
            this.lblIdent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdent.ForeColor = System.Drawing.Color.Black;
            this.lblIdent.Location = new System.Drawing.Point(316, 116);
            this.lblIdent.Name = "lblIdent";
            this.lblIdent.Size = new System.Drawing.Size(172, 41);
            this.lblIdent.TabIndex = 135;
            this.lblIdent.Text = "Identifique-se por favor.";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.BaseColor = System.Drawing.Color.Black;
            this.txtSenha.BorderColor = System.Drawing.Color.Black;
            this.txtSenha.BorderSize = 1;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(278, 261);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Radius = 2;
            this.txtSenha.Size = new System.Drawing.Size(248, 37);
            this.txtSenha.TabIndex = 130;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // GunaLabel9
            // 
            this.GunaLabel9.AutoSize = true;
            this.GunaLabel9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.GunaLabel9.Location = new System.Drawing.Point(274, 240);
            this.GunaLabel9.Name = "GunaLabel9";
            this.GunaLabel9.Size = new System.Drawing.Size(46, 19);
            this.GunaLabel9.TabIndex = 133;
            this.GunaLabel9.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor1 = System.Drawing.Color.Black;
            this.btnLogin.BaseColor2 = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(278, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor1 = System.Drawing.Color.Black;
            this.btnLogin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Radius = 2;
            this.btnLogin.Size = new System.Drawing.Size(248, 37);
            this.btnLogin.TabIndex = 131;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtLogin.BaseColor = System.Drawing.Color.Black;
            this.txtLogin.BorderColor = System.Drawing.Color.Black;
            this.txtLogin.BorderSize = 1;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(278, 192);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.Radius = 2;
            this.txtLogin.Size = new System.Drawing.Size(248, 37);
            this.txtLogin.TabIndex = 129;
            // 
            // GunaLabel6
            // 
            this.GunaLabel6.AutoSize = true;
            this.GunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.GunaLabel6.Location = new System.Drawing.Point(274, 171);
            this.GunaLabel6.Name = "GunaLabel6";
            this.GunaLabel6.Size = new System.Drawing.Size(43, 19);
            this.GunaLabel6.TabIndex = 132;
            this.GunaLabel6.Text = "Login";
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 50F;
            this.gunaControlBox3.Location = new System.Drawing.Point(692, 3);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.Black;
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.Thistle;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 137;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 50F;
            this.gunaControlBox1.Location = new System.Drawing.Point(743, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Black;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Thistle;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 136;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblIdent;
        internal Guna.UI.WinForms.GunaTextBox txtSenha;
        internal Guna.UI.WinForms.GunaLabel GunaLabel9;
        internal Guna.UI.WinForms.GunaGradientButton btnLogin;
        internal Guna.UI.WinForms.GunaTextBox txtLogin;
        internal Guna.UI.WinForms.GunaLabel GunaLabel6;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}

