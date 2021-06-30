namespace ProgramTest.Tests.PhoneSystem
{
    public struct PhoneSystemType
    {
        public double MonthTalkTime { get; set; }
        public int YearUnpaidNum { get; set; }
    }

    public abstract class IPhoneSystem : ITestable<PhoneSystemType, string>
    {
        protected abstract string CalculateAmount(PhoneSystemType x);
        public string Test(PhoneSystemType x)
        {
            return CalculateAmount(x);
        }
    }
}