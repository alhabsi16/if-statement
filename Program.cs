namespace if_statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 1;
           

            if ( a == b || a > b )
            {
                Console.WriteLine("condition met");
            }
            else
            {
                Console.WriteLine("condition is not met");
            }
        }
    }
}