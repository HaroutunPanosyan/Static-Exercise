using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class CelsiusToFahrenheit
    {
        //(0°C × 9/5) + 32 = 32°F
        public static void CtoF(int celsius)
        {
            Console.WriteLine(celsius = ((celsius * 9) / 5) + 32);
        }
    }
}
