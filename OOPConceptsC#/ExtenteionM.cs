using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    internal class ExtenteionM
    {
    }

    public interface IVehicle
    {
        int WheelCount { get; }
    }

    public class Car : IVehicle
    {
        public int WheelCount { get { return 4; } }
    }

    public static  class VehicleExtensions
    {
        public static void PrintWheelCount(this IVehicle vehicle)
        {
            Console.WriteLine("This vehicle has {0} wheels.", vehicle.WheelCount);
        }

        public static IEnumerable<string> GetWords(this string text)
        {
            return text.Split(' ');
        }
    }
}
