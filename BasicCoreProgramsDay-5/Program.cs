namespace BasicCoreProgramsDay_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! to basic core programming");
            Console.WriteLine("Please choose any one program from below options.");         //User input for options
            Console.WriteLine("1:FlipCoin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin.FlipCoin1();       //Calling method
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}