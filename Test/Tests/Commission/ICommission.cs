namespace ProgramTest.Tests.Commission
{
    public struct CommissionType
    {
        public int Host { get; set; }
        public int Monitor { get; set; }
        public int Peripheral { get; set; }
    }
    public abstract class ICommission : ITestable<CommissionType, double>
    {
        protected abstract double CalculateCommission(CommissionType commissionType);
        public double Test(CommissionType cal)
        {
            return CalculateCommission(cal);
        }
    }
}