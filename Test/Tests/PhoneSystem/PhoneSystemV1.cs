namespace ProgramTest.Tests.PhoneSystem
{
    public class PhoneSystemV1 : IPhoneSystem
    {
        protected override string CalculateAmount(PhoneSystemType phone)
        {
            if (phone.MonthTalkTime <= 0 || phone.MonthTalkTime > 31 * 24 * 60)
            {
                return "无效的通话时间";
            }
            if (phone.YearUnpaidNum < 0 || phone.YearUnpaidNum > 11)
            {
                return "无效的延时缴费次数";
            }
            double discount = 0.0;
            if (phone.MonthTalkTime <= 60 && phone.YearUnpaidNum <= 1)
            {
                discount = 0.01;
            }
            else if (phone.MonthTalkTime <= 120 && phone.YearUnpaidNum <= 2)
            {
                discount = 0.015;
            }
            else if (phone.MonthTalkTime <= 180 && phone.YearUnpaidNum <= 3)
            {
                discount = 0.02;
            }
            else if (phone.MonthTalkTime <= 300 && phone.YearUnpaidNum <= 3)
            {
                discount = 0.025;
            }
            else if (phone.YearUnpaidNum <= 6)
            {
                discount = 0.03;
            }

            return (25 + 0.15 * phone.MonthTalkTime * (1 - discount)).ToString();
        }
    }
}
