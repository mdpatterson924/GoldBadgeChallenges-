using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Challenge
{
    class ProgramUI
    {
        private Claim _claim;
        private ClaimRepository _claimRepo;

        public ProgramUI()
        {
            _claim = new Claim();
            _claimRepo = new ClaimRepository();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. See all claims:\n" +
                    "2. Take care of next claim:\n" +
                    "3. Enter a new claim:\n" +
                    "4. Exit Application:");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        SeeClaimsQueue();
                        break;
                    case 2:
                        TakeCareOfNextClaim();
                        break;
                    case 3:
                        NewClaim();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
        public void SeeClaimsQueue()
        {
            Queue<Claim> queue = _claimRepo.GetClaimQueue();

            foreach (Claim claimQueue in queue)
            {
                Console.WriteLine($"{claimQueue.ClaimID}{claimQueue.ClaimType}{claimQueue.Description}{claimQueue.ClaimAmount}{claimQueue.DateOfIncident}{claimQueue.DateOfClaim}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public void NewClaim()
        {
            Claim newClaim = new Claim();
            Console.WriteLine("Enter the Claim information:\n" +
                "What is the ClaimID?");
            string claimID = Console.ReadLine();

            newClaim.ClaimID = int.Parse(claimID);

            Console.WriteLine("What is the claim description?");
            Console.ReadLine();

            Console.WriteLine("What is the claim amount?");
            string claimAmount = Console.ReadLine();
            newClaim.ClaimAmount = decimal.Parse(claimAmount);

            Console.WriteLine("What is the claim type?\n" +
                "1. Car" +
                "2. Home" +
                "3.Theft");
            string OrderAsString = Console.ReadLine();

            int claimType = int.Parse(OrderAsString);

            switch (claimType)
            {
                case 1:
                    newClaim.TypeOfClaim = ClaimType.Car;
                    break;
                case 2:
                    newClaim.TypeOfClaim = ClaimType.Home;
                    break;
                case 3:
                    newClaim.TypeOfClaim = ClaimType.Theft;
                    break;
            }
            Console.WriteLine("When did the incident occur?\n" +
                "mounth/date/year.");
            string DateOfIncident = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(DateOfIncident);

            Console.WriteLine("When was the claim entered\n" +
                "maounth/date/year");
            string DateOfClaim = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(DateOfClaim);

            double DayDifference = (newClaim.DateOfClaim - newClaim.DateOfIncident).TotalDays;
            if(DayDifference > 30)
            {
                newClaim.IsValid = false;
            }
            else
            {
                newClaim.IsValid = true;
            }
            _claimRepo.AddClaimToQueue(newClaim);
        }
        public void TakeCareOfNextClaim()
        {
            Claim NextClaim = _claimRepo.GetClaimQueue().Peek();
            Console.WriteLine("here are the details for the next claim to be handled.");
            Console.WriteLine($"Claim ID:, {NextClaim.ClaimID}");
            Console.WriteLine($"Type:, {NextClaim.TypeOfClaim}");
            Console.WriteLine($"Description:, {NextClaim.Description}");
            Console.WriteLine($"Amount:, {NextClaim.ClaimAmount}");
            Console.WriteLine($"Date of Incident:, {NextClaim.DateOfClaim}");
            Console.WriteLine($"Is it valid?:, {NextClaim.IsValid}");

            Console.WriteLine("Do you want to deal with this claim now?\n" +
                "Y OR" +
                "N.");
            string TakeCareOfNextClaim = Console.ReadLine();
            if (TakeCareOfNextClaim.ToUpper() == "Y")
            {
                _claimRepo.RemoveClaimFromQueue();
            }
        }
    }
}
