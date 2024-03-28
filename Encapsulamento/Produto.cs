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

        public Produto (string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        public string GetNome() //pega o nome, retorna uma string (string)
        {
            return _nome;
        }

        public void SetNome(string nome) //define novo valor, nao retornando nada ao usuário (void)
        {
            if(string.IsNullOrWhiteSpace(nome) || nome.Length < 3)
            {
                Console.WriteLine("Nome nulo ou com menos de 3 caracteres.");
                return;
            }

            _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double preco)
        {
            if (preco < 0)
            {
                Console.WriteLine("Preco nao pode ser negativo");
                return;
            }

            _preco = preco;
        }

        public int GetQuantidade ()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            if (quantidade < 0)
            {
                Console.WriteLine("Quantidade nao pode ser negatica.");
                return;
            }

            _quantidade = quantidade;
        }
    }
}
