using System;
class Lednum : IHomework05{
    public string DisplayLeOnScreen(string ledno){
        string DisplayLeOnScreen;
        DisplayLeOnScreen = ledno;
        string[] opend = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        string[] check = { "[  ]", "[  ]", "[  ]", "[  ]", "[  ]", "[  ]", "[  ]", "[  ]", "[  ]", "[  ]"};
        int x = 1;
        while(x <= 50){
            Console.WriteLine("Of/On Light bulb");
            ledno = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (opend[i] == ledno & check[i] == "[ ! ]")
                {
                        check[i] = "[  ]";
                }
                else if (opend[i] == ledno & check[i] == "[  ]")
                {
                        check[i] = "[ ! ]";
                }    
                }
                Console.WriteLine(string.Join(" ", check));
                Console.WriteLine("{0}",string.Join(" ", opend));
                x++;
            }
            return ledno;
        }
}