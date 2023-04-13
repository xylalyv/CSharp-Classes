using System.Diagnostics;

namespace Class
{
    public class Point
    {
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x { get; set; }
        public int y { get; set; } 
        public string point { get { return $"({x}, {y})"; }}
        public string ShowData()
        {
            return $"{point}";
        }
        public override string ToString() {
            return $"{point}";
        }
    }
    public class Counter
    {
        public Counter()
        {
            min = 0;
            max = 0;
        }
        public Counter(int min, int max)
        {
           this.min = min;
           this.max = max;   
        }
        public int min { get;}
        public int max { get;}
        public  int current_data { get; set;}
        public void increment()
        {
            current_data++;
           if(current_data > max)
           {
                current_data = min;
           }
        }
        public void decrement()
        {
            current_data--;
            if (current_data < min)
            {
                current_data = max;
            }
        }
        public int CurrentData
        {
            get { return current_data; } 
            set { current_data = value; }
        }
        public override string ToString() {
            return $"{current_data}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Point A = new Point();
            A.x = 4;
            A.y = 5;
            Console.WriteLine(A.ToString());
            Console.WriteLine(A.point);
            Counter c = new Counter(0,5);
            c.increment();
            c.increment();
            c.increment();
            c.increment();
            c.increment();
            Console.WriteLine(c.CurrentData);
            c.decrement();
            c.decrement();
            c.decrement();
            c.decrement();
            c.decrement();
            Console.WriteLine(c.CurrentData);
            c.decrement();
            Console.WriteLine(c.CurrentData);


        }
    }
}