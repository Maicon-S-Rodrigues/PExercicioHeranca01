using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioHeranca01
{
    internal class Pessoa
    {
        //Essa será a classe Pai conforme pedido no enunciado

        //Atributos da Classe Pai:
        String Nome;
        DateTime DataNasc;
        String Cpf;

        //Método Construtor Vazio
        public Pessoa (String nome, String dataNasc, String cpf)
        {
            this.Nome = nome;
            this.DataNasc = DateTime.Parse(dataNasc);
            this.Cpf = cpf;
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        ///
        ///Lista de Métodos:
        public override string ToString()
        {
            return "\nNome: " + Nome +
                   "\nData de Nascimento: " + DataNasc +
                   "\nCPF: " + Cpf;
        }
        ////////////////////////////////////////////////////////////////////////////////////////
    }
}
