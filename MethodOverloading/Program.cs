namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b) 
        { 
            return a + b;
        }
        public static double Add(double a, double b) 
        {  
            return a + b; 
        }
        public static string Add(int a, int b, bool c)
        {
            if (c == true)
            {
                if (a + b == 1)
                {
                    return $"{a + b} dollar";
                }
                else
                {
                    return $"{a + b} dollars";
                }
                
            }
            else
            {
                return "False";
            }
            
        }

        static void Main(string[] args)
        {
            int intA = 1;
            int intB = 2;
            double doubleA = 1.5;
            double doubleB = 2.5;
            bool boolA = true;

            Console.WriteLine($"Add {intA} and {intB} is {Add(intA, intB)}");
            Console.WriteLine($"Add {doubleA} and {doubleB} is {Add(doubleA, doubleB)}");
            Console.WriteLine($"Add {intA} and {intB} with the boolean being {boolA} is {Add(intA, intB, boolA)}");
        }
    }
}
