using System;
using System.Collections.Generic;
using System.Text;

namespace P228
{
    public static class Extention

    {
        public static bool CheckNotRoboteCode(this string notRoboteCode)
        {
            if (notRoboteCode.Lenght == 4)
            {
                return true;


            }
            else
            {
                return false;
            }
        }
    }
}
