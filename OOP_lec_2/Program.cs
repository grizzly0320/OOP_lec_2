using static System.Console;
using OOP_lec_2;

TrigComplex tz1 = new TrigComplex(1, 0.5);
TrigComplex tz2 = new TrigComplex(1, -1.5);
var tz3 = tz1 + tz2;
WriteLine(tz3);
WriteLine(new Complex(tz3));

//Complex z1 = new Complex();
//WriteLine(Complex.Count);
//Complex z2 = new Complex(3, -5);
//WriteLine(Complex.Count);
//Complex z3 = new Complex(z2);
//Complex z4 = z2;
//z2.Im = -1;
//WriteLine(z1.Abs);
//WriteLine(z2.Abs);
//WriteLine(z3.Abs);
//WriteLine(z4.Abs);
//WriteLine(z1);
//WriteLine(z2);
//WriteLine(z3);
//WriteLine(z4);
//Complex z5 = z2.Plus(z3);
//WriteLine(z5);
//Complex z6 = z3 + z2;
//WriteLine(z6);
//WriteLine(-z6);
//z6 += z4;
//WriteLine(z6);

//WriteLine();
//int? i1 = null;
//if (i1 != null)
//{
//    int i11 = (int)i1;
//    int i2 = i11 + 1;
//}
//if (i1 is { } i12)
//{
//    int i2 = i12 + 1;
//}
//var i3 = 1 + i1 ?? 0;
//Complex? zz = null;
//WriteLine(zz?.Re.ToString() ?? "null");
//int xx = default;
//WriteLine(xx);
//int[] mas = new int[3];

//MyClass mc = new();
//mc.AddData(10);
//mc.AddData(2, 4, 6, 8, 10);
//(int a, int b, int c) = mc.GetElems();

//Person p = new("Иван", 23);
//(string name, int age) = p;

//class MyClass
//{
//    private List<int> data = new();
//    public void AddData(int elem)
//    {
//        data.Add(elem);
//    }
//    public void AddData(List<int> elems)
//    {
//        data.AddRange(elems);
//    }

//    public void AddData(params int[] elems)
//    {
//        data.AddRange(elems);
//    }
//    public int[]  GetElems()
//    {
//        return new[] { data[0], data[1], data[2] }; 
//    }
//} 

//class Person{
//    private string name;
//    private int age;
//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public void Deconstruct(out string pName, out int pAge)
//    {
//        pName = name;
//        pAge = age;
//    }
//}