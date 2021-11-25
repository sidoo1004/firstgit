using System;
using System.Text;

namespace rep_git_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! sidorencu Adrian ");
            string myString = "hello";
            string myNestString = "world";
            string a = "a";
            string b = "b";
            string c = "c";
            string random = "B";

            int result = string.Compare(a, b);
            int resultLeft = string.Compare(a, b);
            int resultright = string.Compare(c, b);
            int resultRandom = string.Compare(random, b, false);

            //concatonari
            myString = myString + "worlds";
            string hellowu = myString + "my g " + myNestString;
            Stopwatch stopWatch = StopWatch.StartNew();


            for(int i = 0; i<1000; i++)
            {
                myString += i;

            }

            StringBuilder builder = new StringBuilder();
            builder.Append(myString);
            for (int i = 0; i < 10000; i++)
            {
                builder.Append(i);

            }
            



        }
    }
}

