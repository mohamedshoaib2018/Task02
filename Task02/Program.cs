using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Background and foreground(line color) customization
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(170, 44);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            SoundPlayer player01 = new SoundPlayer(@"D:\FOR Linked in\Task02\Task02\Biano.wav");
            player01.PlayLooping();
            Thread.Sleep(2000);
            //--------------------------------------

            //-------------------------------
            #region Part one
            string UserName = Environment.UserName;
            string days = $"Welcome Mr {UserName} Iam so happy to help you";
            string[] AllText = days.Split(' ');
            foreach (string text in AllText)
            {
                Console.SetCursorPosition(70, 1);
                foreach (char c in text)
                {
                    Console.Write(c + " ");
                    Console.Beep(5900, 100);

                }
                Thread.Sleep(600);
                Console.SetCursorPosition(70, 1);
                Console.Write(" ************ ");
            }
            Console.SetCursorPosition(70, 1);
            Console.WriteLine("                             ");
            Console.SetCursorPosition(0, 0);

            Console.WriteLine("Plz Enter the floors number");
            double numOfFloors = double.Parse(Console.ReadLine());
            Console.WriteLine($"So The Number Of Floors is = {numOfFloors}");
            Console.WriteLine("\n\n\n");

            double length, width, height;
            Console.WriteLine("Plz Enter The value of the below Requiremnets");
            Console.Write("Length = ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width = ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Heigth = ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine($"So the values are {length}mm for Length and {width}mm for Width and {height}mm for Heigth ");
            Console.WriteLine("\n\n\n");

            string sys1 = "Heating";
            string sys2 = "Ventilation";
            string requiredSystem = null;
            Console.WriteLine("For the Heating system Press 1 and for the Ventilation System Press 2");
            int userAns = int.Parse(Console.ReadLine());
            switch (userAns)
            {
                case 1:
                    requiredSystem = sys1;
                    Console.WriteLine($"So you choosed the {requiredSystem} system");
                    break;
                case 2:
                    requiredSystem = sys2;
                    Console.WriteLine($"So you choosed the {requiredSystem} system");
                    break;
                default:
                    Console.WriteLine("You did not press a valid number");
                    break;

            }
            #endregion
            #region Part Two
            Console.WriteLine("\n\n\n");
            double beamLength, beamWeightOverMeter;
            Console.Write("Plz Enter The Length of the steel Beam ");
            beamLength = double.Parse(Console.ReadLine());
            Console.Write("Plz Enter The Weight Per Meter of The steel Beam ");
            beamWeightOverMeter = double.Parse(Console.ReadLine());
            Console.WriteLine($"So The Tottal Volume of The Beam = {beamLength * beamWeightOverMeter} Kg");
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Is The BedRoom Accessible to Disabled Individuals Y / N");
            Boolean isAccessible = true;
            string userAnser = Console.ReadLine();
            int loopBreaker = 0;


            do
            {
                if (userAnser == "Y" || userAnser == "y" || userAnser == "yes" || userAnser == "Yes")
                {
                    isAccessible = true;
                    Console.WriteLine("thanks for considering the disabled individuals needs in your design");
                    loopBreaker = 1;
                }
                else if (userAnser == "N" || userAnser == "n" || userAnser == "no" || userAnser == "No")
                {
                    isAccessible = false; Console.WriteLine("I think you have to change your design");
                    loopBreaker = 1;
                }
                else
                {
                    Console.WriteLine("we can not understand your answer plz answer with yes or no");
                    userAnser = Console.ReadLine();
                    loopBreaker = -1;
                }
            }
            while (loopBreaker == -1);


            Console.WriteLine("\n\n\n");

            char panelUniqueCode = 'A';
            Console.WriteLine($"The Unique Code to the electrical panel that you have purchasied is {panelUniqueCode}");
            Console.WriteLine("\n\n\n");
            #endregion
            #region Part three
            Console.WriteLine("Enter the Cost Per Unite Area For the Wanted flooring type");
            double cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Area of the floor");
            double area = double.Parse(Console.ReadLine());
            double tottalCost = cost * area;
            Console.WriteLine($"The Tottal Cost of the flooring system is {tottalCost} EGP");
            Console.WriteLine("\n\n\n");
            double Fcu = 25, Fy = 360;
            Console.WriteLine("what is the Column Width");
            double columnWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("what is the Column Depth");
            double columnDepth = double.Parse(Console.ReadLine());
            double Ac = columnWidth * columnDepth;
            double As = 0.01 * Ac, Pu = 0.35 * Ac * Fcu + 0.67 * As * Fy;
            Console.WriteLine($"so the Column Capacity load for your column = {Pu}");
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Plz enter the number of the light bulbs?");
            int bulbsNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Considering that each bulb consumes 60 watts");
            Console.WriteLine($"The tottal Power Consumbtion = {60 * bulbsNum}");
            #endregion


        }
    }
}
