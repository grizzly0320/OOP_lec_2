using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lec_2 
{

    public class TrigComplex : Complex
    {
        private double r, phi;
        public TrigComplex(double r, double phi)
            : base(r * Math.Cos(phi), r * Math.Sin(phi))
        {
            this.r = r;
            this.phi = phi;
        }
        public TrigComplex(Complex z)
            : base(z)
        {
            phi = Math.Atan(Im / Re);
            if (re < 0)
            {
                phi += im >= 0 ? Math.PI : -Math.PI;
            }
            r = Math.Sqrt(Re * Re + Im * Im);
        }
        public static TrigComplex operator +(TrigComplex first, TrigComplex second)
        {
            return new TrigComplex((first as Complex) + second);
        }
        public override string ToString()
        {
            return r + "(Cos(" + phi + ") + i Sin(" + phi + ")";
        }
    }
    public class Complex
    {
        protected static int count = 0;
        protected int index;
        public static int Count
        {
            get => count;

        }
        public double? this[char part]
        {
            get
            {
                if (part == 'r' || part == 'R') return Re;
                if (part == 'i' || part == 'I') return Im;
                return null;
            }
            set
            {
                if (part == 'r' || part == 'R') Re = value ?? 0;
                if (part == 'i' || part == 'I') Im = value ?? 0;
            }
        }
        public Complex()
        {
            count++;
            index = count;
        }
        protected double re, im;
        //Конструктор по умолчанию
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
            count++;
            index = count;
        }
        //Конструктор копирования
        public Complex(Complex other)
        {
            Re = other.Re;
            Im = other.Im;
            count++;
            index = count;
        }
        /*Свойство - это типо элементов класса, который используется для получения и задания значений полей класса,
        либо для получения величин вычисляемых на основе класса; занимаю промежуточное значение между полями и методами*/
        //Автореализуемое свойство - совмещает свойства поля и метода 
        public double Re {
            get => re;
            set => re = value;
        }

        public double Im {
            get => im;
            set => im = value;
        }
        public double roIM => im; //readonly im
        public double Abs => Math.Sqrt(Re * Re + Im * Im);
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(index);
            sb.Append("):");
            if (Math.Abs(Re) > 10 * double.Epsilon || Math.Abs(Im) < 10 * double.Epsilon)
                sb.Append(Re);
            if (Math.Abs(Im) > 10 * double.Epsilon)
            {
                sb.Append(Im > 0 ? "+" : "-");
                if (Math.Abs(Math.Abs(Im) - 1) > 10 * double.Epsilon)
                {
                    sb.Append(Math.Abs(Im));
                }
                sb.Append("i");
            }
            return sb.ToString();
        }
        public Complex Plus(Complex other) => new Complex(this.Re + other.Re, Im + other.Im);
        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.Re + z2.Re, z1.Im + z2.Im);
        }
        public static Complex operator -(Complex z1, Complex z2) => new Complex(z1.Re - z2.Re, z1.Im - z2.Im);
        public static Complex operator -(Complex z1) =>
            new(z1.Re, -z1.Im);
        public static bool operator ==(Complex it, Complex other)
        {
            return Math.Abs(it.Re - other.Re) < 1e-25 &&
                Math.Abs(it.Im - other.Im) < 1e-25;
        }
        public override bool Equals(object? obj)
        {
            //if (obj == null) return false;
            //if (obj.GetType() != typeof(Complex)) return false;
            //Complex x = (Complex)obj;
            if (obj is Complex x)
                return Math.Abs(Re - x.Re) < 1e-25 &&
                    Math.Abs(Im - x.Im) < 1e-25;
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Re, Im);
        }
        public static bool operator !=(Complex it, Complex other) => !(it == other);
        // Операторы, окторые можно перегрузить
        // Унарные операторы:
        // +, -, !, ~, ++, --
        // Бинарные операторы:
        // +, -, *, /, %
        // Операторы сравнения:
        // ==, !=, <, >, <=, >=
        // Поразрядные операторы:
        // &, |, ^, <<, >>
        // Логические операторы:
        // &&, ||
    }
}
