namespace ProgramTest.Tests.PhoneSystem
{
    public class PhoneSystemV1 : IPhoneSystem
    {
        protected override string CalculateAmount(PhoneSystemType phone)
        {
            if (phone.Time <= 0 || phone.Time > 31 * 24 * 60)
            {
                return "无效的通话时间";
            }
            if (phone.NTimeout < 0 || phone.NTimeout > 11)
            {
                return "无效的延时缴费次数";
            }
            double discount = 0.0;
            if (phone.Time <= 60 && phone.NTimeout <= 1)
            {
                discount = 0.01;
            }
            else if (phone.Time <= 120 && phone.NTimeout <= 2)
            {
                discount = 0.015;
            }
            else if (phone.Time <= 180 && phone.NTimeout <= 3)
            {
                discount = 0.02;
            }
            else if (phone.Time <= 300 && phone.NTimeout <= 3)
            {
                discount = 0.025;
            }
            else if (phone.NTimeout <= 6)
            {
                discount = 0.03;
            }

            return (25 + 0.15 * phone.Time * (1 - discount)).ToString();
        }
    }
}
