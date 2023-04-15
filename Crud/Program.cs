using Crud.Controllers;

namespace Crud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcao;
            ProdutoController produtoController = new ProdutoController();
            opcao = produtoController.Menu();

            while (opcao > 0)
            {
                if (opcao == 1)
                {
                    Console.Clear();
                    produtoController.RegisterProduct();
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    produtoController.ListProduct();
                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    produtoController.ListAllProduct();
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    produtoController.ModifyProduct();
                }
                else if (opcao == 5)
                {
                    Console.Clear();
                    produtoController.RemoveProduct();
                }
                else if (opcao == 6)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opcao invalida");
                    break;
                }

                opcao = produtoController.Menu();
            }
            Console.ReadKey();
        }
    }
}