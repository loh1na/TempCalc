using System;



namespace TempCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("from which temperature valuable to what you want to convert?\n1)from F(Fahrenheit) to C(Celsius)\n2)from C(Celsius) to F(Fahrenheit)");
            string answer = Console.ReadLine();
            if (answer == "1"){
                Console.WriteLine("type temp in F");
                string inputF = Console.ReadLine();
                Console.WriteLine(FtoC(Convert.ToSingle(inputF)));
            }
            else if (answer == "2"){
                Console.WriteLine("type temp in C");
                string inputC = Console.ReadLine();
                Console.WriteLine(CtoF(Convert.ToSingle(inputC)));
            }
            else{
                Console.WriteLine("Please, type correct answer. 1 or 2.");
            }

        }

        private static float FtoC(float tempinF)
        {
            
            float ConvertToC = (tempinF - 32) / 1.8f;

            return ConvertToC;

        }

        private static float CtoF(float TempInC)
        {
            
            float ConvertToF = TempInC * 1.8f + 32;

            return ConvertToF;

        }
    }
}