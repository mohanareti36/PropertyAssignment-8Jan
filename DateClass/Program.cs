using DateClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateClass
{
    class DateV
    {
        static int date, month, year;

        public void dateVO()
        {
            switch(month)
            {
              case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if ((date >= 1 && date <= 31) && (year >= 2011 && year <= 2020)){
                        Console.WriteLine("valid date");
                    }
                    else
                        Console.WriteLine("invalid date");
                    break;
              case 4: case 6: case 9: case 11:if((date>=1&&date<=30)&&(year>=2011&&year<=2020))
                                              Console.WriteLine("valid date");
                                             else
                                                Console.WriteLine("invalid date");
                                             break;
              case 2:if(year%400==0||(year%4==0&&year%100!=0))
                    {
                     if(date>=1&&date<=29)
                        Console.WriteLine("valid");
                    else
                        Console.WriteLine("invalid");
                    }
                   else 
                       if(date>=1&&date<=28)
                        Console.WriteLine("valid");
                    else
                        Console.WriteLine("invalid");
                break;
            }
        }
    public int Date
  {
    get
     {
        return date;
     }
    set
     {
        date = value;
     }
   }
    public int Month
   {
         get
       {
          return month;
       }
        set
      {
        month = value;
      }
   }
    public int Year
   {
      get
      {
        return year;
      }
      set
      {
        year = value;
      }
   }

 }


    class Program
    {
        static void Main(string[] args)
        {
        DateClass.DateV d = new DateV();
        Console.WriteLine("Enter Date: ");
        d.Date = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Month: ");
        d.Month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Year: ");
        d.Year = Convert.ToInt32(Console.ReadLine());

            d.dateVO();
            Console.WriteLine("enf");

        }
    }
}
