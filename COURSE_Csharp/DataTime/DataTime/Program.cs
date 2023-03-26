using System;
using System.Timers;
namespace DataTime
{
    class Program
    {

        // IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime>

        static void Main(string[] args)
        {
         
            
            //=================DateTime Constructor=========================
            //--------------only---DateTime(year,month,day)------------------
            /*
            DateTime date1 = new DateTime(2015, 12, 25);
            Console.WriteLine(date1);
            DateTime date2 = new DateTime(2020, 4, 24);//DateTime(year,month,day)---------
            Console.WriteLine(date2);
            //-----------------DateTime(year,month,day,hour,minute,secend)-------
            DateTime date3 = new DateTime(2020, 4, 24, 2, 30, 40);
            Console.WriteLine(date3);





            //===========================DateTime Fields=====================

            //DateTime object contains two static read-only fields called as MaxValue and Minvalue.

            Console.WriteLine(DateTime.MaxValue);//the maximum value of the datetime------
            Console.WriteLine(DateTime.MinValue);//the mininm value of the datetime-------



            //=========================DateTime Methods=============================
            // Creating TimeSpan object of one month(as 30 days) 
            TimeSpan duration = new TimeSpan(0,0,0,0);//Timespan(days,hours,minute,second)----
            DateTime fixvalue = DateTime.Now.Add(duration);//this means (todays date + duration)
            Console.WriteLine(fixvalue);

            TimeSpan duri1 = new TimeSpan(60, 0, 10, 0);
            DateTime fixvalue1 = DateTime.Now.Add(duri1);
            Console.WriteLine(fixvalue1);

            // Adding days to a date 
            DateTime datetime1 = DateTime.Now;
            DateTime adding = datetime1.AddDays(30);//add only days-------------------
            Console.WriteLine(adding);

            // Parsing 
            string datetimevalue = "Wed Dec 30, 2015";
            // 
            DateTime parsingtime = DateTime.Parse(datetimevalue);
            Console.WriteLine(parsingtime);

            // Date Difference  
            DateTime date12 = new System.DateTime(2015, 3, 10, 2, 15, 10);
            DateTime date22 = new System.DateTime(2015, 7, 15, 6, 30, 20);
            DateTime date32 = new System.DateTime(2015, 12, 28, 10, 45, 30);  
            TimeSpan diff1 = date22.Subtract(date12); // 127.04:15:10  
            Console.WriteLine(diff1);
            DateTime date42 = date32.Subtract(diff1);
            Console.WriteLine(date42);// date4 gets 8/23/2015 6:30:20 AM  
            TimeSpan diff2 = date32 - date22; //166.04:15:10  
            Console.WriteLine(diff2);
            DateTime date52 = date22 - diff1;// date5 gets 3/10/2015 2:15:10 AM
            Console.WriteLine(date52);
            TimeSpan nick = DateTime.Now.Subtract(date12);
            Console.WriteLine(nick);



            // Universal Time  
            DateTime dateObj = new DateTime(2015, 12, 20);
            Console.WriteLine("mans" + dateObj.ToUniversalTime()); // 12/20/2015 4:50:30 AM
            Console.ReadLine();

            DateTime universialtime = DateTime.Now;
            Console.WriteLine($" {universialtime}   universialtime is :   {universialtime.ToUniversalTime()}");
           */

            
            //=======================DateTime Properties=======================
            /*
            DateTime _datetime = new DateTime(2020, 4, 24, 9, 31, 20);
            int year = _datetime.Year;
            int month = _datetime.Month;
            int days = _datetime.Day;
            int hours = _datetime.Hour;
            int minutes = _datetime.Minute;
            int second = _datetime.Second;
            int  wekday =(int ) _datetime.DayOfWeek;// 5 due to Friday-------
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(second);
            Console.WriteLine(wekday);


            //==================DayOfWeek==========================
            DateTime dt = new DateTime(2020,4,24);
            bool isEqual = dt.DayOfWeek == DayOfWeek.Thursday; // False  
            bool isEqual2 = dt.DayOfWeek == DayOfWeek.Friday; // True  
            Console.WriteLine(isEqual);
            Console.WriteLine(isEqual2);

            DateTime dt1 = new DateTime(2020, 4, 25);
            bool valueof = dt1.DayOfWeek == DayOfWeek.Friday ? true : dt1.DayOfWeek == DayOfWeek.Friday ? true : false;
            Console.WriteLine(valueof);
            
            int  valueofstring =(int)DateTime.Now.DayOfWeek;
            Console.WriteLine(valueofstring);

            //======================DateTimeKind=======================
            DateTime ring = DateTime.Now;
            DateTime fing = DateTime.UtcNow;

            DateTime ringconvert = DateTime.SpecifyKind(ring, DateTimeKind.Utc);
            DateTime fingconvert = DateTime.SpecifyKind(fing, DateTimeKind.Local);
            Console.WriteLine(ringconvert.Kind);
            Console.WriteLine(fingconvert.Kind);

            */
            //=======================DateTime Formatting=================
            DateTime calender = DateTime.Now;
            string convertTOstring = calender.ToString("dd/MM/yyyy");
            string convertTOstring1 = calender.ToString("dddd-MMMM-yyyy");
            string convertTOstring2 = calender.ToString("Y");//(month and year only)------
            string convertTOstring3 = calender.ToString("ddd/MMM/yyy");
            Console.WriteLine(convertTOstring);
            Console.WriteLine(convertTOstring1);
            Console.WriteLine(convertTOstring2);
            Console.WriteLine(convertTOstring3);
            string co = calender.ToString("M");
            Console.WriteLine(co);
            string co1 = calender.ToString("f");
            Console.WriteLine(co1);
            string co2 = calender.ToString("F");
            Console.WriteLine(co2);
            string co3 = calender.ToString("g");
            Console.WriteLine(co3);
            string co4 = calender.ToString("G");
            Console.WriteLine(co4);
            string co5 = calender.ToString("d");
            Console.WriteLine(co5);
            string co6 = calender.ToString("D");
            Console.WriteLine(co6);
            string co7 = calender.ToString("t");
            Console.WriteLine(co7);
            string co8 = calender.ToString("T");
            Console.WriteLine(co8);
            string time = calender.ToString("hh-mm-ss tt");
            Console.WriteLine(time);
            string time1 = calender.ToString("HH:mm:FFF tt");
            Console.WriteLine(time1);




        }
    }
}