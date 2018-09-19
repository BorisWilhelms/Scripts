using System.Security.Cryptography;

if (!Args.Any())
{
    Console.WriteLine("Please soemthing to hash");
    return;
}

using (var sha = SHA256.Create())
{
    var bytes = Encoding.UTF8.GetBytes(Args[0]);
    var hash = sha.ComputeHash(bytes);

    Console.WriteLine(Convert.ToBase64String(hash));
}