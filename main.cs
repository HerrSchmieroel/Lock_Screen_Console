using System;

class Phone
{
    static void Main(string[] args)
    {
        int failed = 0;
        string password = "";
    Start:
        
        while (true)
        {
            if (failed >= 27)
            {
                Console.WriteLine("WHY? WHY? I HATE YOU!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Please type in your Password");
            string answer = Console.ReadLine();
            if (failed >= 27)
            {
                Console.WriteLine("WHY? WHY? I HATE YOU!");
                Console.ReadLine();
            }
            if (answer == password)
            {
                Console.WriteLine("Acces granted");
                Console.ReadLine();
                break;
            }
            else if (answer != password)
            {
                Console.WriteLine("False Password!");
                failed++;



            }
            switch (failed)
            {
                case 5:
                    Console.WriteLine("Phone is disabled for 1 minute");
                    Thread.Sleep(60000);
                    goto Start;
                case 6:
                    Console.WriteLine("Phone is disabled for 5 minutes");
                    Thread.Sleep(300000);
                    goto Start;
                case 7:
                    Console.WriteLine("Phone is disabled for 15 minutes");
                    Thread.Sleep(900000);
                    goto Start;
                case 8:
                    Console.WriteLine("Phone is disabled for 15 minutes");
                    Thread.Sleep(900000);

                    goto Start;
                case 9:
                    Console.WriteLine("Phone is disabled for 1 hour");
                    Thread.Sleep(3600000);

                    goto Start;
                case 10:
                    Console.WriteLine("Phone is disabled for 1 hour");
                    Thread.Sleep(3600000);
                    goto Start;
                case 11:
                    Console.WriteLine("Phone is disabled for 5 hours");
                    Thread.Sleep(18000000);
                    goto Start;
                case 12:
                    Console.WriteLine("Phone is disabled for 5 hours");
                    Thread.Sleep(18000000);
                    goto Start;
                case 13:
                    Console.WriteLine("Phone is disabled for 1 day");
                    Thread.Sleep(86400000);
                    goto Start;
                case 14:
                    Console.WriteLine("Phone is disabled for 1 day");
                    Thread.Sleep(86400000);
                    goto Start;
                case 15:
                    Console.WriteLine("Phone is disabled for 5 days");
                    Thread.Sleep(432000000);
                    goto Start;
                case 16:
                    Console.WriteLine("Phone is disabled for 5 days");
                    Thread.Sleep(432000000);
                    goto Start;
                case 17:
                    Console.WriteLine("Phone is disabled for 1 week");
                    Thread.Sleep(604800000);
                    goto Start;
                case 18:
                    Console.WriteLine("Phone is disabled for 1 week");
                    Thread.Sleep(604800000);
                    goto Start;
                case 19:
                    Console.WriteLine("Phone is disabled for 2 weeks");
                    Thread.Sleep(1209600000);
                    goto Start;
                case 20:
                    Console.WriteLine("Phone is disabled for 2 weeks");
                    Thread.Sleep(1209600000);
                    goto Start;
                case 21:
                    Console.WriteLine("Phone is disabled for 30 days");
                    Thread.Sleep(604800000);
                    Thread.Sleep(604800000);
                    goto Start;
                case 22:
                    Console.WriteLine("Phone is disabled for 6 months");
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    goto Start;
                case 23:
                    Console.WriteLine("Phone is disabled for 6 months");
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    Thread.Sleep(1556482560);
                    goto Start;
                case 24:
                    Console.WriteLine("Phone is disabled for 1 year");
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    goto Start;
                case 25:
                    Console.WriteLine("Phone is disabled for 1 year");
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    Thread.Sleep(630720000);
                    goto Start;
                case 26:
                    Console.WriteLine("Bro why do wait over two years to type in a password only to fail again i've no clue why you fail");
                    Console.WriteLine("but I will tell you the password!");
                    Console.WriteLine("The password is: " + password);
                    Console.WriteLine("Please type it right PLEASE! PLEASE!");
                    goto Start;
                    
            }
        }
    }
}