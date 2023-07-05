using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class FahrenheitToCelsius
    {
        // (32°F − 32) × 5/9 = 0°C
        public static float FtoC(float fahrenheit)
        {
            fahrenheit = ((fahrenheit - 32f) * 5f) / 9f;
            return fahrenheit;
        }
    }
}
