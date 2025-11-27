using System;
using System.ComponentModel.Design;

Console.WriteLine("digite o peso em kg");
double pesoEmKg = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite a altura em metros");
double alturaEmMetros = Convert.ToDouble(Console.ReadLine());
double imc;


if (alturaEmMetros == 0)
{
    Console.WriteLine("A altura deve ser maior que zero: ");
    return;
}
double alturaAoQuadrado = alturaEmMetros * alturaEmMetros;
imc = pesoEmKg / alturaAoQuadrado;
double imcFormatado = Math.Round(imc, 2);

Console.WriteLine($"O IMc calculado é: {imcFormatado}");

if (imcFormatado < 18.5)
{
    Console.WriteLine("Magreza");
}
else if (imcFormatado >= 18.5 && imcFormatado <= 24.9)
{
    Console.WriteLine("Normal");
}
else if (imcFormatado >= 25 && imcFormatado <= 29.9)
{
    Console.WriteLine("Excesso de peso");
}
else if (imcFormatado >= 30 && imcFormatado <= 34.9)
{
    Console.WriteLine("Obesidade grau 1");
}
else if (imcFormatado >= 35 && imcFormatado <= 39.9)
{
    Console.WriteLine("Obesidade grau 2");
}
else
{
    Console.WriteLine("Obesidade grau 3");
}
    