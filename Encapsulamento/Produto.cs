using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class Produto
    {
        const string NOME_EMPRESA = "Teste SA"; //nome de constantes sao sempre com todas as letras maiusculas
        
        private string _nome; //atributo privado se escreve com _ e primeira minuscula: _name
        private double _preco; //deixar privado protege o atributo, nao permitindo manipulação pelo usuario
        private int _quantidade;

        //propriedades em C# (manipula atributos) -> ao invez de criar um metodo pra get e um pra set, usa propriedade e descreve dentro o que cada um faz
        public string Nome
        {
            get {
                return _nome;
            }
            set {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3) //utiliza value no local do nome da variavel que seria declarada no metodo, pq no metodo, vc coloca a variavel como argumento, e na propriedade, isso nao eh possivel
                {
                    Console.WriteLine("Nome nulo ou com menos de 3 caracteres.");
                    return;
                }
                _nome = value;
            }
        }

        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("PReco não pode ser negativo.");
                    return;
                }
                _preco = value;
            }
        }

        //propriedade autoimplementada
        public int Quantidade { get; set; }   //nao faz nada alem de get e set, sem condições, sem alterar os valores do Atributo (private set -> nao faz alterações do conteudo).
        


        public Produto (string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

              
    }
}
