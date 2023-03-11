using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture6
{/// <summary>
 /// Создать класс для подсчета площади треугольников
    //  Pеализовать классы для равнобедренного, равностороннего, прямоугольного и разностороннего треугольника
    //  Для каждого использовать свою формулу для подсчета площади
    //  Площадь разностороннего треугольника считаем по формуле герона
    //  Создать отдельный класс, который будет отвечать за логику создания треугольников. В нем вернуть нужный обьект треугольника проверив его стороны
    //  Добавить класс квадрат и прямоугольник и логику подсчета площади для него
    //  Добавить класс для реализации иерархии фигур 
    //  Создавь массив квадратов, прямоугольник и треугольников и вывести их площади
    /// </summary>
    public class Triangle
    {
        public double firstSide;
        public double secondSide;
        public double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public virtual double GetSquare()
        {
            Console.WriteLine("Get square Heron formula");
            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        }
    }
}