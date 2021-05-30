using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramTest.Tests;

namespace ProgramTest.Tests
{
    public partial class Form2 : UITitlePage
    {
        private readonly TestName name;
        private readonly IGrouping<TestName, KeyValuePair<TestId, Tests.Test>> group;

        public Form2(TestName name, IGrouping<TestName, KeyValuePair<TestId, Tests.Test>> group)
        {
            InitializeComponent();
            this.name = name;
            this.group = group;
            this.ShowTitle = false;

            TestName.Items.Add(name.ToString());
            TestName.SelectedIndex = 0;

            group.GroupBy(kv => kv.Key.version)
                .ForEach(group1 =>
                {
                    testVersion.Items.Add(group1.Key);
                });

            group.GroupBy(kv => kv.Key.method)
                .ForEach(group1 =>
                {
                    testMethod.Items.Add(group1.Key);
                });
        }


        //点击开始测试按钮，根据问题和方法选定测试类进行测试
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (testMethod.SelectedItem == null || testVersion.SelectedItem == null)
            {
                UIMessageBox.Show("请选择测试方法以及测试版本");
            }
            else
            {
                DoTest((TestMethod)testMethod.SelectedItem, (string)testVersion.SelectedItem);
            }
        }

        //将测试与图表显示代码抽象为该函数
        //四个参数分别是总数量，成功数量，失败数量以及测试的类
        private void DoTest(TestMethod testMethod, string testVersion)
        {
            KeyValuePair<TestId, Test> test = group.First(item => item.Key.version == testVersion && item.Key.method == testMethod);
            test.Value.StartTest();
            UIMessageBox.Show("测试已经完成");
            SetChart(test.Value);
        }

        private void SetChart(Test t)
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
            series.AddData("成功用例数量", t.resultInfo.successCase);
            series.AddData("失败用例数量", t.resultInfo.failCase);

            //增加Series
            option.Series.Add(series);

            //设置Option
            chart1.SetOption(option);
        }
    }
}
