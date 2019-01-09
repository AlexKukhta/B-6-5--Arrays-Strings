using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyatnashki();
            Console.ReadLine();
        }

        public static void ReadConsoleMassive()
        {
            Console.WriteLine("Enter 6 value in array: ");
            int[] sixValue = new int[6];
            for (int i = 0; i < sixValue.Length; i++)
            {
                sixValue[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your value: {0}",sixValue[i]);
            }
            
            
        }

       public static void MassiveSort()
        {
            int[] array = new int[5] { 5,8,4,7,3};
            int a;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i]);
            }
        }



        public static void CutString()
        {
            Console.WriteLine("CutString");
            Console.WriteLine("Add new sentence: ");

            string sentence = Convert.ToString(Console.ReadLine());
            int i = sentence.Length;
            if (sentence.Length>13)
            {
                string newSentence = sentence.Substring(0, 13);
                Console.WriteLine(newSentence+"...");
            }
        }
       
        public static void ReplaseInPoem()
        {
            Console.WriteLine("ReplaseInPoem");
            Console.WriteLine("Add new poem: ");

            System.String  poem = Console.ReadLine();



            poem.Split(';');
            
            poem.Replace("o", "a");
            poem.Replace("l", "l'");
            poem.Replace("t'", "t");

            Console.WriteLine(poem);
        }

        public static void Pyatnashki()
        {
            Console.WriteLine("Game Pyatnashki");
            int a;

            int[,] table = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int i = 0;
            int j = 0;

            for (i = 0; i < table.GetLength(0); i++)
            {
                for (j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i,j]);
                    
                }

                Console.WriteLine();
            }

            Console.WriteLine("Enter 'W', 'A', 'S' or 'D' for changing location: ");
            
            var buttom = Console.ReadKey();
            i = 0;
            j = 0;

            do
            { 
                switch (buttom.KeyChar)
                    {
                        case 'W':
                        case 'w':
                            if (i==0)
                            {
                                Console.WriteLine("another letter");
                                
                            }
                            else
                            { 
                                a = table[i - 1, j];
                                table[i - 1, j] = table[i, j];
                                table[i, j]=a;
                                i --;
                                
                            }
                            
                            break;

                        case 'A':
                        case 'a':
                            if (j==0)
                            {
                                Console.WriteLine("another letter");
                            }
                            else
                            {
                                a = table[i, j - 1];
                                table[i, j - 1] = table[i, j];
                                table[i, j] = a;
                                j--;
                            }
                            break;

                        case 'S':
                        case 's':
                            if (i==table.GetLength(1)-1)
                            {
                                Console.WriteLine("another letter");
                                
                            }
                            else
                            {
                                a = table[i + 1, j];
                                table[i + 1, j] = table[i, j];
                                table[i, j] = a;
                                i++;   
                            }
                            break;

                        case 'D':
                        case 'd':
                            if (j == table.GetLength(0) - 1)
                            {
                                Console.WriteLine("another letter");
                            }
                            else
                            {
                                a = table[i, j + 1];
                                table[i, j + 1] = table[i, j];
                                table[i, j] = a;
                                j++;
                            }
                            break;
                        
                        default:
                            Console.WriteLine("Your buttom isn't correct");
                            break;
                    }

                    for (int k = 0; k < table.GetLength(0); k++)
                    {
                        for (int n = 0; n < table.GetLength(1); n++)
                        {
                            Console.Write(table[k, n]);

                        }

                        Console.WriteLine();
                    }
                buttom=Console.ReadKey();
            } while (buttom.KeyChar!='x');
            Console.WriteLine("");

        }
        
        public static void PoemExample()
        {
            
        }
    }
}
