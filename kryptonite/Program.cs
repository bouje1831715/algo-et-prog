using System;

namespace kryptonite
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "bonjour";
            Random keyR = new Random();
            int key = keyR.Next(-15, 16);
            string krypter = "";



            Console.WriteLine("Veuiller entrer la phrase a krypter");
            phrase = Console.ReadLine();

            for (int i = 0; i < phrase.Length; i++)
            {
                krypter += Convert.ToChar((int)phrase[i] + key);
            }
            Console.WriteLine("votre phrase krypter est " + krypter + " avec une clé de " + key);

            Console.ReadKey();
        }
    }
}
