using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Laba1
{
    internal class Vector
    {
        double x,y,z;
        public Vector() // Конструктор за замовченням
        {
            x = 1; y = 1; z = 1;
        }
        public Vector(double x, double y, double z) // Конструктор ініціалізації
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector(double a, double b) // Координати вектора в діапазоні
        {
            Random random = new Random();
            x = random.NextDouble() * (b - a) + a;
            y = random.NextDouble() * (b - a) + a;
            z = random.NextDouble() * (b - a) + a;
        }
        public double get_X()
        {
            return x;
        }
        public double get_Y()
        {
            return y;
        }
        public double get_Z()
        {
            return z;
        }
        // Додавання векторів
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
        }
        // Віднімання векторів
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        }
        // Скалярний добуток
        public static double DotProduct(Vector vector1, Vector vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
        }
        // Довжина вектора
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
