namespace L07.SoftUniParty
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main()
        {
            HashSet<string> VIPGuestList = new HashSet<string>();
            HashSet<string> regularGuestList = new HashSet<string>();

            while (true)
            {
                string guestName = Console.ReadLine();

                if (guestName == "PARTY")
                {
                    while (true)
                    {
                        string guestArrived = Console.ReadLine();

                        if (guestArrived == "END")
                        {
                            break;
                        }

                        if (VIPGuestList.Contains(guestArrived))
                        {
                            VIPGuestList.Remove(guestArrived);
                        }
                        else if (regularGuestList.Contains(guestArrived))
                        {
                            regularGuestList.Remove(guestArrived);
                        }

                    }

                    break;
                }

                if (char.IsDigit(guestName.First()))
                {
                    VIPGuestList.Add(guestName);
                }
                else
                {
                    regularGuestList.Add(guestName);
                }
            }

            Console.WriteLine(VIPGuestList.Count + regularGuestList.Count);
            foreach (var VIP in VIPGuestList)
            {
                Console.WriteLine(VIP);
            }
            foreach (var regular in regularGuestList)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
