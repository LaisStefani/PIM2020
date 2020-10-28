using GT_Desktop.Banco_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_Desktop
{
    public partial class Form1 : Form
    {
        DataBase DB = new DataBase();
        ConsultaSQL CST = new ConsultaSQL();

        string SQLString = "";

        private Principal frm1;
        public Form1()
        {
            InitializeComponent();

        }

        public void Autenticacao()
        {
            SQLString = string.Format(@"SELECT 
                                           [ID_USUARIO]
                                          ,[NOME]
                                          ,[LOGIN]
                                          ,[SENHA]
                                          ,[ID_CARGO]
                                          ,[ATIVO]
                                          ,[CodPerfil]
                                      FROM [dbo].[USUARIO]
                                      WHERE 
                                        ATIVO = 1
                                        AND Login = '{0}'
                                        AND Senha = '{1}'"
                                    , txtLogin.Text.Replace("'", "")
                                    , txtSenha.Text.Replace("'", ""));

            DataTable DTB = CST.ConsultaDT(SQL: SQLString);

            if (DTB.Rows.Count > 0)
            {
                #region Abrir formulário principal
                long CodUsuario = Convert.ToInt32(DTB.Rows[0]["ID_USUARIO"].ToString());
                int CodPerfil = Convert.ToInt32(DTB.Rows[0]["CodPerfil"].ToString());

                Hide();

                frm1 = new Principal(CodUsuario, CodPerfil);

                frm1.ShowDialog();
                #endregion
            }
            else
            {
                MessageBox.Show("Erro na consulta do usuário e senha, por favor, verifique e tente novamente.", "Erro, tentativa de login!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
                MessageBox.Show("Digite um usuário", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else if (txtSenha.Text == "")
                MessageBox.Show("Digite sua senha", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {

                Autenticacao();
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

    }
}
