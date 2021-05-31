namespace ProgramTest.Tests.Commission
{
	public class CommissionV1 : ICommission
	{
		protected override double CalculateCommission(CommissionType commissionType)
		{
			int saleroom = 0;
			int flag; // ???
			double commission = 0;
			if (commissionType.Host <= 0 || commissionType.Monitor <= 0 || commissionType.Peripheral <= 0)
			{
				flag = 0;
				// print("必须至少销售一台完整计算机")
			}

			//17.1;17.2;17.3
			else if (commissionType.Host > 70 || commissionType.Monitor > 80 || commissionType.Peripheral > 90)
			{
				commission = -1;
				flag = 0;
				// print("销售超过库存")
			}

			else
			{
				saleroom = commissionType.Host * 25 + commissionType.Monitor * 30 + commissionType.Peripheral * 45;
				flag = -1;
			}

			if (flag == -1)
			{
				if (saleroom <= 1000)
				{
					commission = saleroom * 0.1;
				}
				else if (saleroom <= 1800)
				{
					commission = saleroom * 0.15;
				}
				else
				{
					commission = saleroom * 0.2;
				}
			}

			return commission;
		}
	}
}
