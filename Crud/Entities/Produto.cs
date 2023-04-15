using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public Produto()
        {
            //vazio
        }
        public Produto(int idProduto, string nome, decimal preco, int quantidade, DateTime dataCadastro)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            DataCadastro = dataCadastro;
        }
        public override string ToString()
        {
            return $"Codigo: {IdProduto}, Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}, Data do Cadastro: {DataCadastro.ToString("dd/MM/yyyy HH:mm")}";
        }
    }
}