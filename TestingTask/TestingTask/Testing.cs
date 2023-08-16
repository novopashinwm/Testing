using NUnit.Framework;

[TestFixture]
public class ShapeTests
{
    [Test]
    public void CalculateArea_Circle_ReturnsCorrectArea()
    {
        double radius = 5;
        Circle circle = new Circle(radius);
        double expectedArea = Math.PI * Math.Pow(radius, 2);

        double actualArea = circle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea);
    }

    [Test]
    public void CalculateArea_Triangle_ReturnsCorrectArea()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        Triangle triangle = new Triangle(side1, side2, side3);
        double expectedArea = 6;

        double actualArea = triangle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea);
    }

    [Test]
    public void IsRightTriangle_Triangle_ReturnsCorrectResult()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        Triangle triangle = new Triangle(side1, side2, side3);

        bool isRightTriangle = triangle.IsRightTriangle();

        Assert.IsTrue(isRightTriangle);
    }
}
