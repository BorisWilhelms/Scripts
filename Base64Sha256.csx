using System.Security.Cryptography;

if (!Args.Any())
{
    Console.WriteLine("Please soemthing to hash");
    return;
}

var value = Encoding.UTF8.GetBytes(Args[0]);
var hasher = SHA256.Create();
var hash = hasher.ComputeHash(value);
Console.WriteLine(Convert.ToBase64String(hash));
