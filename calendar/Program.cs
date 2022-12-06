using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday ,
            Friday ,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели: ");
            string stringNumberOfDay = Console.ReadLine();
            int NumberOfDay = Convert.ToInt32(stringNumberOfDay);

            if (Enum.IsDefined(typeof(DayOfWeek), NumberOfDay))
            {
                Console.WriteLine((DayOfWeek)NumberOfDay);
            }
            else
            {
                Console.WriteLine(("Введен неверный номер дня недели!!!")); 
            }   
            Console.ReadKey();
        }
    }
}
