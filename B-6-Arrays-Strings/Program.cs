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
            ReplaseInPoem();
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

            string  poem = Convert.ToString(Console.ReadLine());
            
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

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i,j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Enter 'W', 'A', 'S' or 'D' for changing location: ");

            var buttom = Console.ReadKey();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    switch (buttom.KeyChar)
                        {
                        case 'W':
                        case 'w':
                            a = table[i,j];
                            table[i,j] = table[i - 1,j];
                            table[i - 1,j] = a;
                            break;

                        case 'A':
                        case 'a':
                            a = table[i, j];
                            table[i, j] = table[i, j-1];
                            table[i, j-1] = a;
                            break;

                        case 'S':
                        case 's':
                            a = table[i, j];
                            table[i, j] = table[i + 1, j];
                            table[i + 1, j] = a;
                            break;

                        case 'D':
                        case 'd':
                            a = table[i, j];
                            table[i, j] = table[i, j+1];
                            table[i, j+1] = a;
                            break;

                        default:
                            Console.WriteLine("Your buttom isn't correct");
                            break;
                        }
                }

                Console.WriteLine();
            }
            

        }

        public static void PoemExample()
        {
            
        }
    }
}
