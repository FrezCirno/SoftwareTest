using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest.Tests
{
    using TestVersion = String;
    public enum TestName { 万年历 = 0, 三角形 = 1, 佣金问题 = 2, 销售问题 = 3, 电话系统 = 4 };
    public enum TestMethod { 边界值 = 0, 等价类 = 1, 路径测试 = 2, 分支测试 = 3, 简单条件测试 = 4, 分支条件测试 = 5, 复杂条件测试 = 6, 综合测试 = 7 };
    public struct TestId
    {
        public TestName name;
        public TestVersion version;
        public TestMethod method;

        public TestId(TestName name, TestVersion version, TestMethod method)
        {
            this.name = name;
            this.version = version;
            this.method = method;
        }
    }
}
