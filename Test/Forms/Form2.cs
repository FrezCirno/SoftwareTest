using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProgramTest.Tests;
using Sunny.UI;

namespace ProgramTest.Forms
{
    public partial class Form2 : UITitlePage
    {
        private readonly IGrouping<TestName, KeyValuePair<TestId, ITester>> _group;

        public Form2(IGrouping<TestName, KeyValuePair<TestId, ITester>> group)
        {
            InitializeComponent();
            _group = group;

            TestName.Items.Add(group.Key.ToString());
            TestName.SelectedIndex = 0;

            group.GroupBy(kv => kv.Key.Version)
                .ForEach(group1 => { testVersion.Items.Add(group1.Key); });

            group.GroupBy(kv => kv.Key.Method)
                .ForEach(group1 => { testMethod.Items.Add(group1.Key); });
        }


        //点击开始测试按钮，根据问题和方法选定测试类进行测试
        private void StartButton_Click(object sender, EventArgs e)
        {
            dataGridView.ClearAll();
            if (testMethod.SelectedItem == null || testVersion.SelectedItem == null)
            {
                UIMessageBox.Show("请选择测试方法以及测试版本");
            }
            else
            {
                DoTest((TestMethod) testMethod.SelectedItem, (string) testVersion.SelectedItem);
            }
        }

        //将测试与图表显示代码抽象为该函数
        //四个参数分别是总数量，成功数量，失败数量以及测试的类
        private void DoTest(TestMethod testMethod, string testVersion)
        {
            var kvtest = _group.First(item => item.Key.Version == testVersion && item.Key.Method == testMethod);
            var test = kvtest.Value;
            test.StartTest();
            UIMessageBox.Show("测试已经完成");
            SetChart(test);
            SetDataView(test);
        }

        private void SetChart(ITester t)
        {
            var option = new UIPieOption
            {
                //设置Title
                Title = new UITitle
                {
                    Text = "测试结果",
                    SubText = "饼图",
                    Left = UILeftAlignment.Center
                },
                //设置ToolTip
                ToolTip = new UIPieToolTip
                {
                    Visible = true
                },
                //设置Legend
                Legend = new UILegend
                {
                    Orient = UIOrient.Vertical,
                    Top = UITopAlignment.Top,
                    Left = UILeftAlignment.Left
                }
            };

            //option.Legend.AddData("总测试用例数量");
            option.Legend.AddData("成功用例数量");
            option.Legend.AddData("失败用例数量");

            //设置Series
            var series = new UIPieSeries
            {
                Name = "测试结果",
                Center = new UICenter(50, 55),
                Radius = 70,
                Label = new UIPieSeriesLabel
                {
                    Show = true
                }
            };

            //增加数据
            //series.AddData("总测试用例数量", t.resultInfo.totalCase);
            series.AddData("成功用例数量", t.TestResultInfo.PassedCase);
            series.AddData("失败用例数量", t.TestResultInfo.FailedCase);

            //增加Series
            option.Series.Add(series);

            //设置Option
            pieChart.SetOption(option);
        }

        private void SetDataView(ITester t)
        {
            Type testCaseType = t.TestCaseInfo.TestCaseType;
            Type testResultType = t.TestCaseInfo.TestResultType;
            var testCases = t.TestCaseInfo.TestCases;

            dataGridView.AddColumn("测试Id", "id");
            testCaseType.GetProperties().ForEach(prop => { dataGridView.AddColumn(prop.Name, prop.Name); });

            if (testResultType.IsPrimitive || testResultType == typeof(decimal) || testResultType == typeof(string))
            {
                dataGridView.AddColumn("预期结果", "expect");
                dataGridView.AddColumn("实际结果", "result");
            }
            else
            {
                testResultType.GetProperties().ForEach(prop => { dataGridView.AddColumn("expect_" + prop.Name, "expect_" + prop.Name); });
                testResultType.GetProperties().ForEach(prop => { dataGridView.AddColumn("result_" + prop.Name, "result_" + prop.Name); });
            }
            dataGridView.AddColumn("测试结果", "isPassed");
            dataGridView.AddColumn("测试时间", "time");
            dataGridView.AddColumn("测试人", "who");

            foreach (DictionaryEntry entry in testCases)
            {
                var key = entry.Key;
                var testCase = entry.Value;
                var expect = t.TestCaseInfo.TestExpected[key];
                var result = t.TestCaseInfo.TestResults[key];

                var row = new List<object>();
                row.Add(key);

                testCaseType.GetProperties().ForEach(prop => { row.Add(prop.GetValue(testCase)); });
                if (testResultType.IsPrimitive || testResultType == typeof(decimal) || testResultType == typeof(string))
                {
                    row.Add(expect);
                    row.Add(result);
                }
                else
                {
                    testResultType.GetProperties().ForEach(prop => { row.Add(prop.GetValue(expect)); });
                    testResultType.GetProperties().ForEach(prop => { row.Add(prop.GetValue(result)); });
                }

                row.Add(expect.Equals(result));
                row.Add(DateTime.Now);
                row.Add("User1");
                dataGridView.AddRow(row.ToArray());
            }
        }

        private void On_resetButton_Click(object sender, EventArgs e)
        {
            testVersion.Clear();
            testMethod.Clear();
            dataGridView.ClearAll();
        }
    }
}