using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {

        public string GetCows(int n)
        {
            int lastDigit = n % 10;

            if (n > 10 && n < 20)
                return "коров";

            if (n % 100 > 10 && (n % 100 < 20))
                return "коров";


            switch (lastDigit)
            {
                case 1:
                    return "корова";
                case 2:
                case 3:
                case 4:
                    return "коровы";
                default:
                    return "коров";
            }

        }

    }
}
