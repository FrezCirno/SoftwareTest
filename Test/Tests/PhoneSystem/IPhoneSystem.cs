namespace ProgramTest.Tests.PhoneSystem
{
    public struct PhoneSystemType
    {
        public double Time { get; set; }
        public int NTimeout { get; set; }
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