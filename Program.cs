using System;

namespace TesteDti
{
    class Program
    {
        static void Main(string[] args)
        {    
            string data;
            int qtdPequenos;
            int qtdGrandes;

            Console.WriteLine("Digite a data no formato (dd/mm/yyyy):");
            data = Console.ReadLine();
           
            bool finalDeSemana = VerificarFinalDeSemana(data);

            Console.WriteLine("Digite a quantidade de cães pequenos:");
            qtdPequenos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de cães grandes:");
            qtdGrandes = int.Parse(Console.ReadLine());


            double precoMeuCaninoFeliz = CalcularPrecoMeuCaninoFeliz(finalDeSemana, qtdPequenos, qtdGrandes);
            double precoVaiRex = CalcularPrecoVaiRex(finalDeSemana, qtdPequenos, qtdGrandes);
            double precoChowChawgas = CalcularPrecoChowChawgas(qtdPequenos, qtdGrandes);

            string melhorPetshop;
            double menorPreco;

            if (precoMeuCaninoFeliz <= precoVaiRex && precoMeuCaninoFeliz <= precoChowChawgas)
            {
                melhorPetshop = "Meu Canino Feliz";
                menorPreco = precoMeuCaninoFeliz;
            }
            else if (precoVaiRex <= precoChowChawgas)
            {
                melhorPetshop = "Vai Rex";
                menorPreco = precoVaiRex;
            }
            else
            {
                melhorPetshop = "ChowChawgas";
                menorPreco = precoChowChawgas;
            }

            
            Console.WriteLine($"Melhor petshop: {melhorPetshop}");
            Console.WriteLine($"Preço total dos banhos: R${menorPreco:F2}");
        }

        static double CalcularPrecoMeuCaninoFeliz(bool finalDeSemana, int qtdPequenos, int qtdGrandes)
        {
            double precoPequenos;
            double precoGrandes;

            if (finalDeSemana)
            {
                precoPequenos = qtdPequenos * 24.00;
                precoGrandes = qtdGrandes * 48.00;
            }
            else
            {
                precoPequenos = qtdPequenos * 20.00;
                precoGrandes = qtdGrandes * 40.00;
            }

            return precoPequenos + precoGrandes;
        }

        static double CalcularPrecoVaiRex(bool finalDeSemana, int qtdPequenos, int qtdGrandes)
        {
            double precoPequenos;
            double precoGrandes;

            if (finalDeSemana)
            {
                precoPequenos = qtdPequenos * 20.00;
                precoGrandes = qtdGrandes * 55.00;
            }
            else
            {
                precoPequenos = qtdPequenos * 15.00;
                precoGrandes = qtdGrandes * 50.00;
            }

            return precoPequenos + precoGrandes;
        }

        static double CalcularPrecoChowChawgas(int qtdPequenos, int qtdGrandes)
        {
            double precoPequenos = qtdPequenos * 30.00;
            double precoGrandes = qtdGrandes * 45.00;

            return precoPequenos + precoGrandes;
        }

        static bool VerificarFinalDeSemana(string data)
        {
            string[] partesData = data.Split('/');
            int dia = int.Parse(partesData[0]);
            int mes = int.Parse(partesData[1]);
            int ano = int.Parse(partesData[2]);

            int diaSemana = (dia + (2 * mes) + (3 * (mes + 1) / 5) + ano + (ano / 4) - (ano / 100) + (ano / 400)) % 7;

            return diaSemana == 0 || diaSemana == 6;
        }
    }
}