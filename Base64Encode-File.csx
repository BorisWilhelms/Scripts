using System.IO;
if (!Args.Any())
{
    Console.WriteLine("Please provide filename");
    return;
}
var result = Convert.ToBase64String(File.ReadAllBytes(Args[0]));
Console.WriteLine(result);