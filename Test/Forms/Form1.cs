using System.Collections.Generic;
using System.Linq;
using ProgramTest.Tests;
using ProgramTest.Tests.Calender;
using ProgramTest.Tests.Commission;
using ProgramTest.Tests.PhoneSystem;
using ProgramTest.Tests.SaleSystem;
using ProgramTest.Tests.Triangle;
using Sunny.UI;

namespace ProgramTest.Forms
{
    public partial class Form1 : UIHeaderAsideMainFrame
    {
        private readonly Dictionary<TestId, ITester> _testTable = new Dictionary<TestId, ITester>();

        public Form1()
        {
            InitializeComponent();
            Aside.TabControl = MainTabControl;
            LoadTest();

            int pageIndex = 1000;
            _testTable.GroupBy(item => item.Key.Name)
                .ForEach(group =>
                {
                    var name = group.Key;
                    AddPage(new Form2(group), pageIndex);
                    Aside.CreateNode(name.ToString(), pageIndex++);
                });
        }

        private void LoadTest()
        {
            _testTable[new TestId(TestName.三角形, "v1", TestMethod.边界值)] = new Tester<Triangle, TriangleType, string>(
                new TriangleV1(), "Triangle_Boundary_Testcase.json", "Triangle_Boundary_Expected_Result.json",
                "Triangle_Boundary_Result.json");
            _testTable[new TestId(TestName.三角形, "v1", TestMethod.等价类)] = new Tester<Triangle, TriangleType, string>(
                new TriangleV1(), "Triangle_Equivalent_Testcase.json", "Triangle_Equivalent_Expected_Result.json",
                "Triangle_Equivalent_Result.json");
            _testTable[new TestId(TestName.三角形, "v2", TestMethod.边界值)] = new Tester<Triangle, TriangleType, string>(
                new TriangleV2(), "Triangle_Boundary_Testcase.json", "Triangle_Boundary_Expected_Result.json",
                "Triangle_Boundary_Result_v2.json");
            _testTable[new TestId(TestName.三角形, "v2", TestMethod.等价类)] = new Tester<Triangle, TriangleType, string>(
                new TriangleV2(), "Triangle_Equivalent_Testcase.json", "Triangle_Equivalent_Expected_Result.json",
                "Triangle_Equivalent_Result_v2.json");
            _testTable[new TestId(TestName.佣金问题, "v1", TestMethod.边界值)] =
                new Tester<ICommission, CommissionType, double>(new CommissionV1(), "Commission_Boundary_Testcase.json",
                    "Commission_Boundary_Expected_Result.json", "Commission_Boundary_Result.json");
            _testTable[new TestId(TestName.佣金问题, "v2", TestMethod.边界值)] =
                new Tester<ICommission, CommissionType, double>(new CommissionV2(), "Commission_Boundary_Testcase.json",
                    "Commission_Boundary_Expected_Result.json", "Commission_Boundary_Result_v2.json");
            /*_testTable[new TestId(TestName.销售问题, "v1", TestMethod.路径测试)] =
                new Tester<ISaleSystem, SaleSystemType, double>(new SaleSystemV1(),
                    "SaleSystem_Statement_Testcase.json", "SaleSystem_Statement_Expected_Result.json",
                    "SaleSystem_Statement_Result.json");
            _testTable[new TestId(TestName.销售问题, "v1", TestMethod.分支测试)] =
                new Tester<ISaleSystem, SaleSystemType, double>(new SaleSystemV1(), "SaleSystem_Branch_Testcase.json",
                    "SaleSystem_Branch_Expected_Result.json", "SaleSystem_Branch_Result.json");
            _testTable[new TestId(TestName.销售问题, "v1", TestMethod.简单条件测试)] =
                new Tester<ISaleSystem, SaleSystemType, double>(new SaleSystemV1(),
                    "SaleSystem_SimpleCondition_Testcase.json", "SaleSystem_SimpleCondition_Expected_Result.json",
                    "SaleSystem_SimpleCondition_Result.json");
            _testTable[new TestId(TestName.销售问题, "v1", TestMethod.分支条件测试)] =
                new Tester<ISaleSystem, SaleSystemType, double>(new SaleSystemV1(),
                    "SaleSystem_DecisionCondition_Testcase.json", "SaleSystem_DecisionCondition_Expected_Result.json",
                    "SaleSystem_DecisionCondition_Result.json");
            _testTable[new TestId(TestName.销售问题, "v1", TestMethod.复杂条件测试)] =
                new Tester<ISaleSystem, SaleSystemType, double>(new SaleSystemV1(),
                    "SaleSystem_MultipleCondition_Testcase.json", "SaleSystem_MultipleCondition_Expected_Result.json",
                    "SaleSystem_MultipleCondition_Result.json");*/
            _testTable[new TestId(TestName.电话系统, "v1", TestMethod.边界值)] =
                new Tester<IPhoneSystem, PhoneSystemType, string>(new PhoneSystemV1(),
                    "PhoneSystem_Boundary_Testcase.json", "PhoneSystem_Boundary_Expected_Result.json",
                    "PhoneSystem_Boundary_Result.json");
            _testTable[new TestId(TestName.电话系统, "v1", TestMethod.等价类)] =
                new Tester<IPhoneSystem, PhoneSystemType, string>(new PhoneSystemV1(),
                    "PhoneSystem_Equivalent_Testcase.json", "PhoneSystem_Equivalent_Expected_Result.json",
                    "PhoneSystem_Equivalent_Result.json");
            _testTable[new TestId(TestName.电话系统, "v1", TestMethod.决策表)] =
                new Tester<IPhoneSystem, PhoneSystemType, string>(new PhoneSystemV1(),
                    "PhoneSystem_Decision_Testcase.json", "PhoneSystem_Decision_Expected_Result.json",
                    "PhoneSystem_Decision_Result.json");
            _testTable[new TestId(TestName.万年历, "v1", TestMethod.边界值)] = new Tester<ICalender, CalenderType, string>(
                new CalenderV1(), "Calender_Boundary_Testcase.json", "Calender_Boundary_Expected_Result.json",
                "Calender_Boundary_Result.json");
            _testTable[new TestId(TestName.万年历, "v1", TestMethod.等价类)] = new Tester<ICalender, CalenderType, string>(
                new CalenderV1(), "Calender_Equivalent_Testcase.json", "Calender_Equivalent_Expected_Result.json",
                "Calender_Equivalent_Result.json");
            _testTable[new TestId(TestName.万年历, "v2", TestMethod.边界值)] = new Tester<ICalender, CalenderType, string>(
                new CalenderV2(), "Calender_Boundary_Testcase.json", "Calender_Boundary_Expected_Result.json",
                "Calender_Boundary_Result_v2.json");
            _testTable[new TestId(TestName.万年历, "v2", TestMethod.等价类)] = new Tester<ICalender, CalenderType, string>(
                new CalenderV2(), "Calender_Equivalent_Testcase.json", "Calender_Equivalent_Expected_Result.json",
                "Calender_Equivalent_Result_v2.json");
        }
    }
}