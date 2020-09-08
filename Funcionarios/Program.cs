using System;
using System.Globalization;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncNomeSalario f1 = new FuncNomeSalario();
            FuncNomeSalario f2 = new FuncNomeSalario();

            Console.WriteLine("Dados do primeiro Funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo Funcionário: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salário médio: a "  +  media.ToString ("F2", CultureInfo.InvariantCulture));

        }
    }
}
