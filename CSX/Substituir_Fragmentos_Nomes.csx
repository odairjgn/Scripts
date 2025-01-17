using System.IO;
using static System.Console;
Inicio:
WriteLine("Informe a pasta: ");
var pastaOrigem = new DirectoryInfo(ReadLine());
WriteLine("Informe o fragmento a substituir: ");
var substituir = ReadLine();
var arquivos = pastaOrigem.GetFiles();

foreach (var arquivo in arquivos)
{
    var novoNome = arquivo.FullName.Replace(substituir, "");
    File.Move(arquivo.FullName, novoNome);
    ForegroundColor = ConsoleColor.Red;
    Write(arquivo.FullName);
    ForegroundColor = ConsoleColor.Yellow;
    Write(" => ");
    ForegroundColor = ConsoleColor.Green;
    WriteLine(novoNome);
    ResetColor();
}

WriteLine("Efetuar nova substituição? (S/N)");
if (ReadKey().KeyChar.ToString().ToUpper() == "S")
    goto Inicio;
