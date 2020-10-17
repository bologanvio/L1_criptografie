using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar_Criptare
{
    class Program
    {


        public static char cript(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }


        public static string criptare(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output+=cript(ch, key);

            return output;
        }

        public static string Decriptare(string input, int key)
        {
            return criptare(input, 26 - key);
        }


        static void Main(string[] args)
        {

            Console.WriteLine("*****************************************");
            Console.WriteLine("**********CIFRUL LUI CAESAR**************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("\n");
            Console.WriteLine("Alegeti din cele trei tipuri de criptare :");
            Console.WriteLine("\n");
            Console.WriteLine("1-Cifrul lui Caesar");
            Console.WriteLine("2-Criptare dupa orice cheie");
            Console.WriteLine("3-Cifrul Rot13");
            Console.WriteLine("\n");
            string alegere = Console.ReadLine();
            switch (alegere)
            {
                case "1":
                    {
                        Console.WriteLine("Textul pentru criptare: ");
                        string Text_initial = Console.ReadLine();
                        Console.WriteLine("\n");
                        int key = 3;
                        Console.WriteLine("Textul criptat: ");
                        string text_criptat = criptare(Text_initial, key);
                        Console.WriteLine(text_criptat);
                        Console.WriteLine("Textul decriptat:");
                        string t = Decriptare(text_criptat, key);
                        Console.WriteLine(t);
                        Console.Write("\n");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Textul pentru criptare: ");
                        string Text_initial = Console.ReadLine();
                        Console.Write("Dati o cheie de criptare");
                        int key = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("Textul criptat: ");
                        string text_criptat = criptare(Text_initial, key);
                        Console.WriteLine(text_criptat);
                        Console.WriteLine("Textul decriptat:");
                        string t = Decriptare(text_criptat, key);
                        Console.WriteLine(t);
                        Console.Write("\n");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Textul pentru criptare: ");
                        string Text_initial = Console.ReadLine();
                        Console.WriteLine("\n");
                        int key = 13;
                        Console.WriteLine("\n");
                        Console.WriteLine("Textul criptat: ");
                        string text_criptat = criptare(Text_initial, key);
                        Console.WriteLine(text_criptat);
                        Console.WriteLine("Textul decriptat:");
                        string t = Decriptare(text_criptat, key);
                        Console.WriteLine(t);
                        Console.Write("\n");
                        break;
                    }
            }
            

            Console.ReadKey();

        }
    }
}