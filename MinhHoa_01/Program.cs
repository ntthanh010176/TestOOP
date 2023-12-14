using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoa_01
{
    struct Diem {
      public int x;
      public int y;
    }

    class Program
    {
        static void nhap(ref Diem p)
        {
            Console.Write("Nhap hoanh do x:");
            p.x = int.Parse(Console.ReadLine());
            Console.Write("Nhap tung do y:");
            p.y = int.Parse(Console.ReadLine());
        }

        static void xuat(Diem p, string name)
        {
            Console.WriteLine("{0}({1},{2})", name, p.x, p.y);
        }
        static void Main(string[] args)
        {
            Diem p1= new Diem(), p2= new Diem();
            nhap(ref p1);
            nhap(ref p2);
            xuat(p1,"A");
            xuat(p2,"B");
            Console.ReadLine();
        }
    }
}
