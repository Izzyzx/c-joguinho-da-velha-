using System;

class Program
{
    static void Main()
    {
        SaudacaoPersonalizada();
        LugaresParaConhecer();
    }

    static void SaudacaoPersonalizada()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo!");
    }

    static void LugaresParaConhecer()
    {
        Console.WriteLine("Digite três lugares que você deseja conhecer:");

        Console.Write("Lugar 1: ");
        string lugar1 = Console.ReadLine();

        Console.Write("Lugar 2: ");
        string lugar2 = Console.ReadLine();

        Console.Write("Lugar 3: ");
        string lugar3 = Console.ReadLine();

        Console.WriteLine($"Seria incrível conhecer {lugar1}, {lugar2} e {lugar3}!");
    }
}