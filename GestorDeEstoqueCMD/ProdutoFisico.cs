using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstoqueCMD
{
    [System.Serializable]
     class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;
        public ProdutoFisico(string nome,  float frete,  float preco)
        {
            this.nome = nome;
            this.frete = frete;
            this.preco = preco;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque do preduto {nome}");
            Console.WriteLine("Digite a quantidade de produtos que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saída no estoque do preduto {nome}");
            Console.WriteLine("Digite a quantidade de produtos que você quer dar baixa: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque -= entrada;
            Console.WriteLine("saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine("=================================");
        }
    }
}
