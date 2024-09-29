using System;

namespace KTPM { 
class Program 
{
    static void Main(string[] args)
    {
        bool loop = true;

        while (loop)
        {
            Console.WriteLine("Nhap so tien chuyen");
            string input = Console.ReadLine();
           

            if (input.ToLower() == "exit")
            {
                loop = false;
                Console.WriteLine("Exit");
                break;
            }

            try
            {
                string result = Bank.transfer(Convert.ToInt32(input));
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Only number");
            }

            Console.WriteLine();
        }
    }
}
}