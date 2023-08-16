using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingTask
{
    public class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double CalculateArea()
        {
            // Используем формулу Герона для вычисления площади треугольника
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public bool IsRightTriangle()
        {
            // Проверяем теорему Пифагора для определения прямоугольного треугольника
            return Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                   Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side2, 2) ||
                   Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2);
        }
    }
}
