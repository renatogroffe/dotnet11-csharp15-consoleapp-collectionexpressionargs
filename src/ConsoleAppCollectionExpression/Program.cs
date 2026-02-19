using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 11 + C# 15 | IReadOnlySet<T> + Collection expression arguments *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

string[] paises = ["Brasil", "Italia", "Portugal", "Alemanha",
    "ITALIA", "Espanha", "BRASIL", "portugal", "espanha", "AlEmAnHA", "Inglaterra"]; 

List<string> listPaises = [with(capacity: 20), .. paises];
Console.WriteLine($"{nameof(listPaises)} = {JsonSerializer.Serialize(listPaises)}");

Console.WriteLine();

HashSet<string> hashSetPaises = [with(comparer: StringComparer.OrdinalIgnoreCase), .. listPaises];   
Console.WriteLine($"{nameof(hashSetPaises)} = {JsonSerializer.Serialize(hashSetPaises)}");