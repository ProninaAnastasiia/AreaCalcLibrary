using AreaCalcLibrary;
namespace AreaCalcLibraryTests;

public class UnitTests
{
    [Fact]
    public void Circle_CalculateArea_CorrectResult()
    {
        double radius = 5;
        double expectedArea = Math.PI * radius * radius;
        var circle = new Circle(radius);

        double actualArea = circle.CalculateArea();

        Assert.Equal(expectedArea, actualArea);
    }
    
    [Fact]
    public void Triangle_CalculateArea_CorrectResult()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        double expectedArea = 6;
        var triangle = new Triangle(sideA, sideB, sideC);

        double actualArea = triangle.CalculateArea();

        Assert.Equal(expectedArea, actualArea);
    }
    
    [Fact]
    public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        bool expectedIsRight = true;
        var triangle = new Triangle(sideA, sideB, sideC);

        bool actualIsRight = triangle.IsRightTriangle();

        Assert.Equal(expectedIsRight, actualIsRight);
    }
}