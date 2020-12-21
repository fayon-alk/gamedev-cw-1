using System;

namespace classwork1
{
    class Program
    {
        static void Main (string[] args)
        {
            string charactername = "ahamad";
            int age = 15;
            float speed = 1.65f;
            string superpower1 = "steal armor";
            string superpower2 = "night vision";

            Console.WriteLine("my name is {0} and my superpower is {1} and {2} my age is {3} my speed is {4} ", charactername, superpower1, superpower2, age, speed);

            // second task 
            string heroname = "mario";
                string heroheight = "180cm";
            int heroage = 20;
            string herosuperpower1 = "fire";
            string herosuperpower2 = "fast";
            int agedifference = heroage - age;
            Console.WriteLine("the age difference between two heroes is {0}", agedifference);


        }
    }
}
