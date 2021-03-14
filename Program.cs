using System;
using System.Collections;

namespace dogHotel
{
    class Program
    {
        /*
         * Project Goals:
         * Step 1: Welome message
         * Step 2: Enter amount of dogs
         * Step 3: Enter names
         * Step 4: Enter Nights
         * Step 5: Calculate total with Texas sales Tax
         * Step 6: Print close message and the total cost
         */

        static double salesTax(int dogAmount, int nights)
        {
            //Step 5: Calculate total with Texas Sales Tax
            //convert ints to double
            //apply rates to dogAmount and nights;
            //apply new rates to stateTax
            //return the new total
            
            double dogAmountDouble = Convert.ToDouble(dogAmount);
            double doubleNights = Convert.ToDouble(nights);
            double nRate = 15.00;
            double dRate = 10.00;
            double stateTax = .08;

            //doubles for calculated rates
            double finalDogRate = dogAmountDouble * dRate;
            double finalNightRate = doubleNights * nRate;

            //final tax calculated
            double finalTax = (finalDogRate + finalNightRate) * stateTax;

            //double for final total
            double total = (finalDogRate + finalNightRate) + stateTax;
            return total;
        }


        static void Main(string[] args)
        {
            bool moreDogs = true;
            ArrayList dogNames = new ArrayList();

            //Step 1: Welcome Part
            //Step 2: Enter Amount of Dogs
            Console.WriteLine("*** Welcome to the Dog Hotel! ***");
            Console.WriteLine("This App will calculate your rate to keep them here.");
            Console.WriteLine("How many dogs do you have?");

            //user input
            int dogAmount = Convert.ToInt16(Console.ReadLine());


            //Step 3: Enter Names
            Console.WriteLine("What are their names?");
            Console.WriteLine("Add up to 10 names!");
            Console.WriteLine("");
            Console.WriteLine("***Type -end- to finish adding names.***");

            //Loop to Enter Names
            do
            {
                string answer = Console.ReadLine();
                dogNames.Add(answer);

                //removes "end" input from the list
                if (answer.Equals("end"))
                {
                    moreDogs = false;
                    dogNames.Remove("end");
                }

            } while (moreDogs);


            //Step 4: Enter Nights.
            Console.WriteLine("Please enter the number of nights they will be staying.");
            Console.WriteLine("The rate is as follows:");
            Console.WriteLine("$10 per night.");
            Console.WriteLine("$15 per dog.");

            //user input
            int nights = Convert.ToInt16(Console.ReadLine());

            //Calls Step: 5
            Console.WriteLine("Your total will be:");
            double newTotal = salesTax(dogAmount, nights);
            Console.WriteLine(newTotal);

            //Step 6: Print close message
            Console.Write("Enjoy your stay ");
            for (int i = 0; i < dogNames.Count; i++) {
                Console.Write(dogNames[i]);
                if (i < dogNames.Count - 1)
                {
                    //prints commas between entries
                    Console.Write(", ");
                }
            }
            Console.Write("!");
            

        }//end Main

    }//end Class
}//end nameSpace
