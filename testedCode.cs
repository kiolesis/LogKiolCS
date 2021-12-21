// Przykład złego kodu testującego.

using System;
using Engine.Test;

// Twój kod do testu
namespace CodeForTest
{
    class CodeForTest
    {
        // Metoda Main do eksperymentowania z kodem
        public static void Mein()
        {
            Console.WriteLine("Początek testowanego kodu.");

            // Początek testowanego kodu
            Start.Code();

            // Koniec testowanego kodu

            Console.WriteLine("Koniec testowanego kodu.");
        }
    }
}

// Rozpoczęcie testu
namespace Engine.Test
{
    public class Start
    {
        // Tutaj możesz umieścić błędny kod, aby zwrócić informacje o wyjątku.
        static public void Code()
        {
            try
            {
                // Tutaj umieść błędny kod


                // Przykład:
                double l = 98, b = 0;
                double result;
                result = SafeDivision(l, b);

                Exception a = new Exception();
                throw a;
            }
            catch (Exception a)
            {
                Console.WriteLine("Został zgłoszony wyjątek:");
                Console.WriteLine(a);
                Console.WriteLine(a.Message.ToString());
                Console.WriteLine(a.Source);
                Console.WriteLine(a.HelpLink);
                Console.WriteLine(a.StackTrace);
                Console.WriteLine(a.HResult);
                Console.WriteLine(a.TargetSite);
                
                // Nie używamy dyrektywy "goto".
            a:
                Console.WriteLine("");
                Console.WriteLine("1) Kontynuuj");
                Console.WriteLine("2) Wyjdź z programu");
                string b = Console.ReadLine();
                if (b == "2")
                {
                    Environment.Exit(1);
                }
                if (b == "1")
                {
                    
                }
                else
                {
                    goto a;
                }

            }
        }

        private static double SafeDivision(double a, double b)
        {
            return a / b;
        }

        // Wywołanie testowego błędu
        static public void Error()
        {
            Exception a = new Exception();
            try
            {
                throw a;
            }
            catch
            {
                Console.WriteLine("Został zgłoszony wyjątek:");
                Console.WriteLine(a);
                Console.WriteLine(a.Message.ToString());
                Console.WriteLine(a.Source);
                Console.WriteLine(a.HelpLink);
                Console.WriteLine(a.StackTrace);
                Console.WriteLine(a.HResult);
                Console.WriteLine(a.TargetSite);
            }
        }

        static public int ArrayIndex()
        {
            int[] array = { 1, 1 };
            int index = 0;
            try
            {
                return array[index];
            }
            catch
            {
                throw new ArgumentException("Index wykracza poza zasięg", nameof(index));
            }
        }
    }
}

// Testy wyników kodu
namespace Engine.Test
{
    class Result
    {
        // Zobacz, czy metoda Result.Return(); zwróci oczekiwaną wartość.
        // Użycie:
        // Result.Int("yes", 1);
        // Result.Int(MA ZWRACAĆ INFORMACJE NA EKRANIE?, CO MA OCZEKIWAĆ JAKO WARTOŚĆ ZWRÓCONĄ);
        static public bool Int(string oczekiwanie, int b)
        {
            // Kod konfiguracyjny
            bool a = false;
            int c;

            // Kod testujący
            c = Return();
            if (c == b)
            {
                a = true;
                if (oczekiwanie == "yes")
                {
                    Console.WriteLine("Test Result.Int zaliczony! Bool: " + a + ". Wartość zwrócona: " + c);
                }
                return a;
            }
            else
            {
                a = false;
                if (oczekiwanie == "no")
                {
                    Console.WriteLine("Test Result.Int nie zaliczony! Bool: " + a + ". Wartość zwrócona: " + c);
                }
                return a;
            }
            
        }

        static public int Return()
        {
            int a = 0;

            while (a < 5)
            {
                a++;
            }
            return a;
        }
    }
}

// Uruchomienie testu
namespace Engine.Test
{
    class WasRunning
    {
        static public bool Test(string a, string b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
    }
}

// Testuj ogólnie kod
namespace Engine.Test
{
    class Code
    {
        static public void Voids(string a)
        {
            Console.WriteLine(a);
        }
    }
}
