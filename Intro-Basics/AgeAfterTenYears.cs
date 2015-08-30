using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        string birthDay = Console.ReadLine();

        DateTime today = DateTime.Today;
        DateTime bDay = DateTime.Parse(birthDay);
        int age = today.Year - bDay.Year;

        Console.WriteLine("Now: {0}",age);
        Console.WriteLine("After 10 years: {0}",age+10);
    }
}
