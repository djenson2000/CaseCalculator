using System;

namespace Task_5_part_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string choice; //setting "choice" to be a string
            Int16 first, second, output; //initalising the carbibles first secinds and output as a intager

            Console.Write("Enter first number: ");
            first = Convert.ToInt16(Console.ReadLine()); //Getting the first number
            Console.Write("Enter second number: ");
            second = Convert.ToInt16(Console.ReadLine()); // getting the second number
            Console.Write("Do you wan to add, subtract, multiply or divide and find remainder (1,2,3 or 4): ");
            choice = Console.ReadLine(); //finding out what operation is wanted

            switch (choice) //starting the switch statment
            {
                case "1": //IF the client wants to add... 
                    output = (short)(first + second); //setting the value of "Output" to be the first number plus the second number 
                    Console.WriteLine("{0} + {1} = {2}", first, second, output); //Outputting that result in a clean format
                    break; //Ending the first case statment

                case "2": //IF the client wants to subtract...
                    output = (short)(first - second); // take the seconds number away from the first and put the result in "output"
                    Console.WriteLine("{0} - {1} = {2}", first, second, output);  // Outouts that result in a clean easy to read format
                    break; //ends the second case statment

                case "3": //IF the client wants to multiply...
                    output = (short)(first * second); //multiply the first number by the second number
                    Console.WriteLine("{0} * {1} = {2}", first, second, output); //Then output that result in a clean format
                    break; // end the 3rd case statment

                case "4": //If the client wishs to divide and find the remainder of that result
                    output = (short)(first % second); // do the modules of that fist number to the second (should have remebered that for the test oh well)
                    Console.WriteLine("the remainder of {0} / {1} is {2}", first, second, output); // Output the modules in a clean format
                    break; // end the final case statment

                default: //IF none of those cases are true (the use didnt enter a valid operation)
                    Console.WriteLine("Enter 1, 2 3 or 4 next time >:("); //tell the user off and tell them to do better next time because there silly
                    break; //end the final case statment

            }
        }
    }
}
