using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Tijela", 1.99);
            Produto p2 = new Produto("Mc Book", 999.99, 10);

            Console.WriteLine(p1.GetNome()); //usa um metodo que permite pegar o atributo privado
            p1.Nome = "Tappleware"; //usando propriedade e nao metodo


        }

       

    }
}
