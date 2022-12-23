namespace BasicCoreProgramsDay_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! to basic core programming");
            Console.WriteLine("Please choose any one program from below options.");         //User input for options
            Console.WriteLine("1:FlipCoin\n2:LeapYear\n3:PowerOfTwo\n4:Harmonics\n5:Factors\n6:QuotientAndRemainder\n7:SwapTwoNumbers\n8:EvenOddNumber\n9:VowelConsonant");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)         //Calling different methods using switch case
            {
                case 1:
                    FlipCoin.FlipCoin1();       
                    break;
                case 2:
                    LeapYear.LeapYearPrgoram();
                    break;
                case 3:
                    PowerOfTwo.PowerOfTwoNum();
                    break;
                case 4:
                    Harmonics.HarmonicNumber();
                    break;
                case 5:
                    Console.WriteLine("Please enter input value");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    Factors.factorsNumber(input1);
                    break;
                case 6:
                    QuotientAndRemainder.findingQuotientNumber();
                    break;
                case 7:
                    SwapTwoNumbers.SwapTwoNumbers1();
                    break;
                case 8:
                    EvenOdd.EvenOddNumber();
                    break;
                case 9:
                    VowelConsonant.vowelConsonant();
                    break;
                default:
                    Console.WriteLine("Please enter correct option");
                    break;
            }
        }
    }
}