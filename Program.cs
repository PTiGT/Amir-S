using System.Numerics;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(new double[] { 1, 2, 3 });
        Vector v2 = new Vector(new double[] { 4, 5, 6 });

        Console.WriteLine("v1: " + v1.ToString());
        Console.WriteLine("v2: " + v2.ToString());

        Vector v3 = Vector.Add(v1, v2);
        Console.WriteLine("v1 + v2 = " + v3.ToString());

        double dotProduct = Vector.DotProduct(v1, v2);
        Console.WriteLine("v1 * v2 = " + dotProduct);

        bool equal = Vector.AreEqual(v1, v2);
        Console.WriteLine("v1 == v2: " + equal);

        Vector v4 = new Vector(3);
        v4.ReadFromConsole();
        Console.WriteLine("v4: " + v4.ToString());
        Console.WriteLine("Модуль v4: " + v4.GetMagnitude());
        Console.WriteLine("Максимальный элемент v4: " + v4.GetMaxElement());
        Console.WriteLine("Индекс минимального элемента v4: " + v4.GetMinElementIndex());

        Vector v5 = v4.GetPositiveElementsVector();
        Console.WriteLine("v4: " + v5.ToString());

        Console.ReadKey();
    }
}
