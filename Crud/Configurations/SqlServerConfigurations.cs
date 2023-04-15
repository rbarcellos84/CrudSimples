using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Configurations
{
    public class SqlServerConfigurations
    {
        //biblioteca padrao para conexao com sqlserv
        //Gerenciar pacote de NuGet System.Data.SqlClient

        //biblioteca padrao para executar comando sql
        //Gerenciar pacote de NuGet Dapper(metodo que iremos utilizar) EntityFramework

        //metodo estatico para retornar string de conexao
        public static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Banco;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
