namespace AreaCalcLibrary;

public class Triangle: IShape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Длины сторон должны быть положительными числами.");
        }

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }
    
    public double CalculateArea()
    {
        double semiperimeter = (_sideA + _sideB + _sideC) / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
        if(IsRightTriangle()) Console.WriteLine("Треугольник прямоугольный.");
        return area;
    }
    
    public bool IsRightTriangle()
    {
        double[] sides = { _sideA, _sideB, _sideC };
        Array.Sort(sides);

        double a = sides[0];
        double b = sides[1];
        double c = sides[2];

        bool isRight = Math.Abs(c * c - (a * a + b * b)) < 0.0001; // Проверка с использованием Math.Abs и сравнением с погрешностью нужна из-за погрешностей в вычислениях с плавающей точкой

        return isRight;
    }
    
}