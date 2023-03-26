using System;

namespace Enums
{
    class Program
    {
        enum weekdays { sun,mon,tue,wed,ths,fri,sat};
        enum carshow { hero,apachi,hank,palsar};
        public class car
        {
            public string carname;
            public string brandname;
            public string color;
            public string mileage;
            
            public void car1(string carvar)
            {

                if (carvar == carshow.apachi.ToString())
                {
                    this.carname = "Apachi";
                    this.brandname = "Hanked";
                    this.color = "Black";
                    this.mileage = "320 km/h";
                }
                else if (carvar == carshow.hero.ToString())
                {
                    this.carname = "Hero";
                    this.brandname = "Bolck";
                    this.color = "Gray";
                    this.mileage = "306 km/h";
                }
                else if (carvar == carshow.hank.ToString())
                {
                    this.carname = "Hank";
                    this.brandname = "Yellowed";
                    this.color = "Red";
                    this.mileage = "350 km/h";
                }
                else if (carvar == carshow.palsar.ToString())
                {
                    this.carname = "Palsar";
                    this.brandname = "Bander";
                    this.color = "pink";
                    this.mileage = "420 km/h";
                }
                else
                {
                    this.carname = null;
                    this.brandname = null;
                    this.color = null;
                    this.mileage = null;

                }
            }

            public void result(string nnp)
            {
                this.car1(nnp);
                Console.WriteLine($"CarName :{carname}");
                Console.WriteLine($"BrandName :{brandname}");
                Console.WriteLine($"Car_Color :{color}");
                Console.WriteLine($"Mileage :{mileage}");
            }
        }
        static void Main(string[] args)
        {

            //--------------------first block-----------------------------
            Console.WriteLine("===================enums==================");
            Console.WriteLine($"weekdaystart :{(int)weekdays.mon}");
            Console.WriteLine($"weekdayend :{(int)weekdays.fri}");
            Console.WriteLine(carshow.hank);

            //---------------------second block-------------------------
            Console.WriteLine("===================enums==================");
            var bnd = new car();
            bnd.result(carshow.apachi.ToString());
            Console.ReadLine();

        }
    }
}
