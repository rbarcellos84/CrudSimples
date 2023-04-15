using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Configurations;
using Crud.Entities;
using Dapper;

namespace Crud.Repository
{
    public class ProdutoRepository
    {
        public void Create(Produto produto)
        {
            string Sql = @"Insert into produto (Nome, Preco, Quantidade, DataCadastro) 
                                        values (@Nome, @Preco, @Quantidade, @DataCadastro)";
            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfigurations.GetConnectionString()))
            {
                //executa comando no sql
                connection.Execute(Sql,produto);
            }
        }
        public void Update(Produto produto)
        {
            string Sql = @"Update produto set
                                     Nome = @Nome, 
                                    Preco = @Preco, 
                               Quantidade = @Quantidade 
                          where IdProduto = @IdProduto";

            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfigurations.GetConnectionString()))
            {
                //executa comando no sql
                connection.Execute(Sql, produto);
            }
        }
        public void Delete(Produto produto)
        {
            string Sql = @"delete from produto where IdProduto = @IdProduto";

            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfigurations.GetConnectionString()))
            {
                //executa comando no sql
                connection.Execute(Sql, produto);
            }
        }
        public Produto GetById(int idProduto)
        {
            string Sql = @"select IdProduto, Nome, Preco, Quantidade, DataCadastro from produto where IdProduto = @idProduto";

            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfigurations.GetConnectionString()))
            {
                //executa comando no sql
                return connection.Query<Produto>(Sql,new {idProduto}).FirstOrDefault();
            }
        }
        public List<Produto> GetAll()
        {
            string Sql = @"select IdProduto, Nome, Preco, Quantidade, DataCadastro from produto order by Nome";

            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfigurations.GetConnectionString()))
            {
                //executa comando no sql
                return connection.Query<Produto>(Sql).ToList();
            }
        }
    }
}
