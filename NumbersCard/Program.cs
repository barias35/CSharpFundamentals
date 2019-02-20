using System;

namespace NumbersCard
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 14; i++)
            {
                string cardLetter = "";
                switch (i)
                {
                    case 11:
                        cardLetter = "J";
                        break;
                    case 12:
                        cardLetter = "Q";
                        break;
                    case 13:
                        cardLetter = "K";
                        break;
                    case 14:
                        cardLetter = "A";
                        break;
                    default:
                        break;
                }
                for (int x = 1; x <= 4; x++)
                {
                    /*1 –club, 2 – diamond, 3 – heart and 4 – spades*/
                    if (i<=10)
                    {
                        switch (x)
                        {
                            case 1:
                                Console.WriteLine(i + " - Club");
                                break;
                            case 2:
                                Console.WriteLine(i + " - Diamond");
                                break;
                            case 3:
                                Console.WriteLine(i + " - Heart");
                                break;
                            case 4:
                                Console.WriteLine(i + " - Spades");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (x)
                        {
                            case 1:
                                Console.WriteLine(cardLetter + " - Club");
                                break;
                            case 2:
                                Console.WriteLine(cardLetter + " - Diamond");
                                break;
                            case 3:
                                Console.WriteLine(cardLetter + " - Heart");
                                break;
                            case 4:
                                Console.WriteLine(cardLetter + " - Spades");
                                break;
                            default:
                                break;
                        }
                    }
                   
                }
            }
            Console.ReadKey();
        }
    }
}
