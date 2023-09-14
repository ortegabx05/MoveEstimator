using System;

class Program {
  public static void Main (string[] args) {
    const double baseRate = 200;
    const double hourlyRate = 150;
    const double mileRate = 2;
    
    Console.WriteLine ("Enter the total number of hours worked: ");
    double hours = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine ("Enter the distance in miles for  the move: ");
    double miles = Convert.ToDouble(Console.ReadLine());

    double totalFee = baseRate + (hours * hourlyRate) + (miles * mileRate);

    Console.WriteLine("Total moving fee: ${0}", totalFee);
  }
}