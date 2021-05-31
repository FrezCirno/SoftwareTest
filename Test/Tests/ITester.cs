using System;
using System.Collections;

namespace ProgramTest.Tests
{
    public struct TestResultInfo
    {
        public int PassedCase;//成功数量
        public int FailedCase;//失败数量
    }

    public struct TestCaseInfo
    {
        public Type TestCaseType;
        public Type TestResultType;
        public IDictionary TestCases;
        public IDictionary TestExpected;
        public IDictionary TestResults;
    }
    
    public interface ITester
    {
        TestCaseInfo TestCaseInfo { get; }
        TestResultInfo TestResultInfo { get; }
        void StartTest();
    }
}