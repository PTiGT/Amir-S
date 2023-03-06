using System;
using System.Linq;

class Vector
{
    private double[] elements;

    // Конструкторы
    public Vector(int size)
    {
        elements = new double[size];
    }

    public Vector(double[] values)
    {
        elements = values;
    }

    public Vector(Vector vector)
    {
        elements = vector.elements;
    }

    // Свойство для доступа к элементам массива
    public double this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    // Метод ввода с консоли
    public void ReadFromConsole()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            elements[i] = double.Parse(Console.ReadLine());
        }
    }

    // Метод для вывода вектора в виде строки
    public override string ToString()
    {
        return string.Join(", ", elements);
    }

    // Экземплярный метод для вычисления модуля вектора
    public double GetMagnitude()
    {
        return Math.Sqrt(elements.Select(e => e * e).Sum());
    }

    // Экземплярный метод для получения наибольшего элемента вектора
    public double GetMaxElement()
    {
        return elements.Max();
    }

    // Экземплярный метод для получения индекса наименьшего элемента вектора
    public int GetMinElementIndex()
    {
        return Array.IndexOf(elements, elements.Min());
    }

    // Экземплярный метод для создания нового вектора, состоящего только из положительных элементов
    public Vector GetPositiveElementsVector()
    {
        return new Vector(elements.Where(e => e > 0).ToArray());
    }

    // Статический метод для сложения двух векторов
    public static Vector Add(Vector v1, Vector v2)
    {
        if (v1.elements.Length != v2.elements.Length)
        {
            throw new ArgumentException("Векторы должны быть одинаковой длины");
        }

        double[] result = new double[v1.elements.Length];
        for (int i = 0; i < v1.elements.Length; i++)
        {
            result[i] = v1.elements[i] + v2.elements[i];
        }

        return new Vector(result);
    }

    // Статический метод для вычисления скалярного произведения двух векторов
    public static double DotProduct(Vector v1, Vector v2)
    {
        if (v1.elements.Length != v2.elements.Length)
        {
            throw new ArgumentException("\"Векторы должны быть одинаковой длины");
        }

        double result = 0;
        for (int i = 0; i < v1.elements.Length; i++)
        {
            result += v1.elements[i] * v2.elements[i];
        }

        return result;
    }

    // Статический метод для проверки двух векторов на равенство
    public static bool AreEqual(Vector v1, Vector v2)
    {
        if (v1.elements.Length != v2.elements.Length)
        {
            return false;
        }

        for (int i = 0; i < v1.elements.Length; i++)
        {
            if (v1.elements[i] != v2.elements[i])
            {
                return false;
            }
        }

        return true;
    }

}
