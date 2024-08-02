using System;


namespace BerekeningTarief
{

    class Program
    {
        static void Main()
        {
            int leeftijd;


            leeftijd = int.Parse(Console.ReadLine());

            // Switch case
            switch (leeftijd)
            {
                case 1:
                    Console.WriteLine("juist");
                    break;
                case 2:
                    Console.WriteLine("juist");
                    break;
                case 3:
                    Console.WriteLine("juist");
                    break;
                default:
                    Console.WriteLine("fout");
                    break;
            }




           
        }
    }
}



