using MySql.Data.MySqlClient; //isso foi oque precisou baixar o nuget 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexao
    {


        static private string servidor = "localhost"; 

        static private string banco = "bd_teste";

        static private string usuario = "root";

        static private string senha = "cursoads";

        static public string strConn = $"server={servidor};" +
            $"database={banco}; User Id = {usuario}; " +
            $"password={senha}"; //aqui é a string de conexão strConn

        MySqlConnection cn; //o cn é o obj da classe do MySqlConnection

        private bool Conectar()
        {
            bool result;
            try
            {
                cn = new MySqlConnection(strConn);
                cn.Open();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        private void Desconectar()  
        {
            if (cn.State == System.Data.ConnectionState.Open) 
            {
                cn.Close();
            }
        }
        public bool Executa(String sql)
        {
            bool resultado;
            Conectar();
            
                try
                {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.ExecuteNonQuery(); //faz o insert, update, delete 
                    resultado = true;
                }
                catch
                {
                    resultado = false;
                }
                 finally //é executado nas duas condições para no final desconectar
                {
                    Desconectar();
                }
            
            return resultado;
        }

        public DataTable Retorna(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd; //aqui já executa no banco
                DataTable data = new DataTable();
                da.Fill(data);//pega a tabela de resultado e carrega em data
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Desconectar();
            }
        }
    }  
}
