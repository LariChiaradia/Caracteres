Console.WriteLine("Escreva Algo");
var text = Console.ReadLine();

if (string.IsNullOrEmpty(text))
    throw new Exception("Valor escrito é nulo");

var tamanho = text.Length;
var charInverter = new char[tamanho];

tamanho -= 1;
foreach (var caracter in text)
{
    charInverter[tamanho] = caracter;
    tamanho--;
}

var result = new string(charInverter);

Console.WriteLine("\nInverso:");
Console.WriteLine(result);