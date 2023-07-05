namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What degrees would you like to convert from Celsius to Fahrenheit?");
            int celsius = int.Parse(Console.ReadLine());
            CelsiusToFahrenheit.CtoF(celsius);
            Console.WriteLine();
            Console.WriteLine("Fahrenheit To Celsius Program:\n");
            Console.WriteLine(FahrenheitToCelsius.FtoC(73f) + " Celsius.");
        }
    }
}
