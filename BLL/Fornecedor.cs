using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Fornecedor
    {
        public int Id { get; set; }

        public string Razao { get; set; }

        public string Cnpj { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        Conexao con;

        public bool Gravar()
        {
            con = new Conexao();//instanciação do objeto con
            string sql = $"insert into tb_fornecedor values (null, " +
                $"'{Razao}', '{Cnpj}', '{Telefone}', '{Email}')";

            return con.Executa(sql); //executa esse string sql e retorna true ou false
        }

        public bool Atualizar()
        {
            con = new Conexao();//instanciação do objeto con
            string sql = $"update tb_fornecedor set forn_razao='{Razao}'," +
                $"forn_cnpj='{Cnpj}', forn_telefone='{Telefone}', " +
                $"forn_email='{Email}' where forn_id={Id}";
            return con.Executa(sql);//executa esse string sql e retorna true ou false

        }

        public bool Excluir()
        {
            con = new Conexao(); //instanciação do objeto con
            string sql = $"delete from tb_fornecedor where forn_id={Id}";
            return con.Executa(sql);//executa esse string sql e retorna true ou false

        }

        public DataTable Pesquisar()
        {
            try
            {

                con = new Conexao();//instanciação do objeto con
                string sql = $"select * from tb_fornecedor";
                DataTable dt = new DataTable();
                dt = con.Retorna(sql);
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }


        }
        public DataTable PesquisarId()
        {
            try
            {

                con = new Conexao();//instanciação do objeto con
                string sql = $"select * from tb_fornecedor where forn_id={Id}";
                DataTable dt = new DataTable();
                dt = con.Retorna(sql);
                return dt;
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

    }
}
