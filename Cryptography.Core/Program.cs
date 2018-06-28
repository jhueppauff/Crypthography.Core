using System;

namespace Cryptography.Core
{
    class Program
    {
        private const string key = "E546C8DF278CD5931069B522E695D4F2";

        static void Main(string[] args)
        {
            Console.WriteLine("Insert String to encrypt");
            string content = Console.ReadLine();

            Console.WriteLine("--------------");
            var encrypted = Cryptography.EncryptString(content, key);
            Console.WriteLine($"encrypted:  {encrypted}");

            var decrypted = Cryptography.DecryptString(encrypted, key);
            Console.WriteLine($"decrypted: {decrypted}");

            Console.ReadLine();
        }
    }
}
