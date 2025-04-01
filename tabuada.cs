Using System;


Class Program

{

Static void Main()

{

While (true)

{

Console.Write(“Digite um número para ver a tabuada: “);

If (int.TryParse(Console.ReadLine(), out int numero))

{

Console.WriteLine($”Tabuada do {numero}:”);

For (int i = 1; i <= 10; i++)

{

Console.WriteLine($”{numero} x {i} = {numero * i}”);

}

}

Else

{

Console.WriteLine(“Entrada inválida. Digite um número válido.”);

Continue;

}


Console.Write(“\nDeseja ver a tabuada de outro número? (S para continuar, qualquer outra tecla para sair): “);

String opcao = Console.ReadLine().Trim().ToUpper();


If (opcao != “S”)

{

Console.WriteLine(“Encerrando o programa...”);

Break;

}

}

}

}
