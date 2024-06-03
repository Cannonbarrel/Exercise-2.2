using System;

class Program {
  public static void Main (string[] args) {
    
            const double BaseRate = 200.0;
            const double HourlyRate = 150.0;
            const double PerMileRate = 2.0;

            double hours = 0;
            double miles = 0;

            Console.Write("Enter the number of hours for the job: ");
            string hoursInput = Console.ReadLine();

            bool isHoursValid = double.TryParse(hoursInput, out hours);
            if (!isHoursValid)
            {
                Console.WriteLine("Please enter another number please <3.");
                return;
            }

            Console.Write("Enter the number of miles involved in the move: ");
            string milesInput = Console.ReadLine();

            bool isMilesValid = double.TryParse(milesInput, out miles);
            if (!isMilesValid)
            {
                Console.WriteLine("Please enter another number please <3.");
                return;
            }

            double totalFee = BaseRate + (HourlyRate * hours) + (PerMileRate * miles);
          
            Console.WriteLine("The total moving fee is: ${0}", totalFee);
        }
    }

