using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace GT_Desktop.Banco_Dados
{
    class DataBase
    {
        //Mudar e colocar no app.config
        public SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
    }

    class ConsultaSQL
    {
        public DataTable ConsultaDT(string SQL)
        {
            #region Conectar a classe de BD
            DataBase DB = new DataBase();
            #endregion

            #region Testar e abrir conexão com banco
            try
            {
                DB.Con.Open();
            }
            catch (SqlException Sqle)
            {
                MessageBox.Show("Falha ao tentar conexão. Erro: " + Sqle);
            }
            #endregion

            #region Executar consulta no banco de dados
            SqlDataAdapter Sda = new SqlDataAdapter(SQL, DB.Con);
            DataTable Dtb = new DataTable();
            Sda.Fill(Dtb);
            return Dtb;
            #endregion
        }

        public bool Consulta = false;


        public void ExecutaComandoSQL(string SQL)
        {

            #region Conectar a classe de BD
            DataBase DB = new DataBase();
            #endregion

            #region Testar e abrir conexão com banco
            try
            {
                DB.Con.Open();
            }
            catch (SqlException Sqle)
            {
                MessageBox.Show("Falha ao tentar conexão. Erro: " + Sqle);
            }
            #endregion

            #region Executar consulta no banco de dados
            SqlCommand Cmd = new SqlCommand(SQL, DB.Con);

            try
            {
                SqlDataReader Sdr = Cmd.ExecuteReader();
                if (Sdr.HasRows)
                {
                    Consulta = true;
                }
            }
            catch (SqlException Sqle)
            {
                MessageBox.Show("Falha ao tentar conexão ou executar a consulta. Erro: " + Sqle);
            }
            finally
            {
                DB.Con.Close();
            }
            #endregion
        }
    }
}