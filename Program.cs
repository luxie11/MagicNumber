using System;

namespace Devbridge
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write a number:");
                string insertedNumber = Console.ReadLine();
                int number = Int32.Parse(insertedNumber);
                if (isMagicNumber(number))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }



        }

        static bool isMagicNumber(int number)
        {
            int numberCopy = number;
            int counter = 0;
            int digit = (number % 10);
            bool isValueTheSame = true;
            while(numberCopy > 0)
            {
                counter++;
                if (numberCopy % 10 != digit)
                    isValueTheSame = false;
                numberCopy = numberCopy / 10;
            }
            if (isValueTheSame == true)
                return false;
            if(counter % 2 == 0)
            {
                int halfNumber = (int)Math.Pow(10, counter / 2);
                int firstNumber = number % halfNumber;
                if (isMagicNumber(firstNumber))
                    return false;
            }
            numberCopy = number;
            while (true)
            {
                int rem = number % 10;
                int div = number / 10;
                number = (int)(Math.Pow(10, counter - 1)) * rem + div;
                if (number == numberCopy)
                    break;
                if (number % numberCopy != 0)
                    return false;
            }
            return true;
        }
    }
}
