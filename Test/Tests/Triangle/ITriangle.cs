namespace ProgramTest.Tests.Triangle
{
    public struct TriangleType
    {
        public string Side1 { get; set; }
        public string Side2 { get; set; }
        public string Side3 { get; set; }
    }
    public abstract class Triangle : ITestable<TriangleType, string>
    {
        protected abstract string CheckTriangle(TriangleType tri);
        public string Test(TriangleType tri)
        {
            return CheckTriangle(tri);
        }
    }
}