namespace if_statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 90, b = 80, c = 70, d = 60, f = 50 ;
            int grade;
            string name;

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Grade: ");
            grade = int.Parse(Console.ReadLine());


            if ( grade >= a  )
            {
                Console.WriteLine( name + " get A in Math");
            }
            else if ( grade >= b )
            {
                Console.WriteLine(name + " get B in Math");
            }
            else if( grade >= c )
            {
                Console.WriteLine(name + " get C in Math");
            }
            else if (grade >= d)
            {
                Console.WriteLine(name + " get D in Math");
            }
            else
            {
                Console.WriteLine(name + " get F in Math");
            }
           
        }
    }
}