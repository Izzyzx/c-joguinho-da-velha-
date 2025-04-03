using System;

class Program
{
    static void Main()
    {
        // Definição das categorias de carros
        string[] categorias = { "Hatch", "Sedan", "SUV" };

        // Definição dos modelos e suas informações acho q vai
        string[,] modelos = {
            { "Gol", "R$ 50.000", "Motor 1.0", "Consumo: 12km/L" },
            { "Uno", "R$ 45.000", "Motor 1.0", "Consumo: 13km/L" },
            { "Fiesta", "R$ 55.000", "Motor 1.6", "Consumo: 11km/L" },
            { "Civic", "R$ 120.000", "Motor 2.0", "Consumo: 10km/L" },
            { "Corolla", "R$ 130.000", "Motor 2.0", "Consumo: 11km/L" },
            { "Jetta", "R$ 140.000", "Motor 1.4 Turbo", "Consumo: 12km/L" },
            { "Renegade", "R$ 110.000", "Motor 1.8", "Consumo: 9km/L" },
            { "HR-V", "R$ 125.000", "Motor 1.5 Turbo", "Consumo: 10km/L" },
            { "Compass", "R$ 150.000", "Motor 2.0", "Consumo: 8km/L" }
        };

        bool continuar = true;

        while (continuar)
        {
            // Exibir categorias disponíveis
            Console.WriteLine("\nCategorias disponíveis:");
            for (int i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {categorias[i]}");
            }

            int escolhaCategoria = 0;
            while (escolhaCategoria < 1 || escolhaCategoria > categorias.Length)
            {
                Console.Write("Escolha uma categoria (1 a 3): ");
                string entrada = Console.ReadLine();

                if (entrada == "1" || entrada == "2" || entrada == "3")
                {
                    escolhaCategoria = int.Parse(entrada);
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }

            Console.WriteLine($"\nVocê escolheu: {categorias[escolhaCategoria - 1]}");

            // Exibir modelos da categoria escolhida
            Console.WriteLine("\nModelos disponíveis:");
            int inicio = (escolhaCategoria - 1) * 3;
            int fim = inicio + 3;

            for (int i = inicio; i < fim; i++)
            {
                Console.WriteLine($"{(i - inicio) + 1}. {modelos[i, 0]}");
            }

            int escolhaModelo = 0;
            while (escolhaModelo < 1 || escolhaModelo > 3)
            {
                Console.Write("Escolha um modelo (1 a 3): ");
                string entradaModelo = Console.ReadLine();

                if (entradaModelo == "1" || entradaModelo == "2" || entradaModelo == "3")
                {
                    escolhaModelo = int.Parse(entradaModelo);
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }

            // Exibir informações do modelo escolhido
            int indiceModelo = inicio + (escolhaModelo - 1);
            Console.WriteLine($"\nInformações do {modelos[indiceModelo, 0]}:");
            Console.WriteLine($"Preço: {modelos[indiceModelo, 1]}");
            Console.WriteLine($"Motor: {modelos[indiceModelo, 2]}");
            Console.WriteLine($"Consumo: {modelos[indiceModelo, 3]}");

            // Perguntar se deseja continuar ou n
            Console.Write("\nDeseja consultar outro modelo? (s/n): ");
            string resposta = Console.ReadLine();

            if (resposta != "s" && resposta != "S")
            {
                continuar = false;
                Console.WriteLine("\nObrigado por utilizar nosso sistema! Volte sempre. 🚗💨");
            }
        }
    }
}
