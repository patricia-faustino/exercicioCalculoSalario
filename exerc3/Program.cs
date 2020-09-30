using System;
using System.Globalization;

namespace exerc3 {
    class Program {
        static void Main(string[] args) {
            int num;
            double horas, salario, valor;
            Console.WriteLine("Digite seu número: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas: ");
            horas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor recebido por hora: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            salario = horas * valor;
            Console.WriteLine("NUMBER= " +num);
            Console.WriteLine("SALARY =U$" + salario.ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
