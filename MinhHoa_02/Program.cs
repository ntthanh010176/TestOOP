using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoa_02
{
    class Diem
    {
        private int x;
        private int y;

        public Diem() {
            x = 0;
            y = 0;
        }
        public Diem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void xuat(string name)
        {
            Console.WriteLine("{0}({1},{2})",name,x,y);
        }      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Diem p1 = new Diem();
            p1.setX(2);
            p1.setY(10);
            p1.xuat("A");

            Diem p2 = new Diem();
            p2.setX(7);
            p2.setY(15);
            p2.xuat("B");

            Diem p3 = new Diem();
            p3.setX(10);
            p3.setY(50);
            p3.xuat("C");
            Console.ReadLine();
        }
    }
}
