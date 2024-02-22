namespace AreaCalcLibrary;

public class Circle: IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным числом.");
        }

        _radius = radius;
    }
    
    public double CalculateArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}