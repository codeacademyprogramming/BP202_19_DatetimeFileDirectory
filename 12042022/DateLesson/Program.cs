using System;
using System.Reflection;
using System.Threading;

namespace DateLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");

            DateTime date = new DateTime(2020, 10, 20,14,30,0);

            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());

            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss"));

            date = date.AddYears(-5);
            date = date.AddMonths(10);

            var now = DateTime.UtcNow;
            now = now.AddHours(4);

            Console.WriteLine("Days");
            Console.WriteLine(now.Day);
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Year);


            Console.WriteLine(now);

            Console.WriteLine(date);

            var diff = now.Subtract(date);

            Console.WriteLine(diff.TotalHours);
            Console.WriteLine(diff.Hours);
            Console.WriteLine(diff.TotalDays);

            Console.WriteLine("Tarixi daxil edin:");
            string dateStr = Console.ReadLine();

            DateTime inputDate = Convert.ToDateTime(dateStr);

            Console.WriteLine(inputDate.ToString("dd.MM.yyyy HH:mm"));
        }
    }
}
