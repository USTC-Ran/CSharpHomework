using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public abstract class BaseShape
    {
        public abstract void draw();
        public abstract void area(int[]parm);
    }
    public class Triangle : BaseShape
    {
        public override void draw()
        {
            Console.WriteLine("画三角形");
        }
        public override void area(int[]parm)
        {
            int a = parm[0];
            int b = parm[1];
            int c = parm[2];
            double p = (a + b + c) / 2;
            double s = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("三角形三边为：" + a + "、" + b + "、" + c + "，面积为：" + s);
        }
    }
    public class Circle:BaseShape
    {
        public override void draw()
        {
            Console.WriteLine("画圆形");
        }
        public override void area(int[]parm)
        {
            int r = parm[0];
            double s = 3.1415926 * r * r;
            Console.WriteLine("圆形半径为：" + r + "，面积为：" + s);
        }
    }
    public class Square : BaseShape
    {
        public override void draw()
        {
            Console.WriteLine("画正方形");
        }
        public override void area(int[] parm)
        {
            int a = parm[0];
            double s = a * a;
            Console.WriteLine("正方形边长为：" + a + "，面积为：" + s);
        }
    }
    public class Rectangle : BaseShape
    {
        public override void draw()
        {
            Console.WriteLine("画长方形");
        }
        public override void area(int[] parm)
        {
            int a = parm[0];
            int b = parm[1];
            double s = a * b;
            Console.WriteLine("长方形长和宽为：" + a + "、" + b + "，面积为：" + s);
        }
    }
    public class ShapeFactpry
    {
        public static BaseShape CreateShape(string shapeName)
        {
            switch(shapeName)
            {
                case "三角形":
                    return new Triangle();
                case "圆形":
                    return new Circle();
                case "正方形":
                    return new Square();
                case "长方形":
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseShape shape1 = ShapeFactpry.CreateShape("三角形");
            shape1.draw();
            shape1.area(new int[3] { 6, 7, 8 });
            BaseShape shape2 = ShapeFactpry.CreateShape("圆形");
            shape2.draw();
            shape2.area(new int[1] { 5 });
            BaseShape shape3 = ShapeFactpry.CreateShape("正方形");
            shape3.draw();
            shape3.area(new int[1] { 5 });
            BaseShape shape4 = ShapeFactpry.CreateShape("长方形");
            shape4.draw();
            shape4.area(new int[2] { 5, 6 });
        }
    }
}
