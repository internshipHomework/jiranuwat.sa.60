using System;
using System.Threading;

namespace ox
{
    class Program
    {
        static string[] channel = new string[10] {"0","1","2","3","4","5","6","7","8","9"};
        static int  player = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do{
                if(player % 2 == 0){
                    Console.WriteLine("Player:2");
                }
                else{
                    Console.WriteLine("Player:1");
                }
                Table();
                choice = int.Parse(Console.ReadLine());
                

                if(channel[choice] != "X" && channel[choice] != "O"){
                    if(player % 2 == 0){
                        channel[choice] = "X";
                        player++;
                    }
                    else{
                    channel[choice] = "O";
                    player++;
                    }
                }else{
                    Console.WriteLine("Sorry the row {0} is already marked with {1}" , choice , channel[choice]);
                    Thread.Sleep(2000);
                }
            flag = checkwin();
            }
            while (flag != win && flag != -1); 
            Console.Clear();
            Table();
            if(flag == win){
                Console.WriteLine("Play{0} has won",(player % 2) + 1);
            }
            else{
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Table(){
            Console.WriteLine("___________________");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", channel[1], channel[2], channel[3]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", channel[4], channel[5], channel[6]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", channel[7], channel[8], channel[9]);
            Console.WriteLine("|_____|_____|_____|");
            
        }
        
        static int win = 1;
        static int draw = 0;
        private static int checkwin()
        {
            if(channel[1] == channel[2] &&  channel[2] == channel[3] || channel[4] == channel[5] && channel[5] == channel[6] || channel[7] == channel[8] && channel[8] == channel[9]){
                return win;
            }
            else if (channel[1] == channel[4] && channel[4] == channel[7] || channel[1] == channel[5] && channel[5] == channel[9])
            {  
                return win;
            }
            else if(channel[2] == channel[5] && channel[5] == channel[8]){  
                return win;
            }
            else if(channel[3] == channel[6] && channel[6] == channel[9] || channel[3] == channel[5] && channel[5] == channel[7]){
                return win;
            }
            else if(channel[1] != "1" && channel[2] != "2" && channel[3] != "3" && channel[4] != "4" && channel[5] != "5" && channel[6] != "6" && channel[7] != "7" && channel[8] != "8"  && channel[9] != "9" ){
                return -1;
            }
            else{
                return draw;
            }
        }
    }


}
