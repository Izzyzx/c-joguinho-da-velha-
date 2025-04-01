Using System;


Class Program

{

Static void Main()

{

Console.WriteLine(“======✰ Calculadora ✰======”);


Console.Write(“Digite o primeiro número: “);

If (!double.TryParse(Console.ReadLine(), out double num1))

{

Console.WriteLine(“Valor inválido! Digite um número.”);

Return;

}


Console.Write(“Digite o segundo número: “);

If (!double.TryParse(Console.ReadLine(), out double num2))

{

Console.WriteLine(“Valor inválido! Digite um número.”);

Return;

}


Console.WriteLine(“Escolha uma das 4 operações:”);

Console.WriteLine(“1 – Adição\n2 – Subtração\n3 – Multiplicação\n4 – Divisão”);


If (!int.TryParse(Console.ReadLine(), out int operacao))

{

Console.WriteLine(“Opção inválida! Digite um número de 1 a 4.”);

Return;

}


Switch (operacao)

{

Case 1:

Console.WriteLine($”O resultado da Soma é: {num1 + num2}”);

Break;

Case 2:

Console.WriteLine($”O resultado da Subtração é: {num1 – num2}”);

Break;

Case 3:

Console.WriteLine($”O resultado da Multiplicação é: {num1 * num2}”);

Break;

Case 4:

If (num2 == 0)

Console.WriteLine(“Erro: Divisão por zero é inválida.”);

Else

Console.WriteLine($”O resultado da Divisão é: {num1 / num2}”);

Break;

Default:

Console.WriteLine(“Opção inválida! Escolha um número entre 1 e 4.”);

Break;

}

}

}
