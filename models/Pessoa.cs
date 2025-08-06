using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        // construtores
        public Pessoa() { }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        // getters e setters
        public string Nome
        {
            get => nome;
            set => nome = value; 
        }
        public string Sobrenome
        {
            get => sobrenome;
            set => sobrenome = value; 
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";
    }
}