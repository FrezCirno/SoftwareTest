using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProgramTest.Tests
{
    //所有测试类的基类
    public class Tester<T, TIn, TOut> : ITester where T : ITestable<TIn, TOut>
    {
        private readonly T _instance;
        private readonly string _testFilePath;
        private readonly string _expectFilePath;
        private readonly string _resultFilePath;
        private static readonly string baseUrl = "Data";
        public TestCaseInfo TestCaseInfo { get; private set; }
        public TestResultInfo TestResultInfo { get; private set; }

        public Tester(T instance, string testFilePath,string expectFilePath, string resultFilePath)
        {
            _instance = instance;
            _testFilePath = Path.Combine(baseUrl, testFilePath);
            _expectFilePath = Path.Combine(baseUrl, expectFilePath);
            _resultFilePath = Path.Combine(baseUrl, resultFilePath);
        }

        private static Dictionary<string, TDt> ReadJsonFile<TDt>(string testFilePath)
        {
            using var r = new StreamReader(testFilePath);
            var json = r.ReadToEnd();
            return JsonConvert.DeserializeObject<Dictionary<string, TDt>>(json);
        }

        private static void WriteResultFile<TDt>(Dictionary<string, TDt> resultDictionary, string resultFilePath)
        {
            var result = JsonConvert.SerializeObject(resultDictionary);
            using var w = new StreamWriter(resultFilePath);
            w.WriteLine(result);
        }

        public void StartTest()
        {
            var testCases = ReadJsonFile<TIn>(_testFilePath);
            var expectedResults = ReadJsonFile<TOut>(_expectFilePath);
            var resultDictionary = new Dictionary<string, TOut>();
            var success = 0;
            foreach (var testCase in testCases)
            {
                var key = testCase.Key;
                var result = _instance.Test(testCase.Value);
                resultDictionary.Add(testCase.Key, result);
                if (expectedResults != null && expectedResults[key].Equals(result))
                    success++;
            }
            WriteResultFile(resultDictionary, _resultFilePath);

            TestCaseInfo = new TestCaseInfo
            {
                TestCaseType = typeof(TIn),
                TestResultType = typeof(TOut),
                TestCases = testCases,
                TestExpected = expectedResults,
                TestResults = resultDictionary
            };
            TestResultInfo = new TestResultInfo
            {
                PassedCase = success,
                FailedCase = testCases.Count - success
            };
        }
    }
}
