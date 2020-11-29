using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
             Adress a = new Adress(1, "Ukraine", "Kyiv", "Dankevicha", "16", 91);
             Console.WriteLine(a);


            Rectangle b = new Rectangle(12, 2);
             b.AreaCalulator(12, 2);
             Console.WriteLine(b.Area);


             Book a = new Book();
            a.addauthor();
           a.addcontent();
            a.addtitle();


             Point a=new Point(12,2,"re");
             Point b = new Point(1,23,"rsfge");
             Point c = new Point(22, 34, "rgs");
             Figure f = new Figure(a, b, c);
             f.LengthSide(a, b);
             f.PerimeterCalculator(a, b, c);
            User a = new User("defsdf@gmail.com", "ivan", "Petyx", 20, DateTime.Now);
            Console.WriteLine(a);
            Employee a = new Employee("bla", "balvich","director");
            a.EmployeeInfo();
        }
    }
}
