using System;

namespace HW2
{
    class Program
    {
        static void Main()
        {
            /*
 * This program asks the user for the size of a window.
 * It then calculates the total length of wood needed for the frame
 * and the total area of the glass.
 * */

            double width;
            double height;
            double woodLength;
            double glassArea;
            string widthString;
            string heightString;
            string windowString; 
            int windowCount = 0;
            decimal windowCost = 0;
            decimal totalCost = 0;
            const decimal windowAreaCharge = 9.49m; 

            // read in the width
            Console.WriteLine("Please enter the width in meters.");
            widthString = Console.ReadLine(); // get the value from the user  
            width = double.Parse(widthString); //convert the string into a double

            // read in the height
            Console.WriteLine("Please enter the height in meters.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            // calculate ( width + height ) * 2 * 3.25  and convert to feet
            woodLength = (width + height) * 2 * 3.25;
            // calculate width times height 
            glassArea = (width * 3.25) * (height * 3.25);

            // and print it
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square feet");

            // read in num of windows
            Console.WriteLine("Please enter the number of windows.");
            windowString = Console.ReadLine();
            windowCount = Convert.ToInt32(windowString);
            // calculate cost of one window
            windowCost = (decimal)glassArea * windowAreaCharge;
            // calculate total cost
            totalCost = windowCount * windowCost;

            // tell user total cost with the correct format
            Console.WriteLine("The total cost is: ${0:0.00}", totalCost);

            // this line prevents display window from closing until you type the Enter key
            Console.ReadLine();

        }     
    }
}
