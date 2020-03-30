using System;

namespace HomeWork5
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] opend = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            string[] check = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
            int x = 1;
            while(x <= 50){
                Console.WriteLine("Of/On Light bulb");
                string ledno = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    if (opend[i] == ledno & check[i] == "0")
                    {
                        check[i] = "1";
                    }
                    else if (opend[i] == ledno & check[i] == "1")
                    {
                        check[i] = "0";
                    }
                    
                }
                Console.WriteLine("{0}",string.Join(" ", opend));
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(string.Join(" ", check));
                x++;
            }
            
        }
    }
}
