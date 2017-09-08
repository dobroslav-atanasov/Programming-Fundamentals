using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.ParkingValidation
{
    public class ParkingValidation
    {
        static void Main()
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            string pattern = @"([A-Z]{2}\d{4}[A-Z]{2})";

            for (int i = 0; i < n; i++)
            {
                string[] inputParts = Console.ReadLine().Split(' ').ToArray();
                string command = inputParts[0];

                if (command == "register")
                {
                    string user = inputParts[1];
                    string licenseNumber = inputParts[2];
                    if (Regex.IsMatch(licenseNumber, pattern))
                    {
                        if (!parking.ContainsKey(user))
                        {
                            if (parking.ContainsValue(licenseNumber))
                            {
                                Console.WriteLine($"ERROR: license plate {licenseNumber} is busy");
                            }
                            else
                            {
                                Console.WriteLine($"{user} registered {licenseNumber} successfully");
                                parking[user] = licenseNumber;
                            }                            
                        }
                    }
                    else
                    {
                        if (parking.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licenseNumber}");
                        }
                    }
                }
                else if (command == "unregister")
                {
                    string user = inputParts[1];
                    if (!parking.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {user} unregistered successfully");
                        parking.Remove(user);
                    }
                }
            }

            foreach (var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
