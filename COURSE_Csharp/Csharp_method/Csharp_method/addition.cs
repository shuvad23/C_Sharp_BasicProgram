namespace Csharp_method
{
    public class addition
    {
        public int value1;
        public int value2;
        public int value3;
        public int value4;
        public int value5;
        public int value6;
        public int Numbers;
        //this is the method overloading-------------------------
        public void sum(int x,int y)
        {
            this.value1 = x;
            this.value2 = y;
        }
        public void sum(int x, int y, int z)
        {
            this.sum(x, y);
            this.value3 = z;
        }
        public void sum(int a,int b,int c,int x,int y,int z)
        {
            this.sum(a, b);
            this.sum(a, b, c);
            this.value6 = z;
        }

        //---------------------using params----------------------------
        public int add(params int[] numbers)
        {
            this.Numbers = 0;
            foreach (var num in numbers)
            {
                this.Numbers += num;
            }
            return this.Numbers;
        }

    }
}
