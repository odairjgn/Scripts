using System.IO;
using static System.Console;
Inicio:
WriteLine("Informe a pasta: ");
var pastaOrigem = new DirectoryInfo(ReadLine());
var pastas = pastaOrigem.GetDirectories();

var i = 0;

foreach (var p in pastas)
{
    i++;
    var novoNome = Path.Combine(pastaOrigem.FullName, i.ToString("D2") + " - " + p.Name);
    Directory.Move(p.FullName, novoNome);
    ForegroundColor = ConsoleColor.Red;
    Write(p.FullName);
    ForegroundColor = ConsoleColor.Yellow;
    Write(" => ");
    ForegroundColor = ConsoleColor.Green;
    WriteLine(novoNome);
    ResetColor();
}

WriteLine("Efetuar nova enumeração? (S/N)");
if (ReadKey().KeyChar.ToString().ToUpper() == "S")
    goto Inicio;
