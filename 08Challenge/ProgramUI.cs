using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Challenge
{
   public class ProgramUI
    { 
        //make sure to initialize when declaring a variable

        private Driver _driver = new Driver();
        private InsuranceRepository _inRepo = new InsuranceRepository();

        public ProgramUI()
        {
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add Driver:\n" +
                    "2. View Driver Information:\n" +
                    "3. Exit Application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        CreateNewDriver();
                        break;
                    case 2:
                        ViewRates();
                        break;
                    case 3:
                        running = false;
                        break;

                }
            }
        }
        private void CreateNewDriver()
        {
            Console.Clear();
            Console.WriteLine("What is the driver's name?");
            string name = Console.ReadLine();

            Console.WriteLine("Number of times speed limit was exceeded?");
            int speedViolations = int.Parse(Console.ReadLine());

            decimal speedCost = 0m;
            if (speedViolations > 10)
            {
                speedCost = 20m;
            }
            Console.WriteLine("Number of times driver swerved outside of lane?");
            int swerveViolations = int.Parse(Console.ReadLine());

            decimal swerveCost = 0m;
            if (swerveViolations > 3)
            {
                swerveCost = 5m;
            }
            Console.WriteLine("Number of times driver failed to stop completly at stop sign?");
            int stopViolations = int.Parse(Console.ReadLine());

            decimal stopCost = 0m;
            if (stopViolations > 3)
            {
                stopCost = 5m;
            }
            Console.WriteLine("Number of tiems driver followed too closely?");
            int proximityViolations = int.Parse(Console.ReadLine());
            decimal spaceCost = 0m;
            if(proximityViolations > 3)
            {
                spaceCost = 5m;
            }
            decimal basePremium = 20m;
            decimal totalCost = basePremium + speedCost + swerveCost + stopCost + spaceCost;

            Console.Clear();
            Console.WriteLine
                  ($"Base Premium:             {basePremium.ToString("C2")}\n" +
                $"Speed Violations:         {speedCost.ToString("C2")}\n" +
                $"Swerve Violations:        {swerveCost.ToString("C2")}\n" +
                $"Stop Violations:     {stopCost.ToString("C2")}\n" +
                $"Proximity Violations:    {spaceCost.ToString("C2")}\n" +
                $"\n" +
                $"The monthly premium for {name} is {totalCost.ToString("C2")}. Press any key to return to the menu.");
            Console.ReadLine();
        }
        private void ViewRates()
        {
            decimal basePremium = 20m;
            decimal speedCost = 20m;
            decimal swerveCost = 5m;
            decimal stopCost = 5m;
            decimal spaceCost = 5m;

            Console.Clear();
            Console.WriteLine($"Here are the 2019 Rates:\n" +
                $"Base Premium:                       {basePremium.ToString("C2")}\n" +
                $"More than 10 speed violations:     +{speedCost.ToString("C2")}\n" +
                $"More than 3 swerve violations:       +{swerveCost.ToString("C2")}\n" +
                $"More than 3 stop violations:  +{stopCost.ToString("C2")}\n" +
                $"More than 3 proximity violations: +{spaceCost.ToString("C2")}\n" +
                 "Press any key to continue...");
            Console.ReadLine();

        }
    }
}
