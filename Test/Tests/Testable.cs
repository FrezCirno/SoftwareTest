namespace ProgramTest.Tests
{
    public interface ITestable<in TIn, out TOut>
    {
        TOut Test(TIn tIn);
    }
}