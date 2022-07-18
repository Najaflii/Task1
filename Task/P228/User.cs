using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class User
    {
        private static int id;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NotRoboteCode { get; set; }

        public Month RegistrationMonth { get; set; }
        public User(string name, string surname, string NotRobotCode, Month registrationMonth)
        {
            id++;
            ID = id;
            Name = name;
            Surname = Surname;
            NotRobotCode = NotRobotCode;
            RegistrationMonth = registrationMonth;

        }

        public string GetDetails()
        {


            if (NotRoboteCode.CheckNotRoboteCode())
            {
                return $"{ID} , {Name} , {Surname} , {RegistrationMonth} , {NotRoboteCode}"

            }
            else
            {
                return $"{ID}, {Name}, {Surname} , {RegistrationMonth} , NotRobotCode is not correct";
            }
        }
    }
    public enum Month
    {
        January = 1,
        February,
        March
    }
}
