// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hTHP = new HealthProfile(null, null, 0, null, 0, 0, 0, null);

        Console.Write("Enter Your First Name: ");
        hTHP.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("EnterYour Last Name: ");
        hTHP.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Your Day of Birth: ");
        hTHP.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Month of Birth: ");
        hTHP.MonthOfBirth = (Console.ReadLine());
        Console.Write("Enter Your Year of Birth: ");
        hTHP.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Weight in pounds: ");
        hTHP.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Height in inches: ");
        hTHP.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Gender: ");
        hTHP.Gender = Convert.ToString(Console.ReadLine());



        hTHP.DisplayFirstName();
        hTHP.DisplayLastName();
        hTHP.DisplayDayOfBirth();
        hTHP.DisplayMonthOfBirth();
        hTHP.DisplayYearOfBirth();
        hTHP.DisplayWeightInPounds();
        hTHP.DisplayHeightInInches();
        hTHP.DisplayGender();
        hTHP.DisplayYearsOfAgeSimple();
        hTHP.DisplayMaxHeartRate();
        hTHP.DisplayTargetHeartRate();
        hTHP.DisplayBodyMassIndex();
        hTHP.DisplayBMIOutput();
        hTHP.DisplayBMIChart();
    }
}
