using System;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura");
            Console.WriteLine("Selecione a conversão que deseja: \n1 - celsius -> farenheit\n2 - farenheit -> celsius");
            var escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    CalcularFarenheit();
                    break;
                case "2":
                    CalcularCelsius();
                    break;
                default:
                    Console.WriteLine("Opção não encontrada");
                    break;
            }

            Console.WriteLine("\nRef: SILVA, Marcos Noé Pedro da. \"Equações Matemáticas na Conversão de Temperaturas \"; Brasil Escola. \nDisponível em: https://brasilescola.uol.com.br/matematica/equacoes-matematicas-na-conversao-temperaturas.htm. \nAcesso em 27 de fevereiro de 2021.");

        }

        private static void CalcularCelsius()
        {
            Console.WriteLine("Formula utilizada: (farenheit - 32) / 1.8");
            Console.WriteLine("Insira o valor de farenheit");

            var entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal farenheit))
            {
                var celsius = (farenheit - 32) / 1.8m;
                Console.WriteLine($"{farenheit} farenheit corresponde a {celsius} celsius");
            }
            else
            {
                MensagemErro(entrada);
            }
        }

        private static void CalcularFarenheit()
        {
            Console.WriteLine("Formula utilizada: (celsius * 1.8) + 32");
            Console.WriteLine("Insira o valor de celsius");

            var entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal celsius))
            {
                var farenheit = (celsius * 1.8m) + 32;
                Console.WriteLine($"{celsius} celsius corresponde a {farenheit} farenheit");
            }
            else
            {
                MensagemErro(entrada);
            }
                        
        }
        private static void MensagemErro(string entrada)
        {
            Console.WriteLine($"Não foi possível converter {entrada}");
        }
    }
}
