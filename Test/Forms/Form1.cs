using Sunny.UI;
using System.Collections.Generic;
using System.Linq;
using ProgramTest.Tests;


namespace ProgramTest
{
    public partial class Form1 : UIHeaderAsideMainFrame
    {
        private readonly Dictionary<TestId, Test> testTable;
        public Form1()
        {
            InitializeComponent();
            Aside.TabControl = MainTabControl;

            testTable = new Dictionary<TestId, Test>();
            this.LoadTest();

            int pageIndex = 1000;
            testTable.GroupBy(item => item.Key.name)
                .ForEach(group =>
                {
                    var name = group.Key;
                    AddPage(new Form2(name, group), pageIndex);
                    Aside.CreateNode(name.ToString(), pageIndex++);
                });
        }

        private void LoadTest()
        {
            testTable[new TestId(TestName.万年历, "v1", TestMethod.边界值)] = new CalenderBoundaryTest();
            testTable[new TestId(TestName.万年历, "v2", TestMethod.边界值)] = new CalenderBoundaryTest2();
            testTable[new TestId(TestName.万年历, "v1", TestMethod.等价类)] = new CalenderEquivalentTest();
            testTable[new TestId(TestName.万年历, "v2", TestMethod.等价类)] = new CalenderEquivalentTest2();
            testTable[new TestId(TestName.三角形, "v1", TestMethod.边界值)] = new TriangleBoundaryTest();
            testTable[new TestId(TestName.三角形, "v2", TestMethod.边界值)] = new TriangleBoundaryTest2();
            testTable[new TestId(TestName.三角形, "v1", TestMethod.等价类)] = new TriangleEquivalentTest();
            testTable[new TestId(TestName.三角形, "v2", TestMethod.等价类)] = new TriangleEquivalentTest2();
            testTable[new TestId(TestName.佣金问题, "v1", TestMethod.边界值)] = new ComissionBoundaryTest();
            testTable[new TestId(TestName.佣金问题, "v2", TestMethod.边界值)] = new ComissionBoundaryTest2();
            testTable[new TestId(TestName.销售问题, "v1", TestMethod.路径测试)] = new SaleSystemStatementTest();
            testTable[new TestId(TestName.销售问题, "v1", TestMethod.分支测试)] = new SaleSystemBranchTest();
            testTable[new TestId(TestName.销售问题, "v1", TestMethod.简单条件测试)] = new SaleSystemSimpleConditionTest();
            testTable[new TestId(TestName.销售问题, "v1", TestMethod.分支条件测试)] = new SaleSystemDicisionConditionTest();
            testTable[new TestId(TestName.销售问题, "v1", TestMethod.复杂条件测试)] = new SaleSystemMultipleConditionTest();
            testTable[new TestId(TestName.电话系统, "v1", TestMethod.综合测试)] = new PhoneSystemBranchTest();
        }
    }
}
