//programa que vai somar 2 numeros digitados pelo usuario e depois dividi-lo por 2
double numero1;
double numero2;
double soma;
double divisao;


Console.WriteLine("digite o primeiro número a ser somado");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o segundo número a ser somado");
numero2 = Convert.ToDouble(Console.ReadLine());

soma = numero1 + numero2;
divisao = soma / 2;
Console.WriteLine("------------------------------------------------------------------------------------------");
Console.WriteLine($"soma: {numero1} + {numero2} = {soma} \ndivisão: {soma} / 2 = {divisao}");