
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace TimeShits
{
    class Program
    {
        private const int MinHoursPerDay = 8;
        private const int MinHoursPerWeek = 40;

        static void Main(string[] args)
        {
            DisplayBanner();
            var driver = new ChromeDriver();
            driver.Url = "https://crossmw.my.workfront.com/timesheets";
            //Console.WriteLine("Hello World!");
        }


        private static void DisplayBanner()
        {
            using (var sr = new StreamReader("banner.txt"))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }

    }
}
