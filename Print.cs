using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Print
    {
        public static void PrintinMeters(double radius)
        {

            Console.WriteLine($"The area of circle  is {CircleService.GetArea(radius)} meters");
            Console.WriteLine($"The circumference of circle is {CircleService.GetCircumference(radius)} meters");
        }
        public static void PrintinKilometers(double radius)
        {
            Console.WriteLine($"The area of circle in kilometers  is {CircleService.ConvertAreaToKm(radius)}");
            Console.WriteLine($"The circumference of circle in kilometers  is {CircleService.ConvertCircumferenceToKm(radius)}");
        }
    }
}
