using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();

            bool asdf = check(text);


            Console.WriteLine(asdf);



            int[] array  = new int[4];

            int index = 5;

              delete(ref array,index);

        }
        static bool check(string text)
        {

            string reverseText = "";
            int count = text.Length;
            for (int i = text.Length - 1; i >= 0; i--)
            {

                reverseText += text[i];


            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == reverseText[i])
                {

                    count++;

                }


            }


            if (count == text.Length)
            {


                return true;
            }
            else return false;

        }

        //5.	Verilmiş array-dən verilmiş indexli elementi silən metod.

        static void delete(ref int[] array ,int index)
        {
            int[] newArray = new int[array.Length -1];

            int checkIndex = 0;

            for (int i=0;i<array.Length;i++)
            {

                if (array[i] == index)
                {


                    array[i] = checkIndex;

                }


            }


            for(int i =0;i<newArray.Length;i++)
            {
                

                if (newArray[i] == index)
                {


                    continue;

                }
                array[i] = newArray[i];


            }

            

            



            Console.WriteLine(newArray);

        }
    }








}
