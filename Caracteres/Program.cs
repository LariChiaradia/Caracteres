Console.WriteLine("Escreva Algo");
var text = Console.ReadLine();

if (string.IsNullOrEmpty(text))
    throw new Exception("Valor escrito é nulo");

var tamanho = text.Length;
var charInverter = new char[tamanho];

foreach (var caracter in text)
{
    tamanho--;
    charInverter[tamanho] = caracter;
}

var result = new string(charInverter);

Console.WriteLine("\nInverso:");
Console.WriteLine(result);