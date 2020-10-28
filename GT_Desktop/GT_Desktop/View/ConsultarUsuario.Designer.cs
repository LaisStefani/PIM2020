namespace GT_Desktop
{
    partial class ConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gbox_ConsultaUsuario = new Guna.UI.WinForms.GunaGroupBox();
            this.Btn_PesquisarUsuario = new Guna.UI.WinForms.GunaButton();
            this.DataGridUsuarios = new Guna.UI.WinForms.GunaDataGridView();
            this.Cb_ConsultaUsuario = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.Gbox_ConsultaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbox_ConsultaUsuario
            // 
            this.Gbox_ConsultaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Gbox_ConsultaUsuario.BaseColor = System.Drawing.Color.White;
            this.Gbox_ConsultaUsuario.BorderColor = System.Drawing.Color.Gainsboro;
            this.Gbox_ConsultaUsuario.Controls.Add(this.Btn_PesquisarUsuario);
            this.Gbox_ConsultaUsuario.Controls.Add(this.DataGridUsuarios);
            this.Gbox_ConsultaUsuario.Controls.Add(this.Cb_ConsultaUsuario);
            this.Gbox_ConsultaUsuario.Controls.Add(this.gunaLabel1);
            this.Gbox_ConsultaUsuario.LineColor = System.Drawing.Color.Gainsboro;
            this.Gbox_ConsultaUsuario.Location = new System.Drawing.Point(12, 12);
            this.Gbox_ConsultaUsuario.Name = "Gbox_ConsultaUsuario";
            this.Gbox_ConsultaUsuario.Size = new System.Drawing.Size(695, 346);
            this.Gbox_ConsultaUsuario.TabIndex = 1;
            this.Gbox_ConsultaUsuario.Text = "Consultar Usuário";
            this.Gbox_ConsultaUsuario.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // Btn_PesquisarUsuario
            // 
            this.Btn_PesquisarUsuario.AnimationHoverSpeed = 0.07F;
            this.Btn_PesquisarUsuario.AnimationSpeed = 0.03F;
            this.Btn_PesquisarUsuario.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Btn_PesquisarUsuario.BorderColor = System.Drawing.Color.Black;
            this.Btn_PesquisarUsuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_PesquisarUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_PesquisarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_PesquisarUsuario.ForeColor = System.Drawing.Color.White;
            this.Btn_PesquisarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PesquisarUsuario.Image")));
            this.Btn_PesquisarUsuario.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_PesquisarUsuario.Location = new System.Drawing.Point(297, 67);
            this.Btn_PesquisarUsuario.Name = "Btn_PesquisarUsuario";
            this.Btn_PesquisarUsuario.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Btn_PesquisarUsuario.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_PesquisarUsuario.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_PesquisarUsuario.OnHoverImage = null;
            this.Btn_PesquisarUsuario.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_PesquisarUsuario.Size = new System.Drawing.Size(110, 26);
            this.Btn_PesquisarUsuario.TabIndex = 3;
            this.Btn_PesquisarUsuario.Text = "Pesquisar";
            // 
            // DataGridUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DataGridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridUsuarios.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridUsuarios.EnableHeadersVisualStyles = false;
            this.DataGridUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridUsuarios.Location = new System.Drawing.Point(46, 141);
            this.DataGridUsuarios.Name = "DataGridUsuarios";
            this.DataGridUsuarios.RowHeadersVisible = false;
            this.DataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridUsuarios.Size = new System.Drawing.Size(568, 150);
            this.DataGridUsuarios.TabIndex = 2;
            this.DataGridUsuarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridUsuarios.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridUsuarios.ThemeStyle.ReadOnly = false;
            this.DataGridUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Cb_ConsultaUsuario
            // 
            this.Cb_ConsultaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Cb_ConsultaUsuario.BaseColor = System.Drawing.Color.White;
            this.Cb_ConsultaUsuario.BorderColor = System.Drawing.Color.Silver;
            this.Cb_ConsultaUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_ConsultaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_ConsultaUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.Cb_ConsultaUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cb_ConsultaUsuario.ForeColor = System.Drawing.Color.Black;
            this.Cb_ConsultaUsuario.FormattingEnabled = true;
            this.Cb_ConsultaUsuario.Items.AddRange(new object[] {
            "Nome",
            "Login",
            "Ativo",
            "Inativo"});
            this.Cb_ConsultaUsuario.Location = new System.Drawing.Point(100, 67);
            this.Cb_ConsultaUsuario.Name = "Cb_ConsultaUsuario";
            this.Cb_ConsultaUsuario.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Cb_ConsultaUsuario.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Cb_ConsultaUsuario.Size = new System.Drawing.Size(110, 26);
            this.Cb_ConsultaUsuario.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(13, 72);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Pesquisar por:";
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 372);
            this.Controls.Add(this.Gbox_ConsultaUsuario);
            this.Name = "ConsultarUsuario";
            this.Text = "ConsultarUsuario";
            this.Gbox_ConsultaUsuario.ResumeLayout(false);
            this.Gbox_ConsultaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox Gbox_ConsultaUsuario;
        private Guna.UI.WinForms.GunaButton Btn_PesquisarUsuario;
        private Guna.UI.WinForms.GunaDataGridView DataGridUsuarios;
        private Guna.UI.WinForms.GunaComboBox Cb_ConsultaUsuario;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}