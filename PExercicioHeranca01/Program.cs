using System;

namespace PExercicioHeranca01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            String nome, dataNasc, cpf, registroRA, dataMatricula, numPIS, setor;
            float salario;


            //criando um novo objeto através da Classe "Pessoa"
            //e já passando os parâmetros para registrar o
            //Objeto através das Classes Filhas "Alunos" e "Funcionarios"
            //ALUNO 1:
            Console.WriteLine("CADASTRO de 2 Alunos.\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Primeiro Aluno:\n");
            Console.WriteLine("Informe o nome do Aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a Data de Nascimento do Aluno: ");
            dataNasc = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Aluno: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe o R.A do Aluno: ");
            registroRA = Console.ReadLine();
            Console.WriteLine("Informe a Data de Matrícula do Aluno: ");
            dataMatricula = Console.ReadLine();
            Alunos aluno1 = new Alunos(nome, dataNasc, cpf, registroRA, dataMatricula);
            //////////////////////////////////////////////////////////////////////////////////////////////
            //ALUNO 2:
            Console.WriteLine("\nAperte qualquer tecla para continuar para o próximo...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Segundo Aluno:\n");
            Console.WriteLine("Informe o nome do Aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a Data de Nascimento do Aluno: ");
            dataNasc = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Aluno: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe o R.A do Aluno: ");
            registroRA = Console.ReadLine();
            Console.WriteLine("Informe a Data de Matrícula do Aluno: ");
            dataMatricula = Console.ReadLine();
            Alunos aluno2 = new Alunos(nome, dataNasc, cpf, registroRA, dataMatricula);
            //////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////
            //Funcionario 1:
            Console.Clear();
            Console.WriteLine("CADASTRO de 2 Funcionários.\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Primeiro Funcionário:\n");
            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a Data de Nascimento: ");
            dataNasc = Console.ReadLine();
            Console.WriteLine("Informe o CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe o Número do PIS: ");
            numPIS = Console.ReadLine();
            Console.WriteLine("Informe o Setor: ");
            setor = Console.ReadLine();
            Console.WriteLine("Informe o Salário: ");
            salario = float.Parse(Console.ReadLine());
            Funcionarios funcionario1 = new Funcionarios(nome, dataNasc, cpf, numPIS, salario, setor);
            /////////////////////////////////////////////////////////////////////////////////////////////
            //Funcionario 2:
            Console.WriteLine("\nAperte qualquer tecla para continuar para o próximo...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Segundo Funcionário:\n");
            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a Data de Nascimento: ");
            dataNasc = Console.ReadLine();
            Console.WriteLine("Informe o CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe o Número do PIS: ");
            numPIS = Console.ReadLine();
            Console.WriteLine("Informe o Setor: ");
            setor = Console.ReadLine();
            Console.WriteLine("Informe o Salário: ");
            salario = float.Parse(Console.ReadLine());
            Funcionarios funcionario2 = new Funcionarios(nome, dataNasc, cpf, numPIS, salario, setor);
            /////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////
            Console.Clear();
            Console.WriteLine("Dois Alunos cadastrados:\n");
            Console.Write("Aluno 1:\n" + aluno1.ToString() +
                          "\n\n-------------------------------------------------------" + 
                          "\n\nAluno 2:" + aluno2.ToString());
            Console.Write("\n\n-------------------------------------------------------");
            Console.WriteLine("\nAperte qualquer tecla para mostrar agora os Funcionários...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Dois Funcionários cadastrados:\n");
            Console.Write("Funcionário 1:\n" + funcionario1.ToString() +
                          "\n\n-------------------------------------------------------" +
                          "\n\nFuncionário 2:" + funcionario2.ToString());
            Console.Write("\n\n-------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
