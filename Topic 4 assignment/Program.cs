namespace Topic_4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kylie Banman

            //variables
            string name, age, pay, firstName, lastName, login, partThreeName, itemOne, itemTwo;
            int grade, studentID, partThreeAge;
            double average, numberOne, numberTwo, numberThree, priceOne, priceTwo, totalPrice, discount, amountOff, discountPrice;
            double roundedDiscountPrice;
            decimal roundedAverage;

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

            ////Part two
            //Console.WriteLine("This is part two of the assignment");
            //Console.WriteLine("Hello! Please enter the following information so I can sell it for a profit!");
            //Console.WriteLine("First name:");
            //firstName = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine("Last name:");
            //lastName = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine("Grade (9-12):");
            //Console.WriteLine(Int32.TryParse(Console.ReadLine(), out grade));
            //Console.WriteLine(" ");
            //Console.WriteLine("Student ID:");
            //Console.WriteLine(Int32.TryParse(Console.ReadLine(), out studentID));
            //Console.WriteLine(" ");
            //Console.WriteLine("Login:");
            //login = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine("Average:");
            //Double.TryParse(Console.ReadLine(), out average);
            //roundedAverage = Decimal.Round((decimal)average, 1);
            //Console.WriteLine(" ");
            //Console.WriteLine("Your information:");
            //Console.WriteLine("   Name: " + lastName + ", " + firstName);
            //Console.WriteLine("   Grade: " + grade);
            //Console.WriteLine("   Student ID: " + studentID);
            //Console.WriteLine("   Login: " + login);
            //Console.WriteLine("   Average: " + roundedAverage);

            ////Part three
            //Console.WriteLine("This is part three of the assignment");
            //Console.WriteLine("Hello. What is your name?");
            //partThreeName = Console.ReadLine();
            //Console.WriteLine(" ");
            //Console.WriteLine("Hi " + partThreeName + "! How old are you?");
            //Console.WriteLine(Int32.TryParse(Console.ReadLine(), out partThreeAge));
            //Console.WriteLine(" ");
            //Console.WriteLine("Did you know that in five years you will be " + (partThreeAge + 5) + "?");
            //Console.WriteLine("And five years ago you were " + (partThreeAge - 5));

            ////Part four
            //Console.WriteLine("This is part four of the assignment");
            //Console.WriteLine("Hello. Input a number");
            //Double.TryParse(Console.ReadLine(), out numberOne);
            //Console.WriteLine(" ");
            //Console.WriteLine("Input another number");
            //Double.TryParse(Console.ReadLine(), out numberTwo);
            //Console.WriteLine(" ");
            //Console.WriteLine("Input one more number");
            //Double.TryParse(Console.ReadLine(), out numberThree);
            //Console.WriteLine(" ");
            //Console.WriteLine("If those numbers were added and then divided by two, it would equal " + ((numberOne + numberTwo + numberThree) / 2));

            ////Part five
            Console.WriteLine("Please input the name of an item");
            itemOne = Console.ReadLine();
            Console.WriteLine("Please input the price in dollars of " + itemOne);
            Double.TryParse(Console.ReadLine(), out priceOne);
            Console.WriteLine(" ");
            Console.WriteLine("Please input the name of another item");
            itemTwo = Console.ReadLine();
            Console.WriteLine("Please input the price in dollars of " + itemTwo);
            Double.TryParse(Console.ReadLine(), out priceTwo);
            totalPrice = priceOne + priceTwo;
            Console.WriteLine(" ");
            Console.WriteLine("The total price is " + totalPrice);
            Console.WriteLine(" ");
            Console.WriteLine("What percent discount is available?");
            Double.TryParse(Console.ReadLine(), out discount);
            amountOff = totalPrice * (discount/100);
            discountPrice = totalPrice - amountOff;
            Console.WriteLine(" ");
            roundedDiscountPrice = (double)Decimal.Round((decimal)discountPrice, 2);
            Console.WriteLine("The discounted price is " + roundedDiscountPrice);


            /*This readLine is here so the program doesn't instantly close when I run it on my laptop
             * Because it does that for some reason */
            Console.ReadLine();


        }
    }
}
