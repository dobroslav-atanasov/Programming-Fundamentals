using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.PersonalException
{
    public class PersonalExcep : Exception
    {
        public PersonalExcep() : base("My first exception is awesome!!!")
        {

        }
    }
}
