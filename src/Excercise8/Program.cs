using System;

namespace Excercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //prima uzduotis
            ArrayInput();

            //antra užduotis
            try
            {
                Login();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Antra užduotis
        /// </summary>
        private static void Login()
        {
            Console.WriteLine("Įveskite vartotojo vardą");
            var userName = Console.ReadLine();

            Console.WriteLine("Įveskite slaptaždį");
            var pass = Console.ReadLine();
            if (userName == "admin" && pass == "admin")
            {
                throw new Exception("Neteisingi duomenys");
            }

            Console.WriteLine("Sveiki prisijungę");
        }


        /// <summary>
        /// Pirma užduoti
        /// </summary>
        private static void ArrayInput()
        {
            try
            {
                Console.WriteLine("Įveskite norimo masyvo dydį");
                int arrSize = int.Parse(Console.ReadLine());
                var arr = new int[arrSize];

                for (int i = 0; i < arrSize; i++)
                {
                    Console.WriteLine($"Įveskite {i + 1} masyvo narį");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Kuri nari atspausdinti");
                var input = int.Parse(Console.ReadLine());
                var item = arr[input - 1];

                Console.WriteLine(item);

                Console.Read();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Nurodytas netinkamas masyvo dydis");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Nurodytas neegzistuojantis masyvo indeksas");
            }
            catch (FormatException)
            {
                Console.WriteLine("Neteisinga įvestis");
            }
        }
    }
}
