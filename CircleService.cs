using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    public class CircleService
    {

        public static double GetArea(double radius)
        {
            double area = Circle.Pi * radius * radius;
            return area;

        }
        public static double GetCircumference(double radius)
        {
            double circumference = 2 * Circle.Pi * radius;
            return circumference;
        }

        public static double ConvertAreaToKm(double radius)
        {
            double area = CircleService.GetArea(radius) / 1000;
            return area;
        }

        public static double ConvertCircumferenceToKm(double radius)
        {
            double circumference = CircleService.GetCircumference(radius) / 1000;
            return circumference;
        }
    }
}
