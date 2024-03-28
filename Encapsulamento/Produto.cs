using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class Produto
    {
        private string _nome; //atributo privado se escreve com _ e primeira minuscula: _name
        private double _preco;
        private int _quantidade;

        public Produto (string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome,preco) 
        {
            _quantidade = quantidade;
    }
}
