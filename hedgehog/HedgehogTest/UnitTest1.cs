using HedgehogTask;
namespace HedgehogTest;

public class UnitTest1
{
    [Fact]
    public void ResolveableTask()
    {
        Assert.Equal(7, Hedgehog.StepCounter(0, new uint[] {4, 7, 1}));
    }
    [Fact]
    public void UnresolveableTask1()
    {
        Assert.Equal(-1, Hedgehog.StepCounter(0, new uint[] {8, 1, 9}));
    }
    [Fact]
    public void UnresolveableTask2()
    {
        Assert.Equal(-1, Hedgehog.StepCounter(1, new uint[] {8, 1, 9}));
    }
    [Fact]
    public void UnresolveableTask3()
    {
        Assert.Equal(-1, Hedgehog.StepCounter(2, new uint[] {8, 1, 9}));
    }
}