namespace Csharp_method
{
    public class version
    {
        public string appName;
        public string appversion;
        public int price;
        public int publishyear;

        public version(string app,string versionname,int pricevalue,int year) //this is the constractor-------
        {
            this.appName = app;
            this.appversion = versionname;
            this.price = pricevalue;
            this.publishyear = year;
        }
        public void count(string app, string versionname, int pricevalue, int year)
        {
            this.appName = app;
            this.appversion = versionname;
            this.price = pricevalue;
            this.publishyear = year;
        }

        public void count(version newLocation)
        {
            count(newLocation.appName, newLocation.appversion,newLocation.price,newLocation.publishyear);
        }
    }
}
