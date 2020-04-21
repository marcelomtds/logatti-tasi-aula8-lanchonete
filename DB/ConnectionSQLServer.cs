using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Model;

namespace DB
{
    public class ConnectionSQLServer : IDisposable
    {
        private SqlConnection conexao;

        private StringBuilder sb;

        public ConnectionSQLServer()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoSQLServer"].ConnectionString);
            conexao.Open();
        }

        public void Inserir(Lanchonete lanchonete)
        {
            sb = new StringBuilder();
            sb.Append("INSERT INTO LANCHONETE (descricao, quantidade_clientes, numero_empregados, total_receita, total_despesa) VALUES ");
            sb.Append(string.Format("('{0}', '{1}', '{2}', '{3}', '{4}')", lanchonete.Descricao, lanchonete.QuantidadeClientes, lanchonete.NumeroEmpregados, lanchonete.TotalReceita, lanchonete.TotalDespesa));
            using (var conexao = new ConnectionSQLServer())
            {
                conexao.ExecutaComando(sb.ToString());
            }
        }

        public List<Lanchonete> ListarTodas()
        {
            using (var conexao = new ConnectionSQLServer())
            {
                var sql = "SELECT id, descricao, quantidade_clientes, numero_empregados, total_receita, total_despesa FROM LANCHONETE";
                var retorno = conexao.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Lanchonete> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            List<Lanchonete> lanchonetes = new List<Lanchonete>();
            while (retorno.Read())
            {
                var lanchonete = new Lanchonete()
                {
                    Id = int.Parse(retorno["id"].ToString()),
                    Descricao = retorno["descricao"].ToString(),
                    QuantidadeClientes = int.Parse(retorno["quantidade_clientes"].ToString()),
                    NumeroEmpregados = int.Parse(retorno["numero_empregados"].ToString()),
                    TotalReceita = double.Parse(retorno["total_receita"].ToString()),
                    TotalDespesa = double.Parse(retorno["total_despesa"].ToString()),
                };
                lanchonetes.Add(lanchonete);
            }
            return lanchonetes;
        }

        public void ExecutaComando(string query)
        {
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoRetorno(string query)
        {
            var cmd = new SqlCommand(query, conexao);
            return cmd.ExecuteReader();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
