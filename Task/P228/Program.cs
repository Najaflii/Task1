using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            User user = new User("Farid", "Necefli", "T6H4", Month.February);
            Console.WriteLine(user.GetDetails());

            User user1 = new User("Orxan", "Piriyev", "R4V3V2", Month.March);
            Console.WriteLine(user1.GetDetails);

        }
    }

}
