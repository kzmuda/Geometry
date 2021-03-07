namespace Codecool.Geometry.Shapes
{
    public interface IShape
    {
        double GetArea();
        double GetPerimeter();
        string GetAreaFormula();
        string GetPerimeterForumla();
    }
}