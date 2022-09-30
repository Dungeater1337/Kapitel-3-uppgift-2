using System; 

namespace Uppgift3_14
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            string svar = Console.ReadLine().ToLower();
            

            if (svar == "j")
            {
                Console.WriteLine("Okej hur gammal är du?"); 
                int ålder = int.Parse(Console.ReadLine());

                if (ålder <= 22 && ålder >= 18)
                {
                    Console.WriteLine("Vi skulle vilja anställa dig.");   // Jfdhsofj
                }

                else
                {
                    Console.WriteLine("vi letar tyvärr efter annan personal just nu");
                }
            }
                
                else if (svar == "n")
            {
                Console.WriteLine("Dra dååååå"); 
            }
                
            
        }
    }
}