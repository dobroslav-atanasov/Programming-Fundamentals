using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.PersonalException
{
    public class PersonalException
    {
        public static void Main()
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                try
                {
                    if (num < 0)
                    {
                        throw new PersonalExcep();
                    }

                    Console.WriteLine(num);
                }
                catch (PersonalExcep exception)
                {
                    Console.WriteLine(exception.Message);
                    break;
                }
            }
        }
    }
}
