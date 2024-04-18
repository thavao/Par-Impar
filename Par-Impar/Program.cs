/* 1 - faça um programa que leia um numero inicial e um numero final, mostrando entre eles quais são os valores pares e impares*/

int inicial = 0, final = 0, contador = 0;

Console.Write("Digite o número inicial: ");
inicial = int.Parse(Console.ReadLine());

Console.Write("Digite o número final: ");
final = int.Parse(Console.ReadLine());

contador = inicial + 1;

while (contador < final)
{
    if (contador % 2 == 0 && contador != 0)
        Console.WriteLine(contador + " - Par");
    else
        Console.WriteLine(contador + " - Impar");


    contador++;
}

Console.WriteLine("Digite Enter para encerrar...");
Console.ReadLine();