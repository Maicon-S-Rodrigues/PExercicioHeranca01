using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PExercicioHeranca01
{
    internal class Alunos : Pessoa  
    {
        //Essa será uma das Classes Filhas, que Herdaram conteúdo da Classe Pai "Pessoas"
        //Atributos:
        String RegistroRA;
        String DataMatricula;

        //Método construtor com parâmetros herdados e novos
        public Alunos (String nome, String dataNasc, String cpf, /*herdados*/
                       String registroRA, String dataMatricula /*novos*/) : base (nome, dataNasc, cpf) //referenciando a BASE de onde foram herdados
        {
            RegistroRA = registroRA;
            DataMatricula = dataMatricula;
        }

        public override string ToString()
        {
            return base.ToString() + "\nRegistro de Aluno (R.A): " + RegistroRA +
                                     "\nData de Matrícula: " + DataMatricula;
                                     
        }
    }
}
