using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
namespace HomeWork9
{
    class Program
    {
            static void Main(string[] args)
            {
                using (var reader = new StreamReader(@"product.csv"))
                {
                    List<string> id = new List<string>();
                    List<string> name = new List<string>();
                    List<string> price = new List<string>();


                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        id.Add(values[0]);
                        name.Add(values[1]);
                        price.Add(values[2]);

                    }
                    ArrayList Name = new ArrayList();
                    ArrayList Price = new ArrayList();
                    int sum = 0;
                    int count = 1;
                    while (count <= 100)
                    {
                        Console.WriteLine("Please input a product key:");
                        string inputidproduct = Console.ReadLine();
                        for (int i = 0; i < 10; i++)
                        {
                            if (id[i] == inputidproduct)
                            {
                                Name.Add(name[i]);
                                Price.Add(price[i]);
                                string pri = price[i];
                                int x = Convert.ToInt32(pri);
                                sum = sum + x;

                            }
                        }
                        Console.WriteLine("Products in your cart are");
                        
                        for(int num = 1; num <= Name.Count; num++ ){
                                int Num = Convert.ToInt32(num);
                                int Order = Num - 1;

                                Console.WriteLine(Num + ". " + Name[Order]+ " " + Price[Order]);
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Total amount: "+ sum + " bath");
                    }
                }
            }
        }
}
