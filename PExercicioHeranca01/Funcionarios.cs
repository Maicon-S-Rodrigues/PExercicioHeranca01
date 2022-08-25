using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioHeranca01
{
    internal class Funcionarios : Pessoa
    {
        //Essa será uma das Classes Filhas, que Herdaram conteúdo da Classe Pai "Pessoas"
        String NumPis;
        float Salario;
        String Setor;

        //Método construtor com parâmetros herdados e novos
        public Funcionarios(String nome, String dataNasc, String cpf, /*herdados*/
                       String numPis, float salario, String setor /*novos*/) : base(nome, dataNasc, cpf) //referenciando a BASE de onde foram herdados
        {
            NumPis = numPis;
            Salario = salario;
            Setor = setor;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNúmero do PIS: " + NumPis +
                                     "\nSalário: R$: " + Salario +
                                     "\nSetor: " + Setor;
        }
    }
}
