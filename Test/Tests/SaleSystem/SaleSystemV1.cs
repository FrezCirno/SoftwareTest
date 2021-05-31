namespace ProgramTest.Tests.SaleSystem
{
	class SaleSystemV1: ISaleSystem
	{
		protected override double CalculateAmount(SaleSystemType sale)
		{
			int attribute = 0;  // 佣金系数
		    double result = 0;  // 佣金
		    if(sale.Amount > 200 && sale.FreeDay <= 10){
		        if(sale.Cash >= 60) {
		            attribute = 7;
		            result = sale.Amount / attribute;
		        }
		    } else {
		        if(sale.Cash <= 85) {
		            attribute = 6;
		            result = sale.Amount / attribute;
		        } else {
		            attribute = 5;
		            result = sale.Amount / attribute;
		        }
		    }
		    
		    return result;
		}
	}
}
