using System;

namespace IntroDecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction to decision making in C#
            Console.WriteLine("Please enter the current outside temperature: ");
            string input = Console.ReadLine();
            int temperature;
            try
            {
                temperature = Int32.Parse(input);
                Console.WriteLine("The temperature is: {0} degrees.", temperature);
                if (temperature > 20)
                {
                    Console.WriteLine("It's warm out, stay hydrated.");
                }

                if (temperature < 10)
                {
                    Console.WriteLine("It's a bit chilly out there. Might want an extra layer.");
                }

                if (temperature >= 10 && temperature <= 20)
                {
                    Console.WriteLine("It's not too hot, and not too cold. Make sure you have a jacket because it could go either way.");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Sorry, there was a problem recognising your input. Please enter the temperature as a number.");
            }


           
        }
    }
}
