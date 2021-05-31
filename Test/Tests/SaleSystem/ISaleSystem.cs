namespace ProgramTest.Tests.SaleSystem
{
    public struct SaleSystemType
    {
        public double Amount { get; set; }
        public int FreeDay { get; set; }
        public int Cash { get; set; }
    }
    public abstract class ISaleSystem : ITestable<SaleSystemType, double>
    {
        protected abstract double CalculateAmount(SaleSystemType x);
        public double Test(SaleSystemType x)
        {
            return CalculateAmount(x);
        }
    }
}