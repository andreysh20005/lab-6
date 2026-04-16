internal class Program
{
    private static void Main(string[] args)
    {
        Nums a = new Nums();
        Nums b = new Nums(-1, -9, 5);
        Nums c = new Nums(b);


        Console.WriteLine("пустой конструктор: "+a);
        Console.WriteLine("конструктор с параметрами (int, int, int): "+b);
        Console.WriteLine("копирующий конструктор: " + c);

        Console.WriteLine("метод произведения всех полей:");
        Console.WriteLine(a.Multiply());
        Console.WriteLine(b.Multiply());
        Console.WriteLine(c.Multiply());
        Console.WriteLine();
        Console.WriteLine("дочерний класс - класс для решения квадраных уравнний");
        QuadraticEquation aa = new QuadraticEquation();
        QuadraticEquation bb = new QuadraticEquation(1000, -2000, 3);
        QuadraticEquation cc = new QuadraticEquation(b);
        QuadraticEquation dd = new QuadraticEquation(bb);

        Console.WriteLine("по смыслу, у квадратного уравнения для одного набора чисел только одно решение + мы не меняем поля. Поэтому, дискриминант и корни уравнения вычисляются в момент вызова конструктора сразу");
        Console.WriteLine();
        Console.WriteLine("пустой конструктор: " + aa);
        Console.WriteLine(aa.PrintAnsver());
        Console.WriteLine("конструктор с 3 параметрами (int, int, int): " + bb);
        Console.WriteLine(bb.PrintAnsver());
        Console.WriteLine("конструктор, копирующий поля из родительского класса (Nums): " + cc);
        Console.WriteLine(cc.PrintAnsver());
        Console.WriteLine("копирующий конструктор: " + dd);
        Console.WriteLine(dd.PrintAnsver());

        Console.WriteLine("так же есть доступ через свойства к полям, но только на чтение");
        Console.WriteLine("на примере второго квадратного уравнения");
        Console.WriteLine("a = " + bb.A + "; b = " + bb.B + "; C = " + bb.C);
        Console.WriteLine("D = " + bb.D); 
        Console.WriteLine("x1 = " + bb.X1);
        Console.WriteLine("x2 = " + bb.X2);

        Console.WriteLine("мы всё ещё можем вызывать методы родительского класса");
        Console.WriteLine(bb.Multiply());
    }
}