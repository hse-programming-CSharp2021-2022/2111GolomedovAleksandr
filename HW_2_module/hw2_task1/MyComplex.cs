using System;

namespace hw2_task1
{
    public class MyComplex
    {
        public double re, im;

        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public static MyComplex operator --(MyComplex mc)
            => new MyComplex(mc.re - 1, mc.im - 1);

        public double Mod() => Math.Abs(re * re + im * im);

        public static bool operator true(MyComplex f) => f.Mod() > 1.0;

        public static bool operator false(MyComplex f) => f.Mod() <= 1.0;

        public static MyComplex operator +(MyComplex l, MyComplex r)
            => new MyComplex(l.re + r.re, l.im + r.im);
        
        public static MyComplex operator -(MyComplex l, MyComplex r)
            => new MyComplex(l.re - r.re, l.im - r.im);
        
        public static MyComplex operator *(MyComplex l, MyComplex r)
            => new MyComplex(l.re * r.re - l.im * r.im,
                             l.im * r.re + l.re * r.im);
        
        public static MyComplex operator /(MyComplex l, MyComplex r)
        {
            double newRe = (l.re * r.re + l.im * r.im) / 
                           (r.re * r.re + r.im * r.im);
            double newIm = (l.im * r.re - l.re * r.im) / 
                           (r.re * r.re + r.im * r.im);
            return new MyComplex(newRe, newIm);
        }
    }
}