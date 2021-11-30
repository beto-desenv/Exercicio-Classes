using System;
using System.Globalization;

namespace Exercicio_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" 1°-Programa p/ ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.");
            //Console.WriteLine();

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            //}

            //Console.WriteLine();
            //Console.WriteLine("=======================================================================================================");
            //Console.WriteLine();

            //Console.WriteLine(" 2°-Programa p/ ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.");
            //Console.WriteLine();

            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //Console.WriteLine("Dados do primeiro funcionário:");
            //Console.Write("Nome: ");
            //f1.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Dados do segundo funcionário:");
            //Console.Write("Nome: ");
            //f2.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double media = (f1.Salario + f2.Salario) / 2.0;

            //Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine();
            //Console.WriteLine("=======================================================================================================");
            //Console.WriteLine();

            //Console.WriteLine(" 3°-Fazer um programa para ler os valores da largura e altura de um retângulo.Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe como mostrado no projeto ao lado.");
            //Console.WriteLine();

            //Retangulo ret = new Retangulo();

            //Console.WriteLine("Entre c/ a largura e altura do retângulo: ");
            //ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine();
            //Console.WriteLine("=======================================================================================================");
            //Console.WriteLine();

            //Console.WriteLine(" 4°-Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).Em seguida, mostrar os dados do funcionário(nome e salário líquido).Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada(somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.Use a classe projetada abaixo.");
            //Console.WriteLine();

            //Funcionario func = new Funcionario();

            //Console.Write("Nome: ");
            //func.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine("Funcionário: " + func);

            //Console.WriteLine();
            //Console.WriteLine("Deseja aumentar o salário em qual porcentagem ? ");
            //double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //func.AumentarSalario(porcent);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + func);

            Console.WriteLine();
            Console.WriteLine("=======================================================================================================");
            Console.WriteLine();

            Console.WriteLine(" 5°-Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).Ao final, mostrar qual a nota final do aluno no ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema.");
            Console.WriteLine();

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
                + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            }
        }
    }
}
