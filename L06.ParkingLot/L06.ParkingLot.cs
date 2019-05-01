namespace L06.ParkingLot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingLot
    {
        public static void Main()
        {
            HashSet<string> carsInParkingLot = new HashSet<string>();

            while (true)
            {
                string inputDetails = Console.ReadLine();

                if (inputDetails == "END")
                {
                    break;
                }

                string[] command = inputDetails.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = command[0];
                string carRegPlate = command[1];

                if (direction == "IN")
                {
                    carsInParkingLot.Add(carRegPlate);
                }
                else
                {
                    carsInParkingLot.Remove(carRegPlate);
                }
            }

            if (carsInParkingLot.Count != 0)
            {
                foreach (var car in carsInParkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
