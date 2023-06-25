using System;

namespace App
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        private double h;


        public double A
        {
            get { return a; }
            set { if (a > 0) { a = value; } }
        }
        public double B
        {
            get { return b; }
            set { if (b > 0) { b = value; } }
        }
        public double C
        {
            get { return c; }
            set { if (c > 0) { c = value; } }
        }
        public double H
        {
            get { return h; }
            set { if (h > 0) { h = value; } }
        }
        public Triangle() { }
        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C; 
            h = H;
        }

        public double Area()
        {
            return (a * h) / 2;
        }
        public double Perimeter()
        {
            return a + b + c;
        }
    }

    class Rectangle
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set
            {
                if (a > 0) { a = value; }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b > 0)
                {
                    b = value;
                }
            }
        }

        public Rectangle() { }
        public Rectangle(double A, double B)
        {
            a = A;
            b = B;
        }
        public double Area()
        {
            return a*b;
        }
        public double Perimeter()
        {
            return (a + b) * 2;
        }

    }
    class Squre
    {
        private double a;
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public Squre() { }
        public Squre(double A)
        {
            a = A;
        }
        public double Area()
        {
            return Math.Pow(a, 2);
        }
        public double Perimeter()
        {
            return 4 * a;
        }
    }

    class Circle
    {
        private double r;
        public double R
        {
            get { return r; }
            set
            {
                if (r > 0)
                {
                    r = value;
                }
            }
        }
        public Circle() { }
        public Circle(double r)
        {
            r = R;
        }
        public double Area()
        {
            return (Math.Pow(r, 2) * Math.PI);
        }
        public double Perimeter()
        {
            return (2*r)* Math.PI;
        }

    }
    class Trapezoid
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b > 0)
                {
                    b = value;
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (c > 0)
                {
                    c = value;
                }
            }
        }
        public double D
        {
            get { return d; }
            set
            {
                if (d > 0)
                {
                    d = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (h > 0)
                {
                    h = value;
                }
            }
        }
        public Trapezoid() { }
        public Trapezoid(double A, double B, double C, double D, double H)
        {
            a = A;
            b = B;
            c = C;
            d = D;
            h = H;
        }
        public double Area()
        {
            return ((a + b) / 2) * h;
        }
        public double Perimeter()
        {
            return a + b + c + d;
        }
    }

    class Ellipse
    {
        private double a;
        private double b;
        double pi = 3.14;
        public double A
        {
            get { return a; }
            set
            {
                if (a < 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b < 0)
                {
                    b = value;
                }
            }
        }
        public Ellipse() { }
        public Ellipse(double A, double B)
        {
            a = A;
            b = B;
        }
        public double Area6()
        {
            return pi * a * b;
        }
        public double Perimeter6()
        {
            return (a + b) * pi;
        }
    }
    class Polygon
    {
        private double a;  
        private double n;
        private double h;
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double N
        {
            get { return n; }
            set
            {
                if (n > 0)
                {
                    n = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (h > 0)
                {
                    h = value;
                }
            }
        }
        public Polygon() { }
        public Polygon(double A, double N, double H)
        {
            a = A;
            n = N;
            h = H;
        }
        public double Area()
        {
            return (n * a * h) / 2;
        }
        public double Perimeter()
        {
            return a * n;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose your shape:");
            Console.WriteLine("1-Triangle   2-Squre   3-Rectangle   4-Circle   5-Trapezoid   6-Ellipse   7-Polygon");
            Console.Write("shape number: ");
            double choose = Convert.ToDouble(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Please enter triangle's edges & altitude:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Triangle t1 = new Triangle(a, b, c, h);
                double area = t1.Area();
                Console.Write("Area = ");
                Console.WriteLine(area);
                double perimeter = t1.Perimeter();
                Console.Write("Perimeter = ");
                Console.WriteLine(perimeter);
            }
            else if (choose == 2)
            {
                Console.WriteLine("Please enter the squre's edge:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Squre sqrue = new Squre(a);
                double area = sqrue.Area();
                Console.Write("Area = ");
                Console.WriteLine(area);
                double perimeter = sqrue.Perimeter();
                Console.Write("Perimeter = ");
                Console.WriteLine(perimeter);
            }
            else if (choose == 3)
            {
                Console.WriteLine("Please enter the Rectangle's edges:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Rectangle rectangle = new Rectangle(a, b);
                double area = rectangle.Area();
                Console.Write("Area = ");
                Console.WriteLine(area);
                double permiter = rectangle.Perimeter();
                Console.Write("Perimeter = ");
                Console.WriteLine(permiter);
            }
            else if (choose == 4)
            {
                Console.WriteLine("Please enter the Circle's radius:");
                Console.Write("r = ");
                double r = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(r);
                double area = circle.Area();
                Console.Write("Area = ");
                Console.WriteLine(area);
                double perimeter = circle.Perimeter();
                Console.Write("Perimeter = ");
                Console.WriteLine(perimeter);
            }
            else if (choose == 5)
            {
                Console.WriteLine("Please enter Trapezoid's edges & altitude:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("d = ");
                double d = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Trapezoid trapezoid = new Trapezoid(a, b, c, d, h);
                double area = trapezoid.Area();
                Console.Write("Area = ");
                Console.WriteLine(area);
                double perimeter = trapezoid.Perimeter();
                Console.Write("Perimeter = ");
                Console.WriteLine(perimeter);
            }
            else if (choose == 6)
            {
                Console.WriteLine("Please enter Ellipse's radiuses:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Ellipse ellipse = new Ellipse(a, b);
                double area = ellipse.Area6();
                Console.Write("Area = ");
                Console.WriteLine(area);
                double perimeter = ellipse.Perimeter6();
                Console.Write("Perimeter = ");
                Console.WriteLine(perimeter);
            }
            else if (choose == 7)
            {
                Console.WriteLine("Please enter the number of Ellipse's edge:");
                Console.Write("n = ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter Ellipse's edge & altitude size :");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Polygon polygon = new Polygon(a, n, h);
                double area = polygon.Area();
                Console.Write("Area = ");
                Console.WriteLine(area);
                double perimeter = polygon.Perimeter();
                Console.Write("Perimeter = ");
                Console.WriteLine(perimeter);
            }
            else
            {
                Console.WriteLine("please choose a correct shape!");
            }
        }
    
    }

}