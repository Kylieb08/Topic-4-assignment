namespace Topic_4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kylie Banman

            //variables
            string name, age, pay, firstName, lastName, login;
            int grade, studentID;
            double average;

            //Part one
            //Console.WriteLine("This is part one of the assignment");
            //Console.WriteLine("Hello what is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine("Hi, " + name + "! How old are you?");
            //age = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine("So you're " + age + "? That's not old at all!");
            //Console.WriteLine("How much do you make?");
            //pay = Console.ReadLine();
            //Console.WriteLine("$" + pay + "! I hope that's per hour and not per year!");

            //Part two
            Console.WriteLine("Hello! Please enter the following information so I can sell it for a profit!");
            Console.WriteLine("First name:");
            firstName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Last name:");
            lastName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Grade (9-12):");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out grade));
            Console.WriteLine(" ");
            Console.WriteLine("Student ID:");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out studentID));
            Console.WriteLine(" ");
            Console.WriteLine("Login:");
            login = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Average:");
            Double.TryParse(Console.ReadLine(), out average);
            Console.WriteLine(" ");


        }
    }
}
