using Crud.Entities;
using Crud.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Controllers
{
    public class ProdutoController
    {
        private void PrintProduct(Produto produto)
        {
            Console.WriteLine($"Codigo: {produto.IdProduto}, Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {produto.Quantidade}, Data do Cadastro: {produto.DataCadastro.ToString("dd/MM/yyyy HH:mm")}");
        }
        public void RegisterProduct()
        {
            try
            {
                Produto produto = new Produto();
                produto.DataCadastro = DateTime.Now;

                Console.WriteLine("\n *** Cadastro de Produto ***\n");

                Console.Write("Entre com o nome do produto........: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Entre com o preco do produto.......: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Entre com a quantidade do produto..: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                ProdutoRepository produtoRepository = new ProdutoRepository();
                produtoRepository.Create(produto);

                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao realizar o cadastro do produto: {e.Message}!");
            }
        }
        public void ModifyProduct()
        {
            try
            {
                int idProduto;

                Console.WriteLine("\n *** Modificar de Produto ***\n");
                Console.Write("Entre com o codigo do produto......: ");
                idProduto = int.Parse(Console.ReadLine());

                //listar produto
                Produto consulta = new Produto();
                ProdutoRepository produtoRepository = new ProdutoRepository();
                consulta = produtoRepository.GetById(idProduto);
                PrintProduct(consulta);

                Console.Write("Entre com o nome do produto........: ");
                consulta.Nome = Console.ReadLine();

                Console.Write("Entre com o preco do produto.......: ");
                consulta.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Entre com a quantidade do produto..: ");
                consulta.Quantidade = int.Parse(Console.ReadLine());
                produtoRepository.Update(consulta);

                Console.WriteLine("Produto atualizado com sucesso!");
                Produto produto = new Produto();
                produto = produtoRepository.GetById(idProduto);
                PrintProduct(produto);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao realizar o cadastro do produto: {e.Message}!");
            }
        }
        public void RemoveProduct()
        {
            try
            {
                int idProduto, opcao;

                Console.WriteLine("\n *** Remocao de Produto ***\n");
                Console.Write("Entre com o codigo do produto......: ");
                idProduto = int.Parse(Console.ReadLine());

                //listar produto
                Produto consulta = new Produto();
                ProdutoRepository produtoRepository = new ProdutoRepository();
                consulta = produtoRepository.GetById(idProduto);
                PrintProduct(consulta);

                Console.WriteLine("Deseja remover o produto listado...: 1) Sim - 2) Nao");
                opcao = int.Parse(Console.ReadLine());
                
                if (opcao == 1)
                {
                    produtoRepository.Delete(consulta);
                    Console.WriteLine("Produto removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Produto nao removido!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao realizar o cadastro do produto: {e.Message}!");
            }
        }
        public void ListAllProduct()
        {
            try
            {
                ProdutoRepository produtoRepository = new ProdutoRepository();

                Console.WriteLine("\n *** Consultar de Produtos ***\n");
                foreach (Produto produto in produtoRepository.GetAll())
                {
                    Console.WriteLine("Produto: " + produto.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao listar todos os produtos: {e.Message}!");
            }
        }
        public void ListProduct()
        {
            try
            {
                int idProduto;

                Console.WriteLine("\n *** Consulta de Produto ***\n");
                Console.Write("Entre com o codigo do produto......: ");
                idProduto = int.Parse(Console.ReadLine());

                //listar produto
                Produto consulta = new Produto();
                ProdutoRepository produtoRepository = new ProdutoRepository();
                consulta = produtoRepository.GetById(idProduto);
                PrintProduct(consulta);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao realizar o cadastro do produto: {e.Message}!");
            }
        }
        public int Menu()
        {
            int opcao;

            Console.WriteLine("\n *** Controle de Produto ***\n");
            Console.WriteLine("Escolha uma opcao: ");
            Console.WriteLine("1 - Cadastrar um produto: ");
            Console.WriteLine("2 - Consultar um produto: ");
            Console.WriteLine("3 - Listar todos os produtos: ");
            Console.WriteLine("4 - Modificar um produto: ");
            Console.WriteLine("5 - Remover um produto: ");
            Console.WriteLine("6 - Sair do sistema: ");
            try
            {
                opcao = int.Parse(Console.ReadLine());
                return opcao;
            }
            catch (Exception e)
            {
                Console.WriteLine("Dados de entrada invalido " + e.Message);
            }

            return 0;
        }
    }
}
