using System;


namespace EvenNumberAlgorithm
{

    abstract class EvenNumberGenerator
    {
        public void Run(int min, int max)
        {
            for(int i=min; i<=max; i++)
            {
                if (i % 2 == 0)
                {
                    EvenNumber(i);
                }
            }
        }

        public void Run(int number)
        {
            if (number % 2 == 0)
            {
                EvenNumber(number);
            }
            else
            {
                OddNumber(number);
            }
        }

        public abstract void EvenNumber(int number);
        public abstract void OddNumber(int number);
       
    }

    class NumberCheck:EvenNumberGenerator
    {
        public override void EvenNumber(int number)
        {
            Console.WriteLine("This is an even number: {0}", number);
        }

        public override void OddNumber(int number)
        {
            Console.WriteLine("This is an odd number: {0}", number);
        }
    }
    class Program
    {
        static void Main()
        {
            NumberCheck numberCheck = new NumberCheck();
            numberCheck.Run(1,10);
            numberCheck.Run(5);

            Console.ReadKey();

        }
    }
}